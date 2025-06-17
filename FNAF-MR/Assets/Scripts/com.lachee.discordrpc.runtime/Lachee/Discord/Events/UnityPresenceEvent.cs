using System;
using UnityEngine.Events;

namespace Lachee.Discord.Events
{
	[Serializable]
	[Obsolete("This is a wrapper for Unity 2018")]
	public class UnityPresenceEvent : UnityEvent<PresenceEvent>
	{
	}
}
