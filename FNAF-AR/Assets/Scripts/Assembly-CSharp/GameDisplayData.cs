using System;

[Serializable]
public class GameDisplayData
{
	[Serializable]
	public enum DisplayType
	{
		none = -1,
		map = 0,
		camera = 1,
		workshop = 2,
		store = 3,
		inbox = 4,
		subcanvas = 5,
		splash = 6,
		results = 7,
		proto = 8,
		photoBooth = 9,
		firstEncounter = 10,
		mrEnvironment = 11,
		dialogStart = 12,
		dialogSequentialRewards = 12,
		dialogMapAnimatronic = 13,
		dialogMapRemnant = 14,
		dialogDailyChallenge = 15,
		dialogLootReward = 16,
		dialogHandlerResults = 17,
		dialogEpisodicSplash = 18,
		dialogEnd = 17,
		childLoadoutDrawer = 19,
		scavengingui = 20
	}

	public DisplayType currentDisplay { get; set; }

	public DisplayType previousDisplay { get; set; }

	public GameDisplayData()
	{
	}

	public GameDisplayData(GameDisplayData state)
	{
		previousDisplay = state.previousDisplay;
	}

	public GameDisplayData(DisplayType mode)
	{
		currentDisplay = mode;
		previousDisplay = mode;
	}

	public static bool IsDisplayTypeDialog(DisplayType displayType)
	{
		return displayType - 12 < DisplayType.splash;
	}
}
