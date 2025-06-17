using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SQLiteConnection : IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _open;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.TimeSpan _busyTimeout;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, SQLite4Unity3d.TableMapping> _mappings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, SQLite4Unity3d.TableMapping> _tables;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Diagnostics.Stopwatch _sw;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _elapsedMilliseconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _transactionDepth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Random _rand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private IntPtr <Handle>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly IntPtr NullHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <DatabasePath>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <TimeExecution>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Trace>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <StoreDateTimeAsTicks>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _preserveDuringLinkMagic;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntPtr Handle { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DatabasePath { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TimeExecution { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Trace { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool StoreDateTimeAsTicks { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.TimeSpan BusyTimeout { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<SQLite4Unity3d.TableMapping> TableMappings { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInTransaction { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntPtr get_Handle()
        {
            return (IntPtr)this.<Handle>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Handle(IntPtr value)
        {
            this.<Handle>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DatabasePath()
        {
            return (string)this.<DatabasePath>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DatabasePath(string value)
        {
            this.<DatabasePath>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_TimeExecution()
        {
            return (bool)this.<TimeExecution>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TimeExecution(bool value)
        {
            this.<TimeExecution>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Trace()
        {
            return (bool)this.<Trace>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Trace(bool value)
        {
            this.<Trace>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_StoreDateTimeAsTicks()
        {
            return (bool)this.<StoreDateTimeAsTicks>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_StoreDateTimeAsTicks(bool value)
        {
            this.<StoreDateTimeAsTicks>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLiteConnection(string databasePath, bool storeDateTimeAsTicks = False)
        {
            bool val_1 = storeDateTimeAsTicks;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLiteConnection(string databasePath, SQLite4Unity3d.SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = False)
        {
            var val_11;
            var val_12;
            IntPtr val_4 = 0;
            this._rand = new System.Random();
            if((System.String.IsNullOrEmpty(value:  databasePath)) == true)
            {
                goto label_1;
            }
            
            this.<DatabasePath>k__BackingField = databasePath;
            Result val_5 = SQLite4Unity3d.SQLite3.Open(filename:  SQLite4Unity3d.SQLiteConnection.GetNullTerminatedUtf8(s:  databasePath), db: out  val_4, flags:  openFlags, zvfs:  0);
            this.<Handle>k__BackingField = val_4;
            if(val_5 != 0)
            {
                goto label_4;
            }
            
            this._open = true;
            this.<StoreDateTimeAsTicks>k__BackingField = storeDateTimeAsTicks;
            System.TimeSpan val_7 = System.TimeSpan.FromSeconds(value:  0.1);
            this.BusyTimeout = new System.TimeSpan() {_ticks = val_7._ticks};
            return;
            label_1:
            val_11 = 1152921519618957632;
            val_12 = new System.ArgumentException(message:  "Must be specified", paramName:  "databasePath");
            goto label_7;
            label_4:
            SQLite4Unity3d.SQLiteException val_10 = SQLite4Unity3d.SQLiteException.New(r:  val_5, message:  System.String.Format(format:  "Could not open database file: {0} ({1})", arg0:  this.<DatabasePath>k__BackingField, arg1:  val_5));
            val_11 = 1152921519618957632;
            label_7:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SQLiteConnection()
        {
            if(SQLite4Unity3d.SQLiteConnection._preserveDuringLinkMagic == false)
            {
                    return;
            }
            
            SQLiteConnection.ColumnInfo val_1 = new SQLiteConnection.ColumnInfo();
            .<Name>k__BackingField = "magic";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EnableLoadExtension(int onoff)
        {
            Result val_1 = SQLite4Unity3d.SQLite3.EnableLoadExtension(db:  this.<Handle>k__BackingField, onoff:  onoff);
            if(val_1 == 0)
            {
                    return;
            }
            
            SQLite4Unity3d.SQLiteException val_3 = SQLite4Unity3d.SQLiteException.New(r:  val_1, message:  SQLite4Unity3d.SQLite3.GetErrmsg(db:  this.<Handle>k__BackingField));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static byte[] GetNullTerminatedUtf8(string s)
        {
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8 + 1;
            int val_5 = s.Length;
            if(System.Text.Encoding.UTF8 != null)
            {
                    return (System.Byte[])new byte[0];
            }
            
            return (System.Byte[])new byte[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.TimeSpan get_BusyTimeout()
        {
            return (System.TimeSpan)this._busyTimeout;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BusyTimeout(System.TimeSpan value)
        {
            var val_3;
            this._busyTimeout = value;
            val_3 = null;
            val_3 = null;
            if((System.IntPtr.op_Inequality(value1:  this.<Handle>k__BackingField, value2:  SQLite4Unity3d.SQLiteConnection.NullHandle)) == false)
            {
                    return;
            }
            
            Result val_2 = SQLite4Unity3d.SQLite3.BusyTimeout(db:  this.<Handle>k__BackingField, milliseconds:  (int)D0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<SQLite4Unity3d.TableMapping> get_TableMappings()
        {
            if(this._tables == null)
            {
                    return System.Linq.Enumerable.Empty<SQLite4Unity3d.TableMapping>();
            }
            
            return this._tables.Values;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping GetMapping(System.Type type, SQLite4Unity3d.CreateFlags createFlags = 0)
        {
            SQLite4Unity3d.CreateFlags val_5;
            string val_6;
            val_5 = createFlags;
            val_6 = type;
            if(this._mappings == null)
            {
                goto label_1;
            }
            
            label_7:
            if((this._mappings.TryGetValue(key:  val_6, value: out  0)) == true)
            {
                    return val_3;
            }
            
            SQLite4Unity3d.TableMapping val_3 = new SQLite4Unity3d.TableMapping(type:  val_6, createFlags:  val_5);
            val_6 = val_3;
            val_5 = val_6;
            this._mappings.set_Item(key:  val_5, value:  val_3);
            return val_3;
            label_1:
            this._mappings = new System.Collections.Generic.Dictionary<System.String, SQLite4Unity3d.TableMapping>();
            if(val_6 != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping GetMapping<T>()
        {
            if(this != null)
            {
                    return this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0);
            }
            
            return this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DropTable<T>()
        {
            if(this != null)
            {
                    return this.Execute(query:  System.String.Format(format:  "drop table if exists \"{0}\"", arg0:  this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0).TableName), args:  System.Array.Empty<System.Object>());
            }
            
            return this.Execute(query:  System.String.Format(format:  "drop table if exists \"{0}\"", arg0:  this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0).TableName), args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CreateTable<T>(SQLite4Unity3d.CreateFlags createFlags = 0)
        {
            if(this != null)
            {
                    return this.CreateTable(ty:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  createFlags);
            }
            
            return this.CreateTable(ty:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  createFlags);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CreateTable(System.Type ty, SQLite4Unity3d.CreateFlags createFlags = 0)
        {
            var val_25;
            var val_27;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            string val_49;
            string val_50;
            var val_51;
            var val_52;
            var val_54;
            string val_56;
            var val_57;
            System.Func<IndexedColumn, System.Int32> val_59;
            var val_60;
            System.Func<IndexedColumn, System.String> val_62;
            int val_63;
            var val_64;
            var val_65;
            if(mem[1152921519620805416] == 0)
            {
                goto label_1;
            }
            
            label_88:
            if((mem[1152921519620805416].TryGetValue(key:  ty, value: out  0)) != true)
            {
                    SQLite4Unity3d.TableMapping val_3 = this.GetMapping(type:  ty, createFlags:  createFlags);
                mem[1152921519620805416].Add(key:  ty, value:  val_3);
            }
            
            int val_12 = this.Execute(query:  "create table if not exists \"" + val_3 + 24(val_3 + 24) + "\"(\n"("create table if not exists \"" + val_3 + 24(val_3 + 24) + "\"(\n") + System.String.Join(separator:  ",\n", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  val_3 + 32, selector:  new System.Func<Column, System.String>(object:  this, method:  System.String SQLite4Unity3d.SQLiteConnection::<CreateTable>b__46_0(SQLite4Unity3d.TableMapping.Column p)))))(System.String.Join(separator:  ",\n", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  val_3 + 32, selector:  new System.Func<Column, System.String>(object:  this, method:  System.String SQLite4Unity3d.SQLiteConnection::<CreateTable>b__46_0(SQLite4Unity3d.TableMapping.Column p))))))("create table if not exists \"" + val_3 + 24(val_3 + 24) + "\"(\n"("create table if not exists \"" + val_3 + 24(val_3 + 24) + "\"(\n") + System.String.Join(separator:  ",\n", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  val_3 + 32, selector:  new System.Func<Column, System.String>(object:  this, method:  System.String SQLite4Unity3d.SQLiteConnection::<CreateTable>b__46_0(SQLite4Unity3d.TableMapping.Column p)))))(System.String.Join(separator:  ",\n", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  val_3 + 32, selector:  new System.Func<Column, System.String>(object:  this, method:  System.String SQLite4Unity3d.SQLiteConnection::<CreateTable>b__46_0(SQLite4Unity3d.TableMapping.Column p))))))) + ")", args:  System.Array.Empty<System.Object>());
            if(val_12 == 0)
            {
                    this.MigrateTable(map:  val_3);
            }
            
            System.Collections.Generic.Dictionary<System.String, IndexInfo> val_13 = new System.Collections.Generic.Dictionary<System.String, IndexInfo>();
            val_41 = mem[val_3 + 32];
            val_41 = val_3 + 32;
            val_42 = 1152921504685174784;
            val_43 = 0;
            val_44 = 0;
            val_45 = 0;
            goto label_10;
            label_70:
            var val_14 = val_41 + 0;
            var val_45 = (val_3 + 32 + 0) + 32 + 56;
            if(((val_3 + 32 + 0) + 32 + 56 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_43 = (val_3 + 32 + 0) + 32 + 56 + 176;
            var val_44 = 0;
            val_43 = val_43 + 8;
            label_16:
            if((((val_3 + 32 + 0) + 32 + 56 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_44 = val_44 + 1;
            val_43 = val_43 + 16;
            if(val_44 < ((val_3 + 32 + 0) + 32 + 56 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            val_45 = val_45 + ((((val_3 + 32 + 0) + 32 + 56 + 176 + 8)) << 4);
            val_46 = val_45 + 296;
            label_17:
            System.Collections.Generic.IEnumerator<T> val_15 = (val_3 + 32 + 0) + 32 + 56.GetEnumerator();
            label_40:
            var val_46 = 0;
            val_46 = val_46 + 1;
            if(val_15.MoveNext() == false)
            {
                goto label_23;
            }
            
            var val_47 = 0;
            val_47 = val_47 + 1;
            T val_19 = val_15.Current;
            val_49 = mem[val_19 + 16];
            val_49 = val_19 + 16;
            if(val_49 == 0)
            {
                    val_49 = val_3 + 24(val_3 + 24) + "_" + (val_3 + 32 + 0) + 32 + 24((val_3 + 32 + 0) + 32 + 24);
            }
            
            val_50 = val_49;
            if((val_13.TryGetValue(key:  val_50, value: out  new IndexInfo() {Unique = false})) != true)
            {
                    System.Collections.Generic.List<IndexedColumn> val_22 = new System.Collections.Generic.List<IndexedColumn>();
                T val_23 = val_19 & 1;
                mem[6] = 0;
                mem[4] = 0;
                mem2[0] = 0;
                val_50 = val_49;
                val_13.Add(key:  val_50, value:  new IndexInfo() {IndexName = val_49, TableName = val_49, Unique = val_23, Columns = val_23});
            }
            
            var val_24 = (val_23 != 0) ? 1 : 0;
            val_24 = val_19 ^ val_24;
            if((val_24 & 1) != 0)
            {
                goto label_37;
            }
            
            null.Add(item:  new IndexedColumn() {Order = val_19 + 24, ColumnName = (val_3 + 32 + 0) + 32 + 24});
            goto label_40;
            label_23:
            val_43 = val_25;
            val_51 = val_44;
            val_52 = 456;
            if(val_15 != null)
            {
                goto label_41;
            }
            
            goto label_61;
            label_37:
            new System.Exception() = new System.Exception(message:  "All the columns in an index must have the same value for their Unique property");
            goto label_97;
            label_41:
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_15.Dispose();
            label_61:
            var val_29 = ( == 0) ? 456 : ();
            if(val_29 == 456)
            {
                    val_41 = val_41;
                val_45 = 0;
            }
            else
            {
                    val_41 = val_41;
                if(null != null)
            {
                    val_43 = 0;
            }
            
            }
            
            val_44 =  + 1;
            label_10:
            val_27 = val_29;
            val_25 = val_43;
            if(val_44 < (val_3 + 32 + 24))
            {
                goto label_70;
            }
            
            val_56 = val_13.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_31 = val_56.GetEnumerator();
            goto label_73;
            label_85:
            val_56 = val_49.emailUIDataHandler;
            IndexInfo val_33 = val_13.Item[val_56];
            val_57 = null;
            val_57 = null;
            val_59 = SQLiteConnection.<>c.<>9__46_1;
            if(val_59 == null)
            {
                    val_59 = null;
                val_59 = new System.Func<IndexedColumn, System.Int32>(object:  SQLiteConnection.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 SQLiteConnection.<>c::<CreateTable>b__46_1(SQLite4Unity3d.SQLiteConnection.IndexedColumn i));
                SQLiteConnection.<>c.<>9__46_1 = val_59;
            }
            
            val_60 = null;
            val_60 = null;
            val_62 = SQLiteConnection.<>c.<>9__46_2;
            if(val_62 == null)
            {
                    val_62 = null;
                val_62 = new System.Func<IndexedColumn, System.String>(object:  SQLiteConnection.<>c.__il2cppRuntimeField_static_fields, method:  System.String SQLiteConnection.<>c::<CreateTable>b__46_2(SQLite4Unity3d.SQLiteConnection.IndexedColumn i));
                SQLiteConnection.<>c.<>9__46_2 = val_62;
            }
            
            int val_49 = val_12;
            val_49 = (this.CreateIndex(indexName:  val_56, tableName:  val_49, columnNames:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<IndexedColumn, System.String>(source:  System.Linq.Enumerable.OrderBy<IndexedColumn, System.Int32>(source:  val_23, keySelector:  null), selector:  null)), unique:  (val_23 != 0) ? 1 : 0)) + val_49;
            label_73:
            if((2129044304 & 1) != 0)
            {
                goto label_85;
            }
            
            val_63 = val_49;
            val_64 = val_25;
            val_65 = 655;
            goto label_86;
            label_1:
            mem[1152921519620805416] = new System.Collections.Generic.Dictionary<System.String, SQLite4Unity3d.TableMapping>();
            if(ty != null)
            {
                goto label_88;
            }
            
            goto label_88;
            label_97:
            val_65 = val_27;
            val_54 = new System.Exception();
            if(0 != 1)
            {
                goto label_98;
            }
            
            val_63 = val_49;
            label_86:
            long val_42 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519620793168});
            if(null == null)
            {
                    return val_63;
            }
            
            if(val_65 == 0)
            {
                    return val_63;
            }
            
            if(val_65 == 655)
            {
                    return val_63;
            }
            
            return val_63;
            label_98:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CreateIndex(string indexName, string tableName, string[] columnNames, bool unique = False)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(tableName != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(tableName == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = tableName;
            val_1[1] = System.String.Join(separator:  "\", \"", value:  columnNames);
            val_1[2] = (unique != true) ? "unique" : "";
            val_1[3] = indexName;
            return this.Execute(query:  System.String.Format(format:  "create {2} index if not exists \"{3}\" on \"{0}\"(\"{1}\")", args:  val_1), args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CreateIndex(string indexName, string tableName, string columnName, bool unique = False)
        {
            string[] val_1 = new string[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(columnName != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(columnName == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = columnName;
            unique = unique;
            return this.CreateIndex(indexName:  indexName, tableName:  tableName, columnNames:  val_1, unique:  unique);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CreateIndex(string tableName, string columnName, bool unique = False)
        {
            return this.CreateIndex(indexName:  tableName + "_" + columnName, tableName:  tableName, columnName:  columnName, unique:  unique);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CreateIndex(string tableName, string[] columnNames, bool unique = False)
        {
            return this.CreateIndex(indexName:  tableName + "_" + System.String.Join(separator:  "_", value:  columnNames)(System.String.Join(separator:  "_", value:  columnNames)), tableName:  tableName, columnNames:  columnNames, unique:  unique);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateIndex<T>(System.Linq.Expressions.Expression<System.Func<T, object>> property, bool unique = False)
        {
            var val_14;
            var val_15;
            var val_16;
            val_14 = property.Body;
            val_15 = property.Body;
            if(val_14 != 10)
            {
                goto label_4;
            }
            
            if(val_15 == null)
            {
                goto label_5;
            }
            
            val_14 = null;
            if(val_15 != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_5:
            label_8:
            label_7:
            val_15 = 0.Operand;
            label_4:
            System.Reflection.MemberInfo val_5 = val_15.Member;
            bool val_6 = System.Reflection.PropertyInfo.op_Equality(left:  val_5, right:  0);
            if(val_6 != true)
            {
                    int val_12 = this.CreateIndex(tableName:  this.TableName, columnName:  this.FindColumnWithPropertyName(propertyName:  (val_6 != true) ? 0 : (val_5)).Name, unique:  unique);
                return;
            }
            
            val_16 = new System.ArgumentException(message:  "The lambda expression \'property\' should point to a valid Property");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<SQLite4Unity3d.SQLiteConnection.ColumnInfo> GetTableInfo(string tableName)
        {
            return this.Query<ColumnInfo>(query:  "pragma table_info(\"" + tableName + "\")", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MigrateTable(SQLite4Unity3d.TableMapping map)
        {
            var val_5;
            var val_18;
            var val_19;
            var val_20;
            System.Collections.Generic.List<Column> val_2 = new System.Collections.Generic.List<Column>();
            val_18 = 0;
            val_19 = 0;
            goto label_3;
            label_23:
            List.Enumerator<T> val_3 = this.GetTableInfo(tableName:  map.<TableName>k__BackingField).GetEnumerator();
            label_9:
            if((2130681408 & 1) == 0)
            {
                goto label_6;
            }
            
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            if((System.String.Compare(strA:  map.<Columns>k__BackingField[0x0][0].<Name>k__BackingField, strB:  val_6._masterDomain, comparisonType:  5)) != 0)
            {
                goto label_9;
            }
            
            val_20 = 1;
            goto label_11;
            label_6:
            val_20 = 0;
            label_11:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519622430272});
            if(((113 == 0) ? 113 : 113) != 113)
            {
                goto label_16;
            }
            
            if(( & 1) == 0)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if( != 0)
            {
                    val_18 = 0;
            }
            
            if(( & 1) != 0)
            {
                goto label_20;
            }
            
            label_17:
            val_2.Add(item:  map.<Columns>k__BackingField[0]);
            label_20:
            val_19 = 1;
            label_3:
            if(val_19 < (map.<Columns>k__BackingField.Length))
            {
                goto label_23;
            }
            
            List.Enumerator<T> val_10 = val_2.GetEnumerator();
            label_27:
            if((2130681384 & 1) == 0)
            {
                goto label_28;
            }
            
            int val_15 = this.Execute(query:  "alter table \"" + map + 24(map + 24) + "\" add column " + SQLite4Unity3d.Orm.SqlDecl(p:  0.emailUIDataHandler, storeDateTimeAsTicks:  mem[1152921519622442498])(SQLite4Unity3d.Orm.SqlDecl(p:  0.emailUIDataHandler, storeDateTimeAsTicks:  mem[1152921519622442498])), args:  System.Array.Empty<System.Object>());
            goto label_27;
            label_28:
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519622430248});
            if( == 0)
            {
                    return;
            }
            
            if(229 == 0)
            {
                    return;
            }
            
            if(229 == 229)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual SQLite4Unity3d.SQLiteCommand NewCommand()
        {
            return (SQLite4Unity3d.SQLiteCommand)new SQLite4Unity3d.SQLiteCommand(conn:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.SQLiteCommand CreateCommand(string cmdText, object[] ps)
        {
            System.Collections.Generic.Dictionary<System.String, SQLite4Unity3d.TableMapping> val_2;
            var val_3;
            val_2 = cmdText;
            if(this._open == false)
            {
                goto label_1;
            }
            
            val_3 = 0;
            this._mappings = val_2;
            goto label_3;
            label_7:
            val_2 = ps[0];
            this.Bind(name:  0, val:  val_2);
            val_3 = 1;
            label_3:
            if(val_3 < ps.Length)
            {
                goto label_7;
            }
            
            return (SQLite4Unity3d.SQLiteCommand)this;
            label_1:
            SQLite4Unity3d.SQLiteException val_1 = SQLite4Unity3d.SQLiteException.New(r:  1, message:  "Cannot create commands from unopened database");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Execute(string query, object[] args)
        {
            string val_6;
            System.Diagnostics.Stopwatch val_7;
            val_6 = query;
            if((this.<TimeExecution>k__BackingField) != false)
            {
                    val_7 = this._sw;
                if(val_7 == null)
            {
                    System.Diagnostics.Stopwatch val_2 = null;
                val_7 = val_2;
                val_2 = new System.Diagnostics.Stopwatch();
                this._sw = val_7;
            }
            
                val_2.Reset();
                val_6 = this._sw;
                val_6.Start();
            }
            
            if((this.<TimeExecution>k__BackingField) == false)
            {
                    return (int)this.CreateCommand(cmdText:  val_6, ps:  args).ExecuteNonQuery();
            }
            
            this._sw.Stop();
            val_6 = this._sw;
            this._elapsedMilliseconds = val_6.ElapsedMilliseconds + this._elapsedMilliseconds;
            return (int)this.CreateCommand(cmdText:  val_6, ps:  args).ExecuteNonQuery();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T ExecuteScalar<T>(string query, object[] args)
        {
            string val_8;
            System.Diagnostics.Stopwatch val_9;
            System.Diagnostics.Stopwatch val_10;
            val_8 = query;
            if(this != null)
            {
                    val_9 = this.CreateCommand(cmdText:  val_8, ps:  args);
            }
            else
            {
                    val_9 = this.CreateCommand(cmdText:  val_8, ps:  args);
            }
            
            if(this.TimeExecution != false)
            {
                    val_10 = this._sw;
                if(val_10 == null)
            {
                    System.Diagnostics.Stopwatch val_4 = null;
                val_10 = val_4;
                val_4 = new System.Diagnostics.Stopwatch();
                this._sw = val_10;
            }
            
                val_4.Reset();
                val_8 = this._sw;
                val_8.Start();
            }
            
            if(this.TimeExecution == false)
            {
                    return (long)val_9;
            }
            
            this._sw.Stop();
            val_9 = this._sw;
            this._elapsedMilliseconds = val_9.ElapsedMilliseconds + this._elapsedMilliseconds;
            return (long)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<T> Query<T>(string query, object[] args)
        {
            if((this.CreateCommand(cmdText:  query, ps:  args)) == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<T> DeferredQuery<T>(string query, object[] args)
        {
            if((this.CreateCommand(cmdText:  query, ps:  args)) == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<object> Query(SQLite4Unity3d.TableMapping map, string query, object[] args)
        {
            SQLite4Unity3d.SQLiteCommand val_1 = this.CreateCommand(cmdText:  query, ps:  args);
            if(val_1 != null)
            {
                    return val_1.ExecuteQuery<System.Object>(map:  map);
            }
            
            return val_1.ExecuteQuery<System.Object>(map:  map);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<object> DeferredQuery(SQLite4Unity3d.TableMapping map, string query, object[] args)
        {
            SQLite4Unity3d.SQLiteCommand val_1 = this.CreateCommand(cmdText:  query, ps:  args);
            if(val_1 != null)
            {
                    return val_1.ExecuteDeferredQuery<System.Object>(map:  map);
            }
            
            return val_1.ExecuteDeferredQuery<System.Object>(map:  map);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> Table<T>()
        {
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
            {
                    return (SQLite4Unity3d.TableQuery<T>)__RuntimeMethodHiddenParam + 48;
            }
            
            return (SQLite4Unity3d.TableQuery<T>)__RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Get<T>(object pk)
        {
            string val_3 = this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0).GetByPrimaryKeySql;
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_5;
            }
            
            if(pk != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(pk == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_4[0] = pk;
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Get<T>(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Find<T>(object pk)
        {
            string val_3 = this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0).GetByPrimaryKeySql;
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_5;
            }
            
            if(pk != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(pk == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_4[0] = pk;
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Find(object pk, SQLite4Unity3d.TableMapping map)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(pk != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(pk == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = pk;
            return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.Query(map:  map, query:  map.<GetByPrimaryKeySql>k__BackingField, args:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Find<T>(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsInTransaction()
        {
            return (bool)(this._transactionDepth > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginTransaction(bool exclusive = False)
        {
            var val_10;
            var val_11;
            var val_12;
            if((System.Threading.Interlocked.CompareExchange(location1: ref  this._transactionDepth, value:  1, comparand:  0)) == 0)
            {
                    if(exclusive != false)
            {
                    int val_4 = this.Execute(query:  "BEGIN EXCLUSIVE TRANSACTION;", args:  System.Array.Empty<System.Object>());
                return;
            }
            
                int val_6 = this.Execute(query:  "begin transaction", args:  System.Array.Empty<System.Object>());
                return;
            }
            
            val_10 = 1152921519625304720;
            val_11 = new System.InvalidOperationException(message:  "Cannot begin a transaction while already in a transaction.");
            val_12 = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SaveTransactionPoint()
        {
            var val_8;
            int val_8 = System.Threading.Interlocked.Increment(location: ref  this._transactionDepth);
            object[] val_3 = new object[4];
            if("S" == null)
            {
                    val_8 = 0;
            }
            
            if(val_3.Length == 0)
            {
                    val_8 = 0;
            }
            
            val_3[0] = "S";
            val_3[1] = this._rand;
            val_8 = val_8 - 1;
            val_3[2] = "D";
            val_3[3] = val_8;
            string val_4 = +val_3;
            int val_7 = this.Execute(query:  "savepoint " + val_4, args:  System.Array.Empty<System.Object>());
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Rollback()
        {
            this.RollbackTo(savepoint:  0, noThrow:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RollbackTo(string savepoint)
        {
            this.RollbackTo(savepoint:  savepoint, noThrow:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RollbackTo(string savepoint, bool noThrow)
        {
            if((System.String.IsNullOrEmpty(value:  savepoint)) != false)
            {
                    if((System.Threading.Interlocked.Exchange(location1: ref  this._transactionDepth, value:  0)) <= 0)
            {
                    return;
            }
            
                int val_5 = this.Execute(query:  "rollback", args:  System.Array.Empty<System.Object>());
                return;
            }
            
            this.DoSavePointExecute(savepoint:  savepoint, cmd:  "rollback to ");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Release(string savepoint)
        {
            this.DoSavePointExecute(savepoint:  savepoint, cmd:  "release ");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DoSavePointExecute(string savepoint, string cmd)
        {
            int val_4 = 0;
            int val_11 = savepoint.IndexOf(value:  'D');
            if(val_11 >= 2)
            {
                    val_11 = val_11 + 1;
                if(savepoint.Length > val_11)
            {
                    if((((val_4 & 2147483648) == 0) && ((System.Int32.TryParse(s:  savepoint.Substring(startIndex:  val_11), result: out  val_4)) != false)) && (0 < this._transactionDepth))
            {
                    System.Threading.Thread.VolatileWrite(address: ref  int val_6 = this._transactionDepth, value:  0);
                int val_9 = this.Execute(query:  cmd + savepoint, args:  System.Array.Empty<System.Object>());
                return;
            }
            
            }
            
            }
            
            System.ArgumentException val_10 = new System.ArgumentException(message:  "savePoint is not valid, and should be the result of a call to SaveTransactionPoint.", paramName:  "savePoint");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Commit()
        {
            if((System.Threading.Interlocked.Exchange(location1: ref  this._transactionDepth, value:  0)) == 0)
            {
                    return;
            }
            
            int val_4 = this.Execute(query:  "commit", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RunInTransaction(System.Action action)
        {
            action.Invoke();
            this.Release(savepoint:  this.SaveTransactionPoint());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InsertAll(System.Collections.IEnumerable objects)
        {
            SQLiteConnection.<>c__DisplayClass80_0 val_1 = new SQLiteConnection.<>c__DisplayClass80_0();
            if(val_1 != null)
            {
                    .objects = objects;
                .<>4__this = this;
            }
            else
            {
                    mem[16] = objects;
                mem[32] = this;
            }
            
            .c = 0;
            this.RunInTransaction(action:  new System.Action(object:  val_1, method:  System.Void SQLiteConnection.<>c__DisplayClass80_0::<InsertAll>b__0()));
            if(val_1 != null)
            {
                    return (int)(SQLiteConnection.<>c__DisplayClass80_0)[1152921519626901120].c;
            }
            
            return (int)(SQLiteConnection.<>c__DisplayClass80_0)[1152921519626901120].c;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InsertAll(System.Collections.IEnumerable objects, string extra)
        {
            SQLiteConnection.<>c__DisplayClass81_0 val_1 = new SQLiteConnection.<>c__DisplayClass81_0();
            if(val_1 != null)
            {
                    .objects = objects;
                .<>4__this = this;
                .extra = extra;
            }
            else
            {
                    mem[16] = objects;
                mem[32] = this;
                mem[40] = extra;
            }
            
            .c = 0;
            this.RunInTransaction(action:  new System.Action(object:  val_1, method:  System.Void SQLiteConnection.<>c__DisplayClass81_0::<InsertAll>b__0()));
            if(val_1 != null)
            {
                    return (int)(SQLiteConnection.<>c__DisplayClass81_0)[1152921519627046912].c;
            }
            
            return (int)(SQLiteConnection.<>c__DisplayClass81_0)[1152921519627046912].c;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InsertAll(System.Collections.IEnumerable objects, System.Type objType)
        {
            SQLiteConnection.<>c__DisplayClass82_0 val_1 = new SQLiteConnection.<>c__DisplayClass82_0();
            if(val_1 != null)
            {
                    .objects = objects;
                .<>4__this = this;
                .objType = objType;
            }
            else
            {
                    mem[16] = objects;
                mem[32] = this;
                mem[40] = objType;
            }
            
            .c = 0;
            this.RunInTransaction(action:  new System.Action(object:  val_1, method:  System.Void SQLiteConnection.<>c__DisplayClass82_0::<InsertAll>b__0()));
            if(val_1 != null)
            {
                    return (int)(SQLiteConnection.<>c__DisplayClass82_0)[1152921519627192704].c;
            }
            
            return (int)(SQLiteConnection.<>c__DisplayClass82_0)[1152921519627192704].c;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Insert(object obj)
        {
            if(obj == null)
            {
                    return 0;
            }
            
            return this.Insert(obj:  obj, extra:  "", objType:  obj.GetType());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InsertOrReplace(object obj)
        {
            if(obj == null)
            {
                    return 0;
            }
            
            return this.Insert(obj:  obj, extra:  "OR REPLACE", objType:  obj.GetType());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Insert(object obj, System.Type objType)
        {
            return this.Insert(obj:  obj, extra:  "", objType:  objType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InsertOrReplace(object obj, System.Type objType)
        {
            return this.Insert(obj:  obj, extra:  "OR REPLACE", objType:  objType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Insert(object obj, string extra)
        {
            if(obj == null)
            {
                    return 0;
            }
            
            return this.Insert(obj:  obj, extra:  extra, objType:  obj.GetType());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Insert(object obj, string extra, System.Type objType)
        {
            var val_13;
            System.Type val_14;
            var val_15;
            var val_16;
            object val_17;
            var val_19;
            val_14 = objType;
            if(obj != null)
            {
                    if((System.Type.op_Equality(left:  val_14, right:  0)) == false)
            {
                goto label_4;
            }
            
            }
            
            val_15 = 0;
            return (int)val_15;
            label_4:
            val_13 = this.GetMapping(type:  val_14, createFlags:  0);
            if(((val_2.<PK>k__BackingField) != null) && ((val_2.<PK>k__BackingField.<IsAutoInc>k__BackingField) != false))
            {
                    System.Reflection.PropertyInfo val_3 = val_14.GetProperty(name:  val_2.<PK>k__BackingField._prop);
                if((System.Reflection.PropertyInfo.op_Inequality(left:  val_3, right:  0)) != false)
            {
                    val_16 = null;
                val_16 = null;
                val_17 = System.Guid.Empty;
                if((val_3 & 1) != 0)
            {
                    System.Guid val_5 = System.Guid.NewGuid();
            }
            
            }
            
            }
            
            if((System.String.Compare(strA:  extra, strB:  "OR REPLACE", comparisonType:  5)) != 0)
            {
                    Column[] val_7 = val_13.InsertColumns;
            }
            
            object[] val_9 = new object[0];
            val_14 = val_9;
            val_19 = 0;
            goto label_22;
            label_30:
            Column val_13 = val_13.InsertOrReplaceColumns[0];
            val_17 = val_8[0x0][0]._prop;
            val_19 = 1;
            val_14[0] = val_17;
            label_22:
            if(val_19 < val_9.Length)
            {
                goto label_30;
            }
            
            val_15 = val_13.GetInsertCommand(conn:  this, extra:  extra).ExecuteNonQuery(source:  val_9);
            if((val_2.<HasAutoIncPK>k__BackingField) == false)
            {
                    return (int)val_15;
            }
            
            val_13.SetAutoIncPK(obj:  obj, id:  SQLite4Unity3d.SQLite3.LastInsertRowid(db:  this.<Handle>k__BackingField));
            return (int)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Update(object obj)
        {
            if(obj == null)
            {
                    return 0;
            }
            
            return this.Update(obj:  obj, objType:  obj.GetType());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Update(object obj, System.Type objType)
        {
            System.Type val_21;
            SQLite4Unity3d.SQLiteConnection val_22;
            var val_23;
            var val_24;
            Column val_25;
            var val_26;
            var val_27;
            var val_28;
            System.Func<Column, System.String> val_30;
            SQLite4Unity3d.SQLiteException val_31;
            val_21 = objType;
            val_22 = this;
            SQLiteConnection.<>c__DisplayClass90_0 val_1 = new SQLiteConnection.<>c__DisplayClass90_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_23 = val_1;
            .obj = obj;
            if(obj != null)
            {
                goto label_2;
            }
            
            goto label_4;
            label_1:
            val_23 = 24;
            mem[24] = obj;
            if(mem[24] == 0)
            {
                goto label_4;
            }
            
            label_2:
            if((System.Type.op_Equality(left:  val_21, right:  0)) == false)
            {
                goto label_7;
            }
            
            label_4:
            val_24 = 0;
            return (int)this.Execute(query:  System.String.Format(format:  "update \"{0}\" set {1} where {2} = ? ", arg0:  val_3.<TableName>k__BackingField, arg1:  System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<Column>(source:  val_3.<Columns>k__BackingField, predicate:  new System.Func<Column, System.Boolean>(object:  val_1, method:  System.Boolean SQLiteConnection.<>c__DisplayClass90_0::<Update>b__0(SQLite4Unity3d.TableMapping.Column p))), selector:  System.Func<Column, System.String> val_11 = null))), arg2:  val_3.<PK>k__BackingField.<Name>k__BackingField), args:  val_8.ToArray());
            label_7:
            SQLite4Unity3d.TableMapping val_3 = this.GetMapping(type:  val_21, createFlags:  0);
            if(val_1 == null)
            {
                goto label_10;
            }
            
            .pk = val_3.<PK>k__BackingField;
            if((val_3.<PK>k__BackingField) == null)
            {
                goto label_11;
            }
            
            label_14:
            System.Collections.Generic.List<System.Object> val_8 = new System.Collections.Generic.List<System.Object>(collection:  System.Linq.Enumerable.Select<Column, System.Object>(source:  val_5, selector:  new System.Func<Column, System.Object>(object:  val_1, method:  System.Object SQLiteConnection.<>c__DisplayClass90_0::<Update>b__1(SQLite4Unity3d.TableMapping.Column c))));
            if(val_1 == null)
            {
                goto label_12;
            }
            
            val_25 = .pk;
            goto label_13;
            label_10:
            mem[16] = val_3.<PK>k__BackingField;
            if(mem[16] != 0)
            {
                goto label_14;
            }
            
            label_11:
            val_26 = 1152921519628498912;
            val_27 = new System.NotSupportedException(message:  "Cannot update " + val_3.<TableName>k__BackingField(val_3.<TableName>k__BackingField) + ": it has no PK"(": it has no PK"));
            goto label_33;
            label_12:
            val_25 = .pk;
            label_13:
            val_8.Add(item:  val_3.<PK>k__BackingField._prop);
            val_28 = null;
            val_28 = null;
            val_30 = SQLiteConnection.<>c.<>9__90_2;
            if(val_30 == null)
            {
                    val_30 = val_11;
                val_11 = new System.Func<Column, System.String>(object:  SQLiteConnection.<>c.__il2cppRuntimeField_static_fields, method:  System.String SQLiteConnection.<>c::<Update>b__90_2(SQLite4Unity3d.TableMapping.Column c));
                SQLiteConnection.<>c.<>9__90_2 = val_30;
                val_22 = val_22;
            }
            
            val_21 = .pk;
            val_24 = val_22;
            return (int)this.Execute(query:  System.String.Format(format:  "update \"{0}\" set {1} where {2} = ? ", arg0:  val_3.<TableName>k__BackingField, arg1:  System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Column, System.String>(source:  val_5, selector:  val_11))), arg2:  val_3.<PK>k__BackingField.<Name>k__BackingField), args:  val_8.ToArray());
            label_33:
            val_31 = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int UpdateAll(System.Collections.IEnumerable objects)
        {
            SQLiteConnection.<>c__DisplayClass91_0 val_1 = new SQLiteConnection.<>c__DisplayClass91_0();
            if(val_1 != null)
            {
                    .objects = objects;
                .<>4__this = this;
            }
            else
            {
                    mem[16] = objects;
                mem[32] = this;
            }
            
            .c = 0;
            this.RunInTransaction(action:  new System.Action(object:  val_1, method:  System.Void SQLiteConnection.<>c__DisplayClass91_0::<UpdateAll>b__0()));
            if(val_1 != null)
            {
                    return (int)(SQLiteConnection.<>c__DisplayClass91_0)[1152921519628990640].c;
            }
            
            return (int)(SQLiteConnection.<>c__DisplayClass91_0)[1152921519628990640].c;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Delete(object objectToDelete)
        {
            string val_7;
            if((this.GetMapping(type:  objectToDelete.GetType(), createFlags:  0)) == null)
            {
                goto label_2;
            }
            
            val_7 = val_2.<TableName>k__BackingField;
            if((val_2.<PK>k__BackingField) == null)
            {
                goto label_3;
            }
            
            label_9:
            object[] val_4 = new object[1];
            val_4[0] = val_2.<PK>k__BackingField._prop;
            return this.Execute(query:  System.String.Format(format:  "delete from \"{0}\" where \"{1}\" = ?", arg0:  val_7, arg1:  val_2.<PK>k__BackingField.<Name>k__BackingField), args:  val_4);
            label_2:
            val_7 = 15026800;
            if(69077560 != 0)
            {
                goto label_9;
            }
            
            label_3:
            System.NotSupportedException val_6 = new System.NotSupportedException(message:  "Cannot delete " + val_7 + ": it has no PK"(": it has no PK"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Delete<T>(object primaryKey)
        {
            var val_11;
            SQLite4Unity3d.TableMapping val_2 = this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0);
            if(val_2 != null)
            {
                    val_11 = val_2.PK;
            }
            else
            {
                    val_11 = 0.PK;
            }
            
            string val_5 = 0.TableName;
            if(val_11 != null)
            {
                    object[] val_8 = new object[1];
                val_8[0] = primaryKey;
                if(this != null)
            {
                    return this.Execute(query:  System.String.Format(format:  "delete from \"{0}\" where \"{1}\" = ?", arg0:  val_5, arg1:  val_11.Name), args:  val_8);
            }
            
                return this.Execute(query:  System.String.Format(format:  "delete from \"{0}\" where \"{1}\" = ?", arg0:  val_5, arg1:  val_11.Name), args:  val_8);
            }
            
            System.NotSupportedException val_10 = new System.NotSupportedException(message:  "Cannot delete " + val_5 + ": it has no PK"(": it has no PK"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DeleteAll<T>()
        {
            if(this != null)
            {
                    return this.Execute(query:  System.String.Format(format:  "delete from \"{0}\"", arg0:  this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0).TableName), args:  System.Array.Empty<System.Object>());
            }
            
            return this.Execute(query:  System.String.Format(format:  "delete from \"{0}\"", arg0:  this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0).TableName), args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Finalize()
        {
            this.Finalize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            System.GC.SuppressFinalize(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Dispose(bool disposing)
        {
            this.Close();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Close()
        {
            var val_5;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(this._open == false)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            if((System.IntPtr.op_Inequality(value1:  this.<Handle>k__BackingField, value2:  SQLite4Unity3d.SQLiteConnection.NullHandle)) == false)
            {
                    return;
            }
            
            if(this._mappings == null)
            {
                goto label_5;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this._mappings.Values.GetEnumerator();
            goto label_9;
            label_10:
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            if(0 != 0)
            {
                    0.Dispose();
                mem2[0] = 0;
            }
            
            label_9:
            if((2138308752 & 1) != 0)
            {
                goto label_10;
            }
            
            val_13 = 0;
            val_14 = 93;
            goto label_11;
            label_5:
            val_13 = 0;
            goto label_21;
            label_11:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519630057616});
            if( == 93)
            {
                
            }
            else
            {
                    if(null != null)
            {
                    val_13 = 0;
            }
            
            }
            
            label_21:
            Result val_8 = SQLite4Unity3d.SQLite3.Close(db:  this.<Handle>k__BackingField);
            if(val_8 == 0)
            {
                    val_15 = 149;
                val_16 = null;
                val_16 = null;
                this._open = false;
                this.<Handle>k__BackingField = SQLite4Unity3d.SQLiteConnection.NullHandle;
                if(val_13 == 0)
            {
                    return;
            }
            
                if(149 == 0)
            {
                    return;
            }
            
                if(149 == 149)
            {
                    return;
            }
            
                return;
            }
            
            SQLite4Unity3d.SQLiteException val_10 = SQLite4Unity3d.SQLiteException.New(r:  val_8, message:  SQLite4Unity3d.SQLite3.GetErrmsg(db:  this.<Handle>k__BackingField));
            goto label_33;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <CreateTable>b__46_0(SQLite4Unity3d.TableMapping.Column p)
        {
            return SQLite4Unity3d.Orm.SqlDecl(p:  p, storeDateTimeAsTicks:  this.<StoreDateTimeAsTicks>k__BackingField);
        }
    
    }

}
