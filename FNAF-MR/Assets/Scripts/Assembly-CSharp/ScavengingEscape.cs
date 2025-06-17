public class ScavengingEscape : Phase
{
	public override AttackPhase AttackPhase => AttackPhase.ScavengingEscape;

	protected override void EnterPhase()
	{
		Blackboard.Systems.AttackDisruption.StopDisruption();
		Blackboard.Systems.SubEntityMechanic.StopSystem();
		Blackboard.Systems.Battery.RemoveBatteryDrain(Blackboard.EntityId);
		Blackboard.Systems.Battery.SetExtraBatteryBlocker(isBlocked: true);
		Blackboard.Systems.Mask.SetDesiredMaskState(desiredMaskState: false);
		Blackboard.Systems.Encounter.EncounterWon();
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackCpuEncounterEnded);
	}

	protected override AttackPhase UpdatePhase()
	{
		return AttackPhase.Results;
	}

	protected override void ExitPhase()
	{
		Blackboard.Systems.AttackSurge.StopSurge();
		Blackboard.Systems.Mask.SetMaskAvailable(shouldMaskBeAvailable: false);
		Blackboard.Systems.Flashlight.SetFlashlightAvailable(shouldFlashlightBeAvailable: true);
		Blackboard.Systems.DropsObjectsMechanic.DespawnAllDroppedObjects();
		Blackboard.Systems.DropsObjectsMechanic.StopSystem();
		Blackboard.Systems.NoiseMechanic.StopSystem();
		Blackboard.Systems.VisibilityAlterEffect.StopSystem();
	}
}
