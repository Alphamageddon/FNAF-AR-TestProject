using UnityEngine;

namespace Mapbox.MapMatching
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MatchObject : Route
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <Confidence>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Confidence { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Confidence()
        {
            return (float)this.<Confidence>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Confidence(float value)
        {
            this.<Confidence>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MatchObject()
        {
        
        }
    
    }

}
