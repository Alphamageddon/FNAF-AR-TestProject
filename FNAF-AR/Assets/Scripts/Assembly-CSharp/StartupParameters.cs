using System;
using System.Collections.Generic;
using UnityEngine;

public class StartupParameters
{
	public Func<MasterDomain> MasterDomainGetter;

	public List<Action> RegisteredTeardownCallbacks;

	public bool HasToSBeenAcceptedYet;

	public MonoBehaviour HostMonobehavior;

	public GameLifecycleProxy GameLifecycleProxy;

	public GameUnityHooks UnityHooks;
}
