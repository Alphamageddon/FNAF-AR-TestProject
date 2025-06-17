using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MaxLengthAttribute : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Value>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Value { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Value()
        {
            return (int)this.<Value>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Value(int value)
        {
            this.<Value>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MaxLengthAttribute(int length)
        {
            this.<Value>k__BackingField = length;
        }
    
    }

}
