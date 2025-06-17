using UnityEngine;

public class ScavengingStateUIActions : MonoBehaviour
{
	private MasterDomain _masterDomain;

	private EventExposer _masterEvents;

	public void ShockButtonTriggered()
	{
		_masterDomain.AttackSequenceDomain.ShockerActivated(activated: true);
	}

	public void ShockButtonReleased()
	{
		_masterDomain.AttackSequenceDomain.ShockerActivated(activated: false);
	}

	public void FlashlightButtonTriggered()
	{
		if (!_masterDomain.CameraEquipmentDomain.Flashlight.IsOn && !_masterDomain.CameraEquipmentDomain.Flashlight.CanTurnOn())
		{
			_masterDomain.CameraEquipmentDomain.Flashlight.TriedToTurnOn();
		}
		else if (!_masterDomain.AttackSequenceDomain.IsDisruptionFullyActive())
		{
			_masterDomain.CameraEquipmentDomain.Flashlight.SetFlashlightState(!_masterDomain.CameraEquipmentDomain.Flashlight.IsOn, shouldPlayAudio: true);
		}
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
		_masterEvents = _masterDomain.eventExposer;
	}
}
