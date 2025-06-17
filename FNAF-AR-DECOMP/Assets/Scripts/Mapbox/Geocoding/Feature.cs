using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Feature
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Type>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Text>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <PlaceName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Relevance>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, object> <Properties>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<Mapbox.Utils.Vector2dBounds> <Bbox>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Center>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.Geometry <Geometry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Address>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> <Context>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Text { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlaceName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Relevance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, object> Properties { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.Utils.Vector2dBounds> Bbox { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Center { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.Geometry Geometry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Address { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> Context { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
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
        public string get_Text()
        {
            return (string)this.<Text>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Text(string value)
        {
            this.<Text>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_PlaceName()
        {
            return (string)this.<PlaceName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PlaceName(string value)
        {
            this.<PlaceName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Relevance()
        {
            return (double)this.<Relevance>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Relevance(double value)
        {
            this.<Relevance>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, object> get_Properties()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.<Properties>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Properties(System.Collections.Generic.Dictionary<string, object> value)
        {
            this.<Properties>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.Utils.Vector2dBounds> get_Bbox()
        {
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = this.<Bbox>k__BackingField;
            return (System.Nullable<Mapbox.Utils.Vector2dBounds>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Bbox(System.Nullable<Mapbox.Utils.Vector2dBounds> value)
        {
            mem[1152921519999934944] = value.HasValue + 32;
            this.<Bbox>k__BackingField = value;
            mem[1152921519999934928] = value.HasValue + 16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Center()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Center>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Center(Mapbox.Utils.Vector2d value)
        {
            this.<Center>k__BackingField = value;
            mem[1152921520000158960] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.Geometry get_Geometry()
        {
            return (Mapbox.Geocoding.Geometry)this.<Geometry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Geometry(Mapbox.Geocoding.Geometry value)
        {
            this.<Geometry>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Address()
        {
            return (string)this.<Address>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Address(string value)
        {
            this.<Address>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> get_Context()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.String>>)this.<Context>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Context(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> value)
        {
            this.<Context>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Feature()
        {
        
        }
    
    }

}
