using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DebugUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LogMethodCall(System.Reflection.MethodBase method, object[] values)
        {
            var val_6;
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder().AppendFormat(format:  "Method call: {0}(", arg0:  method);
            val_6 = 0;
            goto label_4;
            label_13:
            long val_7 = 0;
            object val_6 = values[val_7];
            val_7 = (val_6 == 0) ? "null" : (val_6);
            System.Text.StringBuilder val_3 = val_2.AppendFormat(format:  "{0}: {1}", arg0:  System.Reflection.MethodBase.__il2cppRuntimeField_byval_arg, arg1:  val_7);
            val_6 = val_6 - 1;
            if(val_6 < val_6)
            {
                    System.Text.StringBuilder val_4 = val_2.Append(value:  ", ");
            }
            
            val_6 = 1;
            label_4:
            if(val_6 < val_6)
            {
                goto label_13;
            }
            
            System.Text.StringBuilder val_5 = val_2.Append(value:  ")");
            UnityEngine.Debug.Log(message:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void TraceMethodCall()
        {
            var val_2;
            new System.Exception() = new System.Exception(message:  "THIS EXCEPTION IS HARMLESS. TRACING METHOD CALL.");
            val_2 = new System.Exception();
            if(0 == 1)
            {
                    if((null & 1) != 0)
            {
                    UnityEngine.Debug.LogException(exception:  1152921504618721280);
                return;
            }
            
                mem[8] = null;
                val_2 = 8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ToDebugString<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dictionary)
        {
            var val_17;
            var val_19;
            string val_20;
            var val_22;
            var val_25;
            var val_27;
            var val_29;
            var val_30;
            string val_32;
            if(dictionary != null)
            {
                    val_17 = mem[__RuntimeMethodHiddenParam + 48];
                val_17 = __RuntimeMethodHiddenParam + 48;
                var val_18 = 0;
                val_18 = val_18 + 1;
            }
            else
            {
                    val_19 = "null";
                return (string)val_19;
            }
            
            if(dictionary != null)
            {
                    System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
                val_20 = "{";
                System.Text.StringBuilder val_3 = val_2.Append(value:  val_20);
                var val_19 = 0;
                val_19 = val_19 + 1;
                val_20 = __RuntimeMethodHiddenParam + 48 + 8;
            }
            else
            {
                    val_19 = "{}";
                return (string)val_19;
            }
            
            val_22 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(dictionary, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 2) + 8];
            val_22 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(dictionary, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 2) + 8;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_22 = __RuntimeMethodHiddenParam + 48 + 16;
            label_43:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_25 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(dictionary.MoveNext() == false)
            {
                goto label_26;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_25 = __RuntimeMethodHiddenParam + 48 + 24;
            System.Text.StringBuilder val_9 = val_2.Append(value:  "{");
            System.Text.StringBuilder val_10 = val_2.Append(value:  dictionary);
            val_27 = 0;
            System.Text.StringBuilder val_11 = val_2.Append(value:  "=");
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_27 = 0;
            System.Text.StringBuilder val_13 = val_2.Append(value:  dictionary);
            System.Text.StringBuilder val_14 = val_2.Append(value:  "}, ");
            goto label_43;
            label_26:
            val_29 = 0;
            val_30 = 150;
            if(dictionary == null)
            {
                
            }
            else
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                dictionary.Dispose();
            }
            
            if(val_2 != null)
            {
                    val_32 = "}";
                System.Text.StringBuilder val_16 = val_2.Append(value:  val_32);
            }
            else
            {
                    val_32 = "}";
                System.Text.StringBuilder val_17 = val_2.Append(value:  val_32);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ToDebugString<T>(System.Collections.Generic.IList<T> list)
        {
            var val_14;
            var val_16;
            string val_17;
            var val_20;
            var val_22;
            var val_23;
            string val_25;
            if(list != null)
            {
                    val_14 = mem[__RuntimeMethodHiddenParam + 48];
                val_14 = __RuntimeMethodHiddenParam + 48;
                var val_15 = 0;
                val_15 = val_15 + 1;
            }
            else
            {
                    val_16 = "null";
                return (string)val_16;
            }
            
            System.Collections.Generic.IList<T> val_2 = list;
            if(val_2 == null)
            {
                goto label_8;
            }
            
            val_2 = new System.Text.StringBuilder();
            if(val_2 == null)
            {
                goto label_9;
            }
            
            System.Text.StringBuilder val_3 = val_2.Append(value:  "[");
            goto label_10;
            label_8:
            val_16 = "[]";
            return (string)val_16;
            label_9:
            System.Text.StringBuilder val_4 = val_2.Append(value:  "[");
            label_10:
            val_17 = "\n";
            System.Text.StringBuilder val_5 = val_2.Append(value:  val_17);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = __RuntimeMethodHiddenParam + 48 + 8;
            label_30:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_20 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(list.MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_20 = __RuntimeMethodHiddenParam + 48 + 16;
            System.Text.StringBuilder val_10 = val_2.Append(value:  list);
            System.Text.StringBuilder val_11 = val_2.Append(value:  "\n");
            goto label_30;
            label_21:
            val_22 = 0;
            val_23 = 114;
            if(list == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                list.Dispose();
            }
            
            if(val_2 != null)
            {
                    val_25 = "]";
                System.Text.StringBuilder val_13 = val_2.Append(value:  val_25);
            }
            else
            {
                    val_25 = "]";
                System.Text.StringBuilder val_14 = val_2.Append(value:  val_25);
            }
        
        }
    
    }

}
