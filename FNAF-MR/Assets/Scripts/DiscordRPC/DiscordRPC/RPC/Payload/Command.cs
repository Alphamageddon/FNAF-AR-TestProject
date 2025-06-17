using System;
using DiscordRPC.Converters;

namespace DiscordRPC.RPC.Payload
{
	internal enum Command
	{
		[EnumValue("DISPATCH")]
		Dispatch = 0,
		[EnumValue("SET_ACTIVITY")]
		SetActivity = 1,
		[EnumValue("SUBSCRIBE")]
		Subscribe = 2,
		[EnumValue("UNSUBSCRIBE")]
		Unsubscribe = 3,
		[EnumValue("SEND_ACTIVITY_JOIN_INVITE")]
		SendActivityJoinInvite = 4,
		[EnumValue("CLOSE_ACTIVITY_JOIN_REQUEST")]
		CloseActivityJoinRequest = 5,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		Authorize = 6,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		Authenticate = 7,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		GetGuild = 8,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		GetGuilds = 9,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		GetChannel = 10,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		GetChannels = 11,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		SetUserVoiceSettings = 12,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		SelectVoiceChannel = 13,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		GetSelectedVoiceChannel = 14,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		SelectTextChannel = 15,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		GetVoiceSettings = 16,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		SetVoiceSettings = 17,
		[Obsolete("This value is appart of the RPC API and is not supported by this library.", true)]
		CaptureShortcut = 18
	}
}
