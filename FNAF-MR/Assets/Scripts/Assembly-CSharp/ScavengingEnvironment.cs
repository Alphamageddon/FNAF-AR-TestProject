using UnityEngine;

public class ScavengingEnvironment : MonoBehaviour
{
	public Transform AnimatronicStartPosition;

	public Transform[] wayPoints;

	public LockerController[] lockers;

	private void Start()
	{
		SetLockerIndexes();
	}

	private void SetLockerIndexes()
	{
		for (int i = 0; i < lockers.Length; i++)
		{
			lockers[i].SetIndex(i);
		}
	}
}
