using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GatherModsForEquipping.GatherMods
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Workshop.Inventory _inventory;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GatherModsForEquipping.GatherMods(Master.MasterDomain masterDomain)
    {
        this._itemDefinitions = masterDomain.ItemDefinitionDomain.ItemDefinitions;
        this._inventory = masterDomain.WorkshopDomain.Inventory;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool HasSameCategoryEquippedOnOtherSlot(System.Collections.Generic.List<string> mods, int selectedModSlotIndex, Game.ItemDefinition.Data.DataDefinitions.ModCategory modCategory)
    {
        string val_8;
        var val_9;
        var val_10;
        val_9 = modCategory;
        List.Enumerator<T> val_1 = mods.GetEnumerator();
        label_7:
        if(((-1107264104) & 1) == 0)
        {
            goto label_2;
        }
        
        val_8 = 0.emailUIDataHandler;
        if(((mods.IndexOf(item:  val_8)) == selectedModSlotIndex) || (((this._itemDefinitions.GetModById(id:  val_8)) == null) || (val_4.Category != val_9)))
        {
            goto label_7;
        }
        
        long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524974419352});
        val_10 = 1;
        return (bool)val_10;
        label_2:
        long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524974419352});
        val_10 = 0;
        return (bool)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<GameUI.Actions.GatherModsForEquipping.ModContext> GetModsFromInventory(System.Collections.Generic.List<string> mods, int selectedModSlotIndex)
    {
        var val_7;
        System.Collections.Generic.List<ModContext> val_1 = new System.Collections.Generic.List<ModContext>();
        Dictionary.Enumerator<TKey, TValue> val_4 = this._inventory.ModInventory.GetMods().GetEnumerator();
        label_9:
        if(((-1107075328) & 1) == 0)
        {
                return val_1;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_8 = val_7.trackableId;
        .quantity = 1;
        new GatherModsForEquipping.ModContext() = new System.Object();
        ulong val_10 = val_8.m_SubId1.System.IConvertible.ToUInt64(provider:  public Game.ItemDefinition.Data.DataDefinitions.ModData System.Collections.Generic.KeyValuePair<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>::get_Key());
        .Mod = this._itemDefinitions.GetModById(id:  val_10 + 16);
        .quantity = val_8.m_SubId1;
        .modSellable = 1;
        bool val_15 = ~(this.HasSameCategoryEquippedOnOtherSlot(mods:  mods, selectedModSlotIndex:  selectedModSlotIndex, modCategory:  (GatherModsForEquipping.ModContext)[1152921524974672752].Mod.Category));
        val_15 = val_15 & 1;
        .modEquippable = val_15;
        val_1.Add(item:  new GatherModsForEquipping.ModContext());
        goto label_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddCurrentlyEquippedModFromThisSlot(GameUI.WorkshopSlotData currentSlot, int selectedModSlotIndex, System.Collections.Generic.List<GameUI.Actions.GatherModsForEquipping.ModContext> ret)
    {
        string val_9;
        string val_10;
        Game.ItemDefinition.Data.DataDefinitions.ModData val_11;
        GatherModsForEquipping.GatherMods.<>c__DisplayClass5_0 val_1 = new GatherModsForEquipping.GatherMods.<>c__DisplayClass5_0();
        GatherModsForEquipping.ModContext val_2 = null;
        .quantity = 1;
        val_2 = new GatherModsForEquipping.ModContext();
        val_9 = currentSlot.ClientEndoskeleton.GetModAtIndex(index:  selectedModSlotIndex);
        if(val_1 != null)
        {
                val_10 = val_1;
            .modId = val_9;
        }
        else
        {
                val_10 = 16;
            mem[16] = val_9;
            val_9 = mem[16];
        }
        
        if((System.String.IsNullOrEmpty(value:  val_9)) == true)
        {
                return;
        }
        
        System.Predicate<ModContext> val_6 = null;
        val_9 = val_6;
        val_6 = new System.Predicate<ModContext>(object:  val_1, method:  System.Boolean GatherModsForEquipping.GatherMods.<>c__DisplayClass5_0::<AddCurrentlyEquippedModFromThisSlot>b__0(GameUI.Actions.GatherModsForEquipping.ModContext x));
        if((ret.Find(match:  val_6)) != null)
        {
                int val_9 = val_7.quantity;
            val_7.isEquipped = true;
            val_9 = val_9 + 1;
            val_7.quantity = val_9;
            return;
        }
        
        val_11 = this._itemDefinitions.GetModById(id:  val_10);
        if(val_11 == null)
        {
                return;
        }
        
        if(val_2 != null)
        {
                .Mod = val_11;
            .isEquipped = true;
            .modEquippable = true;
        }
        else
        {
                mem[16] = val_11;
            val_11 = true;
            .isEquipped = val_11;
            mem[24] = val_11;
        }
        
        .modSellable = true;
        ret.Add(item:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<GameUI.Actions.GatherModsForEquipping.ModContext> GatherAllModsForSlot(GameUI.WorkshopSlotData currentSlot, int selectedModSlotIndex, System.Collections.Generic.List<GameUI.WorkshopSlotData> slots)
    {
        System.Collections.Generic.List<ModContext> val_1 = new System.Collections.Generic.List<ModContext>();
        Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_2 = currentSlot.ClientEndoskeleton;
        val_1.AddRange(collection:  this.GetModsFromInventory(mods:  val_2.mods, selectedModSlotIndex:  selectedModSlotIndex));
        this.AddCurrentlyEquippedModFromThisSlot(currentSlot:  currentSlot, selectedModSlotIndex:  selectedModSlotIndex, ret:  val_1);
        return val_1;
    }

}
