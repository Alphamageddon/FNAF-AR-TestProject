using UnityEngine;
using UnityEngine.UI;

public class WorkshopModifyStateUIActions : MonoBehaviour
{
	[SerializeField]
	private WorkshopModifyStateUIView workshopModifyStateUIView;

	[SerializeField]
	private DialogHandler_WorkshopModify _dialogHandlerWorkshopModify;

	[SerializeField]
	private Button modCloseButton;

	private EventExposer _eventExposer;

	private void ConfirmSellSelectedMod(ModCell modCell)
	{
		workshopModifyStateUIView.SellMod(modCell.modContext);
	}

	private void ClearModifyTabs()
	{
		Debug.Log("Cleared modify tabs");
		AssemblyButtonPressedPayload payload = new AssemblyButtonPressedPayload
		{
			ButtonType = SlotDisplayButtonType.None
		};
		_eventExposer.OnWorkshopModifyAssemblyButtonPressed(payload);
	}

	public void ConfirmSetEssenceValue()
	{
		workshopModifyStateUIView.SetEssenceValueFromSlider();
	}

	public void DisplaySellMod(ModCell modCell)
	{
		_dialogHandlerWorkshopModify.ShowSellModDialog(modCell, ConfirmSellSelectedMod);
	}

	public void ShowMoreInfoPlush()
	{
		_dialogHandlerWorkshopModify.ShowMoreInfoPlushDialog();
	}

	public void ShowMoreInfoCPU()
	{
		_dialogHandlerWorkshopModify.ShowMoreInfoCpuDialog();
	}

	public void ShowMoreInfoRemnant()
	{
		_dialogHandlerWorkshopModify.ShowMoreInfoRemnantDialog();
	}

	private void Awake()
	{
		MasterDomain domain = MasterDomain.GetDomain();
		if (domain != null)
		{
			_eventExposer = domain.eventExposer;
		}
		modCloseButton.onClick.RemoveListener(ClearModifyTabs);
		modCloseButton.onClick.AddListener(ClearModifyTabs);
	}
}
