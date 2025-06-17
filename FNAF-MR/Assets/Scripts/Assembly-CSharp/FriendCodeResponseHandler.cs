using System;

public class FriendCodeResponseHandler : EventResponseHandler
{
	public enum FriendLookupResponse
	{
		SUCCESS = 0,
		GROUP_NOT_FOUND = 1,
		USER_TRIED_TO_FRIEND_SELF = 2,
		USERS_WERE_ALREADY_FRIENDS = 3,
		UNSPECIFIED_ERROR = 4
	}

	private Action<string> OnFriendCodeUpdated;

	private Action<FriendLookupResponse> OnFriendCodeLookedUp;

	private static readonly string[] FriendLookupServerString;

	public void Setup(Action<string> callbackUpdated, Action<FriendLookupResponse> callbackLookedUp)
	{
		OnFriendCodeUpdated = callbackUpdated;
		OnFriendCodeLookedUp = callbackLookedUp;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetString("friendCode") != null)
		{
			HandleResponseRefresh(data.GetString("friendCode"));
		}
		if (data.GetString("lookupFriendCodeResponse") != null)
		{
			HandleResponseLookup(data.GetString("lookupFriendCodeResponse"));
		}
	}

	private void HandleResponseRefresh(string friendCode)
	{
		OnFriendCodeUpdated(friendCode);
	}

	private void HandleResponseLookup(string resultString)
	{
		switch (resultString)
		{
		case "success":
			OnFriendCodeLookedUp(FriendLookupResponse.SUCCESS);
			break;
		case "groupNotFound":
			OnFriendCodeLookedUp(FriendLookupResponse.GROUP_NOT_FOUND);
			break;
		case "userTriedToFriendSelf":
			OnFriendCodeLookedUp(FriendLookupResponse.USER_TRIED_TO_FRIEND_SELF);
			break;
		case "usersWereAlreadyFriends":
			OnFriendCodeLookedUp(FriendLookupResponse.USERS_WERE_ALREADY_FRIENDS);
			break;
		default:
			OnFriendCodeLookedUp(FriendLookupResponse.UNSPECIFIED_ERROR);
			break;
		}
	}

	static FriendCodeResponseHandler()
	{
		FriendLookupServerString = new string[4] { "success", "groupNotFound", "userTriedToFriendSelf", "usersWereAlreadyFriends" };
	}
}
