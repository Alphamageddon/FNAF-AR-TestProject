using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Intersection
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Out>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<bool> <Entry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> <Bearings>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Location>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<int> <In>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Out { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<bool> Entry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> Bearings { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Location { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> In { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Out()
        {
            return (int)this.<Out>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Out(int value)
        {
            this.<Out>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<bool> get_Entry()
        {
            return (System.Collections.Generic.List<System.Boolean>)this.<Entry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Entry(System.Collections.Generic.List<bool> value)
        {
            this.<Entry>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> get_Bearings()
        {
            return (System.Collections.Generic.List<System.Int32>)this.<Bearings>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Bearings(System.Collections.Generic.List<int> value)
        {
            this.<Bearings>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Location()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Location>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Location(Mapbox.Utils.Vector2d value)
        {
            this.<Location>k__BackingField = value;
            mem[1152921520011692784] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> get_In()
        {
            return (System.Nullable<System.Int32>)this.<In>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_In(System.Nullable<int> value)
        {
            this.<In>k__BackingField = value.HasValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Intersection()
        {
        
        }
    
    }

}
