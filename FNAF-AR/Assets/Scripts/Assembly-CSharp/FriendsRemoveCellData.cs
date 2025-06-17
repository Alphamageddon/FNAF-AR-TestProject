using System;

public class FriendsRemoveCellData
{
	public Action<string, FriendRemoveCell> callback;

	public PlayerFriendsEntry playerFriendsEntry;

	public string buttonText;

	public Func<bool> getSendingEnabled;
}
