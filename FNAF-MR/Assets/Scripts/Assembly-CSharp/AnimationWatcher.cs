using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Playables;

public class AnimationWatcher
{
	private List<PlayableDirector> animations;

	public AnimationWatcher(GameObject gameObject)
	{
		animations = gameObject.GetComponentsInChildren<PlayableDirector>().ToList();
		PlayableDirector component = gameObject.GetComponent<PlayableDirector>();
		if (!(component == null))
		{
			animations.Add(component);
		}
	}

	public bool AllAnimationsComplete()
	{
		foreach (PlayableDirector animation in animations)
		{
			if (animation.state == PlayState.Playing)
			{
				return false;
			}
		}
		return true;
	}
}
