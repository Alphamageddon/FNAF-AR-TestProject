using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class VignetteController : MonoBehaviour
{
	public PostProcessVolume postProcess;

	private Vignette _vignette;

	private void Start()
	{
		postProcess.profile.TryGetSettings<Vignette>(out _vignette);
	}

	public void SetStrength(float strength)
	{
		_vignette.intensity.value = strength;
	}
}
