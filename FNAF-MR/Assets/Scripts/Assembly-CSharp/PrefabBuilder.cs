using UnityEngine;

public class PrefabBuilder
{
	public static bool BuildPrefab(out PrefabInstance prefabInstance, string prefabPath, string prefabParentName)
	{
		Transform parent = null;
		prefabInstance = new PrefabInstance();
		if (!string.IsNullOrEmpty(prefabPath))
		{
			GameObject gameObject = Resources.Load<GameObject>(prefabPath);
			if (gameObject != null)
			{
				if (!string.IsNullOrEmpty(prefabParentName))
				{
					GameObject gameObject2 = GameObject.Find(prefabParentName);
					if (gameObject2 != null)
					{
						parent = gameObject2.transform;
					}
				}
				prefabInstance.Root = Object.Instantiate(gameObject, parent);
				prefabInstance.ComponentContainer = new ComponentContainer();
				return true;
			}
		}
		return false;
	}
}
