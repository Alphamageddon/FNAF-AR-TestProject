using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarController : MonoBehaviour
{
	public TextMeshProUGUI percentageText;

	public Slider slider;

	private int Progress;

	private void Awake()
	{
		percentageText = GetComponentInChildren<TextMeshProUGUI>();
		slider = GetComponentInChildren<Slider>();
		Progress = 0;
		slider.value = 0f;
		slider.minValue = 0f;
		slider.maxValue = 100f;
		percentageText.text = "0%";
	}

	public void AddSliderValue(int fullCount)
	{
		Progress = (int)Mathf.Round(Mathf.Min(100f, (float)Progress + 100f / (float)fullCount));
		slider.value = Progress;
		percentageText.text = Progress + "%";
	}

	public void Complete()
	{
		Progress = 100;
		slider.value = Progress;
		percentageText.text = Progress + "%";
	}
}
