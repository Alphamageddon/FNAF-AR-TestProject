using System;

public class IllumixLoginHandlerParameters
{
	public readonly IUpdateUserTitleDisplayNameRequest updateUserTitleDisplayNameRequest;

	public readonly Action<bool> onGeneratePlayStreamEventReceived;

	public IllumixLoginHandlerParameters(ServerDomain illumixServerDomain, Action<bool> generatePlayStreamEventReceived)
	{
		updateUserTitleDisplayNameRequest = illumixServerDomain.CreateUpdateUserTitleDisplayNameRequest();
		onGeneratePlayStreamEventReceived = generatePlayStreamEventReceived;
	}
}
