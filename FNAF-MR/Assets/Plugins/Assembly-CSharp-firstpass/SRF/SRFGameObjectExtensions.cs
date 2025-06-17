using UnityEngine;

namespace SRF
{
	public static class SRFGameObjectExtensions
	{
		public static T GetIComponent<T>(this GameObject t) where T : class
		{
			return t.GetComponent(typeof(T)) as T;
		}

		public static T GetComponentOrAdd<T>(this GameObject obj) where T : Component
		{
			T val = obj.GetComponent<T>();
			if (val == null)
			{
				val = obj.AddComponent<T>();
			}
			return val;
		}

		public static void RemoveComponentIfExists<T>(this GameObject obj) where T : Component
		{
			T component = obj.GetComponent<T>();
			if (component != null)
			{
				Object.Destroy(component);
			}
		}

		public static void RemoveComponentsIfExists<T>(this GameObject obj) where T : Component
		{
			T[] components = obj.GetComponents<T>();
			for (int i = 0; i < components.Length; i++)
			{
				Object.Destroy(components[i]);
			}
		}

		public static bool EnableComponentIfExists<T>(this GameObject obj, bool enable = true) where T : MonoBehaviour
		{
			T component = obj.GetComponent<T>();
			if (component == null)
			{
				return false;
			}
			component.enabled = enable;
			return true;
		}

		public static void SetLayerRecursive(this GameObject o, int layer)
		{
			SetLayerInternal(o.transform, layer);
		}

		private static void SetLayerInternal(Transform t, int layer)
		{
			t.gameObject.layer = layer;
			foreach (Transform item in t)
			{
				SetLayerInternal(item, layer);
			}
		}
	}
}
