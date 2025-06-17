public class PlayerAvatarDomain
{
	public PlayerAvatarIconHandler AvatarIconHandler;

	public void Setup(GameAssetManagementDomain gameAssetManagementDomain, ItemDefinitions itemDefinitions, GameUIDomain gameUIDomain)
	{
		AvatarIconHandler = new PlayerAvatarIconHandler(gameAssetManagementDomain, itemDefinitions, gameUIDomain);
	}

	public void Teardown()
	{
		AvatarIconHandler = null;
	}
}
