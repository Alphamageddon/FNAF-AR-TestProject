using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CameraStateUIView : MonoBehaviour
{
	[Header("Exposed Hookups")]
	[SerializeField]
	private GameObject legacyEncounterHUDParent;

	[SerializeField]
	private GameObject encounterHUDParent;

	[SerializeField]
	[Header("Mask")]
	private GameObject maskParent;

	[SerializeField]
	private HoldableButton maskButton;

	[SerializeField]
	[Header("Shocker")]
	private GameObject shockerParent;

	[SerializeField]
	[Header("Object Collection")]
	private GameObject collectionParent;

	[SerializeField]
	private Image collectionCountdown;

	[SerializeField]
	private TextMeshProUGUI collectionText;

	[SerializeField]
	[Header("Battery")]
	private GameObject batteryParent;

	[SerializeField]
	private List<BatteryColorToValue> batteryColorToValues;

	[SerializeField]
	private Color batterySurgeColor;

	[SerializeField]
	[Header("Billboard")]
	private AnimatronicBillboardView animatronicBillboardView;

	[SerializeField]
	[Header("Debug")]
	private GameObject Debug_EssenceStatsParent;

	[SerializeField]
	private Text Debug_EssenceText;

	[SerializeField]
	private Text Debug_ThreatText;

	private MasterDomain _masterDomain;

	private EventExposer _masterEventExposer;

	private BatteryMaskLightHandler batteryMaskLightHandler;

	private SurgeMechanicUIHandler surgeMechanicUIHandler;

	private bool emfIconSet;

	private bool extraBatteryIconSet;

	private EncounterHUD _encounterHUD;

	private void UpdateVisibility()
	{
		if (_masterDomain != null)
		{
			bool flag = _masterDomain.CameraEquipmentDomain.Mask.IsMaskFullyOff();
			collectionParent.SetActive(flag & ShouldCollectionBeVisible());
			maskParent.SetActive(ShouldMaskBeVisible());
			if (_encounterHUD != null)
			{
				_encounterHUD.UpdateVisibility();
			}
		}
	}

	private bool ShouldPlayerNoiseMeterBeVisible()
	{
		if (_masterDomain != null && _masterDomain.AttackSequenceDomain != null)
		{
			_masterDomain.AttackSequenceDomain.GetEncounterUIConfig();
		}
		return false;
	}

	private bool ShouldAnimatronicNoiseMeterBeVisible()
	{
		if (_masterDomain != null && _masterDomain.AttackSequenceDomain != null)
		{
			_masterDomain.AttackSequenceDomain.GetEncounterUIConfig();
		}
		return false;
	}

	private bool ShouldCollectionBeVisible()
	{
		if (_masterDomain != null)
		{
			if (_masterDomain.AttackSequenceDomain.GetEncounterUIConfig() == null)
			{
				return false;
			}
			return _masterDomain.AttackSequenceDomain.GetEncounterUIConfig().ShowCollection;
		}
		return false;
	}

	private bool ShouldEmfBeVisible()
	{
		if (_masterDomain != null)
		{
			ShouldRemnantBeVisible();
			return false;
		}
		return false;
	}

	private bool ShouldMaskBeVisible()
	{
		if (_masterDomain != null)
		{
			if (_masterDomain.AttackSequenceDomain.GetEncounterUIConfig() == null)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private bool ShouldRemnantBeVisible()
	{
		if (_masterDomain != null && _masterDomain.AttackSequenceDomain.GetEncounterUIConfig() != null)
		{
			_ = _masterDomain.AttackSequenceDomain.GetEncounterUIConfig().ShowRemnant;
			return false;
		}
		return false;
	}

	private bool ShouldSwapperBeVisible()
	{
		if (_masterDomain.AttackSequenceDomain.GetEncounterUIConfig() == null)
		{
			return false;
		}
		return _masterDomain.AttackSequenceDomain.GetEncounterUIConfig().UseSwapper;
	}

	private void UpdateValues()
	{
		if (collectionParent.activeSelf)
		{
			UpdateCollection();
		}
		if (maskParent.activeSelf)
		{
			UpdateMask();
		}
		if (_encounterHUD != null)
		{
			_encounterHUD.Update();
		}
	}

	private void UpdateCollection()
	{
		IDropsObjectsMechanicViewModel encounterDropsObjectsViewModel = _masterDomain.AttackSequenceDomain.GetEncounterDropsObjectsViewModel();
		if (encounterDropsObjectsViewModel == null)
		{
			collectionParent.SetActive(value: false);
			return;
		}
		if (!encounterDropsObjectsViewModel.ShouldShowCollectionTimer)
		{
			collectionParent.SetActive(value: false);
			return;
		}
		collectionCountdown.fillAmount = encounterDropsObjectsViewModel.CollectionPercentRemaining;
		collectionText.text = Mathf.FloorToInt(encounterDropsObjectsViewModel.CollectionTimeRemaining).ToString("D2");
	}

	private void UpdateEmf()
	{
	}

	private void UpdateMask()
	{
		_masterDomain.CameraEquipmentDomain.Mask.SetDesiredMaskState(maskButton.IsPressed || Input.GetKey(KeyCode.LeftShift));
		batteryMaskLightHandler.Update();
	}

	private void UpdateRemnant()
	{
	}

	private void InitializeEncounterHUD(string cpuId)
	{
		InitializeHUDForEncounter();
		if (_masterDomain.AttackSequenceDomain.GetEncounterUIConfig().ShowBillboard)
		{
			animatronicBillboardView.ShowBillboardsFor(cpuId);
		}
	}

	private void OnAttackUIUpdated()
	{
		UpdateVisibility();
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
		_masterEventExposer = _masterDomain.eventExposer;
		_masterDomain.AttackSequenceDomain.UpdateAttackUI += OnAttackUIUpdated;
		surgeMechanicUIHandler = new SurgeMechanicUIHandler(new SurgeMechanicUIHandlerData(_masterDomain.eventExposer));
		batteryMaskLightHandler = new BatteryMaskLightHandler(new BatteryMaskLightHandlerData(surgeMechanicUIHandler));
		InitializeHUD();
	}

	private void InitializeLegacyEncounterHUD()
	{
		_encounterHUD.UpdateRoot(legacyEncounterHUDParent);
		_encounterHUD.InitializeShockerComponent();
		_encounterHUD.InitializeFlashlightComponent();
		_encounterHUD.InitializeBatteryComponent(surgeMechanicUIHandler, batteryColorToValues, batterySurgeColor);
		_encounterHUD.InitializeHaywireIndicatorComponent();
		UpdateVisibility();
	}

	private void InitializeEncounterHUD()
	{
		_encounterHUD.UpdateRoot(encounterHUDParent);
		_encounterHUD.InitializeShockerComponent();
		_encounterHUD.InitializeFlashlightComponent();
		_encounterHUD.InitializeBatteryComponent(surgeMechanicUIHandler, batteryColorToValues, batterySurgeColor);
		_encounterHUD.InitializeHaywireIndicatorComponent();
		UpdateVisibility();
	}

	private void InitializeHUD()
	{
		legacyEncounterHUDParent.SetActive(value: false);
		encounterHUDParent.SetActive(value: false);
		if (_masterDomain != null)
		{
			_encounterHUD = new EncounterHUD(legacyEncounterHUDParent);
			_encounterHUD.Setup(_masterDomain.AttackSequenceDomain, _masterDomain.CameraEquipmentDomain, base.gameObject.GetComponent<CameraStateUIActions>());
			InitializeLegacyEncounterHUD();
			_masterEventExposer.add_EncounterAnimatronicInitialized(InitializeEncounterHUD);
		}
	}

	private void InitializeHUDForEncounter()
	{
		legacyEncounterHUDParent.SetActive(value: false);
		encounterHUDParent.SetActive(value: false);
		if (_masterDomain.AttackSequenceDomain.IsLegacyAnimatronic())
		{
			InitializeLegacyEncounterHUD();
		}
		else
		{
			InitializeEncounterHUD();
		}
		_masterDomain.eventExposer.add_MaskStateChanged(MaskStateChanged);
	}

	private void MaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning)
	{
		UpdateVisibility();
	}

	private void OnDestroy()
	{
		_encounterHUD = null;
		_masterDomain.AttackSequenceDomain.UpdateAttackUI -= OnAttackUIUpdated;
		_masterEventExposer.remove_EncounterAnimatronicInitialized(InitializeEncounterHUD);
		_masterDomain.eventExposer.remove_MaskStateChanged(MaskStateChanged);
		_masterEventExposer = null;
		batteryMaskLightHandler = null;
		surgeMechanicUIHandler.Teardown();
		surgeMechanicUIHandler = null;
		_masterDomain = null;
	}

	private void Update()
	{
		UpdateVisibility();
		UpdateValues();
		surgeMechanicUIHandler.Update();
	}
}
