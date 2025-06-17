using System.Collections.Generic;
using UnityEngine;

public class GatherModsForEquipping
{
	public class ModContext
	{
		public ModData Mod;

		public bool modEquippable;

		public bool modSellable;

		public bool isEquipped;

		public int quantity = 1;

		public ModContext()
		{
			quantity = 1;
		}

		public ModContext(ModContext contextToCopy)
		{
			quantity = 1;
			if (contextToCopy != null)
			{
				Mod = contextToCopy.Mod;
				modEquippable = contextToCopy.modEquippable;
				modSellable = contextToCopy.modSellable;
				isEquipped = contextToCopy.isEquipped;
				quantity = contextToCopy.quantity;
			}
			else
			{
				Mod = null;
				modEquippable = false;
				modSellable = false;
				isEquipped = false;
			}
		}
	}

	public class GatherMods
	{
		private ItemDefinitions _itemDefinitions;

		private Inventory _inventory;

		public GatherMods()
		{
			MasterDomain domain = MasterDomain.GetDomain();
			_itemDefinitions = domain.ItemDefinitionDomain.ItemDefinitions;
			_inventory = domain.WorkshopDomain.Inventory;
		}

		private bool HasSameCategoryEquippedOnOtherSlot(List<string> mods, int selectedModSlotIndex, ModCategory modCategory)
		{
			foreach (string mod in mods)
			{
				if (mods.IndexOf(mod) != selectedModSlotIndex && _itemDefinitions.GetModById(mod) != null && _itemDefinitions.GetModById(mod).Category == modCategory)
				{
					return true;
				}
			}
			return false;
		}

		private List<ModContext> GetModsFromInventory(List<string> mods, int selectedModSlotIndex)
		{
			List<ModContext> list = new List<ModContext>();
			foreach (ModData key in _inventory.ModInventory.GetMods().Keys)
			{
				ModContext modContext = new ModContext();
				modContext.Mod = _itemDefinitions.GetModById(key.Id);
				modContext.quantity = _inventory.ModInventory.GetMods()[key];
				modContext.modSellable = true;
				modContext.modEquippable = !HasSameCategoryEquippedOnOtherSlot(mods, selectedModSlotIndex, modContext.Mod.Category);
				if (modContext.quantity >= 1)
				{
					list.Add(modContext);
				}
			}
			return list;
		}

		private void AddCurrentlyEquippedModFromThisSlot(WorkshopSlotData currentSlot, int selectedModSlotIndex, List<ModContext> ret)
		{
			string val_9 = currentSlot.endoskeleton.GetModAtIndex(selectedModSlotIndex);
			if (string.IsNullOrEmpty(val_9))
			{
				return;
			}
			ModContext modContext = ret.Find((ModContext x) => x.Mod.Id == val_9);
			if (modContext != null)
			{
				modContext.isEquipped = true;
				Debug.Log("Adding 1 to quantity for mod. Quantity before is: " + modContext.quantity);
				modContext.quantity++;
				return;
			}
			ModData modById = _itemDefinitions.GetModById(val_9);
			if (modById != null)
			{
				ModContext modContext2 = new ModContext();
				modContext2.Mod = modById;
				modContext2.isEquipped = true;
				modContext2.modEquippable = true;
				modContext2.modSellable = true;
				ret.Add(modContext2);
			}
		}

		public List<ModContext> GatherAllModsForSlot(WorkshopSlotData currentSlot, int selectedModSlotIndex, List<WorkshopSlotData> slots)
		{
			List<ModContext> list = new List<ModContext>();
			EndoskeletonData endoskeleton = currentSlot.endoskeleton;
			list.AddRange(GetModsFromInventory(endoskeleton.mods, selectedModSlotIndex));
			AddCurrentlyEquippedModFromThisSlot(currentSlot, selectedModSlotIndex, list);
			return list;
		}
	}
}
