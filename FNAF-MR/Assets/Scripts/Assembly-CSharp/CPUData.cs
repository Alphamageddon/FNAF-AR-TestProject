using UnityEngine;

public class CPUData
{
	public readonly string Id;

	public readonly int Order;

	public readonly string PlushSuitRef;

	public readonly int Condition;

	public readonly EyeColorData AttackEyes;

	public readonly EyeColorData LookAtEyes;

	public readonly EyeColorData LookAwayEyes;

	public readonly int Phantasm;

	public readonly bool PlayerAcquirable;

	public readonly int SpeedMPH;

	public readonly int TravelSpeedMPH;

	public readonly int SalvagerSpeedMPH;

	public readonly float StalkingTimerMin;

	public readonly float StalkingTimerMax;

	public readonly string AttackProfile;

	public readonly string ScavengingAttackProfile;

	public readonly string SoundBankName;

	public readonly string CpuIconName;

	public readonly string CpuIconNameFlat;

	public readonly string CpuSilhouetteIcon;

	public readonly string LossTextKey;

	public readonly Perception Perception;

	public readonly Aggression Aggression;

	public readonly bool AlwaysShowIcon;

	public readonly string ConcreteItemId;

	public readonly MultiAnimatronic MultiAnimatronicConfig;

	public string AnimatronicName;

	public CPUData(CPU_DATA.Entry data)
	{
		Id = data.Logical;
		Order = data.Order;
		PlushSuitRef = data.PlushSuitRef;
		Condition = data.VisualSettings.Condition;
		Color color = new Color(0f, 0f, 0f, 1f);
		bool hasOverride = ColorUtility.TryParseHtmlString("#" + data.VisualSettings.AttackEyes.HexColor, out color);
		if (data.VisualSettings.AttackEyes.HexColor != null)
		{
			AttackEyes = new EyeColorData(hasOverride, color, data.VisualSettings.AttackEyes.Intensity);
		}
		else
		{
			AttackEyes = new EyeColorData(hasOverride: false, color, data.VisualSettings.AttackEyes.Intensity);
		}
		ColorUtility.TryParseHtmlString("#" + data.VisualSettings.LookAtEyes.HexColor, out var color2);
		LookAtEyes = new EyeColorData(hasOverride: true, color2, data.VisualSettings.LookAtEyes.Intensity);
		ColorUtility.TryParseHtmlString("#" + data.VisualSettings.LookAwayEyes.HexColor, out var color3);
		LookAwayEyes = new EyeColorData(hasOverride: true, color3, data.VisualSettings.LookAwayEyes.Intensity);
		Phantasm = data.Phantasm;
		PlayerAcquirable = data.PlayerAcquirable;
		if (data.SpeedMPH != null)
		{
			if (data.SpeedMPH.MapSpeedMPH != null)
			{
				SpeedMPH = data.SpeedMPH.MapSpeedMPH.NotUpgraded;
			}
			TravelSpeedMPH = data.SpeedMPH.TravelSpeedMPH;
		}
		SalvagerSpeedMPH = data.SalvagerSpeedMPH;
		if (data.StalkingTimers != null && data.StalkingTimers.Functioning != null)
		{
			StalkingTimerMin = data.StalkingTimers.Functioning.Min;
			StalkingTimerMax = data.StalkingTimers.Functioning.Max;
		}
		AttackProfile = data.AttackProfile;
		ScavengingAttackProfile = data.ScavengingAttackProfile;
		SoundBankName = data.ArtAssets.Audio.SoundBank;
		if (data.ArtAssets != null && data.ArtAssets.UI != null)
		{
			if (data.ArtAssets.UI.CpuIcon != null)
			{
				CpuIconName = data.ArtAssets.UI.CpuIcon;
			}
			if (data.ArtAssets.UI.CpuIconFlat != null)
			{
				CpuIconNameFlat = data.ArtAssets.UI.CpuIconFlat;
			}
			if (data.ArtAssets.UI.CpuSilhouetteIcon != null)
			{
				CpuSilhouetteIcon = data.ArtAssets.UI.CpuSilhouetteIcon;
			}
		}
		LossTextKey = data.AttackLocalization.LossText;
		if (data.Perception != null)
		{
			Perception = new Perception(data.Perception);
		}
		if (data.Aggression != null)
		{
			Aggression = new Aggression(data.Aggression);
		}
		if (data.AlwaysShowIcon == "Yes")
		{
			AlwaysShowIcon = true;
		}
		else
		{
			AlwaysShowIcon = false;
		}
		ConcreteItemId = data.ConcreteItemID;
		if (data.MultiAnimatronicConfig != null)
		{
			MultiAnimatronicConfig = new MultiAnimatronic(Id, data.MultiAnimatronicConfig);
		}
		AnimatronicName = data.AnimatronicNames.Default;
	}
}
