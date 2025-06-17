public class CrateInfoData
{
	public string Logical;

	public ArtAssets ArtAssets;

	public CrateInfoData(CRATE_INFO_DATA.Entry entry)
	{
		if (entry == null)
		{
			return;
		}
		if (entry.Logical != null)
		{
			Logical = entry.Logical;
		}
		ArtAssets = new ArtAssets();
		if (entry.ArtAssets != null)
		{
			if (entry.ArtAssets.AssetBundle != null)
			{
				ArtAssets.AssetBundle = entry.ArtAssets.AssetBundle;
			}
			if (entry.ArtAssets.RigPrefabName != null)
			{
				ArtAssets.RigPrefabName = entry.ArtAssets.RigPrefabName;
			}
			if (entry.ArtAssets.CratePrefabName != null)
			{
				ArtAssets.CratePrefabName = entry.ArtAssets.CratePrefabName;
			}
			if (entry.ArtAssets.FramePrefabName != null)
			{
				ArtAssets.FramePrefabName = entry.ArtAssets.FramePrefabName;
			}
			if (entry.ArtAssets.SpriteAsset != null)
			{
				ArtAssets.SpriteAsset = entry.ArtAssets.SpriteAsset;
			}
		}
	}
}
