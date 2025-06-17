using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TableMapping
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Type <MappedType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <TableName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableMapping.Column[] <Columns>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableMapping.Column <PK>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <GetByPrimaryKeySql>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableMapping.Column _autoPk;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableMapping.Column[] _insertColumns;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableMapping.Column[] _insertOrReplaceColumns;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasAutoIncPK>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.PreparedSqlLiteInsertCommand _insertCommand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _insertCommandExtra;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type MappedType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TableName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column[] Columns { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column PK { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetByPrimaryKeySql { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasAutoIncPK { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column[] InsertColumns { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column[] InsertOrReplaceColumns { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type get_MappedType()
        {
            return (System.Type)this.<MappedType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_MappedType(System.Type value)
        {
            this.<MappedType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_TableName()
        {
            return (string)this.<TableName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_TableName(string value)
        {
            this.<TableName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column[] get_Columns()
        {
            return (Column[])this.<Columns>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Columns(SQLite4Unity3d.TableMapping.Column[] value)
        {
            this.<Columns>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column get_PK()
        {
            return (Column)this.<PK>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_PK(SQLite4Unity3d.TableMapping.Column value)
        {
            this.<PK>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_GetByPrimaryKeySql()
        {
            return (string)this.<GetByPrimaryKeySql>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_GetByPrimaryKeySql(string value)
        {
            this.<GetByPrimaryKeySql>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TableMapping(System.Type type, SQLite4Unity3d.CreateFlags createFlags = 0)
        {
            var val_12;
            var val_13;
            var val_14;
            this.<MappedType>k__BackingField = type;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_12 = public static System.Object System.Linq.Enumerable::FirstOrDefault<System.Object>(System.Collections.Generic.IEnumerable<TSource> source);
            if((System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  type)) != null)
            {
                    val_12 = 0;
            }
            
            this.<TableName>k__BackingField = this.<MappedType>k__BackingField;
            val_13 = 0;
            T[] val_8 = new System.Collections.Generic.List<Column>().ToArray();
            val_14 = 0;
            this.<Columns>k__BackingField = val_8;
            goto label_21;
            label_28:
            T val_12 = val_8[0];
            if((val_8[0x0][0] + 48) == 0)
            {
                goto label_24;
            }
            
            if((val_8[0x0][0] + 50) == 0)
            {
                goto label_26;
            }
            
            this._autoPk = val_12;
            label_24:
            if((val_8[0x0][0] + 50) != 0)
            {
                    this.<PK>k__BackingField = val_12;
            }
            
            label_26:
            val_14 = 1;
            label_21:
            if(val_14 < val_8.Length)
            {
                goto label_28;
            }
            
            this.<HasAutoIncPK>k__BackingField = (this._autoPk != 0) ? 1 : 0;
            if((this.<PK>k__BackingField) != null)
            {
                    string val_10 = System.String.Format(format:  "select * from \"{0}\" where \"{1}\" = ?", arg0:  this.<TableName>k__BackingField, arg1:  this.<PK>k__BackingField.<Name>k__BackingField);
            }
            
            this.<GetByPrimaryKeySql>k__BackingField = System.String.Format(format:  "select * from \"{0}\" limit 1", arg0:  this.<TableName>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasAutoIncPK()
        {
            return (bool)this.<HasAutoIncPK>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasAutoIncPK(bool value)
        {
            this.<HasAutoIncPK>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAutoIncPK(object obj, long id)
        {
            long val_2 = id;
            if(this._autoPk == null)
            {
                    return;
            }
            
            object val_1 = System.Convert.ChangeType(value:  val_2 = id, conversionType:  this._autoPk.<ColumnType>k__BackingField, provider:  0);
            val_2 = this._autoPk._prop;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column[] get_InsertColumns()
        {
            Column[] val_4;
            var val_5;
            System.Func<Column, System.Boolean> val_7;
            val_4 = this._insertColumns;
            if(val_4 != null)
            {
                    return (Column[])val_3;
            }
            
            val_5 = null;
            val_5 = null;
            val_7 = TableMapping.<>c.<>9__30_0;
            if(val_7 == null)
            {
                    System.Func<Column, System.Boolean> val_1 = null;
                val_7 = val_1;
                val_1 = new System.Func<Column, System.Boolean>(object:  TableMapping.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TableMapping.<>c::<get_InsertColumns>b__30_0(SQLite4Unity3d.TableMapping.Column c));
                TableMapping.<>c.<>9__30_0 = val_7;
            }
            
            TSource[] val_3 = System.Linq.Enumerable.ToArray<Column>(source:  System.Linq.Enumerable.Where<Column>(source:  this.<Columns>k__BackingField, predicate:  val_1));
            this._insertColumns = val_3;
            return (Column[])val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column[] get_InsertOrReplaceColumns()
        {
            if(this._insertOrReplaceColumns != null)
            {
                    return (Column[])val_1;
            }
            
            TSource[] val_1 = System.Linq.Enumerable.ToArray<Column>(source:  this.<Columns>k__BackingField);
            this._insertOrReplaceColumns = val_1;
            return (Column[])val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column FindColumnWithPropertyName(string propertyName)
        {
            .propertyName = propertyName;
            return System.Linq.Enumerable.FirstOrDefault<Column>(source:  this.<Columns>k__BackingField, predicate:  new System.Func<Column, System.Boolean>(object:  new TableMapping.<>c__DisplayClass33_0(), method:  System.Boolean TableMapping.<>c__DisplayClass33_0::<FindColumnWithPropertyName>b__0(SQLite4Unity3d.TableMapping.Column c)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping.Column FindColumn(string columnName)
        {
            .columnName = columnName;
            return System.Linq.Enumerable.FirstOrDefault<Column>(source:  this.<Columns>k__BackingField, predicate:  new System.Func<Column, System.Boolean>(object:  new TableMapping.<>c__DisplayClass34_0(), method:  System.Boolean TableMapping.<>c__DisplayClass34_0::<FindColumn>b__0(SQLite4Unity3d.TableMapping.Column c)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.PreparedSqlLiteInsertCommand GetInsertCommand(SQLite4Unity3d.SQLiteConnection conn, string extra)
        {
            string val_4;
            SQLite4Unity3d.PreparedSqlLiteInsertCommand val_5;
            if(this._insertCommand != null)
            {
                    val_4 = this;
                val_5 = this._insertCommand;
                if((System.String.op_Inequality(a:  this._insertCommandExtra, b:  extra)) == false)
            {
                    return val_5;
            }
            
                val_5.Dispose();
                val_5 = this.CreateInsertCommand(conn:  conn, extra:  extra);
                this._insertCommand = val_5;
            }
            else
            {
                    val_5 = this.CreateInsertCommand(conn:  conn, extra:  extra);
                this._insertCommand = val_5;
                val_4 = this._insertCommandExtra;
            }
            
            mem2[0] = extra;
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.PreparedSqlLiteInsertCommand CreateInsertCommand(SQLite4Unity3d.SQLiteConnection conn, string extra)
        {
            SQLite4Unity3d.SQLiteConnection val_18;
            System.Collections.Generic.IEnumerable<TSource> val_19;
            Column val_20;
            var val_22;
            System.Func<Column, System.String> val_24;
            SQLite4Unity3d.SQLiteConnection val_25;
            var val_26;
            System.Func<Column, System.String> val_28;
            SQLite4Unity3d.SQLiteConnection val_29;
            val_18 = conn;
            Column[] val_1 = this.InsertColumns;
            val_19 = val_1;
            if(((System.Linq.Enumerable.Any<Column>(source:  val_1)) == true) || ((System.Linq.Enumerable.Count<Column>(source:  this.<Columns>k__BackingField)) != 1))
            {
                goto label_6;
            }
            
            val_20 = this.<Columns>k__BackingField[0];
            if((this.<Columns>k__BackingField[0].<IsAutoInc>k__BackingField) == false)
            {
                goto label_6;
            }
            
            string val_4 = System.String.Format(format:  "insert {1} into \"{0}\" default values", arg0:  this.<TableName>k__BackingField, arg1:  extra);
            goto label_7;
            label_6:
            if((System.String.Compare(strA:  extra, strB:  "OR REPLACE", comparisonType:  5)) == 0)
            {
                    val_19 = this.InsertOrReplaceColumns;
            }
            
            object[] val_7 = new object[4];
            val_7[0] = this.<TableName>k__BackingField;
            val_22 = null;
            val_22 = null;
            val_24 = TableMapping.<>c.<>9__38_0;
            if(val_24 == null)
            {
                    val_25 = val_18;
                System.Func<Column, System.String> val_8 = null;
                val_24 = val_8;
                val_8 = new System.Func<Column, System.String>(object:  TableMapping.<>c.__il2cppRuntimeField_static_fields, method:  System.String TableMapping.<>c::<CreateInsertCommand>b__38_0(SQLite4Unity3d.TableMapping.Column c));
                val_18 = ;
                TableMapping.<>c.<>9__38_0 = val_24;
            }
            
            val_20 = 1152921519620573184;
            val_7[1] = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  val_19, selector:  val_8)));
            val_26 = null;
            val_26 = null;
            val_28 = TableMapping.<>c.<>9__38_1;
            if(val_28 == null)
            {
                    val_29 = val_18;
                System.Func<Column, System.String> val_12 = null;
                val_28 = val_12;
                val_12 = new System.Func<Column, System.String>(object:  TableMapping.<>c.__il2cppRuntimeField_static_fields, method:  System.String TableMapping.<>c::<CreateInsertCommand>b__38_1(SQLite4Unity3d.TableMapping.Column c));
                val_18 = ;
                TableMapping.<>c.<>9__38_1 = val_28;
            }
            
            val_7[2] = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  val_19, selector:  val_12)));
            val_7[3] = extra;
            label_7:
            .<Connection>k__BackingField = val_18;
            .<CommandText>k__BackingField = System.String.Format(format:  "insert {3} into \"{0}\"({1}) values ({2})", args:  val_7);
            return (SQLite4Unity3d.PreparedSqlLiteInsertCommand)new SQLite4Unity3d.PreparedSqlLiteInsertCommand();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal void Dispose()
        {
            if(this._insertCommand == null)
            {
                    return;
            }
            
            this._insertCommand.Dispose();
            this._insertCommand = 0;
        }
    
    }

}
