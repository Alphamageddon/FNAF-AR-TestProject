using UnityEngine;

public class StormVFXTerrainDemoFollowTargetPosition : MonoBehaviour
{
	public Transform target;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
		base.transform.position = target.position;
	}
}
