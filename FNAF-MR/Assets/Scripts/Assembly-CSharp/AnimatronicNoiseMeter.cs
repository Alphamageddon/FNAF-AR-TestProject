using UnityEngine;

public class AnimatronicNoiseMeter
{
	private AnimatronicNoiseMeterData _data;

	private Blackboard _blackboard;

	private float _timer;

	private float _displayValuePaddingPercent;

	public AnimatronicNoiseMeter(AnimatronicNoiseMeterData data, Blackboard blackboard)
	{
		_data = data;
		_blackboard = blackboard;
		Reset();
	}

	private void Reset()
	{
		_timer = 0f;
		_displayValuePaddingPercent = 0f;
	}

	public void Update(float delta)
	{
		if (_blackboard.IsAttackPhaseInactive)
		{
			return;
		}
		if (_blackboard.AbsoluteAngleFromCamera > _data.ViewingAngle)
		{
			_timer = Mathf.Max(0f, _timer - _data.TimerDecayPerTick);
			return;
		}
		_timer += delta;
		if (!(_timer < _data.TimeToJumpScare) && _blackboard.Phase != AttackPhase.Charge)
		{
			_blackboard.Systems.Encounter.SetDeathText("death_noise");
			_blackboard.ForceJumpscare = true;
		}
	}

	public void TearDown()
	{
		_data = null;
		_blackboard = null;
	}

	public int GetDisplayValue()
	{
		float num = (_blackboard.AbsoluteAngleFromCamera - _data.ViewingAngle) / (180f - _data.ViewingAngle);
		return (int)(Mathf.Max(_displayValuePaddingPercent + (1f - num), 0f) * 10f);
	}

	public void SetDisplayValuePadding(float displayValuePaddingPercent)
	{
		_displayValuePaddingPercent = displayValuePaddingPercent;
	}
}
