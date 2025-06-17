using System;

namespace SRF
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class RequiredFieldAttribute : Attribute
	{
		private bool _autoCreate;

		private bool _autoSearch;

		private bool _editorOnly = true;

		public bool AutoSearch
		{
			get
			{
				return _autoSearch;
			}
			set
			{
				_autoSearch = value;
			}
		}

		public bool AutoCreate
		{
			get
			{
				return _autoCreate;
			}
			set
			{
				_autoCreate = value;
			}
		}

		[Obsolete]
		public bool EditorOnly
		{
			get
			{
				return _editorOnly;
			}
			set
			{
				_editorOnly = value;
			}
		}

		public RequiredFieldAttribute(bool autoSearch)
		{
			AutoSearch = autoSearch;
		}

		public RequiredFieldAttribute()
		{
		}
	}
}
