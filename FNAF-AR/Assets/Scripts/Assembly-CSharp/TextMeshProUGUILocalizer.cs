using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMeshProUGUILocalizer : MonoBehaviour
{
	private static Dictionary<string, List<TextMeshProUGUILocalizer>> _textMeshProUGUILocalizersByLocId;

	[SerializeField]
	private string _localizationId;

	private TextMeshProUGUI _textMeshProUgui;

	private string _originalString;

	public static void RedoAllLocalizationLookups()
	{
		foreach (string key in _textMeshProUGUILocalizersByLocId.Keys)
		{
			foreach (TextMeshProUGUILocalizer item in _textMeshProUGUILocalizersByLocId[key])
			{
				item.DoLocalizationNow();
			}
		}
	}

	private static bool EnsureGlobalLookupExists(TextMeshProUGUILocalizer textMeshProUguiLocalizer)
	{
		if (!_textMeshProUGUILocalizersByLocId.ContainsKey(textMeshProUguiLocalizer._localizationId))
		{
			List<TextMeshProUGUILocalizer> list = new List<TextMeshProUGUILocalizer>();
			list.Add(textMeshProUguiLocalizer);
			_textMeshProUGUILocalizersByLocId.Add(textMeshProUguiLocalizer._localizationId, list);
			return false;
		}
		if (_textMeshProUGUILocalizersByLocId[textMeshProUguiLocalizer._localizationId].Contains(textMeshProUguiLocalizer))
		{
			return true;
		}
		_textMeshProUGUILocalizersByLocId[textMeshProUguiLocalizer._localizationId].Add(textMeshProUguiLocalizer);
		return false;
	}

	private void EnsureTextMeshProUGUILink()
	{
		if (_textMeshProUgui == null)
		{
			_textMeshProUgui = base.gameObject.GetComponent<TextMeshProUGUI>();
			_originalString = _textMeshProUgui.text;
		}
		if (!(_textMeshProUgui != null))
		{
			Debug.LogError("TextMeshProUGUILocalizer EnsureTextMeshProUGUILink - Can't find TextMeshProUGUI component on " + base.gameObject.name);
		}
	}

	private void DoLocalizationNow()
	{
		if (!(this == null))
		{
			EnsureTextMeshProUGUILink();
			if (!(_textMeshProUgui == null) && LocalizationDomain.Instance != null)
			{
				LocalizationDomain.Instance.Localization.GetInterfaceAsync(DoLocalizationNowCallback);
			}
		}
	}

	private void DoLocalizationNowCallback(Localization iLocalization)
	{
		if (this == null || _textMeshProUgui == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(iLocalization.GetLocalizedString(_localizationId, _originalString)))
		{
			Debug.LogError("TextMeshProUGUILocalizer DoLocalizationNowCallback - Can't find loc string. localizationId:'" + _localizationId + "' originalString:" + _originalString + " GameObject:" + GetTransformHierarchy(base.transform));
			if (_textMeshProUgui != null)
			{
				_textMeshProUgui.text = _originalString;
			}
		}
		else
		{
			_textMeshProUgui.text = iLocalization.GetLocalizedString(_localizationId, _originalString);
		}
	}

	private static string GetTransformHierarchy(Transform transform)
	{
		if (transform.parent == null)
		{
			return transform.name;
		}
		return transform.parent.name + "/" + transform.name;
	}

	private void Awake()
	{
		if (!EnsureGlobalLookupExists(this))
		{
			DoLocalizationNow();
		}
	}

	static TextMeshProUGUILocalizer()
	{
		_textMeshProUGUILocalizersByLocId = new Dictionary<string, List<TextMeshProUGUILocalizer>>();
	}
}
