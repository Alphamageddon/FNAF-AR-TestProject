public class AnimatronicConfigData
{
	public readonly int Durability;

	public readonly int Attack;

	public CPUData CpuData { get; }

	public PlushSuitData PlushSuitData { get; }

	public AttackProfile AttackProfile { get; }

	public string PlushSuitSoundbank => PlushSuitData.SoundBankName;

	public AnimatronicConfigData(CPUData cpuData, PlushSuitData plushSuitData, AttackProfile attackProfile)
	{
		CpuData = cpuData;
		PlushSuitData = plushSuitData;
		AttackProfile = attackProfile;
	}

	public AnimatronicConfigData(CPUData cpuData, PlushSuitData plushSuitData, AttackProfile attackProfile, int durability, int attack)
	{
		CpuData = cpuData;
		PlushSuitData = plushSuitData;
		AttackProfile = attackProfile;
		Durability = durability;
		Attack = attack;
	}

	public AnimatronicConfigData(AnimatronicConfigData data)
	{
		CpuData = data.CpuData;
		PlushSuitData = data.PlushSuitData;
		AttackProfile = data.AttackProfile;
		Durability = data.Durability;
		Attack = data.Attack;
	}

	public override string ToString()
	{
		return CpuData.ToString() + PlushSuitData.ToString();
	}
}
