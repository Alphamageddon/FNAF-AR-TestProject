public class GrantItemRequester : AbstractRequester
{
	public GrantItemRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void GrantPlayerItem(string dropsDataLogical)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("GRANT_ITEM");
		logEventRequest.SetEventAttribute("itemId", dropsDataLogical);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
