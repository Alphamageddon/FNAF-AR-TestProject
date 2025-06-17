using UnityEngine;

public abstract class IxDisplay
{
	protected PrefabInstance _prefabInstance;

	protected ComponentContainer _components;

	protected GameObject _root;

	protected IxDisplay(PrefabInstance instance)
	{
		_prefabInstance = instance;
		_root = instance.Root;
		_components = instance.ComponentContainer;
		CacheAndPopulateComponents();
	}

	public virtual void Teardown()
	{
		_components.TearDown();
		_components = null;
		_prefabInstance = null;
	}

	public void ForceClose()
	{
		Debug.LogWarning("Force closing a dialog: " + _prefabInstance.Root.name);
		_prefabInstance.DispatchCloseEvent();
	}

	protected abstract void CacheAndPopulateComponents();
}
