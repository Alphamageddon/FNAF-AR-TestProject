using UnityEngine;

public class EncounterTriggerSettings
{
	private string _damagedAction;

	private string _slashedAction;

	private string _shutdownAction;

	private string _preShutdownAction;

	public EncounterTriggerSettings(ATTACK_DATA.EncounterTriggerSettings rawSettings)
	{
		if (rawSettings.DamagedAction != null)
		{
			_damagedAction = rawSettings.DamagedAction;
		}
		if (rawSettings.SlashedAction != null)
		{
			_slashedAction = rawSettings.SlashedAction;
		}
		if (rawSettings.ShutdownAction != null)
		{
			Debug.Log("adding shutdownaction " + rawSettings.ShutdownAction);
			_shutdownAction = rawSettings.ShutdownAction;
		}
		if (rawSettings.PreShutdownAction != null)
		{
			Debug.Log("adding preshutdownaction " + rawSettings.PreShutdownAction);
			_preShutdownAction = rawSettings.PreShutdownAction;
			Debug.Log(_preShutdownAction);
		}
	}

	private string GetTriggerActionForPhase(EncounterTrigger trigger)
	{
		string text = "Unset";
		switch (trigger)
		{
		case EncounterTrigger.PreShutdown:
			Debug.Log("Returning PreShutdown action " + _preShutdownAction);
			text = _preShutdownAction;
			break;
		case EncounterTrigger.Shutdown:
			Debug.Log("Returning Shutdown action " + _preShutdownAction);
			text = _shutdownAction;
			break;
		case EncounterTrigger.Damaged:
			text = _damagedAction;
			break;
		case EncounterTrigger.Slashed:
			text = _slashedAction;
			break;
		default:
			text = "None";
			break;
		}
		Debug.Log("Returning action (" + text + ")");
		return text;
	}

	public int GetNextIndexForPhase(EncounterTrigger trigger, int currentIndex)
	{
		if (GetTriggerActionForPhase(trigger) == "ActivateNextAnimatronic")
		{
			return currentIndex + 1;
		}
		if (GetTriggerActionForPhase(trigger) == "ActivatePreviousAnimatronic")
		{
			return currentIndex - 1;
		}
		Debug.Log("cannot get new index, trigger action is " + GetTriggerActionForPhase(trigger) + " trigger is " + trigger);
		return currentIndex;
	}
}
