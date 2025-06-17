using UnityEngine;

public class EscToggleMouse : MonoBehaviour
{
	private bool toggled;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			bool flag = (toggled = !toggled);
			Cursor.lockState = ((!flag) ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = flag;
		}
	}
}
