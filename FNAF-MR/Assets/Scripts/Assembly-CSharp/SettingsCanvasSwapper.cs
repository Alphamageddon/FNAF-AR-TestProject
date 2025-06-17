using UnityEngine;
using UnityEngine.UI;

public class SettingsCanvasSwapper : MonoBehaviour
{
	[Header("Canvases")]
	[SerializeField]
	private GameObject SettingsMasterParent;

	private Button settingsButton;

	private void Update()
	{
		if (settingsButton == null)
		{
			GameObject gameObject = GameObject.Find("TopBarSettingsButton");
			if (gameObject != null)
			{
				settingsButton = gameObject.GetComponent<Button>();
				settingsButton.onClick.RemoveListener(SettingsButtonPressed);
				settingsButton.onClick.AddListener(SettingsButtonPressed);
			}
		}
	}

	private void SettingsButtonPressed()
	{
		SettingsMasterParent.SetActive(value: true);
	}

	public void SettingsClosed()
	{
		SettingsMasterParent.SetActive(value: false);
	}
}
