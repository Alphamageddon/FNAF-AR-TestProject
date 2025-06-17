using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SQLite3
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Open(string filename, out IntPtr db)
        {
            if(52952536 != 0)
            {
                    return (Result)filename;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Open(string filename, out IntPtr db, int flags, IntPtr zvfs)
        {
            if(52952536 != 0)
            {
                    return (Result)filename;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Open(byte[] filename, out IntPtr db, int flags, IntPtr zvfs)
        {
            if(52952536 != 0)
            {
                    return (Result)(filename == null) ? 0 : (filename[32]);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Open16(string filename, out IntPtr db)
        {
            if(52952536 != 0)
            {
                    return (Result)(filename == null) ? 0 : filename.m_firstChar;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result EnableLoadExtension(IntPtr db, int onoff)
        {
            if(52952536 != 0)
            {
                    return (Result)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Close(IntPtr db)
        {
            if(52952536 != 0)
            {
                    return (Result)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Initialize()
        {
            if(52952536 != 0)
            {
                    return (Result);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Shutdown()
        {
            if(52952536 != 0)
            {
                    return (Result);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Config(SQLite4Unity3d.SQLite3.ConfigOption option)
        {
            if(52952536 != 0)
            {
                    return (Result)option;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int SetDirectory(uint directoryType, string directoryPath)
        {
            if(52952536 != 0)
            {
                    var val_1 = (directoryPath == null) ? 0 : directoryPath.m_firstChar;
                return (int)directoryType;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result BusyTimeout(IntPtr db, int milliseconds)
        {
            if(52952536 != 0)
            {
                    return (Result)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int Changes(IntPtr db)
        {
            if(52952536 != 0)
            {
                    return (int)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Prepare2(IntPtr db, string sql, int numBytes, out IntPtr stmt, IntPtr pzTail)
        {
            if(52952536 != 0)
            {
                    return (Result)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static IntPtr Prepare2(IntPtr db, string query)
        {
            IntPtr val_2 = 0;
            Result val_3 = SQLite4Unity3d.SQLite3.Prepare2(db:  db, sql:  query, numBytes:  System.Text.Encoding.UTF8, stmt: out  val_2, pzTail:  0);
            if(val_3 == 0)
            {
                    return val_2;
            }
            
            SQLite4Unity3d.SQLiteException val_5 = SQLite4Unity3d.SQLiteException.New(r:  val_3, message:  SQLite4Unity3d.SQLite3.GetErrmsg(db:  db));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Step(IntPtr stmt)
        {
            if(52952536 != 0)
            {
                    return (Result)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Reset(IntPtr stmt)
        {
            if(52952536 != 0)
            {
                    return (Result)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.Result Finalize(IntPtr stmt)
        {
            if(52952536 != 0)
            {
                    return (Result)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern long LastInsertRowid(IntPtr db)
        {
            if(52952536 != 0)
            {
                    return (long)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern IntPtr Errmsg(IntPtr db)
        {
            if(52952536 != 0)
            {
                    return (IntPtr)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetErrmsg(IntPtr db)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringUni(ptr:  SQLite4Unity3d.SQLite3.Errmsg(db:  db));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int BindParameterIndex(IntPtr stmt, string name)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int BindNull(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int BindInt(IntPtr stmt, int index, int val)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int BindInt64(IntPtr stmt, int index, long val)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int BindDouble(IntPtr stmt, int index, double val)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int BindText(IntPtr stmt, int index, string val, int n, IntPtr free)
        {
            if(52952536 != 0)
            {
                    var val_1 = (val == null) ? 0 : val.m_firstChar;
                return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int BindBlob(IntPtr stmt, int index, byte[] val, int n, IntPtr free)
        {
            if(52952536 != 0)
            {
                    val = (val == null) ? 0 : (val[32]);
                return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int ColumnCount(IntPtr stmt)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern IntPtr ColumnName(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (IntPtr)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static extern IntPtr ColumnName16Internal(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (IntPtr)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ColumnName16(IntPtr stmt, int index)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringUni(ptr:  SQLite4Unity3d.SQLite3.ColumnName16Internal(stmt:  stmt, index:  index));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.ColType ColumnType(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (ColType)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int ColumnInt(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern long ColumnInt64(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (long)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern double ColumnDouble(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (double)D0;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern IntPtr ColumnText(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (IntPtr)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern IntPtr ColumnText16(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (IntPtr)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern IntPtr ColumnBlob(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (IntPtr)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int ColumnBytes(IntPtr stmt, int index)
        {
            if(52952536 != 0)
            {
                    return (int)stmt;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ColumnString(IntPtr stmt, int index)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringUni(ptr:  SQLite4Unity3d.SQLite3.ColumnText16(stmt:  stmt, index:  index));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] ColumnByteArray(IntPtr stmt, int index)
        {
            int val_1 = SQLite4Unity3d.SQLite3.ColumnBytes(stmt:  stmt, index:  index);
            byte[] val_2 = new byte[0];
            if(val_1 < 1)
            {
                    return (System.Byte[])val_2;
            }
            
            System.Runtime.InteropServices.Marshal.Copy(source:  SQLite4Unity3d.SQLite3.ColumnBlob(stmt:  stmt, index:  index), destination:  val_2, startIndex:  0, length:  val_1);
            return (System.Byte[])val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern SQLite4Unity3d.SQLite3.ExtendedResult ExtendedErrCode(IntPtr db)
        {
            if(52952536 != 0)
            {
                    return (ExtendedResult)db;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static extern int LibVersionNumber()
        {
            if(52952536 != 0)
            {
                    return (int);
            }
        
        }
    
    }

}
