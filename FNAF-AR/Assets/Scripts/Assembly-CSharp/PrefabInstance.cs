using System;
using UnityEngine;

public class PrefabInstance
{
	public GameObject Root;

	public ComponentContainer ComponentContainer;

	private Action RequestClose;

	public void add_RequestClose(Action value)
	{
		RequestClose = (Action)Delegate.Combine(RequestClose, value);
	}

	public void remove_RequestClose(Action value)
	{
		RequestClose = (Action)Delegate.Remove(RequestClose, value);
	}

	public void DispatchCloseEvent()
	{
		Debug.LogWarning("Dispatch close event called");
		if (RequestClose == null)
		{
			Debug.LogWarning("Dispatch close event is NULL MOTHER FUCKER");
			Clear();
		}
		else
		{
			RequestClose();
		}
	}

	public void Clear()
	{
		if (Root != null)
		{
			UnityEngine.Object.Destroy(Root);
		}
		Root = null;
		if (ComponentContainer != null)
		{
			ComponentContainer.TearDown();
		}
		ComponentContainer = null;
	}
}
