using System;
using UnityEngine;

public class StoreIconFetcher
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Action<Sprite> iconCallback;

		public StoreIconFetcher _003C_003E4__this;

		public string iconName;

		internal void _003CGetStoreIcon_003Eb__0(Sprite sprite)
		{
			if (iconCallback != null)
			{
				iconCallback(sprite);
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Action<Sprite> iconCallback;

		internal void _003CGetShopUIIcon_003Eb__0(Sprite sprite)
		{
			if (iconCallback != null)
			{
				iconCallback(sprite);
			}
		}
	}

	private IconLookup _iconLookup;

	public StoreIconFetcher(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
	}

	public bool IconsReady()
	{
		return _iconLookup != null;
	}

	public void GetStoreIcon(string iconName, Action<Sprite> iconCallback)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.iconCallback = iconCallback;
		_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass3_.iconName = iconName;
		_iconLookup.GetIcon(IconGroup.Store, iconName, _003C_003Ec__DisplayClass3_._003CGetStoreIcon_003Eb__0);
	}

	public void GetShopUIIcon(string iconName, Action<Sprite> iconCallback)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.iconCallback = iconCallback;
		_iconLookup.GetIcon(IconGroup.ShopUI, iconName, _003C_003Ec__DisplayClass4_._003CGetShopUIIcon_003Eb__0);
	}
}
