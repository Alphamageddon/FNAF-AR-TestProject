using System;

namespace DiscordRPC.Exceptions
{
	[Obsolete("Not actually used anywhere")]
	public class InvalidPipeException : Exception
	{
		internal InvalidPipeException(string message)
			: base(message)
		{
		}
	}
}
