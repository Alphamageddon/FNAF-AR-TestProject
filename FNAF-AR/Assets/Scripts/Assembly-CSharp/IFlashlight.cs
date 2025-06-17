public interface IFlashlight
{
	bool IsOn { get; }

	bool IsFlashlightAvailable { get; }

	float GetCooldownPercent();

	bool CanTurnOn();

	bool HasEnoughBatteryToActivate();

	void TriedToTurnOn();

	void SetFlashlightState(bool setOn, bool shouldPlayAudio);

	void SetFlashlightCooldown(float cooldown);

	void SetFlashlightAvailable(bool shouldFlashlightBeAvailable);
}
