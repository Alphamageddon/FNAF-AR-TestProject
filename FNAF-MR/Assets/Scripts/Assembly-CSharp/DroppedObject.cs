using UnityEngine;

public class DroppedObject : MonoBehaviour
{
	public string audioPrefix;

	public Transform modelRoot;

	public Animator animator;

	public float rimlightBias;

	public readonly SimpleTimer expirationTimer;

	public float SpawnTime;

	public DroppedObject()
	{
		expirationTimer = new SimpleTimer();
	}
}
