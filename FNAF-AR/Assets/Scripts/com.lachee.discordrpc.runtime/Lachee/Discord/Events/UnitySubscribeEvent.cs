using System;
using DiscordRPC.Message;
using UnityEngine.Events;

namespace Lachee.Discord.Events
{
	[Serializable]
	[Obsolete("This is a wrapper for Unity 2018")]
	public class UnitySubscribeEvent : UnityEvent<SubscribeMessage>
	{
	}
}
