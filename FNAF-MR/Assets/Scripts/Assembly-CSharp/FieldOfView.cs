using System.Collections;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
	public float radius;

	[Range(0f, 360f)]
	public float angle;

	public LayerMask targetMask;

	public LayerMask obstructionMask;

	public bool canSeePlayer { get; private set; }

	private void Start()
	{
		StartCoroutine(FOVRoutine());
	}

	private IEnumerator FOVRoutine()
	{
		WaitForSeconds wait = new WaitForSeconds(0.2f);
		while (true)
		{
			yield return wait;
			FieldOfViewCheck();
		}
	}

	private void FieldOfViewCheck()
	{
		Collider[] array = Physics.OverlapSphere(base.transform.position, radius, targetMask);
		if (array.Length != 0)
		{
			Transform transform = array[0].transform;
			Vector3 normalized = (transform.position - base.transform.position).normalized;
			if (Vector3.Angle(base.transform.forward, normalized) < angle / 2f)
			{
				float maxDistance = Vector3.Distance(base.transform.position, transform.position);
				if (!Physics.Raycast(base.transform.position, normalized, maxDistance, obstructionMask))
				{
					canSeePlayer = true;
				}
				else
				{
					canSeePlayer = false;
				}
			}
			else
			{
				canSeePlayer = false;
			}
		}
		else if (canSeePlayer)
		{
			canSeePlayer = false;
		}
	}
}
