public interface IBattery
{
	float Charge { get; }

	int NumExtraBatteriesUsed { get; }

	bool IsExtraBatteryAvailableForUse();

	bool IsExtraBatteryActive();

	void SetExtraBatteryBlocker(bool isBlocked);

	void SetBatteryDrain(string id, BatteryData drainSettings);

	void RemoveBatteryDrain(string id);

	void DrainCharge(float drainAmount);

	void RestoreCharge(float restoreAmount);
}
