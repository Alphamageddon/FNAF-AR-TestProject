using System.Collections;
using UnityEngine;

public static class CoroutineHelper
{
	private static MonoBehaviour _monoBehaviour;

	private static MonoBehaviour MonoBehaviour => GameObject.Find("Bootstrap").GetComponent<MonoBehaviour>();

	public static Coroutine StartCoroutine(IEnumerator coroutine)
	{
		return MonoBehaviour.StartCoroutine(coroutine);
	}

	public static void StopCoroutine(Coroutine coroutine)
	{
		if (coroutine != null)
		{
			MonoBehaviour.StopCoroutine(coroutine);
		}
	}
}
