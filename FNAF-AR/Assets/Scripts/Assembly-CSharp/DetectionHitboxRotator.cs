using System.Collections;
using UnityEngine;

public class DetectionHitboxRotator : MonoBehaviour
{
	private Transform animatronicTransform;

	private bool isAnimatronic3DNull;

	private void Start()
	{
		StartCoroutine(FindAnimatronic());
	}

	private IEnumerator FindAnimatronic()
	{
		while (GameObject.Find("Animatronic3D") == null)
		{
			yield return null;
		}
		animatronicTransform = GameObject.Find("Animatronic3D").transform;
		isAnimatronic3DNull = false;
		yield return null;
	}

	private void Update()
	{
		if (!isAnimatronic3DNull)
		{
			base.gameObject.transform.LookAt(animatronicTransform, Vector3.up);
			base.transform.eulerAngles = new Vector3(0f, base.transform.eulerAngles.y, 0f);
		}
	}
}
