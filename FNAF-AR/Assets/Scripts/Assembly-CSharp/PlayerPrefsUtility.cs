using System;
using System.Globalization;
using Sabresaurus.PlayerPrefsExtensions;
using UnityEngine;

public static class PlayerPrefsUtility
{
	public const string KEY_PREFIX = "ENC-";

	public const string VALUE_FLOAT_PREFIX = "0";

	public const string VALUE_INT_PREFIX = "1";

	public const string VALUE_STRING_PREFIX = "2";

	public static bool IsEncryptedKey(string key)
	{
		if (key.StartsWith("ENC-"))
		{
			return true;
		}
		return false;
	}

	public static string DecryptKey(string encryptedKey)
	{
		if (encryptedKey.StartsWith("ENC-"))
		{
			return SimpleEncryption.DecryptString(encryptedKey.Substring("ENC-".Length));
		}
		throw new InvalidOperationException("Could not decrypt item, no match found in known encrypted key prefixes");
	}

	public static void SetEncryptedFloat(string key, float value)
	{
		string text = SimpleEncryption.EncryptString(key);
		string text2 = SimpleEncryption.EncryptFloat(value);
		PlayerPrefs.SetString("ENC-" + text, "0" + text2);
	}

	public static void SetEncryptedInt(string key, int value)
	{
		string text = SimpleEncryption.EncryptString(key);
		string text2 = SimpleEncryption.EncryptInt(value);
		PlayerPrefs.SetString("ENC-" + text, "1" + text2);
	}

	public static void SetEncryptedString(string key, string value)
	{
		string text = SimpleEncryption.EncryptString(key);
		string text2 = SimpleEncryption.EncryptString(value);
		PlayerPrefs.SetString("ENC-" + text, "2" + text2);
	}

	public static object GetEncryptedValue(string encryptedKey, string encryptedValue)
	{
		if (encryptedValue.StartsWith("0"))
		{
			return GetEncryptedFloat(SimpleEncryption.DecryptString(encryptedKey.Substring("ENC-".Length)));
		}
		if (encryptedValue.StartsWith("1"))
		{
			return GetEncryptedInt(SimpleEncryption.DecryptString(encryptedKey.Substring("ENC-".Length)));
		}
		if (encryptedValue.StartsWith("2"))
		{
			return GetEncryptedString(SimpleEncryption.DecryptString(encryptedKey.Substring("ENC-".Length)));
		}
		throw new InvalidOperationException("Could not decrypt item, no match found in known encrypted key prefixes");
	}

	public static float GetEncryptedFloat(string key, float defaultValue = 0f)
	{
		string text = PlayerPrefs.GetString("ENC-" + SimpleEncryption.EncryptString(key));
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Remove(0, 1);
			return SimpleEncryption.DecryptFloat(text);
		}
		return defaultValue;
	}

	public static int GetEncryptedInt(string key, int defaultValue = 0)
	{
		string text = PlayerPrefs.GetString("ENC-" + SimpleEncryption.EncryptString(key));
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Remove(0, 1);
			return SimpleEncryption.DecryptInt(text);
		}
		return defaultValue;
	}

	public static string GetEncryptedString(string key, string defaultValue = "")
	{
		string text = PlayerPrefs.GetString("ENC-" + SimpleEncryption.EncryptString(key));
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Remove(0, 1);
			return SimpleEncryption.DecryptString(text);
		}
		return defaultValue;
	}

	public static void SetBool(string key, bool value)
	{
		if (value)
		{
			PlayerPrefs.SetInt(key, 1);
		}
		else
		{
			PlayerPrefs.SetInt(key, 0);
		}
	}

	public static bool GetBool(string key, bool defaultValue = false)
	{
		if (PlayerPrefs.HasKey(key))
		{
			if (PlayerPrefs.GetInt(key) != 0)
			{
				return true;
			}
			return false;
		}
		return defaultValue;
	}

	public static void SetEnum(string key, Enum value)
	{
		PlayerPrefs.SetString(key, value.ToString());
	}

	public static T GetEnum<T>(string key, T defaultValue = default(T)) where T : struct
	{
		string value = PlayerPrefs.GetString(key);
		if (!string.IsNullOrEmpty(value))
		{
			return (T)Enum.Parse(typeof(T), value);
		}
		return defaultValue;
	}

	public static object GetEnum(string key, Type enumType, object defaultValue)
	{
		string value = PlayerPrefs.GetString(key);
		if (!string.IsNullOrEmpty(value))
		{
			return Enum.Parse(enumType, value);
		}
		return defaultValue;
	}

	public static void SetDateTime(string key, DateTime value)
	{
		PlayerPrefs.SetString(key, value.ToString("o", CultureInfo.InvariantCulture));
	}

	public static DateTime GetDateTime(string key, DateTime defaultValue = default(DateTime))
	{
		string text = PlayerPrefs.GetString(key);
		if (!string.IsNullOrEmpty(text))
		{
			return DateTime.Parse(text, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		}
		return defaultValue;
	}

	public static void SetTimeSpan(string key, TimeSpan value)
	{
		PlayerPrefs.SetString(key, value.ToString());
	}

	public static TimeSpan GetTimeSpan(string key, TimeSpan defaultValue = default(TimeSpan))
	{
		string text = PlayerPrefs.GetString(key);
		if (!string.IsNullOrEmpty(text))
		{
			return TimeSpan.Parse(text);
		}
		return defaultValue;
	}
}
