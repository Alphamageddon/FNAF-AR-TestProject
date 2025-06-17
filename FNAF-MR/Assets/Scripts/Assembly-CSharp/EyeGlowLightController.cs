using System.Collections.Generic;
using UnityEngine;
using VLB;

[ExecuteInEditMode]
public class EyeGlowLightController : MonoBehaviour
{
	public List<Transform> eyeGlows;

	public List<Transform> eyelidBones;

	public List<VolumetricLightBeam> eyeGlowLights;

	public float eyelidOpenValue;

	public float eyelidClosedValue;

	public GameObject revealPlane;

	public float intensityMultiplier = 5f;

	public Light eyeGlowPointLight;

	public GameObject eyeGlowGrp;

	public Color normalEyeGlowColor = Color.black;

	private float _currentEyelidRotation;

	private Color _currentColor;

	private void Start()
	{
		_currentColor = normalEyeGlowColor;
	}

	private void Update()
	{
		float num = 0f;
		if (eyeGlows.Count > 0)
		{
			for (int i = 0; i < eyeGlows.Count; i++)
			{
				float num2 = 1f;
				if (eyelidBones.Count > i)
				{
					_currentEyelidRotation = eyelidBones[i].localRotation.x;
					num2 = Mathf.Clamp(Mathf.Lerp(1f, 0f, Mathf.InverseLerp(eyelidOpenValue, eyelidClosedValue, _currentEyelidRotation)), 0f, 1f);
				}
				Vector3 localScale = revealPlane.transform.localScale;
				float num3 = Mathf.Clamp(localScale.y, 0f, 50f);
				float num4 = localScale.x * intensityMultiplier;
				float num5 = num2 * (num4 * (Time.deltaTime * num3 + 1f));
				if (eyeGlowLights.Count > i)
				{
					eyeGlowLights[i].intensityInside = num5;
					eyeGlowLights[i].color = _currentColor;
				}
				eyeGlowPointLight.color = _currentColor;
				num += num5;
			}
		}
		eyeGlowPointLight.intensity = Mathf.Clamp(num, 0f, 3f);
	}

	public void StartEyeColorOverride(Color color)
	{
		_currentColor = color;
	}

	public void EndEyeColorOverride()
	{
		_currentColor = normalEyeGlowColor;
	}

	public void SetEyeGlow(bool eyeGlowEnabled)
	{
		eyeGlowGrp.SetActive(eyeGlowEnabled);
	}
}
