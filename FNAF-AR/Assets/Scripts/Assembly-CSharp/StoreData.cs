using System.Collections.Generic;

public class StoreData
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public STORE_DATA.Entry entry;

		public StoreData _003C_003E4__this;

		internal void _003C_002Ector_003Eb__0(Localization localization)
		{
			_003C_003E4__this.Name = LocalizationDomain.Instance.Localization.GetLocalizedString(entry.PurchasableName, entry.PurchasableName);
			_003C_003E4__this.NameRef = entry.PurchasableNameRef;
			_003C_003E4__this.Description = LocalizationDomain.Instance.Localization.GetLocalizedString(entry.Description, entry.Description);
			_003C_003E4__this.DescriptionRef = entry.DescriptionRef;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public StoreData _003C_003E4__this;

		internal void _003C_002Ector_003Eb__0(Localization localization)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public StoreData _003C_003E4__this;

		internal void _003C_002Ector_003Eb__0(Localization localization)
		{
		}
	}

	public const string ACTION_TYPE_URL = "url";

	public const string ACTIVE = "State_Active";

	public const string YES = "Yes";

	public string Id;

	public string Name;

	public string NameRef;

	public string Description;

	public string DescriptionRef;

	public string StoreSection;

	public int Order;

	public string ArtRef;

	public string DialogArtRef;

	public string BadgeArtRef;

	public string BadgeLocRef;

	public string ButtonLocOverride;

	public bool Live;

	public bool Repeatable;

	public bool Subscription;

	public string ActionType;

	public string ActionPayload;

	public List<StoreItem> Items;

	public List<Currency.CurrencyType> ValidCurrencies;

	public StoreData(STORE_DATA.Entry entry)
	{
		_003C_003Ec__DisplayClass22_0 obj = new _003C_003Ec__DisplayClass22_0
		{
			entry = entry,
			_003C_003E4__this = this
		};
		Id = entry.PurchasableLogical;
		obj._003C_002Ector_003Eb__0(LocalizationDomain.Instance.Localization);
		StoreSection = entry.StoreSection;
		Order = entry.Order;
		ArtRef = entry.ArtRef;
		DialogArtRef = entry.DialogArtRef;
		if (entry.Badge != null && entry.Badge.BadgeArtRef != null)
		{
			BadgeArtRef = entry.Badge.BadgeArtRef;
		}
		else
		{
			BadgeArtRef = "";
		}
		if (entry.Badge != null && entry.Badge.BadgeLocRef != null)
		{
			BadgeLocRef = entry.Badge.BadgeLocRef;
		}
		else
		{
			BadgeLocRef = "";
		}
		if (entry.ButtonLocOverride != null)
		{
			ButtonLocOverride = entry.ButtonLocOverride;
		}
		else
		{
			ButtonLocOverride = "";
		}
		Live = entry.LiveState == "State_Active";
		Repeatable = entry.Repeatable == "Yes";
		Subscription = entry.Subscription == "Yes";
		GetItemsFromContents(entry.Contents);
	}

	private void GetItemsFromContents(STORE_DATA.Contents contents)
	{
		Items = new List<StoreItem>();
		if (contents != null)
		{
			if (contents.Item1 != null)
			{
				AddNewItem(contents.Item1);
			}
			if (contents.Item2 != null)
			{
				AddNewItem(contents.Item2);
			}
			if (contents.Item3 != null)
			{
				AddNewItem(contents.Item3);
			}
			if (contents.Item4 != null)
			{
				AddNewItem(contents.Item4);
			}
			if (contents.Item5 != null)
			{
				AddNewItem(contents.Item5);
			}
			if (contents.Item6 != null)
			{
				AddNewItem(contents.Item6);
			}
		}
	}

	private void AddNewItem(STORE_DATA.Item item)
	{
		if (item != null)
		{
			Items.Add(new StoreItem(item.Logical, item.Type, item.Qty));
		}
	}

	public string GenerateDescription()
	{
		if (Items == null)
		{
			return "";
		}
		string text = "";
		foreach (StoreItem item in Items)
		{
			text = text + item.Id + " x" + item.Quantity + "\n";
		}
		return text;
	}
}
