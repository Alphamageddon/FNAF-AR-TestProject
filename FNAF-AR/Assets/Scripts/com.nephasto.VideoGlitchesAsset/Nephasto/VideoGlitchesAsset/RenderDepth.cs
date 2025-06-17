using UnityEngine;

namespace Nephasto.VideoGlitchesAsset
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public sealed class RenderDepth : MonoBehaviour
	{
		[HideInInspector]
		public int layer = -1;

		[HideInInspector]
		public RenderTexture renderTexture;

		private Shader shader;

		private Material material;

		private Camera depthCamera;

		private Camera parentCamera;

		private Material Material
		{
			get
			{
				if (material == null)
				{
					material = new Material(shader);
					if (material != null)
					{
						material.hideFlags = HideFlags.HideAndDontSave;
					}
					else
					{
						Debug.LogWarning("[Nephasto.VideoGlitches] 'RenderDepth' material null. Please contact with 'hello@nephasto.com' and send the log file.");
						base.enabled = false;
					}
				}
				return material;
			}
		}

		private void Start()
		{
			depthCamera = GetComponent<Camera>();
			depthCamera.cullingMask = layer;
			depthCamera.depthTextureMode = DepthTextureMode.Depth;
			depthCamera.clearFlags = CameraClearFlags.Color;
			depthCamera.backgroundColor = Color.black;
			shader = Resources.Load<Shader>("Shaders/RenderDepth");
			if (shader != null)
			{
				if (shader.isSupported)
				{
					parentCamera = base.transform.parent.GetComponent<Camera>();
					CreateRenderTexture();
				}
				else
				{
					Debug.LogWarning("[Nephasto.VideoGlitches] 'RenderDepth' shader not supported. Please contact with 'hello@nephasto.com' and send the log file.");
					base.enabled = false;
				}
			}
			else
			{
				Debug.LogWarning("[Nephasto.VideoGlitches] Shader 'Nephasto/Vintage/Resources/Shaders/RenderDepth.shader' not found. '" + GetType().Name + "' disabled.");
				base.enabled = false;
			}
		}

		private void OnDisable()
		{
			if (material != null)
			{
				Object.DestroyImmediate(material);
			}
			if (depthCamera != null)
			{
				depthCamera.targetTexture = null;
			}
		}

		private void Update()
		{
			if (MustCreateRenderTexture())
			{
				CreateRenderTexture();
			}
		}

		private void LateUpdate()
		{
			if (depthCamera != null && parentCamera != null && renderTexture != null)
			{
				depthCamera.CopyFrom(parentCamera);
				depthCamera.cullingMask = layer;
				depthCamera.depthTextureMode = DepthTextureMode.Depth;
				depthCamera.clearFlags = CameraClearFlags.Color;
				depthCamera.backgroundColor = Color.black;
				depthCamera.targetTexture = renderTexture;
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (Material != null)
			{
				Graphics.Blit(source, destination, material);
			}
		}

		private bool MustCreateRenderTexture()
		{
			if (renderTexture == null)
			{
				return true;
			}
			if (renderTexture.IsCreated() && Screen.width == renderTexture.width)
			{
				return Screen.height != renderTexture.height;
			}
			return true;
		}

		private void CreateRenderTexture()
		{
			if (Screen.width > 0 && Screen.height > 0)
			{
				renderTexture = new RenderTexture(Screen.width, Screen.height, 24);
				if (renderTexture != null)
				{
					renderTexture.isPowerOfTwo = false;
					renderTexture.antiAliasing = 1;
					renderTexture.name = "RenderTexture from VideoGlitches";
					if (renderTexture.Create())
					{
						depthCamera.targetTexture = renderTexture;
						return;
					}
					Debug.LogError("[Nephasto.VideoGlitches] Hardware not support Render-To-Texture, '" + GetType().ToString() + "' disabled.");
					base.enabled = false;
				}
				else
				{
					Debug.LogError("[Nephasto.VideoGlitches] RenderTexture null, hardware may not support Render-To-Texture, '" + GetType().ToString() + "' disabled.");
					base.enabled = false;
				}
			}
			else
			{
				Debug.LogError($"[Nephasto.VideoGlitches] Wrong screen resolution '{Screen.width}x{Screen.height}', '{GetType().ToString()}' disabled.");
				base.enabled = false;
			}
		}
	}
}
