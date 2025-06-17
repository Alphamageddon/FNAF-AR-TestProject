namespace DiscordRPC.Message
{
	public class ConnectionFailedMessage : IMessage
	{
		public override MessageType Type => MessageType.ConnectionFailed;

		public int FailedPipe { get; internal set; }
	}
}
