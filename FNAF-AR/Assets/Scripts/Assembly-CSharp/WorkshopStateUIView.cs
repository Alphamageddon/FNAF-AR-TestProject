using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopStateUIView : MonoBehaviour
{
	[SerializeField]
	[Header("Editor Hookups")]
	private SendSelectDialog sendSelectDialog;

	[SerializeField]
	private WorkshopStateUIActions workshopStateUIActions;

	[SerializeField]
	[Header("Select Buttons")]
	private Transform buttonsParent;

	[SerializeField]
	private WorkshopAnimatronicButton workshopAnimatronicButtonPrefab;

	[SerializeField]
	private WorkshopAnimatronicButton_Locked workshopAnimatronicButton_LockedPrefab;

	[SerializeField]
	[Header("CTA Buttons")]
	private Button modifyButton;

	[SerializeField]
	private Button deployButton;

	[SerializeField]
	private Button wearTearButton;

	[SerializeField]
	private GameObject conditionWordDisplay;

	[SerializeField]
	private TextMeshProUGUI deployButtonText;

	[SerializeField]
	private TextMeshProUGUI availableText;

	[SerializeField]
	[Header("Top Display")]
	private TextMeshProUGUI animatronicNameDisplay;

	[SerializeField]
	private TextMeshProUGUI wearTearPercentText;

	private MasterDomain _masterDomain;

	private WorkshopSlotDataModel _workshopSlotDataModel;

	private WorkshopSlotButtonHandler _workshopSlotButtonHandler;

	private WorkshopPageDisplayHandler _workshopPageDisplayHandler;

	private void AddSubcriptions()
	{
		Debug.LogError("adding subbies");
		_masterDomain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(OnConfigDataLoaded);
	}

	private void OnConfigDataLoaded(CONFIG_DATA.Root configDataEntry)
	{
		Debug.LogError("making handler data");
		Debug.LogError("master domain null now?" + (_masterDomain == null));
		CleanUpWorkshopSlotButtonHandler();
		_workshopSlotButtonHandler = new WorkshopSlotButtonHandler(new WorkshopSlotButtonHandlerData
		{
			masterDomain = _masterDomain,
			eventExposer = _masterDomain.eventExposer,
			workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel,
			prefab = workshopAnimatronicButtonPrefab,
			prefabLocked = workshopAnimatronicButton_LockedPrefab,
			parentTransform = buttonsParent,
			UISelectLockedButton = SelectLockedWarehouseButton,
			itemDefinitions = _masterDomain.ItemDefinitionDomain.ItemDefinitions
		});
		_workshopSlotButtonHandler.GenerateWorkshopAnimatronicButtons(_workshopSlotDataModel.WorkshopSlotDatas);
	}

	private void CleanUpWorkshopSlotButtonHandler()
	{
		if (_workshopSlotButtonHandler != null)
		{
			_workshopSlotButtonHandler.OnDestroy();
		}
		_workshopSlotButtonHandler = null;
	}

	public void ReenableSendSelect()
	{
		sendSelectDialog.ReenableSendSelect();
	}

	public void SelectLockedWarehouseButton(IWorkshopSlotButton workshopAnimatronicButton)
	{
	}

	public void SetupSendSelectDialog(Action<string> SendSelectedSlotToUserId)
	{
		sendSelectDialog.SetupSendSelectDialog(_masterDomain, SendSelectedSlotToUserId, _masterDomain.PlayerAvatarDomain.AvatarIconHandler);
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
		Debug.LogError("master domain null?" + (_masterDomain == null));
		_workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel;
		_workshopSlotDataModel.RefreshIcons();
		WorkshopPageHandlerData data = new WorkshopPageHandlerData
		{
			eventExposer = _masterDomain.eventExposer,
			conditionWordDisplay = conditionWordDisplay,
			workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel,
			itemDefinitions = _masterDomain.ItemDefinitionDomain.ItemDefinitions,
			wearTearPercentText = wearTearPercentText,
			animatronicNameDisplay = animatronicNameDisplay,
			availableText = availableText,
			deployButtonText = deployButtonText,
			modifyButton = modifyButton,
			wearTearButton = wearTearButton,
			deployButton = deployButton
		};
		_workshopPageDisplayHandler = new WorkshopPageDisplayHandler(data);
		AddSubcriptions();
	}

	public void OverrideWorkshopSlotDataState(WorkshopSlotData workshopSlotData, WorkshopEntry.Status status)
	{
		_workshopSlotButtonHandler.OverrideWorkshopSlotDataState(workshopSlotData, status);
	}

	private void Update()
	{
		_workshopPageDisplayHandler.Update();
	}

	private void OnDestroy()
	{
		_workshopPageDisplayHandler.OnDestroy();
		CleanUpWorkshopSlotButtonHandler();
	}
}
