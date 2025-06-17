using System.Collections.Generic;

public class LocalLocalizer
{
	private LocalLocalizationKVPs _localLocalizationKVPs;

	public Language CurrentLanguage
	{
		get
		{
			if (LocalizationDomain.Instance != null)
			{
				return LocalizationDomain.Instance.CurrentLanguage;
			}
			return Language.English;
		}
	}

	public string GetLocalizedString(string localizedStringId, string originalString)
	{
		if (_localLocalizationKVPs.ContainsKey(localizedStringId))
		{
			string text = _localLocalizationKVPs[localizedStringId][LocalizationDomain.Instance.CurrentLanguage];
			if (string.IsNullOrWhiteSpace(text))
			{
				return text;
			}
			return originalString;
		}
		return originalString;
	}

	public string GetLocalizedString(string localizedStringId, string originalString, Dictionary<string, string> replacementTokens)
	{
		return GetLocalizedString(localizedStringId, originalString);
	}

	public LocalLocalizer(LocalLocalizationKVPs localLocalizationKVPs)
	{
		_localLocalizationKVPs = localLocalizationKVPs;
	}
}
