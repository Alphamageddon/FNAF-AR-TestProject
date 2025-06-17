using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UniqueAttribute : IndexedAttribute
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Unique { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_Unique()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Unique(bool value)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UniqueAttribute()
        {
            val_1 = new System.Attribute();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UniqueAttribute(string name, int order)
        {
            val_1 = new System.Attribute();
            mem[1152921519636155072] = name;
            mem[1152921519636155080] = order;
        }
    
    }

}
