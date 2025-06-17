using UnityEngine;

namespace SimpleJson2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Collections.Generic.IDictionary<System.Type, SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate> ConstructorCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<string, SimpleJson2.Reflection.ReflectionUtils.GetDelegate>> GetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<string, System.Collections.Generic.KeyValuePair<System.Type, SimpleJson2.Reflection.ReflectionUtils.SetDelegate>>> SetCache;
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
            ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, ConstructorDelegate> val_1 = new ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, ConstructorDelegate>(object:  this, method:  typeof(SimpleJson2.PocoJsonSerializerStrategy).__il2cppRuntimeField_1A0);
            this.ConstructorCache = new ReflectionUtils.ThreadSafeDictionary<System.Type, ConstructorDelegate>(valueFactory:  null);
            ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.String, GetDelegate>> val_3 = new ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.String, GetDelegate>>(object:  this, method:  typeof(SimpleJson2.PocoJsonSerializerStrategy).__il2cppRuntimeField_1B0);
            this.GetCache = new ReflectionUtils.ThreadSafeDictionary<System.Type, System.Collections.Generic.IDictionary<System.String, GetDelegate>>(valueFactory:  null);
            ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>> val_5 = new ReflectionUtils.ThreadSafeDictionaryValueFactory<System.Type, System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>>(object:  this, method:  typeof(SimpleJson2.PocoJsonSerializerStrategy).__il2cppRuntimeField_1C0);
            this.SetCache = new ReflectionUtils.ThreadSafeDictionary<System.Type, System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>>(valueFactory:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
        {
            return (string)clrPropertyName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual SimpleJson2.Reflection.ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(System.Type key)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            if(key.IsArray != false)
            {
                    val_3 = null;
                val_4 = 1152921505133686792;
                return SimpleJson2.Reflection.ReflectionUtils.GetContructor(type:  key, argsType:  SimpleJson2.PocoJsonSerializerStrategy.__il2cppRuntimeField_static_fields);
            }
            
            val_5 = null;
            return SimpleJson2.Reflection.ReflectionUtils.GetContructor(type:  key, argsType:  SimpleJson2.PocoJsonSerializerStrategy.__il2cppRuntimeField_static_fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual System.Collections.Generic.IDictionary<string, SimpleJson2.Reflection.ReflectionUtils.GetDelegate> GetterValueFactory(System.Type type)
        {
            var val_22;
            var val_23;
            var val_25;
            System.Collections.Generic.Dictionary<System.String, GetDelegate> val_1 = new System.Collections.Generic.Dictionary<System.String, GetDelegate>();
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
            
            GetDelegate val_10 = SimpleJson2.Reflection.ReflectionUtils.GetGetMethod(propertyInfo:  val_7);
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_1.set_Item(key:  ???, value:  ???);
            goto label_35;
            label_14:
            val_22 = 0;
            val_23 = 102;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_3.Dispose();
            }
            
            if( == 102)
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
            val_25 = 0;
            System.Collections.Generic.IEnumerator<T> val_14 = type.GetEnumerator();
            label_89:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_25 = 0;
            if(val_14.MoveNext() == false)
            {
                goto label_71;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_25 = 0;
            T val_18 = val_14.Current;
            if((val_18.IsStatic == true) || (val_18.IsPublic == false))
            {
                goto label_89;
            }
            
            GetDelegate val_21 = SimpleJson2.Reflection.ReflectionUtils.GetGetMethod(fieldInfo:  val_18);
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_1.set_Item(key:  ???, value:  ???);
            goto label_89;
            label_71:
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
                    return (System.Collections.Generic.IDictionary<System.String, GetDelegate>)val_1;
            }
            
            if(193 == 0)
            {
                    return (System.Collections.Generic.IDictionary<System.String, GetDelegate>)val_1;
            }
            
            if(193 == 193)
            {
                    return (System.Collections.Generic.IDictionary<System.String, GetDelegate>)val_1;
            }
            
            return (System.Collections.Generic.IDictionary<System.String, GetDelegate>)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual System.Collections.Generic.IDictionary<string, System.Collections.Generic.KeyValuePair<System.Type, SimpleJson2.Reflection.ReflectionUtils.SetDelegate>> SetterValueFactory(System.Type type)
        {
            var val_21;
            var val_22;
            var val_24;
            System.Reflection.FieldInfo val_25;
            var val_29;
            var val_30;
            var val_32;
            var val_37;
            val_21 = this;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>> val_1 = null;
            val_22 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.KeyValuePair<System.Type, SetDelegate>>();
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_24 = 1152921504685174784;
            val_25 = type.GetEnumerator();
            goto label_22;
            label_35:
            var val_26 = 0;
            val_26 = val_26 + 1;
            T val_5 = val_25.Current;
            if(((val_5 & 1) != 0) && (val_5.IsStatic != true))
            {
                    if(val_5.IsPublic != false)
            {
                    InternalClipper.IntPoint val_9 = new InternalClipper.IntPoint(X:  val_5, Y:  SimpleJson2.Reflection.ReflectionUtils.GetSetMethod(propertyInfo:  val_5));
                var val_27 = 0;
                val_27 = val_27 + 1;
                val_1.set_Item(key:  null, value:  null);
                val_21 = val_21;
            }
            
            }
            
            label_22:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_25.MoveNext() == true)
            {
                goto label_35;
            }
            
            val_29 = 0;
            val_30 = 113;
            if(val_25 != null)
            {
                goto label_36;
            }
            
            goto label_51;
            label_36:
            var val_31 = X23;
            if((X23 + 286) == 0)
            {
                goto label_55;
            }
            
            var val_29 = X23 + 176;
            var val_30 = 0;
            val_29 = val_29 + 8;
            label_54:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_53;
            }
            
            val_30 = val_30 + 1;
            val_29 = val_29 + 16;
            if(val_30 < (X23 + 286))
            {
                goto label_54;
            }
            
            goto label_55;
            label_53:
            val_31 = val_31 + (((X23 + 176 + 8)) << 4);
            val_32 = val_31 + 296;
            label_55:
            X23.Dispose();
            label_51:
            if( == 113)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            System.Collections.Generic.IEnumerator<T> val_14 = type.GetEnumerator();
            goto label_78;
            label_92:
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_25 = val_14.Current;
            if((val_25.IsInitOnly != true) && (val_25.IsStatic != true))
            {
                    if(val_25.IsPublic != false)
            {
                    InternalClipper.IntPoint val_21 = new InternalClipper.IntPoint(X:  val_25, Y:  SimpleJson2.Reflection.ReflectionUtils.GetSetMethod(fieldInfo:  val_25));
                val_25 = val_21.X;
                var val_34 = 0;
                val_34 = val_34 + 1;
                val_1.set_Item(key:  null, value:  null);
                val_21 = val_21;
                val_22 = val_22;
                val_24 = X27;
            }
            
            }
            
            label_78:
            var val_35 = 0;
            val_35 = val_35 + 1;
            if((val_14 & 1) != 0)
            {
                goto label_92;
            }
            
            val_37 = 225;
            if(val_14 == null)
            {
                
            }
            else
            {
                    var val_36 = 0;
                val_36 = val_36 + 1;
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
            
            if( == 225)
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
            object val_129;
            System.String[] val_130;
            string val_131;
            IntPtr val_132;
            var val_133;
            var val_135;
            var val_136;
            var val_137;
            var val_138;
            System.Type val_139;
            var val_140;
            var val_142;
            var val_144;
            var val_146;
            var val_148;
            var val_152;
            var val_153;
            var val_155;
            var val_159;
            var val_161;
            var val_165;
            var val_166;
            var val_167;
            var val_168;
            var val_169;
            var val_170;
            var val_171;
            object val_172;
            var val_173;
            var val_174;
            var val_175;
            var val_176;
            var val_177;
            var val_178;
            var val_180;
            var val_184;
            var val_185;
            val_129 = value;
            val_130 = this;
            if((System.Type.op_Equality(left:  type, right:  0)) == true)
            {
                goto label_3;
            }
            
            if(val_129 != null)
            {
                    var val_2 = (null == null) ? (val_129) : 0;
            }
            else
            {
                    val_131 = 0;
            }
            
            val_132 = 1152921504619999232;
            val_133 = 0;
            if(((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false) || ((System.String.IsNullOrEmpty(value:  val_131)) == false))
            {
                goto label_9;
            }
            
            val_135 = null;
            goto label_143;
            label_9:
            if(val_129 == null)
            {
                goto label_11;
            }
            
            if(val_131 == 0)
            {
                goto label_12;
            }
            
            if(val_131.Length == 0)
            {
                goto label_13;
            }
            
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_16;
            }
            
            label_36:
            val_136 = null;
            val_136 = null;
            val_130 = SimpleJson2.PocoJsonSerializerStrategy.Iso8601Format;
            val_129 = 1152921504617603072;
            System.DateTime val_10 = System.DateTime.ParseExact(s:  val_131, formats:  val_130, provider:  System.Globalization.CultureInfo.InvariantCulture, style:  80);
            val_137 = null;
            goto label_23;
            label_11:
            val_138 = 0;
            return (object)val_138;
            label_12:
            if(null == null)
            {
                goto label_130;
            }
            
            val_139 = 0;
            goto label_26;
            label_13:
            val_133 = 0;
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_29;
            }
            
            val_139 = 0;
            goto label_52;
            label_16:
            if((SimpleJson2.Reflection.ReflectionUtils.IsNullableType(type:  type)) != false)
            {
                    if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  type), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_36;
            }
            
            }
            
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_39;
            }
            
            label_139:
            val_140 = null;
            val_140 = null;
            val_130 = SimpleJson2.PocoJsonSerializerStrategy.Iso8601Format;
            val_129 = 1152921504617709568;
            System.DateTimeOffset val_20 = System.DateTimeOffset.ParseExact(input:  val_131, formats:  val_130, formatProvider:  System.Globalization.CultureInfo.InvariantCulture, styles:  80);
            val_137 = null;
            label_23:
            val_135 = val_137;
            label_143:
            label_272:
            val_138 = val_20;
            return (object)val_138;
            label_29:
            if((SimpleJson2.Reflection.ReflectionUtils.IsNullableType(type:  type)) == false)
            {
                goto label_49;
            }
            
            val_133 = 0;
            val_139 = 0;
            if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  type), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_52;
            }
            
            label_49:
            val_139 = val_131;
            label_52:
            if((SimpleJson2.Reflection.ReflectionUtils.IsNullableType(type:  type)) != true)
            {
                    val_132 = null;
                val_133 = 0;
                val_138 = val_131;
                if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  type), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_132}))) == true)
            {
                    return (object)val_138;
            }
            
            }
            
            label_26:
            if(null == null)
            {
                goto label_59;
            }
            
            val_131 = 0;
            goto label_60;
            label_59:
            val_133 = 0;
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_130;
            }
            
            val_131 = 1;
            label_60:
            if(null == null)
            {
                goto label_64;
            }
            
            label_99:
            if(val_131 == 0)
            {
                goto label_65;
            }
            
            val_133 = 0;
            if((System.Type.op_Inequality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_68;
            }
            
            label_65:
            val_131 = val_129;
            if(val_131 == null)
            {
                goto label_69;
            }
            
            if((SimpleJson2.Reflection.ReflectionUtils.IsTypeDictionary(type:  type)) == false)
            {
                goto label_72;
            }
            
            System.Type val_34 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Type[] val_35 = new System.Type[2];
            val_35[0] = val_139;
            val_35[1] = type;
            var val_145 = 0;
            val_145 = val_145 + 1;
            val_142 = 0;
            goto label_93;
            label_64:
            val_132 = 1152921504618188800;
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_130;
            }
            
            if((System.Type.op_Inequality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_99;
            }
            
            label_68:
            if(((((((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true) && ((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)) && ((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)) && ((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)) && ((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)) && ((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true))
            {
                    if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)
            {
                    if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_123;
            }
            
            }
            
            }
            
            val_129 = System.Convert.ChangeType(value:  val_129, conversionType:  type, provider:  System.Globalization.CultureInfo.InvariantCulture);
            label_123:
            val_130 = 1152921505133735936;
            if((SimpleJson2.Reflection.ReflectionUtils.IsNullableType(type:  type)) == false)
            {
                goto label_130;
            }
            
            object val_59 = SimpleJson2.Reflection.ReflectionUtils.ToNullableType(obj:  val_129, nullableType:  type);
            goto label_272;
            label_39:
            if((SimpleJson2.Reflection.ReflectionUtils.IsNullableType(type:  type)) != false)
            {
                    if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  type), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_139;
            }
            
            }
            
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_142;
            }
            
            goto label_143;
            label_69:
            label_306:
            val_129 = val_129;
            val_138 = val_139;
            if(val_129 == null)
            {
                    return (object)val_138;
            }
            
            if(type.IsArray == false)
            {
                goto label_315;
            }
            
            var val_146 = 0;
            val_146 = val_146 + 1;
            val_144 = 0;
            goto label_151;
            label_72:
            val_146 = 0;
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_154;
            }
            
            label_130:
            val_138 = val_129;
            return (object)val_138;
            label_154:
            var val_147 = 0;
            val_147 = val_147 + 1;
            val_146 = 0;
            goto label_159;
            label_142:
            if((SimpleJson2.Reflection.ReflectionUtils.IsNullableType(type:  type)) != false)
            {
                    if((System.Type.op_Equality(left:  System.Nullable.GetUnderlyingType(nullableType:  type), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                goto label_143;
            }
            
            }
            
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_168;
            }
            
            if((System.Uri.IsWellFormedUriString(uriString:  val_131, uriKind:  0)) == false)
            {
                    return (object)val_138;
            }
            
            if((System.Uri.TryCreate(uriString:  val_131, uriKind:  0, result: out  0)) == false)
            {
                    return (object)val_138;
            }
            
            return (object)val_138;
            label_93:
            object val_81 = this.ConstructorCache.Item[null].Invoke(args:  System.Array.Empty<System.Object>());
            if(val_81 == null)
            {
                goto label_177;
            }
            
            val_148 = val_81;
            if(val_148 != null)
            {
                goto label_178;
            }
            
            label_177:
            val_148 = 0;
            label_178:
            var val_148 = 0;
            val_148 = val_148 + 1;
            System.Collections.Generic.IEnumerator<T> val_83 = val_131.GetEnumerator();
            label_199:
            var val_149 = 0;
            val_149 = val_149 + 1;
            if(val_83.MoveNext() == false)
            {
                goto label_188;
            }
            
            var val_150 = 0;
            val_150 = val_150 + 1;
            var val_154 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_198;
            }
            
            var val_151 = mem[282584257676847];
            var val_152 = 0;
            val_151 = val_151 + 8;
            label_197:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_196;
            }
            
            val_152 = val_152 + 1;
            val_151 = val_151 + 16;
            if(val_152 < mem[282584257676957])
            {
                goto label_197;
            }
            
            goto label_198;
            label_196:
            var val_153 = val_151;
            val_153 = val_153 + 5;
            val_154 = val_154 + val_153;
            val_152 = val_154 + 296;
            label_198:
            val_148.Add(key:  val_83.Current.emailUIDataHandler, value:  this);
            goto label_199;
            label_168:
            if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_202;
            }
            
            return (object)val_138;
            label_159:
            val_153 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            var val_155 = 0;
            val_155 = val_155 + 1;
            val_153 = 0;
            TValue val_96 = this.SetCache.Item[null];
            var val_158 = val_96;
            if((val_96 + 286) == 0)
            {
                goto label_214;
            }
            
            var val_156 = val_96 + 176;
            var val_157 = 0;
            val_156 = val_156 + 8;
            label_213:
            if(((val_96 + 176 + 8) + -8) == null)
            {
                goto label_212;
            }
            
            val_157 = val_157 + 1;
            val_156 = val_156 + 16;
            if(val_157 < (val_96 + 286))
            {
                goto label_213;
            }
            
            goto label_214;
            label_212:
            val_158 = val_158 + (((val_96 + 176 + 8)) << 4);
            val_155 = val_158 + 296;
            label_214:
            System.Collections.Generic.IEnumerator<T> val_97 = val_96.GetEnumerator();
            label_232:
            var val_159 = 0;
            val_159 = val_159 + 1;
            if(val_97.MoveNext() == false)
            {
                goto label_220;
            }
            
            var val_160 = 0;
            val_160 = val_160 + 1;
            T val_101 = val_97.Current;
            GameUI.EmailUIDataHandler val_103 = 0.emailUIDataHandler;
            var val_161 = 0;
            val_161 = val_161 + 1;
            if((val_131.TryGetValue(key:  null, value: out  TValue val_105 = null)) == false)
            {
                goto label_232;
            }
            
            GameUI.EmailUIDataHandler val_107 = 0.emailUIDataHandler;
            0.Invoke(source:  this.ConstructorCache.Item[null].Invoke(args:  System.Array.Empty<System.Object>()), value:  this);
            goto label_232;
            label_151:
            val_159 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            object[] val_110 = new object[1];
            var val_162 = 0;
            val_162 = val_162 + 1;
            val_159 = 0;
            int val_112 = val_129.Count;
            if((val_112 != 0) && (val_112 == 0))
            {
                    val_159 = 0;
            }
            
            if(val_110.Length == 0)
            {
                    val_159 = 0;
            }
            
            val_110[0] = val_112;
            object val_113 = this.ConstructorCache.Item[null].Invoke(args:  val_110);
            if(val_113 == null)
            {
                goto label_242;
            }
            
            val_161 = val_113;
            if(val_161 != null)
            {
                goto label_243;
            }
            
            val_159 = 0;
            label_242:
            val_161 = 0;
            label_243:
            var val_163 = 0;
            val_163 = val_163 + 1;
            val_159 = 0;
            System.Collections.Generic.IEnumerator<T> val_115 = val_129.GetEnumerator();
            label_265:
            var val_164 = 0;
            val_164 = val_164 + 1;
            val_159 = 0;
            if(val_115.MoveNext() == false)
            {
                goto label_253;
            }
            
            var val_165 = 0;
            val_165 = val_165 + 1;
            T val_119 = val_115.Current;
            var val_169 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_264;
            }
            
            var val_166 = mem[282584257676847];
            var val_167 = 0;
            val_166 = val_166 + 8;
            label_263:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_262;
            }
            
            val_167 = val_167 + 1;
            val_166 = val_166 + 16;
            if(val_167 < mem[282584257676957])
            {
                goto label_263;
            }
            
            goto label_264;
            label_262:
            var val_168 = val_166;
            val_168 = val_168 + 1;
            val_169 = val_169 + val_168;
            val_165 = val_169 + 296;
            label_264:
            var val_120 = 0 + 1;
            val_161.set_Item(index:  0, value:  this);
            goto label_265;
            label_188:
            val_166 = 0;
            val_167 = 952;
            if(val_83 != null)
            {
                goto label_266;
            }
            
            goto label_396;
            label_202:
            object val_122 = System.Convert.ChangeType(value:  val_131, conversionType:  type, provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_272;
            label_253:
            val_168 = 0;
            val_169 = 1468;
            if(val_115 != null)
            {
                goto label_273;
            }
            
            goto label_309;
            label_220:
            val_170 = 0;
            val_171 = 1471;
            if(val_97 != null)
            {
                goto label_275;
            }
            
            goto label_298;
            label_3:
            val_172 = new System.ArgumentNullException(paramName:  "type");
            goto label_379;
            label_275:
            var val_172 = mem[69734400];
            if((mem[69734400] + 286) == 0)
            {
                goto label_302;
            }
            
            var val_170 = mem[69734400] + 176;
            var val_171 = 0;
            val_170 = val_170 + 8;
            label_301:
            if(((mem[69734400] + 176 + 8) + -8) == null)
            {
                goto label_300;
            }
            
            val_171 = val_171 + 1;
            val_170 = val_170 + 16;
            if(val_171 < (mem[69734400] + 286))
            {
                goto label_301;
            }
            
            goto label_302;
            label_300:
            val_172 = val_172 + (((mem[69734400] + 176 + 8)) << 4);
            val_173 = val_172 + 296;
            label_302:
            Dispose();
            label_298:
            if( == 1471)
            {
                    return (object)val_138;
            }
            
            if( == false)
            {
                goto label_306;
            }
            
            goto label_306;
            label_273:
            var val_175 = X23;
            if((X23 + 286) == 0)
            {
                goto label_310;
            }
            
            var val_173 = X23 + 176;
            var val_174 = 0;
            val_173 = val_173 + 8;
            label_312:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_311;
            }
            
            val_174 = val_174 + 1;
            val_173 = val_173 + 16;
            if(val_174 < (X23 + 286))
            {
                goto label_312;
            }
            
            label_310:
            val_159 = 0;
            goto label_313;
            label_311:
            val_175 = val_175 + (((X23 + 176 + 8)) << 4);
            val_174 = val_175 + 296;
            label_313:
            X23.Dispose();
            label_309:
            if( == 1468)
            {
                    return (object)val_138;
            }
            
            if( != false)
            {
                    val_159 = 0;
            }
            
            label_315:
            if((SimpleJson2.Reflection.ReflectionUtils.IsTypeGenericeCollectionInterface(type:  type)) != true)
            {
                    if((SimpleJson2.Reflection.ReflectionUtils.IsAssignableFrom(type1:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), type2:  type)) == false)
            {
                    return (object)val_138;
            }
            
            }
            
            System.Type val_127 = SimpleJson2.Reflection.ReflectionUtils.GetGenericListElementType(type:  type);
            var val_178 = X0 + 16;
            if((X0 + 16 + 286) == 0)
            {
                goto label_327;
            }
            
            var val_176 = X0 + 16 + 176;
            var val_177 = 0;
            val_176 = val_176 + 8;
            label_329:
            if(((X0 + 16 + 176 + 8) + -8) == null)
            {
                goto label_328;
            }
            
            val_177 = val_177 + 1;
            val_176 = val_176 + 16;
            if(val_177 < (X0 + 16 + 286))
            {
                goto label_329;
            }
            
            label_327:
            val_159 = 0;
            goto label_330;
            label_328:
            val_178 = val_178 + (((X0 + 16 + 176 + 8)) << 4);
            val_175 = val_178 + 296;
            label_330:
            val_176 = X0 + 16.Item[null];
            if(val_176 != 0)
            {
                goto label_331;
            }
            
            System.Type val_129 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            new System.Type[1][0] = val_127;
            var val_181 = X0 + 16;
            if((X0 + 16 + 286) == 0)
            {
                goto label_340;
            }
            
            var val_179 = X0 + 16 + 176;
            var val_180 = 0;
            val_179 = val_179 + 8;
            label_342:
            if(((X0 + 16 + 176 + 8) + -8) == null)
            {
                goto label_341;
            }
            
            val_180 = val_180 + 1;
            val_179 = val_179 + 16;
            if(val_180 < (X0 + 16 + 286))
            {
                goto label_342;
            }
            
            label_340:
            val_177 = 0;
            goto label_343;
            label_341:
            val_181 = val_181 + (((X0 + 16 + 176 + 8)) << 4);
            val_178 = val_181 + 296;
            label_343:
            val_176 = X0 + 16.Item[null];
            label_331:
            object[] val_132 = new object[1];
            var val_182 = 0;
            val_182 = val_182 + 1;
            val_132[0] = val_129.Count;
            object val_135 = val_176.Invoke(args:  val_132);
            if(val_135 == null)
            {
                goto label_353;
            }
            
            val_180 = val_135;
            if(val_180 != null)
            {
                goto label_354;
            }
            
            label_353:
            val_180 = 0;
            label_354:
            var val_183 = 0;
            val_183 = val_183 + 1;
            System.Collections.Generic.IEnumerator<T> val_137 = val_129.GetEnumerator();
            label_375:
            var val_184 = 0;
            val_184 = val_184 + 1;
            if(val_137.MoveNext() == false)
            {
                goto label_364;
            }
            
            var val_185 = 0;
            val_185 = val_185 + 1;
            T val_141 = val_137.Current;
            val_184 = val_127;
            var val_189 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_371;
            }
            
            var val_186 = mem[282584257676847];
            var val_187 = 0;
            val_186 = val_186 + 8;
            label_373:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_372;
            }
            
            val_187 = val_187 + 1;
            val_186 = val_186 + 16;
            if(val_187 < mem[282584257676957])
            {
                goto label_373;
            }
            
            label_371:
            val_184 = 2;
            goto label_374;
            label_372:
            var val_188 = val_186;
            val_188 = val_188 + 2;
            val_189 = val_189 + val_188;
            val_185 = val_189 + 296;
            label_374:
            int val_142 = val_180.Add(value:  null);
            goto label_375;
            label_364:
            val_166 = 0;
            if(val_137 == null)
            {
                
            }
            else
            {
                    var val_190 = 0;
                val_190 = val_190 + 1;
                val_137.Dispose();
            }
            
            if( == false)
            {
                    return (object)val_138;
            }
            
            if(1468 == 0)
            {
                    return (object)val_138;
            }
            
            if(1468 == 1468)
            {
                    return (object)val_138;
            }
            
            return (object)val_138;
            label_266:
            var val_191 = 0;
            val_191 = val_191 + 1;
            val_129.Dispose();
            label_396:
            if( == 952)
            {
                    return (object)val_138;
            }
            
            if( == false)
            {
                    return (object)val_138;
            }
            
            return (object)val_138;
            label_379:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual object SerializeEnum(System.Enum p)
        {
            return (object)System.Convert.ToDouble(value:  p, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual bool TrySerializeKnownTypes(object input, out object output)
        {
            SimpleJson2.PocoJsonSerializerStrategy val_5;
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
            var val_12;
            var val_13;
            object val_14;
            var val_15;
            var val_16;
            var val_18;
            var val_19;
            var val_23;
            var val_24;
            val_13 = 1152921520063203424;
            val_14 = input;
            if(val_14 == null)
            {
                goto label_1;
            }
            
            output = 0;
            val_15 = val_14.GetType();
            val_16 = val_15;
            if(val_16 == null)
            {
                    return (bool)val_16;
            }
            
            SimpleJson2.JsonObject val_2 = null;
            val_12 = val_2;
            val_2 = new SimpleJson2.JsonObject();
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_18 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            TValue val_4 = this.GetCache.Item[0];
            var val_17 = val_4;
            if((val_4 + 286) == 0)
            {
                goto label_10;
            }
            
            var val_15 = val_4 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_12:
            if(((val_4 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (val_4 + 286))
            {
                goto label_12;
            }
            
            label_10:
            val_18 = 0;
            goto label_13;
            label_11:
            val_17 = val_17 + (((val_4 + 176 + 8)) << 4);
            val_19 = val_17 + 296;
            label_13:
            val_15 = val_4.GetEnumerator();
            label_32:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = 0;
            if(val_15.MoveNext() == false)
            {
                goto label_19;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_18 = 0;
            T val_9 = val_15.Current;
            if(val_9 == 0)
            {
                goto label_32;
            }
            
            GameUI.EmailUIDataHandler val_10 = val_9.emailUIDataHandler;
            object val_11 = val_9.Invoke(source:  val_14);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_2.Add(key:  val_9, value:  public T System.Collections.Generic.IEnumerator<T>::get_Current());
            goto label_32;
            label_19:
            val_14 = 0;
            val_23 = 128;
            if(val_15 != null)
            {
                goto label_33;
            }
            
            goto label_43;
            label_1:
            System.ArgumentNullException val_13 = null;
            val_13 = val_13;
            val_13 = new System.ArgumentNullException(paramName:  "input");
            if(0 != 1)
            {
                goto label_42;
            }
            
            val_23 = 0;
            if(X23 == 0)
            {
                goto label_43;
            }
            
            label_33:
            var val_23 = X23;
            if((X23 + 286) == 0)
            {
                goto label_47;
            }
            
            var val_21 = X23 + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_46:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_45;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (X23 + 286))
            {
                goto label_46;
            }
            
            goto label_47;
            label_45:
            val_23 = val_23 + (((X23 + 176 + 8)) << 4);
            val_24 = val_23 + 296;
            label_47:
            X23.Dispose();
            label_43:
            val_16 = 1;
            mem[1152921520063232096] = 69734400;
            return (bool)val_16;
            label_42:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PocoJsonSerializerStrategy()
        {
            SimpleJson2.PocoJsonSerializerStrategy.EmptyTypes = new System.Type[0];
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
            SimpleJson2.PocoJsonSerializerStrategy.ArrayConstructorParameterTypes = val_2;
            string[] val_4 = new string[3];
            val_4[0] = "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z";
            val_4[1] = "yyyy-MM-dd\\THH:mm:ss\\Z";
            val_4[2] = "yyyy-MM-dd\\THH:mm:ssK";
            SimpleJson2.PocoJsonSerializerStrategy.Iso8601Format = val_4;
        }
    
    }

}
