namespace DiscordRPC.Message
{
	public enum ErrorCode
	{
		Success = 0,
		PipeException = 1,
		ReadCorrupt = 2,
		NotImplemented = 10,
		UnkownError = 1000,
		InvalidPayload = 4000,
		InvalidCommand = 4002,
		InvalidEvent = 4004
	}
}
