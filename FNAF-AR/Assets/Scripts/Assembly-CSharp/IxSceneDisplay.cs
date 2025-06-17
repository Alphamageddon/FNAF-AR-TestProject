using UnityEngine;

public abstract class IxSceneDisplay
{
	protected ComponentContainer _components;

	protected GameObject _root;

	protected IxSceneDisplay(GameObject gameObject)
	{
		_root = gameObject;
		_components = new ComponentContainer();
		CacheAndPopulateComponents();
	}

	public virtual void Teardown()
	{
		_components.TearDown();
		_components = null;
		_root = null;
	}

	public virtual void Show()
	{
		_root.SetActive(value: true);
	}

	public void Hide()
	{
		_root.SetActive(value: false);
	}

	public virtual bool IsActive()
	{
		if (_root != null)
		{
			return _root.activeSelf;
		}
		return false;
	}

	protected abstract void CacheAndPopulateComponents();
}
