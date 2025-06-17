using System;

public static class ServerTime
{
	private static long serverOffset;

	private static bool initialized;

	public static void SetServerTime(long serverTime)
	{
		serverOffset = serverTime - DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		initialized = true;
	}

	public static long GetCurrentTime()
	{
		if (initialized)
		{
			return serverOffset + DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		}
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	public static bool IsInitialized()
	{
		return initialized;
	}
}
