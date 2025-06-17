using System;
using System.Collections.Generic;
using UnityEngine;

public class MinireenasController : MonoBehaviour
{
	public List<Minireena> minireenas;

	public List<Minireena> thirdMinireenas;

	public bool useData;

	public bool useIndividualShakeThresholds;

	public bool checkDisruptionStrengthForSpawn;

	public float disruptionStrength;

	public float climbSpeed;

	public float shakeTolerance;

	public float timeTillJumpscare;

	public float minTimeTillNextSpawn;

	public float maxTimeTillNextSpawn;

	public float minStrengthRequiredForNextSpawn;

	public float maxStrengthRequiredForNextSpawn;

	private DisruptionData _disruptionData;

	private bool _isActive;

	private List<Minireena> _spawnedMinireenas;

	private bool _isClimbing;

	private int _minireenaCount;

	private AudioPlayer _audioPlayer;

	private string _soundBankOverride;

	private const int SoundEventId = 3000;

	private const string SoundEventJumpscareEnd = "SubEntityJumpscareEnd";

	private float _timeTillNextSpawn;

	private float _currentTime;

	private float _strengthRequiredForNextSpawn;

	private float _previousStrength;

	private float _currentStrength;

	public int MinireenaCount
	{
		get
		{
			return _minireenaCount;
		}
		set
		{
			if (_minireenaCount != value)
			{
				_minireenaCount = value;
				this.OnMinireenaCountChanged?.Invoke(value);
			}
		}
	}

	public event Action<int> OnMinireenaCountChanged;

	private void Start()
	{
		if (!useData)
		{
			UpdateSpawnCondition();
		}
		_audioPlayer = MasterDomain.GetDomain().GameAudioDomain.AudioPlayer;
	}

	private void Update()
	{
		if (useData && !_isActive)
		{
			return;
		}
		if (_minireenaCount >= 1 && useIndividualShakeThresholds)
		{
			ShakeOff();
		}
		if (disruptionStrength > 0f)
		{
			if (_minireenaCount <= 1)
			{
				SpawnMinireenas();
			}
			if (_minireenaCount == 2)
			{
				SpawnThirdMinireena();
			}
		}
		_previousStrength = disruptionStrength;
	}

	private void SpawnMinireenas()
	{
		int num = UnityEngine.Random.Range(0, minireenas.Count);
		if (minireenas[num].IsHidden())
		{
			SpawnMinireena(minireenas[num]);
		}
		else if (minireenas[1 - num].IsHidden())
		{
			SpawnMinireena(minireenas[1 - num]);
		}
	}

	private void SpawnThirdMinireena()
	{
		SpawnMinireena(thirdMinireenas[UnityEngine.Random.Range(0, thirdMinireenas.Count)]);
	}

	private void SpawnMinireena(Minireena minireena)
	{
		_currentTime = Time.time;
		if (!(disruptionStrength < _strengthRequiredForNextSpawn) && !(_currentTime < _timeTillNextSpawn))
		{
			minireena.timeTillJumpscare = ((_disruptionData == null) ? timeTillJumpscare : _disruptionData.ScreenObjectAnimationDurations[Mathf.Min(_minireenaCount, 0)]);
			minireena.Climb();
			float num = ((_disruptionData == null) ? climbSpeed : _disruptionData.ScreenObjectAnimationSpeed);
			minireena.SetClimbSpeed(num);
			minireena.ShakeTolerance = shakeTolerance;
			AnimationEventListener component = minireena.GetComponent<AnimationEventListener>();
			component.OnAnimationEventReceived -= AnimationEventReceived;
			component.OnAnimationEventReceived += AnimationEventReceived;
			_spawnedMinireenas.Add(minireena);
			MinireenaCount = _minireenaCount + 1;
			UpdateSpawnCondition();
		}
	}

	private void ShakeOff()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < _spawnedMinireenas.Count; i++)
		{
			_spawnedMinireenas[i].CurrentToleranceModifier = (float)_minireenaCount * 0.15f + (Time.time - _spawnedMinireenas[i].SpawnTime) * 0.05f;
			if (Mathf.Clamp(_previousStrength - disruptionStrength, 0f, (_previousStrength < disruptionStrength) ? 0.5f : (disruptionStrength + -0.05f)) - (_previousStrength - disruptionStrength) <= 0f)
			{
				_spawnedMinireenas[i].Fall();
				list.Add(i);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		int num = 0;
		foreach (int item in list)
		{
			_spawnedMinireenas.RemoveAt(item + num);
			num--;
		}
		UpdateSpawnCondition();
	}

	private void ShakeOffActiveMinireenas()
	{
		foreach (Minireena spawnedMinireena in _spawnedMinireenas)
		{
			spawnedMinireena.Fall();
		}
		_spawnedMinireenas.Clear();
		MinireenaCount = 0;
	}

	private void HideAllMinireenas()
	{
		foreach (Minireena minireena in minireenas)
		{
			minireena.Hide();
		}
		foreach (Minireena thirdMinireena in thirdMinireenas)
		{
			thirdMinireena.Hide();
		}
	}

	private void UpdateSpawnCondition()
	{
		if (checkDisruptionStrengthForSpawn)
		{
			float num = UnityEngine.Random.Range(minStrengthRequiredForNextSpawn, maxStrengthRequiredForNextSpawn);
			_strengthRequiredForNextSpawn = Mathf.Clamp(disruptionStrength + num, 0f, 1f);
		}
		float minInclusive;
		float maxInclusive;
		if (_disruptionData != null)
		{
			minInclusive = ((_disruptionData.ScreenObjectCooldown == null) ? minTimeTillNextSpawn : _disruptionData.ScreenObjectCooldown.Min);
			maxInclusive = ((_disruptionData.ScreenObjectCooldown == null) ? maxTimeTillNextSpawn : _disruptionData.ScreenObjectCooldown.Max);
		}
		else
		{
			minInclusive = minTimeTillNextSpawn;
			maxInclusive = maxTimeTillNextSpawn;
		}
		_timeTillNextSpawn = _currentTime + UnityEngine.Random.Range(minInclusive, maxInclusive);
	}

	public void SetDisruptionData(DisruptionData disruptionData, string soundBankName, Camera camera)
	{
		if (!useData)
		{
			return;
		}
		_soundBankOverride = soundBankName;
		_disruptionData = disruptionData;
		foreach (Minireena minireena in minireenas)
		{
			minireena.targetCamera = camera;
		}
		foreach (Minireena thirdMinireena in thirdMinireenas)
		{
			thirdMinireena.targetCamera = camera;
		}
	}

	public void Activate()
	{
		if (useData)
		{
			_strengthRequiredForNextSpawn = 0f;
			_isActive = true;
			_timeTillNextSpawn = 0f;
		}
	}

	public void SetStrength(float strength)
	{
		if (useData)
		{
			disruptionStrength = strength;
			if (!useIndividualShakeThresholds && Mathf.Epsilon > strength)
			{
				ShakeOffActiveMinireenas();
			}
		}
	}

	public void Deactivate()
	{
		if (useData)
		{
			HideAllMinireenas();
			_audioPlayer.RaiseGameEventForModeWithOverrideByName("SubEntityJumpscareEnd", _soundBankOverride, AudioMode.Camera);
			_isActive = false;
		}
	}

	public void AnimationEventReceived(AnimationEvent animationEvent)
	{
		if (animationEvent.intParameter == 3000)
		{
			_audioPlayer.RaiseGameEventForModeWithOverrideByName(animationEvent.stringParameter, _soundBankOverride, AudioMode.Camera);
		}
	}

	public MinireenasController()
	{
		minireenas = new List<Minireena>();
		thirdMinireenas = new List<Minireena>();
		maxTimeTillNextSpawn = 2f;
		minStrengthRequiredForNextSpawn = 0.15f;
		climbSpeed = 1f;
		shakeTolerance = 0.15f;
		timeTillJumpscare = 4f;
		minTimeTillNextSpawn = 0.5f;
		maxStrengthRequiredForNextSpawn = 0.3f;
		_spawnedMinireenas = new List<Minireena>();
	}
}
