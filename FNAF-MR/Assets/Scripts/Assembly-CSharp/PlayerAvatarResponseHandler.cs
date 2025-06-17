using System;
using System.Collections.Generic;

public class PlayerAvatarResponseHandler : EventResponseHandler
{
	private const string PLAYER_AVATAR_KEY = "ProfileAvatar";

	private Action<List<string>> AvatarListReceived;

	public void Setup(Action<List<string>> callback)
	{
		AvatarListReceived = callback;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetStringList("ProfileAvatar") != null && AvatarListReceived != null)
		{
			AvatarListReceived(data.GetStringList("ProfileAvatar"));
		}
	}
}
