using UnityEngine;

public class EssenceSliderHandler
{
	private const string TEXT_FORMAT = "n0";

	private EssenceSliderData _essenceSliderData;

	public EssenceSliderHandler(EssenceSliderData essenceSliderData)
	{
		_essenceSliderData = essenceSliderData;
		essenceSliderData.eventExposer.add_WorkshopModifyTabOpened(EventExposerOnWorkshopModifyTabOpened);
	}

	private void EventExposerOnWorkshopModifyTabOpened(SlotDisplayButtonType obj)
	{
		if (obj == SlotDisplayButtonType.Remnant)
		{
			InitializeSliderDisplay();
		}
	}

	private int GetSliderValue()
	{
		return Mathf.RoundToInt(_essenceSliderData.essenceSlider.value);
	}

	public void SetEssenceValueFromSliderValue()
	{
		int sliderValue = GetSliderValue();
		if (sliderValue >= 1)
		{
			AddEssenceValue(sliderValue);
		}
	}

	public void AddEssenceValue(int value)
	{
		if (_essenceSliderData == null)
		{
			return;
		}
		WorkshopSlotData selectedSlotData = _essenceSliderData.workshopSlotDataModel.GetSelectedSlotData();
		if (selectedSlotData != null)
		{
			EndoskeletonData endoskeleton = selectedSlotData.endoskeleton;
			if (endoskeleton != null)
			{
				endoskeleton.numEssence += value;
				selectedSlotData.UpdateIsDirty();
				selectedSlotData.Save();
				_essenceSliderData.currencyContainer.SpendEssence(value);
				_essenceSliderData.setEndoskeletonConfigRequester.SetEndoskeletonConfig(_essenceSliderData.workshopSlotDataModel.GetSelectedSlotDataIndex(), selectedSlotData.endoskeleton);
				InitializeSliderDisplay();
			}
		}
	}

	private void UpdateSliderDisplay()
	{
		string text = GetSliderValue().ToString("n0");
		if (!(_essenceSliderData.sliderValueText == null))
		{
			_essenceSliderData.sliderValueText.text = text;
		}
	}

	public void Update()
	{
		UpdateSliderDisplay();
		UpdateAddButtonEnable();
	}

	private void UpdateAddButtonEnable()
	{
		if (_essenceSliderData != null)
		{
			_essenceSliderData.addButton.interactable = _essenceSliderData.currencyContainer.Essence > 0;
		}
	}

	public void InitializeSliderDisplay()
	{
		EndoskeletonData endoskeleton = _essenceSliderData.workshopSlotDataModel.GetSelectedSlotData().endoskeleton;
		_essenceSliderData.essenceCurrentText.text = endoskeleton.numEssence.ToString("n0");
		_essenceSliderData.essenceTotalText.text = _essenceSliderData.currencyContainer.Essence.ToString("n0");
		_essenceSliderData.essenceSlider.maxValue = _essenceSliderData.currencyContainer.Essence;
		_essenceSliderData.essenceSlider.value = 0f;
		UpdateSliderDisplay();
		UpdateAddButtonEnable();
	}

	public void OnDestroy()
	{
		_essenceSliderData.eventExposer.remove_WorkshopModifyTabOpened(EventExposerOnWorkshopModifyTabOpened);
	}
}
