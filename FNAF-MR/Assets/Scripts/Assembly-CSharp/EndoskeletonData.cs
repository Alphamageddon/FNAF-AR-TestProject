using System.Collections.Generic;

public class EndoskeletonData
{
	public string cpu;

	public string plushSuit;

	public int numEssence;

	public List<string> mods;

	public EndoskeletonData()
	{
		cpu = "";
		plushSuit = "";
		mods = new List<string>();
	}

	public EndoskeletonData(EndoskeletonData data)
	{
		mods = new List<string>();
		cpu = data.cpu;
		plushSuit = data.plushSuit;
		numEssence = data.numEssence;
		EnsureModsUpToIndex(data.mods.Count - 1);
		for (int i = 0; i < data.mods.Count; i++)
		{
			mods[i] = data.mods[i];
		}
	}

	public bool Equals(EndoskeletonData other)
	{
		if (!cpu.Equals(other.cpu))
		{
			return false;
		}
		if (!plushSuit.Equals(other.plushSuit))
		{
			return false;
		}
		if (!numEssence.Equals(other.numEssence))
		{
			return false;
		}
		return AreModsEqual(other.mods);
	}

	private bool AreModsEqual(IReadOnlyList<string> other)
	{
		if (mods.Count != other.Count)
		{
			return false;
		}
		for (int i = 0; i < mods.Count; i++)
		{
			if (!mods[i].Equals(other[i]))
			{
				return false;
			}
		}
		return true;
	}

	private void EnsureModsUpToIndex(int index)
	{
		if (mods.Count < index + 1)
		{
			int num = index + 1 - mods.Count;
			do
			{
				mods.Add("");
				num--;
			}
			while (num != 0);
		}
	}

	public override string ToString()
	{
		return $"{{\"cpu\":\"{cpu}\",\"plushSuit\":\"{plushSuit}\",\"numEssence\":{numEssence},\"mods\":{PrintMods()}}}";
	}

	private string PrintMods()
	{
		string text = "[";
		foreach (string mod in mods)
		{
			text = text + mod + ",";
		}
		return text + "]";
	}

	public void SetModAtIndex(string modId, int index)
	{
		EnsureModsUpToIndex(index);
		mods[index] = modId;
	}

	public string GetModAtIndex(int index)
	{
		if (mods.Count <= index)
		{
			return "";
		}
		return mods[index];
	}
}
