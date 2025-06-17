using EZCameraShake;
using UnityEngine;

public class PhantomOverload : Phase
{
	private PhantomOverloadState _state;

	private float _distanceAtStart;

	public override AttackPhase AttackPhase => AttackPhase.PhantomOverload;

	protected override void EnterPhase()
	{
		Blackboard.Systems.AttackStatic.Container.UpdatePhaseStaticSettings(Blackboard.EntityId, Blackboard.StaticConfig.PhantomWalk, Blackboard.AttackProfile.ShearModifier);
		if (_state != null)
		{
			_state.Reset();
		}
		else
		{
			_state = new PhantomOverloadState(Blackboard.AttackProfile.PhantomOverload);
			_state.Reset();
		}
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackPhantomOverloadPowerUpBegin);
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Overload);
		_state.OverloadTimer.StartTimer(Random.Range(_state.Config.ReactionTime.Min, _state.Config.ReactionTime.Max));
		_distanceAtStart = Blackboard.DistanceFromCamera;
		ClearTriggers();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (EndOfPhase.Started && EndOfPhase.IsExpired())
		{
			return AttackPhase.Pause;
		}
		if (_state.OverloadTimer.Started && _state.OverloadTimer.IsExpired())
		{
			Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackPhantomOverloadPowerUpEnd);
			Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.OverloadExit);
			_state.OverloadTimer.Reset();
		}
		if (Blackboard.PhantomRepositionRequested && !_state.HasRepositionTriggered)
		{
			TriggerReposition();
		}
		if (Blackboard.PhantomOverloadRequested && !_state.HasOverloadEffectTriggered)
		{
			TriggerOverloadEffect();
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Debug.Log("exiting overload phase");
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Pause);
		TeleportReposition.PhantomTeleport(Blackboard, _distanceAtStart);
		ClearTriggers();
	}

	private void ClearTriggers()
	{
		Blackboard.PhantomOverloadRequested = false;
		Blackboard.PhantomRepositionRequested = false;
	}

	private void TriggerOverloadEffect()
	{
		Debug.LogError("overload effect triggered");
		_state.HasOverloadEffectTriggered = true;
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackPhantomOverloadPowerRelease);
		if (Blackboard.Systems.Flashlight.IsOn)
		{
			Blackboard.Systems.Flashlight.SetFlashlightState(setOn: false, shouldPlayAudio: false);
			Blackboard.Systems.Flashlight.SetFlashlightCooldown(Random.Range(_state.Config.FlashlightDisableTime.Min, _state.Config.FlashlightDisableTime.Max));
			CameraShaker.Instance.ShakeOnce(0.5f, 5f, 0f, 1.8f);
		}
	}

	private void TriggerReposition()
	{
		Debug.LogError("reposition triggered");
		_state.HasRepositionTriggered = true;
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackPhantomReposition);
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Reposition);
		Debug.LogError("starting end of phase for overload with time " + Blackboard.Model.GetPhantomRepositionEffectTime());
		EndOfPhase.StartTimer(Blackboard.Model.GetPhantomRepositionEffectTime());
	}
}
