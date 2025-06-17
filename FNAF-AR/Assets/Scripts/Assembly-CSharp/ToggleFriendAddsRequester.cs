public class ToggleFriendAddsRequester : AbstractRequester
{
	public ToggleFriendAddsRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void ToggleFriendsAdd(bool enabled)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("TOGGLE_FRIENDS_ADD");
		logEventRequest.SetEventAttribute("friendAddsEnabled", enabled);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
