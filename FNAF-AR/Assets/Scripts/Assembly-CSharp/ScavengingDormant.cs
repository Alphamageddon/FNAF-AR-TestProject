using UnityEngine;

public class ScavengingDormant : Phase
{
	public override AttackPhase AttackPhase => AttackPhase.ScavengingDormant;

	protected override void EnterPhase()
	{
		Blackboard.Model.SetMovementMode(SpaceMover.Mode.SCAVENGING);
		Blackboard.Model.SetAnimationMode(AnimationMode.Scavenging);
		Blackboard.Model.SetAnimationFloat(AnimationFloat.ScavengingMoveSpeed, 0f);
		Debug.LogError("INTITATING TELEPORT FOR SCAVENGING DORMANT");
		Blackboard.Model.ScavengingTeleportToStartPoint(Blackboard.Systems.ScavengingEnvironment);
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.Systems.Encounter.EncounterAnimatronicInitialized();
		Blackboard.Systems.AttackDisruption.SetUpDisruption(Blackboard.AttackProfile.Disruption, Blackboard.PlushSuitData.SoundBankName, Blackboard.PlushSuitData);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackInitialPauseBegin);
		Blackboard.Systems.Battery.SetBatteryDrain(Blackboard.EntityId, Blackboard.ScavengingAttackProfile.Battery);
		if (Blackboard.Systems.Shocker == null)
		{
			Debug.LogError("SHOCKER IS NULL");
		}
		Blackboard.Systems.Shocker.SetShockerData(Blackboard.AttackProfile.ShockerCooldownSeconds, isContinuous: false);
		Blackboard.Systems.Mask.SetMaskAvailable(Blackboard.ScavengingAttackProfile.AttackUIData.ShowMask);
		Blackboard.Systems.Flashlight.SetFlashlightAvailable(Blackboard.ScavengingAttackProfile.AttackUIData.UseFlashlight);
		EndOfPhase.StartTimer(Random.Range(Blackboard.AttackProfile.InitialPause.Seconds.Min, Blackboard.AttackProfile.InitialPause.Seconds.Max));
	}

	protected override AttackPhase UpdatePhase()
	{
		if (!EndOfPhase.IsExpired() || !EndOfPhase.Started)
		{
			return AttackPhase.Null;
		}
		return AttackPhase.ScavengingSearching;
	}

	protected override void ExitPhase()
	{
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackInitialPauseEnd);
		Blackboard.Systems.AttackDisruption.StartDisruption();
		Blackboard.Systems.SubEntityMechanic.StartSystem(Blackboard);
	}
}
