using System;
using System.IO;
using System.Runtime.InteropServices;
using Lachee.IO.Exceptions;

namespace Lachee.IO
{
	public class NamedPipeClientStream : Stream
	{
		private static class Native
		{
			private const string LIBRARY_NAME = "NativeNamedPipe";

			[DllImport("NativeNamedPipe", CallingConvention = CallingConvention.Cdecl, EntryPoint = "createClient")]
			public static extern IntPtr CreateClient();

			[DllImport("NativeNamedPipe", CallingConvention = CallingConvention.Cdecl, EntryPoint = "destroyClient")]
			public static extern void DestroyClient(IntPtr client);

			[DllImport("NativeNamedPipe", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "isConnected")]
			public static extern bool IsConnected([MarshalAs(UnmanagedType.SysInt)] IntPtr client);

			[DllImport("NativeNamedPipe", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "open")]
			public static extern int Open(IntPtr client, [MarshalAs(UnmanagedType.LPStr)] string pipename);

			[DllImport("NativeNamedPipe", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "close")]
			public static extern void Close(IntPtr client);

			[DllImport("NativeNamedPipe", CallingConvention = CallingConvention.Cdecl, EntryPoint = "readFrame")]
			public static extern int ReadFrame(IntPtr client, IntPtr buffer, int length);

			[DllImport("NativeNamedPipe", CallingConvention = CallingConvention.Cdecl, EntryPoint = "writeFrame")]
			public static extern int WriteFrame(IntPtr client, IntPtr buffer, int length);
		}

		private IntPtr ptr;

		private bool _isDisposed;

		public override bool CanRead => true;

		public override bool CanSeek => false;

		public override bool CanWrite => true;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool IsConnected => Native.IsConnected(ptr);

		public string PipeName { get; private set; }

		public NamedPipeClientStream(string server, string pipeName)
		{
			ptr = Native.CreateClient();
			PipeName = FormatPipe(server, pipeName);
			Console.WriteLine("Created new NamedPipeClientStream '{0}' => '{1}'", pipeName, PipeName);
		}

		~NamedPipeClientStream()
		{
			Dispose(disposing: false);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (!_isDisposed)
			{
				Disconnect();
				Native.DestroyClient(ptr);
				_isDisposed = true;
			}
		}

		private static string FormatPipe(string server, string pipeName)
		{
			PlatformID platform = Environment.OSVersion.Platform;
			if (platform == PlatformID.Win32NT || platform != PlatformID.Unix)
			{
				return $"\\\\{server}\\pipe\\{pipeName}";
			}
			if (server != ".")
			{
				throw new PlatformNotSupportedException("Remote pipes are not supported on this platform.");
			}
			return pipeName;
		}

		public void Connect()
		{
			int err = Native.Open(ptr, PipeName);
			if (!IsConnected)
			{
				throw new NamedPipeOpenException(err);
			}
		}

		public void Disconnect()
		{
			Native.Close(ptr);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			if (!IsConnected)
			{
				throw new NamedPipeConnectionException("Cannot read stream as pipe is not connected");
			}
			if (offset + count > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("count", "Cannot read as the count exceeds the buffer size");
			}
			int num = 0;
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(buffer[0]) * count);
			try
			{
				num = Native.ReadFrame(ptr, intPtr, count);
				if (num <= 0)
				{
					if (num < 0)
					{
						throw new NamedPipeReadException(num);
					}
					return 0;
				}
				Marshal.Copy(intPtr, buffer, offset, num);
				return num;
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (!IsConnected)
			{
				throw new NamedPipeConnectionException("Cannot write stream as pipe is not connected");
			}
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(buffer[0]) * count);
			try
			{
				Marshal.Copy(buffer, offset, intPtr, count);
				int num = Native.WriteFrame(ptr, intPtr, count);
				if (num < 0)
				{
					throw new NamedPipeWriteException(num);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}

		public override void Flush()
		{
			throw new NotSupportedException();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}
	}
}
