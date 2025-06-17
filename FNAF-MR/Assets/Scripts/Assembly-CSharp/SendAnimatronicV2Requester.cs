public class SendAnimatronicV2Requester : AbstractRequester
{
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public SendAnimatronicV2Params parameters;

		public SendAnimatronicV2Callbacks callbacks;

		internal void _003CSendAnimatronic_003Eg__OnAnimatronicSent_007C0(ServerResponse response)
		{
			WorkshopEntry workshopEntry = ServerProcessors.ProcessWorkshopDataEntry(response.ScriptData.GetServerDataList("WarehouseDataV2")[parameters.slotId]);
			SendAnimatronicV2ResponseData sendAnimatronicV2ResponseData = new SendAnimatronicV2ResponseData();
			sendAnimatronicV2ResponseData.workshopEntry = workshopEntry;
			callbacks.successCallback(sendAnimatronicV2ResponseData);
		}

		internal void _003CSendAnimatronic_003Eg__OnError_007C1(ServerData serverData)
		{
			callbacks.errorCallback(serverData.JSON);
		}
	}

	public void SendAnimatronic(SendAnimatronicV2Params parameters, SendAnimatronicV2Callbacks callbacks)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.parameters = parameters;
		_003C_003Ec__DisplayClass0_.callbacks = callbacks;
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("SEND_ANIMATRONIC_ATTACK_V2");
		logEventRequest.SetEventAttribute("userId", parameters.userId);
		logEventRequest.SetEventAttribute("slotId", parameters.slotId);
		logEventHandler.Send(logEventRequest, _003C_003Ec__DisplayClass0_._003CSendAnimatronic_003Eg__OnAnimatronicSent_007C0, _003C_003Ec__DisplayClass0_._003CSendAnimatronic_003Eg__OnError_007C1);
	}

	public SendAnimatronicV2Requester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}
}
