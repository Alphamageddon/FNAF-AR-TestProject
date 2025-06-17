using UnityEngine;

public class SetIconSize : MonoBehaviour
{
	public Vector2 size = new Vector2(5f, 5f);

	private SpriteRenderer _sprite;

	private void Start()
	{
		_sprite = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if (!(_sprite.size == size))
		{
			_sprite.size = size;
		}
	}
}
