using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using DiscordRPC.Converters;
using DiscordRPC.Events;
using DiscordRPC.Helper;
using DiscordRPC.IO;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using DiscordRPC.RPC.Commands;
using DiscordRPC.RPC.Payload;
using Newtonsoft.Json;

namespace DiscordRPC.RPC
{
	internal class RpcConnection : IDisposable
	{
		public static readonly int VERSION = 1;

		public static readonly int POLL_RATE = 1000;

		private static readonly bool CLEAR_ON_SHUTDOWN = true;

		private static readonly bool LOCK_STEP = false;

		private ILogger _logger;

		private RpcState _state;

		private readonly object l_states = new object();

		private Configuration _configuration;

		private readonly object l_config = new object();

		private volatile bool aborting;

		private volatile bool shutdown;

		private string applicationID;

		private int processID;

		private long nonce;

		private Thread thread;

		private INamedPipeClient namedPipe;

		private int targetPipe;

		private readonly object l_rtqueue = new object();

		private readonly uint _maxRtQueueSize;

		private Queue<ICommand> _rtqueue;

		private readonly object l_rxqueue = new object();

		private readonly uint _maxRxQueueSize;

		private Queue<IMessage> _rxqueue;

		private AutoResetEvent queueUpdatedEvent = new AutoResetEvent(initialState: false);

		private BackoffDelay delay;

		public ILogger Logger
		{
			get
			{
				return _logger;
			}
			set
			{
				_logger = value;
				if (namedPipe != null)
				{
					namedPipe.Logger = value;
				}
			}
		}

		public RpcState State
		{
			get
			{
				lock (l_states)
				{
					return _state;
				}
			}
		}

		public Configuration Configuration
		{
			get
			{
				Configuration configuration = null;
				lock (l_config)
				{
					return _configuration;
				}
			}
		}

		public bool IsRunning => thread != null;

		public bool ShutdownOnly { get; set; }

		public event OnRpcMessageEvent OnRpcMessage;

		public RpcConnection(string applicationID, int processID, int targetPipe, INamedPipeClient client, uint maxRxQueueSize = 128u, uint maxRtQueueSize = 512u)
		{
			this.applicationID = applicationID;
			this.processID = processID;
			this.targetPipe = targetPipe;
			namedPipe = client;
			ShutdownOnly = true;
			Logger = new ConsoleLogger();
			delay = new BackoffDelay(500, 60000);
			_maxRtQueueSize = maxRtQueueSize;
			_rtqueue = new Queue<ICommand>((int)(_maxRtQueueSize + 1));
			_maxRxQueueSize = maxRxQueueSize;
			_rxqueue = new Queue<IMessage>((int)(_maxRxQueueSize + 1));
			nonce = 0L;
		}

		private long GetNextNonce()
		{
			nonce++;
			return nonce;
		}

		internal void EnqueueCommand(ICommand command)
		{
			Logger.Trace("Enqueue Command: {0}", command.GetType().FullName);
			if (aborting || shutdown)
			{
				return;
			}
			lock (l_rtqueue)
			{
				if (_rtqueue.Count == _maxRtQueueSize)
				{
					Logger.Error("Too many enqueued commands, dropping oldest one. Maybe you are pushing new presences to fast?");
					_rtqueue.Dequeue();
				}
				_rtqueue.Enqueue(command);
			}
		}

		private void EnqueueMessage(IMessage message)
		{
			try
			{
				if (this.OnRpcMessage != null)
				{
					this.OnRpcMessage(this, message);
				}
			}
			catch (Exception ex)
			{
				Logger.Error("Unhandled Exception while processing event: {0}", ex.GetType().FullName);
				Logger.Error(ex.Message);
				Logger.Error(ex.StackTrace);
			}
			if (_maxRxQueueSize == 0)
			{
				Logger.Trace("Enqueued Message, but queue size is 0.");
				return;
			}
			Logger.Trace("Enqueue Message: {0}", message.Type);
			lock (l_rxqueue)
			{
				if (_rxqueue.Count == _maxRxQueueSize)
				{
					Logger.Warning("Too many enqueued messages, dropping oldest one.");
					_rxqueue.Dequeue();
				}
				_rxqueue.Enqueue(message);
			}
		}

		internal IMessage DequeueMessage()
		{
			lock (l_rxqueue)
			{
				if (_rxqueue.Count == 0)
				{
					return null;
				}
				return _rxqueue.Dequeue();
			}
		}

		internal IMessage[] DequeueMessages()
		{
			lock (l_rxqueue)
			{
				IMessage[] result = _rxqueue.ToArray();
				_rxqueue.Clear();
				return result;
			}
		}

		private void MainLoop()
		{
			Logger.Info("RPC Connection Started");
			if (Logger.Level <= LogLevel.Trace)
			{
				Logger.Trace("============================");
				Logger.Trace("Assembly:             " + Assembly.GetAssembly(typeof(RichPresence)).FullName);
				Logger.Trace("Pipe:                 " + namedPipe.GetType().FullName);
				Logger.Trace("Platform:             " + Environment.OSVersion.ToString());
				Logger.Trace("applicationID:        " + applicationID);
				Logger.Trace("targetPipe:           " + targetPipe);
				ILogger logger = Logger;
				int pOLL_RATE = POLL_RATE;
				logger.Trace("POLL_RATE:            " + pOLL_RATE);
				ILogger logger2 = Logger;
				uint maxRtQueueSize = _maxRtQueueSize;
				logger2.Trace("_maxRtQueueSize:      " + maxRtQueueSize);
				ILogger logger3 = Logger;
				maxRtQueueSize = _maxRxQueueSize;
				logger3.Trace("_maxRxQueueSize:      " + maxRtQueueSize);
				Logger.Trace("============================");
			}
			while (!aborting && !shutdown)
			{
				try
				{
					if (namedPipe == null)
					{
						Logger.Error("Something bad has happened with our pipe client!");
						aborting = true;
						return;
					}
					Logger.Trace("Connecting to the pipe through the {0}", namedPipe.GetType().FullName);
					if (namedPipe.Connect(targetPipe))
					{
						Logger.Trace("Connected to the pipe. Attempting to establish handshake...");
						EnqueueMessage(new ConnectionEstablishedMessage
						{
							ConnectedPipe = namedPipe.ConnectedPipe
						});
						EstablishHandshake();
						Logger.Trace("Connection Established. Starting reading loop...");
						bool flag = true;
						while (flag && !aborting && !shutdown && namedPipe.IsConnected)
						{
							if (namedPipe.ReadFrame(out var frame))
							{
								Logger.Trace("Read Payload: {0}", frame.Opcode);
								switch (frame.Opcode)
								{
								case Opcode.Close:
								{
									ClosePayload closePayload = frame.GetObject<ClosePayload>();
									Logger.Warning("We have been told to terminate by discord: ({0}) {1}", closePayload.Code, closePayload.Reason);
									EnqueueMessage(new CloseMessage
									{
										Code = closePayload.Code,
										Reason = closePayload.Reason
									});
									flag = false;
									break;
								}
								case Opcode.Ping:
									Logger.Trace("PING");
									frame.Opcode = Opcode.Pong;
									namedPipe.WriteFrame(frame);
									break;
								case Opcode.Pong:
									Logger.Trace("PONG");
									break;
								case Opcode.Frame:
								{
									if (shutdown)
									{
										Logger.Warning("Skipping frame because we are shutting down.");
										break;
									}
									if (frame.Data == null)
									{
										Logger.Error("We received no data from the frame so we cannot get the event payload!");
										break;
									}
									EventPayload eventPayload = null;
									try
									{
										eventPayload = frame.GetObject<EventPayload>();
									}
									catch (Exception ex)
									{
										Logger.Error("Failed to parse event! {0}", ex.Message);
										Logger.Error("Data: {0}", frame.Message);
									}
									try
									{
										if (eventPayload != null)
										{
											ProcessFrame(eventPayload);
										}
									}
									catch (Exception ex2)
									{
										Logger.Error("Failed to process event! {0}", ex2.Message);
										Logger.Error("Data: {0}", frame.Message);
									}
									break;
								}
								default:
									Logger.Error("Invalid opcode: {0}", frame.Opcode);
									flag = false;
									break;
								}
							}
							if (!aborting && namedPipe.IsConnected)
							{
								ProcessCommandQueue();
								queueUpdatedEvent.WaitOne(POLL_RATE);
							}
						}
						Logger.Trace("Left main read loop for some reason. Aborting: {0}, Shutting Down: {1}", aborting, shutdown);
					}
					else
					{
						Logger.Error("Failed to connect for some reason.");
						EnqueueMessage(new ConnectionFailedMessage
						{
							FailedPipe = targetPipe
						});
					}
					if (!aborting && !shutdown)
					{
						long num = delay.NextDelay();
						Logger.Trace("Waiting {0}ms before attempting to connect again", num);
						Thread.Sleep(delay.NextDelay());
					}
				}
				catch (Exception ex3)
				{
					Logger.Error("Unhandled Exception: {0}", ex3.GetType().FullName);
					Logger.Error(ex3.Message);
					Logger.Error(ex3.StackTrace);
				}
				finally
				{
					if (namedPipe.IsConnected)
					{
						Logger.Trace("Closing the named pipe.");
						namedPipe.Close();
					}
					SetConnectionState(RpcState.Disconnected);
				}
			}
			Logger.Trace("Left Main Loop");
			if (namedPipe != null)
			{
				namedPipe.Dispose();
			}
			Logger.Info("Thread Terminated, no longer performing RPC connection.");
		}

		private void ProcessFrame(EventPayload response)
		{
			Logger.Info("Handling Response. Cmd: {0}, Event: {1}", response.Command, response.Event);
			if (response.Event.HasValue && response.Event.Value == ServerEvent.Error)
			{
				Logger.Error("Error received from the RPC");
				ErrorMessage errorMessage = response.GetObject<ErrorMessage>();
				Logger.Error("Server responded with an error message: ({0}) {1}", errorMessage.Code.ToString(), errorMessage.Message);
				EnqueueMessage(errorMessage);
			}
			else if (State == RpcState.Connecting && response.Command == Command.Dispatch && response.Event.HasValue && response.Event.Value == ServerEvent.Ready)
			{
				Logger.Info("Connection established with the RPC");
				SetConnectionState(RpcState.Connected);
				delay.Reset();
				ReadyMessage readyMessage = response.GetObject<ReadyMessage>();
				lock (l_config)
				{
					_configuration = readyMessage.Configuration;
					readyMessage.User.SetConfiguration(_configuration);
				}
				EnqueueMessage(readyMessage);
			}
			else if (State == RpcState.Connected)
			{
				switch (response.Command)
				{
				case Command.Dispatch:
					ProcessDispatch(response);
					break;
				case Command.SetActivity:
				{
					if (response.Data == null)
					{
						EnqueueMessage(new PresenceMessage());
						break;
					}
					RichPresenceResponse rpr = response.GetObject<RichPresenceResponse>();
					EnqueueMessage(new PresenceMessage(rpr));
					break;
				}
				case Command.Subscribe:
				case Command.Unsubscribe:
				{
					new JsonSerializer().Converters.Add(new EnumSnakeCaseConverter());
					ServerEvent value = response.GetObject<EventPayload>().Event.Value;
					if (response.Command == Command.Subscribe)
					{
						EnqueueMessage(new SubscribeMessage(value));
					}
					else
					{
						EnqueueMessage(new UnsubscribeMessage(value));
					}
					break;
				}
				case Command.SendActivityJoinInvite:
					Logger.Trace("Got invite response ack.");
					break;
				case Command.CloseActivityJoinRequest:
					Logger.Trace("Got invite response reject ack.");
					break;
				default:
					Logger.Error("Unkown frame was received! {0}", response.Command);
					break;
				}
			}
			else
			{
				Logger.Trace("Received a frame while we are disconnected. Ignoring. Cmd: {0}, Event: {1}", response.Command, response.Event);
			}
		}

		private void ProcessDispatch(EventPayload response)
		{
			if (response.Command == Command.Dispatch && response.Event.HasValue)
			{
				switch (response.Event.Value)
				{
				case ServerEvent.ActivitySpectate:
				{
					SpectateMessage message3 = response.GetObject<SpectateMessage>();
					EnqueueMessage(message3);
					break;
				}
				case ServerEvent.ActivityJoin:
				{
					JoinMessage message2 = response.GetObject<JoinMessage>();
					EnqueueMessage(message2);
					break;
				}
				case ServerEvent.ActivityJoinRequest:
				{
					JoinRequestMessage message = response.GetObject<JoinRequestMessage>();
					EnqueueMessage(message);
					break;
				}
				default:
					Logger.Warning("Ignoring {0}", response.Event.Value);
					break;
				}
			}
		}

		private void ProcessCommandQueue()
		{
			if (State != RpcState.Connected)
			{
				return;
			}
			if (aborting)
			{
				Logger.Warning("We have been told to write a queue but we have also been aborted.");
			}
			bool flag = true;
			ICommand command = null;
			while (flag && namedPipe.IsConnected)
			{
				lock (l_rtqueue)
				{
					flag = _rtqueue.Count > 0;
					if (!flag)
					{
						break;
					}
					command = _rtqueue.Peek();
				}
				if (shutdown || (!aborting && LOCK_STEP))
				{
					flag = false;
				}
				IPayload payload = command.PreparePayload(GetNextNonce());
				Logger.Trace("Attempting to send payload: {0}", payload.Command);
				PipeFrame frame = default(PipeFrame);
				if (command is CloseCommand)
				{
					SendHandwave();
					Logger.Trace("Handwave sent, ending queue processing.");
					lock (l_rtqueue)
					{
						_rtqueue.Dequeue();
						break;
					}
				}
				if (aborting)
				{
					Logger.Warning("- skipping frame because of abort.");
					lock (l_rtqueue)
					{
						_rtqueue.Dequeue();
					}
					continue;
				}
				frame.SetObject(Opcode.Frame, payload);
				Logger.Trace("Sending payload: {0}", payload.Command);
				if (namedPipe.WriteFrame(frame))
				{
					Logger.Trace("Sent Successfully.");
					lock (l_rtqueue)
					{
						_rtqueue.Dequeue();
					}
					continue;
				}
				Logger.Warning("Something went wrong during writing!");
				break;
			}
		}

		private void EstablishHandshake()
		{
			Logger.Trace("Attempting to establish a handshake...");
			if (State != RpcState.Disconnected)
			{
				Logger.Error("State must be disconnected in order to start a handshake!");
				return;
			}
			Logger.Trace("Sending Handshake...");
			if (!namedPipe.WriteFrame(new PipeFrame(Opcode.Handshake, new Handshake
			{
				Version = VERSION,
				ClientID = applicationID
			})))
			{
				Logger.Error("Failed to write a handshake.");
			}
			else
			{
				SetConnectionState(RpcState.Connecting);
			}
		}

		private void SendHandwave()
		{
			Logger.Info("Attempting to wave goodbye...");
			if (State == RpcState.Disconnected)
			{
				Logger.Error("State must NOT be disconnected in order to send a handwave!");
			}
			else if (!namedPipe.WriteFrame(new PipeFrame(Opcode.Close, new Handshake
			{
				Version = VERSION,
				ClientID = applicationID
			})))
			{
				Logger.Error("failed to write a handwave.");
			}
		}

		public bool AttemptConnection()
		{
			Logger.Info("Attempting a new connection");
			if (thread != null)
			{
				Logger.Error("Cannot attempt a new connection as the previous connection thread is not null!");
				return false;
			}
			if (State != RpcState.Disconnected)
			{
				Logger.Warning("Cannot attempt a new connection as the previous connection hasn't changed state yet.");
				return false;
			}
			if (aborting)
			{
				Logger.Error("Cannot attempt a new connection while aborting!");
				return false;
			}
			thread = new Thread(MainLoop);
			thread.Name = "Discord IPC Thread";
			thread.IsBackground = true;
			thread.Start();
			return true;
		}

		private void SetConnectionState(RpcState state)
		{
			Logger.Trace("Setting the connection state to {0}", state.ToString().ToSnakeCase().ToUpperInvariant());
			lock (l_states)
			{
				_state = state;
			}
		}

		public void Shutdown()
		{
			Logger.Trace("Initiated shutdown procedure");
			shutdown = true;
			lock (l_rtqueue)
			{
				_rtqueue.Clear();
				if (CLEAR_ON_SHUTDOWN)
				{
					_rtqueue.Enqueue(new PresenceCommand
					{
						PID = processID,
						Presence = null
					});
				}
				_rtqueue.Enqueue(new CloseCommand());
			}
			queueUpdatedEvent.Set();
		}

		public void Close()
		{
			if (thread == null)
			{
				Logger.Error("Cannot close as it is not available!");
				return;
			}
			if (aborting)
			{
				Logger.Error("Cannot abort as it has already been aborted");
				return;
			}
			if (ShutdownOnly)
			{
				Shutdown();
				return;
			}
			Logger.Trace("Updating Abort State...");
			aborting = true;
			queueUpdatedEvent.Set();
		}

		public void Dispose()
		{
			ShutdownOnly = false;
			Close();
		}
	}
}
