public class Damaged : Phase
{
	private const float DAMAGED_ANIMATION_DURATION = 1.1f;

	private const float CLOAK_TIMER_OFFSET = 0.1f;

	private bool _willShutdown;

	private float _cloakTime;

	private SimpleTimer _cloakDelay;

	private SimpleTimer _cloakTimer;

	public override AttackPhase AttackPhase => AttackPhase.Damaged;

	protected override void EnterPhase()
	{
		if (Blackboard.NumShocksRemaining <= 0)
		{
			_willShutdown = true;
			return;
		}
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		_cloakTime = Blackboard.Model.GetCloakSettings().CloakTime;
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Damaged, shouldSet: true);
		if (_cloakDelay == null)
		{
			_cloakDelay = new SimpleTimer();
		}
		_cloakDelay.Reset();
		_cloakDelay.StartTimer(1f);
		if (_cloakTimer == null)
		{
			_cloakTimer = new SimpleTimer();
		}
		_cloakTimer.Reset();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (_willShutdown)
		{
			return AttackPhase.Shutdown;
		}
		if (_cloakDelay.IsExpired() && !_cloakTimer.Started)
		{
			CloakAnimatronic();
		}
		if (!Blackboard.Model.IsAnimationTagActive(AnimationTag.Charge) && !Blackboard.Model.IsAnimationTagActive(AnimationTag.Slashed) && !Blackboard.Model.IsAnimationTagActive(AnimationTag.Damaged) && _cloakTimer.IsExpired())
		{
			SetUpForPausePhase();
			if (!Blackboard.HasAnimatronicToActivate(EncounterTrigger.Damaged))
			{
				return AttackPhase.Pause;
			}
			Blackboard.ActivateNextAnimatronic(EncounterTrigger.Damaged);
			return AttackPhase.WaitForCamera;
		}
		return AttackPhase.Null;
	}

	private void CloakAnimatronic()
	{
		Blackboard.Model.RaiseAudioEventFromPlushSuit(AudioEventName.AttackCloakBegin);
		_cloakTimer.StartTimer(_cloakTime);
		Blackboard.Model.BeginCloak();
		Blackboard.Model.BeginEyeCloak();
	}

	private void SetUpForPausePhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		TeleportReposition.NormalTeleport(Blackboard);
		Blackboard.ForceCircleAfterPause = Blackboard.AttackProfile.Charge.ForceCircleAfterPause;
		Blackboard.ResetPausePhaseChangeGroup = true;
	}

	protected override void ExitPhase()
	{
	}
}
