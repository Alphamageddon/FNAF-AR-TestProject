using System;
using System.Collections.Generic;

public class ShutdownParameters
{
	public Func<MasterDomain> MasterDomainGetter;

	public List<Action> RegisteredTeardownCallbacks;
}
