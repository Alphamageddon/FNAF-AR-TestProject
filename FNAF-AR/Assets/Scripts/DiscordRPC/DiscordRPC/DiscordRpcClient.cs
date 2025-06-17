using System;
using System.Diagnostics;
using DiscordRPC.Events;
using DiscordRPC.Exceptions;
using DiscordRPC.IO;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using DiscordRPC.RPC;
using DiscordRPC.RPC.Commands;
using DiscordRPC.RPC.Payload;
using DiscordRPC.Registry;

namespace DiscordRPC
{
	public sealed class DiscordRpcClient : IDisposable
	{
		private ILogger _logger;

		private RpcConnection connection;

		private bool _shutdownOnly = true;

		private object _sync = new object();

		public bool HasRegisteredUriScheme { get; private set; }

		public string ApplicationID { get; private set; }

		public string SteamID { get; private set; }

		public int ProcessID { get; private set; }

		public int MaxQueueSize { get; private set; }

		public bool IsDisposed { get; private set; }

		public ILogger Logger
		{
			get
			{
				return _logger;
			}
			set
			{
				_logger = value;
				if (connection != null)
				{
					connection.Logger = value;
				}
			}
		}

		public bool AutoEvents { get; private set; }

		public bool SkipIdenticalPresence { get; set; }

		public int TargetPipe { get; private set; }

		public RichPresence CurrentPresence { get; private set; }

		public EventType Subscription { get; private set; }

		public User CurrentUser { get; private set; }

		public Configuration Configuration { get; private set; }

		public bool IsInitialized { get; private set; }

		public bool ShutdownOnly
		{
			get
			{
				return _shutdownOnly;
			}
			set
			{
				_shutdownOnly = value;
				if (connection != null)
				{
					connection.ShutdownOnly = value;
				}
			}
		}

		public event OnReadyEvent OnReady;

		public event OnCloseEvent OnClose;

		public event OnErrorEvent OnError;

		public event OnPresenceUpdateEvent OnPresenceUpdate;

		public event OnSubscribeEvent OnSubscribe;

		public event OnUnsubscribeEvent OnUnsubscribe;

		public event OnJoinEvent OnJoin;

		public event OnSpectateEvent OnSpectate;

		public event OnJoinRequestedEvent OnJoinRequested;

		public event OnConnectionEstablishedEvent OnConnectionEstablished;

		public event OnConnectionFailedEvent OnConnectionFailed;

		public event OnRpcMessageEvent OnRpcMessage;

		public DiscordRpcClient(string applicationID)
			: this(applicationID, -1, null, autoEvents: true, null)
		{
		}

		public DiscordRpcClient(string applicationID, int pipe = -1, ILogger logger = null, bool autoEvents = true, INamedPipeClient client = null)
		{
			if (string.IsNullOrEmpty(applicationID))
			{
				throw new ArgumentNullException("applicationID");
			}
			ApplicationID = applicationID.Trim();
			TargetPipe = pipe;
			ProcessID = Process.GetCurrentProcess().Id;
			HasRegisteredUriScheme = false;
			AutoEvents = autoEvents;
			SkipIdenticalPresence = true;
			_logger = logger ?? new NullLogger();
			connection = new RpcConnection(ApplicationID, ProcessID, TargetPipe, client ?? new ManagedNamedPipeClient(), (!autoEvents) ? 128u : 0u)
			{
				ShutdownOnly = _shutdownOnly,
				Logger = _logger
			};
			connection.OnRpcMessage += delegate(object sender, IMessage msg)
			{
				if (this.OnRpcMessage != null)
				{
					this.OnRpcMessage(this, msg);
				}
				if (AutoEvents)
				{
					ProcessMessage(msg);
				}
			};
		}

		public IMessage[] Invoke()
		{
			if (AutoEvents)
			{
				Logger.Error("Cannot Invoke client when AutomaticallyInvokeEvents has been set.");
				return new IMessage[0];
			}
			IMessage[] array = connection.DequeueMessages();
			foreach (IMessage message in array)
			{
				ProcessMessage(message);
			}
			return array;
		}

		private void ProcessMessage(IMessage message)
		{
			if (message == null)
			{
				return;
			}
			switch (message.Type)
			{
			case MessageType.PresenceUpdate:
				lock (_sync)
				{
					if (message is PresenceMessage presenceMessage)
					{
						if (presenceMessage.Presence == null)
						{
							CurrentPresence = null;
						}
						else if (CurrentPresence == null)
						{
							CurrentPresence = new RichPresence().Merge(presenceMessage.Presence);
						}
						else
						{
							CurrentPresence.Merge(presenceMessage.Presence);
						}
						presenceMessage.Presence = CurrentPresence;
					}
				}
				if (this.OnPresenceUpdate != null)
				{
					this.OnPresenceUpdate(this, message as PresenceMessage);
				}
				break;
			case MessageType.Ready:
				if (message is ReadyMessage readyMessage)
				{
					lock (_sync)
					{
						Configuration = readyMessage.Configuration;
						CurrentUser = readyMessage.User;
					}
					SynchronizeState();
				}
				if (this.OnReady != null)
				{
					this.OnReady(this, message as ReadyMessage);
				}
				break;
			case MessageType.Close:
				if (this.OnClose != null)
				{
					this.OnClose(this, message as CloseMessage);
				}
				break;
			case MessageType.Error:
				if (this.OnError != null)
				{
					this.OnError(this, message as ErrorMessage);
				}
				break;
			case MessageType.JoinRequest:
				if (Configuration != null && message is JoinRequestMessage joinRequestMessage)
				{
					joinRequestMessage.User.SetConfiguration(Configuration);
				}
				if (this.OnJoinRequested != null)
				{
					this.OnJoinRequested(this, message as JoinRequestMessage);
				}
				break;
			case MessageType.Subscribe:
				lock (_sync)
				{
					SubscribeMessage subscribeMessage = message as SubscribeMessage;
					Subscription |= subscribeMessage.Event;
				}
				if (this.OnSubscribe != null)
				{
					this.OnSubscribe(this, message as SubscribeMessage);
				}
				break;
			case MessageType.Unsubscribe:
				lock (_sync)
				{
					UnsubscribeMessage unsubscribeMessage = message as UnsubscribeMessage;
					Subscription &= ~unsubscribeMessage.Event;
				}
				if (this.OnUnsubscribe != null)
				{
					this.OnUnsubscribe(this, message as UnsubscribeMessage);
				}
				break;
			case MessageType.Join:
				if (this.OnJoin != null)
				{
					this.OnJoin(this, message as JoinMessage);
				}
				break;
			case MessageType.Spectate:
				if (this.OnSpectate != null)
				{
					this.OnSpectate(this, message as SpectateMessage);
				}
				break;
			case MessageType.ConnectionEstablished:
				if (this.OnConnectionEstablished != null)
				{
					this.OnConnectionEstablished(this, message as ConnectionEstablishedMessage);
				}
				break;
			case MessageType.ConnectionFailed:
				if (this.OnConnectionFailed != null)
				{
					this.OnConnectionFailed(this, message as ConnectionFailedMessage);
				}
				break;
			default:
				Logger.Error("Message was queued with no appropriate handle! {0}", message.Type);
				break;
			}
		}

		public void Respond(JoinRequestMessage request, bool acceptRequest)
		{
			if (IsDisposed)
			{
				throw new ObjectDisposedException("Discord IPC Client");
			}
			if (connection == null)
			{
				throw new ObjectDisposedException("Connection", "Cannot initialize as the connection has been deinitialized");
			}
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			connection.EnqueueCommand(new RespondCommand
			{
				Accept = acceptRequest,
				UserID = request.User.ID.ToString()
			});
		}

		public void SetPresence(RichPresence presence)
		{
			if (IsDisposed)
			{
				throw new ObjectDisposedException("Discord IPC Client");
			}
			if (connection == null)
			{
				throw new ObjectDisposedException("Connection", "Cannot initialize as the connection has been deinitialized");
			}
			if (!IsInitialized)
			{
				Logger.Warning("The client is not yet initialized, storing the presence as a state instead.");
			}
			if (presence == null)
			{
				if (!SkipIdenticalPresence || CurrentPresence != null)
				{
					connection.EnqueueCommand(new PresenceCommand
					{
						PID = ProcessID,
						Presence = null
					});
				}
			}
			else
			{
				if (presence.HasSecrets() && !HasRegisteredUriScheme)
				{
					throw new BadPresenceException("Cannot send a presence with secrets as this object has not registered a URI scheme. Please enable the uri scheme registration in the DiscordRpcClient constructor.");
				}
				if (presence.HasParty() && presence.Party.Max < presence.Party.Size)
				{
					throw new BadPresenceException("Presence maximum party size cannot be smaller than the current size.");
				}
				if (presence.HasSecrets() && !presence.HasParty())
				{
					Logger.Warning("The presence has set the secrets but no buttons will show as there is no party available.");
				}
				if (!SkipIdenticalPresence || !presence.Matches(CurrentPresence))
				{
					connection.EnqueueCommand(new PresenceCommand
					{
						PID = ProcessID,
						Presence = presence.Clone()
					});
				}
			}
			lock (_sync)
			{
				CurrentPresence = presence?.Clone();
			}
		}

		public RichPresence UpdateButtons(Button[] button = null)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			richPresence.Buttons = button;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence SetButton(Button button, int index = 0)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			richPresence.Buttons[index] = button;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateDetails(string details)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			richPresence.Details = details;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateState(string state)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			richPresence.State = state;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateParty(Party party)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			richPresence.Party = party;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdatePartySize(int size)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			if (richPresence.Party == null)
			{
				throw new BadPresenceException("Cannot set the size of the party if the party does not exist");
			}
			richPresence.Party.Size = size;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdatePartySize(int size, int max)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			if (richPresence.Party == null)
			{
				throw new BadPresenceException("Cannot set the size of the party if the party does not exist");
			}
			richPresence.Party.Size = size;
			richPresence.Party.Max = max;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateLargeAsset(string key = null, string tooltip = null)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			if (richPresence.Assets == null)
			{
				richPresence.Assets = new Assets();
			}
			richPresence.Assets.LargeImageKey = key ?? richPresence.Assets.LargeImageKey;
			richPresence.Assets.LargeImageText = tooltip ?? richPresence.Assets.LargeImageText;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateSmallAsset(string key = null, string tooltip = null)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			if (richPresence.Assets == null)
			{
				richPresence.Assets = new Assets();
			}
			richPresence.Assets.SmallImageKey = key ?? richPresence.Assets.SmallImageKey;
			richPresence.Assets.SmallImageText = tooltip ?? richPresence.Assets.SmallImageText;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateSecrets(Secrets secrets)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			richPresence.Secrets = secrets;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateStartTime()
		{
			return UpdateStartTime(DateTime.UtcNow);
		}

		public RichPresence UpdateStartTime(DateTime time)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			if (richPresence.Timestamps == null)
			{
				richPresence.Timestamps = new Timestamps();
			}
			richPresence.Timestamps.Start = time;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateEndTime()
		{
			return UpdateEndTime(DateTime.UtcNow);
		}

		public RichPresence UpdateEndTime(DateTime time)
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			if (richPresence.Timestamps == null)
			{
				richPresence.Timestamps = new Timestamps();
			}
			richPresence.Timestamps.End = time;
			SetPresence(richPresence);
			return richPresence;
		}

		public RichPresence UpdateClearTime()
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			RichPresence richPresence;
			lock (_sync)
			{
				richPresence = ((CurrentPresence != null) ? CurrentPresence.Clone() : new RichPresence());
			}
			richPresence.Timestamps = null;
			SetPresence(richPresence);
			return richPresence;
		}

		public void ClearPresence()
		{
			if (IsDisposed)
			{
				throw new ObjectDisposedException("Discord IPC Client");
			}
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			if (connection == null)
			{
				throw new ObjectDisposedException("Connection", "Cannot initialize as the connection has been deinitialized");
			}
			SetPresence(null);
		}

		public bool RegisterUriScheme(string steamAppID = null, string executable = null)
		{
			UriSchemeRegister uriSchemeRegister = new UriSchemeRegister(_logger, ApplicationID, steamAppID, executable);
			return HasRegisteredUriScheme = uriSchemeRegister.RegisterUriScheme();
		}

		public void Subscribe(EventType type)
		{
			SetSubscription(Subscription | type);
		}

		[Obsolete("Replaced with Unsubscribe", true)]
		public void Unubscribe(EventType type)
		{
			SetSubscription(Subscription & ~type);
		}

		public void Unsubscribe(EventType type)
		{
			SetSubscription(Subscription & ~type);
		}

		public void SetSubscription(EventType type)
		{
			if (IsInitialized)
			{
				SubscribeToTypes(Subscription & ~type, isUnsubscribe: true);
				SubscribeToTypes(~Subscription & type, isUnsubscribe: false);
			}
			else
			{
				Logger.Warning("Client has not yet initialized, but events are being subscribed too. Storing them as state instead.");
			}
			lock (_sync)
			{
				Subscription = type;
			}
		}

		private void SubscribeToTypes(EventType type, bool isUnsubscribe)
		{
			if (type != EventType.None)
			{
				if (IsDisposed)
				{
					throw new ObjectDisposedException("Discord IPC Client");
				}
				if (!IsInitialized)
				{
					throw new UninitializedException();
				}
				if (connection == null)
				{
					throw new ObjectDisposedException("Connection", "Cannot initialize as the connection has been deinitialized");
				}
				if (!HasRegisteredUriScheme)
				{
					throw new InvalidConfigurationException("Cannot subscribe/unsubscribe to an event as this application has not registered a URI Scheme. Call RegisterUriScheme().");
				}
				if ((type & EventType.Spectate) == EventType.Spectate)
				{
					connection.EnqueueCommand(new SubscribeCommand
					{
						Event = ServerEvent.ActivitySpectate,
						IsUnsubscribe = isUnsubscribe
					});
				}
				if ((type & EventType.Join) == EventType.Join)
				{
					connection.EnqueueCommand(new SubscribeCommand
					{
						Event = ServerEvent.ActivityJoin,
						IsUnsubscribe = isUnsubscribe
					});
				}
				if ((type & EventType.JoinRequest) == EventType.JoinRequest)
				{
					connection.EnqueueCommand(new SubscribeCommand
					{
						Event = ServerEvent.ActivityJoinRequest,
						IsUnsubscribe = isUnsubscribe
					});
				}
			}
		}

		public void SynchronizeState()
		{
			if (!IsInitialized)
			{
				throw new UninitializedException();
			}
			SetPresence(CurrentPresence);
			if (HasRegisteredUriScheme)
			{
				SubscribeToTypes(Subscription, isUnsubscribe: false);
			}
		}

		public bool Initialize()
		{
			if (IsDisposed)
			{
				throw new ObjectDisposedException("Discord IPC Client");
			}
			if (IsInitialized)
			{
				throw new UninitializedException("Cannot initialize a client that is already initialized");
			}
			if (connection == null)
			{
				throw new ObjectDisposedException("Connection", "Cannot initialize as the connection has been deinitialized");
			}
			return IsInitialized = connection.AttemptConnection();
		}

		public void Deinitialize()
		{
			if (!IsInitialized)
			{
				throw new UninitializedException("Cannot deinitialize a client that has not been initalized.");
			}
			connection.Close();
			IsInitialized = false;
		}

		public void Dispose()
		{
			if (!IsDisposed)
			{
				if (IsInitialized)
				{
					Deinitialize();
				}
				IsDisposed = true;
			}
		}
	}
}
