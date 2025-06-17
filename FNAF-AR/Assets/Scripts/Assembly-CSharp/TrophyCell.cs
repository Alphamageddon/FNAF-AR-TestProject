using System;
using UnityEngine;
using UnityEngine.UI;

public class TrophyCell : MonoBehaviour
{
	public class TrophyCellData
	{
		public bool playerOwned;

		public TrophyData serverData;

		public Action<TrophyCell, bool> SelectFunction;

		public bool isValid;
	}

	[SerializeField]
	private GameObject highlightObject;

	[SerializeField]
	private Image image;

	[SerializeField]
	private Button button;

	public TrophyCellData trophyCellData;

	public void SetData(TrophyCellData data)
	{
		trophyCellData = data;
		if (trophyCellData.SelectFunction != null)
		{
			button.onClick.AddListener(SetDatab__7_0);
		}
		if (button != null)
		{
			button.interactable = data.isValid && data.playerOwned;
		}
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
		trophyCellData.SelectFunction(this, arg2: false);
	}
}
