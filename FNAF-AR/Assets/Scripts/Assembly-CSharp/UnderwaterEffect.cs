using UnityEngine;

[ExecuteInEditMode]
[ImageEffectAllowedInSceneView]
public class UnderwaterEffect : MonoBehaviour
{
	public Material _mat;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Graphics.Blit(source, destination, _mat);
	}
}
