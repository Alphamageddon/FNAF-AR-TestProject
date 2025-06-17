using UnityEngine;

public class PhantomHaywire : Phase
{
	private PhantomHaywireState _state;

	public override AttackPhase AttackPhase => AttackPhase.Haywire;

	protected override void EnterPhase()
	{
		if (_state == null || _state.GlobalState != Blackboard.HaywireState)
		{
			_state = new PhantomHaywireState(Blackboard.HaywireState);
		}
		_state.Reset();
		_state.Duration = Random.Range(_state.Config.Seconds.Min, _state.Config.Seconds.Max);
		_state.LookAway = true;
		StartHaywire();
	}

	protected override AttackPhase UpdatePhase()
	{
		bool flag = _state.LookAway ^ Blackboard.IsAABBOnScreen;
		if (_state.Config.RequiredMaskState == HaywireMaskState.IgnoreMask || !flag)
		{
			goto IL_0058;
		}
		bool flag2;
		if (_state.Config.RequiredMaskState != HaywireMaskState.MaskOff)
		{
			if (_state.Config.RequiredMaskState != HaywireMaskState.MaskOn)
			{
				goto IL_0058;
			}
			flag2 = true;
		}
		else
		{
			flag2 = false;
		}
		if ((!flag2 && Blackboard.Systems.Mask.IsMaskFullyOff()) || (flag2 && !Blackboard.Systems.Mask.IsMaskFullyOff()))
		{
			goto IL_005b;
		}
		goto IL_00a5;
		IL_005b:
		bool flag3 = false;
		_state.HasTriggeredCounter = false;
		goto IL_00a7;
		IL_00a7:
		if (flag3)
		{
			_state.CumulativeLookTime = Time.deltaTime + _state.CumulativeLookTime;
		}
		else
		{
			_state.HasTriggeredCounter = true;
		}
		if (_state.CumulativeLookTime < _state.Config.LookTime)
		{
			if (!EndOfPhase.IsExpired())
			{
				return AttackPhase.Null;
			}
			return AttackPhase.PhantomOverload;
		}
		string text = _state.CumulativeLookTime.ToString();
		float lookTime = _state.Config.LookTime;
		Debug.LogError("jumpscaring! cumulative is " + text + " and looktime is " + lookTime);
		Blackboard.Systems.Encounter.SetDeathText("death_haywire");
		return AttackPhase.Jumpscare;
		IL_00a5:
		flag3 = true;
		goto IL_00a7;
		IL_0058:
		if (flag)
		{
			goto IL_005b;
		}
		goto IL_00a5;
	}

	protected override void ExitPhase()
	{
		EndHaywireEffect();
	}

	private void StartHaywire()
	{
		BeginHaywireEffect();
		EndOfPhase.StartTimer(_state.Duration);
	}

	private void BeginHaywireEffect()
	{
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackHaywireBegin);
		Blackboard.Systems.HaywireFxController.SetStrength(1f);
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Haywire);
	}

	private void EndHaywireEffect()
	{
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackHaywireEnd);
		Blackboard.Systems.HaywireFxController.SetStrength(0f);
	}
}
