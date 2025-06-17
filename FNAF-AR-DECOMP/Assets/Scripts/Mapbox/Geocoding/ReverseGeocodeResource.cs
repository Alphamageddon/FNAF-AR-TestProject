using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ReverseGeocodeResource : GeocodeResource<Mapbox.Utils.Vector2d>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d query;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Utils.Vector2d Query { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReverseGeocodeResource(Mapbox.Utils.Vector2d query)
        {
            goto typeof(Mapbox.Geocoding.ReverseGeocodeResource).__il2cppRuntimeField_198;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Utils.Vector2d get_Query()
        {
            return new Mapbox.Utils.Vector2d() {x = this.query};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Query(Mapbox.Utils.Vector2d value)
        {
            this.query = value;
            mem[1152921520003443376] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string GetUrl()
        {
            var val_9;
            var val_10;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(this.Types != null)
            {
                    val_1.Add(key:  "types", value:  Mapbox.Platform.Resource.GetUrlQueryFromArray<System.String>(items:  this.Types, separator:  ","));
            }
            
            val_9 = 6;
            string[] val_5 = new string[6];
            if(("https://api.mapbox.com/") == null)
            {
                    val_9 = 0;
            }
            
            if(val_5.Length == 0)
            {
                    val_9 = 0;
            }
            
            val_5[0] = "https://api.mapbox.com/";
            val_5[1] = this;
            val_10 = public System.String Mapbox.Geocoding.GeocodeResource<Mapbox.Utils.Vector2d>::get_Mode();
            string val_6 = this.Mode;
            if((val_6 != null) && (val_6 == null))
            {
                    val_10 = 0;
            }
            
            if(val_5.Length <= 2)
            {
                    val_10 = 0;
            }
            
            val_5[2] = val_6;
            val_5[3] = ;
            val_5[4] = ".json";
            val_5[5] = Mapbox.Platform.Resource.EncodeQueryString(values:  val_1);
            return (string)+val_5;
        }
    
    }

}
