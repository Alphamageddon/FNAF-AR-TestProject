using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IxTableDisplay<T1, T2> where T1 : IxItemCellDisplay<T2>, new()
{
	private const int STARTING_LIST_CAPACITY = 16;

	private static GameObject _templateItemFosterHome;

	protected List<T1> _displayItems;

	protected List<T2> _dataItems;

	protected GameObject _templateItem;

	protected LayoutGroup _itemDisplayParent;

	public List<T1> DisplayItems => _displayItems;

	public IxTableDisplay(LayoutGroup itemDisplayParent)
	{
		_itemDisplayParent = itemDisplayParent;
		_displayItems = new List<T1>();
		_dataItems = new List<T2>();
		EnsureOrphanParent();
		PrepareTemplateItem();
	}

	public void Teardown()
	{
		Debug.Log("Torndown table display");
		Object.Destroy(_templateItem);
		foreach (T1 displayItem in _displayItems)
		{
			displayItem.TearDown();
		}
	}

	public void SetItems(List<T2> dataItems)
	{
		Clear();
		foreach (T2 dataItem in dataItems)
		{
			AddItem(dataItem);
		}
	}

	public T1 GetItem(int index)
	{
		if (_displayItems.Count - 1 < index)
		{
			return null;
		}
		return _displayItems[index];
	}

	public void AddItem(T2 dataItem)
	{
		GameObject gameObject = Object.Instantiate(_templateItem, _itemDisplayParent.transform, worldPositionStays: false);
		gameObject.SetActive(value: true);
		T1 val = new T1();
		val.Setup(gameObject, dataItem);
		val.UpdateData();
		_displayItems.Add(val);
		_dataItems.Add(dataItem);
	}

	public void Clear()
	{
		Debug.LogError("Clearing! " + _displayItems.Count);
		if (_displayItems.Count > 0)
		{
			foreach (T1 displayItem in _displayItems)
			{
				Debug.Log("tearin down");
				displayItem.TearDown();
			}
		}
		_displayItems.Clear();
		_dataItems.Clear();
	}

	private void EnsureOrphanParent()
	{
		if (!(_templateItemFosterHome != null))
		{
			_templateItemFosterHome = new GameObject("TemplateItemFosterHome");
			_templateItemFosterHome.SetActive(value: false);
		}
	}

	private void PrepareTemplateItem()
	{
		(_templateItem = _itemDisplayParent.transform.GetChild(0).gameObject).SetActive(value: false);
	}
}
