using System;
using System.Collections.Generic;

public class MapEntityEncounterWonRequester : AbstractRequester
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public Action onComplete;

		internal void _003CFinishEncounter_003Eb__0(ServerResponse response)
		{
			onComplete();
		}

		internal void _003CFinishEncounter_003Eb__1(ServerData response)
		{
			onComplete();
		}
	}

	public MapEntityEncounterWonRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void FinishEncounter(string entityId, Action onComplete, List<string> buffsConsumed = null)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.onComplete = onComplete;
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("MAP_ENTITY_ENCOUNTER_WON");
		logEventRequest.SetEventAttribute("entityId", entityId);
		if (buffsConsumed != null)
		{
			logEventRequest.SetEventAttribute("buffsConsumed", buffsConsumed);
		}
		else
		{
			logEventRequest.SetEventAttribute("buffsConsumed", new List<string>());
		}
		logEventHandler.Send(logEventRequest, _003C_003Ec__DisplayClass1_._003CFinishEncounter_003Eb__0, _003C_003Ec__DisplayClass1_._003CFinishEncounter_003Eb__1);
	}
}
