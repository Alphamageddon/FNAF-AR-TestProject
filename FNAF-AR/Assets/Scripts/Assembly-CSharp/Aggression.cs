public class Aggression
{
	public int Min;

	public int Max;

	public Aggression(CPU_DATA.Aggression rawSettings)
	{
		Min = rawSettings.Min;
		Max = rawSettings.Max;
	}
}
