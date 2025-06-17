using UnityEngine;

namespace VLB
{
	public static class GpuInstancing
	{
		public const bool isSupported = true;

		public static bool forceEnableDepthBlend => Config.Instance.actualRenderingMode == RenderingMode.GPUInstancing;

		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
			material.enableInstancing = enableInstancing;
			material.SetKeywordEnabled("VLB_GPU_INSTANCING", enableInstancing);
		}

		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			bool result = true;
			if (!CanBeBatched(beamA, ref reasons))
			{
				result = false;
			}
			if (!CanBeBatched(beamB, ref reasons))
			{
				result = false;
			}
			if (beamA.colorMode != beamB.colorMode)
			{
				AppendErrorMessage(ref reasons, "Color Mode mismatch");
				result = false;
			}
			if (beamA.blendingMode != beamB.blendingMode)
			{
				AppendErrorMessage(ref reasons, "Blending Mode mismatch");
				result = false;
			}
			if (beamA.noiseEnabled != beamB.noiseEnabled)
			{
				AppendErrorMessage(ref reasons, "3D Noise enabled mismatch");
				result = false;
			}
			if (!forceEnableDepthBlend && beamA.depthBlendDistance > 0f != beamB.depthBlendDistance > 0f)
			{
				AppendErrorMessage(ref reasons, "Opaque Geometry Blending mismatch");
				result = false;
			}
			return result;
		}

		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			bool result = true;
			if (beam.geomMeshType != MeshType.Shared)
			{
				AppendErrorMessage(ref reason, $"{beam.name} is not using shared mesh");
				result = false;
			}
			if ((bool)beam.GetComponent<DynamicOcclusion>())
			{
				AppendErrorMessage(ref reason, $"{beam.name}: dynamically occluded and non occluded beams cannot be batched together");
				result = false;
			}
			return result;
		}

		private static void AppendErrorMessage(ref string message, string toAppend)
		{
			if (message != "")
			{
				message += "\n";
			}
			message = message + "- " + toAppend;
		}
	}
}
