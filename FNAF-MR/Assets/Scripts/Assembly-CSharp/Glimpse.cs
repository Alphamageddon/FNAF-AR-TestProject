using UnityEngine;

public class Glimpse : Phase
{
	private GlimpseState _state;

	private GlimpseActivator _glimpseActivator;

	public override AttackPhase AttackPhase => AttackPhase.Glimpse;

	protected override void EnterPhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackGlimpseBegin);
		if (_state != null)
		{
			_state.Reset();
		}
		else
		{
			_state = new GlimpseState(Blackboard.AttackProfile.Glimpse);
		}
		if (_glimpseActivator != null)
		{
			_glimpseActivator.Reset(Blackboard);
		}
		else
		{
			_glimpseActivator = new GlimpseActivator(Blackboard.AttackProfile.Glimpse, Blackboard.Model.GetCloakSettings(), shouldUseDeadZone: false);
		}
		EndOfPhase.StartTimer(Random.Range(_state.Config.PhaseDuration.Min, _state.Config.PhaseDuration.Max));
	}

	protected override AttackPhase UpdatePhase()
	{
		if (_state.ExitTimer.Started && _state.ExitTimer.IsExpired())
		{
			return AttackPhase.Circle;
		}
		if (!_state.ExitTimer.Started && !_state.ExitTimer.IsExpired())
		{
			Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackGlimpseReposition);
			_state.ExitTimer.StartTimer(Random.Range(_state.Config.RepositionDelay.Min, _state.Config.RepositionDelay.Max));
		}
		_glimpseActivator.Update(Blackboard, EndOfPhase.GetRemainingTime());
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackGlimpseEnd);
		TeleportReposition.NormalTeleport(Blackboard);
	}
}
