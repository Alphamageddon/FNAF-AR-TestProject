using UnityEngine;

namespace Game.TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AllPlayerDevices
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.DeviceActiveData active;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> purchased;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TotalDevicesAvailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action OnDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _tempRemovals;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.TheGame.Data.AllPlayerDevices ConstructEmpty(Game.ItemDefinition.Container.ItemDefinitions itemDefinitions)
        {
            var val_12;
            Game.TheGame.Data.AllPlayerDevices val_1 = new Game.TheGame.Data.AllPlayerDevices();
            .purchased = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            Game.TheGame.Data.DeviceActiveData val_3 = new Game.TheGame.Data.DeviceActiveData();
            if(val_1 != null)
            {
                    val_12 = val_1;
                .active = val_3;
            }
            else
            {
                    val_12 = 16;
                mem[16] = val_3;
            }
            
            mem[1152921525128118224] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            mem[1152921525128118232] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            mem[1152921525128118240] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            mem[1152921525128118248] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            mem[1152921525128118256] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            mem[1152921525128118264] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            mem[1152921525128118272] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            mem[1152921525128118280] = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            ._itemDefinitions = itemDefinitions;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StompValues(Game.TheGame.Data.AllPlayerDevices newData)
        {
            var val_4;
            var val_8;
            var val_9;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = newData.purchased.Keys.GetEnumerator();
            label_7:
            if(((-953300768) & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            this.purchased.set_Item(key:  val_5, value:  newData.purchased.Item[val_5]);
            goto label_7;
            label_4:
            val_8 = 0;
            val_9 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525128382688});
            this.UpdateKeys(current:  this.active.Lure, newData:  newData.active.Lure);
            this.UpdateKeys(current:  this.active.Battery, newData:  newData.active.Battery);
            this.UpdateKeys(current:  this.active.Shocker, newData:  newData.active.Shocker);
            this.UpdateKeys(current:  this.active.Transponder, newData:  newData.active.Transponder);
            this.UpdateKeys(current:  this.active.Scanner, newData:  newData.active.Scanner);
            this.UpdateKeys(current:  this.active.Jammer, newData:  newData.active.Jammer);
            this.UpdateKeys(current:  this.active.Meter, newData:  newData.active.Meter);
            this.UpdateKeys(current:  this.active.HomeInvasion, newData:  newData.active.HomeInvasion);
            this.UpdateTotalDevicesAvailable();
            if(this.OnDataUpdated == null)
            {
                    return;
            }
            
            this.OnDataUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> GetEntriesForType(Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory type)
        {
            System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> val_1 = new System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry>();
            System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry> val_2 = this.GetDictionaryForType(type:  type);
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = val_2.Keys.GetEnumerator();
            label_6:
            if(((-952992136) & 1) == 0)
            {
                goto label_3;
            }
            
            val_1.Add(item:  val_2.Item[0.emailUIDataHandler]);
            goto label_6;
            label_3:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525128691320});
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ActivateDevice(string id)
        {
            string val_17;
            Game.TheGame.Data.DeviceEntry val_18;
            var val_19;
            string val_20;
            val_17 = id;
            if((this.purchased.ContainsKey(key:  val_17)) != false)
            {
                    val_18 = 1152921523077884784;
                if(this.purchased.Item[val_17] >= 1)
            {
                    Game.ItemDefinition.Data.DataDefinitions.DeviceData val_3 = this._itemDefinitions.GetDeviceById(id:  val_17);
                if(val_3 != null)
            {
                    if(this.purchased != null)
            {
                    val_19 = this.purchased.Item[val_17];
            }
            else
            {
                    val_19 = 0.Item[val_17];
            }
            
                this.purchased.set_Item(key:  val_17, value:  val_19 - 1);
                double val_17 = 1000;
                Game.TheGame.Data.DeviceEntry val_11 = null;
                val_18 = val_11;
                val_11 = new Game.TheGame.Data.DeviceEntry();
                string val_13 = val_17 + "_clientTemp_" + TheGame.ServerTime.GetCurrentTime();
                if(val_18 != null)
            {
                    val_20 = val_18;
                .deviceId = val_13;
            }
            else
            {
                    val_20 = 16;
                mem[16] = val_13;
            }
            
                .deviceConfigId = val_17;
                val_17 = (val_3.GetMaxTime() + (double)TheGame.ServerTime.GetCurrentTime()) * val_17;
                Game.TheGame.Data.DeviceState val_14 = new Game.TheGame.Data.DeviceState();
                if(val_14 != null)
            {
                    .scalar = 0f;
            }
            else
            {
                    mem[16] = 0;
            }
            
                .expirationTimeStamp = val_17;
                .deviceState = val_14;
                val_17 = val_3 + 48;
                mem2[0] = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_17});
                .deviceType = val_3 + 48.ToString();
                if((val_3 + 48) == 0)
            {
                    Systems.Analytics.AnalyticsCalls.FireEvent_ActiveLure(lureId:  val_3.Id);
            }
            
                this.GetDictionaryForType(type:  val_3.Type).Add(key:  val_20, value:  val_11);
            }
            
            }
            
            }
            
            if(this.OnDataUpdated == null)
            {
                    return;
            }
            
            this.OnDataUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> GetDictionaryForType(Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory type)
        {
            if(type > 7)
            {
                    return 0;
            }
            
            var val_4 = 52949584 + (type) << 2;
            val_4 = val_4 + 52949584;
            goto (52949584 + (type) << 2 + 52949584);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateTotalDevicesAvailable()
        {
            var val_7 = this;
            this.TotalDevicesAvailable = 0;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.purchased.Keys.GetEnumerator();
            goto label_5;
            label_6:
            if(this.purchased.Item[0.emailUIDataHandler] >= 1)
            {
                    int val_7 = this.TotalDevicesAvailable;
                val_7 = val_7 + 1;
                this.TotalDevicesAvailable = val_7;
            }
            
            label_5:
            if(((-952458392) & 1) != 0)
            {
                goto label_6;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525129225064});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetPurchasedCount(string id)
        {
            if((this.purchased.ContainsKey(key:  id)) == false)
            {
                    return 0;
            }
            
            if(this.purchased != null)
            {
                    return this.purchased.Item[id];
            }
            
            return this.purchased.Item[id];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetTotalLures()
        {
            var val_8;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.purchased.Keys.GetEnumerator();
            val_8 = 0;
            goto label_6;
            label_8:
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            Game.ItemDefinition.Data.DataDefinitions.DeviceData val_4 = this._itemDefinitions.GetDeviceById(id:  val_3);
            if(val_4.Type == 0)
            {
                    val_8 = this.purchased.Item[val_3] + val_8;
            }
            
            label_6:
            if(((-952156584) & 1) != 0)
            {
                goto label_8;
            }
            
            return (int)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateKeys(System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> current, System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> newData)
        {
            var val_4;
            var val_17;
            var val_18;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = newData.Keys.GetEnumerator();
            label_6:
            if(((-951959616) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            current.set_Item(key:  val_5, value:  newData.Item[val_5]);
            goto label_6;
            label_3:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525129723840});
            this._tempRemovals.Clear();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_10 = current.Keys.GetEnumerator();
            val_17 = 0;
            goto label_17;
            label_19:
            GameUI.EmailUIDataHandler val_11 = val_4.emailUIDataHandler;
            if((newData.ContainsKey(key:  val_11)) != true)
            {
                    this._tempRemovals.Add(item:  val_11);
                val_17 = 1;
            }
            
            label_17:
            if(((-951959616) & 1) != 0)
            {
                goto label_19;
            }
            
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525129723840});
            val_18 = 0;
            goto label_26;
            label_29:
            bool val_16 = current.Remove(key:  val_11.Item[0]);
            val_18 = 1;
            label_26:
            if(val_18 < val_17)
            {
                goto label_29;
            }
            
            this._tempRemovals.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumActive()
        {
            int val_8 = this.active.HomeInvasion.Count;
            int val_9 = this.active.Battery.Count + this.active.Lure.Count;
            val_9 = val_9 + this.active.Shocker.Count;
            val_9 = val_9 + this.active.Transponder.Count;
            val_9 = val_9 + this.active.Scanner.Count;
            val_9 = val_9 + this.active.Jammer.Count;
            val_9 = val_9 + this.active.Meter.Count;
            val_8 = val_9 + val_8;
            return (int)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetActiveDeviceName(int index)
        {
            int val_17;
            var val_18;
            System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry> val_19;
            val_17 = index;
            if(this.active.Lure.Count > val_17)
            {
                    val_18 = 1152921525128655872;
                return (string)new System.Collections.Generic.List<System.String>(collection:  val_19.Keys).Item[val_17];
            }
            
            val_19 = this.active.Battery;
            val_17 = val_17 - this.active.Lure.Count;
            if(val_17 < this.active.Battery.Count)
            {
                goto label_26;
            }
            
            val_19 = this.active.Shocker;
            val_17 = val_17 - val_19.Count;
            if(val_17 < this.active.Shocker.Count)
            {
                goto label_26;
            }
            
            val_19 = this.active.Transponder;
            val_17 = val_17 - val_19.Count;
            if(val_17 < this.active.Transponder.Count)
            {
                goto label_26;
            }
            
            val_19 = this.active.Scanner;
            val_17 = val_17 - val_19.Count;
            if(val_17 < this.active.Scanner.Count)
            {
                goto label_26;
            }
            
            val_19 = this.active.Jammer;
            val_17 = val_17 - val_19.Count;
            if(val_17 >= this.active.Jammer.Count)
            {
                goto label_31;
            }
            
            label_26:
            val_18 = 1152921525128655872;
            return (string)new System.Collections.Generic.List<System.String>(collection:  val_19.Keys).Item[val_17];
            label_31:
            val_17 = val_17 - val_19.Count;
            if(val_17 >= this.active.Meter.Count)
            {
                    return (string)new System.Collections.Generic.List<System.String>(collection:  val_19.Keys).Item[val_17];
            }
            
            if(this.active.Meter != null)
            {
                    return (string)new System.Collections.Generic.List<System.String>(collection:  val_19.Keys).Item[val_17];
            }
            
            return (string)new System.Collections.Generic.List<System.String>(collection:  val_19.Keys).Item[val_17];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AllPlayerDevices()
        {
            this._tempRemovals = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
