using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SQLiteCommand
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.SQLiteConnection _conn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SQLite4Unity3d.SQLiteCommand.Binding> _bindings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <CommandText>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static IntPtr NegativePointer;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CommandText { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_CommandText()
        {
            return (string)this.<CommandText>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CommandText(string value)
        {
            this.<CommandText>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal SQLiteCommand(SQLite4Unity3d.SQLiteConnection conn)
        {
            this._conn = conn;
            this._bindings = new System.Collections.Generic.List<Binding>();
            this.<CommandText>k__BackingField = "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ExecuteNonQuery()
        {
            Result val_12;
            string val_13;
            IntPtr val_1 = this.Prepare();
            Result val_2 = SQLite4Unity3d.SQLite3.Step(stmt:  val_1);
            Result val_3 = SQLite4Unity3d.SQLite3.Finalize(stmt:  val_1);
            if(val_2 == 101)
            {
                    return (int)SQLite4Unity3d.SQLite3.Changes(db:  this._conn.<Handle>k__BackingField);
            }
            
            if(val_2 == 1)
            {
                goto label_4;
            }
            
            if((val_2 != 19) || ((SQLite4Unity3d.SQLite3.ExtendedErrCode(db:  this._conn.<Handle>k__BackingField)) != 1299))
            {
                goto label_7;
            }
            
            SQLite4Unity3d.NotNullConstraintViolationException val_7 = SQLite4Unity3d.NotNullConstraintViolationException.New(r:  19, message:  SQLite4Unity3d.SQLite3.GetErrmsg(db:  this._conn.<Handle>k__BackingField));
            goto label_8;
            label_7:
            val_12 = val_2;
            val_13 = val_2.ToString();
            goto label_9;
            label_4:
            val_13 = SQLite4Unity3d.SQLite3.GetErrmsg(db:  this._conn.<Handle>k__BackingField);
            val_12 = 1;
            label_9:
            SQLite4Unity3d.SQLiteException val_10 = SQLite4Unity3d.SQLiteException.New(r:  val_12, message:  val_13);
            label_8:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<T> ExecuteDeferredQuery<T>()
        {
            SQLite4Unity3d.TableMapping val_2 = this._conn.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0);
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<T> ExecuteQuery<T>()
        {
            SQLite4Unity3d.TableMapping val_2 = this._conn.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0);
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<T> ExecuteQuery<T>(SQLite4Unity3d.TableMapping map)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnInstanceCreated(object obj)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<T> ExecuteDeferredQuery<T>(SQLite4Unity3d.TableMapping map)
        {
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                    mem2[0] = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            mem2[0] = map;
            return (System.Collections.Generic.IEnumerable<T>)__RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T ExecuteScalar<T>()
        {
            var val_11;
            bool val_1 = this._conn.Trace;
            IntPtr val_2 = this.Prepare();
            Result val_3 = SQLite4Unity3d.SQLite3.Step(stmt:  val_2);
            if(val_3 == 100)
            {
                goto label_2;
            }
            
            if(val_3 != 101)
            {
                goto label_3;
            }
            
            val_11 = 0;
            goto label_4;
            label_2:
            object val_6 = this.ReadCol(stmt:  val_2, index:  0, type:  SQLite4Unity3d.SQLite3.ColumnType(stmt:  val_2, index:  0), clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
            label_4:
            label_20:
            this.Finalize(stmt:  val_2);
            if((1 & 1) != 0)
            {
                    return 1152921504627666944;
            }
            
            if((1 & 1) != 0)
            {
                    return 1152921504627666944;
            }
            
            return 1152921504627666944;
            label_3:
            SQLite4Unity3d.SQLiteException val_9 = SQLite4Unity3d.SQLiteException.New(r:  val_3, message:  SQLite4Unity3d.SQLite3.GetErrmsg(db:  this._conn.Handle));
            if(0 != 1)
            {
                goto label_19;
            }
            
            var val_10 = (null == 0) ? 1 : 0;
            goto label_20;
            label_19:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Bind(string name, object val)
        {
            SQLiteCommand.Binding val_1 = new SQLiteCommand.Binding();
            if(val_1 != null)
            {
                    .<Name>k__BackingField = name;
            }
            else
            {
                    mem[16] = name;
            }
            
            .<Value>k__BackingField = val;
            this._bindings.Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Bind(object val)
        {
            this.Bind(name:  0, val:  val);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            string val_11;
            int val_2 = this._bindings.Count + 1;
            string[] val_3 = new string[0];
            val_11 = this.<CommandText>k__BackingField;
            val_3[0] = val_11;
            List.Enumerator<T> val_4 = this._bindings.GetEnumerator();
            goto label_7;
            label_12:
            GameUI.EmailUIDataHandler val_5 = 0.emailUIDataHandler;
            val_11 = 1;
            val_3[1] = System.String.Format(format:  "  {0}: {1}", arg0:  0, arg1:  val_5._serverGameUIDataModel);
            label_7:
            if(((-2138766376) & 1) != 0)
            {
                goto label_12;
            }
            
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519647949784});
            return (string)System.String.Join(separator:  System.Environment.NewLine, value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private IntPtr Prepare()
        {
            IntPtr val_1 = SQLite4Unity3d.SQLite3.Prepare2(db:  this._conn.<Handle>k__BackingField, query:  this.<CommandText>k__BackingField);
            this.BindAll(stmt:  val_1);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Finalize(IntPtr stmt)
        {
            Result val_1 = SQLite4Unity3d.SQLite3.Finalize(stmt:  stmt);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BindAll(IntPtr stmt)
        {
            IntPtr val_7;
            System.Collections.Generic.List<GameUI.EmailData> val_8;
            val_7 = stmt;
            List.Enumerator<T> val_1 = this._bindings.GetEnumerator();
            label_9:
            if(((-2138336184) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2._masterDomain != null)
            {
                    val_8 = SQLite4Unity3d.SQLite3.BindParameterIndex(stmt:  val_7, name:  val_2._masterDomain);
            }
            else
            {
                    var val_4 = 1 + 1;
                val_8 = 1;
            }
            
            val_2._emailDatas = val_8;
            SQLite4Unity3d.SQLiteCommand.BindParameter(stmt:  val_7, index:  1, value:  val_2._serverGameUIDataModel, storeDateTimeAsTicks:  ((this._conn.<StoreDateTimeAsTicks>k__BackingField) == true) ? 1 : 0);
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static void BindParameter(IntPtr stmt, int index, object value, bool storeDateTimeAsTicks)
        {
            var val_19;
            var val_20;
            var val_21;
            System.Byte[] val_22;
            string val_23;
            var val_24;
            var val_26;
            var val_27;
            var val_28;
            if(value == null)
            {
                goto label_1;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            val_19 = 1152921504623300608;
            if(null == null)
            {
                goto label_3;
            }
            
            if((((null == null) || (null == null)) || (null == null)) || (null == null))
            {
                goto label_7;
            }
            
            if(null == null)
            {
                goto label_27;
            }
            
            if((null == null) || (null == null))
            {
                goto label_10;
            }
            
            if(((null == null) || (null == null)) || (null == null))
            {
                goto label_13;
            }
            
            if(null == null)
            {
                goto label_14;
            }
            
            if(null == null)
            {
                goto label_15;
            }
            
            if(null == null)
            {
                goto label_16;
            }
            
            if((value.GetType() & 1) == 0)
            {
                goto label_18;
            }
            
            label_7:
            val_20 = System.Convert.ToInt32(value:  value);
            goto label_27;
            label_1:
            int val_3 = SQLite4Unity3d.SQLite3.BindNull(stmt:  stmt, index:  index);
            return;
            label_2:
            label_27:
            int val_4 = SQLite4Unity3d.SQLite3.BindInt(stmt:  stmt, index:  index, val:  20819968);
            return;
            label_3:
            int val_5 = SQLite4Unity3d.SQLite3.BindText(stmt:  stmt, index:  index, val:  value, n:  0, free:  SQLite4Unity3d.SQLiteCommand.NegativePointer);
            return;
            label_10:
            label_38:
            int val_7 = SQLite4Unity3d.SQLite3.BindInt64(stmt:  stmt, index:  index, val:  System.Convert.ToInt64(value:  value));
            return;
            label_13:
            int val_10 = SQLite4Unity3d.SQLite3.BindDouble(stmt:  stmt, index:  index, val:  System.Convert.ToDouble(value:  value));
            return;
            label_14:
            GameUI.EmailUIDataHandler val_11 = null.emailUIDataHandler;
            goto label_38;
            label_15:
            if(storeDateTimeAsTicks == false)
            {
                goto label_36;
            }
            
            long val_12 = null.Ticks;
            goto label_38;
            label_16:
            long val_13 = null.UtcTicks;
            goto label_38;
            label_18:
            if(value == null)
            {
                goto label_39;
            }
            
            val_21 = null;
            val_21 = null;
            val_22 = value;
            if(val_22 == null)
            {
                    val_22 = 0;
            }
            
            if(value == null)
            {
                goto label_44;
            }
            
            int val_14 = SQLite4Unity3d.SQLite3.BindBlob(stmt:  stmt, index:  index, val:  val_22, n:  storeDateTimeAsTicks, free:  SQLite4Unity3d.SQLiteCommand.NegativePointer);
            return;
            label_36:
            val_23;
            val_24 = null;
            val_24 = null;
            val_26 = 0;
            goto label_48;
            label_39:
            if(null != null)
            {
                goto label_49;
            }
            
            val_23 = ;
            val_27 = null;
            val_27 = null;
            val_26 = 72;
            label_48:
            int val_15 = SQLite4Unity3d.SQLite3.BindText(stmt:  stmt, index:  index, val:  null, n:  72, free:  SQLite4Unity3d.SQLiteCommand.__il2cppRuntimeField_static_fields);
            return;
            label_44:
            label_49:
            val_28 = new System.NotSupportedException(message:  "Cannot store type: "("Cannot store type: ") + value.GetType());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object ReadCol(IntPtr stmt, int index, SQLite4Unity3d.SQLite3.ColType type, System.Type clrType)
        {
            IntPtr val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            IntPtr val_66;
            var val_67;
            val_58 = type;
            if(val_58 == 5)
            {
                    val_59 = 0;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            val_58 = null;
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_58}))) != false)
            {
                    string val_3 = SQLite4Unity3d.SQLite3.ColumnString(stmt:  stmt, index:  index);
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            val_58 = null;
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_58}))) == false)
            {
                goto label_9;
            }
            
            label_39:
            int val_6 = SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index);
            val_60 = 1152921504621064192;
            return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            label_9:
            val_58 = null;
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_58}))) != false)
            {
                    val_60 = 1152921504616644608;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    double val_13 = SQLite4Unity3d.SQLite3.ColumnDouble(stmt:  stmt, index:  index);
                val_61 = 1152921504618188800;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    double val_16 = SQLite4Unity3d.SQLite3.ColumnDouble(stmt:  stmt, index:  index);
                val_61 = 1152921504623194112;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    0.emailUIDataHandler = SQLite4Unity3d.SQLite3.ColumnInt64(stmt:  stmt, index:  index);
                val_62 = 0;
                val_63 = 1152921504623886336;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_28;
            }
            
            if((this._conn.<StoreDateTimeAsTicks>k__BackingField) == false)
            {
                goto label_30;
            }
            
            long val_22 = SQLite4Unity3d.SQLite3.ColumnInt64(stmt:  stmt, index:  index);
            val_62 = 0;
            val_63 = 1152921504617603072;
            return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            label_28:
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    long val_25 = SQLite4Unity3d.SQLite3.ColumnInt64(stmt:  stmt, index:  index);
                val_64 = null;
                val_64 = null;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((clrType & 1) != 0)
            {
                goto label_39;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_42;
            }
            
            long val_28 = SQLite4Unity3d.SQLite3.ColumnInt64(stmt:  stmt, index:  index);
            return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            label_30:
            System.DateTime val_30 = System.DateTime.Parse(s:  SQLite4Unity3d.SQLite3.ColumnString(stmt:  stmt, index:  index));
            return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            label_42:
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    long val_33 = SQLite4Unity3d.SQLite3.ColumnInt64(stmt:  stmt, index:  index);
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    decimal val_37 = System.Decimal.op_Explicit(value:  SQLite4Unity3d.SQLite3.ColumnDouble(stmt:  stmt, index:  index));
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    int val_40 = SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index);
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_66 = stmt;
                int val_43 = SQLite4Unity3d.SQLite3.ColumnInt(stmt:  val_66, index:  index);
                val_67 = 1152921504624631808;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_66 = stmt;
                int val_46 = SQLite4Unity3d.SQLite3.ColumnInt(stmt:  val_66, index:  index);
                val_67 = 1152921504621010944;
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    int val_49 = SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index);
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    System.Byte[] val_52 = SQLite4Unity3d.SQLite3.ColumnByteArray(stmt:  stmt, index:  index);
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            if((System.Type.op_Equality(left:  clrType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    string val_55 = SQLite4Unity3d.SQLite3.ColumnString(stmt:  stmt, index:  index);
                return (object)((SQLite4Unity3d.SQLite3.ColumnInt(stmt:  stmt, index:  index)) == 1) ? 1 : 0;
            }
            
            System.NotSupportedException val_57 = new System.NotSupportedException(message:  "Don\'t know how to read " + clrType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SQLiteCommand()
        {
            System.Xml.BinXmlSqlMoney val_1 = new System.Xml.BinXmlSqlMoney(v:  0);
            SQLite4Unity3d.SQLiteCommand.NegativePointer = val_1.data;
        }
    
    }

}
