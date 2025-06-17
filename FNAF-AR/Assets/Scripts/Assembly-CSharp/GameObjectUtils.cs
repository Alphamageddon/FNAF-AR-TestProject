using UnityEngine;

public static class GameObjectUtils
{
	public static void Enable(GameObject gameObject, bool state)
	{
		if (!IsDestroyed(gameObject))
		{
			if (state)
			{
				gameObject.transform.localScale = Vector3.one;
			}
			else
			{
				gameObject.transform.localScale = Vector3.zero;
			}
		}
	}

	public static bool IsDestroyed(GameObject gameObject)
	{
		return gameObject == null;
	}
}
