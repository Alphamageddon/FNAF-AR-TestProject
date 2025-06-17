using System;

namespace DiscordRPC.Message
{
	public abstract class IMessage
	{
		private DateTime _timecreated;

		public abstract MessageType Type { get; }

		public DateTime TimeCreated => _timecreated;

		public IMessage()
		{
			_timecreated = DateTime.Now;
		}
	}
}
