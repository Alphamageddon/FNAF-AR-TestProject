using UnityEngine;
using UnityEngine.UI;

public class WorkshopCanvasSwapper : MonoBehaviour
{
	[Header("Buttons")]
	[SerializeField]
	private Button AssembleButton;

	[SerializeField]
	private Button ModifyBackButton;

	[Header("Canvases")]
	[SerializeField]
	private GameObject WorkshopCanvas;

	[SerializeField]
	private GameObject WorkshopModifyCanvas;

	[Header("SlotSaveHookup")]
	[SerializeField]
	private WorkshopModifyStateUIView uiView;

	private void OnEnable()
	{
		AssembleButton.onClick.RemoveListener(AssembleButtonPressed);
		AssembleButton.onClick.AddListener(AssembleButtonPressed);
		ModifyBackButton.onClick.RemoveListener(ModifyBackButtonPressed);
		ModifyBackButton.onClick.AddListener(ModifyBackButtonPressed);
	}

	private void AssembleButtonPressed()
	{
		WorkshopCanvas.SetActive(value: false);
		WorkshopModifyCanvas.SetActive(value: true);
		uiView.SwitchedToTab();
	}

	private void ModifyBackButtonPressed()
	{
		WorkshopCanvas.SetActive(value: true);
		WorkshopModifyCanvas.SetActive(value: false);
		AssemblyButtonPressedPayload payload = new AssemblyButtonPressedPayload
		{
			ButtonType = SlotDisplayButtonType.None
		};
		MasterDomain.GetDomain().eventExposer.OnWorkshopModifyAssemblyButtonPressed(payload);
		uiView.TabSwitched();
	}
}
