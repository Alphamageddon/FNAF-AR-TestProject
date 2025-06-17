using DiscordRPC;

namespace Lachee.Discord
{
	public static class EventExtension
	{
		public static EventType ToDiscordRPC(this Event ev)
		{
			return (EventType)ev;
		}

		public static Event ToUnity(this EventType type)
		{
			return (Event)type;
		}
	}
}
