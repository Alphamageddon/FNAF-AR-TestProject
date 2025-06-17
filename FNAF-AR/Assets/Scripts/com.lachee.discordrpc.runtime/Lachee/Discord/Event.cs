using System;

namespace Lachee.Discord
{
	[Flags]
	public enum Event
	{
		None = 0,
		Spectate = 1,
		Join = 2,
		JoinRequest = 4
	}
}
