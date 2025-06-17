public class MapEntityInteractionFinishedRequester : AbstractRequester
{
	public MapEntityInteractionFinishedRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void FinishInteraction(string entityId, bool giveRewards)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("MAP_ENTITY_INTERACTION_FINISHED");
		logEventRequest.SetEventAttribute("entityId", entityId);
		logEventRequest.SetEventAttribute("giveRewards", giveRewards);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
