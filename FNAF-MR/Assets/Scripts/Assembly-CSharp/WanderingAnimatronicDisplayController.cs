using System.Collections;
using UnityEngine;

public class WanderingAnimatronicDisplayController : IAnimatronicDisplayController
{
	private const string LKEY_ACTION_ENCOUNTER = "map_interaction_encounter";

	private const string LKEY_ACTION_JAMMER = "map_interaction_button_1";

	private const string LKEY_ALERT_JAM = "map_interaction_locationlost";

	private const string LKEY_ALERT_FLEE = "map_interaction_luckyescape";

	private const string LKEY_ALERT_ATTACK = "map_interaction_specialdelivery";

	private IEntityAnimatronicDisplay _target;

	private bool _willDismiss;

	private float _alertDelay;

	private float PostStarBarFillDelaySeconds = 5f;

	private CPUData _cpuData;

	private int _currentPerception;

	public void PreSetup(IEntityAnimatronicDisplay target)
	{
		target.EncounterButtonText.text = LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_encounter", "Encounter (unlocalized)");
		target.JammerButtonText.text = LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_button_1", "Jammer (unlocalized)");
	}

	public void OnSetup(IEntityAnimatronicDisplay target, float alertDelay)
	{
		_target = target;
		_willDismiss = false;
		_alertDelay = alertDelay;
		_cpuData = MasterDomain.GetDomain().ItemDefinitionDomain.ItemDefinitions.GetCPUById(_target.Entity.CPUId);
		_currentPerception = _target.Entity.SynchronizeableState.perception;
		StartDefaultBehavior();
	}

	public void OnFullScreenClicked()
	{
		OnCloseClicked();
	}

	public void OnJammerClicked()
	{
		SetUpJammingUI();
		_willDismiss = true;
	}

	public void OnCloseClicked()
	{
		_ = _willDismiss;
		_target.Flee();
	}

	private void StartDefaultBehavior()
	{
		_target.SetButtonVisibility(canJam: true, canEncounter: true, canClose: false);
		FillStatbarsAndRunPerceptionTimer();
	}

	private void FillStatbarsAndRunPerceptionTimer()
	{
		_target.CoroutineRunner.StartCoroutine(_target.AnimateStatBarFill());
		RollAndPerformAnimatronicAction();
	}

	private void RollAndPerformAnimatronicAction()
	{
		if (_target.Entity.SynchronizeableState.aggression >= 6)
		{
			_target.CoroutineRunner.StartCoroutine(RunAttackTimer());
		}
		else
		{
			_target.CoroutineRunner.StartCoroutine(RunFleeTimer());
		}
	}

	private IEnumerator RunAttackTimer()
	{
		yield return new WaitForSeconds(PostStarBarFillDelaySeconds);
		if (!_willDismiss)
		{
			SetUpSpecialDeliveryUI();
		}
		yield return new WaitForSeconds(_alertDelay);
		if (!_willDismiss)
		{
			_target.Encounter();
		}
	}

	private IEnumerator RunFleeTimer()
	{
		yield return new WaitForSeconds(PostStarBarFillDelaySeconds);
		SetUpFleeUI();
		_willDismiss = true;
		yield return new WaitForSeconds(_alertDelay);
		_target.Flee();
	}

	private void SetUpSpecialDeliveryUI()
	{
		_target.SetButtonVisibility(canJam: true, canEncounter: true, canClose: false);
		_target.ShowAlert("map_interaction_specialdelivery", EntityAnimatronicAlertStyle.SpecialDelivery);
	}

	private void SetUpFleeUI()
	{
		_target.SetButtonVisibility(canJam: false, canEncounter: false, canClose: true);
		_target.ShowAlert("map_interaction_luckyescape", EntityAnimatronicAlertStyle.Jammed);
	}

	private void SetUpJammingUI()
	{
		_target.SetButtonVisibility(canJam: false, canEncounter: false, canClose: true);
		_target.ShowAlert("map_interaction_locationlost", EntityAnimatronicAlertStyle.Jammed);
	}

	private float CalculatePerceptionDelay()
	{
		while (_currentPerception <= Random.Range(_cpuData.Perception.Min, _cpuData.Perception.Max))
		{
			_currentPerception = _cpuData.Perception.Increment + 5;
		}
		return 5f;
	}
}
