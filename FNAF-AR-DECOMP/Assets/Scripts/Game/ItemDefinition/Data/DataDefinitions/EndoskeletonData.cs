using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EndoskeletonData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string cpu;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string plushSuit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numEssence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> mods;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EndoskeletonData()
        {
            this.cpu = "";
            this.plushSuit = "";
            this.mods = new System.Collections.Generic.List<System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EndoskeletonData(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData data)
        {
            var val_6;
            this.cpu = "";
            this.plushSuit = "";
            this.mods = new System.Collections.Generic.List<System.String>();
            if(data != null)
            {
                    this.cpu = data.cpu;
                this.plushSuit = data.plushSuit;
                this.numEssence = data.numEssence;
            }
            else
            {
                    this.cpu = 11993091;
                this.plushSuit = 15026800;
                this.numEssence = 64;
            }
            
            this.EnsureModsUpToIndex(index:  data.mods.Count - 1);
            val_6 = 0;
            goto label_4;
            label_8:
            this.mods.set_Item(index:  0, value:  data.mods.Item[0]);
            val_6 = 1;
            label_4:
            if(val_6 < data.mods.Count)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Equals(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData other)
        {
            string val_4 = this.cpu;
            if((val_4.Equals(value:  other.cpu)) == false)
            {
                    return false;
            }
            
            val_4 = this.plushSuit;
            if((val_4.Equals(value:  other.plushSuit)) == false)
            {
                    return false;
            }
            
            if((this.numEssence.Equals(obj:  other.numEssence)) == false)
            {
                    return false;
            }
            
            return this.AreModsEqual(other:  other.mods);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AreModsEqual(System.Collections.Generic.IReadOnlyList<string> other)
        {
            var val_7;
            var val_9;
            var val_11;
            val_7 = this.mods.Count;
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(val_7 != other.Count)
            {
                goto label_7;
            }
            
            val_7 = 0;
            label_17:
            if(val_7 >= this.mods.Count)
            {
                goto label_9;
            }
            
            val_9 = public System.String System.Collections.Generic.List<System.String>::get_Item(int index);
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_9 = 0;
            val_7 = val_7 + 1;
            if((this.mods.Item[0].Equals(value:  other.Item[0])) == true)
            {
                goto label_17;
            }
            
            label_7:
            val_11 = 0;
            return (bool)val_11;
            label_9:
            val_11 = 1;
            return (bool)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnsureModsUpToIndex(int index)
        {
            System.Collections.Generic.List<System.String> val_6 = this.mods;
            int val_1 = index + 1;
            if(val_6.Count >= val_1)
            {
                    return;
            }
            
            val_6 = this.mods;
            int val_3 = val_6.Count;
            if(val_3 >= val_1)
            {
                    return;
            }
            
            val_6 = "";
            int val_5 = (index + 1) - val_3;
            do
            {
                this.mods.Add(item:  "");
                val_5 = val_5 - 1;
            }
            while(val_5 != 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.cpu != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.cpu == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.cpu;
            val_1[1] = this.plushSuit;
            val_1[2] = this.numEssence;
            val_1[3] = this.PrintMods();
            return (string)System.String.Format(format:  "{{\"cpu\":\"{0}\",\"plushSuit\":\"{1}\",\"numEssence\":{2},\"mods\":{3}}}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string PrintMods()
        {
            int val_9;
            var val_10;
            string val_11;
            val_9 = System.String.alignConst;
            List.Enumerator<T> val_1 = this.mods.GetEnumerator();
            label_3:
            if(((-771991624) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_6 = val_9 + ((System.String.IsNullOrWhiteSpace(value:  val_9)) != true) ? "[" : ","(((System.String.IsNullOrWhiteSpace(value:  val_9)) != true) ? "[" : ",")(val_9 + ((System.String.IsNullOrWhiteSpace(value:  val_9)) != true) ? "[" : ","(((System.String.IsNullOrWhiteSpace(value:  val_9)) != true) ? "[" : ",")) + "\"" + 0.emailUIDataHandler + "\"";
            goto label_3;
            label_2:
            val_10 = 0;
            val_11 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525309691832});
            return (string) + "]";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetModAtIndex(string modId, int index)
        {
            this.EnsureModsUpToIndex(index:  index);
            this.mods.set_Item(index:  index, value:  modId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetModAtIndex(int index)
        {
            if(this.mods.Count <= index)
            {
                    return (string)System.String.alignConst;
            }
            
            System.String.alignConst = this.mods.Item[index];
            return (string)System.String.alignConst;
        }
    
    }

}
