using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Waypoint
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Location>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Location { get; set; }
        
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
        public Mapbox.Utils.Vector2d get_Location()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Location>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Location(Mapbox.Utils.Vector2d value)
        {
            this.<Location>k__BackingField = value;
            mem[1152921520018546528] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Waypoint()
        {
        
        }
    
    }

}
