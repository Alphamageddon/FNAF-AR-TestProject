using System;

public class StreakDataResponseHandler : EventResponseHandler
{
	private Action<StreakData> StreakUpdated;

	public void Setup(EventExposer eventExposer)
	{
		StreakUpdated = eventExposer.OnStreakDataUpdated;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("StreakData") != null)
		{
			HandleResponse(data.GetServerData("StreakData"));
		}
	}

	private void HandleResponse(ServerData data)
	{
		StreakData streakData = new StreakData();
		streakData.currentStreak = data.GetInt("CurrentStreak").Value;
		streakData.bestStreak = data.GetInt("BestStreak").Value;
		streakData.wins = data.GetInt("Wins").Value;
		streakData.encounters = data.GetInt("Encounters").Value;
		StreakUpdated(streakData);
	}
}
