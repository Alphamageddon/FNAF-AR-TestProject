using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EntityAnimatronicDisplay : IxDisplay, IEntityAnimatronicDisplay
{
	private enum AnimatronicStats
	{
		Perception = 0,
		Aggression = 1,
		Durability = 2,
		Attack = 3,
		NumAnimatronicStats = 4
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public EntityAnimatronicDisplay _003C_003E4__this;

		public string body;

		public Action<IconLookup, EntityAnimatronicAlertStyle> iconLoader;

		public EntityAnimatronicAlertStyle alertStyle;

		public Action<Sprite> _003C_003E9__2;

		internal void _003CShowAlert_003Eb__0(IconLookup iconLookup, EntityAnimatronicAlertStyle style)
		{
			_003C_003E4__this._alertText.text = body;
			_003C_003E4__this._alertContainer.gameObject.SetActive(value: true);
			if (style != EntityAnimatronicAlertStyle.SpecialDelivery)
			{
				iconLookup.GetIcon(IconGroup.Reward, "alpine_ui_reward_radio_jammer", _003CShowAlert_003Eb__2);
			}
		}

		internal void _003CShowAlert_003Eb__2(Sprite sprite)
		{
			_003C_003E4__this._alertIcon.sprite = sprite;
		}

		internal void _003CShowAlert_003Eb__1()
		{
			_003CShowAlert_003Eb__0(_003C_003E4__this._iconLookup, alertStyle);
		}
	}

	private const string LKEY_STAT_PERCEPTION = "map_interaction_perception";

	private const string LKEY_STAT_AGGRESSION = "map_interaction_aggression";

	private const string LKEY_STAT_DURABILITY = "map_interaction_durability";

	private const string LKEY_STAT_ATTACK = "map_interaction_attack";

	private const string LKEY_OWNER = "map_interaction_owner";

	private const string LKEY_DEFAULT_OWNER_NAME = "map_interaction_default_owner_name";

	private const string ICON_UI_REWARD_RADIO_JAMMER = "alpine_ui_reward_radio_jammer";

	private MasterDomain _masterDomain;

	private EventExposer _eventExposer;

	private IAnimatronicDisplayController _controller;

	private IconLookup _iconLookup;

	private AssetCache _assetCache;

	private MapEntity _entity;

	private MapEntityInteractionMutex _interactionMutex;

	private RectTransform _topContainer;

	private RectTransform _animatronicContainer;

	private RectTransform _statsContainer;

	private RectTransform _mapDialogAnimatronic;

	private RectTransform _statPerceptionTransform;

	private RectTransform _statAggressionTransform;

	private RectTransform _animatronicWindowRectTransform;

	private Image _animatronicFrame;

	private RawImage _animatronicWindow;

	private Button _encounterButton;

	private TextMeshProUGUI _encounterButtonText;

	private Button _jammerButton;

	private TextMeshProUGUI _jammerButtonText;

	private TextMeshProUGUI _jammerCostText;

	private Action<MapEntity> _onConfirmStandardAction;

	private Action<MapEntity> _onDismiss;

	private Action<MapEntity> _onForceDeleteEntity;

	private Action _onJammerSpent;

	private TextMeshProUGUI _animatronicName;

	private TextMeshProUGUI _animatronicOwner;

	private AnimatronicStatDisplay[] _animatronicStatDisplays;

	private Button _fullScreenButton;

	private Button _closeButton;

	private AnimatronicDisplayAssetPopulator _displayAssetPopulator;

	private Image _alertContainer;

	private TextMeshProUGUI _alertText;

	private Image _alertIcon;

	private List<Action> _queuedIconLoads;

	private CurrencyBank _currencyBank;

	private CONFIG_DATA.MapEntities _mapEntitiesConfigData;

	private CPUData _cpuData;

	private Image _mod1;

	private Image _mod2;

	private Image _mod3;

	private Image _mod4;

	private Localization _localization => LocalizationDomain.Instance.Localization;

	public MapEntity Entity => _entity;

	public CONFIG_DATA.MapEntities EntityConfigData => _mapEntitiesConfigData;

	public TextMeshProUGUI EncounterButtonText => _encounterButtonText;

	public Button JammerButton => _jammerButton;

	public TextMeshProUGUI JammerButtonText => _jammerButtonText;

	public Button CloseButton => _closeButton;

	public MonoBehaviour CoroutineRunner => _animatronicName;

	private Action<MapEntity> OnConfirmStandardAction => _onConfirmStandardAction;

	private Action<MapEntity> OnDismiss => _onDismiss;

	public EntityAnimatronicDisplay(PrefabInstance instance)
		: base(instance)
	{
		_queuedIconLoads = new List<Action>();
	}

	public void Setup(EntityDisplayData data, IAnimatronicDisplayController controller)
	{
		_interactionMutex = data.interactionMutex;
		_controller = controller;
		_entity = data.entity;
		_jammerButton.enabled = true;
		_jammerButton.interactable = false;
		_jammerButton.gameObject.SetActive(value: true);
		_displayAssetPopulator = new AnimatronicDisplayAssetPopulator();
		_onConfirmStandardAction = data.onConfirmStandardAction;
		_onForceDeleteEntity = data.onForceDeleteEntity;
		_onDismiss = data.onDismiss;
		_currencyBank = _masterDomain.TheGameDomain.bank;
		_onJammerSpent = Setupb__73_0;
		PrepLoaders(_masterDomain.GameAssetManagementDomain, _masterDomain.MasterDataDomain);
		_cpuData = _masterDomain.ItemDefinitionDomain.ItemDefinitions.GetCPUById(_entity.CPUId);
		_animatronicName.text = LocalizationDomain.Instance.Localization.GetLocalizedString(_cpuData.AnimatronicName, _cpuData.AnimatronicName);
		if (string.IsNullOrEmpty(_entity.SynchronizeableState.history.ownerDisplayName))
		{
			_animatronicOwner.text = LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_owner", "Owner (unlocalized)") + ": " + LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_default_owner_name", "Fazbear Entertainment (unlocalized)");
		}
		else
		{
			_animatronicOwner.text = LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_owner", "Owner (unlocalized)") + ": " + _entity.SynchronizeableState.history.ownerDisplayName;
		}
		_animatronicOwner.gameObject.SetActive(value: true);
		if (_entity.SynchronizeableState.parts.ContainsKey("mod1"))
		{
			ModData modById = _masterDomain.ItemDefinitionDomain.ItemDefinitions.GetModById(_entity.SynchronizeableState.parts["mod1"]);
			if (modById != null)
			{
				_masterDomain.GameAssetManagementDomain.IconLookupAccess.GetIcon(IconGroup.Mod, modById.ModIconRenderedName, SetMod1Image);
			}
		}
		if (_entity.SynchronizeableState.parts.ContainsKey("mod2"))
		{
			ModData modById2 = _masterDomain.ItemDefinitionDomain.ItemDefinitions.GetModById(_entity.SynchronizeableState.parts["mod2"]);
			if (modById2 != null)
			{
				_masterDomain.GameAssetManagementDomain.IconLookupAccess.GetIcon(IconGroup.Mod, modById2.ModIconRenderedName, SetMod2Image);
			}
		}
		if (_entity.SynchronizeableState.parts.ContainsKey("mod3"))
		{
			ModData modById3 = _masterDomain.ItemDefinitionDomain.ItemDefinitions.GetModById(_entity.SynchronizeableState.parts["mod3"]);
			if (modById3 != null)
			{
				_masterDomain.GameAssetManagementDomain.IconLookupAccess.GetIcon(IconGroup.Mod, modById3.ModIconRenderedName, SetMod3Image);
			}
		}
		if (_entity.SynchronizeableState.parts.ContainsKey("mod4"))
		{
			ModData modById4 = _masterDomain.ItemDefinitionDomain.ItemDefinitions.GetModById(_entity.SynchronizeableState.parts["mod4"]);
			if (modById4 != null)
			{
				_masterDomain.GameAssetManagementDomain.IconLookupAccess.GetIcon(IconGroup.Mod, modById4.ModIconRenderedName, SetMod4Image);
			}
		}
		SetupStats();
		RegisterEvents(data);
		_eventExposer.OnUICanvasDidAppear(GameDisplayData.DisplayType.dialogMapAnimatronic);
	}

	private void SetMod1Image(Sprite img)
	{
		_mod1.enabled = true;
		_mod1.sprite = img;
	}

	private void SetMod2Image(Sprite img)
	{
		_mod2.enabled = true;
		_mod2.sprite = img;
	}

	private void SetMod3Image(Sprite img)
	{
		_mod3.enabled = true;
		_mod3.sprite = img;
	}

	private void SetMod4Image(Sprite img)
	{
		_mod4.enabled = true;
		_mod4.sprite = img;
	}

	public override void Teardown()
	{
		Debug.LogWarning("BRO IM DISMISSED????");
		_interactionMutex.OnInteractionDisplayClosed();
		_eventExposer.OnUICanvasClosed(GameDisplayData.DisplayType.dialogMapAnimatronic);
		UnregsiterEvents();
		_displayAssetPopulator.Teardown();
		_displayAssetPopulator = null;
		_queuedIconLoads.Clear();
		_queuedIconLoads = null;
		ForceDeleteEntity();
		_mapEntitiesConfigData = null;
		_masterDomain = null;
		_jammerButtonText = null;
		_animatronicOwner = null;
		_animatronicStatDisplays = null;
		_animatronicName = null;
		_alertText = null;
		_alertIcon = null;
		_assetCache = null;
		_controller = null;
		_animatronicContainer = null;
		_mapDialogAnimatronic = null;
		_animatronicWindow = null;
		_encounterButtonText = null;
		_animatronicWindowRectTransform = null;
		_alertContainer = null;
		Debug.LogWarning("doing base teardown");
		base.Teardown();
	}

	protected override void CacheAndPopulateComponents()
	{
		Type[] onlyCacheTypes = new Type[5]
		{
			typeof(RectTransform),
			typeof(TextMeshProUGUI),
			typeof(Image),
			typeof(RawImage),
			typeof(Button)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_masterDomain = MasterDomain.GetDomain();
		_mapDialogAnimatronic = _root.GetComponent<RectTransform>();
		_topContainer = _components.TryGetComponent<RectTransform>("TopContainer");
		_animatronicContainer = _components.TryGetComponent<RectTransform>("AnimatronicContainer");
		_statsContainer = _components.TryGetComponent<RectTransform>("StatsContainer");
		_animatronicName = _components.TryGetComponent<TextMeshProUGUI>("AnimatronicNameLabel");
		_animatronicOwner = _components.TryGetComponent<TextMeshProUGUI>("AnimatronicOwnerLabel");
		_animatronicFrame = _components.TryGetComponent<Image>("AnimatronicFrame");
		_mod1 = _components.TryGetComponent<Image>("Mod1");
		_mod2 = _components.TryGetComponent<Image>("Mod2");
		_mod3 = _components.TryGetComponent<Image>("Mod3");
		_mod4 = _components.TryGetComponent<Image>("Mod4");
		_animatronicWindow = _components.TryGetComponent<RawImage>("Animatronic_Window");
		_animatronicWindow.texture = Resources.Load<RenderTexture>("ContentAssets/DialogPrefabs/Map_UI_Animatronic");
		_fullScreenButton = _components.TryGetComponent<Button>("FullScreenButton");
		_fullScreenButton.onClick.AddListener(OnFullScreenClicked);
		_fullScreenButton.interactable = false;
		_closeButton = _components.TryGetComponent<Button>("CloseButton");
		_closeButton.onClick.AddListener(OnCloseClicked);
		_closeButton.interactable = false;
		GameObjectUtils.Enable(_closeButton.gameObject, state: false);
		_encounterButton = _components.TryGetComponent<Button>("EncounterButton");
		_encounterButtonText = _components.TryGetComponent<TextMeshProUGUI>("EncounterButtonText");
		_encounterButton.onClick.AddListener(Encounter);
		_encounterButton.interactable = false;
		_jammerButton = _components.TryGetComponent<Button>("JammerButton");
		_jammerButtonText = _components.TryGetComponent<TextMeshProUGUI>("JammerButtonText");
		_jammerButton.onClick.AddListener(OnJammerClicked);
		_jammerButton.interactable = false;
		_jammerCostText = _components.TryGetComponent<TextMeshProUGUI>("JammerCostText");
		_alertContainer = _components.TryGetComponent<Image>("AlertVisualContainer");
		_alertIcon = _components.TryGetComponent<Image>("AlertIcon");
		_alertText = _components.TryGetComponent<TextMeshProUGUI>("AlertText");
		_animatronicStatDisplays = new AnimatronicStatDisplay[2];
		_statPerceptionTransform = _components.TryGetComponent<RectTransform>("Stat_Perception");
		_statAggressionTransform = _components.TryGetComponent<RectTransform>("Stat_Aggression");
	}

	private void RegisterEvents(EntityDisplayData data)
	{
		Debug.LogWarning("Registering events");
		_eventExposer = data.eventExposer;
		_eventExposer.add_MapEntityInteractionFinished(EventExposer_OnMapEntityInteractionFinished);
		_eventExposer.add_OrtonEncounterMapEntityChosen(EventExposer_OnOrtonEncounterMapEntityChosen);
	}

	private void UnregsiterEvents()
	{
		Debug.LogWarning("Unregistering events");
		_eventExposer.remove_MapEntityInteractionFinished(EventExposer_OnMapEntityInteractionFinished);
		_eventExposer.remove_OrtonEncounterMapEntityChosen(EventExposer_OnOrtonEncounterMapEntityChosen);
	}

	private void EventExposer_OnOrtonEncounterMapEntityChosen(MapEntity mapEntity)
	{
		Debug.LogWarning("Ok the fucking dialog better close now");
		if (_entity == mapEntity)
		{
			Debug.LogWarning("FUCKING DIALOG TIME TO CLOSE CORRECT ENTITY");
			ForceClose();
			Debug.LogWarning("IT CLOSED. I SWEAR TO GOD IF ITS STILL THERE");
		}
	}

	private void EventExposer_OnMapEntityInteractionFinished(MapEntity mapEntity, bool giveRewards)
	{
		if (_entity == mapEntity)
		{
			ForceClose();
		}
	}

	public void Encounter()
	{
		Encounterb__80_0();
	}

	public void Jam()
	{
		Jamb__81_0();
	}

	public void Flee()
	{
		Fleeb__82_0();
	}

	public void ShowAlert(string locKey, EntityAnimatronicAlertStyle alertStyle)
	{
		_003C_003Ec__DisplayClass83_0 _003C_003Ec__DisplayClass83_ = new _003C_003Ec__DisplayClass83_0();
		_003C_003Ec__DisplayClass83_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass83_.alertStyle = alertStyle;
		_003C_003Ec__DisplayClass83_.body = LocalizationDomain.Instance.Localization.GetLocalizedString(locKey, "Alert (unlocalized)");
		_003C_003Ec__DisplayClass83_.iconLoader = _003C_003Ec__DisplayClass83_._003CShowAlert_003Eb__0;
		if (_iconLookup != null)
		{
			_003C_003Ec__DisplayClass83_._003CShowAlert_003Eb__0(_iconLookup, alertStyle);
		}
		else
		{
			_queuedIconLoads.Add(_003C_003Ec__DisplayClass83_._003CShowAlert_003Eb__1);
		}
	}

	public void SetButtonVisibility(bool canJam, bool canEncounter, bool canClose)
	{
		GameObjectUtils.Enable(_jammerButton.gameObject, canJam);
		GameObjectUtils.Enable(_encounterButton.gameObject, canEncounter);
		GameObjectUtils.Enable(_closeButton.gameObject, canClose);
	}

	public IEnumerator AnimateStatBarFill()
	{
		float fillTime = 2.5f;
		float elapsedTime = 0f;
		while (elapsedTime < fillTime)
		{
			float statDisplayBars = Mathf.Lerp(0f, 1f, elapsedTime / fillTime);
			SetStatDisplayBars(statDisplayBars);
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		SetStatDisplayBars(1f);
		yield return null;
	}

	public float CalculateDrawerHeight()
	{
		if (SystemInfo.deviceModel.ToLower().Contains("ipad"))
		{
			_animatronicContainer.sizeDelta = new Vector2
			{
				x = _animatronicContainer.sizeDelta.x + -100f,
				y = _animatronicContainer.sizeDelta.y + -100f
			};
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(_mapDialogAnimatronic);
		return _topContainer.offsetMax.y + _topContainer.rect.x + _animatronicContainer.rect.x + _statsContainer.rect.x;
	}

	public void ActivateLoadout(bool activate)
	{
	}

	private void PrepLoaders(GameAssetManagementDomain assetManagementDomain, MasterDataDomain masterDataDomain)
	{
		assetManagementDomain.IconLookupAccess.GetInterfaceAsync(PrepLoadersb__88_0);
		assetManagementDomain.AssetCacheAccess.GetInterfaceAsync(PrepLoadersb__88_1);
		masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(OnMasterDataConfigEntryLoaded);
	}

	private void SetupLoadout()
	{
	}

	private void SetupStats()
	{
		Debug.LogError("SETTING UP STAT BARS");
		_animatronicStatDisplays[0] = CreateStatDisplay(_statPerceptionTransform, "map_interaction_perception");
		_animatronicStatDisplays[1] = CreateStatDisplay(_statAggressionTransform, "map_interaction_aggression");
		SetStatDisplayBars(0f);
	}

	private void SetStatDisplayBars(float loadAmount)
	{
		if (_entity != null && _animatronicStatDisplays != null)
		{
			_animatronicStatDisplays[0].SetStatValue(_entity.SynchronizeableState.perception, loadAmount, _cpuData.Perception.Min, _cpuData.Perception.Max);
			_animatronicStatDisplays[1].SetStatValue(_entity.SynchronizeableState.aggression, loadAmount, _cpuData.Aggression.Min, _cpuData.Aggression.Max);
		}
	}

	private void OnMasterDataConfigEntryLoaded(CONFIG_DATA.Root e)
	{
		if (e.Entries[0].MapEntities != null)
		{
			_mapEntitiesConfigData = e.Entries[0].MapEntities;
			OnAssetLoadersReady();
		}
		else
		{
			new ArgumentException("e.MapEntities is Null!", "e");
		}
	}

	private void OnAssetLoadersReady()
	{
		if (_iconLookup == null || _assetCache == null || _mapEntitiesConfigData == null)
		{
			return;
		}
		_jammerCostText.text = _mapEntitiesConfigData.Interaction.JammerCost.ToString();
		_controller.PreSetup(this);
		_displayAssetPopulator.Setup(_root.transform, _animatronicFrame.rectTransform, _entity, MasterDomain.GetDomain().ItemDefinitionDomain, _assetCache, StartController);
		foreach (Action queuedIconLoad in _queuedIconLoads)
		{
			queuedIconLoad();
		}
		_queuedIconLoads.Clear();
	}

	private void StartController()
	{
		UpdateJammerAffordability();
		_closeButton.interactable = true;
		_encounterButton.interactable = true;
		_controller.OnSetup(this, 5f);
	}

	private void UpdateJammerAffordability()
	{
		_jammerButton.interactable = _currencyBank.CanAfford(Currency.CurrencyType.HardCurrency, _mapEntitiesConfigData.Interaction.JammerCost);
	}

	private void OnJammerClicked()
	{
		if (_mapEntitiesConfigData != null && _currencyBank.CanAfford(Currency.CurrencyType.HardCurrency, _mapEntitiesConfigData.Interaction.JammerCost))
		{
			_jammerButton.interactable = false;
			_currencyBank.AddCurrency("FAZ_TOKENS", -_mapEntitiesConfigData.Interaction.JammerCost);
			_onJammerSpent();
			_controller.OnJammerClicked();
		}
	}

	private AnimatronicStatDisplay CreateStatDisplay(Transform transform, string locKey)
	{
		AnimatronicStatDisplayData dataItem = new AnimatronicStatDisplayData
		{
			name = LocalizationDomain.Instance.Localization.GetLocalizedString(locKey, "stat (Unlocalized)"),
			backdropSprite = null,
			fillerSprite = null
		};
		AnimatronicStatDisplay animatronicStatDisplay = new AnimatronicStatDisplay();
		animatronicStatDisplay.Setup(transform.gameObject, dataItem);
		return animatronicStatDisplay;
	}

	private void OnFullScreenClicked()
	{
		_controller.OnFullScreenClicked();
	}

	private void OnCloseClicked()
	{
		_controller.OnCloseClicked();
	}

	private void ForceDeleteEntity()
	{
		if (_onForceDeleteEntity != null)
		{
			_onForceDeleteEntity(_entity);
		}
	}

	private void CloseButtonInteractable(bool interactable)
	{
		_closeButton.interactable = interactable;
	}

	private void Setupb__73_0()
	{
		_masterDomain.ServerDomain.mapEntityJamRequester.JamEntity(_entity.EntityId, new List<string>());
	}

	private void Encounterb__80_0()
	{
		_onConfirmStandardAction(_entity);
	}

	private void Jamb__81_0()
	{
		_onDismiss(_entity);
	}

	private void Fleeb__82_0()
	{
		_onDismiss(_entity);
	}

	private void PrepLoadersb__88_0(IconLookup lookup)
	{
		_iconLookup = lookup;
		OnAssetLoadersReady();
	}

	private void PrepLoadersb__88_1(AssetCache assets)
	{
		_assetCache = assets;
		OnAssetLoadersReady();
	}
}
