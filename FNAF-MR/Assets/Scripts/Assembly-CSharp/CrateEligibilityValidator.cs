public class CrateEligibilityValidator
{
	public bool IsValidForEligibilityData(EligibilityContext context, CrateEligibilityData data)
	{
		if (data == null)
		{
			return false;
		}
		_ = data.Type;
		_ = 13;
		return true;
	}
}
