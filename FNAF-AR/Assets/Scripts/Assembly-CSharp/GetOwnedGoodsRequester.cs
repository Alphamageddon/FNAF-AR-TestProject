public class GetOwnedGoodsRequester : AbstractRequester
{
	public GetOwnedGoodsRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void GetOwnedGoods()
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("GET_OWNED_GOODS");
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
