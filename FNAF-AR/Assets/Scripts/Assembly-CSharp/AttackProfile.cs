using System;
using System.Collections.Generic;

public class AttackProfile
{
	public const string SHEAR_MOD = "Shear";

	public readonly string Logical;

	public readonly EncounterType EncounterType;

	public readonly float WaitForCameraTime;

	public readonly float OfflineExpireTime;

	public readonly AttackUIData AttackUIData;

	public readonly IntroScreenSettings IntroScreen;

	public readonly TeleportRepositionData TeleportReposition;

	public readonly InitialPauseData InitialPause;

	public readonly CircleData Circle;

	public readonly PauseData Pause;

	public readonly ChargeData Charge;

	public readonly JumpscareData Jumpscare;

	public readonly HaywireData Haywire;

	public readonly SlashData Slash;

	public readonly DisruptionData Disruption;

	public readonly SurgeData Surge;

	public readonly VisibilityAlterEffectData VisibilityAlterEffect;

	public readonly DropsObjectsData DropsObjects;

	public readonly BatteryData Battery;

	public readonly string StaticProfile;

	public readonly int NumShocksToDefeat;

	public readonly float ShockerCooldownSeconds;

	public readonly PhantomWalkData PhantomWalk;

	public readonly PhantomOverloadData PhantomOverload;

	public readonly PhantomPauseData PhantomPause;

	public readonly PhantomSettingsData PhantomSettings;

	public readonly FootstepsData Footsteps;

	public readonly GlimpseData Glimpse;

	public readonly NoiseMeterData NoiseMeter;

	public float ShearModifier;

	public readonly LookAwayApproachData LookAwayApproach;

	public readonly ChargeBushingSettings ChargeBushingSettings;

	public readonly EncounterTriggerSettings EncounterTriggerSettings;

	public readonly EnrageType EnrageType;

	public readonly Environment Environment;

	public readonly List<SubEntityData> SubEntityData = new List<SubEntityData>();

	public AttackProfile(ATTACK_DATA.Entry rawSettings)
	{
		Logical = rawSettings.Logical;
		EncounterType = (EncounterType)Enum.Parse(typeof(EncounterType), rawSettings.EncounterType);
		WaitForCameraTime = rawSettings.WaitForCameraTime;
		OfflineExpireTime = rawSettings.OfflineExpireTime;
		if (rawSettings.UI != null)
		{
			AttackUIData = new AttackUIData(rawSettings.UI);
		}
		if (rawSettings.IntroScreen != null)
		{
			IntroScreen = new IntroScreenSettings(rawSettings.IntroScreen);
		}
		if (rawSettings.TeleportReposition != null)
		{
			TeleportReposition = new TeleportRepositionData(rawSettings.TeleportReposition);
		}
		if (rawSettings.InitialPause != null)
		{
			InitialPause = new InitialPauseData(rawSettings.InitialPause);
		}
		if (rawSettings.Circle != null)
		{
			Circle = new CircleData(rawSettings.Circle);
		}
		if (rawSettings.Pause != null)
		{
			Pause = new PauseData(rawSettings.Pause);
		}
		if (rawSettings.Charge != null)
		{
			Charge = new ChargeData(rawSettings.Charge);
		}
		if (rawSettings.Jumpscare != null)
		{
			Jumpscare = new JumpscareData(rawSettings.Jumpscare);
		}
		if (rawSettings.Haywire != null)
		{
			Haywire = new HaywireData(rawSettings.Haywire);
		}
		if (rawSettings.Slash != null)
		{
			Slash = new SlashData(rawSettings.Slash);
		}
		if (rawSettings.Disruption != null)
		{
			Disruption = new DisruptionData(rawSettings.Disruption);
		}
		if (rawSettings.Surge != null)
		{
			Surge = new SurgeData(rawSettings.Surge);
		}
		if (rawSettings.VisibilityAlterEffect != null)
		{
			VisibilityAlterEffect = new VisibilityAlterEffectData(rawSettings.VisibilityAlterEffect);
		}
		if (rawSettings.DropsObjects != null)
		{
			DropsObjects = new DropsObjectsData(rawSettings.DropsObjects);
		}
		if (rawSettings.Battery != null)
		{
			Battery = new BatteryData(rawSettings.Battery);
		}
		StaticProfile = rawSettings.StaticProfile;
		NumShocksToDefeat = rawSettings.NumShocksToDefeat;
		ShockerCooldownSeconds = rawSettings.ShockerCooldownSeconds;
		if (rawSettings.PhantomWalk != null)
		{
			PhantomWalk = new PhantomWalkData(rawSettings.PhantomWalk);
		}
		if (rawSettings.PhantomOverload != null)
		{
			PhantomOverload = new PhantomOverloadData(rawSettings.PhantomOverload);
		}
		if (rawSettings.PhantomPause != null)
		{
			PhantomPause = new PhantomPauseData(rawSettings.PhantomPause);
		}
		if (rawSettings.PhantomSettings != null)
		{
			PhantomSettings = new PhantomSettingsData(rawSettings.PhantomSettings);
		}
		if (rawSettings.Footsteps != null)
		{
			Footsteps = new FootstepsData(rawSettings.Footsteps);
		}
		if (rawSettings.Glimpse != null)
		{
			Glimpse = new GlimpseData(rawSettings.Glimpse);
		}
		if (rawSettings.NoiseMeterSettings != null)
		{
			NoiseMeter = new NoiseMeterData(rawSettings.NoiseMeterSettings);
		}
		ShearModifier = 1f;
		if (rawSettings.LookAwayApproach != null)
		{
			LookAwayApproach = new LookAwayApproachData(rawSettings.LookAwayApproach);
		}
		if (rawSettings.ChargeBushingSettings != null)
		{
			ChargeBushingSettings = new ChargeBushingSettings(rawSettings.ChargeBushingSettings);
		}
		if (rawSettings.EncounterTriggerSettings != null)
		{
			EncounterTriggerSettings = new EncounterTriggerSettings(rawSettings.EncounterTriggerSettings);
		}
		if (rawSettings.EnrageType != null)
		{
			EnrageType = (EnrageType)Enum.Parse(typeof(EnrageType), rawSettings.EnrageType);
		}
		if (rawSettings.Environment != null)
		{
			Environment = new Environment(rawSettings.Environment);
		}
		SubEntityData = null;
	}

	public AttackProfile(AttackProfile profile, Dictionary<string, float> mods)
	{
		EncounterType = profile.EncounterType;
		WaitForCameraTime = profile.WaitForCameraTime;
		OfflineExpireTime = profile.OfflineExpireTime;
		AttackUIData = profile.AttackUIData;
		IntroScreen = profile.IntroScreen;
		TeleportReposition = profile.TeleportReposition;
		InitialPause = profile.InitialPause;
		Circle = new CircleData(profile.Circle, mods);
		Pause = profile.Pause;
		Charge = new ChargeData(profile.Charge, mods);
		Jumpscare = profile.Jumpscare;
		Haywire = new HaywireData(profile.Haywire, mods);
		Slash = profile.Slash;
		Disruption = new DisruptionData(profile.Disruption, mods);
		Surge = new SurgeData(profile.Surge, mods);
		VisibilityAlterEffect = profile.VisibilityAlterEffect;
		DropsObjects = profile.DropsObjects;
		Battery = new BatteryData(profile.Battery, mods);
		StaticProfile = profile.StaticProfile;
		NumShocksToDefeat = profile.NumShocksToDefeat;
		ShockerCooldownSeconds = profile.ShockerCooldownSeconds;
		PhantomWalk = profile.PhantomWalk;
		PhantomOverload = profile.PhantomOverload;
		PhantomPause = profile.PhantomPause;
		PhantomSettings = profile.PhantomSettings;
		Footsteps = profile.Footsteps;
		Glimpse = profile.Glimpse;
		ShearModifier = FloatHelper.ApplyModifier(1f, "Shear", mods);
		NoiseMeter = profile.NoiseMeter;
		LookAwayApproach = profile.LookAwayApproach;
		ChargeBushingSettings = profile.ChargeBushingSettings;
		EncounterTriggerSettings = profile.EncounterTriggerSettings;
		EnrageType = profile.EnrageType;
		Environment = profile.Environment;
		List<string> ids = new List<string>(mods.Keys);
		SubEntityData = MasterDomain.GetDomain().ItemDefinitionDomain.ItemDefinitions.GetSubEntityDataByMods(ids);
	}

	public AttackProfile(AttackProfile profileToCopy)
	{
		EncounterType = profileToCopy.EncounterType;
		WaitForCameraTime = profileToCopy.WaitForCameraTime;
		OfflineExpireTime = profileToCopy.OfflineExpireTime;
		AttackUIData = new AttackUIData(profileToCopy.AttackUIData);
		IntroScreen = profileToCopy.IntroScreen;
		TeleportReposition = profileToCopy.TeleportReposition;
		InitialPause = profileToCopy.InitialPause;
		Circle = new CircleData(profileToCopy.Circle);
		Pause = profileToCopy.Pause;
		Charge = new ChargeData(profileToCopy.Charge);
		Jumpscare = profileToCopy.Jumpscare;
		Haywire = profileToCopy.Haywire;
		Slash = profileToCopy.Slash;
		Disruption = new DisruptionData(profileToCopy.Disruption);
		Surge = profileToCopy.Surge;
		VisibilityAlterEffect = profileToCopy.VisibilityAlterEffect;
		DropsObjects = profileToCopy.DropsObjects;
		Battery = profileToCopy.Battery;
		StaticProfile = profileToCopy.StaticProfile;
		NumShocksToDefeat = profileToCopy.NumShocksToDefeat;
		ShockerCooldownSeconds = profileToCopy.ShockerCooldownSeconds;
		PhantomWalk = profileToCopy.PhantomWalk;
		PhantomOverload = profileToCopy.PhantomOverload;
		PhantomPause = profileToCopy.PhantomPause;
		PhantomSettings = profileToCopy.PhantomSettings;
		Footsteps = profileToCopy.Footsteps;
		Glimpse = profileToCopy.Glimpse;
		ShearModifier = profileToCopy.ShearModifier;
		NoiseMeter = profileToCopy.NoiseMeter;
		LookAwayApproach = profileToCopy.LookAwayApproach;
		ChargeBushingSettings = profileToCopy.ChargeBushingSettings;
		EncounterTriggerSettings = profileToCopy.EncounterTriggerSettings;
		EnrageType = profileToCopy.EnrageType;
		Environment = profileToCopy.Environment;
		SubEntityData = profileToCopy.SubEntityData;
	}
}
