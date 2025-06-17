public class PlayerProfileResponseHandler : EventResponseHandler
{
	private PlayerProfileUpdater playerProfileUpdater;

	public void Setup(PlayerProfileUpdater updater)
	{
		playerProfileUpdater = updater;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("PlayerProfile") != null)
		{
			HandleResponse(data.GetServerData("PlayerProfile"));
		}
	}

	private void HandleResponse(ServerData data)
	{
		playerProfileUpdater.UpdateProfile(data);
	}
}
