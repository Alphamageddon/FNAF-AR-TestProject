using UnityEngine;

public abstract class EncounterHUDComponent : IxSceneDisplay
{
	public virtual void Update()
	{
	}

	public virtual void UpdateVisibility(bool isMaskFullyOff)
	{
	}

	protected EncounterHUDComponent(GameObject gameObject)
		: base(gameObject)
	{
	}
}
