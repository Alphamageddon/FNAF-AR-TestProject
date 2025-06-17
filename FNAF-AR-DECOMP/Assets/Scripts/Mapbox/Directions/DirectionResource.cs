using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DirectionResource : Resource
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string apiEndpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.RoutingProfile profile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d[] coordinates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<bool> alternatives;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.BearingFilter[] bearings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<bool> continueStraight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.Overview overview;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] radiuses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<bool> steps;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ApiEndpoint { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d[] Coordinates { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.RoutingProfile RoutingProfile { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> Alternatives { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.BearingFilter[] Bearings { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ContinueStraight { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.Overview Overview { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] Radiuses { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> Steps { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DirectionResource(Mapbox.Utils.Vector2d[] coordinates, Mapbox.Directions.RoutingProfile profile)
        {
            this.apiEndpoint = "directions/v5/";
            this.Coordinates = coordinates;
            this.profile = profile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_ApiEndpoint()
        {
            return (string)this.apiEndpoint;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d[] get_Coordinates()
        {
            return (Mapbox.Utils.Vector2d[])this.coordinates;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Coordinates(Mapbox.Utils.Vector2d[] value)
        {
            int val_2 = value.Length;
            val_2 = val_2 - 2;
            if(val_2 < 24)
            {
                    this.coordinates = value;
                return;
            }
            
            System.Exception val_1 = new System.Exception(message:  "Must be between 2 and 25 elements in coordinates array.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.RoutingProfile get_RoutingProfile()
        {
            return (Mapbox.Directions.RoutingProfile)this.profile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_RoutingProfile(Mapbox.Directions.RoutingProfile value)
        {
            this.profile = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> get_Alternatives()
        {
            return (System.Nullable<System.Boolean>)this.alternatives;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Alternatives(System.Nullable<bool> value)
        {
            this.alternatives = value.HasValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.BearingFilter[] get_Bearings()
        {
            return (Mapbox.Utils.BearingFilter[])this.bearings;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Bearings(Mapbox.Utils.BearingFilter[] value)
        {
            if(value != null)
            {
                    if(value.Length != this.coordinates.Length)
            {
                goto label_3;
            }
            
            }
            
            this.bearings = value;
            return;
            label_3:
            System.Exception val_1 = new System.Exception(message:  "There must be as many bearings as there are coordinates in the request.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> get_ContinueStraight()
        {
            return (System.Nullable<System.Boolean>)this.continueStraight;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ContinueStraight(System.Nullable<bool> value)
        {
            this.continueStraight = value.HasValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.Overview get_Overview()
        {
            return (Mapbox.Directions.Overview)this.overview;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Overview(Mapbox.Directions.Overview value)
        {
            this.overview = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] get_Radiuses()
        {
            return (System.Double[])this.radiuses;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Radiuses(double[] value)
        {
            if(value == null)
            {
                goto label_4;
            }
            
            if(value.Length != this.coordinates.Length)
            {
                goto label_8;
            }
            
            if(value.Length < 1)
            {
                goto label_4;
            }
            
            label_7:
            if(value[0] <= 0f)
            {
                goto label_6;
            }
            
            if((0 + 1) < value.Length)
            {
                goto label_7;
            }
            
            label_4:
            this.radiuses = value;
            return;
            label_6:
            label_8:
            null = new System.Exception(message:  "Radius must be greater than 0");
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> get_Steps()
        {
            return (System.Nullable<System.Boolean>)this.steps;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Steps(System.Nullable<bool> value)
        {
            this.steps = value.HasValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string GetUrl()
        {
            string val_11;
            var val_12;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(((-1779934932) & 1) != 0)
            {
                    val_1.Add(key:  "alternatives", value:  this.alternatives.ToLower());
            }
            
            if(this.bearings != null)
            {
                    val_1.Add(key:  "bearings", value:  Mapbox.Platform.Resource.GetUrlQueryFromArray<Mapbox.Utils.BearingFilter>(items:  this.bearings, separator:  ";"));
            }
            
            val_11 = public System.Boolean System.Nullable<System.Boolean>::get_HasValue();
            if(((-1779934932) & 1) != 0)
            {
                    val_11 = "continue_straight";
                val_1.Add(key:  val_11, value:  this.continueStraight.ToLower());
            }
            
            if(this.overview != null)
            {
                    val_1.Add(key:  "overview", value:  this.overview);
            }
            
            if(this.radiuses != null)
            {
                    val_1.Add(key:  "radiuses", value:  Mapbox.Platform.Resource.GetUrlQueryFromArray<System.Double>(items:  this.radiuses, separator:  ","));
            }
            
            if(((-1779934932) & 1) != 0)
            {
                    val_1.Add(key:  "steps", value:  this.steps.ToLower());
            }
            
            val_12 = 6;
            object[] val_7 = new object[6];
            if(("https://api.mapbox.com/") == null)
            {
                    val_12 = 0;
            }
            
            if(val_7.Length == 0)
            {
                    val_12 = 0;
            }
            
            val_7[0] = "https://api.mapbox.com/";
            val_7[1] = this;
            val_7[2] = this.profile;
            val_7[3] = Mapbox.Platform.Resource.GetUrlQueryFromArray<Mapbox.Utils.Vector2d>(items:  this.coordinates, separator:  ";");
            val_7[4] = ".json";
            val_7[5] = Mapbox.Platform.Resource.EncodeQueryString(values:  val_1);
            return (string)+val_7;
        }
    
    }

}
