public class GetPlayerFriendsRequester : AbstractRequester
{
	public GetPlayerFriendsRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void GetPlayerFriends()
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("GET_PLAYER_FRIENDS");
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
