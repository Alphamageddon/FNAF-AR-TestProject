using UnityEngine;

public class StormVFXTerrainDemoCamera : MonoBehaviour
{
	public float moveSpeed = 5f;

	public float height = 2f;

	[Space]
	public float acceleration = 10f;

	public float deceleration = 5f;

	private Vector3 velocity;

	private void Start()
	{
	}

	private void Update()
	{
		Vector2 vector = default(Vector2);
		vector.x = Input.GetAxisRaw("Horizontal");
		vector.y = Input.GetAxisRaw("Vertical");
		bool num = vector != Vector2.zero;
		Vector3 zero = Vector3.zero;
		RaycastHit hitInfo;
		bool num2 = Physics.Raycast(base.transform.position, Vector3.down, out hitInfo);
		_ = Vector3.zero;
		if (num2)
		{
			zero.y = hitInfo.point.y + height - base.transform.position.y;
		}
		if (num)
		{
			zero += base.transform.right * vector.x;
			zero += base.transform.forward * vector.y;
			zero.Normalize();
			zero *= moveSpeed;
			velocity = Vector3.MoveTowards(velocity, zero, Time.deltaTime * acceleration);
		}
		else
		{
			velocity = Vector3.MoveTowards(velocity, zero, Time.deltaTime * deceleration);
		}
		Vector3 vector2 = velocity * Time.deltaTime;
		base.transform.position += vector2;
	}
}
