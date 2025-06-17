using DiscordRPC.Message;

namespace Lachee.Discord.Events
{
	public sealed class JoinRequestEvent
	{
		public User user { get; }

		internal JoinRequestEvent(JoinRequestMessage message)
		{
			user = new User(message.User);
		}
	}
}
