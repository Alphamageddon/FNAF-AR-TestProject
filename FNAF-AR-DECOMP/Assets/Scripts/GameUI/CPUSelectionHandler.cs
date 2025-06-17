using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CPUSelectionHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CPUCell CPUCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform CPUCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CPUSelectionData CPUSelectionData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string BARE_ENDO = "BareEndo";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsEquipedToDifferentSlot(string cpuKey)
        {
            .cpuKey = cpuKey;
            .selectedSlot = this.workshopSlotDataModel.GetSelectedSlotData();
            return (bool)((this.workshopSlotDataModel.workshopSlotDatas.Find(match:  new System.Predicate<GameUI.WorkshopSlotData>(object:  new CPUSelectionHandler.<>c__DisplayClass7_0(), method:  System.Boolean CPUSelectionHandler.<>c__DisplayClass7_0::<IsEquipedToDifferentSlot>b__0(GameUI.WorkshopSlotData slotData)))) != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildSelectionButtons()
        {
            var val_7;
            var val_8;
            object val_22;
            var val_23;
            System.Comparison<Game.ItemDefinition.Data.DataDefinitions.CPUData> val_25;
            bool val_26;
            val_22 = this;
            System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.CPUData> val_4 = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.CPUData>(collection:  this._masterDomain.ItemDefinitionDomain.ItemDefinitions.CpuDictionary.Values);
            val_23 = null;
            val_23 = null;
            val_25 = CPUSelectionHandler.<>c.<>9__8_0;
            if(val_25 == null)
            {
                goto label_7;
            }
            
            if(val_4 == null)
            {
                goto label_8;
            }
            
            label_12:
            val_4.Sort(comparison:  val_25);
            goto label_9;
            label_7:
            System.Comparison<Game.ItemDefinition.Data.DataDefinitions.CPUData> val_5 = null;
            val_25 = val_5;
            val_5 = new System.Comparison<Game.ItemDefinition.Data.DataDefinitions.CPUData>(object:  CPUSelectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 CPUSelectionHandler.<>c::<BuildSelectionButtons>b__8_0(Game.ItemDefinition.Data.DataDefinitions.CPUData x, Game.ItemDefinition.Data.DataDefinitions.CPUData y));
            CPUSelectionHandler.<>c.<>9__8_0 = val_25;
            if(val_4 != null)
            {
                goto label_12;
            }
            
            label_8:
            0.Sort(comparison:  val_5);
            label_9:
            List.Enumerator<T> val_6 = val_4.GetEnumerator();
            var val_21 = val_7;
            do
            {
                label_26:
                if(((-1259711840) & 1) == 0)
            {
                    return;
            }
            
                if((System.String.op_Equality(a:  val_9._masterDomain, b:  "BareEndo")) != true)
            {
                    if((this.IsEquipedToDifferentSlot(cpuKey:  val_9._masterDomain)) == true)
            {
                goto label_26;
            }
            
            }
            
                if((this._masterDomain.WorkshopDomain.Inventory.CpuInventory.entries.ContainsKey(key:  val_9._masterDomain)) != false)
            {
                    val_26 = 1;
            }
            else
            {
                    val_26 = System.String.op_Equality(a:  val_9._masterDomain, b:  "BareEndo");
            }
            
                val_21 = val_26 | val_21;
            }
            while(val_21 == false);
            
            new CPUCell.CPUCellData() = new System.Object();
            .serverData = val_8.emailUIDataHandler;
            System.Action<GameUI.CPUCell, System.Boolean> val_18 = new System.Action<GameUI.CPUCell, System.Boolean>(object:  this, method:  System.Void GameUI.CPUSelectionHandler::SelectCPUCell(GameUI.CPUCell cpuCell, bool initialSelection));
            .SelectFunction = null;
            .playerOwned = val_26;
            this.InstantiateAndSetButtonData(data:  new CPUCell.CPUCellData());
            goto label_26;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InstantiateAndSetButtonData(GameUI.CPUCell.CPUCellData data)
        {
            string val_8;
            var val_11;
            GameUI.CPUCell val_1 = UnityEngine.Object.Instantiate<GameUI.CPUCell>(original:  this.CPUCellPrefab, parent:  this.CPUCellParent);
            if(val_1 != null)
            {
                    val_1.SetData(data:  data);
            }
            else
            {
                    val_1.SetData(data:  data);
            }
            
            if(val_1.cpuCellData == null)
            {
                goto label_5;
            }
            
            if(val_1.cpuCellData.playerOwned == false)
            {
                goto label_6;
            }
            
            label_10:
            if((((val_1.cpuCellData.serverData == 0) ? 1 : 0) & 1) != 0)
            {
                goto label_7;
            }
            
            val_8 = val_1.cpuCellData.serverData.CpuIconName;
            goto label_12;
            label_5:
            if(val_1.cpuCellData.playerOwned == true)
            {
                goto label_10;
            }
            
            label_6:
            if((((val_1.cpuCellData.serverData == 0) ? 1 : 0) & 1) == 0)
            {
                goto label_11;
            }
            
            label_7:
            val_8 = 0;
            goto label_12;
            label_11:
            val_8 = val_1.cpuCellData.serverData.CpuSilhouetteIcon;
            label_12:
            if((System.String.IsNullOrWhiteSpace(value:  val_8)) == false)
            {
                goto label_14;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            goto label_18;
            label_14:
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_22;
            label_18:
            val_11 = this._iconLookup;
            UnityEngine.Sprite val_6 = val_11.GetDefaultIcon();
            goto label_23;
            label_22:
            val_11 = this._iconLookup;
            label_23:
            val_1.SetIcon(icon:  val_11.GetIcon(group:  0, name:  val_8));
            this.CPUSelectionData.cells.Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SelectCPUCell(GameUI.CPUCell cpuCell, bool initialSelection)
        {
            GameUI.WorkshopSlotData val_1 = this.workshopSlotDataModel.GetSelectedSlotData();
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_2 = val_1.ClientEndoskeleton;
            val_2.cpu = cpuCell.cpuCellData.serverData.Id;
            val_1.UpdateIsDirty();
            this.HighlightCell(cpuCell:  cpuCell);
            if(initialSelection != false)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.OnWorkshopCpuChanged();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HighlightCell(GameUI.CPUCell cpuCell)
        {
            List.Enumerator<T> val_1 = this.CPUSelectionData.cells.GetEnumerator();
            label_7:
            if(((-1259078776) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            UnityEngine.Object val_6 = cpuCell;
            val_6 = UnityEngine.Object.op_Equality(x:  val_2, y:  val_6);
            val_2.SetSelected(value:  val_6);
            goto label_7;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524822604680});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CPUSelectionHandler(Master.MasterDomain masterDomain, GameUI.CPUCell cpuCellPrefab, UnityEngine.Transform cpuCellParent)
        {
            this._masterDomain = masterDomain;
            GameUI.Domain val_1 = masterDomain.gameUIDomain;
            this.workshopSlotDataModel = val_1.gameUIData.emailUIDataHandler;
            this.CPUCellPrefab = cpuCellPrefab;
            this.CPUCellParent = cpuCellParent;
            this.CPUSelectionData = new GameUI.CPUSelectionData();
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.CPUSelectionHandler::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateCPUSelectionCells()
        {
            this.ClearAllCells();
            this.BuildSelectionButtons();
            this.SetStartSelection();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetStartSelection()
        {
            var val_5;
            var val_12;
            System.Collections.Generic.List<GameUI.CPUCell> val_13;
            val_12 = this;
            if(this.CPUSelectionData.cells == null)
            {
                    return;
            }
            
            if(this.CPUSelectionData.cells.Count < 1)
            {
                    return;
            }
            
            val_13 = this.CPUSelectionData.cells;
            List.Enumerator<T> val_3 = val_13.GetEnumerator();
            do
            {
                if(((-1258460816) & 1) == 0)
            {
                    return;
            }
            
                val_13 = val_5.emailUIDataHandler;
                Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_7 = this.workshopSlotDataModel.GetSelectedSlotData().DisplayEndoskeleton;
            }
            while((System.String.op_Equality(a:  val_7.cpu, b:  0)) == false);
            
            this.SelectCPUCell(cpuCell:  val_13, initialSelection:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearAllCells()
        {
            var val_3;
            List.Enumerator<T> val_1 = this.CPUSelectionData.cells.GetEnumerator();
            label_11:
            if(((-1258257664) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            if(val_4.gameObject == 0)
            {
                goto label_11;
            }
            
            UnityEngine.Object.Destroy(obj:  val_4.gameObject);
            goto label_11;
            label_3:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524823425792});
            this.CPUSelectionData.cells.Clear();
        }
    
    }

}
