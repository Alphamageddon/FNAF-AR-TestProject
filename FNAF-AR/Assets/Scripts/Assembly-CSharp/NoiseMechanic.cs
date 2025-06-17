using UnityEngine;

public class NoiseMechanic
{
	private Blackboard _blackboard;

	private NoiseMeterData _data;

	private Transform _cameraTransform;

	private AttackSequenceConfigs _configs;

	private PlayerNoiseMeter _playerNoiseMeter;

	private AnimatronicNoiseMeter _animatronicNoiseMeter;

	private bool _isReady;

	private float _pollTimer;

	public PlayerNoiseMeter PlayerNoiseMeter => _playerNoiseMeter;

	public AnimatronicNoiseMeter AnimatronicNoiseMeter => _animatronicNoiseMeter;

	public void StartSystem(AttackUIData UIData, NoiseMeterData noiseMeterData, Blackboard blackboard)
	{
		_blackboard = blackboard;
		_data = noiseMeterData;
		_pollTimer = _configs.NoiseMeterPollingInterval;
		if (UIData.UsePlayerNoiseMeter)
		{
			_playerNoiseMeter = new PlayerNoiseMeter(_cameraTransform, _data.PlayerNoiseMeter, _blackboard, _configs);
			_isReady = true;
		}
		if (UIData.UseAnimatronicNoiseMeter)
		{
			_animatronicNoiseMeter = new AnimatronicNoiseMeter(_data.AnimatronicNoiseMeter, _blackboard);
			_isReady = true;
		}
	}

	public void StopSystem()
	{
		_blackboard = null;
		if (_playerNoiseMeter != null)
		{
			_playerNoiseMeter.TearDown();
		}
		_playerNoiseMeter = null;
		if (_animatronicNoiseMeter != null)
		{
			AnimatronicNoiseMeter.TearDown();
		}
		_animatronicNoiseMeter = null;
		_isReady = false;
	}

	public void Update()
	{
		if (!_isReady)
		{
			return;
		}
		if (_animatronicNoiseMeter != null)
		{
			_animatronicNoiseMeter.Update(Time.deltaTime);
		}
		_pollTimer -= Time.deltaTime;
		if (!(_pollTimer > 0f))
		{
			if (_playerNoiseMeter != null)
			{
				_playerNoiseMeter.Update();
			}
			_pollTimer = _configs.NoiseMeterPollingInterval;
		}
	}

	public NoiseMechanic(AttackSequenceConfigs configs)
	{
		_configs = configs;
	}

	public void Setup(Transform cameraTransform)
	{
		_cameraTransform = cameraTransform;
	}

	public void Teardown()
	{
		StopSystem();
	}
}
