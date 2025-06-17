using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectSizeFilter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<string, float> MIN_SIZE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<string, float> MAX_SIZE;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool isSizeAnomaly(string obj, float size)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            if((DefaultNamespace.ObjectSizeFilter.MIN_SIZE.ContainsKey(key:  obj)) == false)
            {
                goto label_4;
            }
            
            val_6 = null;
            val_6 = null;
            if(DefaultNamespace.ObjectSizeFilter.MIN_SIZE.Item[obj] > size)
            {
                goto label_8;
            }
            
            label_4:
            val_7 = null;
            val_7 = null;
            if((DefaultNamespace.ObjectSizeFilter.MAX_SIZE.ContainsKey(key:  obj)) == false)
            {
                goto label_16;
            }
            
            val_8 = null;
            val_8 = null;
            if(DefaultNamespace.ObjectSizeFilter.MAX_SIZE.Item[obj] >= 0)
            {
                goto label_16;
            }
            
            label_8:
            val_9 = 1;
            return (bool)val_9;
            label_16:
            val_9 = 0;
            return (bool)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectSizeFilter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ObjectSizeFilter()
        {
            System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "laptop", value:  0.15f);
            }
            else
            {
                    val_1.Add(key:  "laptop", value:  0.15f);
            }
            
            val_1.Add(key:  "bed", value:  1f);
            val_1.Add(key:  "keyboard", value:  0.15f);
            DefaultNamespace.ObjectSizeFilter.MIN_SIZE = val_1;
            System.Collections.Generic.Dictionary<System.String, System.Single> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
            if(val_2 != null)
            {
                    val_2.Add(key:  "laptop", value:  0.7f);
            }
            else
            {
                    val_2.Add(key:  "laptop", value:  0.7f);
            }
            
            val_2.Add(key:  "cell phone", value:  0.3f);
            if(val_2 != null)
            {
                    val_2.Add(key:  "cup", value:  0.3f);
            }
            else
            {
                    val_2.Add(key:  "cup", value:  0.3f);
            }
            
            val_2.Add(key:  "keyboard", value:  0.5f);
            DefaultNamespace.ObjectSizeFilter.MAX_SIZE = val_2;
        }
    
    }

}
