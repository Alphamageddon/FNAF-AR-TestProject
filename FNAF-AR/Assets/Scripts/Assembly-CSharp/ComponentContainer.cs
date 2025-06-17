using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComponentContainer
{
	public static readonly Type[] Texts;

	public static readonly Type[] Buttons;

	public static readonly Type[] Images;

	public static readonly Type[] TextsButtons;

	public static readonly Type[] TextsImages;

	public static readonly Type[] ButtonsImages;

	public static readonly Type[] TextsButtonsImages;

	public static readonly Type[] AnimatorsTextsImages;

	private Dictionary<Type, Dictionary<string, LinkedList<Component>>> _components;

	private void CacheComponent(Component component)
	{
		CacheComponentWithType(component, component.GetType());
	}

	private void CacheComponentWithType(Component component, Type t)
	{
		if (!_components.TryGetValue(t, out var value))
		{
			_components.Add(t, new Dictionary<string, LinkedList<Component>>());
		}
		value = _components[t];
		if (!value.TryGetValue(component.name, out var value2))
		{
			value.Add(component.name, new LinkedList<Component>());
		}
		value2 = value[component.name];
		value2.AddLast(component);
	}

	private T GetCachedComponent<T>(string searchName, Type componentType, bool suppressError = false) where T : Component
	{
		Dictionary<string, LinkedList<Component>> value = null;
		if (!_components.TryGetValue(componentType, out value))
		{
			return null;
		}
		if (!value.TryGetValue(searchName, out var value2))
		{
			if (!suppressError)
			{
				string text = $"Could not find component {searchName} of type {componentType}";
				Debug.LogError("ComponentContainer GetCachedComponent - " + text);
			}
			return null;
		}
		if (value2.First.Value == null)
		{
			return null;
		}
		return (T)value2.First.Value;
	}

	public void CacheComponentsWithInheritance(GameObject gameObject, Type[] onlyCacheTypes)
	{
		foreach (Type type in onlyCacheTypes)
		{
			Component[] componentsInChildren = gameObject.GetComponentsInChildren(type, includeInactive: true);
			foreach (Component component in componentsInChildren)
			{
				CacheComponentWithType(component, type);
			}
		}
	}

	public void CacheComponents(GameObject gameObject, Type[] onlyCacheTypes)
	{
		foreach (Type type in onlyCacheTypes)
		{
			Component[] componentsInChildren = gameObject.GetComponentsInChildren(type, includeInactive: true);
			foreach (Component component in componentsInChildren)
			{
				CacheComponent(component);
			}
		}
	}

	public bool TryGetComponent<T>(string searchName, out T returnComponent, bool suppressError = false) where T : Component
	{
		returnComponent = TryGetComponent<T>(searchName, suppressError);
		return returnComponent != null;
	}

	public T TryGetComponent<T>(string searchName, bool suppressError = false) where T : Component
	{
		return GetCachedComponent<T>(searchName, typeof(T), suppressError);
	}

	public void TearDown()
	{
		if (_components != null)
		{
			_components.Clear();
		}
		_components = null;
	}

	public ComponentContainer()
	{
		_components = new Dictionary<Type, Dictionary<string, LinkedList<Component>>>();
	}

	static ComponentContainer()
	{
		Texts = new Type[1] { typeof(TextMeshProUGUI) };
		Buttons = new Type[1] { typeof(Button) };
		Images = new Type[1] { typeof(Image) };
		TextsButtons = new Type[2]
		{
			typeof(TextMeshProUGUI),
			typeof(Button)
		};
		TextsImages = new Type[2]
		{
			typeof(TextMeshProUGUI),
			typeof(Image)
		};
		ButtonsImages = new Type[2]
		{
			typeof(Button),
			typeof(Image)
		};
		TextsButtonsImages = new Type[3]
		{
			typeof(TextMeshProUGUI),
			typeof(Button),
			typeof(Image)
		};
		AnimatorsTextsImages = new Type[3]
		{
			typeof(Animator),
			typeof(TextMeshProUGUI),
			typeof(Image)
		};
	}
}
