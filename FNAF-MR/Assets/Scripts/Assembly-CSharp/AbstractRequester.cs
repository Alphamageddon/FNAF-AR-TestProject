public abstract class AbstractRequester
{
	protected readonly LogEventHandler logEventHandler;

	protected AbstractRequester(LogEventHandler eventHandler)
	{
		logEventHandler = eventHandler;
	}

	protected static void NullResponse(ServerResponse response)
	{
	}

	protected static void NullErrorResponse(ServerData serverData)
	{
	}
}
