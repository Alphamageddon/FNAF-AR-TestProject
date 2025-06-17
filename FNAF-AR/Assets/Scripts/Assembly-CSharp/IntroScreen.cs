using System;
using UnityEngine;
using UnityEngine.UI;

public class IntroScreen
{
	public class IntroScreenDialogData
	{
		public AttackProfile attackProfile;

		public ScavengingAttackProfile scavengingAttackProfile;

		public bool isEvent;

		public Action encounterCallback;

		public Action<Button, GameObject> hookupsCallback;
	}

	private EventExposer _masterEventExposer;

	private AttackAnimatronicExternalSystems _systems;

	private bool environmentReady;

	private Button readyButton;

	private GameObject loadingIcon;

	private bool encounterButtonHit;

	public void Setup(AttackAnimatronicExternalSystems sys)
	{
		_systems = sys;
	}

	public IntroScreen(EventExposer masterEvents)
	{
		_masterEventExposer = masterEvents;
	}

	public bool IsDone()
	{
		return encounterButtonHit;
	}

	public void MarkReady()
	{
		environmentReady = true;
		if (loadingIcon != null && readyButton != null)
		{
			loadingIcon.SetActive(value: false);
			readyButton.gameObject.SetActive(value: true);
		}
	}

	public void Enable(AttackProfile profile)
	{
		encounterButtonHit = false;
		IntroScreenDialogData introScreenDialogData = new IntroScreenDialogData();
		introScreenDialogData.attackProfile = profile;
		introScreenDialogData.isEvent = false;
		introScreenDialogData.hookupsCallback = AttachHookups;
		introScreenDialogData.encounterCallback = EnterEncounter;
		_masterEventExposer.OnEntityIntroDisplayRequestReceived(introScreenDialogData);
	}

	public void Enable(ScavengingAttackProfile profile)
	{
		encounterButtonHit = false;
		IntroScreenDialogData introScreenDialogData = new IntroScreenDialogData();
		introScreenDialogData.scavengingAttackProfile = profile;
		introScreenDialogData.isEvent = false;
		introScreenDialogData.hookupsCallback = AttachHookups;
		introScreenDialogData.encounterCallback = EnterEncounter;
		_masterEventExposer.OnEntityIntroDisplayRequestReceived(introScreenDialogData);
	}

	private void AttachHookups(Button button, GameObject loadingObj)
	{
		loadingIcon = loadingObj;
		readyButton = button;
		if (environmentReady)
		{
			loadingIcon.SetActive(value: false);
			readyButton.gameObject.SetActive(value: true);
		}
	}

	private void EnterEncounter()
	{
		encounterButtonHit = true;
		environmentReady = false;
		MasterDomain.GetDomain().GameAudioDomain.AudioPlayer.RaiseGameEventForMode(AudioEventName.CameraIntroButtonNormal, AudioMode.Global);
		GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
		gameObject.GetComponent<GyroCamera>().enabled = false;
		gameObject.GetComponent<FirstPersonCameraRotation>().enabled = true;
		gameObject.GetComponent<EscToggleMouse>().enabled = true;
	}

	public void Teardown()
	{
		_masterEventExposer = null;
		_systems = null;
		encounterButtonHit = false;
	}
}
