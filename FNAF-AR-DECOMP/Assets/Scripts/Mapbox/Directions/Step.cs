using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Step
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Directions.Intersection> <Intersections>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Utils.Vector2d> <Geometry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.Maneuver <Maneuver>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Duration>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Distance>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Mode>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Intersection> Intersections { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Utils.Vector2d> Geometry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.Maneuver Maneuver { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Duration { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Distance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Mode { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Intersection> get_Intersections()
        {
            return (System.Collections.Generic.List<Mapbox.Directions.Intersection>)this.<Intersections>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Intersections(System.Collections.Generic.List<Mapbox.Directions.Intersection> value)
        {
            this.<Intersections>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Utils.Vector2d> get_Geometry()
        {
            return (System.Collections.Generic.List<Mapbox.Utils.Vector2d>)this.<Geometry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Geometry(System.Collections.Generic.List<Mapbox.Utils.Vector2d> value)
        {
            this.<Geometry>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.Maneuver get_Maneuver()
        {
            return (Mapbox.Directions.Maneuver)this.<Maneuver>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Maneuver(Mapbox.Directions.Maneuver value)
        {
            this.<Maneuver>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Duration()
        {
            return (double)this.<Duration>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Duration(double value)
        {
            this.<Duration>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Distance()
        {
            return (double)this.<Distance>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Distance(double value)
        {
            this.<Distance>k__BackingField = value;
        }
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
        public string get_Mode()
        {
            return (string)this.<Mode>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Mode(string value)
        {
            this.<Mode>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Step()
        {
        
        }
    
    }

}
