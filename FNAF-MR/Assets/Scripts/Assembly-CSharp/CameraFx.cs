using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFx : MonoBehaviour
{
	public DisruptionFxController disruptionFxController;

	private void Update()
	{
		if (SceneManager.GetActiveScene().buildIndex == 2)
		{
			if (disruptionFxController == null)
			{
				Debug.LogWarning("CameraFx has found disruption controller");
				disruptionFxController = GameObject.Find("UI_Camera").GetComponent<DisruptionFxController>();
			}
		}
		else
		{
			disruptionFxController = null;
		}
	}
}
