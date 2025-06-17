using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomNightCell : MonoBehaviour
{
	[Header("Animatronic Image")]
	[SerializeField]
	private Image animatronicImage;

	[Header("Number Changer")]
	[SerializeField]
	private TextMeshProUGUI valueText;

	[SerializeField]
	private Button leftButton;

	[SerializeField]
	private Button rightButton;

	private int currValue;

	private CustomNightAnimatronic animatronic;

	private void Start()
	{
		leftButton.onClick.AddListener(ValueDown);
		rightButton.onClick.AddListener(ValueUp);
		UpdateText();
	}

	private void UpdateText()
	{
		valueText.text = currValue.ToString();
		if (animatronic != null)
		{
			animatronic.InitialAIValue = currValue;
		}
	}

	public void SetData(CustomNightAnimatronic CNAnimatronic)
	{
		animatronic = CNAnimatronic;
		MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess.GetIcon(IconGroup.Portrait, CNAnimatronic.PortraitImageName, SetImage);
	}

	private void SetImage(Sprite img)
	{
		animatronicImage.sprite = img;
	}

	private void ValueDown()
	{
		currValue = Mathf.Max(0, currValue - 1);
		UpdateText();
	}

	private void ValueUp()
	{
		currValue = Mathf.Min(20, currValue + 1);
		UpdateText();
	}
}
