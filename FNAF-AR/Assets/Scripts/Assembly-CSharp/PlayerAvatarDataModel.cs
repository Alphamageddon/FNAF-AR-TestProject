using System;
using System.Collections.Generic;

public class PlayerAvatarDataModel
{
	private Action<List<string>> AvatarUnlocksUpdated;

	public List<string> UnlockedAvatarIDs { get; set; }

	public void add_AvatarUnlocksUpdated(Action<List<string>> value)
	{
		AvatarUnlocksUpdated = (Action<List<string>>)Delegate.Combine(AvatarUnlocksUpdated, value);
	}

	public void remove_AvatarUnlocksUpdated(Action<List<string>> value)
	{
		AvatarUnlocksUpdated = (Action<List<string>>)Delegate.Remove(AvatarUnlocksUpdated, value);
	}

	private void EventExposer_PlayerAvatarUnlockedListReceived(List<string> list)
	{
		UnlockedAvatarIDs = list;
		if (AvatarUnlocksUpdated != null)
		{
			AvatarUnlocksUpdated(list);
		}
	}

	public PlayerAvatarDataModel(EventExposer eventExposer)
	{
		UnlockedAvatarIDs = new List<string> { "default", "female", "male" };
		eventExposer.add_PlayerAvatarUnlockedListReceived(EventExposer_PlayerAvatarUnlockedListReceived);
	}
}
