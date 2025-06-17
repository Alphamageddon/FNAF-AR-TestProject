using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Leg
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Directions.Step> <Steps>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Summary>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Duration>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Distance>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.Annotation <Annotation>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Step> Steps { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Summary { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Duration { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Distance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.Annotation Annotation { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Directions.Step> get_Steps()
        {
            return (System.Collections.Generic.List<Mapbox.Directions.Step>)this.<Steps>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Steps(System.Collections.Generic.List<Mapbox.Directions.Step> value)
        {
            this.<Steps>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Summary()
        {
            return (string)this.<Summary>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Summary(string value)
        {
            this.<Summary>k__BackingField = value;
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
        public Mapbox.Directions.Annotation get_Annotation()
        {
            return (Mapbox.Directions.Annotation)this.<Annotation>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Annotation(Mapbox.Directions.Annotation value)
        {
            this.<Annotation>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Leg()
        {
        
        }
    
    }

}
