using System.Collections.Generic;

public static class FloatHelper
{
	public static float ApplyModifier(float baseValue, string key, Dictionary<string, float> mods)
	{
		if (mods.ContainsKey(key))
		{
			return baseValue * mods[key];
		}
		return baseValue;
	}
}
