using System;

public class CurrencyContainer
{
	private int _fazTokens;

	private int _parts;

	private int _essence;

	private int _eventCurrency;

	private int _collectedRemnant;

	public int FazTokens => _fazTokens;

	public int Parts => _parts;

	public int Essence => _essence;

	public int EventCurrency => _eventCurrency;

	public CurrencyContainer()
	{
		_fazTokens = 0;
		_parts = 0;
		_essence = 0;
		_eventCurrency = 0;
	}

	public void SetFazTokens(int amount)
	{
		_fazTokens = amount;
	}

	public void AddFazTokens(int amount)
	{
		_fazTokens += amount;
	}

	public void SpendFazTokens(int amount)
	{
		_fazTokens = Math.Max(0, _fazTokens - amount);
	}

	public void SetParts(int amount)
	{
		_parts = amount;
	}

	public void AddParts(int amount)
	{
		_parts += amount;
	}

	public void SpendParts(int amount)
	{
		_parts = Math.Max(0, _parts - amount);
	}

	public void UpdateEssence(int amount)
	{
		_collectedRemnant = amount;
		_essence = _collectedRemnant;
	}

	public void CollectEssence(int amount)
	{
		_collectedRemnant += amount;
		_essence += amount;
	}

	public void FlushCollectedRemnant()
	{
		_collectedRemnant = 0;
	}

	public void AddEssence(int amount)
	{
		_essence += amount;
	}

	public void SpendEssence(int amount)
	{
		_essence = Math.Max(0, _essence - amount);
	}

	public void SetEventCurrency(int amount)
	{
		_eventCurrency = amount;
	}

	public void AddEventCurrency(int amount)
	{
		_eventCurrency += amount;
	}

	public void SpendEventCurrency(int amount)
	{
		_eventCurrency = Math.Max(0, _eventCurrency - amount);
	}
}
