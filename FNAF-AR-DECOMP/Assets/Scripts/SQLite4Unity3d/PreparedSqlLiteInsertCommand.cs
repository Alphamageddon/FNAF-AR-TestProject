using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreparedSqlLiteInsertCommand : IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Initialized>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.SQLiteConnection <Connection>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <CommandText>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private IntPtr <Statement>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly IntPtr NullStatement;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Initialized { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SQLite4Unity3d.SQLiteConnection Connection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CommandText { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected IntPtr Statement { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Initialized()
        {
            return (bool)this.<Initialized>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Initialized(bool value)
        {
            this.<Initialized>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SQLite4Unity3d.SQLiteConnection get_Connection()
        {
            return (SQLite4Unity3d.SQLiteConnection)this.<Connection>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_Connection(SQLite4Unity3d.SQLiteConnection value)
        {
            this.<Connection>k__BackingField = value;
        }
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
        protected IntPtr get_Statement()
        {
            return (IntPtr)this.<Statement>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_Statement(IntPtr value)
        {
            this.<Statement>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal PreparedSqlLiteInsertCommand(SQLite4Unity3d.SQLiteConnection conn)
        {
            this.<Connection>k__BackingField = conn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ExecuteNonQuery(object[] source)
        {
            IntPtr val_14;
            Result val_16;
            string val_17;
            if((this.<Initialized>k__BackingField) != true)
            {
                    this.<Statement>k__BackingField = this;
                this.<Initialized>k__BackingField = true;
            }
            
            if((source != null) && (source.Length >= 1))
            {
                    do
            {
                val_14 = this.<Statement>k__BackingField;
                long val_15 = 0;
                val_15 = val_15 + 1;
                SQLite4Unity3d.SQLiteCommand.BindParameter(stmt:  val_14, index:  val_15, value:  source[val_15], storeDateTimeAsTicks:  ((this.<Connection>k__BackingField.<StoreDateTimeAsTicks>k__BackingField) == true) ? 1 : 0);
            }
            while(val_15 < source.Length);
            
            }
            
            Result val_2 = SQLite4Unity3d.SQLite3.Step(stmt:  this.<Statement>k__BackingField);
            if(val_2 == 101)
            {
                    Result val_4 = SQLite4Unity3d.SQLite3.Reset(stmt:  this.<Statement>k__BackingField);
                return (int)SQLite4Unity3d.SQLite3.Changes(db:  this.<Connection>k__BackingField.<Handle>k__BackingField);
            }
            
            if(val_2 == 1)
            {
                goto label_12;
            }
            
            if((val_2 != 19) || ((SQLite4Unity3d.SQLite3.ExtendedErrCode(db:  this.<Connection>k__BackingField.<Handle>k__BackingField)) != 1299))
            {
                goto label_15;
            }
            
            Result val_6 = SQLite4Unity3d.SQLite3.Reset(stmt:  this.<Statement>k__BackingField);
            SQLite4Unity3d.NotNullConstraintViolationException val_8 = SQLite4Unity3d.NotNullConstraintViolationException.New(r:  19, message:  SQLite4Unity3d.SQLite3.GetErrmsg(db:  this.<Connection>k__BackingField.<Handle>k__BackingField));
            goto label_16;
            label_15:
            Result val_9 = SQLite4Unity3d.SQLite3.Reset(stmt:  this.<Statement>k__BackingField);
            val_16 = val_2;
            val_17 = val_2.ToString();
            goto label_17;
            label_12:
            Result val_12 = SQLite4Unity3d.SQLite3.Reset(stmt:  this.<Statement>k__BackingField);
            val_16 = 1;
            val_17 = SQLite4Unity3d.SQLite3.GetErrmsg(db:  this.<Connection>k__BackingField.<Handle>k__BackingField);
            label_17:
            SQLite4Unity3d.SQLiteException val_13 = SQLite4Unity3d.SQLiteException.New(r:  val_16, message:  val_17);
            label_16:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual IntPtr Prepare()
        {
            if((this.<Connection>k__BackingField) != null)
            {
                    return SQLite4Unity3d.SQLite3.Prepare2(db:  this.<Connection>k__BackingField.<Handle>k__BackingField, query:  this.<CommandText>k__BackingField);
            }
            
            return SQLite4Unity3d.SQLite3.Prepare2(db:  this.<Connection>k__BackingField.<Handle>k__BackingField, query:  this.<CommandText>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            this.Dispose(disposing:  false);
            System.GC.SuppressFinalize(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Dispose(bool disposing)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = this;
            val_10 = 1152921505104236544;
            val_11 = null;
            val_11 = null;
            if((System.IntPtr.op_Inequality(value1:  this.<Statement>k__BackingField, value2:  SQLite4Unity3d.PreparedSqlLiteInsertCommand.NullStatement)) == false)
            {
                    return;
            }
            
            Result val_2 = SQLite4Unity3d.SQLite3.Finalize(stmt:  this.<Statement>k__BackingField);
            val_12 = null;
            val_12 = null;
            this.<Connection>k__BackingField = 0;
            this.<Statement>k__BackingField = SQLite4Unity3d.PreparedSqlLiteInsertCommand.NullStatement;
            if(51 == 51)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Finalize()
        {
            this.Dispose(disposing:  false);
            this.Finalize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PreparedSqlLiteInsertCommand()
        {
        
        }
    
    }

}
