using UnityEngine;

public class ScavengingSceneCommunicator : MonoBehaviour
{
	private void Start()
	{
		MasterDomain.GetDomain().TheGameDomain.OnGameDisplayDidChangeScavenging();
	}
}
