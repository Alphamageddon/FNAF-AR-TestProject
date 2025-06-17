using UnityEngine;

public class EncounterSceneCommunicator : MonoBehaviour
{
	private void Start()
	{
		MasterDomain.GetDomain().TheGameDomain.OnGameDisplayDidChange();
	}
}
