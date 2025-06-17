using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRFIListExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T Random<T>(System.Collections.Generic.IList<T> list)
        {
            var val_7;
            var val_9;
            var val_11;
            var val_12;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = 0;
            val_9 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8];
            val_9 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8;
            if(list != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                val_9 = __RuntimeMethodHiddenParam + 48;
                val_7 = 0;
                val_11 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8];
                val_11 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8;
                if(list == 1)
            {
                    val_12 = 0;
            }
            else
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_11 = __RuntimeMethodHiddenParam + 48;
                val_7 = 0;
                val_12 = UnityEngine.Random.Range(min:  0, max:  list);
            }
            
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_7 = 0;
            }
            else
            {
                    System.IndexOutOfRangeException val_6 = new System.IndexOutOfRangeException(message:  "List needs at least one entry to call Random()");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T RandomOrDefault<T>(System.Collections.Generic.IList<T> list)
        {
            System.Collections.Generic.IList<T> val_7 = list;
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(val_7 == null)
            {
                    return 0;
            }
            
            val_7 = ???;
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T PopLast<T>(System.Collections.Generic.IList<T> list)
        {
            var val_8;
            var val_10;
            var val_13;
            var val_14;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = 0;
            val_10 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8];
            val_10 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8;
            if(list != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_10 = __RuntimeMethodHiddenParam + 48;
                val_8 = 0;
                System.Collections.Generic.IList<T> val_10 = list;
                val_10 = val_10 - 1;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_8 = 0;
                val_13 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8];
                val_13 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8;
                val_14 = val_10;
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = __RuntimeMethodHiddenParam + 48;
                val_13 = 0;
                System.Collections.Generic.IList<T> val_5 = list - 1;
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_13 = 4;
                return (Row)list;
            }
            
            System.InvalidOperationException val_7 = new System.InvalidOperationException();
        }
    
    }

}
