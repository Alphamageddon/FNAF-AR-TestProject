using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DevicesStateUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DevicesStateUIActions deviceStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceCell deviceCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform deviceCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject EmptyDeviceMenuDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.DeviceCell> _deviceCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulateDevices()
        {
            var val_9;
            Game.ItemDefinition.Data.DataDefinitions.DeviceData val_10;
            this.Reset();
            System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData> val_1 = this.GetSortedDeviceList(allDevices:  this._masterDomain.devicesDomain.AllPlayerDevices.purchased);
            val_9 = 0;
            goto label_4;
            label_10:
            if(val_1 != null)
            {
                    val_10 = val_1.Item[0];
            }
            else
            {
                    val_10 = val_1.Item[0];
            }
            
            Game.ItemDefinition.Data.DataDefinitions.DeviceData val_4 = val_1.Item[0];
            this.CreateDeviceCell(data:  val_10, numPurchased:  this._masterDomain.devicesDomain.AllPlayerDevices.purchased.Item[val_4.Id]);
            val_9 = 1;
            label_4:
            if(val_9 < val_1.Count)
            {
                goto label_10;
            }
            
            this.EmptyDeviceMenuDisplay.SetActive(value:  (val_1.Count < 1) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData> GetSortedDeviceList(System.Collections.Generic.Dictionary<string, int> allDevices)
        {
            var val_5;
            var val_13;
            System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData> val_1 = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData>();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = allDevices.Keys.GetEnumerator();
            label_11:
            if(((-1156412784) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            if(allDevices.Item[val_6] < 1)
            {
                goto label_11;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.DeviceData val_9 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  val_6);
            if(val_9 == null)
            {
                goto label_11;
            }
            
            val_1.Add(item:  val_9);
            goto label_11;
            label_3:
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524925270672});
            val_13 = null;
            val_13 = null;
            if((DevicesStateUIView.<>c.<>9__8_0) == null)
            {
                goto label_22;
            }
            
            label_27:
            val_1.Sort(comparison:  DevicesStateUIView.<>c.<>9__8_0);
            return val_1;
            label_22:
            DevicesStateUIView.<>c.<>9__8_0 = new System.Comparison<Game.ItemDefinition.Data.DataDefinitions.DeviceData>(object:  DevicesStateUIView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 DevicesStateUIView.<>c::<GetSortedDeviceList>b__8_0(Game.ItemDefinition.Data.DataDefinitions.DeviceData x, Game.ItemDefinition.Data.DataDefinitions.DeviceData y));
            if(val_1 != null)
            {
                goto label_27;
            }
            
            goto label_27;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateDeviceCell(Game.ItemDefinition.Data.DataDefinitions.DeviceData data, int numPurchased)
        {
            GameUI.DeviceCell val_3 = UnityEngine.Object.Instantiate<GameUI.DeviceCell>(original:  this.deviceCellPrefab, parent:  this.deviceCellParent);
            val_3.SetData(data:  data, num:  numPurchased, icon:  this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  data.Type), subicon:  this.GetLureImage(data:  data), onClicked:  new System.Action<System.String>(object:  this, method:  public System.Void GameUI.DevicesStateUIView::OnDeviceCellClicked(string id)), shouldHaveCancelPanel:  false, onDeactivateClicked:  0);
            this._deviceCells.Add(item:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Sprite GetLureImage(Game.ItemDefinition.Data.DataDefinitions.DeviceData data)
        {
            string val_12;
            Game.AssetManagement.Icons.IIconLookup val_13;
            var val_15;
            if(data.LureData == null)
            {
                    return 0;
            }
            
            if((System.String.IsNullOrEmpty(value:  data.LureData.AnimatronicLured)) != false)
            {
                    return 0;
            }
            
            if((this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  data.LureData.AnimatronicLured)) == null)
            {
                goto label_8;
            }
            
            val_12 = val_3.PortraitIconName;
            if(val_12 != null)
            {
                goto label_9;
            }
            
            label_8:
            val_12 = System.String.alignConst;
            label_9:
            val_13 = this._iconLookup;
            if((System.String.IsNullOrWhiteSpace(value:  val_12)) != false)
            {
                    var val_6 = 0;
                val_15 = 1152921505280790536;
                val_6 = val_6 + 1;
                val_15 = 1152921505280790552;
            }
            else
            {
                    var val_7 = 0;
                val_15 = 1152921505280790536;
                val_7 = val_7 + 1;
                return val_13.GetIcon(group:  3, name:  val_12);
            }
            
            val_12 = ???;
            val_13 = ???;
            return val_13.GetDefaultIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            System.Collections.Generic.List<GameUI.DeviceCell> val_7;
            var val_8;
            val_7 = this._deviceCells;
            if(val_7 == null)
            {
                goto label_1;
            }
            
            val_8 = 0;
            goto label_2;
            label_15:
            if(val_7.Item[0] != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this._deviceCells.Item[0].gameObject);
            }
            else
            {
                    ConsoleLogger.LogError(className:  "DevicesStateUIView", functionName:  "Reset", logString:  "There is a Device entry that is null and it shouldn\'t be.");
            }
            
            val_7 = this._deviceCells;
            val_8 = 1;
            label_2:
            if(val_8 < val_7.Count)
            {
                goto label_15;
            }
            
            this._deviceCells.Clear();
            return;
            label_1:
            this._deviceCells = new System.Collections.Generic.List<GameUI.DeviceCell>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDeviceCellClicked(string id)
        {
            this.deviceStateUIActions.ShowConfirmationDialog(deviceId:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDeviceDataUpdated()
        {
            this.PopulateDevices();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveCell(GameUI.DeviceCell cell)
        {
            bool val_1 = this._deviceCells.Remove(item:  cell);
            UnityEngine.Object.Destroy(obj:  cell.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceCell GetCellForId(string id)
        {
            string val_5;
            var val_6;
            var val_7;
            val_5 = id;
            val_6 = 0;
            goto label_1;
            label_7:
            GameUI.DeviceCell val_1 = this._deviceCells.Item[0];
            if((System.String.op_Equality(a:  val_1._data.Id, b:  val_5)) == true)
            {
                goto label_5;
            }
            
            val_6 = 1;
            label_1:
            if(val_6 < this._deviceCells.Count)
            {
                goto label_7;
            }
            
            val_7 = 0;
            return (GameUI.DeviceCell)val_5.Item[0];
            label_5:
            val_5 = this._deviceCells;
            return (GameUI.DeviceCell)val_5.Item[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            System.Action val_7;
            this._masterDomain = Master.MasterDomain.GetDomain();
            val_7 = System.Delegate.Combine(a:  val_1.devicesDomain.AllPlayerDevices.OnDataUpdated, b:  new System.Action(object:  this, method:  public System.Void GameUI.DevicesStateUIView::OnDeviceDataUpdated()));
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
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.DevicesStateUIView::<Awake>b__16_0(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            this.PopulateDevices();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            System.Delegate val_4 = System.Delegate.Remove(source:  this._masterDomain.devicesDomain.AllPlayerDevices.OnDataUpdated, value:  new System.Action(object:  this, method:  public System.Void GameUI.DevicesStateUIView::OnDeviceDataUpdated()));
            if(this._masterDomain.devicesDomain.AllPlayerDevices == null)
            {
                goto label_4;
            }
            
            if(val_4 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_4 == null)
            {
                goto label_8;
            }
            
            label_5:
            if(null != null)
            {
                    val_4 = 0;
            }
            
            label_8:
            this._masterDomain.devicesDomain.AllPlayerDevices.OnDataUpdated = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToStore()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            val_1.gameUIData.illumixButtonBlackBoard = "Device";
            this._masterDomain.eventExposer.OnUIChangeRequest(obj:  3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DevicesStateUIView()
        {
            this._deviceCells = new System.Collections.Generic.List<GameUI.DeviceCell>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Awake>b__16_0(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
    
    }

}
