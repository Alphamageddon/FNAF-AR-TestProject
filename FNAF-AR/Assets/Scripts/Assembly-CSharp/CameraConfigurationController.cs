using Nephasto.VideoGlitchesAsset;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraConfigurationController : MonoBehaviour
{
	[SerializeField]
	private PostProcessLayer _postProcessLayer;

	[SerializeField]
	private PostProcessVolume _postProcessVolume;

	[SerializeField]
	private AmplifyMotionEffect _amplifyMotionEffect;

	[SerializeField]
	private ModifiedGlitchShader _modifiedGlitchShader;

	[SerializeField]
	private VignetteController _vignetteController;

	[SerializeField]
	private HaywireFxController _haywireFxController;

	[SerializeField]
	private VideoGlitchShift _videoGlitchShift;

	[SerializeField]
	private VideoGlitchNoiseDigital _videoGlitchNoiseDigital;
}
