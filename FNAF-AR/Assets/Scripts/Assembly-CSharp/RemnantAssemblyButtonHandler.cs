using UnityEngine;

public class RemnantAssemblyButtonHandler
{
	private const string NumberFormat = "n0";

	private readonly RemnantAssemblyButtonHandlerLoadData _data;

	private bool _dataSet;

	public RemnantAssemblyButtonHandler(RemnantAssemblyButtonHandlerLoadData data)
	{
		_dataSet = true;
		_data = data;
		data.EssenceButton.onClick.RemoveListener(ButtonClicked);
		data.EssenceButton.onClick.AddListener(ButtonClicked);
	}

	private void ButtonClicked()
	{
		Debug.Log("Switching to remnant tab");
		if (_data.EventExposer != null)
		{
			AssemblyButtonPressedPayload payload = new AssemblyButtonPressedPayload
			{
				ButtonType = SlotDisplayButtonType.Remnant
			};
			_data.EventExposer.OnWorkshopModifyAssemblyButtonPressed(payload);
		}
	}

	public void Update()
	{
		if (!_dataSet)
		{
			return;
		}
		WorkshopSlotData selectedSlotData = _data.WorkshopSlotDataModel.GetSelectedSlotData();
		if (selectedSlotData != null && selectedSlotData.endoskeleton != null)
		{
			string text = selectedSlotData.endoskeleton.numEssence.ToString("n0");
			if (text != null && _data.EssenceSlotTotalDisplayText != null)
			{
				_data.EssenceSlotTotalDisplayText.text = text;
			}
		}
	}
}
