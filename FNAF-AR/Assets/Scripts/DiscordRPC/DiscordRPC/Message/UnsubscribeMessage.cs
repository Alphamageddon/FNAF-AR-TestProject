using DiscordRPC.RPC.Payload;

namespace DiscordRPC.Message
{
	public class UnsubscribeMessage : IMessage
	{
		public override MessageType Type => MessageType.Unsubscribe;

		public EventType Event { get; internal set; }

		internal UnsubscribeMessage(ServerEvent evt)
		{
			switch (evt)
			{
			default:
				Event = EventType.Join;
				break;
			case ServerEvent.ActivityJoinRequest:
				Event = EventType.JoinRequest;
				break;
			case ServerEvent.ActivitySpectate:
				Event = EventType.Spectate;
				break;
			}
		}
	}
}
