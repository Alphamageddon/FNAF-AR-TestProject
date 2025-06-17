using System.Collections.Generic;

public class CustomNightAnimatronic
{
	public enum CustomNightRooms
	{
		Stage = 1,
		DiningArea = 2,
		Kitchen = 3,
		Restrooms = 4,
		Backstage = 5,
		Closet = 6,
		WestHall = 7,
		EastHall = 8,
		WestCorner = 9,
		EastCorner = 10,
		Office = 11,
		PirateCove = 12,
		DiningAreaWest = 13,
		DiningAreaEast = 14,
		PirateCove2 = 15,
		PirateCove3 = 16
	}

	public string Id;

	public string Bundle;

	public string Prefab;

	public string PortraitImageName;

	public int InitialAIValue;

	public bool CanGoKitchen = true;

	public bool CanGoBackstage = true;

	public bool CanGoRestrooms = true;

	public bool CanGoCloset = true;

	public CustomNightRooms originRoom;

	public CustomNightRooms pushbackRoom;

	public bool EastPath;

	public int ThreeAMValueBoost;

	public static Dictionary<CustomNightRooms, List<CustomNightRooms>> possibleRooms;

	public static List<CustomNightRooms> StunLockRooms;

	static CustomNightAnimatronic()
	{
		possibleRooms = new Dictionary<CustomNightRooms, List<CustomNightRooms>>();
		possibleRooms.Add(CustomNightRooms.Stage, new List<CustomNightRooms> { CustomNightRooms.DiningArea });
		possibleRooms.Add(CustomNightRooms.DiningArea, new List<CustomNightRooms>
		{
			CustomNightRooms.DiningAreaWest,
			CustomNightRooms.DiningAreaEast
		});
		possibleRooms.Add(CustomNightRooms.DiningAreaWest, new List<CustomNightRooms>
		{
			CustomNightRooms.Backstage,
			CustomNightRooms.WestHall
		});
		possibleRooms.Add(CustomNightRooms.DiningAreaEast, new List<CustomNightRooms>
		{
			CustomNightRooms.Restrooms,
			CustomNightRooms.Kitchen,
			CustomNightRooms.EastHall
		});
		possibleRooms.Add(CustomNightRooms.Backstage, new List<CustomNightRooms> { CustomNightRooms.DiningAreaWest });
		possibleRooms.Add(CustomNightRooms.Restrooms, new List<CustomNightRooms> { CustomNightRooms.DiningAreaEast });
		possibleRooms.Add(CustomNightRooms.Kitchen, new List<CustomNightRooms> { CustomNightRooms.DiningAreaEast });
		possibleRooms.Add(CustomNightRooms.WestHall, new List<CustomNightRooms>
		{
			CustomNightRooms.Closet,
			CustomNightRooms.WestCorner
		});
		possibleRooms.Add(CustomNightRooms.EastHall, new List<CustomNightRooms> { CustomNightRooms.EastCorner });
		possibleRooms.Add(CustomNightRooms.Closet, new List<CustomNightRooms> { CustomNightRooms.WestHall });
		possibleRooms.Add(CustomNightRooms.WestCorner, new List<CustomNightRooms> { CustomNightRooms.Office });
		possibleRooms.Add(CustomNightRooms.EastCorner, new List<CustomNightRooms> { CustomNightRooms.Office });
		possibleRooms.Add(CustomNightRooms.PirateCove, new List<CustomNightRooms> { CustomNightRooms.PirateCove2 });
		possibleRooms.Add(CustomNightRooms.PirateCove2, new List<CustomNightRooms> { CustomNightRooms.PirateCove3 });
		possibleRooms.Add(CustomNightRooms.PirateCove3, new List<CustomNightRooms> { CustomNightRooms.WestHall });
		StunLockRooms = new List<CustomNightRooms>();
		StunLockRooms.Add(CustomNightRooms.EastCorner);
		StunLockRooms.Add(CustomNightRooms.PirateCove);
		StunLockRooms.Add(CustomNightRooms.PirateCove2);
		StunLockRooms.Add(CustomNightRooms.PirateCove3);
	}
}
