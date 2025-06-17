public class VirtualGoodsListRequester : AbstractRequester
{
	public VirtualGoodsListRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void RequestVirtualGoods()
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("GET_STORE_ITEMS_V2");
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
