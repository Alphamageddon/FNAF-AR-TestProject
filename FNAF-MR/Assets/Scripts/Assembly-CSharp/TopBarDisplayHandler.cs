using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopBarDisplayHandler
{
	public class TopBarDisplayData
	{
		public MasterDomain masterDomain;

		public TextMeshProUGUI fazTokenText;

		public TextMeshProUGUI partsNumText;

		public TextMeshProUGUI eventCurrencyNumText;

		public GameObject topBarParent;

		public Image playerAvatarImage;

		public PlayerAvatarIconHandler avatarIconLookup;

		public GameAssetManagementDomain gameAssetManagementDomain;

		public Image eventCurrencyIconImage;

		public GameObject eventCurrencyContainer;

		public TextMeshProUGUI currentLevelText;

		public TextMeshProUGUI nextLevelText;

		public Slider levelProgressSlider;
	}

	private TopBarDisplayData _topBarDisplayData;

	private IconLookup _iconLookup;

	private readonly string MAX_LEVEL_LOC_KEY;

	private readonly string LEVEL_LOC_KEY;

	private void LookupReady(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
		UpdatePlayerAvatarFromPlayerProfile();
	}

	private void EventExposer_PlayerProfileUpdated(PlayerProfile obj)
	{
		UpdatePlayerAvatarImage(obj.avatarId);
	}

	private void EventExposer_OnGameDisplayChanged(GameDisplayData displayData)
	{
		if (ServerTime.IsInitialized())
		{
			UpdateEventCurrencyDisplay();
		}
	}

	private void UpdateEventCurrencyDisplay()
	{
		_topBarDisplayData.eventCurrencyContainer.SetActive(value: false);
	}

	private void UpdatePlayerAvatarFromPlayerProfile()
	{
		string avatarId = ((_topBarDisplayData == null) ? null : _topBarDisplayData.masterDomain.TheGameDomain.loginDomain.playerProfile.avatarId);
		UpdatePlayerAvatarImage(avatarId);
	}

	private void UpdatePlayerAvatarImage(string avatarId)
	{
		_ = _topBarDisplayData.gameAssetManagementDomain;
		_topBarDisplayData.avatarIconLookup.GetAvatarProfileSprite(avatarId, UpdatePlayerAvatarImageb__10_0);
	}

	private void TopBarEnabled(bool showTopBar)
	{
		if (showTopBar)
		{
			UpdatePlayerAvatarFromPlayerProfile();
		}
	}

	private void UpdateTopBarParentVisibility()
	{
		if (!_topBarDisplayData.topBarParent.activeSelf)
		{
			UpdatePlayerAvatarFromPlayerProfile();
		}
		if (SceneManager.GetActiveScene().name == "LoadingScene")
		{
			_topBarDisplayData.topBarParent.SetActive(value: false);
		}
		else
		{
			_topBarDisplayData.topBarParent.SetActive(_topBarDisplayData.masterDomain.TheGameDomain.gameDisplayChanger.IsDisplayType(GameDisplayData.DisplayType.map));
		}
	}

	private void UpdateCurrentParts()
	{
		string text = FormatNumber.ToTopBarKMB(_topBarDisplayData.masterDomain.TheGameDomain.bank.GetCurrency("PARTS"));
		if (_topBarDisplayData.partsNumText != null)
		{
			_topBarDisplayData.partsNumText.text = text;
		}
	}

	private void UpdateCurrentEventCurrency()
	{
		decimal num = _topBarDisplayData.masterDomain.WorkshopDomain.Inventory.CurrencyContainer.Essence;
		_topBarDisplayData.eventCurrencyNumText.text = FormatNumber.ToKMB(num);
	}

	private void UpdateFazTokensText()
	{
		string text = FormatNumber.ToTopBarKMB(_topBarDisplayData.masterDomain.TheGameDomain.bank.GetCurrency("FAZ_TOKENS"));
		if (_topBarDisplayData.fazTokenText != null)
		{
			_topBarDisplayData.fazTokenText.text = text;
		}
	}

	public TopBarDisplayHandler(TopBarDisplayData topBarDisplayData)
	{
		MAX_LEVEL_LOC_KEY = "MaxLevel";
		LEVEL_LOC_KEY = "Level";
		_topBarDisplayData = topBarDisplayData;
		EventExposer eventExposer = topBarDisplayData.masterDomain.eventExposer;
		LookupReady(topBarDisplayData.masterDomain.GameAssetManagementDomain.IconLookupAccess);
		eventExposer.add_PlayerAvatarUpdated(UpdatePlayerAvatarFromPlayerProfile);
		eventExposer.add_PlayerProfileUpdated(EventExposer_PlayerProfileUpdated);
		eventExposer.add_GameDisplayChange(EventExposer_OnGameDisplayChanged);
	}

	private void OnPlayerLevelHandlerReady()
	{
		UpdateLevelDisplay();
	}

	private void UpdateLevelDisplay()
	{
	}

	public void Update()
	{
		UpdateTopBarParentVisibility();
		UpdateCurrentParts();
		UpdateFazTokensText();
		UpdateCurrentEventCurrency();
		UpdateLevelDisplay();
	}

	public void OnDestroy()
	{
		if (_topBarDisplayData.masterDomain.eventExposer != null)
		{
			_topBarDisplayData.masterDomain.eventExposer.remove_PlayerAvatarUpdated(UpdatePlayerAvatarFromPlayerProfile);
			_topBarDisplayData.masterDomain.eventExposer.remove_PlayerProfileUpdated(EventExposer_PlayerProfileUpdated);
			_topBarDisplayData.masterDomain.eventExposer.remove_GameDisplayChange(EventExposer_OnGameDisplayChanged);
		}
	}

	private void UpdateEventCurrencyDisplayb__8_0(Sprite sprite)
	{
		_topBarDisplayData.eventCurrencyIconImage.overrideSprite = sprite;
	}

	private void UpdatePlayerAvatarImageb__10_0(Sprite sprite)
	{
		_topBarDisplayData.playerAvatarImage.overrideSprite = sprite;
	}
}
