using Nephasto.VideoGlitchesAsset;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class HaywireFxController : MonoBehaviour
{
	public PostProcessVolume postProcess;

	public VideoGlitchNoiseDigital noiseDigital;

	public VideoGlitchShift shift;

	[SerializeField]
	[Range(0f, 1f)]
	private float _strength;

	public bool editorMode;

	private ColorGrading _colorGrading;

	private bool _strengthChanged;

	private void Start()
	{
		noiseDigital.Strength = 0f;
		shift.Strength = 0f;
		postProcess.profile.TryGetSettings<ColorGrading>(out _colorGrading);
	}

	private void Update()
	{
		if (_strengthChanged || editorMode)
		{
			noiseDigital.enabled = _strength > 0f;
			shift.enabled = true;
			noiseDigital.Strength = _strength;
			shift.Strength = _strength;
			_strengthChanged = false;
			_colorGrading.saturation.value = -40f;
		}
	}

	public void SetStrength(float strength)
	{
		_strength = Mathf.Clamp(strength, 0f, 1f);
		_strengthChanged = true;
	}
}
