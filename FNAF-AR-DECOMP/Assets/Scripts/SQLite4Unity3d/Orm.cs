using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Orm
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int DefaultMaxStringLength = 140;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ImplicitPkName = "Id";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ImplicitIndexSuffix = "Id";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string SqlDecl(SQLite4Unity3d.TableMapping.Column p, bool storeDateTimeAsTicks)
        {
            string val_9;
            string[] val_1 = new string[5];
            val_1[0] = "\"";
            val_1[1] = p.<Name>k__BackingField;
            val_1[2] = "\" ";
            val_1[3] = SQLite4Unity3d.Orm.SqlType(p:  p, storeDateTimeAsTicks:  storeDateTimeAsTicks);
            val_1[4] = " ";
            val_9 = +val_1;
            if((p.<IsPK>k__BackingField) != false)
            {
                    val_9 = val_9 + "primary key ";
            }
            
            if((p.<IsAutoInc>k__BackingField) != false)
            {
                    val_9 = val_9 + "autoincrement ";
            }
            
            if((p.<IsNullable>k__BackingField) != true)
            {
                    val_9 = val_9 + "not null ";
            }
            
            if((System.String.IsNullOrEmpty(value:  p.<Collation>k__BackingField)) == false)
            {
                    return val_9 + "collate " + p.<Collation>k__BackingField(p.<Collation>k__BackingField) + " ";
            }
            
            return val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string SqlType(SQLite4Unity3d.TableMapping.Column p, bool storeDateTimeAsTicks)
        {
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)
            {
                    if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_19;
            }
            
            }
            
            return "integer";
            label_19:
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    if(((-2141469912) & 1) == 0)
            {
                    return "integer";
            }
            
                string val_25 = "varchar(" + p.<MaxStringLength>k__BackingField(p.<MaxStringLength>k__BackingField) + ")";
                return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    if(storeDateTimeAsTicks == true)
            {
                    return "integer";
            }
            
                return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
            {
                    return "integer";
            }
            
            if(((p.<ColumnType>k__BackingField) & 1) != 0)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    return "integer";
            }
            
            if((System.Type.op_Equality(left:  p.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    return "integer";
            }
            
            System.NotSupportedException val_37 = new System.NotSupportedException(message:  "Don\'t know about " + p.<ColumnType>k__BackingField(p.<ColumnType>k__BackingField));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsPK(System.Reflection.MemberInfo p)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            return (bool)(null != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Collation(System.Reflection.MemberInfo p)
        {
            var val_5;
            var val_6;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_5 = p;
            if(null == null)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_5 = 0;
            val_6 = val_5 + 16;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAutoInc(System.Reflection.MemberInfo p)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            return (bool)(null != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.IEnumerable<SQLite4Unity3d.IndexedAttribute> GetIndices(System.Reflection.MemberInfo p)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(p != null)
            {
                    return System.Linq.Enumerable.Cast<SQLite4Unity3d.IndexedAttribute>(source:  p);
            }
            
            return System.Linq.Enumerable.Cast<SQLite4Unity3d.IndexedAttribute>(source:  p);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Nullable<int> MaxStringLength(System.Reflection.PropertyInfo p)
        {
            var val_5;
            var val_6;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_5 = p;
            if(null != null)
            {
                    val_6 = 0;
                return (System.Nullable<System.Int32>)val_6;
            }
            
            val_6 = 0;
            return (System.Nullable<System.Int32>)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsMarkedNotNull(System.Reflection.MemberInfo p)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            return (bool)(null != 0) ? 1 : 0;
        }
    
    }

}
