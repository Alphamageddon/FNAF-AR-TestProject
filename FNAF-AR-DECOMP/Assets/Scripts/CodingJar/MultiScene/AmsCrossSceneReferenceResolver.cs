using UnityEngine;

namespace CodingJar.MultiScene
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AmsCrossSceneReferenceResolver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<CodingJar.MultiScene.AmsCrossSceneReferenceResolver.ResolveCrossSceneReferenceDelegate> _resolvers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AmsCrossSceneReferenceResolver()
        {
            System.Collections.Generic.List<ResolveCrossSceneReferenceDelegate> val_1 = new System.Collections.Generic.List<ResolveCrossSceneReferenceDelegate>();
            CodingJar.MultiScene.AmsCrossSceneReferenceResolver._resolvers = val_1;
            val_1.Clear();
            mem[1152921520111366960] = 0;
            mem[1152921520111366968] = static System.Boolean CodingJar.MultiScene.AmsCrossSceneReferenceResolver::DefaultResolve(CodingJar.MultiScene.RuntimeCrossSceneReference xRef);
            mem[1152921520111366944] = static System.Boolean CodingJar.MultiScene.AmsCrossSceneReferenceResolver::DefaultResolve(CodingJar.MultiScene.RuntimeCrossSceneReference xRef);
            val_1.Add(item:  new AmsCrossSceneReferenceResolver.ResolveCrossSceneReferenceDelegate());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddCustomResolver(CodingJar.MultiScene.AmsCrossSceneReferenceResolver.ResolveCrossSceneReferenceDelegate customResolver)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((CodingJar.MultiScene.AmsCrossSceneReferenceResolver._resolvers.Contains(item:  customResolver)) != false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            CodingJar.MultiScene.AmsCrossSceneReferenceResolver._resolvers.Add(item:  customResolver);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Resolve(CodingJar.MultiScene.RuntimeCrossSceneReference xRef)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            CodingJar.MultiScene.ResolveException val_17;
            val_12 = 1152921504851574784;
            if((UnityEngine.Object.op_Implicit(exists:  xRef._sourceObject)) == false)
            {
                goto label_4;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  xRef._sourceObject)) == false)
            {
                goto label_7;
            }
            
            val_13 = null;
            val_13 = null;
            System.Collections.Generic.List<ResolveCrossSceneReferenceDelegate> val_13 = CodingJar.MultiScene.AmsCrossSceneReferenceResolver._resolvers;
            val_13 = val_13.Count - 1;
            do
            {
                if((val_13 & 2147483648) != 0)
            {
                    return;
            }
            
                val_14 = null;
                val_14 = null;
                val_15 = CodingJar.MultiScene.AmsCrossSceneReferenceResolver._resolvers.Item[val_13];
                val_13 = val_13 - 1;
            }
            while((val_15.Invoke(xRef:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()})) == false);
            
            return;
            label_4:
            string val_6 = System.String.Format(format:  "Cross-Scene Ref: {0}. fromObject is null.", arg0:  null);
            goto label_17;
            label_7:
            label_17:
            if((UnityEngine.Object.op_Implicit(exists:  1152921505137197056)) == true)
            {
                    return;
            }
            
            CodingJar.MultiScene.ResolveException val_10 = (new CodingJar.MultiScene.ResolveException(message:  System.String.Format(format:  "Cross-Scene Ref: {0}. Could not Resolve toObject {1}", arg0:  null, arg1:  xRef._sourceObject))) + 16;
            if(val_10.IsValid() == false)
            {
                    return;
            }
            
            val_17 = val_10;
            mem[1152921520111775776] = val_17;
            if((UnityEngine.Object.op_Implicit(exists:  val_17)) == false)
            {
                    return;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool DefaultResolve(CodingJar.MultiScene.RuntimeCrossSceneReference xRef)
        {
            CodingJar.MultiScene.AmsCrossSceneReferenceResolver.ResolveToField(fromObject:  xRef._sourceObject, toObject:  xRef._sourceObject, fromFieldPath:  xRef._sourceField, debugThis:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ResolveToField(object fromObject, UnityEngine.Object toObject, string fromFieldPath, CodingJar.MultiScene.RuntimeCrossSceneReference debugThis)
        {
            object val_19;
            UnityEngine.Object val_20;
            object val_21;
            var val_22;
            var val_24;
            val_19 = fromFieldPath;
            val_20 = toObject;
            val_21 = fromObject;
            System.Reflection.PropertyInfo val_9 = 0;
            System.Reflection.FieldInfo val_8 = 0;
            char[] val_1 = new char[1];
            val_1[0] = '.';
            System.String[] val_2 = val_19.Split(separator:  val_1);
            val_22 = 0;
            goto label_4;
            label_12:
            val_21 = CodingJar.MultiScene.AmsCrossSceneReferenceResolver.GetObjectFromField(fromObject:  val_21, fromField:  val_2[0]);
            if(val_21 == null)
            {
                goto label_8;
            }
            
            if(val_21.GetType().IsClass == false)
            {
                goto label_10;
            }
            
            val_22 = 1;
            label_4:
            if(val_22 < (val_2.Length - 1))
            {
                goto label_12;
            }
            
            var val_20 = -4294967296;
            val_20 = val_20 + ((val_2.Length) << 32);
            if((CodingJar.MultiScene.AmsCrossSceneReferenceResolver.GetFieldFromObject(fromObject:  val_21, fromField:  val_2[val_20 >> 32], field: out  val_8, property: out  val_9, arrayIndex: out  0)) == false)
            {
                goto label_16;
            }
            
            CodingJar.MultiScene.AmsCrossSceneReferenceResolver.AssignField(fromObject:  val_21, toObject:  val_20, field:  val_8, property:  val_9, arrayIndex:  0);
            return;
            label_8:
            string val_12 = System.String.Format(format:  "Cross-Scene Ref: {0}. Could not follow path {1} because {2} was null", arg0:  null, arg1:  val_19, arg2:  val_2[0x0] + 32);
            new CodingJar.MultiScene.ResolveException() = new CodingJar.MultiScene.ResolveException(message:  val_12);
            label_10:
            val_19 = System.String.Format(format:  "Cross-Scene Ref: {0}. Could not follow path {1} because {2} was not a class (probably a struct). This is unsupported.", arg0:  null, arg1:  val_12, arg2:  val_2[0x0] + 32);
            val_20 = new CodingJar.MultiScene.ResolveException();
            val_20 = new CodingJar.MultiScene.ResolveException(message:  val_19);
            label_16:
            CodingJar.MultiScene.ResolveException val_18 = new CodingJar.MultiScene.ResolveException(message:  System.String.Format(format:  "Cross-Scene Ref: {0}. {1}", arg0:  null, arg1:  1152921504623300608));
            mem[8] = null;
            val_24 = 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool GetFieldFromObject(object fromObject, string fromField, out System.Reflection.FieldInfo field, out System.Reflection.PropertyInfo property, out int arrayIndex)
        {
            int val_18;
            int val_19;
            System.Type val_20;
            System.Reflection.PropertyInfo val_21;
            val_18 = 1152921520112695584;
            arrayIndex = 0;
            field = 0;
            property = 0;
            char[] val_1 = new char[1];
            val_1[0] = ',';
            System.String[] val_2 = fromField.Split(separator:  val_1);
            val_19 = val_2.Length;
            if(val_19 == 0)
            {
                    val_19 = val_2.Length;
            }
            
            string val_18 = val_2[0];
            if(val_19 >= 2)
            {
                    if((System.Int32.TryParse(s:  val_2[1], result: out  val_18)) == false)
            {
                goto label_7;
            }
            
            }
            
            val_20 = fromObject.GetType();
            goto label_9;
            label_22:
            if(((System.Reflection.FieldInfo.op_Equality(left:  field, right:  0)) == false) || ((System.Reflection.PropertyInfo.op_Equality(left:  property, right:  0)) == false))
            {
                goto label_11;
            }
            
            field = val_20;
            if((System.Reflection.FieldInfo.op_Equality(left:  val_20, right:  0)) != false)
            {
                    if((val_18.StartsWith(value:  "m_")) != false)
            {
                    val_18;
                property = val_20.GetProperty(name:  System.Char.ToLower(c:  val_18.Chars[2])(System.Char.ToLower(c:  val_18.Chars[2])) + val_18.Substring(startIndex:  3)(val_18.Substring(startIndex:  3)), bindingAttr:  116);
            }
            
            }
            
            val_20 = val_20;
            label_9:
            if((System.Type.op_Inequality(left:  val_20, right:  0)) == true)
            {
                goto label_22;
            }
            
            label_11:
            if((System.Reflection.FieldInfo.op_Inequality(left:  field, right:  0)) == false)
            {
                goto label_23;
            }
            
            val_21 = 1;
            goto label_25;
            label_23:
            val_21 = property;
            bool val_17 = System.Reflection.PropertyInfo.op_Inequality(left:  val_21, right:  0);
            goto label_25;
            label_7:
            val_21 = 0;
            label_25:
            val_21 = val_21 & 1;
            return (bool)val_21;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object GetObjectFromField(object fromObject, string fromField)
        {
            System.Reflection.FieldInfo val_13;
            object val_14;
            object val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            string val_23;
            object val_24;
            object val_25;
            int val_3 = 0;
            System.Reflection.PropertyInfo val_2 = 0;
            System.Reflection.FieldInfo val_1 = 0;
            if((CodingJar.MultiScene.AmsCrossSceneReferenceResolver.GetFieldFromObject(fromObject:  fromObject, fromField:  fromField, field: out  val_1, property: out  val_2, arrayIndex: out  val_3)) == false)
            {
                goto label_3;
            }
            
            val_13 = val_1;
            if((System.Reflection.FieldInfo.op_Inequality(left:  val_13, right:  0)) != false)
            {
                    val_14 = val_13;
            }
            else
            {
                    val_14 = val_2;
            }
            
            val_15 = val_14;
            if((System.Reflection.FieldInfo.op_Inequality(left:  val_13, right:  0)) != false)
            {
                    val_16 = val_13;
            }
            else
            {
                    val_16 = val_2;
            }
            
            bool val_7 = System.Reflection.FieldInfo.op_Inequality(left:  val_13, right:  0);
            if((val_3 & 2147483648) != 0)
            {
                goto label_12;
            }
            
            if(val_7 == false)
            {
                goto label_13;
            }
            
            val_17 = val_13;
            val_18 = mem[282584257677295];
            goto label_15;
            label_12:
            if(val_7 == false)
            {
                goto label_16;
            }
            
            val_19 = val_13;
            return (object)val_19;
            label_13:
            val_17 = val_2;
            val_18 = 0;
            label_15:
            if(val_17 == 0)
            {
                goto label_20;
            }
            
            var val_17 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_21;
            }
            
            var val_14 = mem[282584257676847];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_23:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < mem[282584257676957])
            {
                goto label_23;
            }
            
            label_21:
            val_18 = 1;
            goto label_24;
            label_22:
            var val_16 = val_14;
            val_16 = val_16 + 1;
            val_17 = val_17 + val_16;
            val_20 = val_17 + 296;
            label_24:
            val_13 = val_3;
            if(val_17.Count <= 0)
            {
                goto label_25;
            }
            
            var val_20 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_26;
            }
            
            var val_18 = mem[282584257676847];
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_28:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_27;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < mem[282584257676957])
            {
                goto label_28;
            }
            
            label_26:
            val_18 = 0;
            goto label_29;
            label_27:
            val_20 = val_20 + (((mem[282584257676847] + 8)) << 4);
            val_21 = val_20 + 296;
            label_29:
            val_19 = val_17;
            object val_9 = val_19.Item[0];
            return (object)val_19;
            label_16:
            val_15 = val_2;
            val_19 = val_15;
            return (object)val_19;
            label_3:
            string val_10 = System.String.Format(format:  "Could not find Field {0}", arg0:  fromField);
            goto label_32;
            label_20:
            val_23 = "Expected collection of elements for property {0} but field type is {1}";
            val_24 = val_16;
            val_25 = val_15;
            goto label_33;
            label_25:
            object val_11 = val_13 + 1;
            val_23 = "Expected collection of at least {0} elements from property {1}";
            val_25 = val_11;
            val_24 = val_15;
            label_33:
            label_32:
            CodingJar.MultiScene.ResolveException val_13 = new CodingJar.MultiScene.ResolveException(message:  System.String.Format(format:  val_23, arg0:  val_11, arg1:  val_24));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void AssignField(object fromObject, UnityEngine.Object toObject, System.Reflection.FieldInfo field, System.Reflection.PropertyInfo property, int arrayIndex)
        {
            int val_26;
            System.Reflection.PropertyInfo val_27;
            UnityEngine.Object val_28;
            object val_29;
            object val_30;
            object val_31;
            object val_32;
            var val_33;
            var val_34;
            var val_39;
            System.Object[] val_40;
            string val_42;
            System.Object[] val_43;
            var val_44;
            val_26 = arrayIndex;
            val_27 = property;
            val_28 = toObject;
            if((System.Reflection.FieldInfo.op_Inequality(left:  field, right:  0)) != false)
            {
                    val_29 = field;
            }
            else
            {
                    val_29 = val_27;
            }
            
            val_30 = val_29;
            if((System.Reflection.FieldInfo.op_Inequality(left:  field, right:  0)) != false)
            {
                    val_31 = field;
            }
            else
            {
                    val_31 = val_27;
            }
            
            val_32 = val_31;
            if((val_26 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            if((System.Reflection.FieldInfo.op_Inequality(left:  field, right:  0)) == false)
            {
                goto label_10;
            }
            
            val_33 = field;
            goto label_12;
            label_9:
            if((UnityEngine.Object.op_Implicit(exists:  val_28)) == false)
            {
                goto label_15;
            }
            
            val_26 = val_28.GetType();
            if((val_32 & 1) == 0)
            {
                goto label_18;
            }
            
            label_15:
            if((System.Reflection.FieldInfo.op_Inequality(left:  field, right:  0)) == false)
            {
                goto label_19;
            }
            
            field.SetValue(obj:  fromObject, value:  val_28);
            return;
            label_10:
            val_33 = val_27;
            label_12:
            val_27 = val_33;
            if(val_27 == null)
            {
                goto label_22;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            if(val_27.Count <= val_26)
            {
                goto label_27;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto label_31;
            label_27:
            var val_29 = 0;
            val_29 = val_29 + 1;
            goto label_35;
            label_19:
            if((System.Reflection.PropertyInfo.op_Inequality(left:  val_27, right:  0)) == false)
            {
                    return;
            }
            
            val_28 = ???;
            val_26 = ???;
            val_39 = ???;
            val_34 = 0;
            goto typeof(System.Reflection.PropertyInfo).__il2cppRuntimeField_318;
            label_31:
            val_39.set_Item(index:  val_26, value:  val_28);
            return;
            label_35:
            val_30 = ???;
            val_40 = ???;
            val_32 = ???;
            val_27.Insert(index:  val_26, value:  val_28);
            return;
            label_22:
            string val_21 = System.String.Format(format:  "Expected collection of elements for property {0} but field type is {1}", arg0:  val_30, arg1:  val_32);
            goto label_38;
            label_18:
            System.Type val_23 = val_28.GetType();
            val_42 = "Field {0} of type {1} is not compatible with {2} of type {3}";
            val_43 = new object[4];
            label_38:
            CodingJar.MultiScene.ResolveException val_26 = new CodingJar.MultiScene.ResolveException(message:  System.String.Format(format:  null, args:  null));
            mem[8] = null;
            val_44 = 8;
        }
    
    }

}
