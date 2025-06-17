using DiscordRPC.Converters;

namespace DiscordRPC.RPC.Payload
{
	internal enum ServerEvent
	{
		[EnumValue("READY")]
		Ready = 0,
		[EnumValue("ERROR")]
		Error = 1,
		[EnumValue("ACTIVITY_JOIN")]
		ActivityJoin = 2,
		[EnumValue("ACTIVITY_SPECTATE")]
		ActivitySpectate = 3,
		[EnumValue("ACTIVITY_JOIN_REQUEST")]
		ActivityJoinRequest = 4
	}
}
