namespace DiscordRPC.Message
{
	public class SpectateMessage : JoinMessage
	{
		public override MessageType Type => MessageType.Spectate;
	}
}
