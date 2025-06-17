using UnityEngine;

public class LoadingAnimatronics : MonoBehaviour
{
	[SerializeField]
	private GameObject[] animatronics;

	private GameObject activeAnimatronic;

	private void Start()
	{
		int num = (int)Random.Range(0f, animatronics.Length);
		activeAnimatronic = animatronics[num];
		activeAnimatronic.SetActive(value: true);
	}
}
