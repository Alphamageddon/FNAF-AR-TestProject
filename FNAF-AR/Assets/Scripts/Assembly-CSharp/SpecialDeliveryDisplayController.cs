using System.Collections;
using UnityEngine;

public class SpecialDeliveryDisplayController : IAnimatronicDisplayController
{
	private const string LKEY_ACTION_ENCOUNTER = "map_interaction_encounter";

	private const string LKEY_ACTION_JAMMER = "map_interaction_button_1";

	private const string LKEY_ALERT_ATTACK = "map_interaction_specialdelivery";

	private const string LKEY_ALERT_JAM = "map_interaction_locationlost";

	private IEntityAnimatronicDisplay _target;

	private bool _willDismiss;

	private float _alertDelay;

	private float PostStarBarFillDelaySeconds = 5f;

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
		target.EncounterButtonText.text = LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_encounter", "Encounter (unlocalized)");
		target.JammerButtonText.text = LocalizationDomain.Instance.Localization.GetLocalizedString("map_interaction_button_1", "Jammer (unlocalized)");
		StartDefaultBehavior();
	}

	public void OnJammerClicked()
	{
		SetUpJammingUI();
		_willDismiss = true;
	}

	public void OnFullScreenClicked()
	{
		OnCloseClicked();
	}

	public void OnCloseClicked()
	{
		_ = _willDismiss;
		_target.Flee();
	}

	private void StartDefaultBehavior()
	{
		_target.SetButtonVisibility(canJam: true, canEncounter: true, canClose: false);
		_target.CoroutineRunner.StartCoroutine(DoSpecialDelivery());
	}

	private IEnumerator DoSpecialDelivery()
	{
		yield return new WaitForSeconds(PostStarBarFillDelaySeconds);
		_target.SetButtonVisibility(canJam: true, canEncounter: true, canClose: false);
		_target.ShowAlert("map_interaction_specialdelivery", EntityAnimatronicAlertStyle.SpecialDelivery);
		yield return new WaitForSeconds(_alertDelay);
		if (!_willDismiss)
		{
			_target.Encounter();
		}
	}

	private void SetUpJammingUI()
	{
		_target.SetButtonVisibility(canJam: false, canEncounter: false, canClose: true);
		_target.ShowAlert("map_interaction_locationlost", EntityAnimatronicAlertStyle.Jammed);
	}
}
