using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CPUCell : MonoBehaviour
{
	public class CPUCellData
	{
		public bool playerOwned;

		public CPUData serverData;

		public Action<CPUCell, bool> SelectFunction;

		public bool isValid;
	}

	[SerializeField]
	private TextMeshProUGUI userNameText;

	[SerializeField]
	private GameObject highlightObject;

	[SerializeField]
	private Image image;

	[SerializeField]
	private Button button;

	[SerializeField]
	private GameObject unavailableObject;

	public CPUCellData cpuCellData;

	public void SetData(CPUCellData data)
	{
		cpuCellData = data;
		if (cpuCellData.SelectFunction != null)
		{
			button.onClick.AddListener(SetDatab__7_0);
		}
		if (button != null)
		{
			button.interactable = data.isValid && data.playerOwned;
		}
		userNameText.gameObject.SetActive(cpuCellData.playerOwned);
		userNameText.text = MasterDomain.GetDomain().LocalizationDomain.Localization.GetLocalizedString(data.serverData.AnimatronicName, data.serverData.AnimatronicName);
		unavailableObject.SetActive(!data.isValid);
	}

	public string GetIconName()
	{
		Sprite overrideSprite = image.overrideSprite;
		if (overrideSprite == null)
		{
			return "";
		}
		return overrideSprite.name;
	}

	public void SetIcon(Sprite icon)
	{
		if (!(image.overrideSprite == icon))
		{
			image.overrideSprite = icon;
		}
	}

	internal void SetSelected(bool value)
	{
		if (!(highlightObject == null))
		{
			highlightObject.SetActive(value);
		}
	}

	private void SetDatab__7_0()
	{
		cpuCellData.SelectFunction(this, arg2: false);
	}
}
