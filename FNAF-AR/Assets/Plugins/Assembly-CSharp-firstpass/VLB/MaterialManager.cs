using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	public static class MaterialManager
	{
		public enum BlendingMode
		{
			Additive = 0,
			SoftAdditive = 1,
			TraditionalTransparency = 2,
			Count = 3
		}

		public enum Noise3D
		{
			Off = 0,
			On = 1,
			Count = 2
		}

		public enum DepthBlend
		{
			Off = 0,
			On = 1,
			Count = 2
		}

		public enum ColorGradient
		{
			Off = 0,
			MatrixLow = 1,
			MatrixHigh = 2,
			Count = 3
		}

		public enum ClippingPlane
		{
			Off = 0,
			On = 1,
			Count = 2
		}

		public class StaticProperties
		{
			public BlendingMode blendingMode;

			public Noise3D noise3D;

			public DepthBlend depthBlend;

			public ColorGradient colorGradient;

			public ClippingPlane clippingPlane;

			public int materialID => (int)((int)((int)((int)((int)blendingMode * 2 + noise3D) * 2 + depthBlend) * 3 + colorGradient) * 2 + clippingPlane);

			public void ApplyToMaterial(Material mat)
			{
				mat.SetKeywordEnabled("VLB_ALPHA_AS_BLACK", BlendingMode_AlphaAsBlack[(int)blendingMode]);
				mat.SetInt("_BlendSrcFactor", (int)BlendingMode_SrcFactor[(int)blendingMode]);
				mat.SetInt("_BlendDstFactor", (int)BlendingMode_DstFactor[(int)blendingMode]);
				mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_LOW", colorGradient == ColorGradient.MatrixLow);
				mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_HIGH", colorGradient == ColorGradient.MatrixHigh);
				mat.SetKeywordEnabled("VLB_DEPTH_BLEND", depthBlend == DepthBlend.On);
				mat.SetKeywordEnabled("VLB_NOISE_3D", noise3D == Noise3D.On);
				mat.SetKeywordEnabled("VLB_CLIPPING_PLANE", clippingPlane == ClippingPlane.On);
			}
		}

		private class MaterialsGroup
		{
			public Material[] materials = new Material[kStaticPropertiesCount];
		}

		public static MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

		private static readonly BlendMode[] BlendingMode_SrcFactor = new BlendMode[3]
		{
			BlendMode.One,
			BlendMode.OneMinusDstColor,
			BlendMode.SrcAlpha
		};

		private static readonly BlendMode[] BlendingMode_DstFactor = new BlendMode[3]
		{
			BlendMode.One,
			BlendMode.One,
			BlendMode.OneMinusSrcAlpha
		};

		private static readonly bool[] BlendingMode_AlphaAsBlack = new bool[3] { true, true, false };

		private static int kStaticPropertiesCount = 72;

		private static Hashtable ms_MaterialsGroup = new Hashtable(1);

		public static Material NewMaterial(bool gpuInstanced)
		{
			Shader beamShader = Config.Instance.beamShader;
			if (!beamShader)
			{
				Debug.LogError("Invalid Beam Shader set in VLB Config");
				return null;
			}
			Material obj = new Material(beamShader)
			{
				hideFlags = Consts.ProceduralObjectsHideFlags,
				renderQueue = Config.Instance.geometryRenderQueue
			};
			GpuInstancing.SetMaterialProperties(obj, gpuInstanced);
			return obj;
		}

		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			MaterialsGroup materialsGroup = (MaterialsGroup)ms_MaterialsGroup[groupID];
			if (materialsGroup == null)
			{
				materialsGroup = new MaterialsGroup();
				ms_MaterialsGroup[groupID] = materialsGroup;
			}
			int materialID = staticProps.materialID;
			Material material = materialsGroup.materials[materialID];
			if (material == null)
			{
				material = NewMaterial(gpuInstanced: true);
				if ((bool)material)
				{
					materialsGroup.materials[materialID] = material;
					staticProps.ApplyToMaterial(material);
				}
			}
			return material;
		}
	}
}
