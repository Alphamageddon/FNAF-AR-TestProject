public class AvatarSaveRequester : AbstractRequester
{
	public AvatarSaveRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	public void SaveAvatarId(string avatarId)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("SAVE_AVATAR");
		logEventRequest.SetEventAttribute("avatarId", avatarId);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}
}
