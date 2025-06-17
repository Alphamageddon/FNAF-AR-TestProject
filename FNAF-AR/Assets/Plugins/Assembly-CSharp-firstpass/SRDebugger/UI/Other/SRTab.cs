using System;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.Serialization;

namespace SRDebugger.UI.Other
{
	public class SRTab : SRMonoBehaviourEx
	{
		public RectTransform HeaderExtraContent;

		[Obsolete]
		[HideInInspector]
		public Sprite Icon;

		public RectTransform IconExtraContent;

		public string IconStyleKey = "Icon_Stompy";

		public int SortIndex;

		[HideInInspector]
		public SRTabButton TabButton;

		[SerializeField]
		[FormerlySerializedAs("Title")]
		private string _title;

		[SerializeField]
		private string _longTitle;

		[SerializeField]
		private string _key;

		public string Title => _title;

		public string LongTitle
		{
			get
			{
				if (string.IsNullOrEmpty(_longTitle))
				{
					return _title;
				}
				return _longTitle;
			}
		}

		public string Key => _key;
	}
}
