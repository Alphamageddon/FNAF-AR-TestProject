namespace DiscordRPC.IO
{
	public enum Opcode : uint
	{
		Handshake = 0u,
		Frame = 1u,
		Close = 2u,
		Ping = 3u,
		Pong = 4u
	}
}
