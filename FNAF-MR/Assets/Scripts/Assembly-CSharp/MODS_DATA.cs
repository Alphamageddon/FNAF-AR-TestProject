using System.Collections.Generic;

public sealed class MODS_DATA
{
	public class ArtAssets
	{
		public string ModIcon { get; set; }

		public string ModIconRendered { get; set; }

		public string ModIconReward { get; set; }
	}

	public class Effects
	{
		public string EffectCategory { get; set; }

		public string EffectType_1 { get; set; }

		public double EffectMag_1 { get; set; }

		public string EffectType_2 { get; set; }

		public double EffectMag_2 { get; set; }

		public string EffectType_3 { get; set; }

		public double EffectMag_3 { get; set; }

		public string EffectType_4 { get; set; }

		public double EffectMag_4 { get; set; }
	}

	public class Entry
	{
		public string ModLogical { get; set; }

		public string ModName { get; set; }

		public string ConcreteItemID { get; set; }

		public string ModDesc { get; set; }

		public string ModType { get; set; }

		public Effects Effects { get; set; }

		public int DropWeight { get; set; }

		public int PartsBuyback { get; set; }

		public int Stars { get; set; }

		public ArtAssets ArtAssets { get; set; }

		public double BreakageChance { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
