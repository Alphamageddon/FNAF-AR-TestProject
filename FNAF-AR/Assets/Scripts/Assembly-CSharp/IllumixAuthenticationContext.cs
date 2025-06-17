using PlayFab;

public class IllumixAuthenticationContext
{
	public readonly string clientSessionTicket;

	public readonly string illumixId;

	public readonly string entityToken;

	public readonly string entityId;

	public readonly string entityType;

	public IllumixAuthenticationContext(PlayFabAuthenticationContext context)
	{
		if (context != null)
		{
			clientSessionTicket = context.ClientSessionTicket;
			illumixId = context.PlayFabId;
			entityToken = context.EntityToken;
			entityId = context.EntityId;
			entityType = context.EntityType;
		}
	}
}
