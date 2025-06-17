using System;

public class SendAnimatronicV2Callbacks
{
	public readonly Action<SendAnimatronicV2ResponseData> successCallback;

	public readonly Action<string> errorCallback;

	public SendAnimatronicV2Callbacks(Action<SendAnimatronicV2ResponseData> success, Action<string> error)
	{
		successCallback = success;
		errorCallback = error;
	}
}
