using UnityEngine.UI;

public interface IButtonClick
{
	Button button { get; set; }

	bool buttonClicked { get; set; }

	void ButtonClick();
}
