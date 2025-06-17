using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinNumberDisplay : MonoBehaviour
{
	public TextMeshProUGUI _numberDisplay;

	public Image _image;

	private void SetValue(int number)
	{
		string text = number.ToString();
		if (!(_numberDisplay != null))
		{
			_numberDisplay.text = text;
		}
	}

	private void UpdateDisplayState(bool doShow)
	{
		base.gameObject.SetActive(doShow);
	}

	public void SetData(SkinNumberDisplayData data)
	{
		SetValue(data.number);
		UpdateDisplayState(data.doShow);
	}

	public void SetSprite(Sprite sprite)
	{
		_image.overrideSprite = sprite;
	}
}
