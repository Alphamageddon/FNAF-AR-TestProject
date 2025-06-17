using System;
using System.Security.Cryptography;
using System.Text;

namespace Sabresaurus.PlayerPrefsExtensions
{
	public static class SimpleEncryption
	{
		private static string key = ":{j%6j?E:t#}G10mM%9hp5S=%}2,Y26C";

		private static RijndaelManaged provider = null;

		private static void SetupProvider()
		{
			provider = new RijndaelManaged();
			provider.Key = Encoding.ASCII.GetBytes(key);
			provider.Mode = CipherMode.ECB;
		}

		public static string EncryptString(string sourceString)
		{
			if (provider == null)
			{
				SetupProvider();
			}
			ICryptoTransform cryptoTransform = provider.CreateEncryptor();
			byte[] bytes = Encoding.UTF8.GetBytes(sourceString);
			return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
		}

		public static string DecryptString(string sourceString)
		{
			if (provider == null)
			{
				SetupProvider();
			}
			ICryptoTransform cryptoTransform = provider.CreateDecryptor();
			byte[] array = Convert.FromBase64String(sourceString);
			byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			return Encoding.UTF8.GetString(bytes);
		}

		public static string EncryptFloat(float value)
		{
			return EncryptString(Convert.ToBase64String(BitConverter.GetBytes(value)));
		}

		public static string EncryptInt(int value)
		{
			return EncryptString(Convert.ToBase64String(BitConverter.GetBytes(value)));
		}

		public static float DecryptFloat(string sourceString)
		{
			return BitConverter.ToSingle(Convert.FromBase64String(DecryptString(sourceString)), 0);
		}

		public static int DecryptInt(string sourceString)
		{
			return BitConverter.ToInt32(Convert.FromBase64String(DecryptString(sourceString)), 0);
		}
	}
}
