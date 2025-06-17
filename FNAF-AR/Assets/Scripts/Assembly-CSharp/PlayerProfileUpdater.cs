using System;

public class PlayerProfileUpdater
{
	private readonly string className;

	private Action<PlayerProfile> PlayerProfileUpdated;

	private Action<UserNameSetError> DisplayNameObscenityFound;

	public void Setup(EventExposer eventExposer)
	{
		PlayerProfileUpdated = eventExposer.OnPlayerProfileUpdated;
		DisplayNameObscenityFound = eventExposer.OnDisplayNameObscenityFound;
	}

	public void UpdateProfile(ServerData data)
	{
		if (PlayerProfileUpdated != null)
		{
			PlayerProfileUpdated(BuildPlayerProfileFromServerData(data));
		}
	}

	public void OnDisplayNameObscenityFound(UserNameSetError error)
	{
		if (DisplayNameObscenityFound != null)
		{
			DisplayNameObscenityFound(error);
		}
	}

	private PlayerProfile BuildPlayerProfileFromServerData(ServerData data)
	{
		return new PlayerProfile
		{
			userName = data.GetString("userName"),
			displayName = data.GetString("displayName"),
			userId = data.GetString("userId"),
			avatarId = data.GetString("avatarId"),
			friendAddsEnabled = data.GetBoolean("friendAddsEnabled").Value,
			friendSendsEnabled = data.GetBoolean("friendSendsEnabled").Value
		};
	}

	public PlayerProfileUpdater()
	{
		className = "PlayerProfileUpdater";
	}
}
