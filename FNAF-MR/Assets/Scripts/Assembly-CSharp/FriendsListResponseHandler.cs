using System;
using System.Collections.Generic;

public class FriendsListResponseHandler : EventResponseHandler
{
	private Action<List<PlayerFriendsEntry>> OnFriendsListUpdated;

	public void Setup(Action<List<PlayerFriendsEntry>> callback)
	{
		OnFriendsListUpdated = callback;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("friendsList") != null)
		{
			HandleResponse(data.GetServerData("friendsList"));
		}
	}

	private void HandleResponse(ServerData friendsListData)
	{
		List<PlayerFriendsEntry> list = new List<PlayerFriendsEntry>();
		foreach (string key in friendsListData.Keys)
		{
			list.Add(ServerProcessors.ProcessPlayerFriendsEntry(friendsListData.GetServerData(key)));
		}
		OnFriendsListUpdated(list);
	}
}
