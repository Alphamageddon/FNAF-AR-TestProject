using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopSlotData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsDirty>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsSaving>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Data.WorkshopEntry <ServerEntry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData <ClientEndoskeleton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite Sprite;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsDirty { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSaving { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Data.WorkshopEntry ServerEntry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData ClientEndoskeleton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData DisplayEndoskeleton { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsDirty()
        {
            return (bool)this.<IsDirty>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsDirty(bool value)
        {
            this.<IsDirty>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsSaving()
        {
            return (bool)this.<IsSaving>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsSaving(bool value)
        {
            this.<IsSaving>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Data.WorkshopEntry get_ServerEntry()
        {
            return (AnimatronicEntity.Data.WorkshopEntry)this.<ServerEntry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ServerEntry(AnimatronicEntity.Data.WorkshopEntry value)
        {
            this.<ServerEntry>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData get_ClientEndoskeleton()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData)this.<ClientEndoskeleton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ClientEndoskeleton(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData value)
        {
            this.<ClientEndoskeleton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData get_DisplayEndoskeleton()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData)this.<ClientEndoskeleton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetIconLookup(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
            this.SetIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetItemDefinitions(Game.ItemDefinition.Container.ItemDefinitions itemDefinitions)
        {
            this._itemDefinitions = itemDefinitions;
            this.SetIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateIsDirty()
        {
            bool val_2 = ~(this.<ClientEndoskeleton>k__BackingField.Equals(other:  this.<ServerEntry>k__BackingField.endoskeleton));
            val_2 = val_2 & 1;
            this.<IsDirty>k__BackingField = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateServerWorkshopEntry(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            if((this.<ServerEntry>k__BackingField) == null)
            {
                goto label_0;
            }
            
            if((entry.Equals(other:  this.<ServerEntry>k__BackingField)) == false)
            {
                goto label_2;
            }
            
            return;
            label_0:
            this.Initialize(entry:  entry);
            goto label_3;
            label_2:
            if((this.<IsSaving>k__BackingField) != false)
            {
                    this.UpdateSaving(entry:  entry);
            }
            
            if((this.<IsDirty>k__BackingField) != false)
            {
                    this.UpdateDirty(entry:  entry);
            }
            else
            {
                    this.UpdateClean(entry:  entry);
            }
            
            this.UpdateIsDirty();
            label_3:
            this.SetIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateIcon()
        {
            this.SetIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Save()
        {
            this.<IsSaving>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Initialize(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            this.SaveEntry(entry:  entry);
            this.OverwriteClientEndoskeleton(endoskeleton:  this.<ServerEntry>k__BackingField.endoskeleton);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SaveEntry(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            this.<ServerEntry>k__BackingField = new AnimatronicEntity.Data.WorkshopEntry(entryToCopy:  entry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OverwriteClientEndoskeleton(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton)
        {
            this.<ClientEndoskeleton>k__BackingField = new Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData(data:  endoskeleton);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateClean(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            if((entry.endoskeleton.Equals(other:  this.<ServerEntry>k__BackingField.endoskeleton)) != true)
            {
                    ConsoleLogger.LogError(className:  "WorkshopSlotData", functionName:  "UpdateClean", logString:  "Endoskeleton changed unexpectedly while there are no unsaved changes. Using server version");
            }
            
            this.Initialize(entry:  entry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDirty(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            if((entry.EqualsExceptForEndoskeleton(other:  this.<ServerEntry>k__BackingField)) != false)
            {
                    return;
            }
            
            if((entry.endoskeleton.Equals(other:  this.<ServerEntry>k__BackingField.endoskeleton)) != true)
            {
                    ConsoleLogger.LogError(className:  "WorkshopSlotData", functionName:  "UpdateDirty", logString:  "Endoskeleton changed unexpectedly while there are unsaved changes. Using client version");
            }
            
            this.SaveEntry(entry:  entry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSaving(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            AnimatronicEntity.Data.WorkshopEntry val_3 = this.<ServerEntry>k__BackingField;
            if((entry.EqualsExceptForEndoskeleton(other:  val_3 = this.<ServerEntry>k__BackingField)) == true)
            {
                    return;
            }
            
            val_3 = entry.endoskeleton;
            if((val_3.Equals(other:  this.<ClientEndoskeleton>k__BackingField)) != true)
            {
                    ConsoleLogger.LogError(className:  "WorkshopSlotData", functionName:  "UpdateSaving", logString:  "Endoskeleton change did not match unsaved changes. Using server version");
            }
            
            this.SaveEntry(entry:  entry);
            this.OverwriteClientEndoskeleton(endoskeleton:  this.<ServerEntry>k__BackingField.endoskeleton);
            this.<IsSaving>k__BackingField = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIcon()
        {
            string val_8;
            string val_9;
            var val_12;
            if(this._iconLookup == null)
            {
                    return;
            }
            
            if(this._itemDefinitions == null)
            {
                    return;
            }
            
            if((this.<ServerEntry>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<ClientEndoskeleton>k__BackingField) != null)
            {
                    val_8 = this.<ClientEndoskeleton>k__BackingField.plushSuit;
            }
            else
            {
                    val_8 = this.<ClientEndoskeleton>k__BackingField.plushSuit;
            }
            
            if((0.GetPlushSuitById(id:  val_8)) == null)
            {
                goto label_7;
            }
            
            val_9 = val_1.PortraitIconName;
            if(val_9 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_9 = System.String.alignConst;
            label_8:
            if((System.String.IsNullOrWhiteSpace(value:  val_9)) == false)
            {
                goto label_9;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_14;
            label_9:
            if(this.Sprite != 0)
            {
                    if((System.String.op_Inequality(a:  this.Sprite.name, b:  val_9)) == false)
            {
                    return;
            }
            
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_24;
            label_14:
            val_12 = this._iconLookup;
            UnityEngine.Sprite val_7 = val_12.GetDefaultIcon();
            goto label_25;
            label_24:
            val_12 = this._iconLookup;
            label_25:
            this.Sprite = val_12.GetIcon(group:  3, name:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopSlotData()
        {
        
        }
    
    }

}
