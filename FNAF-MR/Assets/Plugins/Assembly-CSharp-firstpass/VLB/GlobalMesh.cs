using UnityEngine;

namespace VLB
{
	public static class GlobalMesh
	{
		private static Mesh ms_Mesh;

		private static bool ms_DoubleSided;

		public static Mesh Get()
		{
			bool useSinglePassShader = Config.Instance.useSinglePassShader;
			if (ms_Mesh == null || ms_DoubleSided != useSinglePassShader)
			{
				Destroy();
				ms_Mesh = MeshGenerator.GenerateConeZ_Radius(1f, 1f, 1f, Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, cap: true, useSinglePassShader);
				ms_Mesh.hideFlags = Consts.ProceduralObjectsHideFlags;
				ms_DoubleSided = useSinglePassShader;
			}
			return ms_Mesh;
		}

		public static void Destroy()
		{
			if (ms_Mesh != null)
			{
				Object.DestroyImmediate(ms_Mesh);
				ms_Mesh = null;
			}
		}
	}
}
