using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerAvatarIconHandler
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Action<Sprite> iconCallback;

		public PlayerAvatarIconHandler _003C_003E4__this;

		internal void _003CGetAvatarProfileSprite_003Eb__0()
		{
			iconCallback(null);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public List<string> keys;

		internal int _003CGetAllAvatarIDs_003Eb__0(string a, string b)
		{
			if (keys.Contains(a))
			{
				if (keys.Contains(b))
				{
					return 0;
				}
				return -1;
			}
			return 1;
		}
	}

	private const string DEFAULT = "default";

	private IconLookup _iconLookup;

	private readonly ItemDefinitions _itemDefinitions;

	private readonly GameUIDomain _gameUIDomain;

	public PlayerAvatarIconHandler(GameAssetManagementDomain assetDomain, ItemDefinitions itemDefinitions, GameUIDomain gameUIDomain)
	{
		_itemDefinitions = itemDefinitions;
		_gameUIDomain = gameUIDomain;
		assetDomain.IconLookupAccess.GetInterfaceAsync(LookupReady);
	}

	private void LookupReady(IconLookup lookup)
	{
		_iconLookup = lookup;
	}

	public void GetAvatarProfileSprite(string avatarId, Action<Sprite> iconCallback)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.iconCallback = iconCallback;
		_003C_003Ec__DisplayClass6_._003C_003E4__this = this;
		if (_iconLookup != null)
		{
			ProfileAvatarData profileAvatarById = _itemDefinitions.GetProfileAvatarById((avatarId == null) ? "default" : avatarId);
			if (profileAvatarById == null)
			{
				Debug.LogError("ProfileAvatarData is null for AvatarID " + ((avatarId == null) ? "default" : avatarId));
			}
			else
			{
				_iconLookup.GetIconFromAtlas(IconGroup.AvatarAtlases, profileAvatarById.Asset, profileAvatarById.SpriteAtlas, iconCallback, _003C_003Ec__DisplayClass6_._003CGetAvatarProfileSprite_003Eb__0);
			}
		}
	}

	public List<string> GetAllAvatarIDs()
	{
		List<string> second = new List<string>(_gameUIDomain.GameUIData.playerAvatarDataModel.UnlockedAvatarIDs);
		if (_itemDefinitions == null)
		{
			return null;
		}
		List<string> keys = new List<string>(_itemDefinitions.ProfileAvatars.Keys);
		return (from s in keys.Intersect(second)
			orderby keys.IndexOf(s)
			select s).ToList();
	}
}
