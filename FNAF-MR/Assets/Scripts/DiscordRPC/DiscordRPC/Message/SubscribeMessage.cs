using DiscordRPC.RPC.Payload;

namespace DiscordRPC.Message
{
	public class SubscribeMessage : IMessage
	{
		public override MessageType Type => MessageType.Subscribe;

		public EventType Event { get; internal set; }

		internal SubscribeMessage(ServerEvent evt)
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
