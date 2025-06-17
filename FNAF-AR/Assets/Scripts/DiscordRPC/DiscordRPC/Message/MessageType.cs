namespace DiscordRPC.Message
{
	public enum MessageType
	{
		Ready = 0,
		Close = 1,
		Error = 2,
		PresenceUpdate = 3,
		Subscribe = 4,
		Unsubscribe = 5,
		Join = 6,
		Spectate = 7,
		JoinRequest = 8,
		ConnectionEstablished = 9,
		ConnectionFailed = 10
	}
}
