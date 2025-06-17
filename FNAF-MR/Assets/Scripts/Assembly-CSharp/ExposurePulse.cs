using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ExposurePulse : MonoBehaviour
{
	[Header("Post Processing")]
	public PostProcessProfile postProcessProfile;

	public Vignette vignette;

	public ColorGrading colorGrading;

	[Header("Exposure")]
	public bool useExposure;

	[Range(-5f, 5f)]
	public float exposureMin = -1f;

	[Range(-5f, 5f)]
	public float exposureMax = 1f;

	[Space(10f)]
	[Header("Vignette")]
	public bool useVignette;

	public bool useVignetteIntensity;

	public bool useVignetteRoundness;

	[Space(10f)]
	[Header("Vignette Intensity")]
	[Range(-1f, 1f)]
	public float vignetteIntensityMin;

	[Range(-1f, 1f)]
	public float vignetteIntensityMax = 1f;

	[Space(10f)]
	[Header("Vignette Roundness")]
	[Range(0f, 1f)]
	public float vignetteRoundnessMin;

	[Range(0f, 1f)]
	public float vignetteRoundnessMax = 1f;

	[Header("Pulse")]
	public float speedExposure = 1f;

	public float speedVignetteIntensity = 1f;

	public float speedVignetteRoundness = 1f;

	public void OnEnable()
	{
		postProcessProfile = GetComponent<PostProcessVolume>().profile;
		postProcessProfile.TryGetSettings<Vignette>(out vignette);
		postProcessProfile.TryGetSettings<ColorGrading>(out colorGrading);
	}

	public void Update()
	{
		if (useExposure)
		{
			colorGrading.postExposure.value = Mathf.Lerp(exposureMin, exposureMax, Mathf.PingPong(Time.time * speedExposure, 1f));
		}
		if (useVignette)
		{
			if (useVignetteIntensity)
			{
				vignette.intensity.value = Mathf.Lerp(vignetteIntensityMin, vignetteIntensityMax, Mathf.PingPong(Time.time * speedVignetteIntensity, 1f));
			}
			if (useVignetteRoundness)
			{
				vignette.roundness.value = Mathf.Lerp(vignetteRoundnessMin, vignetteRoundnessMax, Mathf.PingPong(Time.time * speedVignetteRoundness, 1f));
			}
		}
	}
}
