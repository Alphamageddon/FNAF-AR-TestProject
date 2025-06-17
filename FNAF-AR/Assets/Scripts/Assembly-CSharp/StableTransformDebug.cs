using UnityEngine;

public class StableTransformDebug : MonoBehaviour
{
	public Transform playerTransform;

	[SerializeField]
	private Transform myTransform;

	private void Update()
	{
		myTransform.localEulerAngles = new Vector3(0f, playerTransform.localEulerAngles.y, 0f);
		myTransform.position = playerTransform.position;
	}
}
