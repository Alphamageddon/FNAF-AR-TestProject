using UnityEngine;

namespace com.illumix.IntVector3
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntVector3Cache
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool NO_CACHE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<int, com.illumix.IntVector3.IntVector3>>> coordCache;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntVector3Cache()
        {
            this.coordCache = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, com.illumix.IntVector3.IntVector3>>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 GenerateIntVector(int x, int y, int z)
        {
            int val_13;
            var val_14;
            var val_15;
            var val_16;
            val_13 = x;
            val_14 = 1152921505150455808;
            val_15 = null;
            val_15 = null;
            if(com.illumix.IntVector3.IntVector3Cache.NO_CACHE != false)
            {
                    com.illumix.IntVector3.IntVector3 val_1 = null;
                val_16 = val_1;
                val_1 = new com.illumix.IntVector3.IntVector3();
                .<Item1>k__BackingField = val_13;
                .<Item2>k__BackingField = y;
                .<Item3>k__BackingField = z;
                return (com.illumix.IntVector3.IntVector3)val_16;
            }
            
            if((this.coordCache.ContainsKey(key:  val_13)) != true)
            {
                    this.coordCache.set_Item(key:  val_13, value:  new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, com.illumix.IntVector3.IntVector3>>());
            }
            
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, com.illumix.IntVector3.IntVector3>> val_4 = this.coordCache.Item[val_13];
            if((val_4.ContainsKey(key:  y)) != true)
            {
                    val_4.set_Item(key:  y, value:  new System.Collections.Generic.Dictionary<System.Int32, com.illumix.IntVector3.IntVector3>());
            }
            
            val_14 = val_4.Item[y];
            if((val_14.ContainsKey(key:  z)) != true)
            {
                    .<Item1>k__BackingField = val_13;
                .<Item2>k__BackingField = y;
                .<Item3>k__BackingField = z;
                val_14.set_Item(key:  z, value:  new com.illumix.IntVector3.IntVector3());
            }
            
            val_13 = this.coordCache.Item[val_13];
            val_16 = val_13.Item[y].Item[z];
            return (com.illumix.IntVector3.IntVector3)val_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IntVector3Cache()
        {
            com.illumix.IntVector3.IntVector3Cache.NO_CACHE = true;
        }
    
    }

}
