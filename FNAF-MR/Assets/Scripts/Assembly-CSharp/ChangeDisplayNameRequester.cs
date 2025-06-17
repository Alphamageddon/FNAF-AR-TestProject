using System;

public interface ChangeDisplayNameRequester
{
	void ChangeDisplayName(string displayName);

	void Setup(Action<PlayerProfile> playerProfileCallback, Action<UserNameSetError> obscenityFoundCallback);
}
