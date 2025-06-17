using UnityEngine;

namespace SimpleJson2.Reflection
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ReflectionUtils
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly object[] EmptyObjects;
        
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
            var val_8;
            var val_12;
            var val_13;
            var val_14;
            val_8 = type;
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Collections.Generic.IEnumerator<T> val_2 = val_8.GetEnumerator();
            label_24:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            T val_6 = val_2.Current;
            if(((SimpleJson2.Reflection.ReflectionUtils.IsTypeGeneric(type:  val_6)) == false) || ((System.Type.op_Equality(left:  val_6, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false))
            {
                goto label_24;
            }
            
            val_12 = mem[val_6 + 32];
            val_12 = val_6 + 32;
            val_13 = 0;
            val_14 = 92;
            if(val_2 != null)
            {
                goto label_31;
            }
            
            goto label_42;
            label_12:
            val_13 = 0;
            val_12 = 0;
            val_14 = 83;
            if(val_2 != null)
            {
                goto label_31;
            }
            
            goto label_42;
            label_31:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_2.Dispose();
            label_42:
            if( != 83)
            {
                    if( == 92)
            {
                    return (System.Type);
            }
            
            }
            
            val_8 = val_8;
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
            if((SimpleJson2.Reflection.ReflectionUtils.IsTypeGeneric(type:  val_7)) != false)
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
            var val_3;
            if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) != 0)
            {
                    val_3 = 1;
                return (bool)val_3;
            }
            
            if((type & 1) != 0)
            {
                    return System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            val_3 = 0;
            return (bool)val_3;
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
        public static SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate GetContructor(System.Reflection.ConstructorInfo constructorInfo)
        {
            return SimpleJson2.Reflection.ReflectionUtils.GetConstructorByExpression(constructorInfo:  constructorInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate GetContructor(System.Type type, System.Type[] argsType)
        {
            return SimpleJson2.Reflection.ReflectionUtils.GetConstructorByExpression(type:  type, argsType:  argsType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate GetConstructorByReflection(System.Reflection.ConstructorInfo constructorInfo)
        {
            .constructorInfo = constructorInfo;
            mem[1152921520066271344] = new ReflectionUtils.<>c__DisplayClass25_0();
            mem[1152921520066271352] = System.Object ReflectionUtils.<>c__DisplayClass25_0::<GetConstructorByReflection>b__0(object[] args);
            mem[1152921520066271328] = System.Object ReflectionUtils.<>c__DisplayClass25_0::<GetConstructorByReflection>b__0(object[] args);
            return (ConstructorDelegate)new ReflectionUtils.ConstructorDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate GetConstructorByReflection(System.Type type, System.Type[] argsType)
        {
            System.Reflection.ConstructorInfo val_1 = SimpleJson2.Reflection.ReflectionUtils.GetConstructorInfo(type:  type, argsType:  argsType);
            if((System.Reflection.ConstructorInfo.op_Equality(left:  val_1, right:  0)) == false)
            {
                    return SimpleJson2.Reflection.ReflectionUtils.GetConstructorByReflection(constructorInfo:  val_1);
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate GetConstructorByExpression(System.Reflection.ConstructorInfo constructorInfo)
        {
            var val_12;
            System.Linq.Expressions.ParameterExpression val_3 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "args");
            System.Linq.Expressions.Expression[] val_4 = new System.Linq.Expressions.Expression[-1720170352];
            if(1152921506838341936 < 1)
            {
                goto label_7;
            }
            
            object val_12 = 0;
            label_18:
            val_12 = 0;
            if(val_12 >= null)
            {
                    val_12 = 0;
            }
            
            System.Linq.Expressions.UnaryExpression val_7 = System.Linq.Expressions.Expression.Convert(expression:  System.Linq.Expressions.Expression.ArrayIndex(array:  val_3, index:  System.Linq.Expressions.Expression.Constant(value:  val_12)), type:  System.Reflection.ConstructorInfo.__il2cppRuntimeField_byval_arg);
            if(val_4 == null)
            {
                goto label_12;
            }
            
            if(val_7 != null)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(val_7 == null)
            {
                goto label_16;
            }
            
            label_13:
            label_16:
            val_4[0] = val_7;
            val_12 = val_12 + 1;
            if(val_12 < val_4[0])
            {
                goto label_18;
            }
            
            label_7:
            System.Linq.Expressions.ParameterExpression[] val_9 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_9 == null)
            {
                goto label_21;
            }
            
            if(val_3 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_3 == null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            val_9[0] = val_3;
            mem[1152921520066650064] = System.Linq.Expressions.Expression.Lambda<System.Func<System.Object[], System.Object>>(body:  System.Linq.Expressions.Expression.New(constructor:  constructorInfo, arguments:  val_4), parameters:  val_9).Compile();
            mem[1152921520066695168] = new ReflectionUtils.<>c__DisplayClass27_0();
            mem[1152921520066695176] = System.Object ReflectionUtils.<>c__DisplayClass27_0::<GetConstructorByExpression>b__0(object[] args);
            mem[1152921520066695152] = System.Object ReflectionUtils.<>c__DisplayClass27_0::<GetConstructorByExpression>b__0(object[] args);
            return (ConstructorDelegate)new ReflectionUtils.ConstructorDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate GetConstructorByExpression(System.Type type, System.Type[] argsType)
        {
            System.Reflection.ConstructorInfo val_1 = SimpleJson2.Reflection.ReflectionUtils.GetConstructorInfo(type:  type, argsType:  argsType);
            if((System.Reflection.ConstructorInfo.op_Equality(left:  val_1, right:  0)) == false)
            {
                    return SimpleJson2.Reflection.ReflectionUtils.GetConstructorByExpression(constructorInfo:  val_1);
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.GetDelegate GetGetMethod(System.Reflection.PropertyInfo propertyInfo)
        {
            return SimpleJson2.Reflection.ReflectionUtils.GetGetMethodByExpression(propertyInfo:  propertyInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.GetDelegate GetGetMethod(System.Reflection.FieldInfo fieldInfo)
        {
            return SimpleJson2.Reflection.ReflectionUtils.GetGetMethodByExpression(fieldInfo:  fieldInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.GetDelegate GetGetMethodByReflection(System.Reflection.PropertyInfo propertyInfo)
        {
            .methodInfo = propertyInfo;
            mem[1152921520067275264] = new ReflectionUtils.<>c__DisplayClass31_0();
            mem[1152921520067275272] = System.Object ReflectionUtils.<>c__DisplayClass31_0::<GetGetMethodByReflection>b__0(object source);
            mem[1152921520067275248] = System.Object ReflectionUtils.<>c__DisplayClass31_0::<GetGetMethodByReflection>b__0(object source);
            return (GetDelegate)new ReflectionUtils.GetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.GetDelegate GetGetMethodByReflection(System.Reflection.FieldInfo fieldInfo)
        {
            .fieldInfo = fieldInfo;
            mem[1152921520067412864] = new ReflectionUtils.<>c__DisplayClass32_0();
            mem[1152921520067412872] = System.Object ReflectionUtils.<>c__DisplayClass32_0::<GetGetMethodByReflection>b__0(object source);
            mem[1152921520067412848] = System.Object ReflectionUtils.<>c__DisplayClass32_0::<GetGetMethodByReflection>b__0(object source);
            return (GetDelegate)new ReflectionUtils.GetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.GetDelegate GetGetMethodByExpression(System.Reflection.PropertyInfo propertyInfo)
        {
            System.Linq.Expressions.ParameterExpression val_3 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "instance");
            if((SimpleJson2.Reflection.ReflectionUtils.IsValueType(type:  propertyInfo)) != false)
            {
                    System.Linq.Expressions.UnaryExpression val_5 = System.Linq.Expressions.Expression.Convert(expression:  val_3, type:  propertyInfo);
            }
            
            System.Linq.Expressions.ParameterExpression[] val_10 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_10 == null)
            {
                goto label_18;
            }
            
            if(val_3 != null)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_3 == null)
            {
                goto label_22;
            }
            
            label_19:
            label_22:
            val_10[0] = val_3;
            .compiled = System.Linq.Expressions.Expression.Lambda<System.Func<System.Object, System.Object>>(body:  System.Linq.Expressions.Expression.TypeAs(expression:  System.Linq.Expressions.Expression.Call(instance:  System.Linq.Expressions.Expression.TypeAs(expression:  val_3, type:  propertyInfo), method:  propertyInfo), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), parameters:  val_10).Compile();
            mem[1152921520067634464] = new ReflectionUtils.<>c__DisplayClass33_0();
            mem[1152921520067634472] = System.Object ReflectionUtils.<>c__DisplayClass33_0::<GetGetMethodByExpression>b__0(object source);
            mem[1152921520067634448] = System.Object ReflectionUtils.<>c__DisplayClass33_0::<GetGetMethodByExpression>b__0(object source);
            return (GetDelegate)new ReflectionUtils.GetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.GetDelegate GetGetMethodByExpression(System.Reflection.FieldInfo fieldInfo)
        {
            System.Linq.Expressions.ParameterExpression val_3 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "instance");
            System.Linq.Expressions.ParameterExpression[] val_8 = new System.Linq.Expressions.ParameterExpression[1];
            if(val_8 == null)
            {
                goto label_6;
            }
            
            if(val_3 != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_3 == null)
            {
                goto label_10;
            }
            
            label_7:
            label_10:
            val_8[0] = val_3;
            .compiled = System.Linq.Expressions.Expression.Lambda<GetDelegate>(body:  System.Linq.Expressions.Expression.Convert(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Convert(expression:  val_3, type:  fieldInfo), field:  fieldInfo), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), parameters:  val_8).Compile();
            mem[1152921520067847872] = new ReflectionUtils.<>c__DisplayClass34_0();
            mem[1152921520067847880] = System.Object ReflectionUtils.<>c__DisplayClass34_0::<GetGetMethodByExpression>b__0(object source);
            mem[1152921520067847856] = System.Object ReflectionUtils.<>c__DisplayClass34_0::<GetGetMethodByExpression>b__0(object source);
            return (GetDelegate)new ReflectionUtils.GetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.SetDelegate GetSetMethod(System.Reflection.PropertyInfo propertyInfo)
        {
            return SimpleJson2.Reflection.ReflectionUtils.GetSetMethodByExpression(propertyInfo:  propertyInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.SetDelegate GetSetMethod(System.Reflection.FieldInfo fieldInfo)
        {
            return SimpleJson2.Reflection.ReflectionUtils.GetSetMethodByExpression(fieldInfo:  fieldInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.SetDelegate GetSetMethodByReflection(System.Reflection.PropertyInfo propertyInfo)
        {
            .methodInfo = propertyInfo;
            mem[1152921520068225856] = new ReflectionUtils.<>c__DisplayClass37_0();
            mem[1152921520068225864] = System.Void ReflectionUtils.<>c__DisplayClass37_0::<GetSetMethodByReflection>b__0(object source, object value);
            mem[1152921520068225840] = System.Void ReflectionUtils.<>c__DisplayClass37_0::<GetSetMethodByReflection>b__0(object source, object value);
            return (SetDelegate)new ReflectionUtils.SetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.SetDelegate GetSetMethodByReflection(System.Reflection.FieldInfo fieldInfo)
        {
            .fieldInfo = fieldInfo;
            mem[1152921520068363456] = new ReflectionUtils.<>c__DisplayClass38_0();
            mem[1152921520068363464] = System.Void ReflectionUtils.<>c__DisplayClass38_0::<GetSetMethodByReflection>b__0(object source, object value);
            mem[1152921520068363440] = System.Void ReflectionUtils.<>c__DisplayClass38_0::<GetSetMethodByReflection>b__0(object source, object value);
            return (SetDelegate)new ReflectionUtils.SetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.SetDelegate GetSetMethodByExpression(System.Reflection.PropertyInfo propertyInfo)
        {
            System.Linq.Expressions.ParameterExpression val_3 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "instance");
            System.Linq.Expressions.ParameterExpression val_5 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "value");
            if((SimpleJson2.Reflection.ReflectionUtils.IsValueType(type:  propertyInfo)) != false)
            {
                    System.Linq.Expressions.UnaryExpression val_7 = System.Linq.Expressions.Expression.Convert(expression:  val_3, type:  propertyInfo);
            }
            
            if((SimpleJson2.Reflection.ReflectionUtils.IsValueType(type:  propertyInfo)) != false)
            {
                    System.Linq.Expressions.UnaryExpression val_10 = System.Linq.Expressions.Expression.Convert(expression:  val_5, type:  propertyInfo);
            }
            else
            {
                    System.Linq.Expressions.UnaryExpression val_11 = System.Linq.Expressions.Expression.TypeAs(expression:  val_5, type:  propertyInfo);
            }
            
            System.Linq.Expressions.Expression[] val_12 = new System.Linq.Expressions.Expression[1];
            if(val_12 == null)
            {
                goto label_22;
            }
            
            if(val_11 != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(val_11 == null)
            {
                goto label_26;
            }
            
            label_23:
            label_26:
            val_12[0] = val_11;
            System.Linq.Expressions.ParameterExpression[] val_14 = new System.Linq.Expressions.ParameterExpression[2];
            if(val_14 == null)
            {
                goto label_30;
            }
            
            if(val_3 != null)
            {
                goto label_31;
            }
            
            goto label_34;
            label_30:
            if(val_3 == null)
            {
                goto label_34;
            }
            
            label_31:
            label_34:
            val_14[0] = val_3;
            val_14[1] = val_5;
            .compiled = System.Linq.Expressions.Expression.Lambda<System.Action<System.Object, System.Object>>(body:  System.Linq.Expressions.Expression.Call(instance:  System.Linq.Expressions.Expression.TypeAs(expression:  val_3, type:  propertyInfo), method:  propertyInfo, arguments:  val_12), parameters:  val_14).Compile();
            mem[1152921520068609664] = new ReflectionUtils.<>c__DisplayClass39_0();
            mem[1152921520068609672] = System.Void ReflectionUtils.<>c__DisplayClass39_0::<GetSetMethodByExpression>b__0(object source, object val);
            mem[1152921520068609648] = System.Void ReflectionUtils.<>c__DisplayClass39_0::<GetSetMethodByExpression>b__0(object source, object val);
            return (SetDelegate)new ReflectionUtils.SetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.Reflection.ReflectionUtils.SetDelegate GetSetMethodByExpression(System.Reflection.FieldInfo fieldInfo)
        {
            System.Linq.Expressions.ParameterExpression val_3 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "instance");
            System.Linq.Expressions.ParameterExpression val_5 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "value");
            System.Linq.Expressions.ParameterExpression[] val_10 = new System.Linq.Expressions.ParameterExpression[2];
            if(val_10 == null)
            {
                goto label_9;
            }
            
            if(val_3 != null)
            {
                goto label_10;
            }
            
            goto label_13;
            label_9:
            if(val_3 == null)
            {
                goto label_13;
            }
            
            label_10:
            label_13:
            val_10[0] = val_3;
            val_10[1] = val_5;
            .compiled = System.Linq.Expressions.Expression.Lambda<System.Action<System.Object, System.Object>>(body:  SimpleJson2.Reflection.ReflectionUtils.Assign(left:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Convert(expression:  val_3, type:  fieldInfo), field:  fieldInfo), right:  System.Linq.Expressions.Expression.Convert(expression:  val_5, type:  fieldInfo)), parameters:  val_10).Compile();
            mem[1152921520068837408] = new ReflectionUtils.<>c__DisplayClass40_0();
            mem[1152921520068837416] = System.Void ReflectionUtils.<>c__DisplayClass40_0::<GetSetMethodByExpression>b__0(object source, object val);
            mem[1152921520068837392] = System.Void ReflectionUtils.<>c__DisplayClass40_0::<GetSetMethodByExpression>b__0(object source, object val);
            return (SetDelegate)new ReflectionUtils.SetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Linq.Expressions.BinaryExpression Assign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
        {
            System.Type[] val_2 = new System.Type[1];
            if(val_2 == null)
            {
                goto label_4;
            }
            
            if(left != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(left == null)
            {
                goto label_8;
            }
            
            label_5:
            label_8:
            val_2[0] = left;
            return System.Linq.Expressions.Expression.Add(left:  left, right:  right, method:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetMethod(name:  "Assign"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReflectionUtils()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ReflectionUtils()
        {
            SimpleJson2.Reflection.ReflectionUtils.EmptyObjects = new object[0];
        }
    
    }

}
