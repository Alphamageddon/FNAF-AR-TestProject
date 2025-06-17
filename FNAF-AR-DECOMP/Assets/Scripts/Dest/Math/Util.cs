using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Util
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Shuffle<T>(System.Collections.Generic.IList<T> collection)
        {
            var val_8;
            var val_10;
            var val_12;
            val_8 = null;
            val_8 = null;
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(collection < 2)
            {
                    return;
            }
            
            do
            {
                val_10 = 0;
                int val_2 = Dest.Math.Rand.Instance.NextInt(max:  collection);
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_10 = 0;
                val_12 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(collection, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8];
                val_12 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(collection, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8;
                System.Collections.Generic.IList<T> val_4 = collection - 1;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_12 = 0;
                var val_11 = 0;
                val_11 = val_11 + 1;
                var val_12 = 0;
                val_12 = val_12 + 1;
            }
            while(collection > 2);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Shuffle<T>(System.Collections.Generic.IList<T> collection, Dest.Math.Rand rand)
        {
            var val_9;
            var val_11;
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(collection < 2)
            {
                    return;
            }
            
            do
            {
                val_9 = 0;
                int val_2 = rand.NextInt(max:  collection);
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_9 = 0;
                val_11 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(collection, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8];
                val_11 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(collection, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8;
                System.Collections.Generic.IList<T> val_4 = collection - 1;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_11 = 0;
                var val_11 = 0;
                val_11 = val_11 + 1;
                var val_12 = 0;
                val_12 = val_12 + 1;
            }
            while(collection > 2);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Shuffle<T>(T[] collection)
        {
            var val_5;
            int val_6;
            int val_7;
            val_5 = null;
            val_5 = null;
            val_6 = collection.Length;
            if(val_6 < 2)
            {
                    return;
            }
            
            var val_1 = (long)val_6 + 3;
            do
            {
                int val_2 = Dest.Math.Rand.Instance.NextInt(max:  val_6);
                val_7 = collection.Length;
                if(val_2 >= val_7)
            {
                    val_7 = collection.Length;
            }
            
                val_6 = val_6 - 1;
                if(val_6 >= val_7)
            {
                    val_7 = collection.Length;
            }
            
                mem2[0] = null;
                var val_4 = val_1 - 1;
                mem2[0] = collection[(long)val_2];
            }
            while((val_1 - 3) > 2);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Shuffle<T>(T[] collection, Dest.Math.Rand rand)
        {
            int val_5;
            int val_6;
            val_5 = collection.Length;
            if(val_5 < 2)
            {
                    return;
            }
            
            var val_1 = (long)val_5 + 3;
            do
            {
                int val_2 = rand.NextInt(max:  val_5);
                val_6 = collection.Length;
                if(val_2 >= val_6)
            {
                    val_6 = collection.Length;
            }
            
                val_5 = val_5 - 1;
                if(val_5 >= val_6)
            {
                    val_6 = collection.Length;
            }
            
                mem2[0] = null;
                var val_4 = val_1 - 1;
                mem2[0] = collection[(long)val_2];
            }
            while((val_1 - 3) > 2);
        
        }
    
    }

}
