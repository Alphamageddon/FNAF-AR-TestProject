using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceStatusDisplay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect _scrollRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplay _deviceDisplayPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory> _categoriesToDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplayDialog _dialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.DeviceDisplay> _deviceList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Awake()
        {
            System.Action val_7;
            this._masterDomain = Master.MasterDomain.GetDomain();
            val_7 = System.Delegate.Combine(a:  val_1.devicesDomain.AllPlayerDevices.OnDataUpdated, b:  new System.Action(object:  this, method:  public System.Void GameUI.DeviceStatusDisplay::OnDeviceDataUpdated()));
            if(val_1.devicesDomain.AllPlayerDevices == null)
            {
                goto label_4;
            }
            
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_7 == null)
            {
                goto label_8;
            }
            
            label_5:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_8:
            val_1.devicesDomain.AllPlayerDevices.OnDataUpdated = val_7;
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.DeviceStatusDisplay::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            this._dialog.Initialize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.RemoveAllDevices();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
            this.RemoveAllDevices();
            this.AddDevicesByCategory();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateActiveDevices()
        {
            this.RemoveAllDevices();
            this.AddDevicesByCategory();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveAllDevices()
        {
            var val_3;
            var val_10;
            List.Enumerator<T> val_1 = this._deviceList.GetEnumerator();
            label_8:
            if(((-1215202720) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GameUI.DeviceDisplay> val_5 = new System.Action<GameUI.DeviceDisplay>(object:  this, method:  System.Void GameUI.DeviceStatusDisplay::ExpireDevice(GameUI.DeviceDisplay deviceDisplay));
            if(((System.Delegate.Remove(source:  X21, value:  null)) != null) && (null != null))
            {
                    val_10 = 0;
            }
            
            mem2[0] = val_10;
            UnityEngine.Object.Destroy(obj:  val_3.emailUIDataHandler.gameObject);
            goto label_8;
            label_2:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524866480736});
            this._deviceList.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddDevicesByCategory()
        {
            var val_16;
            DeviceCategory val_17;
            Game.TheGame.Data.DeviceEntry val_18;
            UnityEngine.Sprite val_19;
            UnityEngine.Sprite val_20;
            val_16 = 0;
            goto label_1;
            label_21:
            System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> val_2 = this._masterDomain.devicesDomain.AllPlayerDevices.GetEntriesForType(type:  this._categoriesToDisplay.Item[0]);
            if(val_2.Count != 1)
            {
                goto label_7;
            }
            
            Game.TheGame.Data.DeviceEntry val_7 = val_2.Item[0];
            val_17 = this.GetIconForLure(id:  val_7.deviceConfigId);
            val_18 = val_2.Item[0];
            val_19 = this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  this._categoriesToDisplay.Item[0]);
            val_20 = val_17;
            goto label_14;
            label_7:
            if(val_2.Count < 2)
            {
                goto label_16;
            }
            
            val_17 = this._categoriesToDisplay.Item[0];
            UnityEngine.Sprite val_13 = this._masterDomain.DeviceConfigs.GetStackSpriteForDeviceCategory(category:  val_17);
            val_18 = val_13.GetDeviceWithLongestExpiration(deviceEntries:  val_2);
            val_19 = val_13;
            val_20 = 0;
            label_14:
            this.AddDevice(entry:  val_18, icon:  val_19, subIcon:  val_20);
            label_16:
            val_16 = 1;
            label_1:
            if(val_16 < this._categoriesToDisplay.Count)
            {
                goto label_21;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.DeviceEntry GetDeviceWithLongestExpiration(System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> deviceEntries)
        {
            var val_5;
            var val_6;
            val_5 = deviceEntries.Item[0];
            val_6 = 1;
            goto label_2;
            label_11:
            Game.TheGame.Data.DeviceEntry val_2 = deviceEntries.Item[1];
            if(val_2.deviceState.expirationTimeStamp > val_1.deviceState.expirationTimeStamp)
            {
                    val_5 = deviceEntries.Item[1];
            }
            
            val_6 = 2;
            label_2:
            if(val_6 < deviceEntries.Count)
            {
                goto label_11;
            }
            
            return (Game.TheGame.Data.DeviceEntry)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddDevice(Game.TheGame.Data.DeviceEntry entry, UnityEngine.Sprite icon, UnityEngine.Sprite subIcon)
        {
            System.Action<GameUI.DeviceDisplay> val_7;
            GameUI.DeviceDisplay val_2 = UnityEngine.Object.Instantiate<GameUI.DeviceDisplay>(original:  this._deviceDisplayPrefab, parent:  this._scrollRect.content);
            System.Action<Game.TheGame.Data.DeviceEntry> val_3 = new System.Action<Game.TheGame.Data.DeviceEntry>(object:  this, method:  public System.Void GameUI.DeviceStatusDisplay::OnDeviceClicked(Game.TheGame.Data.DeviceEntry entry));
            if(val_2 != null)
            {
                    val_2.InitializeDevice(entry:  entry, icon:  icon, subIcon:  subIcon, callback:  val_3);
            }
            else
            {
                    val_2.InitializeDevice(entry:  entry, icon:  icon, subIcon:  subIcon, callback:  val_3);
            }
            
            val_7 = System.Delegate.Combine(a:  val_2.Expired, b:  new System.Action<GameUI.DeviceDisplay>(object:  this, method:  System.Void GameUI.DeviceStatusDisplay::ExpireDevice(GameUI.DeviceDisplay deviceDisplay)));
            if(val_2 == null)
            {
                goto label_6;
            }
            
            if(val_7 != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_7 == null)
            {
                goto label_10;
            }
            
            label_7:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_10:
            val_2.Expired = val_7;
            this._deviceList.Add(item:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Sprite GetIconForLure(string id)
        {
            string val_14;
            Game.AssetManagement.Icons.IIconLookup val_15;
            var val_17;
            Game.ItemDefinition.Data.DataDefinitions.DeviceData val_2 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  id);
            if(val_2.LureData == null)
            {
                    return 0;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_2.LureData.AnimatronicLured)) != false)
            {
                    return 0;
            }
            
            if((this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  val_2.LureData.AnimatronicLured)) == null)
            {
                goto label_11;
            }
            
            val_14 = val_5.PortraitIconName;
            if(val_14 != null)
            {
                goto label_12;
            }
            
            label_11:
            val_14 = System.String.alignConst;
            label_12:
            val_15 = this._iconLookup;
            if((System.String.IsNullOrWhiteSpace(value:  val_14)) != false)
            {
                    var val_8 = 0;
                val_17 = 1152921505280790536;
                val_8 = val_8 + 1;
                val_17 = 1152921505280790552;
            }
            else
            {
                    var val_9 = 0;
                val_17 = 1152921505280790536;
                val_9 = val_9 + 1;
                return val_15.GetIcon(group:  3, name:  val_14);
            }
            
            val_14 = ???;
            val_15 = ???;
            return val_15.GetDefaultIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDeviceDataUpdated()
        {
            this.RemoveAllDevices();
            this.AddDevicesByCategory();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDeviceClicked(Game.TheGame.Data.DeviceEntry entry)
        {
            System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> val_3 = this._masterDomain.devicesDomain.AllPlayerDevices.GetEntriesForType(type:  val_2.Type);
            if(val_3.Count == 1)
            {
                    this.ShowDialogForSingleItem(data:  this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  entry.deviceConfigId));
                return;
            }
            
            if(val_3.Count < 2)
            {
                    return;
            }
            
            this.ShowDialogForStackedItems(entries:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowDialogForSingleItem(Game.ItemDefinition.Data.DataDefinitions.DeviceData data)
        {
            this._dialog.SetDataForSingleItem(data:  data, icon:  this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  data.Type));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowDialogForStackedItems(System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> entries)
        {
            var val_16;
            System.Action<GameUI.DeviceDisplay> val_17;
            System.Collections.Generic.List<GameUI.DeviceDisplay> val_1 = new System.Collections.Generic.List<GameUI.DeviceDisplay>();
            val_16 = 0;
            goto label_1;
            label_24:
            Game.TheGame.Data.DeviceEntry val_3 = entries.Item[0];
            Game.ItemDefinition.Data.DataDefinitions.DeviceData val_4 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  val_3.deviceConfigId);
            UnityEngine.Sprite val_6 = this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  val_4.Type);
            Game.TheGame.Data.DeviceEntry val_7 = entries.Item[0];
            UnityEngine.Sprite val_8 = this.GetIconForLure(id:  val_7.deviceConfigId);
            GameUI.DeviceDisplay val_9 = UnityEngine.Object.Instantiate<GameUI.DeviceDisplay>(original:  this._deviceDisplayPrefab);
            Game.TheGame.Data.DeviceEntry val_10 = entries.Item[0];
            System.Action<Game.TheGame.Data.DeviceEntry> val_11 = new System.Action<Game.TheGame.Data.DeviceEntry>(object:  this, method:  public System.Void GameUI.DeviceStatusDisplay::OnDeviceClicked(Game.TheGame.Data.DeviceEntry entry));
            if(val_9 != null)
            {
                    val_9.InitializeDevice(entry:  val_10, icon:  val_6, subIcon:  val_8, callback:  val_11);
            }
            else
            {
                    val_9.InitializeDevice(entry:  val_10, icon:  val_6, subIcon:  val_8, callback:  val_11);
            }
            
            val_17 = System.Delegate.Combine(a:  val_9.Expired, b:  new System.Action<GameUI.DeviceDisplay>(object:  this, method:  System.Void GameUI.DeviceStatusDisplay::ExpireDevice(GameUI.DeviceDisplay deviceDisplay)));
            if(val_9 == null)
            {
                goto label_17;
            }
            
            if(val_17 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_17 == null)
            {
                goto label_21;
            }
            
            label_18:
            if(null != null)
            {
                    val_17 = 0;
            }
            
            label_21:
            val_9.Expired = val_17;
            val_1.Add(item:  val_9);
            val_16 = 1;
            label_1:
            if(val_16 < entries.Count)
            {
                goto label_24;
            }
            
            this._dialog.SetDataForMultipleItems(displays:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExpireDevice(GameUI.DeviceDisplay deviceDisplay)
        {
            GameUI.DeviceDisplay val_7;
            System.Action<GameUI.DeviceDisplay> val_8;
            val_7 = deviceDisplay;
            val_8 = System.Delegate.Remove(source:  deviceDisplay.Expired, value:  new System.Action<GameUI.DeviceDisplay>(object:  this, method:  System.Void GameUI.DeviceStatusDisplay::ExpireDevice(GameUI.DeviceDisplay deviceDisplay)));
            if(val_7 == null)
            {
                goto label_2;
            }
            
            if(val_8 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_8 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_8 = 0;
            }
            
            label_6:
            deviceDisplay.Expired = val_8;
            if((this._deviceList.Contains(item:  val_7)) != false)
            {
                    bool val_5 = this._deviceList.Remove(item:  val_7);
                val_7 = val_7.gameObject;
                UnityEngine.Object.Destroy(obj:  val_7);
                return;
            }
            
            this._dialog.Expire(deviceDisplay:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceStatusDisplay()
        {
            this._deviceList = new System.Collections.Generic.List<GameUI.DeviceDisplay>();
        }
    
    }

}
