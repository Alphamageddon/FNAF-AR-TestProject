using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DirectionsResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Directions.Route> <Routes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Directions.Waypoint> <Waypoints>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Code>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Route> Routes { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Waypoint> Waypoints { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Code { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Route> get_Routes()
        {
            return (System.Collections.Generic.List<Mapbox.Directions.Route>)this.<Routes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Routes(System.Collections.Generic.List<Mapbox.Directions.Route> value)
        {
            this.<Routes>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Waypoint> get_Waypoints()
        {
            return (System.Collections.Generic.List<Mapbox.Directions.Waypoint>)this.<Waypoints>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Waypoints(System.Collections.Generic.List<Mapbox.Directions.Waypoint> value)
        {
            this.<Waypoints>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Code()
        {
            return (string)this.<Code>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Code(string value)
        {
            this.<Code>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DirectionsResponse()
        {
        
        }
    
    }

}
