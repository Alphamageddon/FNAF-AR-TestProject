using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ReflectionUtils
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly object[] EmptyObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object[] _1ObjArray;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type GetTypeInfo(System.Type type)
        {
            return (System.Type)type;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Attribute GetAttribute(System.Reflection.MemberInfo info, System.Type type)
        {
            if((System.Reflection.MemberInfo.op_Equality(left:  info, right:  0)) == true)
            {
                    return 0;
            }
            
            if((System.Type.op_Equality(left:  type, right:  0)) == true)
            {
                    return 0;
            }
            
            if((System.Attribute.IsDefined(element:  info, attributeType:  type)) == false)
            {
                    return 0;
            }
            
            return System.Attribute.GetCustomAttribute(element:  info, attributeType:  type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type GetGenericListElementType(System.Type type)
        {
            System.Type val_10;
            var val_11;
            var val_15;
            var val_16;
            val_10 = type;
            if((System.Type.op_Equality(left:  val_10, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_11 = val_10;
                return (System.Type);
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.Generic.IEnumerator<T> val_4 = val_10.GetEnumerator();
            label_28:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_8 = val_4.Current;
            if(((PlayFab.Json.ReflectionUtils.IsTypeGeneric(type:  val_8)) == false) || ((System.Type.op_Equality(left:  val_8, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false))
            {
                goto label_28;
            }
            
            val_11 = mem[val_8 + 32];
            val_11 = val_8 + 32;
            val_15 = 0;
            val_16 = 112;
            if(val_4 != null)
            {
                goto label_35;
            }
            
            goto label_46;
            label_16:
            val_15 = 0;
            val_11 = 0;
            val_16 = 103;
            if(val_4 != null)
            {
                goto label_35;
            }
            
            goto label_46;
            label_35:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_4.Dispose();
            label_46:
            if( != 103)
            {
                    if( == 112)
            {
                    return (System.Type);
            }
            
            }
            
            val_10 = val_10;
            return (System.Type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Attribute GetAttribute(System.Type objectType, System.Type attributeType)
        {
            if((System.Type.op_Equality(left:  objectType, right:  0)) == true)
            {
                    return 0;
            }
            
            if((System.Type.op_Equality(left:  attributeType, right:  0)) == true)
            {
                    return 0;
            }
            
            if((System.Attribute.IsDefined(element:  objectType, attributeType:  attributeType)) == false)
            {
                    return 0;
            }
            
            return System.Attribute.GetCustomAttribute(element:  objectType, attributeType:  attributeType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type[] GetGenericTypeArguments(System.Type type)
        {
            if(type == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsTypeGeneric(System.Type type)
        {
            var val_1;
            var val_2;
            val_1 = type;
            val_2 = null;
            val_2 = val_1;
            val_1 = ???;
            goto typeof(System.Type).__il2cppRuntimeField_638;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsTypeGenericeCollectionInterface(System.Type type)
        {
            System.Type val_7;
            var val_8;
            val_7 = type;
            if((PlayFab.Json.ReflectionUtils.IsTypeGeneric(type:  val_7)) != false)
            {
                    val_7 = val_7;
                if((System.Type.op_Equality(left:  val_7, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)
            {
                    if((System.Type.op_Equality(left:  val_7, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                    return System.Type.op_Equality(left:  val_7, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            }
            
                val_8 = 1;
                return (bool)val_8;
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAssignableFrom(System.Type type1, System.Type type2)
        {
            var val_1;
            var val_2;
            val_1 = type1;
            val_2 = null;
            val_2 = val_1;
            val_1 = ???;
            goto typeof(System.Type).__il2cppRuntimeField_878;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsTypeDictionary(System.Type type)
        {
            var val_5;
            if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) == 0)
            {
                goto label_4;
            }
            
            label_12:
            val_5 = 1;
            return (bool)val_5;
            label_4:
            if((type & 1) == 0)
            {
                goto label_9;
            }
            
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_12;
            }
            
            return System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            label_9:
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsNullableType(System.Type type)
        {
            if((type & 1) == 0)
            {
                    return false;
            }
            
            return System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object ToNullableType(object obj, System.Type nullableType)
        {
            if(obj == null)
            {
                    return 0;
            }
            
            return System.Convert.ChangeType(value:  obj, conversionType:  System.Nullable.GetUnderlyingType(nullableType:  nullableType), provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsValueType(System.Type type)
        {
            if(type != null)
            {
                    return type.IsValueType;
            }
            
            return type.IsValueType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> GetConstructors(System.Type type)
        {
            if(type != null)
            {
                    return type.GetConstructors();
            }
            
            return type.GetConstructors();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Reflection.ConstructorInfo GetConstructorInfo(System.Type type, System.Type[] argsType)
        {
            var val_9;
            var val_10;
            var val_12;
            var val_13;
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = type.GetConstructors().GetEnumerator();
            goto label_18;
            label_32:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_9 = val_3.Current;
            if(argsType.Length != (val_5 + 24))
            {
                goto label_18;
            }
            
            val_10 = mem[val_5 + 592];
            val_10 = val_5 + 592;
            var val_14 = 0;
            label_26:
            if(val_14 >= (val_5 + 24))
            {
                goto label_20;
            }
            
            if(val_14 >= (val_5 + 24))
            {
                    val_10 = 0;
            }
            
            T val_6 = val_9 + 0;
            val_14 = val_14 + 1;
            if((System.Type.op_Inequality(left:  (val_5 + 0) + 32, right:  argsType[0])) == false)
            {
                goto label_26;
            }
            
            label_18:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_32;
            }
            
            val_12 = 0;
            val_9 = 0;
            val_13 = 121;
            if(val_3 != null)
            {
                goto label_37;
            }
            
            goto label_50;
            label_20:
            val_12 = 0;
            val_13 = 123;
            if(val_3 != null)
            {
                goto label_37;
            }
            
            goto label_50;
            label_37:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.Dispose();
            label_50:
            if( != 121)
            {
                    if( == 123)
            {
                    return (System.Reflection.ConstructorInfo)val_9;
            }
            
            }
            
            val_9 = 0;
            return (System.Reflection.ConstructorInfo)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type type)
        {
            if(type == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type type)
        {
            if(type == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Reflection.MethodInfo GetGetterMethodInfo(System.Reflection.PropertyInfo propertyInfo)
        {
            if(propertyInfo == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Reflection.MethodInfo GetSetterMethodInfo(System.Reflection.PropertyInfo propertyInfo)
        {
            if(propertyInfo == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.ConstructorDelegate GetContructor(System.Reflection.ConstructorInfo constructorInfo)
        {
            return PlayFab.Json.ReflectionUtils.GetConstructorByReflection(constructorInfo:  constructorInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.ConstructorDelegate GetContructor(System.Type type, System.Type[] argsType)
        {
            return PlayFab.Json.ReflectionUtils.GetConstructorByReflection(type:  type, argsType:  argsType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.ConstructorDelegate GetConstructorByReflection(System.Reflection.ConstructorInfo constructorInfo)
        {
            .constructorInfo = constructorInfo;
            mem[1152921525720167712] = new ReflectionUtils.<>c__DisplayClass26_0();
            mem[1152921525720167720] = System.Object ReflectionUtils.<>c__DisplayClass26_0::<GetConstructorByReflection>b__0(object[] args);
            mem[1152921525720167696] = System.Object ReflectionUtils.<>c__DisplayClass26_0::<GetConstructorByReflection>b__0(object[] args);
            return (ConstructorDelegate)new ReflectionUtils.ConstructorDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.ConstructorDelegate GetConstructorByReflection(System.Type type, System.Type[] argsType)
        {
            System.Reflection.ConstructorInfo val_1 = PlayFab.Json.ReflectionUtils.GetConstructorInfo(type:  type, argsType:  argsType);
            if((System.Reflection.ConstructorInfo.op_Equality(left:  val_1, right:  0)) == false)
            {
                    return PlayFab.Json.ReflectionUtils.GetConstructorByReflection(constructorInfo:  val_1);
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.GetDelegate GetGetMethod(System.Reflection.PropertyInfo propertyInfo)
        {
            return PlayFab.Json.ReflectionUtils.GetGetMethodByReflection(propertyInfo:  propertyInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.GetDelegate GetGetMethod(System.Reflection.FieldInfo fieldInfo)
        {
            return PlayFab.Json.ReflectionUtils.GetGetMethodByReflection(fieldInfo:  fieldInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.GetDelegate GetGetMethodByReflection(System.Reflection.PropertyInfo propertyInfo)
        {
            .methodInfo = propertyInfo;
            mem[1152921525720747808] = new ReflectionUtils.<>c__DisplayClass30_0();
            mem[1152921525720747816] = System.Object ReflectionUtils.<>c__DisplayClass30_0::<GetGetMethodByReflection>b__0(object source);
            mem[1152921525720747792] = System.Object ReflectionUtils.<>c__DisplayClass30_0::<GetGetMethodByReflection>b__0(object source);
            return (GetDelegate)new ReflectionUtils.GetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.GetDelegate GetGetMethodByReflection(System.Reflection.FieldInfo fieldInfo)
        {
            .fieldInfo = fieldInfo;
            mem[1152921525720885408] = new ReflectionUtils.<>c__DisplayClass31_0();
            mem[1152921525720885416] = System.Object ReflectionUtils.<>c__DisplayClass31_0::<GetGetMethodByReflection>b__0(object source);
            mem[1152921525720885392] = System.Object ReflectionUtils.<>c__DisplayClass31_0::<GetGetMethodByReflection>b__0(object source);
            return (GetDelegate)new ReflectionUtils.GetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.SetDelegate GetSetMethod(System.Reflection.PropertyInfo propertyInfo)
        {
            return PlayFab.Json.ReflectionUtils.GetSetMethodByReflection(propertyInfo:  propertyInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.SetDelegate GetSetMethod(System.Reflection.FieldInfo fieldInfo)
        {
            return PlayFab.Json.ReflectionUtils.GetSetMethodByReflection(fieldInfo:  fieldInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.SetDelegate GetSetMethodByReflection(System.Reflection.PropertyInfo propertyInfo)
        {
            .methodInfo = propertyInfo;
            mem[1152921525721263392] = new ReflectionUtils.<>c__DisplayClass34_0();
            mem[1152921525721263400] = System.Void ReflectionUtils.<>c__DisplayClass34_0::<GetSetMethodByReflection>b__0(object source, object value);
            mem[1152921525721263376] = System.Void ReflectionUtils.<>c__DisplayClass34_0::<GetSetMethodByReflection>b__0(object source, object value);
            return (SetDelegate)new ReflectionUtils.SetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.ReflectionUtils.SetDelegate GetSetMethodByReflection(System.Reflection.FieldInfo fieldInfo)
        {
            .fieldInfo = fieldInfo;
            mem[1152921525721400992] = new ReflectionUtils.<>c__DisplayClass35_0();
            mem[1152921525721401000] = System.Void ReflectionUtils.<>c__DisplayClass35_0::<GetSetMethodByReflection>b__0(object source, object value);
            mem[1152921525721400976] = System.Void ReflectionUtils.<>c__DisplayClass35_0::<GetSetMethodByReflection>b__0(object source, object value);
            return (SetDelegate)new ReflectionUtils.SetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReflectionUtils()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ReflectionUtils()
        {
            PlayFab.Json.ReflectionUtils.EmptyObjects = new object[0];
        }
    
    }

}
