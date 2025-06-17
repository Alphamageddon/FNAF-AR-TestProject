public abstract class BaseScavengingJumpscare : Phase
{
	public override AttackPhase AttackPhase => AttackPhase.Jumpscare;

	protected void RunSharedEnterPhase()
	{
		Blackboard.Systems.AttackDisruption.StopDisruption();
		Blackboard.Systems.AttackSurge.StopSurge();
		Blackboard.Systems.DropsObjectsMechanic.StopSystem();
		Blackboard.Systems.NoiseMechanic.StopSystem();
		Blackboard.Systems.VisibilityAlterEffect.StopSystem();
		Blackboard.Systems.SubEntityMechanic.StopSystem();
		Blackboard.Systems.Battery.RemoveBatteryDrain(Blackboard.EntityId);
		Blackboard.Systems.Battery.SetExtraBatteryBlocker(isBlocked: true);
		Blackboard.Systems.Flashlight.SetFlashlightState(setOn: false, shouldPlayAudio: false);
		Blackboard.Model.Teleport(0f, 0f, faceCamera: false);
		Blackboard.Model.SetTransformOverrideMode(TransformOverrider.Mode.JumpscareGlobal);
		Blackboard.Systems.Mask.SetDesiredMaskState(desiredMaskState: false);
		Blackboard.Systems.Encounter.EncounterLost();
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackCpuEncounterEnded);
	}

	protected void RunSharedExitPhase()
	{
		Blackboard.Systems.Mask.SetMaskAvailable(shouldMaskBeAvailable: false);
		Blackboard.Systems.Flashlight.SetFlashlightAvailable(shouldFlashlightBeAvailable: true);
	}
}
