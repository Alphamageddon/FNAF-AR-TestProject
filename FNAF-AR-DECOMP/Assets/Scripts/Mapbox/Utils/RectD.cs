using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct RectD
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Min>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Max>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Size>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Center>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Min { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Max { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Size { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Center { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Min()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Max>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Min(Mapbox.Utils.Vector2d value)
        {
            this.<Max>k__BackingField = value;
            mem[1152921519939226504] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Max()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Size>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Max(Mapbox.Utils.Vector2d value)
        {
            this.<Size>k__BackingField = value;
            mem[1152921519939450520] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Size()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Center>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Size(Mapbox.Utils.Vector2d value)
        {
            this.<Center>k__BackingField = value;
            mem[1152921519939674536] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Center()
        {
            return new Mapbox.Utils.Vector2d();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Center(Mapbox.Utils.Vector2d value)
        {
            mem[1152921519939898544] = value.x;
            mem[1152921519939898552] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RectD(Mapbox.Utils.Vector2d min, Mapbox.Utils.Vector2d size)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Contains(Mapbox.Utils.Vector2d point)
        {
        
        }
    
    }

}
