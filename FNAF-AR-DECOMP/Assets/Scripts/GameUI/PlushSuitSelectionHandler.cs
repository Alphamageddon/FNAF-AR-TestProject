using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class PlushSuitSelectionHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string BARE_ENDO = "BareEndo";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PlushSuitCell plushSuitCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform plushSuitCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PlushSuitSelectionData plushSuitSelectionData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsEquipedToDifferentSlot(string plushSuitId)
        {
            .plushSuitId = plushSuitId;
            .selectedSlot = this._masterDomain.gameUIDomain.GetSelectedSlotData();
            return (bool)((this.workshopSlotDataModel.workshopSlotDatas.Find(match:  new System.Predicate<GameUI.WorkshopSlotData>(object:  new PlushSuitSelectionHandler.<>c__DisplayClass7_0(), method:  System.Boolean PlushSuitSelectionHandler.<>c__DisplayClass7_0::<IsEquipedToDifferentSlot>b__0(GameUI.WorkshopSlotData slotData)))) != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildSelectionButtons()
        {
            var val_9;
            var val_10;
            object val_21;
            var val_22;
            System.Comparison<Game.ItemDefinition.Data.DataDefinitions.PlushSuitData> val_24;
            bool val_25;
            val_21 = this;
            TheGame.Domain val_1 = this._masterDomain.theGameDomain;
            System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.PlushSuitData> val_6 = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.PlushSuitData>(collection:  this._masterDomain.ItemDefinitionDomain.ItemDefinitions.PlushSuitDictionary.Values);
            val_22 = null;
            val_22 = null;
            val_24 = PlushSuitSelectionHandler.<>c.<>9__8_0;
            if(val_24 == null)
            {
                goto label_10;
            }
            
            if(val_6 == null)
            {
                goto label_11;
            }
            
            label_15:
            val_6.Sort(comparison:  val_24);
            goto label_12;
            label_10:
            System.Comparison<Game.ItemDefinition.Data.DataDefinitions.PlushSuitData> val_7 = null;
            val_24 = val_7;
            val_7 = new System.Comparison<Game.ItemDefinition.Data.DataDefinitions.PlushSuitData>(object:  PlushSuitSelectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PlushSuitSelectionHandler.<>c::<BuildSelectionButtons>b__8_0(Game.ItemDefinition.Data.DataDefinitions.PlushSuitData x, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData y));
            PlushSuitSelectionHandler.<>c.<>9__8_0 = val_24;
            if(val_6 != null)
            {
                goto label_15;
            }
            
            label_11:
            0.Sort(comparison:  val_7);
            label_12:
            List.Enumerator<T> val_8 = val_6.GetEnumerator();
            var val_20 = val_9;
            do
            {
                label_25:
                if(((-1234948544) & 1) == 0)
            {
                    return;
            }
            
                GameUI.EmailUIDataHandler val_11 = val_10.emailUIDataHandler;
                if((System.String.op_Equality(a:  val_11._masterDomain, b:  "BareEndo")) != true)
            {
                    if((this.IsEquipedToDifferentSlot(plushSuitId:  val_11._masterDomain)) == true)
            {
                goto label_25;
            }
            
            }
            
                if((val_1.playerInventory.GetPlushSuits().Contains(item:  val_11._masterDomain)) != false)
            {
                    val_25 = 1;
            }
            else
            {
                    val_25 = System.String.op_Equality(a:  val_11._masterDomain, b:  "BareEndo");
            }
            
                val_20 = val_25 | val_20;
            }
            while(val_20 == false);
            
            new PlushSuitCell.PlushSuitCellData() = new System.Object();
            .serverData = val_11;
            System.Action<GameUI.PlushSuitCell> val_17 = new System.Action<GameUI.PlushSuitCell>(object:  this, method:  System.Void GameUI.PlushSuitSelectionHandler::SelectPlushSuitCell(GameUI.PlushSuitCell plushSuitCell));
            .SelectFunction = null;
            .playerOwned = val_25;
            this.InstantiateAndSetButtonData(plushSuitData:  val_11, plushSuitCellData:  new PlushSuitCell.PlushSuitCellData());
            goto label_25;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InstantiateAndSetButtonData(Game.ItemDefinition.Data.DataDefinitions.PlushSuitData plushSuitData, GameUI.PlushSuitCell.PlushSuitCellData plushSuitCellData)
        {
            string val_5;
            var val_8;
            GameUI.PlushSuitCell val_1 = UnityEngine.Object.Instantiate<GameUI.PlushSuitCell>(original:  this.plushSuitCellPrefab, parent:  this.plushSuitCellParent);
            if(val_1 != null)
            {
                    val_1.SetData(plushSuitCellData:  plushSuitCellData);
            }
            else
            {
                    val_1.SetData(plushSuitCellData:  plushSuitCellData);
            }
            
            if(val_1.plushSuitCellData.playerOwned == false)
            {
                goto label_6;
            }
            
            if(plushSuitData == null)
            {
                goto label_9;
            }
            
            val_5 = plushSuitData.PlushSuitIconName;
            goto label_10;
            label_6:
            if(plushSuitData == null)
            {
                goto label_9;
            }
            
            val_5 = plushSuitData.PlushSuitSilhouetteIcon;
            goto label_10;
            label_9:
            val_5 = 0;
            label_10:
            if((System.String.IsNullOrWhiteSpace(value:  val_5)) == false)
            {
                goto label_12;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_16;
            label_12:
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_20;
            label_16:
            val_8 = this._iconLookup;
            UnityEngine.Sprite val_4 = val_8.GetDefaultIcon();
            goto label_21;
            label_20:
            val_8 = this._iconLookup;
            label_21:
            val_1.SetIcon(icon:  val_8.GetIcon(group:  2, name:  val_5));
            this.plushSuitSelectionData.cells.Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SelectPlushSuitCell(GameUI.PlushSuitCell plushSuitCell)
        {
            GameUI.WorkshopSlotData val_1 = this.workshopSlotDataModel.GetSelectedSlotData();
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_2 = val_1.ClientEndoskeleton;
            val_2.plushSuit = plushSuitCell.plushSuitCellData.serverData.Id;
            if(val_1 != null)
            {
                    val_1.UpdateIsDirty();
            }
            else
            {
                    0.UpdateIsDirty();
            }
            
            val_1.UpdateIcon();
            this.HighlightCell(plushSuitCell:  plushSuitCell);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HighlightCell(GameUI.PlushSuitCell plushSuitCell)
        {
            List.Enumerator<T> val_1 = this.plushSuitSelectionData.cells.GetEnumerator();
            label_7:
            if(((-1234352344) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            UnityEngine.Object val_6 = plushSuitCell;
            val_6 = UnityEngine.Object.op_Equality(x:  val_2, y:  val_6);
            val_2.SetSelected(v:  val_6);
            goto label_7;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524847331112});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCellSelectability()
        {
            bool val_8;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            List.Enumerator<T> val_3 = this.plushSuitSelectionData.cells.GetEnumerator();
            val_8 = (val_1.<WorkshopStage>k__BackingField.IsWaitingForSpawn()) ^ 1;
            label_8:
            if(((-1234191176) & 1) == 0)
            {
                goto label_6;
            }
            
            0.emailUIDataHandler.SetSelectable(value:  val_8);
            goto label_8;
            label_6:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524847492280});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetStartSelection()
        {
            var val_5;
            var val_11;
            System.Collections.Generic.List<GameUI.PlushSuitCell> val_12;
            val_11 = this;
            val_12 = this.plushSuitSelectionData.cells;
            List.Enumerator<T> val_3 = val_12.GetEnumerator();
            do
            {
                if(((-1234009584) & 1) == 0)
            {
                    return;
            }
            
                val_12 = val_5.emailUIDataHandler;
                Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_7 = this._masterDomain.gameUIDomain.GetSelectedSlotData().DisplayEndoskeleton;
            }
            while((System.String.op_Equality(a:  val_7.plushSuit, b:  val_6._itemDefinitions._purchasedSlots + 16)) == false);
            
            this.SelectPlushSuitCell(plushSuitCell:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearAllCells()
        {
            var val_3;
            List.Enumerator<T> val_1 = this.plushSuitSelectionData.cells.GetEnumerator();
            label_11:
            if(((-1233822816) & 1) == 0)
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
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524847860640});
            this.plushSuitSelectionData.cells.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlushSuitSelectionHandler(Master.MasterDomain masterDomain, GameUI.PlushSuitCell plushSuitCellPrefab, UnityEngine.Transform plushSuitCellParent)
        {
            this._masterDomain = masterDomain;
            GameUI.Domain val_1 = masterDomain.gameUIDomain;
            this.plushSuitCellPrefab = plushSuitCellPrefab;
            this.plushSuitCellParent = plushSuitCellParent;
            this.workshopSlotDataModel = true;
            this.plushSuitSelectionData = new GameUI.PlushSuitSelectionData();
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.PlushSuitSelectionHandler::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GeneratePlushSuitSelectionCells()
        {
            this.ClearAllCells();
            this.BuildSelectionButtons();
            this.SetStartSelection();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateCellSelectability();
        }
    
    }

}
