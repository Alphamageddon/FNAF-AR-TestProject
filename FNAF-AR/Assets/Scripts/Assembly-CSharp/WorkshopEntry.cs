using UnityEngine;

public class WorkshopEntry
{
	public enum Status
	{
		Available = 0,
		Scavenging = 1,
		Sent = 2,
		Returning = 3,
		Attacking = 4,
		ScavengeAppointment = 5,
		LoadScavenging = 6
	}

	public Status status;

	public double lastCommand;

	public string entityId;

	public int health;

	public string appointmentId;

	public EndoskeletonData endoskeleton;

	public int GetWearAndTearPercentage()
	{
		return 100 - health;
	}

	public WorkshopEntry()
	{
	}

	public WorkshopEntry(WorkshopEntry entryToCopy)
	{
		status = entryToCopy.status;
		lastCommand = entryToCopy.lastCommand;
		entityId = entryToCopy.entityId;
		health = entryToCopy.health;
		appointmentId = entryToCopy.appointmentId;
		if (entryToCopy.endoskeleton != null)
		{
			endoskeleton = new EndoskeletonData(entryToCopy.endoskeleton);
		}
	}

	public bool Equals(WorkshopEntry other)
	{
		if (!EqualsExceptForEndoskeleton(other))
		{
			return false;
		}
		if (endoskeleton != null)
		{
			return endoskeleton.Equals(other.endoskeleton);
		}
		return true;
	}

	public bool EqualsExceptForEndoskeleton(WorkshopEntry other)
	{
		if (status != other.status || !Mathf.Approximately((float)lastCommand - (float)other.lastCommand, 0f))
		{
			return false;
		}
		if (entityId != other.entityId || health != other.health)
		{
			return false;
		}
		return appointmentId == other.appointmentId;
	}
}
