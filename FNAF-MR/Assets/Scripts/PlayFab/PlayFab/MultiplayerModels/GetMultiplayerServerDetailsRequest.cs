using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetMultiplayerServerDetailsRequest : PlayFabRequestCommon
	{
		[Obsolete("No longer available", false)]
		public string BuildId;

		public Dictionary<string, string> CustomTags;

		[Obsolete("No longer available", false)]
		public string Region;

		public string SessionId;
	}
}
