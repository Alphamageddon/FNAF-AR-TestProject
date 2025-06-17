using UnityEngine;

public class PhantomWalk : Phase
{
	private PhantomWalkState _state;

	private float _encounterWinTime;

	private float _encounterBurnTime;

	public override AttackPhase AttackPhase => AttackPhase.PhantomWalk;

	protected override void EnterPhase()
	{
		Blackboard.Systems.AttackStatic.Container.UpdatePhaseStaticSettings(Blackboard.EntityId, Blackboard.StaticConfig.PhantomWalk, Blackboard.AttackProfile.ShearModifier);
		if (_state != null)
		{
			_state.Reset();
		}
		else
		{
			_state = new PhantomWalkState(Blackboard.AttackProfile.PhantomWalk);
			_state.Reset();
			_encounterWinTime = Random.Range(_state.Config.EncounterBurnTime.Min, _state.Config.EncounterBurnTime.Max);
			_encounterBurnTime = 0f;
		}
		MovementSettings movementSettings = Blackboard.Model.GetMovementSettings();
		_state.AnimatedSpeed = movementSettings.AnimatedSpeed;
		_state.JumpscareRange = movementSettings.JumpscareDistance;
		_state.BurnTimeAllowed = Random.Range(_state.Config.PhaseBurnTime.Min, _state.Config.PhaseBurnTime.Max);
		Debug.Log("Allowed burn time: " + _state.BurnTimeAllowed);
		Debug.Log("Win burn time: " + _encounterWinTime);
		StartManifesting();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (!_state.HasManifested)
		{
			if (!(Blackboard.DistanceFromCamera > _state.JumpscareRange))
			{
				return AttackPhase.Jumpscare;
			}
			return AttackPhase.Null;
		}
		bool flag;
		if (Blackboard.IsAABBOnScreen && Blackboard.Systems.Flashlight.IsOn)
		{
			flag = true;
		}
		else
		{
			if (_state.WasBurning)
			{
				Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackWalkBurnEnd);
			}
			flag = false;
			_state.HasTriggeredCounter = false;
		}
		if (!flag || !_state.HasTriggeredCounter)
		{
			if (flag)
			{
				_state.HasTriggeredCounter = true;
				Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackWalkBurnBegin);
			}
		}
		else
		{
			_encounterBurnTime = Time.deltaTime + _encounterBurnTime;
			_state.BurnTime = Time.deltaTime + _state.BurnTime;
		}
		if (flag != _state.WasBurning)
		{
			Blackboard.Model.SetPhantomEffectAndAnimationState(flag ? PhantomFxController.States.Burning : PhantomFxController.States.Walking);
			SetMovementSpeed();
			_state.WasBurning = flag;
		}
		if (_encounterBurnTime >= _encounterWinTime)
		{
			return AttackPhase.Shutdown;
		}
		if (_state.BurnTime >= _state.BurnTimeAllowed)
		{
			if (_state.Config.ShouldHaywire)
			{
				return AttackPhase.Haywire;
			}
			return AttackPhase.PhantomOverload;
		}
		if (!(Blackboard.DistanceFromCamera > _state.JumpscareRange))
		{
			return AttackPhase.Jumpscare;
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Model.UnregisterForPhantomManifestComplete(StartWalking);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackWalkEnd);
		if (_state.WasBurning)
		{
			Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackWalkBurnEnd);
		}
		Blackboard.Model.StopMoving();
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Pause);
	}

	private void StartManifesting()
	{
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackPhantomManifest);
		Blackboard.Model.RegisterForPhantomManifestComplete(StartWalking);
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Manifest);
	}

	private void StartWalking()
	{
		_state.HasManifested = true;
		Blackboard.Model.UnregisterForPhantomManifestComplete(StartWalking);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackWalkBegin);
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Walking);
		SetMovementSpeed();
	}

	private void SetMovementSpeed()
	{
		Blackboard.Model.MoveInLineTowardCamera(Blackboard.Model.GetPhantomAnimationSpeedModifier() * _state.AnimatedSpeed, isWalking: false);
	}
}
