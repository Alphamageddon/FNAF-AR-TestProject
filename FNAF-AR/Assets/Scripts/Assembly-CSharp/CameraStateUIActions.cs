using UnityEngine;

public class CameraStateUIActions : MonoBehaviour
{
	private MasterDomain _masterDomain;

	private EventExposer _masterEvents;

	private void _masterEvents_RewardDialogOpened()
	{
	}

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

	public void SwapButtonTriggered()
	{
	}

	public void EmfMeterPressed()
	{
	}

	public void ExtraBatteryPressed()
	{
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
		_masterEvents = _masterDomain.eventExposer;
		_masterEvents.add_RewardDialogOpened(_masterEvents_RewardDialogOpened);
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
		_masterEvents.remove_RewardDialogOpened(_masterEvents_RewardDialogOpened);
	}
}
