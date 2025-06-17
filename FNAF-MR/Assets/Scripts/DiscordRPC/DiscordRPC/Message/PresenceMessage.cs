namespace DiscordRPC.Message
{
	public class PresenceMessage : IMessage
	{
		public override MessageType Type => MessageType.PresenceUpdate;

		public BaseRichPresence Presence { get; internal set; }

		public string Name { get; internal set; }

		public string ApplicationID { get; internal set; }

		internal PresenceMessage()
			: this(null)
		{
		}

		internal PresenceMessage(RichPresenceResponse rpr)
		{
			if (rpr == null)
			{
				Presence = null;
				Name = "No Rich Presence";
				ApplicationID = "";
			}
			else
			{
				Presence = rpr;
				Name = rpr.Name;
				ApplicationID = rpr.ClientID;
			}
		}
	}
}
