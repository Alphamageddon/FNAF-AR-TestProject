using System.Collections.Generic;

public class MapEntityScanAndRetireEntitiesRequester : AbstractRequester
{
	public MapEntityScanAndRetireEntitiesRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void ScanAndRetireEntities(List<string> entitiesToScan, List<string> entitiesToRetire)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("MAP_ENTITY_SCAN_AND_RETIRE_ENTITIES");
		logEventRequest.SetEventAttribute("entitiesToScan", entitiesToScan);
		logEventRequest.SetEventAttribute("entitiesToRetire", entitiesToRetire);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
