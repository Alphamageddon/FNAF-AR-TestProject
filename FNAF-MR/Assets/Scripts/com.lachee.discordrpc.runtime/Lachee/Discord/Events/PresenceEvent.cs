using DiscordRPC.Message;

namespace Lachee.Discord.Events
{
	public sealed class PresenceEvent
	{
		public Presence presence { get; }

		public string name { get; }

		public string applicationID { get; }

		internal PresenceEvent(PresenceMessage message)
		{
			presence = new Presence(message.Presence);
			name = message.Name;
			applicationID = message.ApplicationID;
		}
	}
}
