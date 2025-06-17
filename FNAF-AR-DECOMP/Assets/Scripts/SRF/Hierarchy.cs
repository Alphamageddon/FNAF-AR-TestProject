using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Hierarchy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly char[] Seperator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.Dictionary<string, UnityEngine.Transform> Cache;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Item { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform get_Item(string key)
        {
            return SRF.Hierarchy.Get(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Transform Get(string key)
        {
            var val_12;
            var val_13;
            UnityEngine.Transform val_14;
            System.Collections.Generic.Dictionary<System.String, UnityEngine.Transform> val_15;
            var val_16;
            UnityEngine.Transform val_17;
            val_12 = null;
            val_12 = null;
            if((SRF.Hierarchy.Cache.TryGetValue(key:  key, value: out  0)) != true)
            {
                    UnityEngine.GameObject val_3 = UnityEngine.GameObject.Find(name:  key);
                if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
            {
                    val_13 = null;
                val_14 = val_3.transform;
                val_13 = null;
                val_14 = val_14;
                val_15 = SRF.Hierarchy.Cache;
                val_15.Add(key:  key, value:  val_14);
            }
            else
            {
                    val_16 = null;
                val_16 = null;
                System.String[] val_6 = key.Split(separator:  SRF.Hierarchy.Seperator, options:  1);
                val_15 = new UnityEngine.GameObject(name:  System.Linq.Enumerable.Last<System.String>(source:  val_6)).transform;
                SRF.Hierarchy.Cache.Add(key:  key, value:  val_15);
                val_17 = val_15;
                if()
            {
                    return val_17;
            }
            
                val_17.parent = System.String.Join(separator:  "/", value:  val_6, startIndex:  0, count:  val_6.Length - 1);
            }
            
            }
            
            val_17 = val_15;
            return val_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Hierarchy()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Hierarchy()
        {
            char[] val_1 = new char[1];
            val_1[0] = '/';
            SRF.Hierarchy.Seperator = val_1;
            SRF.Hierarchy.Cache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Transform>();
        }
    
    }

}
