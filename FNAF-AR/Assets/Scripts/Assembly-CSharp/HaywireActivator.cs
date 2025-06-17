using UnityEngine;

public static class HaywireActivator
{
	public static bool CanActivate(Blackboard blackboard, float angle)
	{
		if (!blackboard.Systems.DropsObjectsMechanic.ViewModel.IsDroppedObjectActive)
		{
			return blackboard.HaywireState.ActiveState.Config.AllowedHalfAngle >= angle;
		}
		return false;
	}

	public static void CalculateActivation(HaywireGlobalState haywireState, AttackPhase sourcePhase)
	{
		if (haywireState.FirstActivationRequest)
		{
			haywireState.Cooldown.StartTimer(haywireState.Config.Cooldown);
			haywireState.FirstActivationRequest = false;
		}
		if (haywireState.Cooldown.Started && !haywireState.Cooldown.IsExpired())
		{
			Debug.Log("Cooldown for haywire is active..");
			return;
		}
		HaywirePhaseSettingsData haywirePhaseSettingsData;
		ActivationState activationState;
		switch (sourcePhase)
		{
		case AttackPhase.Charge:
			haywirePhaseSettingsData = haywireState.Config.Charge;
			activationState = haywireState.ChargeState;
			break;
		case AttackPhase.Pause:
			haywirePhaseSettingsData = haywireState.Config.Pause;
			activationState = haywireState.PauseState;
			break;
		case AttackPhase.Circle:
			haywirePhaseSettingsData = haywireState.Config.Circle;
			activationState = haywireState.CircleState;
			break;
		default:
			haywirePhaseSettingsData = haywireState.Config.Circle;
			activationState = haywireState.CircleState;
			break;
		}
		if (haywirePhaseSettingsData == null || activationState == null)
		{
			Debug.LogError("Phase settings data or activation state for haywire for state " + sourcePhase.ToString() + " is null");
			return;
		}
		Debug.Log("Calculating activation for state " + sourcePhase);
		CalculateActivation(haywirePhaseSettingsData, activationState, haywireState);
	}

	private static void CalculateActivation(HaywirePhaseSettingsData phaseSettingsData, ActivationState activationState, HaywireGlobalState haywireState)
	{
		if (phaseSettingsData.UseMax && (float)haywireState.HaywireCount >= haywireState.Config.MaxCount)
		{
			haywireState.ActiveState = null;
			activationState.TimesNotActivated++;
			Debug.Log("haywire count is greater than max. cannot activate.");
			return;
		}
		float num;
		if (phaseSettingsData.ActivationChance == null)
		{
			num = 0f;
		}
		else if (phaseSettingsData.ActivationChance.Modifier >= 0f)
		{
			float num2 = phaseSettingsData.ActivationChance.Modifier * (float)activationState.TimesNotActivated;
			num = phaseSettingsData.ActivationChance.Chance + num2;
		}
		else
		{
			float num3 = phaseSettingsData.ActivationChance.Modifier * (float)activationState.TimesActivated;
			num = phaseSettingsData.ActivationChance.Chance - num3;
		}
		Debug.Log("Haywire activation chance with applied modifier is " + num);
		if (Random.Range(0.0001f, 1f) > num)
		{
			haywireState.ActiveState = null;
			activationState.TimesNotActivated++;
			Debug.Log("Haywire activation chance was not picked.");
			return;
		}
		Debug.Log("Haywire success!");
		haywireState.ResetMultiwire();
		haywireState.ActiveState = activationState;
		activationState.TimesActivated++;
		activationState.TimesNotActivated = 0;
		if (phaseSettingsData.TriggerPercent != null)
		{
			activationState.TriggerPercent = Random.Range(phaseSettingsData.TriggerPercent.Min, phaseSettingsData.TriggerPercent.Max);
		}
		if (phaseSettingsData.AddToMax)
		{
			haywireState.HaywireCount++;
		}
	}
}
