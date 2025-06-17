public class ScavengingData
{
	public readonly Environment Environment;

	public ScavengingData(SCAVENGING_DATA.Entry rawSettings)
	{
		if (rawSettings.Environment != null)
		{
			Environment = new Environment(rawSettings.Environment);
		}
	}
}
