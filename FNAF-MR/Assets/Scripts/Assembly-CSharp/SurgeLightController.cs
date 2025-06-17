using UnityEngine;

public class SurgeLightController : MonoBehaviour
{
	public GameObject surgeLight;

	[SerializeField]
	private float surgeLightStrength;

	private Light _light;

	private bool _lightIsNotNull;

	private void Start()
	{
		_light = surgeLight.GetComponent<Light>();
		_lightIsNotNull = _light != null;
	}

	private void Update()
	{
		if (_lightIsNotNull)
		{
			if (surgeLightStrength > 0f)
			{
				surgeLight.SetActive(value: true);
				_light.intensity = surgeLightStrength;
			}
			else
			{
				surgeLight.SetActive(value: false);
			}
		}
	}

	public void SetSurgeLightStrength(float value)
	{
		surgeLightStrength = Mathf.Clamp(value, 0f, 1f);
	}
}
