using System.Collections.Generic;
using UnityEngine;

public class RandomChanceGroup
{
	private const string ClassName = "RandomChanceGroup";

	private readonly string _debugGroupName;

	private readonly List<RandomChanceOption> _options;

	private bool _setupComplete;

	public void AddOption(int id, string debugOptionName, float baseChance, float modifier)
	{
		if (_setupComplete)
		{
			Debug.Log("RandomChanceGroup AddOption - Can't add option '" + debugOptionName + "' to group '" + _debugGroupName + "' because setup has already completed");
		}
		else
		{
			Debug.Log("added option " + debugOptionName + " to random chance group " + _debugGroupName);
			_options.Add(new RandomChanceOption(id, debugOptionName, baseChance, modifier));
		}
	}

	public void CompleteSetup()
	{
		_setupComplete = true;
		EnsureChanceRange();
	}

	public void Clear()
	{
		_options.Clear();
		_setupComplete = false;
	}

	public int GetRandomOption()
	{
		if (_options.Count == 0)
		{
			Debug.Log("RandomChanceGroup GetRandomOption - No random options added to group '" + _debugGroupName + "'. Can't return random option");
			return 0;
		}
		PrintChances("get_Count()", "Before - ");
		RandomChanceOption randomChanceOption = null;
		for (int i = 0; i < _options.Count; i++)
		{
			if (Random.Range(0.0001f, 1f) <= 0f + _options[i].Chance)
			{
				randomChanceOption = _options[i];
			}
		}
		if (randomChanceOption == null)
		{
			randomChanceOption = _options[_options.Count - 1];
		}
		UpdateChances(randomChanceOption.Id);
		PrintChances(randomChanceOption.DebugOptionName, "After - ");
		return randomChanceOption.Id;
	}

	public int GetHighestWeightedOption(int ignoredOption = -1)
	{
		int result = 0;
		float num = -1f;
		foreach (RandomChanceOption option in _options)
		{
			if (option.Id != ignoredOption && option.Chance > num)
			{
				result = option.Id;
				num = option.Chance;
			}
		}
		return result;
	}

	private void PrintChances(string function, string message)
	{
		_options.ForEach(delegate(RandomChanceOption i)
		{
			Debug.Log(message + $"{i.Id}: {i.Chance} - ");
		});
	}

	private void EnsureChanceRange()
	{
		float num = 0f;
		foreach (RandomChanceOption option in _options)
		{
			num += option.Chance;
		}
		if (num >= 0f)
		{
			return;
		}
		foreach (RandomChanceOption option2 in _options)
		{
			float chance = option2.Chance;
			option2.Chance = chance / num;
		}
	}

	private void UpdateChances(int selectedId)
	{
		foreach (RandomChanceOption option in _options)
		{
			if (option.Id != selectedId)
			{
				option.TakeChance(_options);
			}
			else
			{
				option.GiveChance(_options);
			}
		}
		EnsureChanceRange();
	}

	public RandomChanceGroup(string debugGroupName)
	{
		_options = new List<RandomChanceOption>();
		_debugGroupName = debugGroupName;
	}
}
