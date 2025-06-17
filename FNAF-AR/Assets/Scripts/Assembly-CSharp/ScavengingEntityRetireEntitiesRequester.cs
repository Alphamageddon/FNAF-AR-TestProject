using System.Collections.Generic;

public class ScavengingEntityRetireEntitiesRequester : AbstractRequester
{
	public ScavengingEntityRetireEntitiesRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void RetireEntities(List<string> entitiesToRetire)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("SCAVENGING_ENTITY_RETIRE_ENTITIES");
		logEventRequest.SetEventAttribute("entitiesToRetire", entitiesToRetire);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
