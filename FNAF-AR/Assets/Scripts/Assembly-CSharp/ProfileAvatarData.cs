public class ProfileAvatarData
{
	public readonly string Logical;

	public readonly string Asset;

	public readonly string MapAsset;

	public readonly string ConcreteItemId;

	public readonly string SpriteAtlas;

	public readonly string Avatar3DBundle;

	public string DisplayName { get; set; }

	public ProfileAvatarData(PROFILE_AVATAR_DATA.Entry data)
	{
		Logical = ((data.Logical == null) ? "" : data.Logical);
		DisplayName = ((data.Name == null) ? "" : LocalizationDomain.Instance.Localization.GetLocalizedString(data.Name, data.Name));
		Asset = ((data.ArtAssetId == null) ? "" : data.ArtAssetId);
		MapAsset = ((data.MapAssetId == null) ? "" : data.MapAssetId);
		ConcreteItemId = ((data.ConcreteItemID == null) ? "" : data.ConcreteItemID);
		SpriteAtlas = ((data.SpriteAtlas == null) ? "" : data.SpriteAtlas);
		Avatar3DBundle = ((data.Avatar3DBundle == null) ? "" : data.Avatar3DBundle);
	}
}
