using System.Collections.Generic;
using UnityEngine;

public class ResultsUIView : MonoBehaviour
{
	[SerializeField]
	private DialogHandler_Results dialogHandler_Results;

	[SerializeField]
	private List<GameObject> rewardsDisplayWin;

	[SerializeField]
	private List<GameObject> rewardsDisplayLoss;

	[SerializeField]
	private ResultsPlayerWinUIView playerWinUIView;

	[SerializeField]
	private ResultsPlayerLoseUIView playerLoseUIView;

	[SerializeField]
	private bool useOldSequence;

	private MasterDomain _masterDomain;

	private AudioPlayer _audioPlayer;

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
		AudioPlayerReady(_masterDomain.GameAudioDomain.AudioPlayer);
		_masterDomain.eventExposer.OnRewardDialogOpened();
		_ = useOldSequence;
	}

	private void AudioPlayerReady(AudioPlayer audioPlayer)
	{
		_audioPlayer = audioPlayer;
	}

	private void Start()
	{
		if (useOldSequence || _masterDomain == null)
		{
			return;
		}
		EncounterResult encounterResult = _masterDomain.GameUIDomain.GameUIData.rewardDataModel.encounterResult;
		if (encounterResult == null)
		{
			encounterResult = new EncounterResult();
			encounterResult.EncounterType = EncounterType.Standard;
			encounterResult.PlayerDidWin = false;
			encounterResult.AnimatronicAudioId = "???";
			encounterResult.EntityId = "???";
			encounterResult.CpuId = "???";
			encounterResult.PlushSuitId = "???";
		}
		if (!(dialogHandler_Results == null) && encounterResult.EncounterType != EncounterType.Tutorial)
		{
			if (!encounterResult.PlayerDidWin)
			{
				Debug.Log("Starting lose sequence");
				dialogHandler_Results.ShowResultsPlayerLose();
				playerLoseUIView.StartPlayerLoseSequence(_audioPlayer);
			}
			else
			{
				Debug.Log("Starting win sequence");
				dialogHandler_Results.ShowResultsPlayerWin();
				playerWinUIView.StartPlayerWinSequence(_audioPlayer, allowShortcut: false, allowAds: false);
			}
		}
	}

	private void Update()
	{
		_ = useOldSequence;
	}

	private void OnDestroy()
	{
		if (_masterDomain != null && _masterDomain.eventExposer != null)
		{
			_masterDomain.eventExposer.OnRewardDialogClosed();
		}
		_ = useOldSequence;
	}
}
