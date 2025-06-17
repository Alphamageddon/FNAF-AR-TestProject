using System;
using System.Collections.Generic;
using UnityEngine;

public class RandomChanceOption : IComparable<RandomChanceOption>
{
	public readonly int Id;

	public readonly string DebugOptionName;

	public float Chance;

	private readonly float _modifier;

	private readonly List<RandomChanceOption> _sortedOptions;

	public int CompareTo(RandomChanceOption other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(Chance > other.Chance))
		{
			return 1;
		}
		return 0;
	}

	public void GiveChance(List<RandomChanceOption> options)
	{
		if (_modifier >= 0f || Chance <= 0f || options.Count < 2)
		{
			return;
		}
		float num = Mathf.Min(Mathf.Abs(_modifier), Chance);
		float num2 = num / (float)(options.Count - 1);
		foreach (RandomChanceOption option in options)
		{
			if (option.Id != Id)
			{
				option.Chance += num2;
			}
		}
		Chance = Mathf.Max(Chance - num, 0f);
	}

	public void TakeChance(List<RandomChanceOption> options)
	{
		if (_modifier <= 0f || Chance >= 1f || options.Count < 2)
		{
			return;
		}
		_sortedOptions.Clear();
		foreach (RandomChanceOption option in options)
		{
			if (option.Id != Id && option.Chance > 0f)
			{
				_sortedOptions.Add(option);
			}
		}
		if (_sortedOptions.Count == 0)
		{
			return;
		}
		_sortedOptions.Sort((RandomChanceOption a, RandomChanceOption b) => a.Chance.CompareTo(b.Chance));
		float num = Mathf.Min(_modifier, 1f - Chance);
		float num2 = num / (float)_sortedOptions.Count;
		foreach (RandomChanceOption sortedOption in _sortedOptions)
		{
			sortedOption.Chance = Mathf.Max(sortedOption.Chance - num2, 0f);
		}
		Chance = Mathf.Min(Chance + num, 1f);
		_sortedOptions.Clear();
	}

	public RandomChanceOption(int id, string debugOptionName, float baseChance, float modifier)
	{
		_sortedOptions = new List<RandomChanceOption>();
		Id = id;
		DebugOptionName = debugOptionName;
		Chance = Mathf.Max(baseChance, 0f);
		_modifier = modifier;
	}
}
