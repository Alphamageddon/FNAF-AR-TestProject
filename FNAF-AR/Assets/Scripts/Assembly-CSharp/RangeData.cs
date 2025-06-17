using System.Collections.Generic;

public class RangeData
{
	public readonly float Min;

	public readonly float Max;

	public RangeData(float min, float max)
	{
		Min = min;
		Max = max;
	}

	public RangeData(RangeData range, string key, Dictionary<string, float> mods)
	{
		if (!mods.ContainsKey(key))
		{
			Min = range.Min;
			Max = range.Max;
		}
		else
		{
			Min = range.Min * mods[key];
			Max = range.Max * mods[key];
		}
	}

	public override string ToString()
	{
		return $"{{\"Min\":{Min},\"Max\":{Max}}}";
	}
}
