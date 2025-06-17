using System;
using System.Collections.Generic;
using UnityEngine;

public class MultiAnimatronic
{
	private static string Wildcard = "*";

	public readonly SelectionType SelectionType;

	private readonly string _id;

	private readonly string[] _cpuIds;

	private readonly string[] _plushsuitIds;

	private readonly int _count;

	private readonly bool _includeCurrentCPU;

	public MultiAnimatronic(string id, CPU_DATA.MultiAnimatronicConfig rawSettings)
	{
		SelectionType = (SelectionType)Enum.Parse(typeof(SelectionType), rawSettings.SelectionType);
		_id = id;
		if (rawSettings.CpuIds != null)
		{
			_cpuIds = rawSettings.CpuIds.Split(',');
		}
		if (rawSettings.PlushsuitIds != null)
		{
			_plushsuitIds = rawSettings.PlushsuitIds.Split(',');
		}
		_count = rawSettings.SelectionCount;
		_includeCurrentCPU = !(rawSettings.IncludeCurrentCpu == "No");
	}

	public string[] GenerateCpuIds()
	{
		if (SelectionType == SelectionType.Sequential)
		{
			return GenerateSequentialCpuIds();
		}
		if (SelectionType != SelectionType.Random)
		{
			return new string[0];
		}
		return RollRandomCpuIds();
	}

	private string[] RollRandomCpuIds()
	{
		List<string> list = new List<string>(_cpuIds);
		if (_includeCurrentCPU)
		{
			list.Add(_id);
		}
		List<string> list2 = new List<string>();
		if (list.Count == 0)
		{
			return list2.ToArray();
		}
		while (list2.Count < _count)
		{
			int index = UnityEngine.Random.Range(0, list.Count);
			list2.Add(list[index]);
			list.RemoveAt(index);
		}
		return list2.ToArray();
	}

	private string[] GenerateSequentialCpuIds()
	{
		if (!_includeCurrentCPU)
		{
			return _cpuIds;
		}
		List<string> list = new List<string>();
		list.Add(_id);
		list.AddRange(_cpuIds);
		return list.ToArray();
	}

	public string[] GeneratePlushsuitIds(string serverPlushsuit)
	{
		List<string> list = new List<string>();
		if (_includeCurrentCPU)
		{
			list.Add(serverPlushsuit);
		}
		if (_count - list.Count < 1)
		{
			return list.ToArray();
		}
		int num = 0;
		while (list.Count < _count)
		{
			string item = ((_plushsuitIds != null && num < _plushsuitIds.Length) ? ((!(_plushsuitIds[num] != Wildcard)) ? serverPlushsuit : _plushsuitIds[num]) : serverPlushsuit);
			list.Add(item);
			num++;
		}
		return list.ToArray();
	}
}
