namespace DiscordRPC.Message
{
	public class CloseMessage : IMessage
	{
		public override MessageType Type => MessageType.Close;

		public string Reason { get; internal set; }

		public int Code { get; internal set; }

		internal CloseMessage()
		{
		}

		internal CloseMessage(string reason)
		{
			Reason = reason;
		}
	}
}
