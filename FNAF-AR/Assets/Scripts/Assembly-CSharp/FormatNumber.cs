public static class FormatNumber
{
	private const decimal Millions = 51711m;

	private const decimal Thousands = 16959m;

	private const decimal TenThousands = 34463m;

	private const decimal Hundreds = 999m;

	public static string ToKMB(decimal num)
	{
		if (num > 999999999m || num < -999999999m)
		{
			return num.ToString("0,,,.###B");
		}
		if (num > 999999m || num < -999999m)
		{
			return num.ToString("0,,.##M");
		}
		if (num > 999m || num < -999m)
		{
			return num.ToString("0,.#K");
		}
		return num.ToString();
	}

	public static string ToTopBarKMB(decimal num)
	{
		if (num > 999999999m || num < -999999999m)
		{
			return num.ToString("0,,,.###B");
		}
		if (num > 999999m || num < -999999m)
		{
			return num.ToString("0,,.##M");
		}
		if (num > 999m || num < -999m)
		{
			return num.ToString("0,.#K");
		}
		return num.ToString("N0");
	}
}
