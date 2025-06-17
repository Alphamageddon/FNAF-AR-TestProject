using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingHandler_Shared : MonoBehaviour
{
	[Header("Loading Screen Objects")]
	[SerializeField]
	private GameObject loadingScreen;

	[SerializeField]
	private Slider loadingSlider;

	private MasterDomain domain;

	private bool loading;

	private AsyncOperation currOperation;

	private void Awake()
	{
		domain = MasterDomain.GetDomain();
		domain.eventExposer.add_SceneLoading(SceneLoading);
	}

	private void SceneLoading(AsyncOperation operation)
	{
		if (currOperation == null && operation != null)
		{
			currOperation = operation;
			operation.completed += OnSceneCompleted;
			loadingScreen.SetActive(value: true);
			StartCoroutine("UpdateLoadBar");
		}
	}

	private void OnSceneCompleted(AsyncOperation operation)
	{
		operation.completed -= OnSceneCompleted;
		currOperation = null;
		loadingScreen.SetActive(value: false);
	}

	private IEnumerator UpdateLoadBar()
	{
		while (currOperation != null && !currOperation.isDone)
		{
			loadingSlider.value = currOperation.progress;
			yield return null;
		}
	}
}
