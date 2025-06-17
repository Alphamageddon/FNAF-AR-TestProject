using System.Collections.Generic;

public sealed class SCAVENGING_ATTACK_DATA
{
	public class Battery
	{
		public Flashlight Flashlight { get; set; }

		public Shocker Shocker { get; set; }
	}

	public class Entry
	{
		public string Logical { get; set; }

		public UI UI { get; set; }

		public IntroScreen IntroScreen { get; set; }

		public Settings Settings { get; set; }
	}

	public class Flashlight
	{
		public float ActivationDrain { get; set; }

		public float ActiveDrain { get; set; }
	}

	public class IntroScreen
	{
		public string Bundle { get; set; }

		public string Asset { get; set; }

		public string Page1Loc { get; set; }

		public string Page2Loc { get; set; }

		public string Page3Loc { get; set; }

		public string Page4Loc { get; set; }
	}

	public class Movement
	{
		public float WalkSpeed { get; set; }

		public float RunSpeed { get; set; }

		public float ElectrifiedSpeed { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class Settings
	{
		public Movement Movement { get; set; }

		public Battery Battery { get; set; }

		public float LoseTime { get; set; }

		public float SearchLockerChance { get; set; }

		public float SwapDirectionAfterLosePlayerChance { get; set; }

		public float ShockedStunTime { get; set; }

		public float ElectrifiedTime { get; set; }
	}

	public class Shocker
	{
		public float ActivationDrain { get; set; }
	}

	public class UI
	{
		public bool UseShocker { get; set; }

		public bool UseFlashlight { get; set; }

		public bool UseMask { get; set; }
	}
}
