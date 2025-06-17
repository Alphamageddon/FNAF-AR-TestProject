using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogConfigurer
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public UnityAction closeDialog;

		internal void _003CSetComponentValues_003Eb__1()
		{
			closeDialog();
		}

		internal void _003CSetComponentValues_003Eb__2()
		{
			closeDialog();
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_1
	{
		public Image textMeshProUgui;

		internal void _003CSetComponentValues_003Eb__0(Sprite sprite)
		{
			textMeshProUgui.overrideSprite = sprite;
		}
	}

	private IconLookup _iconLookup;

	public DialogConfigurer()
	{
		MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(IconCacheReady);
	}

	private void IconCacheReady(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
	}

	private static void CacheStandardComponents(PrefabInstance prefabInstance, GameDialogConfig gameDialogConfig)
	{
		List<Type> list = new List<Type>();
		list.Add(typeof(Sprite));
		list.Add(typeof(Button));
		list.Add(typeof(Image));
		list.Add(typeof(IconGroup));
		list.Add(typeof(TextMeshProUGUI));
		list.Add(typeof(StarDisplay));
		list.Add(typeof(Transform));
		prefabInstance.ComponentContainer.CacheComponents(prefabInstance.Root, list.ToArray());
	}

	private void SetComponentValues(PrefabInstance prefabInstance, GameDialogConfig gameDialogConfig, UnityAction closeDialog)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.closeDialog = closeDialog;
		if (gameDialogConfig.Strings != null)
		{
			foreach (string key in gameDialogConfig.Strings.Keys)
			{
				if (prefabInstance.ComponentContainer != null)
				{
					TextMeshProUGUI returnComponent = null;
					prefabInstance.ComponentContainer.TryGetComponent<TextMeshProUGUI>(key, out returnComponent);
					if (returnComponent != null)
					{
						returnComponent.text = gameDialogConfig.Strings[key];
					}
				}
			}
		}
		if (gameDialogConfig.Sprites != null)
		{
			foreach (string key2 in gameDialogConfig.Sprites.Keys)
			{
				_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_1();
				if (prefabInstance.ComponentContainer.TryGetComponent<Image>(key2, out _003C_003Ec__DisplayClass4_2.textMeshProUgui))
				{
					if (gameDialogConfig.Sprites[key2] != null)
					{
						_003C_003Ec__DisplayClass4_2._003CSetComponentValues_003Eb__0(gameDialogConfig.Sprites[key2]);
					}
					if (gameDialogConfig.SpriteNames.ContainsKey(key2) && gameDialogConfig.IconGroups.ContainsKey(key2))
					{
						_iconLookup.GetIcon(gameDialogConfig.IconGroups[key2], gameDialogConfig.SpriteNames[key2], _003C_003Ec__DisplayClass4_2._003CSetComponentValues_003Eb__0);
					}
				}
			}
		}
		if (gameDialogConfig.ButtonCallbacks != null)
		{
			Debug.Log("Button Callbacks");
			foreach (string key3 in gameDialogConfig.ButtonCallbacks.Keys)
			{
				Debug.Log("Callback for button " + key3 + " is " + gameDialogConfig.ButtonCallbacks[key3].Method.ToString());
				Button returnComponent2 = null;
				if (prefabInstance.ComponentContainer.TryGetComponent<Button>(key3, out returnComponent2))
				{
					returnComponent2.onClick.RemoveListener(gameDialogConfig.ButtonCallbacks[key3]);
					returnComponent2.onClick.AddListener(gameDialogConfig.ButtonCallbacks[key3]);
				}
			}
		}
		if (gameDialogConfig.NumberOfStars.Value >= 1 && prefabInstance.ComponentContainer.TryGetComponent<StarDisplay>(gameDialogConfig.NumberOfStars.Key, out var returnComponent3))
		{
			returnComponent3.SetStars(gameDialogConfig.NumberOfStars.Value);
		}
		if (gameDialogConfig.GameObjectEnables != null)
		{
			foreach (string key4 in gameDialogConfig.GameObjectEnables.Keys)
			{
				if (prefabInstance.ComponentContainer.TryGetComponent<Transform>(key4, out var returnComponent4))
				{
					returnComponent4.gameObject.SetActive(gameDialogConfig.GameObjectEnables[key4]);
				}
			}
		}
		if (gameDialogConfig.ButtonInteractables != null)
		{
			foreach (string key5 in gameDialogConfig.ButtonInteractables.Keys)
			{
				Debug.Log("setting interactable for button " + key5 + " to value " + gameDialogConfig.ButtonInteractables[key5]);
				if (prefabInstance.ComponentContainer.TryGetComponent<Button>(key5, out var returnComponent5))
				{
					returnComponent5.interactable = gameDialogConfig.ButtonInteractables[key5];
				}
			}
		}
		if (gameDialogConfig.DismissButtons == null)
		{
			return;
		}
		foreach (string dismissButton in gameDialogConfig.DismissButtons)
		{
			if (prefabInstance.ComponentContainer.TryGetComponent<Button>(dismissButton, out var returnComponent6))
			{
				returnComponent6.onClick.AddListener(_003C_003Ec__DisplayClass4_._003CSetComponentValues_003Eb__1);
				returnComponent6.interactable = true;
			}
		}
	}

	private void LogErrorNotFound(string objectName, string functionName, Type value, string variableValue)
	{
		Debug.LogError("ERROR: Unable to locate cached component of type: " + value?.ToString() + " named: " + variableValue);
	}

	public void ConfigureDialog(PrefabInstance instance, GameDialogConfig config, UnityAction action)
	{
		if (config.CustomCachingAction != null)
		{
			config.CustomCachingAction(instance);
		}
		else
		{
			CacheStandardComponents(instance, config);
		}
		SetComponentValues(instance, config, action);
	}
}
