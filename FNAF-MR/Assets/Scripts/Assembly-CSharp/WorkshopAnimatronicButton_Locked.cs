using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopAnimatronicButton_Locked : MonoBehaviour, IWorkshopSlotButton
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Action<WorkshopAnimatronicButton_Locked> buttonCallback;

		public WorkshopAnimatronicButton_Locked _003C_003E4__this;

		internal void _003CInitialize_003Eb__0()
		{
			Action<WorkshopAnimatronicButton_Locked> action = buttonCallback;
			_ = _003C_003E4__this;
			action?.Invoke(_003C_003E4__this);
		}
	}

	[SerializeField]
	[Header("Local Hookups")]
	private GameObject selectedStateImage;

	[SerializeField]
	private TextMeshProUGUI streakUnlockNumText;

	[SerializeField]
	private TextMeshProUGUI fazTokenPriceText;

	[SerializeField]
	private Button thisButton;

	private int _displayNumber;

	[SpecialName]
	GameObject IWorkshopSlotButton.gameObject => base.gameObject;

	public void Initialize(int displayNumber, Action<WorkshopAnimatronicButton_Locked> buttonCallback)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.buttonCallback = buttonCallback;
		_003C_003Ec__DisplayClass6_._003C_003E4__this = this;
		_displayNumber = displayNumber;
		string dataForStreak = displayNumber.ToString();
		SetDataForStreak(dataForStreak);
		thisButton.onClick.AddListener(_003C_003Ec__DisplayClass6_._003CInitialize_003Eb__0);
	}

	public void SetDataForStreak(string streak)
	{
		streakUnlockNumText.transform.parent.gameObject.SetActive(value: true);
		streakUnlockNumText.text = streak;
		fazTokenPriceText.transform.parent.gameObject.SetActive(value: false);
	}

	public void SetDataForPurchase(string price)
	{
		streakUnlockNumText.transform.parent.gameObject.SetActive(value: false);
		fazTokenPriceText.transform.parent.gameObject.SetActive(value: true);
		fazTokenPriceText.text = price;
	}

	public void SetSelectedUI(bool value)
	{
		selectedStateImage.SetActive(value);
	}

	public int GetSortWeight()
	{
		return 10;
	}

	public WorkshopSlotData GetWorkshopSlotData()
	{
		return null;
	}

	public bool IsReadyToCollect()
	{
		return false;
	}

	public void OverrideSlotDataState(WorkshopEntry.Status status)
	{
	}

	public void TearDown()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
