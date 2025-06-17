public class IntroScreenSettings
{
	public string Bundle;

	public string Asset;

	public string Page1Loc;

	public string Page2Loc;

	public string Page3Loc;

	public string Page4Loc;

	public IntroScreenSettings(ATTACK_DATA.IntroScreen data)
	{
		Bundle = data.Bundle;
		Asset = data.Asset;
		Page1Loc = data.Page1Loc;
		Page2Loc = data.Page2Loc;
		Page3Loc = data.Page3Loc;
		Page4Loc = data.Page4Loc;
	}

	public IntroScreenSettings(SCAVENGING_ATTACK_DATA.IntroScreen data)
	{
		Bundle = data.Bundle;
		Asset = data.Asset;
		Page1Loc = data.Page1Loc;
		Page2Loc = data.Page2Loc;
		Page3Loc = data.Page3Loc;
		Page4Loc = data.Page4Loc;
	}
}
