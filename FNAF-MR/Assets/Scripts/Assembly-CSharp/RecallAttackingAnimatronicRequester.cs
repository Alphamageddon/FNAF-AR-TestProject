public class RecallAttackingAnimatronicRequester : AbstractRequester
{
	public void RecallAnimatronicAttack(int slotId)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("RECALL_ATTACKING_ANIMATRONIC");
		logEventRequest.SetEventAttribute("slotId", slotId);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}

	public RecallAttackingAnimatronicRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}
}
