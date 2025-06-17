using UnityEngine;

public class EditorMouseControls : MonoBehaviour
{
	public float speed = 3.5f;

	private float X;

	private float Y;

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			base.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, (0f - Input.GetAxis("Mouse X")) * speed, 0f));
			X = base.transform.rotation.eulerAngles.x;
			Y = base.transform.rotation.eulerAngles.y;
			base.transform.rotation = Quaternion.Euler(X, Y, 0f);
		}
	}
}
