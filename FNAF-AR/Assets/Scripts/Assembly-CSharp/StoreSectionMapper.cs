public class StoreSectionMapper
{
	public enum StoreSectionType
	{
		None = 0,
		Pack = 1,
		FazCoins = 2,
		Device = 3,
		EndoskeletonSlot = 4,
		MiniPack = 5,
		Lure = 6,
		Buff = 7,
		BuffItem = 8
	}

	public const string STORE_SECTION_NONE = "None";

	public const string STORE_SECTION_PACK = "Pack";

	public const string STORE_SECTION_FAZCOINS = "FazCoins";

	public const string STORE_SECTION_DEVICE = "Device";

	public const string STORE_SECTION_ENDOSKELETON = "EndoskeletonSlot";

	public const string STORE_SECTION_MINIPACK = "MiniPack";

	public const string STORE_SECTION_LURE = "Lure";

	public const string STORE_SECTION_BUFF = "Buff";

	public const string STORE_SECTION_BUFFITETM = "BuffItem";

	public static string GetStringForType(StoreSectionType type)
	{
		return type switch
		{
			StoreSectionType.None => "None", 
			StoreSectionType.Pack => "Pack", 
			StoreSectionType.FazCoins => "FazCoins", 
			StoreSectionType.Device => "Device", 
			StoreSectionType.EndoskeletonSlot => "EndoskeletonSlot", 
			StoreSectionType.MiniPack => "MiniPack", 
			StoreSectionType.Lure => "Lure", 
			StoreSectionType.Buff => "Buff", 
			StoreSectionType.BuffItem => "BuffItem", 
			_ => "None", 
		};
	}

	public static StoreSectionType GetTypeForString(string typeString)
	{
		return typeString switch
		{
			"None" => StoreSectionType.None, 
			"Pack" => StoreSectionType.Pack, 
			"FazCoins" => StoreSectionType.FazCoins, 
			"Device" => StoreSectionType.Device, 
			"EndoskeletonSlot" => StoreSectionType.EndoskeletonSlot, 
			"MiniPack" => StoreSectionType.MiniPack, 
			"Lure" => StoreSectionType.Lure, 
			"Buff" => StoreSectionType.Buff, 
			"BuffItem" => StoreSectionType.BuffItem, 
			_ => StoreSectionType.None, 
		};
	}
}
