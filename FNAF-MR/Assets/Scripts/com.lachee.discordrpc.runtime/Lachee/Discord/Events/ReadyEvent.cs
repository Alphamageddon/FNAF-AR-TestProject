using DiscordRPC;
using DiscordRPC.Message;

namespace Lachee.Discord.Events
{
	public sealed class ReadyEvent
	{
		public User user { get; }

		public Configuration configuration { get; }

		public int version { get; }

		internal ReadyEvent(ReadyMessage message)
		{
			user = new User(message.User);
			configuration = message.Configuration;
			version = message.Version;
		}
	}
}
