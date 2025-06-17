using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDisplayChanger
{
	private sealed class ClearDisplayBufferUntilSceneReadyCoroutined__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int __state;

		private object __current;

		public GameDisplayChanger __this;

		private Color blackWithAlpha;

		object IEnumerator<object>.Current => __current;

		object IEnumerator.Current => __current;

		public ClearDisplayBufferUntilSceneReadyCoroutined__16(int __state)
		{
			this.__state = __state;
		}

		void IDisposable.Dispose()
		{
		}

		public bool MoveNext()
		{
			if (__state != 1)
			{
				if (__state != 0)
				{
					goto IL_0045;
				}
				__state = 0;
				__this._sceneReady = false;
				blackWithAlpha = Color.clear;
			}
			else
			{
				__state = 0;
			}
			if (!__this._sceneReady)
			{
				GL.Clear(clearDepth: true, clearColor: true, blackWithAlpha);
				__current = 0;
				__state = 1;
				return true;
			}
			goto IL_0045;
			IL_0045:
			return false;
		}

		void IEnumerator.Reset()
		{
			new NotSupportedException();
		}
	}

	private const string STARTUP_SCENE = "StartupScreen";

	private const string LoadingScene = "GameProject_Alpine_CanvasController_Loading_Generic";

	private TheGameDomain domain;

	private SceneLookupTableAccess _lookupTableAccess;

	private GameDisplayData.DisplayType currentDisplay;

	private Stack<GameDisplayData.DisplayType> currentDisplayDialogs;

	private bool _sceneReady;

	private Coroutine _clearDisplayBufferUntilSceneReadyCoroutine;

	private void EventExposer_UICanvasReady(GameDisplayData.DisplayType displayType)
	{
		_ = 5;
	}

	private void EventExposer_UICanvasDidAppear(GameDisplayData.DisplayType displayType)
	{
		if (displayType <= GameDisplayData.DisplayType.childLoadoutDrawer && displayType >= GameDisplayData.DisplayType.dialogStart)
		{
			currentDisplayDialogs.Push(displayType);
		}
	}

	private void EventExposer_UICanvasClosed(GameDisplayData.DisplayType displayType)
	{
		if (displayType <= GameDisplayData.DisplayType.childLoadoutDrawer && displayType >= GameDisplayData.DisplayType.dialogStart)
		{
			currentDisplayDialogs.Pop();
		}
	}

	private void TrySwapGameScenesAndTriggerEvent(GameDisplayData.DisplayType displayType)
	{
		if (displayType != GameDisplayData.DisplayType.firstEncounter && displayType - 12 >= GameDisplayData.DisplayType.proto)
		{
			UpdateDisplayObjects(displayType);
			UpdateDisplayScene(displayType);
			SendDisplayChangeEvent(currentDisplay, displayType);
			currentDisplay = displayType;
		}
	}

	private void UpdateDisplayScene(GameDisplayData.DisplayType displayType)
	{
		if (ShouldLoadScene(displayType))
		{
			TryLoadNewScene(displayType);
		}
		else
		{
			_sceneReady = true;
		}
	}

	private void UpdateDisplayObjects(GameDisplayData.DisplayType displayType)
	{
		foreach (GameDisplayData.DisplayType key in domain.displayKeyValuePairs.Keys)
		{
			if (key == displayType)
			{
				if (domain.displayKeyValuePairs[key] != null)
				{
					domain.displayKeyValuePairs[key].SetActive(value: true);
				}
			}
			else if (domain.displayKeyValuePairs[key] != null)
			{
				domain.displayKeyValuePairs[key].SetActive(value: false);
			}
		}
		UpdateSkybox((int)displayType);
	}

	private void ClearDisplayBufferUntilSceneReady()
	{
		if (_clearDisplayBufferUntilSceneReadyCoroutine != null)
		{
			_clearDisplayBufferUntilSceneReadyCoroutine = null;
		}
	}

	private IEnumerator ClearDisplayBufferUntilSceneReadyCoroutine()
	{
		return new ClearDisplayBufferUntilSceneReadyCoroutined__16(0)
		{
			__this = this
		};
	}

	private bool ShouldLoadScene(GameDisplayData.DisplayType displayType)
	{
		if (domain.sceneKeyValuePairs.ContainsKey(displayType))
		{
			return !SceneManager.GetSceneByName(domain.sceneKeyValuePairs[displayType]).isLoaded;
		}
		return false;
	}

	private void TryLoadNewScene(GameDisplayData.DisplayType displayType)
	{
		if (ShouldLoadScene(displayType))
		{
			AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(domain.sceneKeyValuePairs[displayType], LoadSceneMode.Single);
			asyncOperation.completed += TryLoadNewSceneb__18_0;
			domain.eventExposer.OnLoadScene(asyncOperation);
		}
	}

	private void PlayerDataError(ServerData reponse)
	{
		Debug.LogError("Couldnt get player data heres the error ig: " + reponse.JSON);
	}

	private void UnloadCurrentScene()
	{
		ClearDisplayBufferUntilSceneReady();
		domain.eventExposer.OnPrepareForSceneUnload();
		foreach (GameDisplayData.DisplayType key in domain.sceneKeyValuePairs.Keys)
		{
			if (SceneManager.GetSceneByName(domain.sceneKeyValuePairs[key]).isLoaded)
			{
				UnloadSceneAsync(domain.sceneKeyValuePairs[key]);
			}
		}
	}

	private void SendDisplayChangeEvent(GameDisplayData.DisplayType previousDisplay, GameDisplayData.DisplayType newDisplay)
	{
		GameDisplayData gameDisplayData = new GameDisplayData();
		gameDisplayData.previousDisplay = previousDisplay;
		gameDisplayData.currentDisplay = newDisplay;
		domain.eventExposer.OnGameDisplayChange(gameDisplayData);
	}

	private AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions sceneOptions = UnloadSceneOptions.None)
	{
		return SceneManager.UnloadSceneAsync(sceneName, sceneOptions);
	}

	private void UpdateSkybox(int state)
	{
		Debug.LogError("updating skybox for state " + state);
		if (domain.SkyboxConfigs.SceneMaterial.Length <= state)
		{
			Debug.LogError("No skybox for state " + state);
			return;
		}
		if (domain.SkyboxConfigs.SceneMaterial[state] == null)
		{
			Debug.LogError("Null skybox for state " + state);
			return;
		}
		RenderSettings.skybox = domain.SkyboxConfigs.SceneMaterial[state];
		Debug.LogError("set skybox to" + domain.SkyboxConfigs.SceneMaterial[state]);
		RenderSettings.ambientIntensity = domain.SkyboxConfigs.SceneIntensityMult[state];
	}

	private void AddAndroidBackButtonForMapAction()
	{
	}

	private void ProcessAndroidBackButtonForDisplayChange(GameDisplayData.DisplayType displayType)
	{
	}

	public GameDisplayChanger(TheGameDomain domain, SceneLookupTableAccess lookupTableAccess)
	{
		currentDisplay = GameDisplayData.DisplayType.map;
		currentDisplayDialogs = new Stack<GameDisplayData.DisplayType>();
		this.domain = domain;
		_lookupTableAccess = lookupTableAccess;
	}

	public void Start()
	{
	}

	public void RequestDisplayChange(GameDisplayData.DisplayType displayType)
	{
		UpdateDisplayObjects(displayType);
		UpdateDisplayScene(displayType);
		SendDisplayChangeEvent(currentDisplay, displayType);
		currentDisplay = displayType;
	}

	public void ChangeDisplayToMap()
	{
		RequestDisplayChange(GameDisplayData.DisplayType.map);
	}

	public GameDisplayData.DisplayType GetDisplayType()
	{
		return currentDisplay;
	}

	public bool IsDisplayType(GameDisplayData.DisplayType displayType)
	{
		return currentDisplay == displayType;
	}

	public GameDisplayData.DisplayType GetDialogDisplayType()
	{
		if (currentDisplayDialogs.Count == 0)
		{
			return GameDisplayData.DisplayType.map;
		}
		_ = currentDisplayDialogs;
		return currentDisplayDialogs.Peek();
	}

	public int GetDialogDisplayCount()
	{
		return currentDisplayDialogs.Count;
	}

	private void TryLoadNewSceneb__18_0(AsyncOperation operation)
	{
		_sceneReady = true;
		UpdateDisplayObjects(currentDisplay);
		MasterDomain.GetDomain().eventExposer.OnSceneLoaded(currentDisplay);
	}
}
