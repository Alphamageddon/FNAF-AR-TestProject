using System;
using System.Collections.Generic;

public class MapEntityResponseHandler : EventResponseHandler
{
	private Func<ServerData, MapEntitySynchronizeableState> loader;

	private Action<List<MapEntitySynchronizeableState>> playerMapEntityDataLoaded;

	public void Setup(Func<ServerData, MapEntitySynchronizeableState> entityLoader, Action<List<MapEntitySynchronizeableState>> callback)
	{
		loader = entityLoader;
		playerMapEntityDataLoaded = callback;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("Reports") != null)
		{
			HandleResponse(data.GetServerData("Reports"));
		}
	}

	private void HandleResponse(ServerData data)
	{
		playerMapEntityDataLoaded(ConstructMapEntities(data));
	}

	private List<MapEntitySynchronizeableState> ConstructMapEntities(ServerData data)
	{
		List<MapEntitySynchronizeableState> list = new List<MapEntitySynchronizeableState>();
		foreach (string key in data.Keys)
		{
			list.Add(loader(data.GetServerData(key.ToString())));
		}
		return list;
	}
}
