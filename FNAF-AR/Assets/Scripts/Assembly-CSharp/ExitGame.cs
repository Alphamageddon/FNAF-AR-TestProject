using UnityEngine;

public class ExitGame : MonoBehaviour
{
	private float heldTime;

	private bool isExiting;

	private void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			heldTime += Time.deltaTime;
			if (heldTime >= 3f && !isExiting)
			{
				isExiting = true;
				Debug.Log("Exiting game...");
				ExitTheGame();
			}
		}
		else
		{
			heldTime = 0f;
			isExiting = false;
		}
	}

	private void ExitTheGame()
	{
		Application.Quit();
	}
}
