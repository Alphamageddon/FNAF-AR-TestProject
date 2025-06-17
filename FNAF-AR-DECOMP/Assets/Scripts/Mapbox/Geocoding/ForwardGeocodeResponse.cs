using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ForwardGeocodeResponse : GeocodeResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> <Query>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Query { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> get_Query()
        {
            return (System.Collections.Generic.List<System.String>)this.<Query>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Query(System.Collections.Generic.List<string> value)
        {
            this.<Query>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ForwardGeocodeResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
