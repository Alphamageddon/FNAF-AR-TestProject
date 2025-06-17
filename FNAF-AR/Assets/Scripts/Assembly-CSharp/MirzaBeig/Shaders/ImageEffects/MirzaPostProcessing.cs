using System;
using UnityEngine;

namespace MirzaBeig.Shaders.ImageEffects
{
	[Serializable]
	[ExecuteInEditMode]
	public class MirzaPostProcessing : MonoBehaviour
	{
		public Material material;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Graphics.Blit(source, destination, material);
		}
	}
}
