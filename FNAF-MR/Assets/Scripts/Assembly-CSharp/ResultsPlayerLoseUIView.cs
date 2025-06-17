using TMPro;
using UnityEngine;

public class ResultsPlayerLoseUIView : MonoBehaviour
{
	[SerializeField]
	private ResultSequencer playerLoseSequence;

	[SerializeField]
	private GameObject returnButton;

	[SerializeField]
	private NumberChanger streakNumberChanger;

	[SerializeField]
	private TextMeshProUGUI lostRemnantText;

	[SerializeField]
	private TextMeshProUGUI currentRemnantText;

	[SerializeField]
	private NumberChanger remnantNumberChanger;

	[SerializeField]
	private bool shouldFinalRemnantAnimate;

	[SerializeField]
	private TextMeshProUGUI animatronicName;

	[SerializeField]
	private TextMeshProUGUI deathExplanationText;

	private MasterDomain _masterDomain;

	private ResultsDataModel _results;

	private BaseResultStep.ConditionalSettings _conditionalSettings;

	private string _animatronicAudioId;

	public void StartPlayerLoseSequence(AudioPlayer audioPlayer)
	{
		GetDataSources();
		if (ValidateDataSources())
		{
			SetDynamicData();
		}
		else
		{
			Debug.LogError("ResultsPlayerLoseUIView StartPlayerLoseSequence - Missing necessary data to fully display losses. Using fallback data");
		}
		if (_masterDomain != null)
		{
			playerLoseSequence.StartSequence(_masterDomain.eventExposer, _masterDomain.GameAssetManagementDomain, audioPlayer, _animatronicAudioId, _conditionalSettings);
		}
	}

	public void ShowReturnButton()
	{
		returnButton.SetActive(value: true);
	}

	private void GetDataSources()
	{
		_masterDomain = MasterDomain.GetDomain();
		if (_masterDomain != null)
		{
			_results = _masterDomain.GameUIDomain.GameUIData.rewardDataModel;
		}
	}

	private bool ValidateDataSources()
	{
		string text;
		if (_masterDomain != null)
		{
			if (_results != null && _results.encounterResult != null && _results.rewardDataV3 != null)
			{
				return true;
			}
			text = "ResultsDataModel or one of its children are null";
		}
		else
		{
			text = "MasterDomain is null";
		}
		Debug.LogError("ResultsPlayerLoseUIView ValidateDataSources - " + text);
		return false;
	}

	private void SetDynamicData()
	{
		BaseResultStep.ConditionalSettings conditionalSettings = new BaseResultStep.ConditionalSettings();
		conditionalSettings.StartingStreak = _results.encounterResult.OldCurrentStreak;
		conditionalSettings.AllowAds = false;
		_conditionalSettings = conditionalSettings;
		_animatronicAudioId = _results.encounterResult.AnimatronicAudioId;
		streakNumberChanger.InitValues(_results.encounterResult.OldCurrentStreak, _results.encounterResult.NewCurrentStreak);
		lostRemnantText.text = $"-{_results.rewardDataV3.essenceOnLoss}";
		currentRemnantText.text = $"{_results.encounterResult.CurrentRemnant}";
		int num = Mathf.Max(_results.encounterResult.CurrentRemnant - _results.rewardDataV3.essenceOnLoss, 0);
		remnantNumberChanger.InitValues(shouldFinalRemnantAnimate ? _results.encounterResult.CurrentRemnant : num, num);
		animatronicName.SetText(LocalizationDomain.Instance.Localization.GetLocalizedString(_masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(_results.encounterResult.PlushSuitId).AnimatronicName, _masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(_results.encounterResult.PlushSuitId).AnimatronicName));
		deathExplanationText.SetText(LocalizationDomain.Instance.Localization.GetLocalizedString(_results.encounterResult.DeathText, _results.encounterResult.DeathText));
	}
}
