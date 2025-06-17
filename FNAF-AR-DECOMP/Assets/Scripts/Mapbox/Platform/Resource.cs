using UnityEngine;

namespace Mapbox.Platform
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class Resource
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string ApiEndpoint { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_ApiEndpoint(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetUrl(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static string EncodeQueryString(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> values)
        {
            System.Collections.Generic.IEnumerable<TSource> val_12;
            var val_13;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, __f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>> val_15;
            var val_17;
            System.Func<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, __f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>> val_19;
            var val_20;
            System.Func<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String> val_22;
            var val_23;
            System.Func<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String> val_25;
            val_12 = values;
            if(val_12 == null)
            {
                    return (string)System.String.alignConst;
            }
            
            val_13 = null;
            val_13 = null;
            val_15 = Resource.<>c.<>9__3_0;
            if(val_15 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, __f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>> val_1 = null;
                val_15 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, __f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>>(object:  Resource.<>c.__il2cppRuntimeField_static_fields, method:  __f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> Resource.<>c::<EncodeQueryString>b__3_0(System.Collections.Generic.KeyValuePair<string, string> p));
                Resource.<>c.<>9__3_0 = val_15;
            }
            
            val_17 = null;
            val_17 = null;
            val_19 = Resource.<>c.<>9__3_1;
            if(val_19 == null)
            {
                    System.Func<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, __f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>> val_3 = null;
                val_19 = val_3;
                val_3 = new System.Func<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, __f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>>(object:  Resource.<>c.__il2cppRuntimeField_static_fields, method:  __f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String> Resource.<>c::<EncodeQueryString>b__3_1(<>f__AnonymousType0<System.Collections.Generic.KeyValuePair<string, string>, string> <>h__TransparentIdentifier0));
                Resource.<>c.<>9__3_1 = val_19;
            }
            
            val_20 = null;
            val_20 = null;
            val_22 = Resource.<>c.<>9__3_2;
            if(val_22 == null)
            {
                    System.Func<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String> val_5 = null;
                val_22 = val_5;
                val_5 = new System.Func<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String>(object:  Resource.<>c.__il2cppRuntimeField_static_fields, method:  System.String Resource.<>c::<EncodeQueryString>b__3_2(<>f__AnonymousType1<<>f__AnonymousType0<System.Collections.Generic.KeyValuePair<string, string>, string>, string> <>h__TransparentIdentifier1));
                Resource.<>c.<>9__3_2 = val_22;
            }
            
            val_23 = null;
            val_23 = null;
            val_25 = Resource.<>c.<>9__3_3;
            if(val_25 == null)
            {
                    System.Func<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String> val_7 = null;
                val_25 = val_7;
                val_7 = new System.Func<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String>(object:  Resource.<>c.__il2cppRuntimeField_static_fields, method:  System.String Resource.<>c::<EncodeQueryString>b__3_3(<>f__AnonymousType1<<>f__AnonymousType0<System.Collections.Generic.KeyValuePair<string, string>, string>, string> <>h__TransparentIdentifier1));
                Resource.<>c.<>9__3_3 = val_25;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_8 = System.Linq.Enumerable.Select<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String>(source:  System.Linq.Enumerable.OrderBy<__f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>, System.String>(source:  System.Linq.Enumerable.Select<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, __f__AnonymousType1____h__TransparentIdentifier0_j__TPar, _v_j__TPar_<__f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>, System.String>>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.String>, __f__AnonymousType0__p_j__TPar, _k_j__TPar_<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>>(source:  val_12, selector:  val_1), selector:  val_3), keySelector:  val_5), selector:  val_7);
            val_12 = val_8;
            if((System.Linq.Enumerable.Count<System.String>(source:  val_8)) == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            return "?"("?") + System.String.Join(separator:  "&", value:  System.Linq.Enumerable.ToArray<System.String>(source:  val_12))(System.String.Join(separator:  "&", value:  System.Linq.Enumerable.ToArray<System.String>(source:  val_12)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static string GetUrlQueryFromArray<U>(U[] items, string separator = ",")
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_2 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 48 + 294];
                val_2 = __RuntimeMethodHiddenParam + 48 + 294;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
            val_3 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
            if(val_3 != 0)
            {
                    return System.String.Join(separator:  separator, value:  System.Linq.Enumerable.ToArray<System.String>(source:  items));
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_4 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_4 & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48 + 294];
                val_4 = __RuntimeMethodHiddenParam + 48 + 294;
            }
            
            val_5 = mem[__RuntimeMethodHiddenParam + 48];
            val_5 = __RuntimeMethodHiddenParam + 48;
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 48];
                val_5 = __RuntimeMethodHiddenParam + 48;
            }
            
            val_3 = __RuntimeMethodHiddenParam + 48 + 16;
            mem2[0] = val_3;
            return System.String.Join(separator:  separator, value:  System.Linq.Enumerable.ToArray<System.String>(source:  items));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Resource()
        {
        
        }
    
    }

}
