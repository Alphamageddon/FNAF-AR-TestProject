using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ReverseGeocodeResponse : GeocodeResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<double> <Query>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<double> Query { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<double> get_Query()
        {
            return (System.Collections.Generic.List<System.Double>)this.<Query>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Query(System.Collections.Generic.List<double> value)
        {
            this.<Query>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReverseGeocodeResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
