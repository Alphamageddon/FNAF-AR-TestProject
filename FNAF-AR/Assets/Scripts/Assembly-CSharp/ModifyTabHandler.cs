using UnityEngine;

public class ModifyTabHandler
{
	private SlotDisplayButtonType _currentTab;

	private readonly ModifyTabHandlerLoadData _data;

	public ModifyTabHandler(ModifyTabHandlerLoadData data)
	{
		_data = data;
		_data.EventExposer.add_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
	}

	private void ShowTab(SlotDisplayButtonType modifyTabType)
	{
		DispatchClosedEvents(_currentTab);
		SwapTabs((int)modifyTabType);
		DispatchOpenedEvents(modifyTabType);
		_currentTab = modifyTabType;
	}

	private void OnWorkshopModifyAssemblyButtonPressed(AssemblyButtonPressedPayload payload)
	{
		ShowTab(payload.ButtonType);
	}

	private void SwapTabs(int index)
	{
		Debug.Log("Swapping to modify tab index - " + index);
		foreach (GameObject assembleTab in _data.AssembleTabs)
		{
			assembleTab.SetActive(_data.AssembleTabs.IndexOf(assembleTab) == index);
		}
	}

	private void DispatchClosedEvents(SlotDisplayButtonType modifyTabType)
	{
		_data.EventExposer.OnWorkshopModifyTabClosed(modifyTabType);
	}

	private void DispatchOpenedEvents(SlotDisplayButtonType modifyTabType)
	{
		_data.EventExposer.OnWorkshopModifyTabOpened(modifyTabType);
	}

	public void OnDestroy()
	{
		DispatchClosedEvents(_currentTab);
		_data.EventExposer.remove_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
	}
}
