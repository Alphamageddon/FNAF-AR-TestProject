public class WorkshopSlotDataSaveHandler
{
	private readonly WorkshopSlotDataSaveHandlerLoadData _data;

	public WorkshopSlotDataSaveHandler(WorkshopSlotDataSaveHandlerLoadData data)
	{
		_data = data;
	}

	private void SaveEndoskeletonConfigToServer()
	{
		if (_data.setEndoskeletonConfigRequester != null)
		{
			_data.setEndoskeletonConfigRequester.SetEndoskeletonConfig(_data.workshopSlotDataModel.GetSelectedSlotDataIndex(), _data.workshopSlotDataModel.GetSelectedSlotData().endoskeleton);
		}
	}

	public void OnDisable()
	{
		SaveEndoskeletonConfigToServer();
	}

	public void OnApplicationFocus(bool hasFocus)
	{
		if (!hasFocus)
		{
			SaveEndoskeletonConfigToServer();
		}
	}

	public void OnApplicationPause(bool pauseStatus)
	{
		if (pauseStatus)
		{
			SaveEndoskeletonConfigToServer();
		}
	}
}
