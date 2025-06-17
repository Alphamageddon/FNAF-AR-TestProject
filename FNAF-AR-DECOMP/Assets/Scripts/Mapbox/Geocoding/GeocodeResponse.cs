using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public abstract class GeocodeResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Type>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Geocoding.Feature> <Features>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Attribution>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Geocoding.Feature> Features { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Attribution { get; set; }
        
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
        public System.Collections.Generic.List<Mapbox.Geocoding.Feature> get_Features()
        {
            return (System.Collections.Generic.List<Mapbox.Geocoding.Feature>)this.<Features>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Features(System.Collections.Generic.List<Mapbox.Geocoding.Feature> value)
        {
            this.<Features>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Attribution()
        {
            return (string)this.<Attribution>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Attribution(string value)
        {
            this.<Attribution>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected GeocodeResponse()
        {
        
        }
    
    }

}
