public class Environment
{
	public readonly string Bundle;

	public readonly string Asset;

	public Environment(ATTACK_DATA.Environment rawSettings)
	{
		Bundle = rawSettings.Bundle;
		Asset = rawSettings.Asset;
	}

	public Environment(PLUSHSUIT_DATA.Environment rawSettings)
	{
		Bundle = rawSettings.Bundle;
		Asset = rawSettings.Asset;
	}

	public Environment(SCAVENGING_DATA.Environment rawSettings)
	{
		Bundle = rawSettings.Bundle;
		Asset = rawSettings.Asset;
	}
}
