using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CollationAttribute : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Value>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Value { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Value()
        {
            return (string)this.<Value>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Value(string value)
        {
            this.<Value>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CollationAttribute(string collation)
        {
            this.<Value>k__BackingField = collation;
        }
    
    }

}
