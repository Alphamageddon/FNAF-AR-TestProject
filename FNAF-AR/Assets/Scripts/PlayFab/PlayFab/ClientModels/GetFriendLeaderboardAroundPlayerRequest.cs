using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetFriendLeaderboardAroundPlayerRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public bool? IncludeFacebookFriends;

		public bool? IncludeSteamFriends;

		public int? MaxResultsCount;

		public string PlayFabId;

		public PlayerProfileViewConstraints ProfileConstraints;

		public string StatisticName;

		public int? Version;

		public string XboxToken;
	}
}
