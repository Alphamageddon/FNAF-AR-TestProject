using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModSelectionHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.Actions.GatherModsForEquipping.GatherMods _gatherMods;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel _workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GameUIMasterDataConnector _dataConnector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ModCell _modCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _modCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotData _selectedSlot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.ModCell> _modCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.Actions.GatherModsForEquipping.ModContext> _modContexts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.ModCell> _DisplaySellDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _ShowInvalidModCategoryDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _selectedModSlotIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _noModsLabel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _modsAvailableCountText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _modsTotalCountText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_WorkshopModMenuOpened()
        {
            GameUI.WorkshopSlotData val_1 = this._workshopSlotDataModel.GetSelectedSlotData();
            this._selectedSlot = val_1;
            this._modContexts = this._gatherMods.GatherAllModsForSlot(currentSlot:  val_1, selectedModSlotIndex:  this._selectedModSlotIndex, slots:  this._workshopSlotDataModel.workshopSlotDatas);
            this.RefreshCellsFromLocalData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SelectModCell(GameUI.ModCell modCell)
        {
            if(modCell.modCellPayload.context.isEquipped == false)
            {
                goto label_3;
            }
            
            this.UpequipMod();
            goto label_4;
            label_3:
            if(modCell.modCellPayload.context.modEquippable == false)
            {
                goto label_7;
            }
            
            this.UpequipMod();
            this.EquipMod(modId:  modCell.modCellPayload.context.Mod.Id);
            label_4:
            this.RefreshCellsFromLocalData();
            return;
            label_7:
            this._ShowInvalidModCategoryDialog.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshCellsFromLocalData()
        {
            this._modContexts.Sort(comparison:  new System.Comparison<ModContext>(object:  this, method:  System.Int32 GameUI.ModSelectionHandler::SortModFunction(GameUI.Actions.GatherModsForEquipping.ModContext mod1, GameUI.Actions.GatherModsForEquipping.ModContext mod2)));
            this.AddCellsAndSetData();
            this.RemoveExcessCells();
            this.SetSelected();
            this.UpdateNoModImage();
            this.UpdateModCountHeaderText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateModCountHeaderText()
        {
            var val_7 = null;
            if((ModSelectionHandler.<>c.<>9__20_0) == null)
            {
                goto label_3;
            }
            
            label_12:
            this._modsAvailableCountText.text = this._modCells.FindAll(match:  ModSelectionHandler.<>c.<>9__20_0).Count.ToString();
            this._modsTotalCountText.text = this._modCells.Count.ToString();
            return;
            label_3:
            ModSelectionHandler.<>c.<>9__20_0 = new System.Predicate<GameUI.ModCell>(object:  ModSelectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModSelectionHandler.<>c::<UpdateModCountHeaderText>b__20_0(GameUI.ModCell x));
            if(this._modCells != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCellData(GameUI.Actions.GatherModsForEquipping.ModContext modContext, GameUI.ModCell modCell)
        {
            System.Action<GameUI.ModCell> val_3;
            GameUI.ModSelectionCellData val_1 = new GameUI.ModSelectionCellData();
            .context = modContext;
            System.Action<GameUI.ModCell> val_2 = new System.Action<GameUI.ModCell>(object:  this, method:  System.Void GameUI.ModSelectionHandler::SelectModCell(GameUI.ModCell modCell));
            if(val_1 != null)
            {
                    .SelectModCell = val_2;
                val_3 = this._DisplaySellDialog;
            }
            else
            {
                    mem[24] = val_2;
                val_3 = this._DisplaySellDialog;
            }
            
            .DisplaySellDialog = val_3;
            modCell.SetData(payload:  val_1);
            this.SetIconForCell(modData:  modContext.Mod, modCell:  modCell);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIconForCell(Game.ItemDefinition.Data.DataDefinitions.ModData modData, GameUI.ModCell modCell)
        {
            string val_4;
            var val_7;
            if(modData == null)
            {
                goto label_1;
            }
            
            val_4 = modData.ModIconRenderedName;
            if(val_4 != null)
            {
                goto label_2;
            }
            
            label_1:
            val_4 = System.String.alignConst;
            label_2:
            if((System.String.IsNullOrWhiteSpace(value:  val_4)) == false)
            {
                goto label_4;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_8;
            label_4:
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_12;
            label_8:
            val_7 = this._iconLookup;
            UnityEngine.Sprite val_3 = val_7.GetDefaultIcon();
            goto label_13;
            label_12:
            val_7 = this._iconLookup;
            label_13:
            modCell.SetSprite(icon:  val_7.GetIcon(group:  1, name:  val_4));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddCell()
        {
            this._modCells.Add(item:  UnityEngine.Object.Instantiate<GameUI.ModCell>(original:  this._modCellPrefab, parent:  this._modCellParent));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildSelectionButtons()
        {
            this.AddCellsAndSetData();
            this.RemoveExcessCells();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveExcessCells()
        {
            int val_8;
            int val_8 = this._modCells.Count;
            val_8 = val_8 - this._modContexts.Count;
            if(val_8 < 1)
            {
                    return;
            }
            
            val_8 = this._modContexts.Count;
            goto label_5;
            label_11:
            UnityEngine.Object.Destroy(obj:  X22.Item[val_8].gameObject);
            val_8 = val_8 + 1;
            label_5:
            if(val_8 < this._modCells.Count)
            {
                goto label_11;
            }
            
            this._modCells.RemoveRange(index:  this._modContexts.Count, count:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddCellsAndSetData()
        {
            var val_5 = 0;
            goto label_1;
            label_7:
            if(val_5 >= this._modCells.Count)
            {
                    this.AddCell();
            }
            
            this.SetCellData(modContext:  this._modContexts.Item[0], modCell:  this._modCells.Item[0]);
            val_5 = 1;
            label_1:
            if(val_5 < this._modContexts.Count)
            {
                goto label_7;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetSelected()
        {
            System.Collections.Generic.List<GameUI.ModCell> val_6;
            var val_7;
            var val_9;
            val_6 = this;
            val_7 = null;
            val_7 = null;
            if((ModSelectionHandler.<>c.<>9__27_0) == null)
            {
                goto label_3;
            }
            
            label_17:
            if((this._modCells.Find(match:  ModSelectionHandler.<>c.<>9__27_0)) != 0)
            {
                    val_9 = 1;
            }
            else
            {
                    if(this._modCells.Count < 1)
            {
                    return;
            }
            
                val_6 = this._modCells;
                GameUI.ModCell val_4 = val_6.Item[0];
                if(val_4 == null)
            {
                    return;
            }
            
                val_9 = 0;
            }
            
            val_4.SetSelected(value:  false);
            return;
            label_3:
            ModSelectionHandler.<>c.<>9__27_0 = new System.Predicate<GameUI.ModCell>(object:  ModSelectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModSelectionHandler.<>c::<SetSelected>b__27_0(GameUI.ModCell x));
            if(this._modCells != null)
            {
                goto label_17;
            }
            
            goto label_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpequipMod()
        {
            if(this.GetEquippedModContext() != null)
            {
                    val_1.isEquipped = false;
            }
            
            this.ClearCurrentEquippedModSlot();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveEquippedModContextFromContextList()
        {
            var val_3 = null;
            if((ModSelectionHandler.<>c.<>9__29_0) == null)
            {
                goto label_3;
            }
            
            label_8:
            int val_1 = this._modContexts.RemoveAll(match:  ModSelectionHandler.<>c.<>9__29_0);
            return;
            label_3:
            ModSelectionHandler.<>c.<>9__29_0 = new System.Predicate<ModContext>(object:  ModSelectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModSelectionHandler.<>c::<RemoveEquippedModContextFromContextList>b__29_0(GameUI.Actions.GatherModsForEquipping.ModContext x));
            if(this._modContexts != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearCurrentEquippedModSlot()
        {
            if((System.String.op_Inequality(a:  this._selectedSlot.ClientEndoskeleton.GetModAtIndex(index:  this._selectedModSlotIndex), b:  System.String.alignConst)) == false)
            {
                    return;
            }
            
            this._selectedSlot.ClientEndoskeleton.SetModAtIndex(modId:  System.String.alignConst, index:  this._selectedModSlotIndex);
            this._selectedSlot.UpdateIsDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCurrentModSlot(string id)
        {
            if((System.String.op_Inequality(a:  id, b:  this._selectedSlot.ClientEndoskeleton.GetModAtIndex(index:  this._selectedModSlotIndex))) == false)
            {
                    return;
            }
            
            this._selectedSlot.ClientEndoskeleton.SetModAtIndex(modId:  id, index:  this._selectedModSlotIndex);
            this._selectedSlot.UpdateIsDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EquipMod(string modId)
        {
            .modId = modId;
            ModContext val_3 = this._modContexts.Find(match:  new System.Predicate<ModContext>(object:  new ModSelectionHandler.<>c__DisplayClass32_0(), method:  System.Boolean ModSelectionHandler.<>c__DisplayClass32_0::<EquipMod>b__0(GameUI.Actions.GatherModsForEquipping.ModContext x)));
            val_3.isEquipped = true;
            this.SetCurrentModSlot(id:  (ModSelectionHandler.<>c__DisplayClass32_0)[1152921524843139104].modId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DecrementModFromContextList(string modId)
        {
            .modId = modId;
            ModContext val_3 = this._modContexts.Find(match:  new System.Predicate<ModContext>(object:  new ModSelectionHandler.<>c__DisplayClass33_0(), method:  System.Boolean ModSelectionHandler.<>c__DisplayClass33_0::<DecrementModFromContextList>b__0(GameUI.Actions.GatherModsForEquipping.ModContext x)));
            if(val_3 == null)
            {
                    return;
            }
            
            int val_5 = val_3.quantity;
            val_5 = val_5 - 1;
            val_3.quantity = val_5;
            if(val_5 > 0)
            {
                    return;
            }
            
            if(val_3.isEquipped != false)
            {
                    this.ClearCurrentEquippedModSlot();
            }
            
            bool val_4 = this._modContexts.Remove(item:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.Actions.GatherModsForEquipping.ModContext GetEquippedModContext()
        {
            var val_2 = null;
            if((ModSelectionHandler.<>c.<>9__34_0) != null)
            {
                    if(this._modContexts == null)
            {
                    return this._modContexts.Find(match:  ModSelectionHandler.<>c.<>9__34_0);
            }
            
                return this._modContexts.Find(match:  ModSelectionHandler.<>c.<>9__34_0);
            }
            
            ModSelectionHandler.<>c.<>9__34_0 = new System.Predicate<ModContext>(object:  ModSelectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModSelectionHandler.<>c::<GetEquippedModContext>b__34_0(GameUI.Actions.GatherModsForEquipping.ModContext x));
            if(this._modContexts != null)
            {
                    return this._modContexts.Find(match:  ModSelectionHandler.<>c.<>9__34_0);
            }
            
            return this._modContexts.Find(match:  ModSelectionHandler.<>c.<>9__34_0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddModContextToInventoryAsUnequipped(GameUI.Actions.GatherModsForEquipping.ModContext modContext)
        {
            var val_2;
            var val_3;
            System.Collections.Generic.List<ModContext> val_9 = this._modContexts;
            List.Enumerator<T> val_1 = val_9.GetEnumerator();
            var val_9 = val_2;
            label_7:
            if(((-1238125488) & 1) == 0)
            {
                goto label_2;
            }
            
            val_9 = val_3.emailUIDataHandler;
            if((System.String.op_Equality(a:  val_4._masterDomain, b:  modContext.Mod.Id)) == false)
            {
                goto label_7;
            }
            
            val_9 = val_9 + 1;
            mem2[0] = val_9;
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524843557968});
            return;
            label_2:
            if(modContext != null)
            {
                goto label_9;
            }
            
            goto label_18;
            label_9:
            modContext.isEquipped = false;
            goto label_19;
            label_18:
            mem[26] = 0;
            label_19:
            modContext.quantity = 1;
            this._modContexts.Add(item:  modContext);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int SortModFunction(GameUI.Actions.GatherModsForEquipping.ModContext mod1, GameUI.Actions.GatherModsForEquipping.ModContext mod2)
        {
            System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModCategory, System.Int32> val_8;
            int val_9;
            var val_10;
            val_8 = mod2;
            val_9 = this;
            var val_2 = (mod2.modEquippable == true) ? 1 : 0;
            val_2 = ((mod1.modEquippable == true) ? 1 : 0) ^ val_2;
            if((val_2 & 1) == 0)
            {
                goto label_3;
            }
            
            label_14:
            var val_3 = (mod1.modEquippable == true) ? (-1) : 1;
            return (int)val_10;
            label_3:
            if(mod1.Mod.Category != mod2.Mod.Category)
            {
                goto label_7;
            }
            
            val_9 = mod1.Mod.Stars;
            if(val_9 != mod2.Mod.Stars)
            {
                goto label_11;
            }
            
            if((System.String.op_Equality(a:  mod1.Mod.Id, b:  mod2.Mod.Id)) == false)
            {
                goto label_13;
            }
            
            goto label_14;
            label_7:
            val_8 = this._dataConnector.<ModCategorySortWeights>k__BackingField;
            val_9 = mod2.Mod.Category;
            val_10 = (this._dataConnector.<ModCategorySortWeights>k__BackingField.Item[mod1.Mod.Category]) - val_8.Item[val_9];
            return (int)val_10;
            label_11:
            val_8 = mod1.Mod.Stars;
            val_10 = val_8 - mod2.Mod.Stars;
            return (int)val_10;
            label_13:
            if(mod2.Mod != null)
            {
                    return System.String.Compare(strA:  mod1.Mod.Id, strB:  mod2.Mod.Id);
            }
            
            return System.String.Compare(strA:  mod1.Mod.Id, strB:  mod2.Mod.Id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearAllCells()
        {
            var val_3;
            List.Enumerator<T> val_1 = this._modCells.GetEnumerator();
            label_10:
            if(((-1237633184) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            if(val_4.gameObject == 0)
            {
                goto label_10;
            }
            
            UnityEngine.Object.Destroy(obj:  val_4.gameObject);
            goto label_10;
            label_2:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524844050272});
            this._modCells.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateNoModImage()
        {
            this._noModsLabel.SetActive(value:  (this.GetNumberOfVisibleMods() == 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModSelectionHandler(Master.MasterDomain masterDomain, GameUI.ModCell cellPrefab, UnityEngine.Transform plushSuitCellParent, System.Action<GameUI.ModCell> SellDialog, System.Action InvalidModCategoryDialog, UnityEngine.GameObject noModsLabel, TMPro.TextMeshProUGUI modCountText, TMPro.TextMeshProUGUI modsTotalCountText)
        {
            this._selectedModSlotIndex = 0;
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            GameUI.Domain val_2 = masterDomain.gameUIDomain;
            this._workshopSlotDataModel = 0;
            GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
            this._dataConnector = 0;
            this._modCells = new System.Collections.Generic.List<GameUI.ModCell>();
            this._modCellPrefab = cellPrefab;
            this._modCellParent = plushSuitCellParent;
            this._gatherMods = new GatherModsForEquipping.GatherMods(masterDomain:  this._masterDomain);
            this._DisplaySellDialog = SellDialog;
            this._ShowInvalidModCategoryDialog = InvalidModCategoryDialog;
            this._noModsLabel = val_1;
            this._modsAvailableCountText = modCountText;
            this._modsTotalCountText = modsTotalCountText;
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.ModSelectionHandler::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            this._masterDomain.eventExposer.add_WorkshopModMenuOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.ModSelectionHandler::EventExposer_WorkshopModMenuOpened()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSelectedModIndex(int selectedModIndex)
        {
            this._selectedModSlotIndex = selectedModIndex;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SellModAndUpdateLocalData(GameUI.Actions.GatherModsForEquipping.ModContext modContext)
        {
            this.DecrementModFromContextList(modId:  modContext.Mod.Id);
            this.RefreshCellsFromLocalData();
            System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32> val_1 = new System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>();
            val_1.Add(key:  modContext.Mod, value:  1);
            this._masterDomain.WorkshopDomain.Inventory.ModInventory.RemoveMod(key:  modContext.Mod, amount:  1);
            this._masterDomain.serverDomain.sellModsRequester.SellMods(modTable:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNumberOfVisibleMods()
        {
            if(this._modCells != null)
            {
                    return this._modCells.Count;
            }
            
            return this._modCells.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TearDown()
        {
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_WorkshopModMenuOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.ModSelectionHandler::EventExposer_WorkshopModMenuOpened()));
        }
    
    }

}
