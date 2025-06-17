using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Camera/Scanlines Effect")]
public class ScanlinesEffect : MonoBehaviour
{
	public Shader shader;

	private Material _material;

	[Range(0f, 10f)]
	public float lineWidth = 2f;

	[Range(0f, 1f)]
	public float hardness = 0.9f;

	[Range(0f, 1f)]
	public float displacementSpeed = 0.1f;

	protected Material material
	{
		get
		{
			if (_material == null)
			{
				_material = new Material(shader);
				_material.hideFlags = HideFlags.HideAndDontSave;
			}
			return _material;
		}
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!(shader == null))
		{
			material.SetFloat("_LineWidth", lineWidth);
			material.SetFloat("_Hardness", hardness);
			material.SetFloat("_Speed", displacementSpeed);
			Graphics.Blit(source, destination, material, 0);
		}
	}

	private void OnDisable()
	{
		if ((bool)_material)
		{
			Object.DestroyImmediate(_material);
		}
	}
}
