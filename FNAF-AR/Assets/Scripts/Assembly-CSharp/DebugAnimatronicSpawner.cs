using UnityEngine;

public class DebugAnimatronicSpawner : MonoBehaviour
{
	public void DebugCreateAnimatronic(string PlushsuitID)
	{
		Animatronic3DDomain animatronic3DDomain = GameLifecycleProxy.GetMasterDomain().Animatronic3DDomain;
		CPU_DATA.Entry entry = null;
		PLUSHSUIT_DATA.Entry entry2 = null;
		ATTACK_DATA.Entry entry3 = null;
		AnimatronicConfigData configData = null;
		CPU_DATA.Root obj = (CPU_DATA.Root)ConstantVariables.Instance.MasterDataDownloader.GetMasterDataDeserialized(typeof(CPU_DATA));
		PLUSHSUIT_DATA.Root root = (PLUSHSUIT_DATA.Root)ConstantVariables.Instance.MasterDataDownloader.GetMasterDataDeserialized(typeof(PLUSHSUIT_DATA));
		ATTACK_DATA.Root root2 = (ATTACK_DATA.Root)ConstantVariables.Instance.MasterDataDownloader.GetMasterDataDeserialized(typeof(ATTACK_DATA));
		foreach (CPU_DATA.Entry entry4 in obj.Entries)
		{
			if (entry4.Logical == PlushsuitID)
			{
				entry = entry4;
			}
		}
		foreach (PLUSHSUIT_DATA.Entry entry5 in root.Entries)
		{
			if (entry5.Logical == PlushsuitID)
			{
				entry2 = entry5;
			}
		}
		foreach (ATTACK_DATA.Entry entry6 in root2.Entries)
		{
			if (entry6.Logical == PlushsuitID)
			{
				entry3 = entry6;
			}
		}
		if (entry != null && entry2 != null && entry3 != null)
		{
			configData = new AnimatronicConfigData(new CPUData(entry), new PlushSuitData(entry2), new AttackProfile(entry3));
		}
		CreationRequest request = new CreationRequest(configData, null);
		animatronic3DDomain.CreateAnimatronic3D(request);
	}
}
