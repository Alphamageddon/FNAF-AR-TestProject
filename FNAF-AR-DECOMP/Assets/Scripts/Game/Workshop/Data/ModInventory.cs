using UnityEngine;

namespace Game.Workshop.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModInventory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> <entries>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> entries { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_entries(System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> value)
        {
            this.<entries>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> get_entries()
        {
            return (System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>)this.<entries>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModInventory()
        {
            this.<entries>k__BackingField = new System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsMod(Game.ItemDefinition.Data.DataDefinitions.ModData modData)
        {
            var val_8;
            var val_9;
            val_8 = modData;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.<entries>k__BackingField.GetEnumerator();
            do
            {
                if(((-956005640) & 1) == 0)
            {
                goto label_13;
            }
            
                UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
                ulong val_3 = val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public Game.ItemDefinition.Data.DataDefinitions.ModData System.Collections.Generic.KeyValuePair<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>::get_Key());
            }
            while((System.String.op_Equality(a:  val_3 + 16, b:  modData.Id)) == false);
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525125677816});
            val_9 = 1;
            return (bool)val_9;
            label_13:
            val_9 = 0;
            return (bool)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddMod(Game.ItemDefinition.Data.DataDefinitions.ModData key, int amount)
        {
            this.<entries>k__BackingField.Add(key:  key, value:  amount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveMod(Game.ItemDefinition.Data.DataDefinitions.ModData key, int amount)
        {
            var val_4;
            System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32> val_16;
            Game.ItemDefinition.Data.DataDefinitions.ModData val_17;
            string val_18;
            val_16 = this;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.<entries>k__BackingField.GetEnumerator();
            val_17 = 0;
            goto label_5;
            label_6:
            UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_4.trackableId;
            ulong val_6 = val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public Game.ItemDefinition.Data.DataDefinitions.ModData System.Collections.Generic.KeyValuePair<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>::get_Key());
            val_18 = mem[val_6 + 16];
            val_18 = val_6 + 16;
            if((System.String.op_Equality(a:  val_18, b:  key.Id)) != false)
            {
                    val_17 = val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public Game.ItemDefinition.Data.DataDefinitions.ModData System.Collections.Generic.KeyValuePair<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>::get_Key());
            }
            
            label_5:
            if(((-955716128) & 1) != 0)
            {
                goto label_6;
            }
            
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525125967328});
            if(val_17 == 0)
            {
                    return;
            }
            
            if((this.<entries>k__BackingField.ContainsKey(key:  val_17)) == false)
            {
                    return;
            }
            
            val_18 = 1152921525125944192;
            val_16 = this.<entries>k__BackingField;
            if((this.<entries>k__BackingField.Item[val_17]) > amount)
            {
                    val_16.set_Item(key:  val_17, value:  val_16.Item[val_17] - amount);
                return;
            }
            
            bool val_15 = val_16.Remove(key:  val_17);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> GetMods()
        {
            System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32> val_1 = new System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.<entries>k__BackingField.GetEnumerator();
            do
            {
                label_5:
                if(((-955563160) & 1) == 0)
            {
                    return val_1;
            }
            
                UnityEngine.XR.ARSubsystems.TrackableId val_3 = 0.trackableId;
            }
            while((-955563176) < 1);
            
            val_1.set_Item(key:  val_3.m_SubId1.System.IConvertible.ToUInt64(provider:  public Game.ItemDefinition.Data.DataDefinitions.ModData System.Collections.Generic.KeyValuePair<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>::get_Key()), value:  -955563176);
            goto label_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, int> GetRandomItems()
        {
            System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32> val_1 = new System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.<entries>k__BackingField.Keys.GetEnumerator();
            do
            {
                if(((-955409160) & 1) == 0)
            {
                    return val_1;
            }
            
                GameUI.EmailUIDataHandler val_4 = 0.emailUIDataHandler;
                Game.ItemDefinition.Data.DataDefinitions.ModData val_9 = val_4;
                int val_5 = this.<entries>k__BackingField.Item[val_9];
            }
            while(val_5 < 1);
            
            val_9 = val_5 + 1;
            int val_6 = UnityEngine.Random.Range(min:  0, max:  val_9);
            if(val_6 >= 1)
            {
                    val_1.Add(key:  val_4, value:  val_6);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateFromLookup(Game.ItemDefinition.Container.ItemDefinitions itemDefinitions)
        {
            Dictionary.Enumerator<TKey, TValue> val_1 = this.<entries>k__BackingField.GetEnumerator();
            do
            {
                label_6:
                if(((-955256200) & 1) == 0)
            {
                    return;
            }
            
                UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
                Game.ItemDefinition.Data.DataDefinitions.ModData val_4 = itemDefinitions.GetModById(id:  val_3 + 16);
            }
            while(val_4 == null);
            
            val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public Game.ItemDefinition.Data.DataDefinitions.ModData System.Collections.Generic.KeyValuePair<Game.ItemDefinition.Data.DataDefinitions.ModData, System.Int32>::get_Key()).Copy(copy:  val_4);
            goto label_6;
        }
    
    }

}
