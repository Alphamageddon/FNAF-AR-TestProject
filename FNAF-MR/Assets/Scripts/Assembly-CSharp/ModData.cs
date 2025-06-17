using System;
using System.Collections.Generic;

public class ModData
{
	private const string CAPITAL_LETTERS_AFTER_FIRST = "(?<!^)[A-Z]";

	private const string SPACE_PLUS_LETTER = " $0";

	public string Id;

	public string Name;

	public string Description;

	public ModType Type;

	public ModCategory Category;

	public string CategoryString;

	public string CategoryStringLocalized;

	public List<ModEffect> Effects;

	public double BreakageChance;

	public double DropWeight;

	public double PartsBuyback;

	public string ModIconName;

	public string ModIconRenderedName;

	public string ModIconRewardName;

	public int Stars;

	public ModData(string id)
	{
		Id = id;
	}

	public ModData(MODS_DATA.Entry entry)
	{
		ModData modData = this;
		Id = entry.ModLogical;
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(delegate(Localization localization)
		{
			modData.Name = localization.GetLocalizedString(entry.ModName, entry.ModName);
			modData.Description = localization.GetLocalizedString(entry.ModDesc, entry.ModDesc);
		});
		Type = GetTypeForString(entry.ModType);
		CategoryString = entry.Effects.EffectCategory;
		Category = GetCategoryForString(entry.Effects.EffectCategory);
		GetModNameLocalized(Category);
		Effects = new List<ModEffect>();
		ModEffect modEffect = CreateModEffect(entry.Effects.EffectType_1, entry.Effects.EffectMag_1);
		if (modEffect != null)
		{
			Effects.Add(modEffect);
		}
		ModEffect modEffect2 = CreateModEffect(entry.Effects.EffectType_2, entry.Effects.EffectMag_2);
		if (modEffect2 != null)
		{
			Effects.Add(modEffect2);
		}
		ModEffect modEffect3 = CreateModEffect(entry.Effects.EffectType_3, entry.Effects.EffectMag_3);
		if (modEffect3 != null)
		{
			Effects.Add(modEffect3);
		}
		ModEffect modEffect4 = CreateModEffect(entry.Effects.EffectType_4, entry.Effects.EffectMag_4);
		if (modEffect4 != null)
		{
			Effects.Add(modEffect4);
		}
		BreakageChance = entry.BreakageChance;
		DropWeight = entry.DropWeight;
		PartsBuyback = entry.PartsBuyback;
		if (entry.ArtAssets.ModIcon != null)
		{
			ModIconName = entry.ArtAssets.ModIcon;
		}
		else
		{
			ModIconName = "";
		}
		if (entry.ArtAssets.ModIconRendered != null)
		{
			ModIconRenderedName = entry.ArtAssets.ModIconRendered;
		}
		else
		{
			ModIconRenderedName = "";
		}
		if (entry.ArtAssets.ModIconReward != null)
		{
			ModIconRewardName = entry.ArtAssets.ModIconReward;
		}
		else
		{
			ModIconRewardName = "";
		}
		Stars = entry.Stars;
	}

	public void Copy(ModData copy)
	{
		Name = copy.Name;
		Description = copy.Description;
		Type = copy.Type;
		Category = copy.Category;
		Effects = new List<ModEffect>();
		foreach (ModEffect effect in copy.Effects)
		{
			Effects.Add(effect);
		}
		BreakageChance = copy.BreakageChance;
		DropWeight = copy.DropWeight;
		PartsBuyback = copy.PartsBuyback;
		Stars = copy.Stars;
	}

	private void GetModNameLocalized(ModCategory category)
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(delegate(Localization localization)
		{
			CategoryStringLocalized = localization.GetLocalizedString("mod_category_name_" + category, "mod_category_name_" + category);
		});
	}

	private ModEffect CreateModEffect(string type, double magnitude)
	{
		if (string.IsNullOrEmpty(type))
		{
			return null;
		}
		return new ModEffect(type, (float)magnitude);
	}

	private ModType GetTypeForString(string type)
	{
		return (ModType)Enum.Parse(typeof(ModType), type);
	}

	private ModCategory GetCategoryForString(string category)
	{
		return (ModCategory)Enum.Parse(typeof(ModCategory), category);
	}
}
