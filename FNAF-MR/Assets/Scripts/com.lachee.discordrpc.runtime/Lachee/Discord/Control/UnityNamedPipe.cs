using System;
using System.IO;
using DiscordRPC.IO;
using DiscordRPC.Logging;
using Lachee.IO;

namespace Lachee.Discord.Control
{
	public class UnityNamedPipe : INamedPipeClient, IDisposable
	{
		private const string PIPE_NAME = "discord-ipc-{0}";

		private NamedPipeClientStream _stream;

		private byte[] _buffer = new byte[PipeFrame.MAX_SIZE];

		private volatile bool _isDisposed;

		public ILogger Logger { get; set; }

		public bool IsConnected
		{
			get
			{
				if (_stream != null)
				{
					return _stream.IsConnected;
				}
				return false;
			}
		}

		public int ConnectedPipe { get; private set; }

		public bool Connect(int pipe)
		{
			if (_isDisposed)
			{
				throw new ObjectDisposedException("NamedPipe");
			}
			if (pipe > 9)
			{
				throw new ArgumentOutOfRangeException("pipe", "Argument cannot be greater than 9");
			}
			if (pipe < 0)
			{
				for (int i = 0; i < 10; i++)
				{
					if (AttemptConnection(i) || AttemptConnection(i, doSandbox: true))
					{
						return true;
					}
				}
				return false;
			}
			if (!AttemptConnection(pipe))
			{
				return AttemptConnection(pipe, doSandbox: true);
			}
			return true;
		}

		private bool AttemptConnection(int pipe, bool doSandbox = false)
		{
			if (_stream != null)
			{
				Logger.Error("Attempted to create a new stream while one already exists!");
				return false;
			}
			if (IsConnected)
			{
				Logger.Error("Attempted to create a new connection while one already exists!");
				return false;
			}
			try
			{
				string text = (doSandbox ? GetPipeSandbox() : "");
				if (doSandbox && text == null)
				{
					Logger.Trace("Skipping sandbox because this platform does not support it.");
					return false;
				}
				string pipeName = GetPipeName(pipe);
				Logger.Info("Connecting to " + pipeName + " (" + text + ")");
				ConnectedPipe = pipe;
				_stream = new NamedPipeClientStream(".", pipeName);
				_stream.Connect();
				Logger.Info("Connected");
				return true;
			}
			catch (Exception ex)
			{
				Logger.Error("Failed: " + ex.GetType().FullName + ", " + ex.Message);
				ConnectedPipe = -1;
				Close();
				return false;
			}
		}

		public void Close()
		{
			if (_stream != null)
			{
				Logger.Trace("Closing stream");
				_stream.Dispose();
				_stream = null;
			}
		}

		public void Dispose()
		{
			if (!_isDisposed)
			{
				Logger.Trace("Disposing Stream");
				_isDisposed = true;
				Close();
			}
		}

		public bool ReadFrame(out PipeFrame frame)
		{
			if (_isDisposed)
			{
				throw new ObjectDisposedException("_stream");
			}
			if (!IsConnected)
			{
				frame = default(PipeFrame);
				return false;
			}
			int num = _stream.Read(_buffer, 0, _buffer.Length);
			Logger.Trace("Read {0} bytes", num);
			if (num == 0)
			{
				frame = default(PipeFrame);
				return false;
			}
			using MemoryStream stream = new MemoryStream(_buffer, 0, num);
			frame = default(PipeFrame);
			if (!frame.ReadStream(stream))
			{
				Logger.Error("Failed to read a frame! {0}", frame.Opcode);
				return false;
			}
			Logger.Trace("Read pipe frame!");
			return true;
		}

		public bool WriteFrame(PipeFrame frame)
		{
			if (_isDisposed)
			{
				throw new ObjectDisposedException("_stream");
			}
			if (!IsConnected)
			{
				Logger.Error("Failed to write frame because the stream is closed");
				return false;
			}
			try
			{
				Logger.Trace("Writing frame");
				frame.WriteStream(_stream);
				return true;
			}
			catch (IOException ex)
			{
				Logger.Error("Failed to write frame because of a IO Exception: {0}", ex.Message);
			}
			catch (ObjectDisposedException)
			{
				Logger.Warning("Failed to write frame as the stream was already disposed");
			}
			catch (InvalidOperationException)
			{
				Logger.Warning("Failed to write frame because of a invalid operation");
			}
			return false;
		}

		private string GetPipeName(int pipe, string sandbox = "")
		{
			switch (Environment.OSVersion.Platform)
			{
			default:
				Logger.Trace("PIPE WIN");
				return sandbox + $"discord-ipc-{pipe}";
			case PlatformID.Unix:
			case PlatformID.MacOSX:
				Logger.Trace("PIPE UNIX / MACOSX");
				return Path.Combine(GetEnviromentTemp(), sandbox + $"discord-ipc-{pipe}");
			}
		}

		private string GetPipeSandbox()
		{
			if (Environment.OSVersion.Platform != PlatformID.Unix)
			{
				return null;
			}
			return "snap.discord/";
		}

		private string GetEnviromentTemp()
		{
			object obj = null ?? Environment.GetEnvironmentVariable("XDG_RUNTIME_DIR");
			if (obj == null)
			{
				obj = Environment.GetEnvironmentVariable("TMPDIR");
			}
			if (obj == null)
			{
				obj = Environment.GetEnvironmentVariable("TMP");
			}
			if (obj == null)
			{
				obj = Environment.GetEnvironmentVariable("TEMP");
			}
			if (obj == null)
			{
				obj = "/tmp";
			}
			return (string)obj;
		}
	}
}
