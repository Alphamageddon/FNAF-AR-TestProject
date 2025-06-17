using System;

public class FriendsListCellData
{
	public Action<string> callback;

	public PlayerFriendsEntry playerFriendsEntry;

	public string buttonText;

	public Func<bool> getSendingEnabled;
}
