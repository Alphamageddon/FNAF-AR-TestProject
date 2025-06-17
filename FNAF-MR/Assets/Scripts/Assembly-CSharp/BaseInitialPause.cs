using UnityEngine;

public abstract class BaseInitialPause : Phase
{
	public override AttackPhase AttackPhase => AttackPhase.InitialPause;

	protected void RunSharedEnterPhase()
	{
		Debug.LogError("InitialPauseSharedEnterPhase");
		Blackboard.Systems.AnimatronicState.SetEnrageState(ShouldEnrage());
		Blackboard.Systems.AttackStatic.Container.UpdatePhaseStaticSettings(Blackboard.EntityId, Blackboard.StaticConfig.InitialPause, Blackboard.AttackProfile.ShearModifier);
		Blackboard.Systems.Encounter.EncounterAnimatronicInitialized();
		Blackboard.Systems.AttackDisruption.SetUpDisruption(Blackboard.AttackProfile.Disruption, Blackboard.PlushSuitData.SoundBankName, Blackboard.PlushSuitData);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackInitialPauseBegin);
		Blackboard.Systems.Battery.SetBatteryDrain(Blackboard.EntityId, Blackboard.AttackProfile.Battery);
		if (Blackboard.Systems.Shocker == null)
		{
			Debug.LogError("SHOCKER IS NULL");
		}
		Blackboard.Systems.Shocker.SetShockerData(Blackboard.AttackProfile.ShockerCooldownSeconds, Blackboard.AttackProfile.AttackUIData.UseContinuousShocker);
		Blackboard.Systems.HaywireIndicator.Reset();
		if (Blackboard.AttackProfile.AttackUIData.UseSwapper)
		{
			RunSwapperSharedEnterPhase();
		}
		else
		{
			RunStandardSharedEnterPhase();
		}
		EndOfPhase.StartTimer(Random.Range(Blackboard.AttackProfile.InitialPause.Seconds.Min, Blackboard.AttackProfile.InitialPause.Seconds.Max));
	}

	private void RunStandardSharedEnterPhase()
	{
		Blackboard.Systems.Mask.SetMaskAvailable(shouldMaskBeAvailable: true);
		Blackboard.Systems.Flashlight.SetFlashlightAvailable(Blackboard.AttackProfile.AttackUIData.UseFlashlight);
	}

	private void RunSwapperSharedEnterPhase()
	{
		Blackboard.Systems.Mask.SetMaskAvailable(shouldMaskBeAvailable: true);
		Blackboard.Systems.Flashlight.SetFlashlightAvailable(shouldFlashlightBeAvailable: true);
	}

	protected void RunSharedExitPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackInitialPauseEnd);
		Blackboard.Systems.AttackDisruption.StartDisruption();
		Blackboard.Systems.AttackSurge.StartSurge(Blackboard.AttackProfile.Surge);
		Blackboard.Systems.DropsObjectsMechanic.StartSystem(Blackboard.AttackProfile.DropsObjects, Blackboard);
		Blackboard.Systems.VisibilityAlterEffect.StartSystem(Blackboard.AttackProfile.VisibilityAlterEffect, Blackboard.Model);
		Blackboard.Systems.SubEntityMechanic.StartSystem(Blackboard);
	}

	private bool ShouldEnrage()
	{
		if (Blackboard.AttackProfile.EnrageType == EnrageType.Alone)
		{
			return Blackboard.NumAnimatronicsRemaining == 1;
		}
		return false;
	}
}
