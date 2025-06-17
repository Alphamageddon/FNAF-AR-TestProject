using System;
using System.Collections.Generic;
using UnityEngine;

public class WorkshopSlotData
{
	public Sprite sprite;

	private Action<Sprite> _iconUpdated;

	private IconLookup _iconLookup;

	private ItemDefinitions _itemDefinitions;

	private string _plushtrapCpuId = "Plushtrap";

	private List<string> _plushtrapPlushsuitIds;

	public bool isDirty { get; set; }

	public bool isSaving { get; set; }

	public WorkshopEntry workshopEntry { get; set; }

	public EndoskeletonData endoskeleton { get; private set; }

	public Action<Sprite> IconUpdated
	{
		get
		{
			return _iconUpdated;
		}
		set
		{
			_iconUpdated = value;
			if (sprite != null && _iconUpdated != null)
			{
				_iconUpdated(sprite);
			}
		}
	}

	public void SetIconLookup(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
		SetIcon();
	}

	public void SetItemDefinitions(ItemDefinitions itemDefinitions)
	{
		_itemDefinitions = itemDefinitions;
		SetIcon();
	}

	public void UpdateIsDirty()
	{
		isDirty = endoskeleton != workshopEntry.endoskeleton;
	}

	public void UpdateServerWorkshopEntry(WorkshopEntry entry)
	{
		if (workshopEntry == null)
		{
			Initialize(entry);
			SetIcon();
		}
		else if (entry != workshopEntry)
		{
			if (isSaving)
			{
				UpdateSaving(entry);
			}
			if (isDirty)
			{
				UpdateDirty(entry);
			}
			else
			{
				UpdateClean(entry);
			}
			UpdateIsDirty();
			SetIcon();
		}
	}

	public void UpdateIcon()
	{
		SetIcon();
	}

	public void Save()
	{
		isSaving = true;
	}

	public bool ValidatePlushtrapCpu(string cpuDataId, string plushsuitId)
	{
		if (_plushtrapPlushsuitIds == null)
		{
			_plushtrapPlushsuitIds = _itemDefinitions.GetPlushSuitIdsByCategory(_plushtrapCpuId);
		}
		if (cpuDataId != _plushtrapCpuId)
		{
			return true;
		}
		return _plushtrapPlushsuitIds.Contains(plushsuitId);
	}

	private void Initialize(WorkshopEntry entry)
	{
		SaveEntry(entry);
		OverwriteClientEndoskeleton(workshopEntry.endoskeleton);
	}

	private void SaveEntry(WorkshopEntry entry)
	{
		Debug.Log("Saving entry");
		workshopEntry = new WorkshopEntry(entry);
	}

	private void OverwriteClientEndoskeleton(EndoskeletonData endoskeleton)
	{
		Debug.Log("overwriting skeleton");
		this.endoskeleton = new EndoskeletonData(endoskeleton);
	}

	private void UpdateClean(WorkshopEntry entry)
	{
		if (!entry.endoskeleton.Equals(workshopEntry.endoskeleton))
		{
			Debug.LogError("WorkshopSlotData UpdateClean - Endoskeleton changed unexpectedly while there are no unsaved changes. Using server version");
		}
		Initialize(entry);
	}

	private void UpdateDirty(WorkshopEntry entry)
	{
		if (!entry.endoskeleton.Equals(workshopEntry.endoskeleton))
		{
			Debug.LogError("WorkshopSlotData UpdateDirty - Endoskeleton changed unexpectedly while there are unsaved changes. Using client version");
		}
		if (!entry.EqualsExceptForEndoskeleton(workshopEntry))
		{
			SaveEntry(entry);
		}
	}

	private void UpdateSaving(WorkshopEntry entry)
	{
		if (!entry.endoskeleton.Equals(endoskeleton))
		{
			Debug.LogError("WorkshopSlotData UpdateSaving - Endoskeleton change did not match unsaved changes. Using server version");
		}
		if (!entry.EqualsExceptForEndoskeleton(workshopEntry))
		{
			Initialize(entry);
			isSaving = false;
		}
	}

	private void SetIcon()
	{
		if (_iconLookup == null || _itemDefinitions == null || workshopEntry == null || endoskeleton == null)
		{
			return;
		}
		PlushSuitData plushSuitById = _itemDefinitions.GetPlushSuitById(endoskeleton.plushSuit);
		if (plushSuitById != null && plushSuitById.PortraitIconName != null)
		{
			if (!(sprite != null) || !(sprite.name == plushSuitById.PortraitIconName))
			{
				_iconLookup.GetIcon(IconGroup.Portrait, plushSuitById.PortraitIconName, CacheAndNotifyIcon);
			}
		}
		else
		{
			Debug.LogError("PlushSuit Data is null for id " + endoskeleton.plushSuit);
		}
	}

	private void CacheAndNotifyIcon(Sprite s)
	{
		sprite = s;
		if (_iconUpdated != null)
		{
			_iconUpdated(s);
		}
	}
}
