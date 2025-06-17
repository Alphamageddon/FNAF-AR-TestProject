using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class GeocodeResource<T> : Resource
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.List<string> FeatureTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string apiEndpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string mode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] types;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract T Query { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ApiEndpoint { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Mode { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] Types { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract T get_Query(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_Query(T value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_ApiEndpoint()
        {
            return (string)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Mode()
        {
            return (string)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] get_Types()
        {
            return (System.String[])this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Types(string[] value)
        {
            var val_3;
            if((value == null) || (value.Length < 1))
            {
                goto label_2;
            }
            
            var val_4 = 0;
            label_12:
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184.Contains(item:  value[0])) == false)
            {
                goto label_11;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < value.Length)
            {
                goto label_12;
            }
            
            label_2:
            mem[1152921519998006896] = value;
            return;
            label_11:
            System.Exception val_2 = new System.Exception(message:  "Invalid type. Must be \"country\", \"region\", \"postcode\",  \"place\",  \"locality\",  \"neighborhood\",  \"address\", or  \"poi\".");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected GeocodeResource<T>()
        {
            mem[1152921519998164128] = "geocoding/v5/";
            mem[1152921519998164136] = "mapbox.places/";
            if(this != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GeocodeResource<T>()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                    val_1.Add(item:  "country");
            }
            else
            {
                    val_1.Add(item:  "country");
            }
            
            val_1.Add(item:  "region");
            if(val_1 != null)
            {
                    val_1.Add(item:  "postcode");
            }
            else
            {
                    val_1.Add(item:  "postcode");
            }
            
            val_1.Add(item:  "place");
            if(val_1 != null)
            {
                    val_1.Add(item:  "locality");
            }
            else
            {
                    val_1.Add(item:  "locality");
            }
            
            val_1.Add(item:  "neighborhood");
            if(val_1 != null)
            {
                    val_1.Add(item:  "address");
            }
            else
            {
                    val_1.Add(item:  "address");
            }
            
            val_1.Add(item:  "poi");
            mem2[0] = val_1;
        }
    
    }

}
