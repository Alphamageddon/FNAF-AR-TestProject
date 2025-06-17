public class StoreSectionData
{
	public enum DisplayType
	{
		Carousel = 0,
		Main = 1,
		None = 2
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public StoreSectionData _003C_003E4__this;

		public STORESECTIONS_DATA.Entry entry;

		internal void _003C_002Ector_003Eb__0(Localization localization)
		{
			_003C_003E4__this.DisplayName = localization.GetLocalizedString(entry.StoreSectionName, entry.StoreSectionNameRef);
		}
	}

	public const string DISPLAY_CAROUSEL = "Carousel";

	public const string DISPLAY_MAIN = "Main";

	public const string DISPLAY_NONE = "None";

	public string Logical;

	public string DisplayName;

	public DisplayType Type;

	public int Order;

	public StoreSectionData(STORESECTIONS_DATA.Entry entry)
	{
		_003C_003Ec__DisplayClass8_0 obj = new _003C_003Ec__DisplayClass8_0
		{
			entry = entry,
			_003C_003E4__this = this
		};
		Logical = ((entry.Logical == null) ? "" : entry.Logical);
		obj._003C_002Ector_003Eb__0(LocalizationDomain.Instance.Localization);
		Type = GetDisplayType(entry.DisplayType);
		Order = entry.Order;
	}

	private DisplayType GetDisplayType(string raw)
	{
		if (raw != "Carousel")
		{
			if (!(raw == "Main"))
			{
				return DisplayType.None;
			}
			return DisplayType.Main;
		}
		return DisplayType.Carousel;
	}
}
