using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Os
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <locale>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <expId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <bootId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ver>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string locale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string expId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int bootId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ver { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_locale()
        {
            return (string)this.<locale>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_locale(string value)
        {
            this.<locale>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_expId()
        {
            return (string)this.<expId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_expId(string value)
        {
            this.<expId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_bootId()
        {
            return (int)this.<bootId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_bootId(int value)
        {
            this.<bootId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_name()
        {
            return (string)this.<name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_name(string value)
        {
            this.<name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ver()
        {
            return (string)this.<ver>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ver(string value)
        {
            this.<ver>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Os()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Os(string fullName, string name)
        {
            val_1 = new System.Object();
        }
    
    }

}
