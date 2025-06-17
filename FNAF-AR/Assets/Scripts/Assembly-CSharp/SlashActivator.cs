using UnityEngine;

public class SlashActivator
{
	public static bool CanActivate(Blackboard blackboard, float angle)
	{
		if (blackboard.NumShocksRemaining <= 1)
		{
			return false;
		}
		if (!blackboard.Systems.DropsObjectsMechanic.ViewModel.IsDroppedObjectActive)
		{
			return blackboard.SlashState.ActiveState.SlashConfig.AllowedHalfAngle >= angle;
		}
		return false;
	}

	public static void CalculateActivation(SlashGlobalState slashState, AttackPhase sourcePhase)
	{
		if (slashState.Config == null)
		{
			return;
		}
		if (slashState.FirstActivationRequest)
		{
			slashState.Cooldown.StartTimer(slashState.Config.Cooldown);
			slashState.FirstActivationRequest = false;
		}
		if (slashState.Cooldown.Started && !slashState.Cooldown.IsExpired())
		{
			Debug.Log("Cooldown for slash is active..");
			return;
		}
		SlashPhaseSettingsData slashPhaseSettingsData;
		ActivationState activationState;
		switch (sourcePhase)
		{
		case AttackPhase.Pause:
			slashPhaseSettingsData = slashState.Config.Pause;
			activationState = slashState.PauseState;
			break;
		case AttackPhase.Circle:
			slashPhaseSettingsData = slashState.Config.Circle;
			activationState = slashState.CircleState;
			break;
		default:
			slashPhaseSettingsData = slashState.Config.Circle;
			activationState = slashState.CircleState;
			break;
		}
		if (slashPhaseSettingsData == null || activationState == null)
		{
			Debug.LogError("Phase settings data or activation state for slash for state " + sourcePhase.ToString() + " is null");
			return;
		}
		Debug.Log("Calculating activation for state " + sourcePhase);
		CalculateActivation(slashPhaseSettingsData, activationState, slashState);
	}

	private static void CalculateActivation(SlashPhaseSettingsData phaseSettingsData, ActivationState activationState, SlashGlobalState slashState)
	{
		if (phaseSettingsData.UseMax && (float)slashState.SlashCount >= slashState.Config.MaxCount)
		{
			slashState.ActiveState = null;
			activationState.TimesNotActivated++;
			Debug.Log("slash count is greater than max. cannot activate.");
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
		Debug.Log("Slash activation chance with applied modifier is " + num);
		if (Random.Range(0.0001f, 1f) > num)
		{
			slashState.ActiveState = null;
			activationState.TimesNotActivated++;
			Debug.Log("Slash activation chance was not picked.");
			return;
		}
		Debug.Log("Slash success!");
		slashState.IsMultislashActive = false;
		slashState.RemainingActivations = 0;
		slashState.ActiveState = activationState;
		activationState.TimesActivated++;
		activationState.TimesNotActivated = 0;
		if (phaseSettingsData.TriggerPercent != null)
		{
			activationState.TriggerPercent = Random.Range(phaseSettingsData.TriggerPercent.Min, phaseSettingsData.TriggerPercent.Max);
		}
		if (phaseSettingsData.AddToMax)
		{
			slashState.SlashCount++;
		}
	}
}
