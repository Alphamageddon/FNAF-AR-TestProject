using System;
using System.Collections.Generic;

public class WorkshopDataV2ResponseHandler : EventResponseHandler
{
	private Action<WorkshopData> WorkshopDataV2Updated;

	private Func<ServerData, WorkshopEntry> ProcessWorkshopDataEntry;

	public void Setup(Action<WorkshopData> callback, Func<ServerData, WorkshopEntry> processor)
	{
		WorkshopDataV2Updated = callback;
		ProcessWorkshopDataEntry = processor;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerDataList("WarehouseDataV2") != null)
		{
			HandleResponse(data.GetServerDataList("WarehouseDataV2"));
		}
	}

	private void HandleResponse(List<ServerData> data)
	{
		WorkshopData workshopData = new WorkshopData();
		foreach (ServerData datum in data)
		{
			workshopData.Add(ProcessWorkshopDataEntry(datum));
		}
		WorkshopDataV2Updated(workshopData);
	}
}
