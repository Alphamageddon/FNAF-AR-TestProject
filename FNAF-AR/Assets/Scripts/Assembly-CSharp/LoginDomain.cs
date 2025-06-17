using System;
using UnityEngine;

public class LoginDomain
{
	public static readonly string PlayerPrefsLastServerSyncedNameKey;

	public static readonly string PLAYERPREFS_SERVER_TYPE;

	private EventExposer _masterEvents;

	private ServerDomain _serverDomain;

	public PlayerProfileUpdater playerProfileUpdater;

	public PlayerProfile playerProfile;

	public ChangeDisplayNameRequester changeDisplayNameRequester;

	public LoginDomain(ServerDomain ServerDomain, Action<bool> onGeneratePlayStreamEventReceived)
	{
		playerProfileUpdater = new PlayerProfileUpdater();
		IllumixLoginHandlerParameters illumixLoginHandlerParameters = new IllumixLoginHandlerParameters(ServerDomain, onGeneratePlayStreamEventReceived);
		changeDisplayNameRequester = new IllumixChangeDisplayNameRequester(illumixLoginHandlerParameters.updateUserTitleDisplayNameRequest);
		playerProfile = new PlayerProfile();
	}

	public void Setup(EventExposer masterEvents, ServerDomain serverDomain, Action authFunction, Action<string> forcedUpdateFunction, Action<ServerData> streakUpdater)
	{
		_masterEvents = masterEvents;
		_serverDomain = serverDomain;
		AuthenticateDevice();
	}

	public void Update()
	{
	}

	public void Teardown()
	{
		playerProfile = null;
		changeDisplayNameRequester = null;
		playerProfileUpdater = null;
	}

	public void SelectTargetServerId(string serverId)
	{
	}

	public void AuthenticateDevice()
	{
		playerProfileUpdater.Setup(_masterEvents);
		_masterEvents.add_PlayerProfileUpdated(OnPlayerProfileUpdated);
		_masterEvents.add_DisplayNameObscenityFound(MasterEvents_DisplayNameObscenityFound);
		changeDisplayNameRequester.Setup(_masterEvents.OnPlayerProfileUpdated, _masterEvents.OnDisplayNameObscenityFound);
	}

	public void PrepareForLogin()
	{
	}

	private void OnPlayerProfileUpdated(PlayerProfile profile)
	{
		PlayerPrefs.SetString(PlayerPrefsLastServerSyncedNameKey, profile.displayName);
		playerProfile = profile;
	}

	private void MasterEvents_DisplayNameObscenityFound(UserNameSetError error)
	{
		playerProfile.displayName = PlayerPrefs.GetString(PlayerPrefsLastServerSyncedNameKey, playerProfile.displayName);
	}

	static LoginDomain()
	{
		PlayerPrefsLastServerSyncedNameKey = "LoginDomain_LastServerSyncedName";
		PLAYERPREFS_SERVER_TYPE = "playerprefs_server_type";
	}
}
