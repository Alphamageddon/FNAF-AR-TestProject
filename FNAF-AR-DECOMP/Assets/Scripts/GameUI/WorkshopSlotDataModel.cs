using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopSlotDataModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.WorkshopSlotData> _workshopSlotDatas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotData selectedWorkshopSlotData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int selectedWorkshopSlotDataIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.WorkshopSlotData> workshopSlotDatas { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.WorkshopSlotData> get_workshopSlotDatas()
        {
            return (System.Collections.Generic.List<GameUI.WorkshopSlotData>)this._workshopSlotDatas;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopSlotDataModel(Master.MasterDomain masterDomain)
        {
            this._workshopSlotDatas = new System.Collections.Generic.List<GameUI.WorkshopSlotData>();
            this.selectedWorkshopSlotDataIndex = 0;
            this._masterDomain = masterDomain;
            masterDomain.eventExposer.add_WorkshopDataV2Updated(value:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  this, method:  System.Void GameUI.WorkshopSlotDataModel::EventExposer_WarehouseDataV2Updated(AnimatronicEntity.Data.WorkshopData workshopData)));
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.WorkshopSlotDataModel::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            this._masterDomain.ItemDefinitionDomain.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void GameUI.WorkshopSlotDataModel::ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            var val_5 = this;
            this._iconLookup = iconLookup;
            List.Enumerator<T> val_1 = this._workshopSlotDatas.GetEnumerator();
            label_4:
            if(((-1187110024) & 1) == 0)
            {
                goto label_2;
            }
            
            val_2._emailIdsToBeSetToReadOnServer = this._iconLookup;
            0.emailUIDataHandler.SetIcon();
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524894573432});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            var val_6 = this;
            var val_7 = 0;
            val_7 = val_7 + 1;
            this._itemDefinitions = itemDefinitionDomain.ItemDefinitions;
            List.Enumerator<T> val_3 = this._workshopSlotDatas.GetEnumerator();
            label_9:
            if(((-1186957048) & 1) == 0)
            {
                goto label_7;
            }
            
            val_4._itemDefinitions = this._itemDefinitions;
            0.emailUIDataHandler.SetIcon();
            goto label_9;
            label_7:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524894726408});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_WarehouseDataV2Updated(AnimatronicEntity.Data.WorkshopData workshopData)
        {
            this.BuildSlotDataFromWarehouseDataV2(workshopData:  workshopData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildSlotDataFromWarehouseDataV2(AnimatronicEntity.Data.WorkshopData workshopData)
        {
            var val_9;
            GameUI.WorkshopSlotData val_10;
            val_9 = 0;
            goto label_1;
            label_15:
            AnimatronicEntity.Data.WorkshopEntry val_2 = workshopData.Entries.Item[0];
            val_2.status = this.UpdateEntryStatus(entry:  val_2);
            if(val_9 >= this._workshopSlotDatas.Count)
            {
                goto label_6;
            }
            
            val_10 = this._workshopSlotDatas.Item[0];
            if(val_10 != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_6:
            GameUI.WorkshopSlotData val_6 = null;
            val_10 = val_6;
            val_6 = new GameUI.WorkshopSlotData();
            this._workshopSlotDatas.Add(item:  val_6);
            ._iconLookup = this._iconLookup;
            val_6.SetIcon();
            ._itemDefinitions = this._itemDefinitions;
            val_6.SetIcon();
            label_9:
            val_6.UpdateServerWorkshopEntry(entry:  val_2);
            val_9 = 1;
            label_1:
            if(val_9 < workshopData.Entries.Count)
            {
                goto label_15;
            }
            
            this.UpdateSelectedSlot();
            this._masterDomain.eventExposer.OnWorkshopSlotDataUpdated(datas:  this._workshopSlotDatas);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Data.WorkshopEntry.Status UpdateEntryStatus(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            Status val_6;
            if((System.String.IsNullOrEmpty(value:  entry.entityId)) != false)
            {
                    val_6 = 0;
                return val_6;
            }
            
            val_6 = entry.status;
            if(val_6 != 1)
            {
                    return val_6;
            }
            
            AnimatronicEntity.AnimatronicEntity val_3 = this._masterDomain.AnimatronicEntityDomain.container.GetEntity(entityId:  entry.entityId);
            if(val_3 == null)
            {
                    return val_6;
            }
            
            if(val_3.stateData.animatronicState == 11)
            {
                    val_6 = 3;
                return val_6;
            }
            
            val_6 = entry.status;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSelectedSlot()
        {
            if(this._workshopSlotDatas.Count < 1)
            {
                    return;
            }
            
            int val_5 = System.Math.Max(val1:  0, val2:  System.Math.Min(val1:  this._workshopSlotDatas.Count - 1, val2:  this.selectedWorkshopSlotDataIndex));
            this.selectedWorkshopSlotDataIndex = val_5;
            this.selectedWorkshopSlotData = this._workshopSlotDatas.Item[val_5];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSelectedSlotData(GameUI.WorkshopSlotData workshopSlotData)
        {
            this.selectedWorkshopSlotData = workshopSlotData;
            this.selectedWorkshopSlotDataIndex = this._workshopSlotDatas.IndexOf(item:  workshopSlotData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumScavengers()
        {
            var val_5;
            List.Enumerator<T> val_1 = this._workshopSlotDatas.GetEnumerator();
            val_5 = 0;
            goto label_7;
            label_8:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2._serverGameUIDataModel._masterDomain != 1)
            {
                    if(val_2._serverGameUIDataModel._masterDomain != 3)
            {
                goto label_7;
            }
            
            }
            
            val_5 = 1;
            label_7:
            if(((-1185957352) & 1) != 0)
            {
                goto label_8;
            }
            
            return (int)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSelectedSlotDataIndex()
        {
            return (int)this.selectedWorkshopSlotDataIndex;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopSlotData GetSelectedSlotData()
        {
            return (GameUI.WorkshopSlotData)this.selectedWorkshopSlotData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal AnimatronicEntity.Data.WorkshopEntry.Status GetSelectedSlotDataStatus()
        {
            if((this.selectedWorkshopSlotData.<ServerEntry>k__BackingField) != null)
            {
                    return (Status)this.selectedWorkshopSlotData.<ServerEntry>k__BackingField.status;
            }
            
            return (Status)this.selectedWorkshopSlotData.<ServerEntry>k__BackingField.status;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            if(this._workshopSlotDatas == null)
            {
                    return;
            }
            
            this._workshopSlotDatas.Clear();
            this._workshopSlotDatas = 0;
        }
    
    }

}
