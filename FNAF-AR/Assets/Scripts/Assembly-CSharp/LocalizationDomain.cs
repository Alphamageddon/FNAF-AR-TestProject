using System;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationDomain
{
	public Localization ILocalization;

	public Action LocalizationLoaded;

	private static LocalizationDomain _localizationDomain;

	private Localization _localization;

	private LocalLocalizer _localLocalization;

	public static LocalizationDomain Instance
	{
		get
		{
			return _localizationDomain;
		}
		set
		{
			if (_localizationDomain != null)
			{
				Debug.LogError("LocalizationDomain Instance - Setting Instance, but one already exists!");
			}
			else
			{
				_localizationDomain = value;
			}
		}
	}

	public Localization Localization => _localization;

	public LocalLocalizer ILocalLocalization => _localLocalization;

	public Language CurrentLanguage
	{
		get
		{
			if (_localization != null)
			{
				return _localization.CurrentLanguage;
			}
			return Language.English;
		}
		set
		{
			_localization.CurrentLanguage = value;
		}
	}

	public bool ShowDebug
	{
		get
		{
			if (_localization != null)
			{
				return _localization.ShowDebug;
			}
			return false;
		}
		set
		{
			_localization.ShowDebug = value;
		}
	}

	public LocalizationDomain()
	{
		Instance = this;
	}

	public void Setup(LocalLocalizationKVPs localLocalizationKVPs)
	{
		_localization = new Localization();
		_localization.GetInterfaceAsync(delegate(Localization localization)
		{
			ILocalization = localization;
			LocalizationLoaded?.Invoke();
		});
		_localLocalization = new LocalLocalizer(localLocalizationKVPs);
	}

	public void OnLocalizationReceived(Dictionary<string, LocDataEntry> locData)
	{
		_localization.Setup(locData);
	}

	public void Teardown()
	{
		_localization.Teardown();
		_localization = null;
		_localLocalization = null;
		_localizationDomain = null;
	}

	public string GetCurrentLanguageCode2()
	{
		_ = CurrentLanguage;
		return "en";
	}
}
