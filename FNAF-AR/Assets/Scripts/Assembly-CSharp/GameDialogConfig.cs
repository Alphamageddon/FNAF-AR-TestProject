using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public struct GameDialogConfig
{
	public string ResourcePath;

	public string AttachParentName;

	public UnityAction OnDismissCallback;

	public Dictionary<string, string> Strings;

	public Dictionary<string, UnityAction> ButtonCallbacks;

	public Dictionary<string, Sprite> Sprites;

	public Dictionary<string, IconGroup> IconGroups;

	public Dictionary<string, string> SpriteNames;

	public KeyValuePair<string, int> NumberOfStars;

	public Dictionary<string, bool> GameObjectEnables;

	public Dictionary<string, bool> ButtonInteractables;

	public List<string> DismissButtons;

	public bool PlayAudioOnShow;

	public AudioEventName AudioEventName;

	public AudioMode AudioMode;

	public bool EnableAndroidBackButton;

	public Action<PrefabInstance> CustomCachingAction;
}
