using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LootRewardDisplay : IxDisplay
{
	private const string RIG_PHASE_ANIM_KEY = "TargetPhase";

	private const string RIG_TRIGGER_ANIM_KEY = "Advance";

	private const string UI_PHASE_ANIM_KEY = "TargetPhase";

	private const string UI_TRIGGER_ANIM_KEY = "Advance";

	private const string CRATE_OPEN_TRIGGER_ANIM_KEY = "Open";

	private const string REWARD_LEVEL_1 = "Balloon_Blue";

	private const string REWARD_LEVEL_2 = "Balloon_Green";

	private const string REWARD_LEVEL_3 = "Balloon_Red";

	private const string REWARD_STAR_GOLD = "Star_Balloon_Gold";

	private const string REWARD_STAR_PLAT = "Star_Balloon_Platinum";

	private const string SFX_LEVEL_1_TAP = "UIRewardLevelOneTapped";

	private const string SFX_LEVEL_2_TAP = "UIRewardLevelTwoTapped";

	private const string SFX_LEVEL_3_TAP = "UIRewardLevelThreeTapped";

	private const float XP_ANIMATION_DURATION = 3f;

	private const float WAIT_ON_SCREEN_TIME = 2f;

	private const string STREAK_XP_BONUS_LOGICAL = "Streak_XP_Bonus";

	private Animator _rigAnimator;

	private Animator _crateAnimator;

	private Animator _uiAnimator;

	private EventTrigger _fullScreenButton;

	private CustomAnimationEventScript _rigEvents;

	private CustomAnimationEventScript _crateEvents;

	private SpriteRenderer _itemScreen;

	private TextMeshProUGUI _itemViewNameLabel;

	private TextMeshProUGUI _itemViewDescLabel;

	private Transform _crateMount;

	private Transform _itemMount;

	private Slider _xpSlider;

	private TextMeshProUGUI _xpAmount;

	private Button _finalListConfirmButton;

	private Button _continueButton;

	private TextMeshProUGUI _currentLevelText;

	private TextMeshProUGUI _nextLevelText;

	private TextMeshProUGUI _xpStreakBonusAmount;

	private HorizontalLayoutGroup _xpBonusStreakContainer;

	private ImageChange _freddyBalloonSilhouette;

	private MasterDomain _masterDomain;

	private IxTableDisplay<LootItemCellDisplay, LootRewardEntry> _itemTable;

	private CrateInfoData _crateInfo;

	private List<LootRewardEntry> _rewards;

	private bool _levelUp;

	private int _currentRewardIndex;

	private CratePhase _currentPhase;

	private ComponentContainer _rigComponents;

	private AudioPlayer _audioPlayer;

	private bool _didPlayerGainXP;

	private int _xpGained;

	private int _xpBonusStreakGained;

	private MonoBehaviour _coroutineTool;

	private bool _continueButtonPressed;

	private IconLookup _iconLookup;

	private AssetCache _assetCache;

	private bool _assetLoadersReady;

	private LootRewardDisplayData _bufferedDisplayData;

	private GameObject _rigPrefab;

	private GameObject _cratePrefab;

	private GameObject _framePrefab;

	private GameObject _rig;

	private bool _isFullScreenButtonDown;

	private bool _hasTornDown;

	public LootRewardDisplay(PrefabInstance instance)
		: base(instance)
	{
		_masterDomain = MasterDomain.GetDomain();
		_coroutineTool = instance.Root.AddComponent<CoroutineBehaviour>();
		_masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(b__62_0);
		_masterDomain.GameAssetManagementDomain.AssetCacheAccess.GetInterfaceAsync(b__62_1);
		_masterDomain.eventExposer.OnUICanvasDidAppear(GameDisplayData.DisplayType.dialogLootReward);
	}

	private void OnAssetLoadersReady()
	{
		if (_iconLookup != null && _assetCache != null)
		{
			_assetLoadersReady = true;
			if (_bufferedDisplayData != null)
			{
				ShowRewards(_bufferedDisplayData);
				_bufferedDisplayData = null;
			}
		}
	}

	public void ShowRewards(LootRewardDisplayData data)
	{
		if (!_assetLoadersReady)
		{
			_bufferedDisplayData = data;
		}
		else if (data != null)
		{
			_crateInfo = data.crateInfo;
			_rewards = data.rewards;
			_levelUp = data.levelUp;
			_rewards.Sort(ComparisonSortXPToLast);
			_didPlayerGainXP = false;
			data.MergeByType("XP");
			SetUpXpText();
			if (_crateInfo != null)
			{
				LoadPrefabs();
			}
			else
			{
				ExecuteSequence();
			}
		}
	}

	private void CalculateHowMuchXPGained()
	{
		foreach (LootRewardEntry reward in _rewards)
		{
			if (reward.LootItem.Item == "XP")
			{
				if (reward.LootItem.Logical == "Streak_XP_Bonus")
				{
					_xpBonusStreakGained = reward.NumToGive + _xpBonusStreakGained;
				}
				else
				{
					_xpGained = reward.NumToGive + _xpGained;
				}
			}
		}
	}

	private int ComparisonSortXPToLast(LootRewardEntry x, LootRewardEntry y)
	{
		if (ComparisonSortXPToLastg__IsLootXP(x.LootItem.Type))
		{
			return 1;
		}
		if (ComparisonSortXPToLastg__IsLootXP(y.LootItem.Type))
		{
			return 0;
		}
		return string.Compare(x.LootItem.Type, y.LootItem.Type, StringComparison.Ordinal);
	}

	private void LoadPrefabs()
	{
		_assetCache.LoadAsset<GameObject>(_crateInfo.ArtAssets.AssetBundle, _crateInfo.ArtAssets.RigPrefabName, LoadPrefabsb__67_0, LoadPrefabsb__67_1);
		_assetCache.LoadAsset<GameObject>(_crateInfo.ArtAssets.AssetBundle, _crateInfo.ArtAssets.CratePrefabName, LoadPrefabsb__67_2, LoadPrefabsb__67_3);
		_assetCache.LoadAsset<GameObject>(_crateInfo.ArtAssets.AssetBundle, _crateInfo.ArtAssets.FramePrefabName, LoadPrefabsb__67_4, LoadPrefabsb__67_5);
	}

	private void OnAssetFailed(string role, string asset)
	{
		Debug.LogError("LootRewardDisplay OnAssetFailed - Failed to load " + role + " '" + asset + "', show final list of rewards");
		ShowFinalList();
	}

	private void OnCrateAssetsLoaded()
	{
		if (!(_rigPrefab == null) && !(_cratePrefab == null) && !(_framePrefab == null))
		{
			_rig = UnityEngine.Object.Instantiate(_rigPrefab, _root.transform, worldPositionStays: false);
			_rigComponents = new ComponentContainer();
			Type[] onlyCacheTypes = new Type[4]
			{
				typeof(Camera),
				typeof(Animator),
				typeof(CustomAnimationEventScript),
				typeof(Transform)
			};
			_rigComponents.CacheComponents(_rig, onlyCacheTypes);
			if (_rigComponents.TryGetComponent<Camera>("Camera", out var returnComponent))
			{
				returnComponent.depth = 10f;
			}
			_rigAnimator = _rig.GetComponent<Animator>();
			_rigEvents = _rig.GetComponent<CustomAnimationEventScript>();
			_rigEvents.AnimComplete += RigAnimComplete;
			_crateMount = _rigComponents.TryGetComponent<Transform>("CrateMount");
			_itemMount = _rigComponents.TryGetComponent<Transform>("ItemMount");
			GameObject gameObject = UnityEngine.Object.Instantiate(_cratePrefab, _crateMount, worldPositionStays: false);
			ComponentContainer componentContainer = new ComponentContainer();
			componentContainer.CacheComponents(gameObject, new Type[2]
			{
				typeof(Animator),
				typeof(CustomAnimationEventScript)
			});
			_crateAnimator = componentContainer.TryGetComponent<Animator>(gameObject.name);
			_crateEvents = componentContainer.TryGetComponent<CustomAnimationEventScript>(gameObject.name);
			_crateEvents.AnimComplete += CrateAnimComplete;
			GameObject gameObject2 = UnityEngine.Object.Instantiate(_framePrefab, _itemMount, worldPositionStays: false);
			ComponentContainer componentContainer2 = new ComponentContainer();
			componentContainer2.CacheComponents(gameObject2, new Type[1] { typeof(SpriteRenderer) });
			_itemScreen = componentContainer2.TryGetComponent<SpriteRenderer>("Item_Icon");
			ExecuteSequence();
		}
	}

	private void ExecuteSequence()
	{
		if (_crateInfo != null)
		{
			_fullScreenButton.enabled = true;
			_currentRewardIndex = 0;
			_currentPhase = CratePhase.CrateIdle;
			_rigAnimator.SetInteger("TargetPhase", 2);
			_rigAnimator.SetTrigger("Advance");
			_uiAnimator.SetInteger("TargetPhase", 0);
			_uiAnimator.SetTrigger("Advance");
		}
		else
		{
			ShowFinalList();
		}
	}

	protected override void CacheAndPopulateComponents()
	{
		_masterDomain = MasterDomain.GetDomain();
		Type[] onlyCacheTypes = new Type[8]
		{
			typeof(Animator),
			typeof(GridLayoutGroup),
			typeof(TextMeshProUGUI),
			typeof(Slider),
			typeof(HorizontalLayoutGroup),
			typeof(ImageChange),
			typeof(Button),
			typeof(EventTrigger)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_uiAnimator = _components.TryGetComponent<Animator>("UIAnimator");
		GridLayoutGroup itemDisplayParent = _components.TryGetComponent<GridLayoutGroup>("Content");
		_itemTable = new IxTableDisplay<LootItemCellDisplay, LootRewardEntry>(itemDisplayParent);
		CacheAndPopulateComponentsg__SetUpFullscreenButton();
		_itemViewNameLabel = _components.TryGetComponent<TextMeshProUGUI>("ItemViewNameLabel");
		_itemViewDescLabel = _components.TryGetComponent<TextMeshProUGUI>("ItemViewDescLabel");
		_currentLevelText = _components.TryGetComponent<TextMeshProUGUI>("CurrentLevelText");
		_nextLevelText = _components.TryGetComponent<TextMeshProUGUI>("NextLevelText");
		if (_masterDomain.GameAudioDomain.AudioPlayer != null)
		{
			_audioPlayer = _masterDomain.GameAudioDomain.AudioPlayer;
		}
		_xpSlider = _components.TryGetComponent<Slider>("Slider");
		_xpAmount = _components.TryGetComponent<TextMeshProUGUI>("XPAmount");
		_xpStreakBonusAmount = _components.TryGetComponent<TextMeshProUGUI>("XPBonusAmount");
		_xpBonusStreakContainer = _components.TryGetComponent<HorizontalLayoutGroup>("XPBonusStreakContainer");
		_freddyBalloonSilhouette = _components.TryGetComponent<ImageChange>("Balloon");
		_finalListConfirmButton = _components.TryGetComponent<Button>("SummaryConfirmButton");
		_finalListConfirmButton.onClick.AddListener(OnFinalListConfirmButton);
		_continueButton = _components.TryGetComponent<Button>("ContinueButton");
		_continueButton.onClick.AddListener(OnContinueButtonPressed);
	}

	private void PopulateItemScreen()
	{
		_masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDisplayDataForRewardData(_rewards[_currentRewardIndex], _iconLookup, PopulateItemScreenb__72_0);
	}

	private void OnFullScreenButtonUp(BaseEventData eventData)
	{
		_isFullScreenButtonDown = false;
		_rigAnimator.speed = 1f;
	}

	private void OnFullScreenButtonDown(BaseEventData eventData)
	{
		Debug.Log("Tap!");
		_isFullScreenButtonDown = true;
		_rigAnimator.speed = 3f;
		if (_currentPhase != CratePhase.ItemIdle)
		{
			if (_currentPhase == CratePhase.CrateIdle)
			{
				_crateAnimator.SetTrigger("Open");
				CrateOpenSFX();
			}
		}
		else
		{
			ShowNextItemAnim();
		}
	}

	private void RigAnimComplete(int step)
	{
		switch (step)
		{
		case 5:
			_currentRewardIndex++;
			if (_currentRewardIndex >= _rewards.Count)
			{
				ShowFinalList();
			}
			else
			{
				ShowQueuedItemFromCrate();
			}
			break;
		case 3:
			if (!_isFullScreenButtonDown)
			{
				_currentPhase = CratePhase.ItemIdle;
				RigAnimCompleteg__ShowItemIdleAnim();
			}
			else
			{
				ShowNextItemAnim();
			}
			break;
		case 1:
			_currentPhase = CratePhase.CrateIdle;
			break;
		}
	}

	private void ShowXPGainSequence()
	{
		SetUpXPSlider();
		_uiAnimator.SetInteger("TargetPhase", 2);
		_uiAnimator.SetTrigger("Advance");
	}

	private void SetUpXPSlider()
	{
	}

	private void SetUpXpText()
	{
		SetupBonusStreakXP();
		if (_xpAmount != null)
		{
			_xpAmount.text = _xpGained.ToString();
		}
	}

	private void SetupBonusStreakXP()
	{
		if (!(_xpBonusStreakContainer == null) && !(_xpBonusStreakContainer.gameObject == null))
		{
			if (_xpBonusStreakGained > 0)
			{
				_xpBonusStreakContainer.gameObject.SetActive(value: true);
				_xpStreakBonusAmount.text = _xpBonusStreakGained.ToString();
			}
			else
			{
				_xpBonusStreakContainer.gameObject.SetActive(value: false);
			}
		}
	}

	private int GetTotalXPGained()
	{
		return _xpBonusStreakGained + _xpGained;
	}

	private void SetUpXPSliderLevelText(int currentLevel, int nextLevel)
	{
		if (_nextLevelText != null)
		{
			_nextLevelText.text = nextLevel.ToString();
		}
	}

	private IEnumerator AnimateXPBar(float targetValue, Action callback)
	{
		yield return null;
	}

	private void OnAnimateBarComplete()
	{
		ShowLevelUpBalloonAnim();
	}

	private void OnContinueButtonPressed()
	{
		_continueButtonPressed = true;
		_continueButton.onClick.RemoveAllListeners();
		ForceClose();
	}

	private void ShowLevelUpBalloonAnim()
	{
		_freddyBalloonSilhouette.ChangeImage();
		_coroutineTool.StartCoroutine(WaitOnScreenForTime(ForceClose));
	}

	private IEnumerator WaitOnScreenForTime(Action onFinishCallback)
	{
		yield return null;
	}

	private void ShowNextItemAnim()
	{
		_rigAnimator.SetInteger("TargetPhase", 5);
		_rigAnimator.SetTrigger("Advance");
		_uiAnimator.SetInteger("TargetPhase", 0);
		_uiAnimator.SetTrigger("Advance");
		_currentPhase = CratePhase.ItemDismiss;
	}

	private void CrateAnimComplete(int step)
	{
		ShowQueuedItemFromCrate();
	}

	private void ShowFinalList()
	{
		_itemTable.SetItems(_rewards);
		_uiAnimator.SetInteger("TargetPhase", 4);
		_uiAnimator.SetTrigger("Advance");
	}

	private void OnFinalListConfirmButton()
	{
		ForceClose();
	}

	private void ShowQueuedItemFromCrate()
	{
		PopulateItemScreen();
		_rigAnimator.SetInteger("TargetPhase", 3);
		_rigAnimator.SetTrigger("Advance");
		_currentPhase = CratePhase.ItemAppear;
		_audioPlayer.RaiseGameEventForModeWithOverrideByName("UIRewardItemShown", "ui", AudioMode.Global);
	}

	private void CrateOpenSFX()
	{
		if (_cratePrefab.name == "Balloon_Blue")
		{
			_audioPlayer.RaiseGameEventForModeWithOverrideByName("UIRewardLevelOneTapped", "ui", AudioMode.Global);
		}
		else if (_cratePrefab.name == "Balloon_Green" || _cratePrefab.name == "Star_Balloon_Gold")
		{
			_audioPlayer.RaiseGameEventForModeWithOverrideByName("UIRewardLevelTwoTapped", "ui", AudioMode.Global);
		}
		else if (_cratePrefab.name == "Balloon_Red" || _cratePrefab.name == "Star_Balloon_Platinum")
		{
			_audioPlayer.RaiseGameEventForModeWithOverrideByName("UIRewardLevelThreeTapped", "ui", AudioMode.Global);
		}
		else
		{
			_audioPlayer.RaiseGameEventForModeWithOverrideByName("UIRewardLevelOneTapped", "ui", AudioMode.Global);
		}
	}

	public override void Teardown()
	{
		if (!_hasTornDown)
		{
			_hasTornDown = true;
			if (_rigEvents != null)
			{
				_rigEvents.AnimComplete -= RigAnimComplete;
			}
			if (_crateEvents != null)
			{
				_crateEvents.AnimComplete -= CrateAnimComplete;
			}
			_rewards.Clear();
			_rewards = null;
			_itemTable.Teardown();
			_itemTable = null;
			_fullScreenButton.triggers.Clear();
			_fullScreenButton = null;
			if (_rigPrefab != null)
			{
				_assetCache.ReleaseAsset(_rigPrefab);
				_rigPrefab = null;
			}
			if (_cratePrefab != null)
			{
				_assetCache.ReleaseAsset(_cratePrefab);
				_cratePrefab = null;
			}
			if (_framePrefab != null)
			{
				_assetCache.ReleaseAsset(_framePrefab);
				_framePrefab = null;
			}
			_rigEvents = null;
			_crateInfo = null;
			_bufferedDisplayData = null;
			_audioPlayer = null;
			_coroutineTool = null;
			_uiAnimator = null;
			_itemMount = null;
			_rigAnimator = null;
			_itemViewDescLabel = null;
			_itemScreen = null;
			_assetLoadersReady = false;
			_iconLookup = null;
			_assetCache = null;
			_masterDomain.eventExposer.OnUICanvasClosed(GameDisplayData.DisplayType.dialogLootReward);
			_masterDomain = null;
			base.Teardown();
		}
	}

	private void b__62_0(IconLookup lookup)
	{
		_iconLookup = lookup;
		OnAssetLoadersReady();
	}

	private void b__62_1(AssetCache assets)
	{
		_assetCache = assets;
		OnAssetLoadersReady();
	}

	internal static bool ComparisonSortXPToLastg__IsLootXP(string str)
	{
		return string.Compare(str, "XP", StringComparison.OrdinalIgnoreCase) == 0;
	}

	private void LoadPrefabsb__67_0(GameObject prefab)
	{
		_rigPrefab = prefab;
		OnCrateAssetsLoaded();
	}

	private void LoadPrefabsb__67_1()
	{
		OnAssetFailed("RigPrefab", _crateInfo.ArtAssets.RigPrefabName);
	}

	private void LoadPrefabsb__67_2(GameObject prefab)
	{
		_cratePrefab = prefab;
		OnCrateAssetsLoaded();
	}

	private void LoadPrefabsb__67_3()
	{
		OnAssetFailed("CratePrefab", _crateInfo.ArtAssets.CratePrefabName);
	}

	private void LoadPrefabsb__67_4(GameObject prefab)
	{
		_framePrefab = prefab;
		OnCrateAssetsLoaded();
	}

	private void LoadPrefabsb__67_5()
	{
		OnAssetFailed("FramePrefab", _crateInfo.ArtAssets.FramePrefabName);
	}

	private void CacheAndPopulateComponentsg__SetUpFullscreenButton()
	{
		_fullScreenButton = _components.TryGetComponent<EventTrigger>("FullScreenButton");
		Debug.Log("full screen button null? " + (_fullScreenButton == null));
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerDown;
		entry.callback.AddListener(OnFullScreenButtonDown);
		_fullScreenButton.triggers.Add(entry);
		EventTrigger.Entry entry2 = new EventTrigger.Entry();
		entry2.eventID = EventTriggerType.PointerUp;
		entry2.callback.AddListener(OnFullScreenButtonUp);
		_fullScreenButton.triggers.Add(entry2);
		_fullScreenButton.enabled = false;
	}

	private void PopulateItemScreenb__72_0(LootDisplayData displayData)
	{
		_itemScreen.sprite = displayData.DisplayIcon;
		_itemViewNameLabel.text = displayData.DisplayName;
		if (displayData.DisplayQuantity > 1)
		{
			_itemViewDescLabel.text = displayData.DisplayQuantity.ToString();
		}
		else
		{
			_itemViewDescLabel.text = "";
		}
	}

	private void RigAnimCompleteg__ShowItemIdleAnim()
	{
		_uiAnimator.SetInteger("TargetPhase", 1);
		_uiAnimator.SetTrigger("Advance");
	}
}
