using UnityEngine;

public class Slash : Phase
{
	private bool _raiseAnimStarted;

	private bool _slashAnimStarted;

	private bool _slashAnimRequested;

	private SimpleTimer raisedTimer = new SimpleTimer();

	private int InitialNumShocksRemaining;

	public override AttackPhase AttackPhase => AttackPhase.Slash;

	protected override void EnterPhase()
	{
		_raiseAnimStarted = false;
		_slashAnimStarted = false;
		_slashAnimRequested = false;
		raisedTimer.Reset();
		Blackboard.SlashState.ResetTimers();
		InitialNumShocksRemaining = Blackboard.NumShocksRemaining;
		if (Blackboard.SlashState.UseMultislash())
		{
			StartMultislash();
		}
		else
		{
			StartSlash();
		}
	}

	private void StartSlash()
	{
		if (Blackboard.SlashState.ActiveState.SlashConfig.TeleportToCamera)
		{
			Blackboard.Model.TeleportInFrontOfCamera(Blackboard.Model.GetMovementSettings().HaywireDistance);
		}
		else
		{
			Blackboard.Model.TeleportAtCurrentAngle(Blackboard.Model.GetMovementSettings().HaywireDistance);
		}
		BeginSlashEffects();
	}

	private void StartMultislash()
	{
		if (!Blackboard.SlashState.IsMultislashActive)
		{
			Blackboard.SlashState.IsMultislashActive = true;
			Blackboard.SlashState.RemainingActivations = Random.Range(Blackboard.SlashState.Config.Multislash.Count.Min, Blackboard.SlashState.Config.Multislash.Count.Max + 1);
			StartSlash();
		}
		else
		{
			Blackboard.SlashState.HiddenTimer.StartTimer(Random.Range(Blackboard.SlashState.Config.Multislash.HiddenTime.Min, Blackboard.SlashState.Config.Multislash.HiddenTime.Max));
		}
		Blackboard.SlashState.RemainingActivations--;
	}

	private void BeginSlashEffects()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Attack);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.SlashedRaise, shouldSet: true);
		Blackboard.Model.RaiseAudioEventAnimatronic(AudioEventName.AttackDecloakBegin, useCpu: false);
		Blackboard.Model.BeginDecloak(shouldOpenShock: false);
		Blackboard.Model.BeginEyeDecloak();
	}

	private void RepositionForMultislash()
	{
		float angleFromCamera = Random.Range(Blackboard.SlashState.Config.Multislash.HalfAngle.Min, Blackboard.SlashState.Config.Multislash.HalfAngle.Max) * ((Random.Range(0, 2) > 0) ? (-1f) : 1f);
		Blackboard.Model.Teleport(angleFromCamera, Blackboard.Model.GetMovementSettings().HaywireDistance, faceCamera: true);
		BeginSlashEffects();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (InitialNumShocksRemaining != Blackboard.NumShocksRemaining)
		{
			return AttackPhase.Damaged;
		}
		if (Blackboard.ShockedDuringSlash)
		{
			Blackboard.Systems.Encounter.SetDeathText("death_slash");
			Blackboard.ShockedDuringSlash = false;
			return AttackPhase.Jumpscare;
		}
		if (Blackboard.SlashState.HiddenTimer.Started)
		{
			if (!Blackboard.SlashState.HiddenTimer.IsExpired())
			{
				return AttackPhase.Null;
			}
			Blackboard.SlashState.HiddenTimer.Reset();
			Debug.Log("repositioning for multislash");
			RepositionForMultislash();
			Blackboard.SlashState.LocateTimer.StartTimer(Random.Range(Blackboard.SlashState.Config.Multislash.LocateTime.Min, Blackboard.SlashState.Config.Multislash.LocateTime.Max));
			return AttackPhase.Null;
		}
		if (Blackboard.SlashState.LocateTimer.Started)
		{
			if (!Blackboard.IsAABBOnScreen && !Blackboard.SlashState.LocateTimer.IsExpired())
			{
				return AttackPhase.Null;
			}
			Blackboard.SlashState.LocateTimer.Reset();
			return AttackPhase.Null;
		}
		if (!_raiseAnimStarted)
		{
			if (!raisedTimer.Started)
			{
				float seconds = Blackboard.AttackProfile.Slash.Seconds;
				raisedTimer.StartTimer(seconds);
			}
			if (raisedTimer.Started && raisedTimer.IsExpired())
			{
				_raiseAnimStarted = true;
			}
			return AttackPhase.Null;
		}
		if (!_slashAnimRequested)
		{
			Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Slashed, shouldSet: true);
			_slashAnimRequested = true;
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Slashed))
		{
			if (!_slashAnimStarted)
			{
				_slashAnimStarted = true;
			}
			return AttackPhase.Null;
		}
		if (!_slashAnimStarted)
		{
			return AttackPhase.Null;
		}
		SetUpForPausePhase();
		if (Blackboard.SlashState.IsMultislashActive && Blackboard.SlashState.RemainingActivations > 0)
		{
			return AttackPhase.Slash;
		}
		Blackboard.ForceCircleAfterPause = Blackboard.AttackProfile.Charge.ForceCircleAfterPause;
		return AttackPhase.Pause;
	}

	private void SetUpForPausePhase()
	{
		TeleportReposition.NormalTeleport(Blackboard);
	}

	protected override void ExitPhase()
	{
		_raiseAnimStarted = false;
		_slashAnimStarted = false;
		_slashAnimRequested = false;
		raisedTimer.Reset();
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		if (!Blackboard.SlashState.IsMultislashActive || Blackboard.SlashState.RemainingActivations <= 0)
		{
			Blackboard.SlashState.ActiveState = null;
			Blackboard.SlashState.Cooldown.StartTimer(Blackboard.SlashState.Config.Cooldown);
		}
	}
}
