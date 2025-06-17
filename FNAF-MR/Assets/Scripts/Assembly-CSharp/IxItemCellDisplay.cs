using UnityEngine;

public abstract class IxItemCellDisplay<T> : IIxItemCellDisplay
{
	protected GameObject _root;

	protected ComponentContainer _components;

	protected T _dataItem;

	public virtual void Setup(GameObject root, T dataItem)
	{
		_root = root;
		_components = new ComponentContainer();
		_dataItem = dataItem;
		PopulateComponents();
	}

	public virtual void TearDown()
	{
		if (_components != null)
		{
			_components.TearDown();
		}
		_components = null;
		Object.Destroy(_root);
	}

	protected abstract void PopulateComponents();

	public abstract void UpdateData();

	public float GetWidth()
	{
		return ((RectTransform)_root.transform).rect.xMin;
	}

	public float GetHeight()
	{
		return ((RectTransform)_root.transform).rect.xMin;
	}
}
