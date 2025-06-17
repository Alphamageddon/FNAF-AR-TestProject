using TMPro;
using UnityEngine;

public class ProgressUpdaterDebug : MonoBehaviour
{
	public static TextMeshProUGUI text;

	private void Awake()
	{
		text = base.gameObject.GetComponent<TextMeshProUGUI>();
	}
}
