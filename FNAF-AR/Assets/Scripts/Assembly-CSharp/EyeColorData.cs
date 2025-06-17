using UnityEngine;

public class EyeColorData
{
	public bool HasOverride;

	public Color Color;

	public float Intensity;

	public EyeColorData(bool hasOverride, Color color, float intensity)
	{
		HasOverride = hasOverride;
		Color = color;
		Intensity = intensity;
	}
}
