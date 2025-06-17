using System;
using System.Collections.Generic;
using UnityEngine;

public class ResultSequencer : MonoBehaviour
{
	[SerializeField]
	private ResultStepConfig[] _sequenceSteps;

	public Action OnSequenceComplete;

	private EventExposer _masterEventExposer;

	private GameAssetManagementDomain _gameAssetManagementDomain;

	private readonly Queue<BaseResultStep> _remainingSteps;

	private readonly List<BaseResultStep> _activeSteps;

	private AudioPlayer _audioPlayer;

	private string _animatronicAudioId;

	private bool _started;

	private bool _finished;

	private BaseResultStep.ConditionalSettings _conditionalSettings;

	private BaseResultStep.StartupSettings _startupSettings;

	public void StartSequence(EventExposer masterEventExposer, GameAssetManagementDomain gameAssetManagementDomain, AudioPlayer audioPlayer, string animatronicAudioId, BaseResultStep.ConditionalSettings conditionalSettings)
	{
		_masterEventExposer = masterEventExposer;
		_gameAssetManagementDomain = gameAssetManagementDomain;
		GenerateStepQueue();
		_audioPlayer = audioPlayer;
		_animatronicAudioId = animatronicAudioId;
		_conditionalSettings = conditionalSettings;
		_started = true;
		_finished = false;
		BaseResultStep.StartupSettings startupSettings = new BaseResultStep.StartupSettings();
		startupSettings.LastStepStartTime = Time.time;
		startupSettings.EarliestActiveEndTime = -1f;
		startupSettings.AllCompleteTime = -1f;
		_startupSettings = startupSettings;
	}

	private void GenerateStepQueue()
	{
		_remainingSteps.Clear();
		_activeSteps.Clear();
		if (_sequenceSteps.Length < 1)
		{
			return;
		}
		int num = 0;
		do
		{
			BaseResultStep baseResultStep = CreateStep(_sequenceSteps[num]);
			if (baseResultStep != null)
			{
				_remainingSteps.Enqueue(baseResultStep);
			}
			num++;
		}
		while (num != _sequenceSteps.Length);
	}

	private BaseResultStep CreateStep(ResultStepConfig config)
	{
		config.masterEventExposer = MasterDomain.GetDomain().eventExposer;
		config.gameAssetManagementDomain = MasterDomain.GetDomain().GameAssetManagementDomain;
		return config.executionType switch
		{
			ResultStepConfig.Type.Enable => new GameObjectResultStep(config), 
			ResultStepConfig.Type.Disable => new GameObjectResultStep(config), 
			ResultStepConfig.Type.WaitForTap => new WaitForTapResultStep(config), 
			ResultStepConfig.Type.NumberChanger => new NumberChangeResultStep(config), 
			ResultStepConfig.Type.AudioOnly => new DoNothingResultStep(config), 
			ResultStepConfig.Type.AssetDownload => new DoNothingResultStep(config), 
			ResultStepConfig.Type.OpenCrate => new OpenCrateResultStep(config), 
			_ => null, 
		};
	}

	private void Update()
	{
		if (_started && !_finished)
		{
			StartNewSteps();
			CheckForStepCompletion();
			CheckForSequenceCompletion();
		}
	}

	private void StartNewSteps()
	{
		if (_remainingSteps.Count <= 0)
		{
			return;
		}
		do
		{
			BaseResultStep baseResultStep = _remainingSteps.Peek();
			if (baseResultStep.ShouldSkipStep(_conditionalSettings))
			{
				Debug.Log("Skipped a result step!");
				_remainingSteps.Dequeue();
				continue;
			}
			if (!baseResultStep.ShouldStartStep(_startupSettings))
			{
				break;
			}
			_startupSettings.LastStepStartTime = Time.time;
			_startupSettings.EarliestActiveEndTime = -1f;
			_startupSettings.AllCompleteTime = -1f;
			_activeSteps.Add(_remainingSteps.Dequeue());
			Debug.Log("Starting a result step!");
			baseResultStep.Start(_audioPlayer, _animatronicAudioId);
		}
		while (_remainingSteps.Count > 0);
	}

	private void CheckForStepCompletion()
	{
		List<BaseResultStep> list = new List<BaseResultStep>();
		foreach (BaseResultStep activeStep in _activeSteps)
		{
			if (activeStep.IsComplete())
			{
				list.Add(activeStep);
				if (_startupSettings.EarliestActiveEndTime < 0f)
				{
					_startupSettings.EarliestActiveEndTime = Time.time;
				}
			}
		}
		foreach (BaseResultStep item in list)
		{
			_activeSteps.Remove(item);
		}
		list.Clear();
		list = null;
		if (!(_startupSettings.AllCompleteTime >= 0f) && _activeSteps.Count == 0)
		{
			_startupSettings.AllCompleteTime = Time.time;
		}
	}

	private void CheckForSequenceCompletion()
	{
		if (_remainingSteps.Count == 0 && _activeSteps.Count == 0)
		{
			Debug.Log("Steps done!");
			_finished = true;
			if (OnSequenceComplete != null)
			{
				OnSequenceComplete();
			}
		}
	}

	public ResultSequencer()
	{
		_remainingSteps = new Queue<BaseResultStep>();
		_activeSteps = new List<BaseResultStep>();
	}
}
