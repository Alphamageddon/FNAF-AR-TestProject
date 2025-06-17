using System;
using System.Linq;
using System.Text;

namespace DiscordRPC.Helper
{
	public static class StringTools
	{
		public static string GetNullOrString(this string str)
		{
			if (str.Length != 0 && !string.IsNullOrEmpty(str.Trim()))
			{
				return str;
			}
			return null;
		}

		public static bool WithinLength(this string str, int bytes)
		{
			return str.WithinLength(bytes, Encoding.UTF8);
		}

		public static bool WithinLength(this string str, int bytes, Encoding encoding)
		{
			return encoding.GetByteCount(str) <= bytes;
		}

		public static string ToCamelCase(this string str)
		{
			return (from s in str?.ToLowerInvariant().Split(new string[2] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
				select char.ToUpper(s[0]) + s.Substring(1, s.Length - 1)).Aggregate(string.Empty, (string s1, string s2) => s1 + s2);
		}

		public static string ToSnakeCase(this string str)
		{
			if (str == null)
			{
				return null;
			}
			return string.Concat(str.Select((char x, int i) => (i <= 0 || !char.IsUpper(x)) ? x.ToString() : ("_" + x)).ToArray()).ToUpperInvariant();
		}
	}
}
