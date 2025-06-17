using System;
using UnityEngine;

namespace VLB
{
	public static class MeshGenerator
	{
		private const float kMinTruncatedRadius = 0.001f;

		private static float GetAngleOffset(int numSides)
		{
			if (numSides != 4)
			{
				return 0f;
			}
			return MathF.PI / 4f;
		}

		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			float radiusEnd = lengthZ * Mathf.Tan(coneAngle * (MathF.PI / 180f) * 0.5f);
			return GenerateConeZ_Radius(lengthZ, radiusStart, radiusEnd, numSides, numSegments, cap, doubleSided);
		}

		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return GenerateConeZ_RadiusAndAngle(lengthZ, 0f, coneAngle, numSides, numSegments, cap, doubleSided);
		}

		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			Mesh mesh = new Mesh();
			bool flag = cap && radiusStart > 0f;
			radiusStart = Mathf.Max(radiusStart, 0.001f);
			int num = numSides * (numSegments + 2);
			int num2 = num;
			if (flag)
			{
				num2 += numSides + 1;
			}
			float angleOffset = GetAngleOffset(numSides);
			Vector3[] array = new Vector3[num2];
			for (int i = 0; i < numSides; i++)
			{
				float f = angleOffset + MathF.PI * 2f * (float)i / (float)numSides;
				float num3 = Mathf.Cos(f);
				float num4 = Mathf.Sin(f);
				for (int j = 0; j < numSegments + 2; j++)
				{
					float num5 = (float)j / (float)(numSegments + 1);
					float num6 = Mathf.Lerp(radiusStart, radiusEnd, num5);
					array[i + j * numSides] = new Vector3(num6 * num3, num6 * num4, num5 * lengthZ);
				}
			}
			if (flag)
			{
				int num7 = num;
				array[num7] = Vector3.zero;
				num7++;
				for (int k = 0; k < numSides; k++)
				{
					float f2 = angleOffset + MathF.PI * 2f * (float)k / (float)numSides;
					float num8 = Mathf.Cos(f2);
					float num9 = Mathf.Sin(f2);
					array[num7] = new Vector3(radiusStart * num8, radiusStart * num9, 0f);
					num7++;
				}
			}
			if (!doubleSided)
			{
				mesh.vertices = array;
			}
			else
			{
				Vector3[] array2 = new Vector3[array.Length * 2];
				array.CopyTo(array2, 0);
				array.CopyTo(array2, array.Length);
				mesh.vertices = array2;
			}
			Vector2[] array3 = new Vector2[num2];
			int num10 = 0;
			for (int l = 0; l < num; l++)
			{
				array3[num10++] = Vector2.zero;
			}
			if (flag)
			{
				for (int m = 0; m < numSides + 1; m++)
				{
					array3[num10++] = new Vector2(1f, 0f);
				}
			}
			if (!doubleSided)
			{
				mesh.uv = array3;
			}
			else
			{
				Vector2[] array4 = new Vector2[array3.Length * 2];
				array3.CopyTo(array4, 0);
				array3.CopyTo(array4, array3.Length);
				for (int n = 0; n < array3.Length; n++)
				{
					Vector2 vector = array4[n + array3.Length];
					array4[n + array3.Length] = new Vector2(vector.x, 1f);
				}
				mesh.uv = array4;
			}
			int num11 = numSides * 2 * Mathf.Max(numSegments + 1, 1) * 3;
			if (flag)
			{
				num11 += numSides * 3;
			}
			int[] array5 = new int[num11];
			int num12 = 0;
			for (int num13 = 0; num13 < numSides; num13++)
			{
				int num14 = num13 + 1;
				if (num14 == numSides)
				{
					num14 = 0;
				}
				for (int num15 = 0; num15 < numSegments + 1; num15++)
				{
					int num16 = num15 * numSides;
					array5[num12++] = num16 + num13;
					array5[num12++] = num16 + num14;
					array5[num12++] = num16 + num13 + numSides;
					array5[num12++] = num16 + num14 + numSides;
					array5[num12++] = num16 + num13 + numSides;
					array5[num12++] = num16 + num14;
				}
			}
			if (flag)
			{
				for (int num17 = 0; num17 < numSides - 1; num17++)
				{
					array5[num12++] = num;
					array5[num12++] = num + num17 + 2;
					array5[num12++] = num + num17 + 1;
				}
				array5[num12++] = num;
				array5[num12++] = num + 1;
				array5[num12++] = num + numSides;
			}
			if (!doubleSided)
			{
				mesh.triangles = array5;
			}
			else
			{
				int[] array6 = new int[array5.Length * 2];
				array5.CopyTo(array6, 0);
				for (int num18 = 0; num18 < array5.Length; num18 += 3)
				{
					array6[array5.Length + num18] = array5[num18] + num2;
					array6[array5.Length + num18 + 1] = array5[num18 + 2] + num2;
					array6[array5.Length + num18 + 2] = array5[num18 + 1] + num2;
				}
				mesh.triangles = array6;
			}
			Bounds bounds = new Bounds(new Vector3(0f, 0f, lengthZ * 0.5f), new Vector3(Mathf.Max(radiusStart, radiusEnd) * 2f, Mathf.Max(radiusStart, radiusEnd) * 2f, lengthZ));
			mesh.bounds = bounds;
			return mesh;
		}

		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			int num = numSides * (numSegments + 2);
			if (geomCap)
			{
				num += numSides + 1;
			}
			if (doubleSided)
			{
				num *= 2;
			}
			return num;
		}

		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			int num = numSides * (numSegments + 1) * 2 * 3;
			if (geomCap)
			{
				num += numSides * 3;
			}
			if (doubleSided)
			{
				num *= 2;
			}
			return num;
		}

		public static int GetSharedMeshVertexCount()
		{
			return GetVertexCount(Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, geomCap: true, Config.Instance.useSinglePassShader);
		}

		public static int GetSharedMeshIndicesCount()
		{
			return GetIndicesCount(Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, geomCap: true, Config.Instance.useSinglePassShader);
		}
	}
}
