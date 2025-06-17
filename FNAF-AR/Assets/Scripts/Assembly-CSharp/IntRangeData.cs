public class IntRangeData
{
	public readonly int Min;

	public readonly int Max;

	public IntRangeData(int min, int max)
	{
		Min = min;
		Max = max;
	}

	public override string ToString()
	{
		return $"{{\"Min\":{Min},\"Max\":{Max}}}";
	}
}
