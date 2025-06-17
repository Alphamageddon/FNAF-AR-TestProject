using System;
using UnityEngine;

public class AnimationEventListener : MonoBehaviour
{
	public event Action<AnimationEvent> OnAnimationEventReceived;

	public void RaiseAnimationEvent(AnimationEvent animationEvent)
	{
		this.OnAnimationEventReceived?.Invoke(animationEvent);
	}
}
