using System.Collections.Generic;

public class RandomChanceData
{
	public readonly float Chance;

	public readonly float Modifier;

	public RandomChanceData(float chance, float modifier)
	{
		Chance = chance;
		Modifier = modifier;
	}

	public RandomChanceData(RandomChanceData chance, string chanceKey, string modifierKey, Dictionary<string, float> mods)
	{
		Chance = chance.Chance * (mods.ContainsKey(chanceKey) ? mods[chanceKey] : 1f);
		Modifier = chance.Modifier * (mods.ContainsKey(modifierKey) ? mods[modifierKey] : 1f);
	}

	public override string ToString()
	{
		return $"{{\"Chance\":{Chance},\"Modifier\":{Modifier}}}";
	}
}
