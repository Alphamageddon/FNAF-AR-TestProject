using UnityEngine;

[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class ModifiedGlitchShader : MonoBehaviour
{
	public float ShearStrength = 0.12f;

	public bool InvertScreen;

	public bool InvertGrayScreen;

	private Material _material;

	private float TimeCount;

	private float HorizontalResolution = 480f;

	private float VerticalResolution = 640f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		_material = new Material(Shader.Find("Custom/Mobile Modified Glitch Shader"));
		_material.hideFlags = HideFlags.HideAndDontSave;
		_material.SetFloat("_ResHorizontal", HorizontalResolution);
		_material.SetFloat("_ResVertical", VerticalResolution);
		_material.SetFloat("_Timer", TimeCount);
		_material.SetFloat("_ShearStrength", ShearStrength);
		_material.SetFloat("_ScanlineGlitchEnabled", (ShearStrength == 0f) ? 0f : 1f);
		_material.SetFloat("_InvertScreen", InvertScreen ? 1f : 0f);
		_material.SetFloat("_InvertGrayScreen", InvertGrayScreen ? 1f : 0f);
		Graphics.Blit(source, destination, _material);
		TimeCount += Time.deltaTime * 0.5f;
		if (TimeCount > 10f)
		{
			TimeCount = 0f;
		}
	}

	private void OnDisable()
	{
		Object.DestroyImmediate(_material);
	}

	public ModifiedGlitchShader()
	{
		HorizontalResolution = Screen.width;
		VerticalResolution = Screen.height;
	}
}
