using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Geometry
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Type>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Coordinates>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Coordinates { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Type()
        {
            return (string)this.<Type>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Type(string value)
        {
            this.<Type>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Coordinates()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Coordinates>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Coordinates(Mapbox.Utils.Vector2d value)
        {
            this.<Coordinates>k__BackingField = value;
            mem[1152921520002994336] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Geometry()
        {
        
        }
    
    }

}
