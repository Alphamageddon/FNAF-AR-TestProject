using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IndexedAttribute : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Order>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Unique>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Order { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool Unique { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Order()
        {
            return (int)this.<Order>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Order(int value)
        {
            this.<Order>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool get_Unique()
        {
            return (bool)this.<Unique>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void set_Unique(bool value)
        {
            this.<Unique>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IndexedAttribute()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IndexedAttribute(string name, int order)
        {
            this.<Name>k__BackingField = name;
            this.<Order>k__BackingField = order;
        }
    
    }

}
