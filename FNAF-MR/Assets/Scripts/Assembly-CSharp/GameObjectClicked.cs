using UnityEngine;
using UnityEngine.UI;

public class GameObjectClicked : IButtonClick
{
	public bool buttonClicked { get; set; }

	public Button button { get; set; }

	public GameObjectClicked(GameObject gameObject)
	{
		buttonClicked = false;
		if (button == null)
		{
			button = gameObject.AddComponent<Button>();
		}
		button.onClick.RemoveListener(ButtonClick);
		button.onClick.AddListener(ButtonClick);
	}

	public void ButtonClick()
	{
		buttonClicked = true;
	}
}
