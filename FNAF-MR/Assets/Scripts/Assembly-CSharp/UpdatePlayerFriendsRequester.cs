public class UpdatePlayerFriendsRequester : AbstractRequester
{
	public UpdatePlayerFriendsRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void UpdatePlayerFriends()
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("UPDATE_PLAYER_FRIENDS");
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
