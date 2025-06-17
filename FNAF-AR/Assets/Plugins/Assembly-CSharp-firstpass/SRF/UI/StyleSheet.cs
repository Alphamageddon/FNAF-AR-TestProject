using System;
using System.Collections.Generic;
using UnityEngine;

namespace SRF.UI
{
	[Serializable]
	public class StyleSheet : ScriptableObject
	{
		[SerializeField]
		private List<string> _keys = new List<string>();

		[SerializeField]
		private List<Style> _styles = new List<Style>();

		[SerializeField]
		public StyleSheet Parent;

		public Style GetStyle(string key, bool searchParent = true)
		{
			int num = _keys.IndexOf(key);
			if (num < 0)
			{
				if (searchParent && Parent != null)
				{
					return Parent.GetStyle(key);
				}
				return null;
			}
			return _styles[num];
		}
	}
}
