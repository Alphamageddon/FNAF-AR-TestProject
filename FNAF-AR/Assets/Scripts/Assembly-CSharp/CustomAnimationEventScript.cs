using System;
using UnityEngine;

public class CustomAnimationEventScript : MonoBehaviour
{
	public event Action<string> AnimEvent;

	public event Action<int> AnimComplete;

	public void OnAnimEvent(string message)
	{
		this.AnimEvent?.Invoke(message);
	}

	public void OnAnimComplete(int step)
	{
		this.AnimComplete?.Invoke(step);
	}
}
