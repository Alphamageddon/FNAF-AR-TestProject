using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
	[SerializeField]
	private Sprite[] sprite;

	public Image ImageComponent;

	public void ChangeImage()
	{
		if (sprite.Length >= 2)
		{
			ImageComponent.sprite = sprite[1];
		}
	}
}
