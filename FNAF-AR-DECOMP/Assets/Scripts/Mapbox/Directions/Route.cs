using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Route
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Directions.Leg> <Legs>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Utils.Vector2d> <Geometry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Duration>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Distance>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <Weight>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <WeightName>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Leg> Legs { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Utils.Vector2d> Geometry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Duration { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Distance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Weight { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string WeightName { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Leg> get_Legs()
        {
            return (System.Collections.Generic.List<Mapbox.Directions.Leg>)this.<Legs>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Legs(System.Collections.Generic.List<Mapbox.Directions.Leg> value)
        {
            this.<Legs>k__BackingField = value;
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
        public float get_Weight()
        {
            return (float)this.<Weight>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Weight(float value)
        {
            this.<Weight>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_WeightName()
        {
            return (string)this.<WeightName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_WeightName(string value)
        {
            this.<WeightName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Route()
        {
        
        }
    
    }

}
