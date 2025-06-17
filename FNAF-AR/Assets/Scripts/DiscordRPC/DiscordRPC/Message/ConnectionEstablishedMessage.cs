namespace DiscordRPC.Message
{
	public class ConnectionEstablishedMessage : IMessage
	{
		public override MessageType Type => MessageType.ConnectionEstablished;

		public int ConnectedPipe { get; internal set; }
	}
}
