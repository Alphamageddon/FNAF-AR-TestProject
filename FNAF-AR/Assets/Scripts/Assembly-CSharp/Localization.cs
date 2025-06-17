using System;
using System.Collections.Generic;
using UnityEngine;

public class Localization
{
	public const string PlayerPrefsPreviousSystemLanguageKey = "LocalizationPreviousSystemLanguage";

	public const string PlayerPrefsCurrentLanguageKey = "LocalizationCurrentLanguage";

	private const string PlayerPrefsShowDebugKey = "LocalizationShowDebug";

	private Language _currentLanguage;

	private bool _initialized;

	private bool _showDebug;

	private Dictionary<string, LocDataEntry> _locDataQuickLookup;

	private Action<Localization> callbacks;

	protected bool IsReady => _initialized;

	protected Localization GetPublicInterface => this;

	public bool ShowDebug
	{
		get
		{
			return PlayerPrefs.GetInt("LocalizationShowDebug") != 0;
		}
		set
		{
			int value2 = (value ? 1 : 0);
			PlayerPrefs.SetInt("LocalizationShowDebug", value2);
			_showDebug = value;
		}
	}

	private Language PreviousSystemLanguage
	{
		get
		{
			Language result = Language.English;
			Enum.TryParse<Language>(PlayerPrefs.GetString("LocalizationPreviousSystemLanguage", "None"), out result);
			return result;
		}
		set
		{
			PlayerPrefs.SetString("LocalizationPreviousSystemLanguage", value.ToString());
		}
	}

	public Language CurrentLanguage
	{
		get
		{
			Language result = Language.English;
			Enum.TryParse<Language>(PlayerPrefs.GetString("LocalizationCurrentLanguage", "English"), out result);
			return result;
		}
		set
		{
			PlayerPrefs.SetString("LocalizationCurrentLanguage", value.ToString());
			Language result = Language.English;
			Enum.TryParse<Language>(PlayerPrefs.GetString("LocalizationCurrentLanguage", "English"), out result);
			_currentLanguage = result;
		}
	}

	public Localization()
	{
		_locDataQuickLookup = new Dictionary<string, LocDataEntry>();
		_showDebug = ShowDebug;
		InitCurrentLanguage();
	}

	public void Setup(Dictionary<string, LocDataEntry> locData)
	{
		_locDataQuickLookup = locData;
		_initialized = true;
		TryToDispatchPublicInterface();
	}

	public void Teardown()
	{
		_initialized = false;
		_locDataQuickLookup = null;
	}

	public string GetLocalizedString(string localizedStringId, string originalString)
	{
		if (!_locDataQuickLookup.ContainsKey(localizedStringId))
		{
			if (!_showDebug)
			{
				return originalString;
			}
			return "#>!!" + originalString + "!!<#";
		}
		LocDataEntry locDataEntry = _locDataQuickLookup[localizedStringId];
		string text = _currentLanguage switch
		{
			Language.English => locDataEntry.English, 
			Language.French => locDataEntry.French, 
			Language.Italian => locDataEntry.Italian, 
			Language.German => locDataEntry.German, 
			Language.Spanish_Spain => locDataEntry.SpanishSpain, 
			Language.Portuguese_Brazil => locDataEntry.PortugueseBrazil, 
			Language.Russian => locDataEntry.Russian, 
			_ => null, 
		};
		if (_showDebug)
		{
			bool flag = string.IsNullOrEmpty(text);
			string result = (flag ? "#>!!" : "#>") + (flag ? originalString : text) + (flag ? "!!<#" : "<#");
			if (!flag)
			{
				return result;
			}
			return originalString;
		}
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return originalString;
	}

	public string GetLocalizedString(string localizedStringId, string originalString, Dictionary<string, string> replacementTokens)
	{
		string text = localizedStringId;
		string originalString2 = originalString;
		foreach (string key in replacementTokens.Keys)
		{
			if (key == null)
			{
				return GetLocalizedString(localizedStringId, originalString);
			}
			text = GetLocalizedString(text, originalString2).Replace("<fnaf " + key + " fnaf>", GetLocalizedString(replacementTokens[key], replacementTokens[key]));
			originalString2 = text;
		}
		return text;
	}

	private void InitCurrentLanguage()
	{
		Language currentSystemLanguage = GetCurrentSystemLanguage();
		if (PreviousSystemLanguage != currentSystemLanguage)
		{
			CurrentLanguage = currentSystemLanguage;
			PreviousSystemLanguage = currentSystemLanguage;
		}
		_currentLanguage = currentSystemLanguage;
	}

	private Language GetCurrentSystemLanguage()
	{
		return Application.systemLanguage switch
		{
			SystemLanguage.English => Language.English, 
			SystemLanguage.French => Language.French, 
			SystemLanguage.Italian => Language.Italian, 
			SystemLanguage.German => Language.German, 
			SystemLanguage.Spanish => Language.Spanish_Spain, 
			SystemLanguage.Portuguese => Language.Portuguese_Brazil, 
			SystemLanguage.Russian => Language.Russian, 
			_ => Language.English, 
		};
	}

	public void GetInterfaceAsync(Action<Localization> callback)
	{
		if (IsReady)
		{
			callback(this);
		}
		else
		{
			callbacks = (Action<Localization>)Delegate.Combine(callbacks, callback);
		}
	}

	public void TryToDispatchPublicInterface()
	{
		if (callbacks != null)
		{
			callbacks(this);
		}
	}
}
