using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Annotation
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] <Distance>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] <Duration>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] <Speed>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] <Congestion>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] Distance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] Duration { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] Speed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] Congestion { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] get_Distance()
        {
            return (System.Double[])this.<Distance>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Distance(double[] value)
        {
            this.<Distance>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] get_Duration()
        {
            return (System.Double[])this.<Duration>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Duration(double[] value)
        {
            this.<Duration>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] get_Speed()
        {
            return (System.String[])this.<Speed>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Speed(string[] value)
        {
            this.<Speed>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] get_Congestion()
        {
            return (System.String[])this.<Congestion>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Congestion(string[] value)
        {
            this.<Congestion>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Annotation()
        {
        
        }
    
    }

}
