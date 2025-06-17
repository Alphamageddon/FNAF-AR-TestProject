using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class CatalogItem : PlayFabBaseModel
	{
		public List<CatalogAlternateId> AlternateIds;

		public List<Content> Contents;

		public string ContentType;

		public DateTime? CreationDate;

		public EntityKey CreatorEntity;

		public Dictionary<string, string> Description;

		public object DisplayProperties;

		public string DisplayVersion;

		public DateTime? EndDate;

		public string ETag;

		public string Id;

		public List<Image> Images;

		public bool? IsHidden;

		public Dictionary<string, KeywordSet> Keywords;

		public DateTime? LastModifiedDate;

		public ModerationState Moderation;

		public Rating Rating;

		public DateTime? StartDate;

		public List<string> Tags;

		public Dictionary<string, string> Title;

		public string Type;
	}
}
