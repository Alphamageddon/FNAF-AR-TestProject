using System;
using System.Collections.Generic;

public class PlayerGoodsResponseHandler : EventResponseHandler
{
	private Action<Dictionary<string, int>> PlayerGoodsUpdated;

	private Func<List<ServerData>, Dictionary<string, int>> ProcessPlayerGoods;

	public void Setup(Action<Dictionary<string, int>> callback, Func<List<ServerData>, Dictionary<string, int>> processor)
	{
		PlayerGoodsUpdated = callback;
		ProcessPlayerGoods = processor;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerDataList("Goods") != null)
		{
			HandleResponse(data.GetServerDataList("Goods"));
		}
	}

	private void HandleResponse(List<ServerData> data)
	{
		if (PlayerGoodsUpdated != null)
		{
			PlayerGoodsUpdated(ProcessPlayerGoods(data));
		}
	}
}
