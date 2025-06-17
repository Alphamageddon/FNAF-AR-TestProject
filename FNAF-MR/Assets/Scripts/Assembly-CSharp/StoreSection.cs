using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreSection : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI TitleText;

	public Transform SectionContents;

	public StoreSectionData.DisplayType Type;

	private Dictionary<string, StoreCell> _cells;

	public void SetData(StoreSectionData data, StoreDomain storeDomain)
	{
		Type = data.Type;
		TitleText.text = data.DisplayName;
		_cells = new Dictionary<string, StoreCell>();
	}

	public void AddItem(string id, StoreCell cell)
	{
		cell.transform.SetParent(SectionContents, worldPositionStays: false);
		if (!base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(value: true);
		}
		_cells.Add(id, cell);
	}

	public void Reset()
	{
		foreach (StoreCell value in _cells.Values)
		{
			Object.Destroy(value.gameObject);
		}
		_cells.Clear();
		base.gameObject.SetActive(value: false);
	}

	public RectTransform GetRectTransform()
	{
		return GetComponent<RectTransform>();
	}

	public StoreCell GetCell(string itemId)
	{
		if (_cells.ContainsKey(itemId))
		{
			return _cells[itemId];
		}
		return null;
	}
}
