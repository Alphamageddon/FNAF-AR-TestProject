using System;

public class FriendCodeRequester : AbstractRequester
{
	private const string GENERATE_NEW_FRIENDCODE = "GENERATE_NEW_FRIENDCODE";

	private const string LOOKUP_FRIENDCODE = "LOOKUP_FRIENDCODE";

	private const string FRIEND_CODE_ID = "friendCode";

	private Action RefreshErrorReceived;

	public void RefreshCode(Action errorCallback)
	{
		RefreshErrorReceived = errorCallback;
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("GENERATE_NEW_FRIENDCODE");
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, RefreshErrorResponse);
	}

	public void RequestFriendByCode(string friendCode)
	{
		LogEventRequest logEventRequest = new LogEventRequest();
		logEventRequest.SetEventKey("LOOKUP_FRIENDCODE");
		logEventRequest.SetEventAttribute("friendCode", friendCode);
		logEventHandler.Send(logEventRequest, AbstractRequester.NullResponse, AbstractRequester.NullErrorResponse);
	}

	public FriendCodeRequester(LogEventHandler eventHandler)
		: base(eventHandler)
	{
	}

	private void RefreshErrorResponse(ServerData serverData)
	{
		if (RefreshErrorReceived != null)
		{
			RefreshErrorReceived();
		}
	}
}
