using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLobby : MonoBehaviour
{
	public void LoadLobbyScene()
	{
		MasterDomain.GetDomain().TheGameDomain.gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.map);
	}

	public void LoadModelViewer()
	{
		SceneManager.LoadScene(3);
	}

	public void LoadCustomNight()
	{
		SceneManager.LoadScene(6);
	}
}
