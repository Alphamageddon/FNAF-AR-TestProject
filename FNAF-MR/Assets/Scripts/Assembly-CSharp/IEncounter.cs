public interface IEncounter
{
	void Setup(AttackSpawner spawner, AttackDestroyer destroyer, RewardDispatcher rewardDispatcher, IShocker shocker, GameDisplayChanger gameDisplayChanger);

	void Teardown();

	void OnApplicationQuit();

	string GetEntityId();

	bool IsInProgress();

	bool IsPlayingOutro();

	bool CanReturnToMap();

	void ShockerActivated(bool isDisruptionFullyActive);

	void EncounterAnimatronicInitialized();

	AttackUIData GetEncounterUIConfig();

	DropsObjectsMechanicViewModel GetEncounterDropsObjectsViewModel();

	void EncounterWon();

	void EncounterLost();

	void UsedJammer();

	void LeaveEncounter();

	void SetDeathText(string text);

	void ReadyForUi();
}
