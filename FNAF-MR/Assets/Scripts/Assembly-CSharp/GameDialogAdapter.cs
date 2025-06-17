using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameDialogAdapter
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ExitAttackSequenceDisplay display;

		public GameDialogAdapter _003C_003E4__this;

		internal void _003COnExitAttackSequenceDialoge_003Eb__0(PrefabInstance instance)
		{
			display = new ExitAttackSequenceDisplay(instance);
			display.Setup(_003C_003E4__this._eventExposer);
		}

		internal void _003COnExitAttackSequenceDialoge_003Eb__1()
		{
			if (display != null)
			{
				display.Teardown();
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public LootRewardDisplay display;

		public LootRewardDisplayData data;

		internal void _003COnLootRewardDisplayDialogRequested_003Eb__0(PrefabInstance instance)
		{
			display = new LootRewardDisplay(instance);
			display.ShowRewards(data);
		}

		internal void _003COnLootRewardDisplayDialogRequested_003Eb__1()
		{
			if (display != null)
			{
				display.Teardown();
			}
			data.onDismissCallback?.Invoke();
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public IEntityAnimatronicDisplay display;

		public EntityDisplayData data;

		internal void _003COnEntityWanderingAnimatronicDisplayRequestReceived_003Eb__0(PrefabInstance instance)
		{
			display = new EntityAnimatronicDisplay(instance);
			display.Setup(data, new WanderingAnimatronicDisplayController());
		}

		internal void _003COnEntityWanderingAnimatronicDisplayRequestReceived_003Eb__1()
		{
			if (display != null)
			{
				display.Teardown();
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public IEntityAnimatronicDisplay display;

		public EntityDisplayData data;

		internal void _003COnEntitySpecialDeliveryDisplayDialogRequested_003Eb__0(PrefabInstance instance)
		{
			display = new EntityAnimatronicDisplay(instance);
			display.Setup(data, new SpecialDeliveryDisplayController());
		}

		internal void _003COnEntitySpecialDeliveryDisplayDialogRequested_003Eb__1()
		{
			if (display != null)
			{
				display.Teardown();
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public EntityScanDisplay display;

		public GameDialogAdapter _003C_003E4__this;

		public EntityDisplayData data;

		public GameDialogConfig nextDialog;

		public Action _003C_003E9__2;

		internal void _003CPresentScanningDialogWithFollowup_003Eb__0(PrefabInstance instance)
		{
			display = new EntityScanDisplay(instance);
			display.Setup(_003CPresentScanningDialogWithFollowup_003Eb__2);
		}

		internal void _003CPresentScanningDialogWithFollowup_003Eb__2()
		{
			_003C_003E4__this._eventExposer.OnMapEntityScanned(data.entity);
			_003C_003E4__this.PresentMapEntityInteraction(data, nextDialog);
		}

		internal void _003CPresentScanningDialogWithFollowup_003Eb__1()
		{
			if (display != null)
			{
				display.Teardown();
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public IntroScreenDisplay display;

		public IntroScreen.IntroScreenDialogData data;

		internal void _003COnEntityIntroDisplayDialogRequested_003Eb__0(PrefabInstance instance)
		{
			display = new IntroScreenDisplay(instance);
			display.Setup(data);
		}

		internal void _003COnEntityIntroDisplayDialogRequested_003Eb__1()
		{
			if (display != null)
			{
				display.Teardown();
			}
		}
	}

	public const string CRATE_REWARD_LOC_KEY = "reward_title";

	public const string COLLECT_BUTTON_LOC_KEY = "ui_results_btn_label_collect";

	public const string CONTINUE_BUTTON_LOC_KEY = "ui_loot_reward_screen_continue_button_text";

	private Action<GameDialogConfig> OnConfigGenerated;

	private readonly EventExposer _eventExposer;

	private string _rewardDialogTitle;

	private string _collectButtonString;

	private string _continueButtonString;

	private string _levelText;

	private string _levelUpText;

	public void add_OnConfigGenerated(Action<GameDialogConfig> value)
	{
		OnConfigGenerated = (Action<GameDialogConfig>)Delegate.Combine(OnConfigGenerated, value);
	}

	public void remove_OnConfigGenerated(Action<GameDialogConfig> value)
	{
		OnConfigGenerated = (Action<GameDialogConfig>)Delegate.Remove(OnConfigGenerated, value);
	}

	public GameDialogAdapter(EventExposer eventExposer)
	{
		_eventExposer = eventExposer;
		_eventExposer.add_LootRewardDisplayRequestReceived(OnLootRewardDisplayDialogRequested);
		_eventExposer.add_EntitySpecialDeliveryDisplayRequestReceived(OnEntitySpecialDeliveryDisplayDialogRequested);
		_eventExposer.add_EntityWanderingAnimatronicDisplayRequestReceived(OnEntityWanderingAnimatronicDisplayRequestReceived);
		_eventExposer.add_ExitAttackSequenceReceived(OnExitAttackSequenceDialoge);
		_eventExposer.add_EntityIntroDisplayRequestReceived(OnEntityIntroDisplayRequestReceived);
	}

	public void Teardown()
	{
		_eventExposer.remove_LootRewardDisplayRequestReceived(OnLootRewardDisplayDialogRequested);
		_eventExposer.remove_EntitySpecialDeliveryDisplayRequestReceived(OnEntitySpecialDeliveryDisplayDialogRequested);
		_eventExposer.remove_ExitAttackSequenceReceived(OnExitAttackSequenceDialoge);
		_eventExposer.remove_EntityIntroDisplayRequestReceived(OnEntityIntroDisplayRequestReceived);
	}

	private void OnExitAttackSequenceDialoge(ExitAttackSequenceDialogData data)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass14_.display = null;
		List<string> list = new List<string>();
		list.Add("CTA1");
		list.Add("CTA2");
		list.Add("CTA3");
		Dictionary<string, UnityAction> dictionary = new Dictionary<string, UnityAction>();
		dictionary.Add("CTA1", data.jammerCallback.Invoke);
		dictionary.Add("CTA2", data.leaveCallback.Invoke);
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		dictionary2.Add("CTA1Text", data.jammerButtonText);
		dictionary2.Add("CTA2Text", data.leaveButtonText);
		dictionary2.Add("CTA3Text", data.stayButtonText);
		dictionary2.Add("TitleText", data.titleText);
		dictionary2.Add("BodyText", data.bodyText);
		dictionary2.Add("JammerCostText", data.jammerButtonCost);
		Dictionary<string, bool> dictionary3 = new Dictionary<string, bool>();
		if (!data.shouldJammerBeInteractable)
		{
			Debug.Log("jammer NOT interactable");
			dictionary3.Add("CTA1", value: false);
		}
		Debug.Log("making dialog for attack sequence leave");
		OnConfigGenerated(new GameDialogConfig
		{
			ResourcePath = "ContentAssets/DialogPrefabs/SharedDialog_ExitAttackSequenceConfirm",
			AttachParentName = "SafeAreaContainerDialog",
			OnDismissCallback = _003C_003Ec__DisplayClass14_._003COnExitAttackSequenceDialoge_003Eb__1,
			Strings = dictionary2,
			ButtonCallbacks = dictionary,
			NumberOfStars = default(KeyValuePair<string, int>),
			DismissButtons = list,
			PlayAudioOnShow = true,
			EnableAndroidBackButton = true,
			CustomCachingAction = _003C_003Ec__DisplayClass14_._003COnExitAttackSequenceDialoge_003Eb__0,
			ButtonInteractables = dictionary3
		});
	}

	private void OnEntityIntroDisplayRequestReceived(IntroScreen.IntroScreenDialogData data)
	{
		_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
		_003C_003Ec__DisplayClass69_.data = data;
		_003C_003Ec__DisplayClass69_.display = null;
		List<string> list = new List<string>();
		list.Add("CTA1");
		Dictionary<string, UnityAction> dictionary = new Dictionary<string, UnityAction>();
		dictionary.Add("CTA1", data.encounterCallback.Invoke);
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		if (data.attackProfile != null)
		{
			dictionary2.Add("Page1Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.attackProfile.IntroScreen.Page1Loc, data.attackProfile.IntroScreen.Page1Loc));
			dictionary2.Add("Page2Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.attackProfile.IntroScreen.Page2Loc, data.attackProfile.IntroScreen.Page2Loc));
			dictionary2.Add("Page3Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.attackProfile.IntroScreen.Page3Loc, data.attackProfile.IntroScreen.Page3Loc));
			dictionary2.Add("Page4Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.attackProfile.IntroScreen.Page4Loc, data.attackProfile.IntroScreen.Page4Loc));
		}
		else
		{
			dictionary2.Add("Page1Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.scavengingAttackProfile.IntroScreen.Page1Loc, data.scavengingAttackProfile.IntroScreen.Page1Loc));
			dictionary2.Add("Page2Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.scavengingAttackProfile.IntroScreen.Page2Loc, data.scavengingAttackProfile.IntroScreen.Page2Loc));
			dictionary2.Add("Page3Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.scavengingAttackProfile.IntroScreen.Page3Loc, data.scavengingAttackProfile.IntroScreen.Page3Loc));
			dictionary2.Add("Page4Text", LocalizationDomain.Instance.Localization.GetLocalizedString(data.scavengingAttackProfile.IntroScreen.Page4Loc, data.scavengingAttackProfile.IntroScreen.Page4Loc));
		}
		dictionary2.Add("CTA1Text", LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_encounter", "map_interaction_encounter"));
		OnConfigGenerated(new GameDialogConfig
		{
			ResourcePath = "ContentAssets/DialogPrefabs/EncounterDialog_IntroScreen",
			AttachParentName = "SafeAreaContainerDialog",
			OnDismissCallback = _003C_003Ec__DisplayClass69_._003COnEntityIntroDisplayDialogRequested_003Eb__1,
			Strings = dictionary2,
			ButtonCallbacks = dictionary,
			NumberOfStars = default(KeyValuePair<string, int>),
			DismissButtons = list,
			PlayAudioOnShow = false,
			EnableAndroidBackButton = false,
			CustomCachingAction = _003C_003Ec__DisplayClass69_._003COnEntityIntroDisplayDialogRequested_003Eb__0
		});
	}

	private void OnRewardDialogRequestReceived()
	{
		new List<string> { "CTA1", "FABicon_close" };
		Dictionary<string, string> strings = new Dictionary<string, string>();
		Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();
		Dictionary<string, IconGroup> iconGroups = new Dictionary<string, IconGroup>();
		Dictionary<string, string> spriteNames = new Dictionary<string, string>();
		Dictionary<string, UnityAction> buttonCallbacks = new Dictionary<string, UnityAction>();
		if (OnConfigGenerated != null)
		{
			OnConfigGenerated(new GameDialogConfig
			{
				ResourcePath = "ContentAssets/DialogPrefabs/SharedDialog_CollectReward",
				AttachParentName = "SafeAreaContainerDialog",
				Strings = strings,
				ButtonCallbacks = buttonCallbacks,
				Sprites = sprites,
				IconGroups = iconGroups,
				SpriteNames = spriteNames,
				NumberOfStars = default(KeyValuePair<string, int>),
				PlayAudioOnShow = false,
				AudioEventName = AudioEventName.DailyChallengesRewardDialogOnShow,
				AudioMode = AudioMode.Global,
				EnableAndroidBackButton = false,
				CustomCachingAction = null
			});
		}
	}

	private void OnLootRewardDisplayDialogRequested(LootRewardDisplayData data)
	{
		Debug.Log("received loot display dialog request!");
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.data = data;
		_003C_003Ec__DisplayClass16_.display = null;
		if (string.IsNullOrEmpty(_rewardDialogTitle) && LocalizationDomain.Instance != null && LocalizationDomain.Instance.Localization != null)
		{
			_rewardDialogTitle = LocalizationDomain.Instance.Localization.GetLocalizedString("reward_title", "YOUR REWARDS");
		}
		if (string.IsNullOrEmpty(_collectButtonString) && LocalizationDomain.Instance != null && LocalizationDomain.Instance.Localization != null)
		{
			_collectButtonString = LocalizationDomain.Instance.Localization.GetLocalizedString("ui_results_btn_label_collect", "COLLECT");
		}
		if (string.IsNullOrEmpty(_continueButtonString) && LocalizationDomain.Instance != null && LocalizationDomain.Instance.Localization != null)
		{
			_continueButtonString = LocalizationDomain.Instance.Localization.GetLocalizedString("ui_loot_reward_screen_continue_button_text", "CONTINUE");
		}
		new List<string>();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("TitleText", _rewardDialogTitle);
		dictionary.Add("ConfirmButtonText", _collectButtonString);
		dictionary.Add("ContinueButtonText", _continueButtonString);
		if (OnConfigGenerated != null)
		{
			OnConfigGenerated(new GameDialogConfig
			{
				ResourcePath = "ContentAssets/DialogPrefabs/SharedDialog_LootReward",
				AttachParentName = "SafeAreaContainerDialog",
				OnDismissCallback = _003C_003Ec__DisplayClass16_._003COnLootRewardDisplayDialogRequested_003Eb__1,
				Strings = dictionary,
				NumberOfStars = default(KeyValuePair<string, int>),
				PlayAudioOnShow = true,
				AudioEventName = AudioEventName.DailyChallengesRewardDialogOnShow,
				AudioMode = AudioMode.Global,
				EnableAndroidBackButton = true,
				CustomCachingAction = _003C_003Ec__DisplayClass16_._003COnLootRewardDisplayDialogRequested_003Eb__0
			});
		}
		else
		{
			Debug.LogError("OnConfigGenerated null");
		}
	}

	private void OnEntityWanderingAnimatronicDisplayRequestReceived(EntityDisplayData data)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.data = data;
		_003C_003Ec__DisplayClass19_.display = null;
		PresentMapEntityInteraction(data, new GameDialogConfig
		{
			ResourcePath = "ContentAssets/DialogPrefabs/MapDialog_Animatronic",
			AttachParentName = "SafeAreaContainerDialog",
			OnDismissCallback = _003C_003Ec__DisplayClass19_._003COnEntityWanderingAnimatronicDisplayRequestReceived_003Eb__1,
			NumberOfStars = default(KeyValuePair<string, int>),
			PlayAudioOnShow = true,
			EnableAndroidBackButton = true,
			CustomCachingAction = _003C_003Ec__DisplayClass19_._003COnEntityWanderingAnimatronicDisplayRequestReceived_003Eb__0
		});
	}

	private void OnEntitySpecialDeliveryDisplayDialogRequested(EntityDisplayData data)
	{
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.data = data;
		_003C_003Ec__DisplayClass20_.display = null;
		PresentMapEntityInteraction(data, new GameDialogConfig
		{
			ResourcePath = "ContentAssets/DialogPrefabs/MapDialog_Animatronic",
			AttachParentName = "SafeAreaContainerDialog",
			OnDismissCallback = _003C_003Ec__DisplayClass20_._003COnEntitySpecialDeliveryDisplayDialogRequested_003Eb__1,
			NumberOfStars = default(KeyValuePair<string, int>),
			PlayAudioOnShow = false,
			EnableAndroidBackButton = false,
			CustomCachingAction = _003C_003Ec__DisplayClass20_._003COnEntitySpecialDeliveryDisplayDialogRequested_003Eb__0
		});
	}

	private void PresentMapEntityInteraction(EntityDisplayData data, GameDialogConfig desiredDialog)
	{
		if (data.entity.SynchronizeableState.isRevealed)
		{
			if (OnConfigGenerated != null)
			{
				OnConfigGenerated(desiredDialog);
			}
		}
		else
		{
			PresentScanningDialogWithFollowup(data, desiredDialog);
		}
	}

	private void PresentScanningDialogWithFollowup(EntityDisplayData data, GameDialogConfig nextDialog)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass24_.data = data;
		_003C_003Ec__DisplayClass24_.display = null;
		_003C_003Ec__DisplayClass24_.nextDialog = nextDialog;
		_003C_003Ec__DisplayClass24_._003C_003E9__2 = null;
		if (OnConfigGenerated != null)
		{
			OnConfigGenerated(new GameDialogConfig
			{
				ResourcePath = "ContentAssets/DialogPrefabs/MapDialog_Scanning",
				AttachParentName = "SafeAreaContainerDialog",
				OnDismissCallback = _003C_003Ec__DisplayClass24_._003CPresentScanningDialogWithFollowup_003Eb__1,
				NumberOfStars = default(KeyValuePair<string, int>),
				PlayAudioOnShow = true,
				EnableAndroidBackButton = true,
				CustomCachingAction = _003C_003Ec__DisplayClass24_._003CPresentScanningDialogWithFollowup_003Eb__0
			});
		}
	}
}
