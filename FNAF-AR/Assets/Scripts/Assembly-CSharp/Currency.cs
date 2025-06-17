using UnityEngine;

public class Currency
{
	public enum CurrencyType
	{
		HardCurrency = 0,
		Parts = 1,
		Essence = 2,
		RealMoney = 3,
		EventCurrency = 4
	}

	public const string FAZ_TOKEN = "FAZ_TOKENS";

	public const string PARTS = "PARTS";

	public const string ESSENCE = "ESSENCE";

	public const string REALMONEY = "REAL_MONEY";

	public const string EVENT_CURRENCY = "EVENT_CURRENCY";

	public const string PF_FAZ_TOKEN = "FC";

	public const string PF_PARTS = "PA";

	public const string PF_ESSENCE = "RE";

	public const string PF_REALMONEY = "RM";

	public const string PF_EVENT_CURRENCY = "EC";

	public static string GetCurrencyString(CurrencyType type)
	{
		return GetPFCurrencyString(type);
	}

	private static string GetPFCurrencyString(CurrencyType type)
	{
		return type switch
		{
			CurrencyType.HardCurrency => "FC", 
			CurrencyType.Parts => "PA", 
			CurrencyType.Essence => "RE", 
			CurrencyType.RealMoney => "RM", 
			CurrencyType.EventCurrency => "EC", 
			_ => "", 
		};
	}

	public static CurrencyType GetTypeForString(string currencyString)
	{
		switch (currencyString)
		{
		case "FAZ_TOKENS":
			return CurrencyType.HardCurrency;
		case "FC":
			return CurrencyType.HardCurrency;
		case "PARTS":
			return CurrencyType.Parts;
		case "PA":
			return CurrencyType.Parts;
		case "ESSENCE":
			return CurrencyType.Essence;
		case "RE":
			return CurrencyType.Essence;
		case "REAL_MONEY":
			return CurrencyType.RealMoney;
		case "RM":
			return CurrencyType.RealMoney;
		case "EVENT_CURRENCY":
			return CurrencyType.EventCurrency;
		case "EC":
			return CurrencyType.EventCurrency;
		default:
			Debug.LogError("Currency GetTypeForString - No currency corresponding to " + currencyString);
			return CurrencyType.HardCurrency;
		}
	}
}
