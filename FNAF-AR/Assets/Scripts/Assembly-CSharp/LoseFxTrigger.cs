using Nephasto.VideoGlitchesAsset;
using UnityEngine;

public class LoseFxTrigger : MonoBehaviour
{
	public VideoGlitchVHSNoise vhsNoise;

	public VideoGlitchNoiseDigital noiseDigital;

	private void OnEnable()
	{
		vhsNoise.enabled = true;
		noiseDigital.enabled = true;
	}

	private void OnDisable()
	{
		vhsNoise.enabled = false;
		noiseDigital.enabled = false;
	}
}
