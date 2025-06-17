public class Perception
{
	public int Min;

	public int Max;

	public int Increment;

	public Perception(CPU_DATA.Perception rawSettings)
	{
		Min = rawSettings.Min;
		Max = rawSettings.Max;
		Increment = rawSettings.Increment;
	}
}
