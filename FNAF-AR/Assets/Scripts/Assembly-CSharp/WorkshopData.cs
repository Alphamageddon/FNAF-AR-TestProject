using System.Collections.Generic;

public class WorkshopData
{
	private List<WorkshopEntry> entries;

	public List<WorkshopEntry> Entries => entries;

	public WorkshopData()
	{
		entries = new List<WorkshopEntry>();
	}

	public void Add(WorkshopEntry entry)
	{
		entries.Add(entry);
	}

	public int GetNumSlots()
	{
		return entries.Count;
	}

	public int GetNextAvailableEntrySlot()
	{
		if (entries.Count >= 1)
		{
			for (int i = 0; i < GetNumSlots(); i++)
			{
				WorkshopEntry workshopEntry = entries[i];
				if (workshopEntry.health >= 1 && workshopEntry.status == WorkshopEntry.Status.Available)
				{
					return i;
				}
			}
		}
		return 0;
	}

	public string GetNextScavengingEntityId()
	{
		if (entries.Count < 1)
		{
			return string.Empty;
		}
		for (int i = 0; i < entries.Count; i++)
		{
			WorkshopEntry workshopEntry = entries[i];
			if (workshopEntry.status == WorkshopEntry.Status.Scavenging || workshopEntry.status == WorkshopEntry.Status.ScavengeAppointment)
			{
				return workshopEntry.entityId;
			}
		}
		return string.Empty;
	}

	public bool ShouldRepair()
	{
		foreach (WorkshopEntry entry in entries)
		{
			if (entry.health < 100)
			{
				return true;
			}
		}
		return false;
	}
}
