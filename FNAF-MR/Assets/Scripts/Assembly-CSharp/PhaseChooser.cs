using System;
using System.Collections.Generic;
using UnityEngine;

public class PhaseChooser
{
	private static readonly string ClassName;

	private EventExposer _masterEventExposer;

	private Blackboard _blackboard;

	private Action _readyForCleanupCallback;

	private Dictionary<AttackPhase, Phase> _phaseLookup;

	private Phase _currentPhase;

	public AttackPhase Phase
	{
		get
		{
			if (_currentPhase != null)
			{
				return _currentPhase.AttackPhase;
			}
			return AttackPhase.Null;
		}
	}

	public void Update()
	{
		if (_blackboard.ForceJumpscare)
		{
			_blackboard.ForceJumpscare = false;
			SetPhase(AttackPhase.Jumpscare);
		}
		else
		{
			SetPhase((_currentPhase != null) ? _currentPhase.Update() : AttackPhase.Null);
		}
	}

	public void OffscreenLossTriggered()
	{
		SetPhase(AttackPhase.JumpscareOffscreen);
	}

	private void SetPhase(AttackPhase newPhase)
	{
		if (newPhase == AttackPhase.Null)
		{
			return;
		}
		Debug.Log("Switching to phase " + newPhase);
		if (_currentPhase != null)
		{
			_currentPhase.Exit();
		}
		if (newPhase == AttackPhase.ReadyForCleanup)
		{
			_readyForCleanupCallback?.Invoke();
		}
		else if (_phaseLookup.ContainsKey(newPhase))
		{
			if (_phaseLookup[newPhase] == null)
			{
				Debug.LogError("Phase " + newPhase.ToString() + " is null.");
				return;
			}
			_currentPhase = _phaseLookup[newPhase];
			_currentPhase.Enter();
		}
	}

	public PhaseChooser(EventExposer masterEventExposer, Action readyForCleanupCallback)
	{
		_masterEventExposer = masterEventExposer;
		_readyForCleanupCallback = readyForCleanupCallback;
	}

	public void Setup(Blackboard blackboard)
	{
		_blackboard = blackboard;
		CreatePhaseLookup(blackboard.EncounterType);
		SetPhase(AttackPhase.WaitForEnvironmentPreload);
	}

	private void CreatePhaseLookup(EncounterType encounterType)
	{
		_phaseLookup = new Dictionary<AttackPhase, Phase>();
		switch (encounterType)
		{
		case EncounterType.Standard:
			CreateStandardPhaseLookup();
			break;
		case EncounterType.Tutorial:
			CreateTutorialPhaseLookup();
			break;
		case EncounterType.TutorialAutoWin:
			CreateTutorialAutoWinPhaseLookup();
			break;
		case EncounterType.Phantom:
			CreatePhantomPhaseLookup();
			break;
		case EncounterType.LookAwayApproach:
			CreateLookAwayApproachPhaseLookup();
			break;
		case EncounterType.TagTeam:
			CreateTagTeamPhaseLookup();
			break;
		case EncounterType.Scavenging:
			CreateScavengingPhaseLookup();
			break;
		default:
			_currentPhase = null;
			break;
		}
	}

	private void CreateCommonPhaseLookup()
	{
		CreateAndAddPhase<InitialPause>(AttackPhase.InitialPause);
		CreateAndAddPhase<Pause>(AttackPhase.Pause);
		CreateAndAddPhase<Circle>(AttackPhase.Circle);
		CreateAndAddPhase<Glimpse>(AttackPhase.Glimpse);
		CreateAndAddPhase<Damaged>(AttackPhase.Damaged);
		CreateAndAddPhase<Haywire>(AttackPhase.Haywire);
		CreateAndAddPhase<JumpscareOffscreen>(AttackPhase.JumpscareOffscreen);
		CreateAndAddPhase<Shutdown>(AttackPhase.Shutdown);
		CreateAndAddPhase<Results>(AttackPhase.Results);
		CreateAndAddPhase<Slashed>(AttackPhase.Slashed);
		CreateAndAddPhase<AttackPlayer>(AttackPhase.AttackPlayer);
		CreateAndAddPhase<Slash>(AttackPhase.Slash);
	}

	private void CreateStandardPhaseLookup()
	{
		CreateAndAddPhase<WaitForEnvironmentPreload>(AttackPhase.WaitForEnvironmentPreload);
		CreateAndAddPhase<WaitForCamera>(AttackPhase.WaitForCamera);
		CreateAndAddPhase<Charge>(AttackPhase.Charge);
		CreateAndAddPhase<Jumpscare>(AttackPhase.Jumpscare);
		CreateCommonPhaseLookup();
	}

	private void CreateScavengingPhaseLookup()
	{
		CreateAndAddPhase<ScavengingWaitForEnvironmentPreload>(AttackPhase.WaitForEnvironmentPreload);
		CreateAndAddPhase<ScavengingWaitForCamera>(AttackPhase.WaitForCamera);
		CreateAndAddPhase<ScavengingDormant>(AttackPhase.ScavengingDormant);
		CreateAndAddPhase<ScavengingSearching>(AttackPhase.ScavengingSearching);
		CreateAndAddPhase<ScavengingSpotted>(AttackPhase.ScavengingSpotted);
		CreateAndAddPhase<ScavengingStunned>(AttackPhase.ScavengingStunned);
		CreateAndAddPhase<ScavengingJumpscare>(AttackPhase.Jumpscare);
		CreateAndAddPhase<ScavengingJumpscareOffscreen>(AttackPhase.JumpscareOffscreen);
		CreateAndAddPhase<ScavengingEscape>(AttackPhase.ScavengingEscape);
		CreateAndAddPhase<ScavengingResults>(AttackPhase.Results);
	}

	private void CreateTutorialPhaseLookup()
	{
	}

	private void CreateTutorialAutoWinPhaseLookup()
	{
	}

	private void CreatePhantomPhaseLookup()
	{
		CreateAndAddPhase<WaitForEnvironmentPreload>(AttackPhase.WaitForEnvironmentPreload);
		CreateAndAddPhase<WaitForCamera>(AttackPhase.WaitForCamera);
		CreateAndAddPhase<PhantomInitialPause>(AttackPhase.InitialPause);
		CreateAndAddPhase<PhantomWalk>(AttackPhase.PhantomWalk);
		CreateAndAddPhase<PhantomOverload>(AttackPhase.PhantomOverload);
		CreateAndAddPhase<PhantomPause>(AttackPhase.Pause);
		CreateAndAddPhase<PhantomJumpscare>(AttackPhase.Jumpscare);
		CreateAndAddPhase<PhantomJumpscareOffscreen>(AttackPhase.JumpscareOffscreen);
		CreateAndAddPhase<PhantomShutdown>(AttackPhase.Shutdown);
		CreateAndAddPhase<PhantomHaywire>(AttackPhase.Haywire);
		CreateAndAddPhase<Results>(AttackPhase.Results);
	}

	private void CreateLookAwayApproachPhaseLookup()
	{
	}

	private void CreateTagTeamPhaseLookup()
	{
	}

	private void CreateAndAddPhase<T>(AttackPhase phase) where T : Phase, new()
	{
		if (!_phaseLookup.ContainsKey(phase))
		{
			T val = new T();
			val.Setup(_blackboard);
			_phaseLookup.Add(phase, val);
		}
	}

	public void RequestDestruction()
	{
		SetPhase(AttackPhase.ReadyForCleanup);
	}

	public void ClearPhases()
	{
		_currentPhase = null;
		if (_phaseLookup == null)
		{
			return;
		}
		foreach (Phase value in _phaseLookup.Values)
		{
			value.Teardown();
		}
		_phaseLookup.Clear();
		_phaseLookup = null;
	}

	public void Teardown()
	{
		ClearPhases();
		_blackboard = null;
		_readyForCleanupCallback = null;
		_masterEventExposer = null;
	}
}
