public class ToggleFriendSendsRequester : AbstractRequester
{
	public ToggleFriendSendsRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void ToggleFriendSends(bool enabled)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("TOGGLE_FRIEND_SENDS");
		logEventRequest.SetEventAttribute("friendSendsEnabled", enabled);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
