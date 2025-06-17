using System;
using System.Collections.Generic;
using UnityEngine;

public class LocalLocalizationKVPs : MonoBehaviour
{
	[Serializable]
	public class LanguageToStringKVP
	{
		public Language language;

		public string localizedString;
	}

	[Serializable]
	public class LocalLocalizationKVP
	{
		public string Key;

		public List<LanguageToStringKVP> localization;

		public string this[Language key] => localization.Find((LanguageToStringKVP x) => x.language == key).localizedString;

		public bool ContainsKey(Language searchLanguage)
		{
			return localization.Find((LanguageToStringKVP x) => x.language == searchLanguage) != null;
		}
	}

	[SerializeField]
	private List<LocalLocalizationKVP> locKVPs;

	public LocalLocalizationKVP this[string key] => locKVPs.Find((LocalLocalizationKVP x) => x.Key == key);

	public bool ContainsKey(string searchKey)
	{
		return locKVPs.Find((LocalLocalizationKVP x) => x.Key == searchKey) != null;
	}
}
