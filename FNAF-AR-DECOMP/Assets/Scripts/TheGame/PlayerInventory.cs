using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerInventory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string Auto = "Auto";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string Common = "Common";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string Uncommon = "Uncommon";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string Rare = "Rare";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, TheGame.PlayerAnimatronicInventory> inventory;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerInventory()
        {
            this.inventory = new System.Collections.Generic.Dictionary<System.String, TheGame.PlayerAnimatronicInventory>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddItem(string animatronicId, Game.TheGame.Data.RewardItem item)
        {
            string val_4;
            if((this.inventory.ContainsKey(key:  animatronicId)) != true)
            {
                    this.inventory.Add(key:  animatronicId, value:  new TheGame.PlayerAnimatronicInventory());
            }
            
            if(item != null)
            {
                    val_4 = item.item;
            }
            else
            {
                    val_4 = 11993091;
            }
            
            this.inventory.Item[animatronicId].AddItem(name:  val_4, amount:  item.amount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetItem(string name, TheGame.PlayerAnimatronicInventory item)
        {
            if((this.inventory.ContainsKey(key:  name)) != false)
            {
                    bool val_2 = this.inventory.Remove(key:  name);
            }
            
            this.inventory.Add(key:  name, value:  item);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetItemCount(string animatronicId, string itemName)
        {
            if((this.inventory.ContainsKey(key:  animatronicId)) == false)
            {
                    return 0;
            }
            
            TheGame.PlayerAnimatronicInventory val_2 = this.inventory.Item[animatronicId];
            this = val_2.inventory;
            if((this.ContainsKey(key:  itemName)) == false)
            {
                    return 0;
            }
            
            if(val_2.inventory != null)
            {
                    return val_2.inventory.Item[itemName];
            }
            
            return val_2.inventory.Item[itemName];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNumControlKeys(string animatronicId)
        {
            return this.GetItemCount(animatronicId:  animatronicId, itemName:  "ControlKeys");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasPlushSuit(string animatronicId)
        {
            return (bool)((this.GetItemCount(animatronicId:  animatronicId, itemName:  "PlushSuit")) > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetTotalTrophies(string animatronicId)
        {
            int val_4 = this.GetItemCount(animatronicId:  animatronicId, itemName:  "Rare");
            int val_5 = (this.GetItemCount(animatronicId:  animatronicId, itemName:  "Common")) + (this.GetItemCount(animatronicId:  animatronicId, itemName:  "Auto"));
            val_5 = val_5 + (this.GetItemCount(animatronicId:  animatronicId, itemName:  "Uncommon"));
            val_4 = val_5 + val_4;
            return (int)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> GetPlushSuits()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.inventory.GetEnumerator();
            do
            {
                label_5:
                if((1689374424 & 1) == 0)
            {
                    return val_1;
            }
            
                UnityEngine.XR.ARSubsystems.TrackableId val_3 = 0.trackableId;
            }
            while((this.HasPlushSuit(animatronicId:  val_3.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, TheGame.PlayerAnimatronicInventory>::get_Key()))) == false);
            
            val_1.Add(item:  val_3.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, TheGame.PlayerAnimatronicInventory>::get_Key()));
            goto label_5;
        }
    
    }

}
