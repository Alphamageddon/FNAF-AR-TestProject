using System.Collections.Generic;
using UnityEngine;

public class FriendsListTabHandler
{
	private MasterDomain _masterDomain;

	private FriendsListTabData friendsListTabData;

	private List<FriendRemoveCell> friendsListCells;

	private DialogHandler_Profile _dialogHandler;

	private PlayerAvatarIconHandler _avatarIconLookup;

	private void EventExposer_FriendListUpdated(List<PlayerFriendsEntry> friendsList)
	{
		ClearFriendsList();
		GenerateFriendsList(friendsList);
	}

	private void GenerateFriendsList(List<PlayerFriendsEntry> friendsList)
	{
		foreach (PlayerFriendsEntry friends in friendsList)
		{
			FriendRemoveCell friendRemoveCell = Object.Instantiate(friendsListTabData.friendSelectCellPrefab, friendsListTabData.cellParent);
			FriendsRemoveCellData friendsRemoveCellData = new FriendsRemoveCellData();
			friendsRemoveCellData.playerFriendsEntry = friends;
			friendsRemoveCellData.callback = SelectFriendsListCell;
			friendsRemoveCellData.buttonText = "X";
			friendRemoveCell.SetData(friendsRemoveCellData);
			_avatarIconLookup.GetAvatarProfileSprite(friends.avatarId, friendRemoveCell.SetSprite);
			friendsListCells.Add(friendRemoveCell);
		}
	}

	private void ConfirmedRemoveFriend(FriendRemoveCell cell)
	{
		if (friendsListCells.Contains(cell))
		{
			friendsListCells.Remove(cell);
		}
		if (!(cell.gameObject == null))
		{
			Object.Destroy(cell.gameObject);
		}
	}

	private void SelectFriendsListCell(string userId, FriendRemoveCell friendRemoveCell)
	{
		_dialogHandler.ShowRemoveFriendDialog(userId, ConfirmedRemoveFriend, friendRemoveCell);
	}

	private void ClearFriendsList()
	{
		foreach (FriendRemoveCell friendsListCell in friendsListCells)
		{
			if (!(friendsListCell == null) && !(friendsListCell.gameObject == null))
			{
				Object.Destroy(friendsListCell.gameObject);
			}
		}
		friendsListCells.Clear();
	}

	public FriendsListTabHandler(MasterDomain masterDomain, FriendsListTabData friendsListTabData, DialogHandler_Profile dialogHandler, PlayerAvatarIconHandler avatarIconLookup)
	{
		this.friendsListTabData = friendsListTabData;
		friendsListCells = new List<FriendRemoveCell>();
		_masterDomain = masterDomain;
		_masterDomain.eventExposer.add_FriendListUpdated(EventExposer_FriendListUpdated);
		_dialogHandler = dialogHandler;
		_avatarIconLookup = avatarIconLookup;
	}

	public void PopulateFriendsTab()
	{
		_masterDomain.ServerDomain.getPlayerFriendsRequester.GetPlayerFriends();
	}

	public void ClearFriendsFromList()
	{
		ClearFriendsList();
	}

	public void OnDestroy()
	{
		ClearFriendsList();
		friendsListCells = null;
		if (_masterDomain.eventExposer != null)
		{
			_masterDomain.eventExposer.remove_FriendListUpdated(EventExposer_FriendListUpdated);
		}
	}
}
