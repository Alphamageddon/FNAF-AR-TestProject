using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SQLiteException : Exception
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.SQLite3.Result <Result>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.SQLite3.Result Result { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.SQLite3.Result get_Result()
        {
            return (Result)this.<Result>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Result(SQLite4Unity3d.SQLite3.Result value)
        {
            this.<Result>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SQLiteException(SQLite4Unity3d.SQLite3.Result r, string message)
        {
            this.<Result>k__BackingField = r;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SQLite4Unity3d.SQLiteException New(SQLite4Unity3d.SQLite3.Result r, string message)
        {
            return (SQLite4Unity3d.SQLiteException)new SQLite4Unity3d.SQLiteException(r:  r, message:  message);
        }
    
    }

}
