using System;

public interface IUpdateUserTitleDisplayNameRequest
{
	void SetCallbacks(Action<string> result, Action<IllumixErrorData> error);

	void UpdateWithDisplayName(string displayName);
}
