using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DiscordRPC.IO
{
	public struct PipeFrame : IEquatable<PipeFrame>
	{
		public static readonly int MAX_SIZE = 16384;

		public Opcode Opcode { get; set; }

		public uint Length => (uint)Data.Length;

		public byte[] Data { get; set; }

		public string Message
		{
			get
			{
				return GetMessage();
			}
			set
			{
				SetMessage(value);
			}
		}

		public Encoding MessageEncoding => Encoding.UTF8;

		public PipeFrame(Opcode opcode, object data)
		{
			Opcode = opcode;
			Data = null;
			SetObject(data);
		}

		private void SetMessage(string str)
		{
			Data = MessageEncoding.GetBytes(str);
		}

		private string GetMessage()
		{
			return MessageEncoding.GetString(Data);
		}

		public void SetObject(object obj)
		{
			string message = JsonConvert.SerializeObject(obj);
			SetMessage(message);
		}

		public void SetObject(Opcode opcode, object obj)
		{
			Opcode = opcode;
			SetObject(obj);
		}

		public T GetObject<T>()
		{
			return JsonConvert.DeserializeObject<T>(GetMessage());
		}

		public bool ReadStream(Stream stream)
		{
			if (!TryReadUInt32(stream, out var value))
			{
				return false;
			}
			if (!TryReadUInt32(stream, out var value2))
			{
				return false;
			}
			uint num = value2;
			using MemoryStream memoryStream = new MemoryStream();
			uint num2 = (uint)Min(2048, value2);
			byte[] array = new byte[num2];
			int count;
			while ((count = stream.Read(array, 0, Min(array.Length, num))) > 0)
			{
				num -= num2;
				memoryStream.Write(array, 0, count);
			}
			byte[] array2 = memoryStream.ToArray();
			if (array2.LongLength != value2)
			{
				return false;
			}
			Opcode = (Opcode)value;
			Data = array2;
			return true;
		}

		private int Min(int a, uint b)
		{
			if (b >= a)
			{
				return a;
			}
			return (int)b;
		}

		private bool TryReadUInt32(Stream stream, out uint value)
		{
			byte[] array = new byte[4];
			if (stream.Read(array, 0, array.Length) != 4)
			{
				value = 0u;
				return false;
			}
			value = BitConverter.ToUInt32(array, 0);
			return true;
		}

		public void WriteStream(Stream stream)
		{
			byte[] bytes = BitConverter.GetBytes((uint)Opcode);
			byte[] bytes2 = BitConverter.GetBytes(Length);
			byte[] array = new byte[bytes.Length + bytes2.Length + Data.Length];
			bytes.CopyTo(array, 0);
			bytes2.CopyTo(array, bytes.Length);
			Data.CopyTo(array, bytes.Length + bytes2.Length);
			stream.Write(array, 0, array.Length);
		}

		public bool Equals(PipeFrame other)
		{
			if (Opcode == other.Opcode && Length == other.Length)
			{
				return Data == other.Data;
			}
			return false;
		}
	}
}
