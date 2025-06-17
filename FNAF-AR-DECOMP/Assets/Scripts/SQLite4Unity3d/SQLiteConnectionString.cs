using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class SQLiteConnectionString
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ConnectionString>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <DatabasePath>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <StoreDateTimeAsTicks>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ConnectionString { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DatabasePath { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool StoreDateTimeAsTicks { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ConnectionString()
        {
            return (string)this.<ConnectionString>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ConnectionString(string value)
        {
            this.<ConnectionString>k__BackingField = value;
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
        public SQLiteConnectionString(string databasePath, bool storeDateTimeAsTicks)
        {
            this.<StoreDateTimeAsTicks>k__BackingField = storeDateTimeAsTicks;
            this.<ConnectionString>k__BackingField = databasePath;
            this.<DatabasePath>k__BackingField = databasePath;
        }
    
    }

}
