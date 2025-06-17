public class RemoveFriendRequester : AbstractRequester
{
	public RemoveFriendRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void RemoveFriend(string userId)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("REMOVE_FRIEND");
		logEventRequest.SetEventAttribute("userId", userId);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
