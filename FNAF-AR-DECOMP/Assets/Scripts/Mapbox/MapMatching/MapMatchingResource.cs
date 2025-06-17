using UnityEngine;

namespace Mapbox.MapMatching
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapMatchingResource : Resource
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _apiEndpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d[] _coordinates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint[] _radiuses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long[] _timestamps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.MapMatching.Profile Profile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.MapMatching.Geometries> Geometries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> Steps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.MapMatching.Overview> Overview;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.MapMatching.Annotations> Annotations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> Tidy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.MapMatching.InstructionLanguages> Language;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ApiEndpoint { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d[] Coordinates { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint[] Radiuses { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long[] Timestamps { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_ApiEndpoint()
        {
            return (string)this._apiEndpoint;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d[] get_Coordinates()
        {
            return (Mapbox.Utils.Vector2d[])this._coordinates;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Coordinates(Mapbox.Utils.Vector2d[] value)
        {
            string val_3;
            if(value == null)
            {
                goto label_1;
            }
            
            int val_2 = value.Length;
            val_2 = val_2 - 2;
            if(val_2 >= 99)
            {
                goto label_2;
            }
            
            this._coordinates = value;
            return;
            label_1:
            val_3 = "Coordinates cannot be null.";
            goto label_3;
            label_2:
            val_3 = "Must be between 2 and 100 elements in coordinates array";
            label_3:
            null = new System.Exception(message:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint[] get_Radiuses()
        {
            return (System.UInt32[])this._radiuses;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Radiuses(uint[] value)
        {
            System.Func<System.UInt32, System.Boolean> val_5;
            var val_6;
            string val_9;
            if(this._coordinates == null)
            {
                goto label_1;
            }
            
            if(value == null)
            {
                goto label_2;
            }
            
            if(value.Length != this._coordinates.Length)
            {
                goto label_3;
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = MapMatchingResource.<>c.<>9__13_0;
            if(val_5 == null)
            {
                    System.Func<System.UInt32, System.Boolean> val_1 = null;
                val_5 = val_1;
                val_1 = new System.Func<System.UInt32, System.Boolean>(object:  MapMatchingResource.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MapMatchingResource.<>c::<set_Radiuses>b__13_0(uint r));
                MapMatchingResource.<>c.<>9__13_0 = val_5;
            }
            
            if((System.Linq.Enumerable.Count<System.UInt32>(source:  System.Linq.Enumerable.Where<System.UInt32>(source:  value, predicate:  val_1))) >= 1)
            {
                goto label_9;
            }
            
            label_2:
            this._radiuses = value;
            return;
            label_1:
            val_9 = "Coordinates not set";
            goto label_11;
            label_3:
            val_9 = "There must be as many radiuses as there are coordinates in the request.";
            goto label_11;
            label_9:
            val_9 = "Radius must be greater than 0";
            label_11:
            null = new System.Exception(message:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long[] get_Timestamps()
        {
            return (System.Int64[])this._timestamps;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Timestamps(long[] value)
        {
            string val_3;
            if(this._coordinates != null)
            {
                    if(value != null)
            {
                    if(value.Length != this._coordinates.Length)
            {
                goto label_3;
            }
            
            }
            
                this._timestamps = value;
                return;
            }
            
            val_3 = "Coordinates not set";
            goto label_4;
            label_3:
            val_3 = "There must be as many timestapms as there are coordinates in the request.";
            label_4:
            null = new System.Exception(message:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string GetUrl()
        {
            if(this._coordinates != null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
                if((this.Geometries & 1) != 0)
            {
                    val_1.Add(key:  "geometries", value:  Mapbox.VectorTile.ExtensionMethods.EnumExtensions.Description(value:  new System.Enum()));
            }
            
                if(this._radiuses != null)
            {
                    val_1.Add(key:  "radiuses", value:  Mapbox.Platform.Resource.GetUrlQueryFromArray<System.UInt32>(items:  this._radiuses, separator:  ";"));
            }
            
                if((this.Steps & 1) != 0)
            {
                    val_1.Add(key:  "steps", value:  this.Steps.ToLower());
            }
            
                if((this.Overview & 1) != 0)
            {
                    val_1.Add(key:  "overview", value:  Mapbox.VectorTile.ExtensionMethods.EnumExtensions.Description(value:  new System.Enum()));
            }
            
                if(this._timestamps != null)
            {
                    val_1.Add(key:  "timestamps", value:  Mapbox.Platform.Resource.GetUrlQueryFromArray<System.Int64>(items:  this._timestamps, separator:  ";"));
            }
            
                if((this.Annotations & 1) != 0)
            {
                    val_1.Add(key:  "annotations", value:  this.Annotations.getUrlQueryFromAnnotations(anno:  this.Annotations, separator:  ","));
            }
            
                if((this.Tidy & 1) != 0)
            {
                    val_1.Add(key:  "tidy", value:  this.Tidy & 1.ToString().ToLower());
            }
            
                if((this.Language & 1) != 0)
            {
                    val_1.Add(key:  "language", value:  Mapbox.VectorTile.ExtensionMethods.EnumExtensions.Description(value:  new System.Enum()));
            }
            
                string[] val_12 = new string[7];
                val_12[0] = "https://api.mapbox.com/";
                val_12[1] = this._apiEndpoint;
                val_12[2] = Mapbox.VectorTile.ExtensionMethods.EnumExtensions.Description(value:  new System.Enum());
                val_12[3] = "/";
                val_12[4] = Mapbox.Platform.Resource.GetUrlQueryFromArray<Mapbox.Utils.Vector2d>(items:  this._coordinates, separator:  ";");
                val_12[5] = ".json";
                val_12[6] = Mapbox.Platform.Resource.EncodeQueryString(values:  val_1);
                return (string)+val_12;
            }
            
            System.Exception val_17 = new System.Exception(message:  "Coordinates cannot be null.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string getUrlQueryFromAnnotations(Mapbox.MapMatching.Annotations anno, string separator)
        {
            var val_16;
            var val_17;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = System.Linq.Enumerable.Cast<Mapbox.MapMatching.Annotations>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))).GetEnumerator();
            label_23:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_15;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            if((val_6.Current & (~anno)) != 0)
            {
                goto label_23;
            }
            
            val_1.Add(item:  Mapbox.VectorTile.ExtensionMethods.EnumExtensions.Description(value:  new System.Enum()));
            goto label_23;
            label_15:
            val_16 = 0;
            val_17 = 84;
            if(val_6 == null)
            {
                    return (string)System.String.Join(separator:  separator, value:  val_1.ToArray());
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_6.Dispose();
            return (string)System.String.Join(separator:  separator, value:  val_1.ToArray());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMatchingResource()
        {
            this._apiEndpoint = "matching/v5/";
        }
    
    }

}
