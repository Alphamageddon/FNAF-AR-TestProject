using UnityEngine;

public class OrtonDisplayStrings : MonoBehaviour
{
	public static OrtonDisplayStrings Instance;

	private string[] stringsToDisplay;

	public float verticalSpacing = 30f;

	public int fontSize = 20;

	private GUIStyle guiStyle;

	private void Awake()
	{
		Instance = this;
	}

	private void Start()
	{
		guiStyle = new GUIStyle();
		guiStyle.fontSize = fontSize;
		guiStyle.normal.textColor = Color.white;
	}

	public void Display(string[] strings)
	{
		stringsToDisplay = strings;
	}

	private void OnGUI()
	{
		if (stringsToDisplay != null)
		{
			for (int i = 0; i < stringsToDisplay.Length; i++)
			{
				float num = (float)i * verticalSpacing;
				GUI.Label(new Rect(10f, 10f + num, Screen.width, 30f), stringsToDisplay[i], guiStyle);
			}
		}
	}
}
