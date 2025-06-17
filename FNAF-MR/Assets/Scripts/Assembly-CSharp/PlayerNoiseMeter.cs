using System;
using UnityEngine;

public class PlayerNoiseMeter
{
	private static float DEAD_ZONE_METER_CAP;

	private PlayerNoiseMeterData _data;

	private Blackboard _blackboard;

	private Transform _cameraTransform;

	private readonly AttackSequenceConfigs _configs;

	private Quaternion _lastRotation;

	private Quaternion _currentRotation;

	private Vector3 _lastPos;

	private Vector3 _currentPos;

	private float _totalNoise;

	private float _noiseModifier;

	public PlayerNoiseMeter(Transform cameraTransform, PlayerNoiseMeterData data, Blackboard blackboard, AttackSequenceConfigs configs)
	{
		_noiseModifier = 1f;
		_data = data;
		_blackboard = blackboard;
		_cameraTransform = cameraTransform;
		_configs = configs;
		Reset();
	}

	private void Reset()
	{
		_lastRotation = _cameraTransform.rotation;
		_currentRotation = _cameraTransform.rotation;
		_lastPos = _cameraTransform.position;
		_currentPos = _cameraTransform.position;
		_totalNoise = 0f;
	}

	public void Update()
	{
		UpdateCameraData();
		AddNoise();
		Decay();
	}

	public void TearDown()
	{
		_blackboard = null;
		_cameraTransform = null;
		_data = null;
	}

	private void UpdateCameraData()
	{
		_lastRotation = _currentRotation;
		_currentRotation = _cameraTransform.rotation;
		_lastPos = _currentPos;
		_currentPos = _cameraTransform.position;
	}

	private void AddNoise()
	{
		AddAngleNoise();
		AddPositionNoise();
		float num = ((!_blackboard.IsAttackPhaseInactive) ? 1f : DEAD_ZONE_METER_CAP);
		_totalNoise = Mathf.Min(_totalNoise, _data.NoiseToJumpScare * num);
		if (!(_totalNoise * _noiseModifier < _data.NoiseToJumpScare))
		{
			_blackboard.Systems.Encounter.SetDeathText("death_noise");
			_blackboard.ForceJumpscare = true;
		}
	}

	private void Decay()
	{
		_totalNoise = Math.Max(0f, _totalNoise - _data.NoiseDecayPerTick);
	}

	public int GetDisplayValue()
	{
		if (_totalNoise > 0f)
		{
			return (int)(_totalNoise * _noiseModifier / _data.NoiseToJumpScare * 10f) + 1;
		}
		return 0;
	}

	public void SetNoiseModifier(float noiseModifier)
	{
		_noiseModifier = noiseModifier + 1f;
	}

	private void AddAngleNoise()
	{
		float num = Quaternion.Angle(_currentRotation, _lastRotation);
		num = Mathf.Pow(num * _data.RotationScale, _data.RotationExponent);
		if (!(num < _configs.MinAngleDelta))
		{
			_totalNoise += num;
		}
	}

	private void AddPositionNoise()
	{
		Vector3 vector = _currentPos - _lastPos;
		float f = Mathf.Abs(vector.x) * _data.PositionScale.x;
		f = Mathf.Pow(f, _data.PositionExponent.x);
		float f2 = Mathf.Abs(vector.y) * _data.PositionScale.y;
		f2 = Mathf.Pow(f2, _data.PositionExponent.y);
		float f3 = Mathf.Abs(vector.z) * _data.PositionScale.z;
		f3 = Mathf.Pow(f3, _data.PositionExponent.z);
		float num = f + f2 + f3;
		if (!(num < _data.NoiseToJumpScare))
		{
			_totalNoise += num;
		}
	}

	static PlayerNoiseMeter()
	{
		DEAD_ZONE_METER_CAP = 0.7f;
	}
}
