using UnityEngine;

namespace RuntimeHandle
{
	public static class HandleMathUtils
	{
		public const float PRECISION_THRESHOLD = 0.001f;

		public static float ClosestPointOnRay(Ray ray, Ray other)
		{
			float num = Vector3.Dot(ray.direction, other.direction);
			float num2 = Vector3.Dot(other.origin, other.direction);
			float num3 = Vector3.Dot(ray.origin, other.direction);
			float num4 = Vector3.Dot(ray.direction, other.origin);
			float num5 = Vector3.Dot(ray.origin, ray.direction);
			float num6 = num * num - 1f;
			if (Mathf.Abs(num6) < 0.001f)
			{
				return 0f;
			}
			return (num5 - num4 + num * (num2 - num3)) / num6;
		}
	}
}
