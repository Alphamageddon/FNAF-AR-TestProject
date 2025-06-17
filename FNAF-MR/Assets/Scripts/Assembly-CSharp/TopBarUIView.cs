using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopBarUIView : MonoBehaviour
{
	[SerializeField]
	[Header("Top Panel")]
	private GameObject topBarParent;

	[SerializeField]
	private TextMeshProUGUI fazTokenText;

	[SerializeField]
	private TextMeshProUGUI nextLevelText;

	[SerializeField]
	private TextMeshProUGUI currentLevelText;

	[SerializeField]
	private Slider levelProgressSlider;

	[SerializeField]
	private TextMeshProUGUI partsNumText;

	[SerializeField]
	private Image playerAvatarImage;

	[SerializeField]
	[Header("Event Currency")]
	private Image EventCurrencyIconImage;

	[SerializeField]
	private GameObject EventCurrencyContainer;

	[SerializeField]
	private TextMeshProUGUI eventCurrencyNumText;

	private MasterDomain _masterDomain;

	private TopBarDisplayHandler _topBarDisplayHandler;

	private TopBarDisplayHandler.TopBarDisplayData _topBarDisplayData;

	private void BuildData()
	{
		TopBarDisplayHandler.TopBarDisplayData topBarDisplayData = new TopBarDisplayHandler.TopBarDisplayData();
		topBarDisplayData.masterDomain = _masterDomain;
		topBarDisplayData.fazTokenText = fazTokenText;
		topBarDisplayData.partsNumText = partsNumText;
		topBarDisplayData.eventCurrencyNumText = eventCurrencyNumText;
		topBarDisplayData.topBarParent = topBarParent;
		topBarDisplayData.gameAssetManagementDomain = _masterDomain.GameAssetManagementDomain;
		topBarDisplayData.playerAvatarImage = playerAvatarImage;
		topBarDisplayData.avatarIconLookup = _masterDomain.PlayerAvatarDomain.AvatarIconHandler;
		topBarDisplayData.eventCurrencyIconImage = EventCurrencyIconImage;
		topBarDisplayData.eventCurrencyContainer = EventCurrencyContainer;
		topBarDisplayData.currentLevelText = currentLevelText;
		topBarDisplayData.nextLevelText = nextLevelText;
		topBarDisplayData.levelProgressSlider = levelProgressSlider;
		_topBarDisplayData = topBarDisplayData;
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
		BuildData();
		_topBarDisplayHandler = new TopBarDisplayHandler(_topBarDisplayData);
	}

	private void Update()
	{
		if (_masterDomain != null && _masterDomain.TheGameDomain != null && !(SceneManager.GetActiveScene().name == "LoadingScene"))
		{
			_topBarDisplayHandler.Update();
		}
	}

	private void OnDestroy()
	{
		_topBarDisplayHandler.OnDestroy();
	}
}
