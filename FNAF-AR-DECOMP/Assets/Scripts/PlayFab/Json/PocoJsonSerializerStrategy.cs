using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Collections.Generic.IDictionary<System.Type, PlayFab.Json.ReflectionUtils.ConstructorDelegate> ConstructorCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, PlayFab.Json.ReflectionUtils.GetDelegate>> GetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<string, System.Collections.Generic.KeyValuePair<System.Type, PlayFab.Json.ReflectionUtils.SetDelegate>>> SetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly System.Type[] EmptyTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly System.Type[] ArrayConstructorParameterTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string[] Iso8601Format;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PocoJsonSerializerStrategy()
        {
            ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, ConstructorDelegate> val_1 = new ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, ConstructorDelegate>(object:  this, method:  typeof(PlayFab.Json.PocoJsonSerializerStrategy).__il2cppRuntimeField_1B0);
            this.ConstructorCache = new ReflectionUtils.ThreadSafeDictionary<System.Type, ConstructorDelegate>(valueFactory:  null);
            ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, GetDelegate>> val_3 = new ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, GetDelegate>>(object:  this, method:  typeof(PlayFab.Json.PocoJsonSerializerStrategy).__il2cppRuntimeField_1C0);
            this.GetCache = new ReflectionUtils.ThreadSafeDictionary<System.Type, System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, GetDelegate>>(valueFactory:  null);
            ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>> val_5 = new ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>>(object:  this, method:  typeof(PlayFab.Json.PocoJsonSerializerStrategy).__il2cppRuntimeField_1D0);
            this.SetCache = new ReflectionUtils.ThreadSafeDictionary<System.Type, System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>>(valueFactory:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual string MapClrMemberNameToJsonFieldName(System.Reflection.MemberInfo memberInfo)
        {
            var val_5;
            var val_6;
            var val_7;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_5 = 0;
            label_10:
            if(val_5 >= null)
            {
                goto label_5;
            }
            
            val_6 = 0;
            val_5 = val_5 + 1;
            if((System.String.IsNullOrEmpty(value:  11993091)) == true)
            {
                goto label_10;
            }
            
            val_7 = 11993091;
            return (string)val_7;
            label_5:
            val_7 = memberInfo;
            return (string)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void MapClrMemberNameToJsonFieldName(System.Reflection.MemberInfo memberInfo, out string jsonName, out PlayFab.Json.JsonProperty jsonProp)
        {
            var val_5;
            jsonName = memberInfo;
            jsonProp = 0;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_5 = 0;
            if(memberInfo != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual PlayFab.Json.ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(System.Type key)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            if(key.IsArray != false)
            {
                    val_3 = null;
                val_4 = 1152921505288372232;
                return PlayFab.Json.ReflectionUtils.GetContructor(type:  key, argsType:  PlayFab.Json.PocoJsonSerializerStrategy.__il2cppRuntimeField_static_fields);
            }
            
            val_5 = null;
            return PlayFab.Json.ReflectionUtils.GetContructor(type:  key, argsType:  PlayFab.Json.PocoJsonSerializerStrategy.__il2cppRuntimeField_static_fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, PlayFab.Json.ReflectionUtils.GetDelegate> GetterValueFactory(System.Type type)
        {
            var val_22;
            var val_23;
            System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, GetDelegate> val_1 = new System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, GetDelegate>();
            var val_24 = 0;
            val_24 = val_24 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = type.GetEnumerator();
            label_35:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_14;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            T val_7 = val_3.Current;
            if((((val_7 & 1) == 0) || (val_7.IsStatic == true)) || (val_7.IsPublic == false))
            {
                goto label_35;
            }
            
            GetDelegate val_10 = PlayFab.Json.ReflectionUtils.GetGetMethod(propertyInfo:  val_7);
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_1.set_Item(key:  ???, value:  ???);
            goto label_35;
            label_14:
            val_22 = 0;
            val_23 = 91;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_3.Dispose();
            }
            
            if( == 91)
            {
                
            }
            else
            {
                    if( != false)
            {
                    val_22 = 0;
            }
            
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            System.Collections.Generic.IEnumerator<T> val_14 = type.GetEnumerator();
            label_86:
            var val_30 = 0;
            val_30 = val_30 + 1;
            if(val_14.MoveNext() == false)
            {
                goto label_69;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            T val_18 = val_14.Current;
            if((val_18.IsStatic == true) || (val_18.IsPublic == false))
            {
                goto label_86;
            }
            
            GetDelegate val_21 = PlayFab.Json.ReflectionUtils.GetGetMethod(fieldInfo:  val_18);
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_1.set_Item(key:  ???, value:  ???);
            goto label_86;
            label_69:
            if(val_14 == null)
            {
                
            }
            else
            {
                    var val_33 = 0;
                val_33 = val_33 + 1;
                val_14.Dispose();
            }
            
            if( == false)
            {
                    return (System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, GetDelegate>)val_1;
            }
            
            if(171 == 0)
            {
                    return (System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, GetDelegate>)val_1;
            }
            
            if(171 == 171)
            {
                    return (System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, GetDelegate>)val_1;
            }
            
            return (System.Collections.Generic.IDictionary<System.Reflection.MemberInfo, GetDelegate>)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual System.Collections.Generic.IDictionary<string, System.Collections.Generic.KeyValuePair<System.Type, PlayFab.Json.ReflectionUtils.SetDelegate>> SetterValueFactory(System.Type type)
        {
            var val_21;
            var val_22;
            var val_24;
            var val_25;
            var val_29;
            var val_30;
            var val_32;
            val_21 = this;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>> val_1 = null;
            val_22 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>();
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_24 = 1152921504685174784;
            val_25 = type.GetEnumerator();
            goto label_22;
            label_35:
            var val_27 = 0;
            val_27 = val_27 + 1;
            T val_5 = val_25.Current;
            if(((val_5 & 1) != 0) && (val_5.IsStatic != true))
            {
                    if(val_5.IsPublic != false)
            {
                    InternalClipper.IntPoint val_9 = new InternalClipper.IntPoint(X:  val_5, Y:  PlayFab.Json.ReflectionUtils.GetSetMethod(propertyInfo:  val_5));
                var val_28 = 0;
                val_28 = val_28 + 1;
                val_1.set_Item(key:  val_9.X, value:  val_9.Y);
                val_21 = val_21;
            }
            
            }
            
            label_22:
            var val_29 = 0;
            val_29 = val_29 + 1;
            if(val_25.MoveNext() == true)
            {
                goto label_35;
            }
            
            val_29 = 0;
            val_30 = 108;
            if(val_25 != null)
            {
                goto label_36;
            }
            
            goto label_50;
            label_36:
            var val_32 = X23;
            if((X23 + 286) == 0)
            {
                goto label_54;
            }
            
            var val_30 = X23 + 176;
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_53:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_52;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (X23 + 286))
            {
                goto label_53;
            }
            
            goto label_54;
            label_52:
            val_32 = val_32 + (((X23 + 176 + 8)) << 4);
            val_32 = val_32 + 296;
            label_54:
            X23.Dispose();
            label_50:
            if( == 108)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            System.Collections.Generic.IEnumerator<T> val_14 = type.GetEnumerator();
            goto label_77;
            label_91:
            var val_34 = 0;
            val_34 = val_34 + 1;
            T val_16 = val_14.Current;
            if((val_16.IsInitOnly != true) && (val_16.IsStatic != true))
            {
                    if(val_16.IsPublic != false)
            {
                    val_25 = val_21;
                InternalClipper.IntPoint val_21 = new InternalClipper.IntPoint(X:  val_16, Y:  PlayFab.Json.ReflectionUtils.GetSetMethod(fieldInfo:  val_16));
                var val_35 = 0;
                val_35 = val_35 + 1;
                val_1.set_Item(key:  val_21.X, value:  val_21.Y);
                val_21 = val_21;
                val_22 = val_22;
                val_24 = 1152921504685174784;
            }
            
            }
            
            label_77:
            var val_36 = 0;
            val_36 = val_36 + 1;
            if(val_14.MoveNext() == true)
            {
                goto label_91;
            }
            
            if(val_14 == null)
            {
                
            }
            else
            {
                    var val_37 = 0;
                val_37 = val_37 + 1;
                type.Dispose();
            }
            
            if( == 0)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>)val_22;
            }
            
            if( == 0)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>)val_22;
            }
            
            if( == 215)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>)val_22;
            }
            
            return (System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>)val_22;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
        {
            if((this & 1) != 0)
            {
                    return true;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual object DeserializeObject(object value, System.Type type)
        {
            System.Type val_129;
            object val_130;
            var val_131;
            var val_132;
            var val_133;
            var val_135;
            var val_136;
            System.String[] val_137;
            var val_138;
            var val_139;
            var val_140;
            var val_141;
            var val_143;
            var val_144;
            var val_145;
            var val_146;
            var val_148;
            var val_149;
            var val_150;
            var val_151;
            var val_154;
            var val_155;
            var val_157;
            var val_161;
            var val_162;
            var val_164;
            var val_169;
            var val_173;
            var val_174;
            var val_175;
            var val_176;
            var val_177;
            var val_178;
            var val_179;
            System.Type val_180;
            var val_181;
            var val_182;
            var val_183;
            var val_185;
            System.Object[] val_186;
            var val_187;
            var val_189;
            var val_193;
            var val_194;
            var val_195;
            var val_196;
            var val_197;
            val_129 = type;
            val_130 = value;
            if((System.Type.op_Equality(left:  val_129, right:  0)) == true)
            {
                goto label_3;
            }
            
            if(val_130 == null)
            {
                goto label_4;
            }
            
            if((val_129 & 1) == 0)
            {
                goto label_6;
            }
            
            label_398:
            val_131 = val_130;
            return (object)val_131;
            label_4:
            val_132 = 0;
            val_133 = 1;
            goto label_8;
            label_6:
            val_133 = 0;
            string val_2 = (null == null) ? (val_130) : 0;
            label_8:
            if(((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false) || ((System.String.IsNullOrEmpty(value:  val_2)) == false))
            {
                goto label_12;
            }
            
            val_135 = null;
            goto label_110;
            label_12:
            if(val_130 == null)
            {
                goto label_14;
            }
            
            if(val_2 == 0)
            {
                goto label_15;
            }
            
            if(val_2.Length == 0)
            {
                goto label_16;
            }
            
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_19;
            }
            
            label_39:
            val_136 = null;
            val_136 = null;
            val_137 = PlayFab.Json.PocoJsonSerializerStrategy.Iso8601Format;
            val_138 = 1152921504617603072;
            System.DateTime val_10 = System.DateTime.ParseExact(s:  val_2, formats:  val_137, provider:  System.Globalization.CultureInfo.InvariantCulture, style:  80);
            val_139 = null;
            goto label_26;
            label_14:
            val_131 = 0;
            return (object)val_131;
            label_15:
            if((val_133 & 1) == 0)
            {
                goto label_28;
            }
            
            goto label_29;
            label_16:
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_32;
            }
            
            val_140 = 0;
            goto label_56;
            label_19:
            if((PlayFab.Json.ReflectionUtils.IsNullableType(type:  val_129)) != false)
            {
                    if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  val_129), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_39;
            }
            
            }
            
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_42;
            }
            
            label_106:
            val_141 = null;
            val_141 = null;
            val_137 = PlayFab.Json.PocoJsonSerializerStrategy.Iso8601Format;
            val_138 = 1152921504617709568;
            System.DateTimeOffset val_20 = System.DateTimeOffset.ParseExact(input:  val_2, formats:  val_137, formatProvider:  System.Globalization.CultureInfo.InvariantCulture, styles:  80);
            val_139 = null;
            label_26:
            val_135 = val_139;
            label_110:
            label_401:
            val_131 = val_20;
            return (object)val_131;
            label_28:
            if(null == null)
            {
                goto label_398;
            }
            
            goto label_50;
            label_32:
            if((PlayFab.Json.ReflectionUtils.IsNullableType(type:  val_129)) == false)
            {
                goto label_53;
            }
            
            val_140 = 0;
            if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  val_129), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_56;
            }
            
            label_53:
            val_140 = val_2;
            label_56:
            if((PlayFab.Json.ReflectionUtils.IsNullableType(type:  val_129)) != true)
            {
                    if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  val_129), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return (object)val_131;
            }
            
            }
            
            if((val_133 & 1) == 0)
            {
                goto label_63;
            }
            
            label_29:
            val_143 = 0;
            val_144 = 0;
            val_145 = 0;
            goto label_64;
            label_63:
            label_50:
            var val_29 = (null == null) ? 1 : 0;
            var val_30 = (null == null) ? 1 : 0;
            var val_31 = (null == null) ? (val_130) : 0;
            label_64:
            System.Type val_32 = System.Nullable.GetUnderlyingType(nullableType:  val_129);
            if((System.Type.op_Inequality(left:  val_32, right:  0)) != false)
            {
                    val_146 = null;
                val_146 = null;
                val_129 = ((PlayFab.Json.PlayFabSimpleJson.NumberTypes.IndexOf(item:  val_32)) == 1) ? (val_129) : (val_32);
            }
            
            val_148 = null;
            val_148 = null;
            if(val_29 != 0)
            {
                    if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_398;
            }
            
            }
            
            if(val_30 == 0)
            {
                goto label_79;
            }
            
            val_149 = 0;
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_398;
            }
            
            label_79:
            if(val_31 == 0)
            {
                goto label_83;
            }
            
            val_149 = 0;
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_398;
            }
            
            label_83:
            var val_43 = (val_31 != 0) ? 1 : 0;
            var val_44 = val_30 | val_29;
            val_43 = val_44 | val_43;
            val_44 = val_43 & (PlayFab.WsaReflectionExtensions.GetTypeInfo(type:  val_129));
            if(val_44 != 1)
            {
                goto label_87;
            }
            
            object val_48 = System.Enum.ToObject(enumType:  val_129, value:  System.Convert.ChangeType(value:  val_130, conversionType:  System.Enum.GetUnderlyingType(enumType:  val_129), provider:  System.Globalization.CultureInfo.InvariantCulture));
            goto label_401;
            label_87:
            val_43 = val_43 & (((PlayFab.Json.PlayFabSimpleJson.NumberTypes.IndexOf(item:  val_129)) != 1) ? 1 : 0);
            if(val_43 != 1)
            {
                goto label_95;
            }
            
            label_177:
            object val_51 = System.Convert.ChangeType(value:  val_130, conversionType:  val_129, provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_401;
            label_42:
            if((PlayFab.Json.ReflectionUtils.IsNullableType(type:  val_129)) != false)
            {
                    if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  val_129), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_106;
            }
            
            }
            
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_109;
            }
            
            goto label_110;
            label_95:
            if(val_130 == null)
            {
                goto label_111;
            }
            
            if((PlayFab.Json.ReflectionUtils.IsTypeDictionary(type:  val_129)) == false)
            {
                goto label_114;
            }
            
            val_150 = mem[val_34 == 1 ? type : val_32 + 24];
            val_150 = val_34 == 1 ? type : val_32 + 24;
            if(val_150 == 0)
            {
                    val_150 = mem[val_34 == 1 ? type : val_32 + 24];
                val_150 = val_34 == 1 ? type : val_32 + 24;
            }
            
            System.Type val_59 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Type[] val_60 = new System.Type[2];
            val_60[0] = val_34 == 1 ? type : val_32 + 32;
            val_60[1] = val_34 == 1 ? type : val_32 + 40;
            var val_144 = 0;
            val_144 = val_144 + 1;
            val_151 = 0;
            goto label_135;
            label_109:
            if((PlayFab.Json.ReflectionUtils.IsNullableType(type:  val_129)) != false)
            {
                    if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  val_129), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_110;
            }
            
            }
            
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_144;
            }
            
            if((System.Uri.IsWellFormedUriString(uriString:  val_2, uriKind:  0)) == false)
            {
                    return (object)val_131;
            }
            
            if((System.Uri.TryCreate(uriString:  val_2, uriKind:  0, result: out  0)) == false)
            {
                    return (object)val_131;
            }
            
            return (object)val_131;
            label_111:
            label_299:
            if(val_130 == null)
            {
                    return (object)val_131;
            }
            
            if(val_129.IsArray == false)
            {
                goto label_308;
            }
            
            var val_145 = 0;
            val_145 = val_145 + 1;
            val_149 = 0;
            goto label_159;
            label_114:
            val_154 = 0;
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_162;
            }
            
            val_155 = 1152921505288421376;
            goto label_395;
            label_144:
            if((System.Type.op_Equality(left:  val_129, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_166;
            }
            
            return (object)val_131;
            label_162:
            var val_146 = 0;
            val_146 = val_146 + 1;
            val_154 = 0;
            goto label_172;
            label_166:
            System.Globalization.CultureInfo val_75 = System.Globalization.CultureInfo.InvariantCulture;
            goto label_177;
            label_135:
            object val_79 = this.ConstructorCache.Item[null].Invoke(args:  System.Array.Empty<System.Object>());
            if(val_79 == null)
            {
                goto label_179;
            }
            
            val_157 = val_79;
            if(val_157 != null)
            {
                goto label_180;
            }
            
            label_179:
            val_157 = 0;
            label_180:
            var val_147 = 0;
            val_147 = val_147 + 1;
            System.Collections.Generic.IEnumerator<T> val_81 = val_130.GetEnumerator();
            label_201:
            var val_148 = 0;
            val_148 = val_148 + 1;
            if(val_81.MoveNext() == false)
            {
                goto label_190;
            }
            
            var val_149 = 0;
            val_149 = val_149 + 1;
            var val_153 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_200;
            }
            
            var val_150 = mem[282584257676847];
            var val_151 = 0;
            val_150 = val_150 + 8;
            label_199:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_198;
            }
            
            val_151 = val_151 + 1;
            val_150 = val_150 + 16;
            if(val_151 < mem[282584257676957])
            {
                goto label_199;
            }
            
            goto label_200;
            label_198:
            var val_152 = val_150;
            val_152 = val_152 + 5;
            val_153 = val_153 + val_152;
            val_161 = val_153 + 296;
            label_200:
            val_157.Add(key:  val_81.Current.emailUIDataHandler, value:  this);
            goto label_201;
            label_172:
            val_162 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            object val_101 = this.ConstructorCache.Item[null].Invoke(args:  System.Array.Empty<System.Object>());
            val_155 = 1152921505288421376;
            var val_154 = 0;
            val_154 = val_154 + 1;
            val_162 = 0;
            TValue val_92 = this.SetCache.Item[null];
            var val_157 = val_92;
            if((val_92 + 286) == 0)
            {
                goto label_212;
            }
            
            var val_155 = val_92 + 176;
            var val_156 = 0;
            val_155 = val_155 + 8;
            label_211:
            if(((val_92 + 176 + 8) + -8) == null)
            {
                goto label_210;
            }
            
            val_156 = val_156 + 1;
            val_155 = val_155 + 16;
            if(val_156 < (val_92 + 286))
            {
                goto label_211;
            }
            
            goto label_212;
            label_210:
            val_157 = val_157 + (((val_92 + 176 + 8)) << 4);
            val_164 = val_157 + 296;
            label_212:
            System.Collections.Generic.IEnumerator<T> val_93 = val_92.GetEnumerator();
            label_230:
            var val_158 = 0;
            val_158 = val_158 + 1;
            if(val_93.MoveNext() == false)
            {
                goto label_218;
            }
            
            var val_159 = 0;
            val_159 = val_159 + 1;
            T val_97 = val_93.Current;
            GameUI.EmailUIDataHandler val_99 = 0.emailUIDataHandler;
            var val_160 = 0;
            val_160 = val_160 + 1;
            if((val_130.TryGetValue(key:  null, value: out  val_101)) == false)
            {
                goto label_230;
            }
            
            GameUI.EmailUIDataHandler val_103 = 0.emailUIDataHandler;
            0.Invoke(source:  val_101, value:  this);
            goto label_230;
            label_159:
            object[] val_106 = new object[1];
            var val_161 = 0;
            val_161 = val_161 + 1;
            val_106[0] = val_130.Count;
            object val_109 = this.ConstructorCache.Item[null].Invoke(args:  val_106);
            if(val_109 == null)
            {
                goto label_240;
            }
            
            val_169 = val_109;
            if(val_169 != null)
            {
                goto label_241;
            }
            
            label_240:
            val_169 = 0;
            label_241:
            var val_162 = 0;
            val_162 = val_162 + 1;
            System.Collections.Generic.IEnumerator<T> val_111 = val_130.GetEnumerator();
            label_263:
            var val_163 = 0;
            val_163 = val_163 + 1;
            if(val_111.MoveNext() == false)
            {
                goto label_251;
            }
            
            var val_164 = 0;
            val_164 = val_164 + 1;
            T val_115 = val_111.Current;
            var val_168 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_262;
            }
            
            var val_165 = mem[282584257676847];
            var val_166 = 0;
            val_165 = val_165 + 8;
            label_261:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_260;
            }
            
            val_166 = val_166 + 1;
            val_165 = val_165 + 16;
            if(val_166 < mem[282584257676957])
            {
                goto label_261;
            }
            
            goto label_262;
            label_260:
            var val_167 = val_165;
            val_167 = val_167 + 1;
            val_168 = val_168 + val_167;
            val_173 = val_168 + 296;
            label_262:
            var val_116 = 0 + 1;
            val_169.set_Item(index:  0, value:  this);
            goto label_263;
            label_190:
            val_174 = 0;
            val_175 = 911;
            if(val_81 != null)
            {
                goto label_264;
            }
            
            goto label_388;
            label_251:
            val_176 = 0;
            val_177 = 1456;
            if(val_111 != null)
            {
                goto label_266;
            }
            
            goto label_302;
            label_218:
            val_178 = 0;
            val_179 = 1461;
            if(val_93 != null)
            {
                goto label_268;
            }
            
            goto label_291;
            label_3:
            val_180 = new System.ArgumentNullException(paramName:  "type");
            goto label_371;
            label_268:
            var val_171 = X24;
            if((X24 + 286) == 0)
            {
                goto label_295;
            }
            
            var val_169 = X24 + 176;
            var val_170 = 0;
            val_169 = val_169 + 8;
            label_294:
            if(((X24 + 176 + 8) + -8) == null)
            {
                goto label_293;
            }
            
            val_170 = val_170 + 1;
            val_169 = val_169 + 16;
            if(val_170 < (X24 + 286))
            {
                goto label_294;
            }
            
            goto label_295;
            label_293:
            val_171 = val_171 + (((X24 + 176 + 8)) << 4);
            val_181 = val_171 + 296;
            label_295:
            X24.Dispose();
            label_291:
            if( != 1461)
            {
                goto label_296;
            }
            
            val_157 = 0;
            goto label_395;
            label_296:
            if( == false)
            {
                goto label_299;
            }
            
            goto label_299;
            label_266:
            var val_174 = X23;
            if((X23 + 286) == 0)
            {
                goto label_306;
            }
            
            var val_172 = X23 + 176;
            var val_173 = 0;
            val_172 = val_172 + 8;
            label_305:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_304;
            }
            
            val_173 = val_173 + 1;
            val_172 = val_172 + 16;
            if(val_173 < (X23 + 286))
            {
                goto label_305;
            }
            
            goto label_306;
            label_304:
            val_174 = val_174 + (((X23 + 176 + 8)) << 4);
            val_182 = val_174 + 296;
            label_306:
            X23.Dispose();
            label_302:
            if( == 1456)
            {
                    return (object)val_131;
            }
            
            label_308:
            if((PlayFab.Json.ReflectionUtils.IsTypeGenericeCollectionInterface(type:  null)) != true)
            {
                    if((PlayFab.Json.ReflectionUtils.IsAssignableFrom(type1:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), type2:  null)) != true)
            {
                    if((System.Type.op_Equality(left:  null, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                    return (object)val_131;
            }
            
            }
            
            }
            
            System.Type val_123 = PlayFab.Json.ReflectionUtils.GetGenericListElementType(type:  null);
            val_183 = 0;
            if((System.Type.op_Inequality(left:  null, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_330;
            }
            
            var val_175 = 0;
            val_175 = val_175 + 1;
            val_183 = 0;
            val_185 = this.ConstructorCache.Item[null];
            if(val_185 == 0)
            {
                goto label_330;
            }
            
            val_186 = System.Array.Empty<System.Object>();
            goto label_344;
            label_330:
            System.Type val_129 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            new System.Type[1][0] = val_123;
            var val_176 = 0;
            val_176 = val_176 + 1;
            val_187 = 0;
            val_185 = this.ConstructorCache.Item[null];
            val_186 = System.Array.Empty<System.Object>();
            label_344:
            object val_134 = val_185.Invoke(args:  val_186);
            if(val_134 == null)
            {
                goto label_345;
            }
            
            val_189 = val_134;
            if(val_189 != null)
            {
                goto label_346;
            }
            
            label_345:
            val_189 = 0;
            label_346:
            var val_177 = 0;
            val_177 = val_177 + 1;
            System.Collections.Generic.IEnumerator<T> val_136 = val_130.GetEnumerator();
            label_367:
            var val_178 = 0;
            val_178 = val_178 + 1;
            if(val_136.MoveNext() == false)
            {
                goto label_356;
            }
            
            var val_179 = 0;
            val_179 = val_179 + 1;
            T val_140 = val_136.Current;
            val_193 = val_123;
            var val_183 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_363;
            }
            
            var val_180 = mem[282584257676847];
            var val_181 = 0;
            val_180 = val_180 + 8;
            label_365:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_364;
            }
            
            val_181 = val_181 + 1;
            val_180 = val_180 + 16;
            if(val_181 < mem[282584257676957])
            {
                goto label_365;
            }
            
            label_363:
            val_193 = 2;
            goto label_366;
            label_364:
            var val_182 = val_180;
            val_182 = val_182 + 2;
            val_183 = val_183 + val_182;
            val_194 = val_183 + 296;
            label_366:
            int val_141 = val_189.Add(value:  this);
            goto label_367;
            label_356:
            val_195 = 0;
            if(val_136 != null)
            {
                goto label_368;
            }
            
            goto label_376;
            label_368:
            var val_186 = ;
            if((val_138 + 286) == 0)
            {
                goto label_380;
            }
            
            var val_184 = val_138 + 176;
            var val_185 = 0;
            val_184 = val_184 + 8;
            label_379:
            if(((val_138 + 176 + 8) + -8) == null)
            {
                goto label_378;
            }
            
            val_185 = val_185 + 1;
            val_184 = val_184 + 16;
            if(val_185 < (val_138 + 286))
            {
                goto label_379;
            }
            
            goto label_380;
            label_378:
            val_186 = val_186 + (((val_138 + 176 + 8)) << 4);
            val_196 = val_186 + 296;
            label_380:
            Dispose();
            label_376:
            if( == false)
            {
                    return (object)val_131;
            }
            
            if(1456 == 0)
            {
                    return (object)val_131;
            }
            
            if(1456 == 1456)
            {
                    return (object)val_131;
            }
            
            return (object)val_131;
            label_264:
            var val_189 = 0;
            if(0 == 0)
            {
                goto label_392;
            }
            
            var val_187 = 0;
            var val_188 = 25769803786;
            label_391:
            if(mem[25769803778] == null)
            {
                goto label_390;
            }
            
            val_187 = val_187 + 1;
            val_188 = val_188 + 16;
            if(val_187 < 0)
            {
                goto label_391;
            }
            
            goto label_392;
            label_390:
            val_189 = val_189 + ((mem[25769803786]) << 4);
            val_197 = val_189 + 296;
            label_392:
            Dispose();
            label_388:
            if( == 911)
            {
                goto label_393;
            }
            
            val_155 = 1152921505288421376;
            if( == false)
            {
                goto label_395;
            }
            
            goto label_395;
            label_393:
            val_155 = 1152921505288421376;
            label_395:
            if((PlayFab.Json.ReflectionUtils.IsNullableType(type:  null)) == false)
            {
                goto label_398;
            }
            
            object val_143 = PlayFab.Json.ReflectionUtils.ToNullableType(obj:  val_130, nullableType:  null);
            goto label_401;
            label_371:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual object SerializeEnum(System.Enum p)
        {
            return (object)System.Convert.ToDouble(value:  p, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual bool TrySerializeKnownTypes(object input, out object output)
        {
            PlayFab.Json.PocoJsonSerializerStrategy val_5;
            var val_6;
            var val_7;
            var val_8;
            if(input == null)
            {
                goto label_7;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                goto label_4;
            }
            
            label_7:
            val_5 = 0;
            val_6 = 0;
            goto label_9;
            label_2:
            System.DateTime val_2 = null.ToUniversalTime();
            val_7 = null;
            val_7 = null;
            System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
            goto label_25;
            label_3:
            val_8 = null;
            val_8 = null;
            System.Globalization.CultureInfo val_4 = System.Globalization.CultureInfo.InvariantCulture;
            goto label_25;
            label_4:
            val_5;
            label_25:
            val_6 = 1;
            label_9:
            output = ;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual bool TrySerializeUnknownTypes(object input, out object output)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_22;
            var val_25;
            var val_28;
            var val_29;
            val_17 = 1152921525717071488;
            val_18 = this;
            if(input == null)
            {
                goto label_1;
            }
            
            output = 0;
            val_19 = input.GetType();
            val_20 = val_19;
            if(val_20 == null)
            {
                    return (bool)val_20;
            }
            
            PlayFab.Json.JsonObject val_2 = null;
            val_16 = val_2;
            val_2 = new PlayFab.Json.JsonObject();
            var val_19 = 0;
            val_19 = val_19 + 1;
            TValue val_4 = this.GetCache.Item[0];
            var val_22 = val_4;
            if((val_4 + 286) == 0)
            {
                goto label_13;
            }
            
            var val_20 = val_4 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_12:
            if(((val_4 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (val_4 + 286))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            val_22 = val_22 + (((val_4 + 176 + 8)) << 4);
            val_22 = val_22 + 296;
            label_13:
            val_19 = val_4.GetEnumerator();
            label_41:
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_19;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            T val_9 = val_19.Current;
            if(val_9 == 0)
            {
                goto label_41;
            }
            
            GameUI.EmailUIDataHandler val_10 = val_9.emailUIDataHandler;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_25 = 4;
            if((val_2.ContainsKey(key:  0)) == true)
            {
                goto label_31;
            }
            
            if((0 != 0) && ((val_9.Invoke(source:  input)) == null))
            {
                    if(15026800 != 0)
            {
                goto label_41;
            }
            
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_2.Add(key:  0, value:  0);
            goto label_41;
            label_19:
            val_28 = 0;
            val_18 = 199;
            if(val_19 != null)
            {
                goto label_42;
            }
            
            goto label_58;
            label_1:
            System.ArgumentNullException val_15 = null;
            val_17 = val_15;
            val_15 = new System.ArgumentNullException(paramName:  "input");
            label_31:
            new System.Exception() = new System.Exception(message:  "The given key is defined multiple times in the same type: "("The given key is defined multiple times in the same type: ") + input.GetType() + "." + 0);
            if(0 != 1)
            {
                goto label_57;
            }
            
            val_18 = 0;
            if(X21 == 0)
            {
                goto label_58;
            }
            
            label_42:
            var val_29 = X21;
            if((X21 + 286) == 0)
            {
                goto label_62;
            }
            
            var val_27 = X21 + 176;
            var val_28 = 0;
            val_27 = val_27 + 8;
            label_61:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_60;
            }
            
            val_28 = val_28 + 1;
            val_27 = val_27 + 16;
            if(val_28 < (X21 + 286))
            {
                goto label_61;
            }
            
            goto label_62;
            label_60:
            val_29 = val_29 + (((X21 + 176 + 8)) << 4);
            val_29 = val_29 + 296;
            label_62:
            X21.Dispose();
            label_58:
            val_20 = 1;
            mem[1152921525717100176] = 0;
            return (bool)val_20;
            label_57:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PocoJsonSerializerStrategy()
        {
            PlayFab.Json.PocoJsonSerializerStrategy.EmptyTypes = new System.Type[0];
            System.Type[] val_2 = new System.Type[1];
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_3 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_3 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_3;
            PlayFab.Json.PocoJsonSerializerStrategy.ArrayConstructorParameterTypes = val_2;
            string[] val_4 = new string[3];
            val_4[0] = "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z";
            val_4[1] = "yyyy-MM-dd\\THH:mm:ss\\Z";
            val_4[2] = "yyyy-MM-dd\\THH:mm:ssK";
            PlayFab.Json.PocoJsonSerializerStrategy.Iso8601Format = val_4;
        }
    
    }

}
