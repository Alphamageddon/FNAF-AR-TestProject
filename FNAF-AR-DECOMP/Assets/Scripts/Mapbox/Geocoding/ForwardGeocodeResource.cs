using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ForwardGeocodeResource : GeocodeResource<string>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.List<string> CountryCodes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string query;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<bool> autocomplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] country;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<Mapbox.Utils.Vector2d> proximity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<Mapbox.Utils.Vector2dBounds> bbox;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int limit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool fuzzyMatch;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string Query { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> Autocomplete { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.Utils.Vector2dBounds> Bbox { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool FuzzyMatch { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] Country { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.Utils.Vector2d> Proximity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Limit { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ForwardGeocodeResource(string query)
        {
            goto typeof(Mapbox.Geocoding.ForwardGeocodeResource).__il2cppRuntimeField_198;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string get_Query()
        {
            return (string)this.query;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Query(string value)
        {
            this.query = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> get_Autocomplete()
        {
            return (System.Nullable<System.Boolean>)this.autocomplete;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Autocomplete(System.Nullable<bool> value)
        {
            this.autocomplete = value.HasValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.Utils.Vector2dBounds> get_Bbox()
        {
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = this.bbox;
            return (System.Nullable<Mapbox.Utils.Vector2dBounds>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Bbox(System.Nullable<Mapbox.Utils.Vector2dBounds> value)
        {
            mem[1152921519994621224] = value.HasValue + 32;
            mem[1152921519994621208] = value.HasValue + 16;
            this.bbox = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_FuzzyMatch()
        {
            return (bool)this.fuzzyMatch;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_FuzzyMatch(bool value)
        {
            this.fuzzyMatch = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] get_Country()
        {
            return (System.String[])this.country;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Country(string[] value)
        {
            System.Collections.Generic.List<System.String> val_3;
            int val_4;
            var val_5;
            if(value == null)
            {
                goto label_2;
            }
            
            val_4 = value.Length;
            if(val_4 < 1)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            label_8:
            val_5 = null;
            val_5 = null;
            val_4 = value.Length;
            val_3 = Mapbox.Geocoding.ForwardGeocodeResource.CountryCodes;
            if((val_3.Contains(item:  value[0])) == false)
            {
                goto label_7;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < value.Length)
            {
                goto label_8;
            }
            
            label_2:
            this.country = value;
            return;
            label_7:
            System.Exception val_2 = new System.Exception(message:  "Invalid country shortcode. See https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<Mapbox.Utils.Vector2d> get_Proximity()
        {
            mem2[0] = ???;
            mem2[0] = this.proximity;
            return (System.Nullable<Mapbox.Utils.Vector2d>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Proximity(System.Nullable<Mapbox.Utils.Vector2d> value)
        {
            mem[1152921519995458288] = value.HasValue + 16;
            this.proximity = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Limit()
        {
            return (int)this.limit;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Limit(int value)
        {
            this.limit = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string GetUrl()
        {
            var val_17;
            var val_18;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(((-1790766420) & 1) != 0)
            {
                    val_1.Add(key:  "autocomplete", value:  this.autocomplete.ToLower());
            }
            
            if(this.bbox.supportsTrackableAttachments != false)
            {
                    val_1.Add(key:  "bbox", value:  this.bbox.HasValue);
            }
            
            if(this.country != null)
            {
                    val_1.Add(key:  "country", value:  Mapbox.Platform.Resource.GetUrlQueryFromArray<System.String>(items:  this.country, separator:  ","));
            }
            
            if(this.proximity.HasValue != false)
            {
                    val_1.Add(key:  "proximity", value:  this.proximity.HasValue);
            }
            
            if(this.Types != null)
            {
                    val_1.Add(key:  "types", value:  Mapbox.Platform.Resource.GetUrlQueryFromArray<System.String>(items:  this.Types, separator:  ","));
            }
            
            val_1.Add(key:  "fuzzyMatch", value:  this.fuzzyMatch.ToString().ToLower());
            if(this.limit >= 1)
            {
                    val_1.Add(key:  "limit", value:  this.limit.ToString());
            }
            
            val_17 = 6;
            string[] val_12 = new string[6];
            if(("https://api.mapbox.com/") == null)
            {
                    val_17 = 0;
            }
            
            if(val_12.Length == 0)
            {
                    val_17 = 0;
            }
            
            val_12[0] = "https://api.mapbox.com/";
            val_12[1] = this;
            val_18 = public System.String Mapbox.Geocoding.GeocodeResource<System.String>::get_Mode();
            string val_13 = this.Mode;
            if((val_13 != null) && (val_13 == null))
            {
                    val_18 = 0;
            }
            
            if(val_12.Length <= 2)
            {
                    val_18 = 0;
            }
            
            val_12[2] = val_13;
            val_12[3] = System.Uri.EscapeDataString(stringToEscape:  this);
            val_12[4] = ".json";
            val_12[5] = Mapbox.Platform.Resource.EncodeQueryString(values:  val_1);
            return (string)+val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ForwardGeocodeResource()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                    val_1.Add(item:  "ad");
            }
            else
            {
                    val_1.Add(item:  "ad");
            }
            
            val_1.Add(item:  "ae");
            if(val_1 != null)
            {
                    val_1.Add(item:  "af");
            }
            else
            {
                    val_1.Add(item:  "af");
            }
            
            val_1.Add(item:  "ag");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ai");
            }
            else
            {
                    val_1.Add(item:  "ai");
            }
            
            val_1.Add(item:  "al");
            if(val_1 != null)
            {
                    val_1.Add(item:  "am");
            }
            else
            {
                    val_1.Add(item:  "am");
            }
            
            val_1.Add(item:  "ao");
            if(val_1 != null)
            {
                    val_1.Add(item:  "aq");
            }
            else
            {
                    val_1.Add(item:  "aq");
            }
            
            val_1.Add(item:  "ar");
            if(val_1 != null)
            {
                    val_1.Add(item:  "as");
            }
            else
            {
                    val_1.Add(item:  "as");
            }
            
            val_1.Add(item:  "at");
            if(val_1 != null)
            {
                    val_1.Add(item:  "au");
            }
            else
            {
                    val_1.Add(item:  "au");
            }
            
            val_1.Add(item:  "aw");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ax");
            }
            else
            {
                    val_1.Add(item:  "ax");
            }
            
            val_1.Add(item:  "az");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ba");
            }
            else
            {
                    val_1.Add(item:  "ba");
            }
            
            val_1.Add(item:  "bb");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bd");
            }
            else
            {
                    val_1.Add(item:  "bd");
            }
            
            val_1.Add(item:  "be");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bf");
            }
            else
            {
                    val_1.Add(item:  "bf");
            }
            
            val_1.Add(item:  "bg");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bh");
            }
            else
            {
                    val_1.Add(item:  "bh");
            }
            
            val_1.Add(item:  "bi");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bj");
            }
            else
            {
                    val_1.Add(item:  "bj");
            }
            
            val_1.Add(item:  "bl");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bm");
            }
            else
            {
                    val_1.Add(item:  "bm");
            }
            
            val_1.Add(item:  "bn");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bo");
            }
            else
            {
                    val_1.Add(item:  "bo");
            }
            
            val_1.Add(item:  "bq");
            if(val_1 != null)
            {
                    val_1.Add(item:  "br");
            }
            else
            {
                    val_1.Add(item:  "br");
            }
            
            val_1.Add(item:  "bs");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bt");
            }
            else
            {
                    val_1.Add(item:  "bt");
            }
            
            val_1.Add(item:  "bv");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bw");
            }
            else
            {
                    val_1.Add(item:  "bw");
            }
            
            val_1.Add(item:  "by");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bz");
            }
            else
            {
                    val_1.Add(item:  "bz");
            }
            
            val_1.Add(item:  "ca");
            if(val_1 != null)
            {
                    val_1.Add(item:  "cc");
            }
            else
            {
                    val_1.Add(item:  "cc");
            }
            
            val_1.Add(item:  "cd");
            if(val_1 != null)
            {
                    val_1.Add(item:  "cf");
            }
            else
            {
                    val_1.Add(item:  "cf");
            }
            
            val_1.Add(item:  "cg");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ch");
            }
            else
            {
                    val_1.Add(item:  "ch");
            }
            
            val_1.Add(item:  "ci");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ck");
            }
            else
            {
                    val_1.Add(item:  "ck");
            }
            
            val_1.Add(item:  "cl");
            if(val_1 != null)
            {
                    val_1.Add(item:  "cm");
            }
            else
            {
                    val_1.Add(item:  "cm");
            }
            
            val_1.Add(item:  "cn");
            if(val_1 != null)
            {
                    val_1.Add(item:  "co");
            }
            else
            {
                    val_1.Add(item:  "co");
            }
            
            val_1.Add(item:  "cr");
            if(val_1 != null)
            {
                    val_1.Add(item:  "cu");
            }
            else
            {
                    val_1.Add(item:  "cu");
            }
            
            val_1.Add(item:  "cv");
            if(val_1 != null)
            {
                    val_1.Add(item:  "cw");
            }
            else
            {
                    val_1.Add(item:  "cw");
            }
            
            val_1.Add(item:  "cx");
            if(val_1 != null)
            {
                    val_1.Add(item:  "cy");
            }
            else
            {
                    val_1.Add(item:  "cy");
            }
            
            val_1.Add(item:  "cz");
            if(val_1 != null)
            {
                    val_1.Add(item:  "de");
            }
            else
            {
                    val_1.Add(item:  "de");
            }
            
            val_1.Add(item:  "dj");
            if(val_1 != null)
            {
                    val_1.Add(item:  "dk");
            }
            else
            {
                    val_1.Add(item:  "dk");
            }
            
            val_1.Add(item:  "dm");
            if(val_1 != null)
            {
                    val_1.Add(item:  "do");
            }
            else
            {
                    val_1.Add(item:  "do");
            }
            
            val_1.Add(item:  "dz");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ec");
            }
            else
            {
                    val_1.Add(item:  "ec");
            }
            
            val_1.Add(item:  "ee");
            if(val_1 != null)
            {
                    val_1.Add(item:  "eg");
            }
            else
            {
                    val_1.Add(item:  "eg");
            }
            
            val_1.Add(item:  "eh");
            if(val_1 != null)
            {
                    val_1.Add(item:  "er");
            }
            else
            {
                    val_1.Add(item:  "er");
            }
            
            val_1.Add(item:  "es");
            if(val_1 != null)
            {
                    val_1.Add(item:  "et");
            }
            else
            {
                    val_1.Add(item:  "et");
            }
            
            val_1.Add(item:  "fi");
            if(val_1 != null)
            {
                    val_1.Add(item:  "fj");
            }
            else
            {
                    val_1.Add(item:  "fj");
            }
            
            val_1.Add(item:  "fk");
            if(val_1 != null)
            {
                    val_1.Add(item:  "fm");
            }
            else
            {
                    val_1.Add(item:  "fm");
            }
            
            val_1.Add(item:  "fo");
            if(val_1 != null)
            {
                    val_1.Add(item:  "fr");
            }
            else
            {
                    val_1.Add(item:  "fr");
            }
            
            val_1.Add(item:  "ga");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gb");
            }
            else
            {
                    val_1.Add(item:  "gb");
            }
            
            val_1.Add(item:  "gd");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ge");
            }
            else
            {
                    val_1.Add(item:  "ge");
            }
            
            val_1.Add(item:  "gf");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gg");
            }
            else
            {
                    val_1.Add(item:  "gg");
            }
            
            val_1.Add(item:  "gh");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gi");
            }
            else
            {
                    val_1.Add(item:  "gi");
            }
            
            val_1.Add(item:  "gl");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gm");
            }
            else
            {
                    val_1.Add(item:  "gm");
            }
            
            val_1.Add(item:  "gn");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gp");
            }
            else
            {
                    val_1.Add(item:  "gp");
            }
            
            val_1.Add(item:  "gq");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gr");
            }
            else
            {
                    val_1.Add(item:  "gr");
            }
            
            val_1.Add(item:  "gs");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gt");
            }
            else
            {
                    val_1.Add(item:  "gt");
            }
            
            val_1.Add(item:  "gu");
            if(val_1 != null)
            {
                    val_1.Add(item:  "gw");
            }
            else
            {
                    val_1.Add(item:  "gw");
            }
            
            val_1.Add(item:  "gy");
            if(val_1 != null)
            {
                    val_1.Add(item:  "hk");
            }
            else
            {
                    val_1.Add(item:  "hk");
            }
            
            val_1.Add(item:  "hm");
            if(val_1 != null)
            {
                    val_1.Add(item:  "hn");
            }
            else
            {
                    val_1.Add(item:  "hn");
            }
            
            val_1.Add(item:  "hr");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ht");
            }
            else
            {
                    val_1.Add(item:  "ht");
            }
            
            val_1.Add(item:  "hu");
            if(val_1 != null)
            {
                    val_1.Add(item:  "id");
            }
            else
            {
                    val_1.Add(item:  "id");
            }
            
            val_1.Add(item:  "ie");
            if(val_1 != null)
            {
                    val_1.Add(item:  "il");
            }
            else
            {
                    val_1.Add(item:  "il");
            }
            
            val_1.Add(item:  "im");
            if(val_1 != null)
            {
                    val_1.Add(item:  "in");
            }
            else
            {
                    val_1.Add(item:  "in");
            }
            
            val_1.Add(item:  "io");
            if(val_1 != null)
            {
                    val_1.Add(item:  "iq");
            }
            else
            {
                    val_1.Add(item:  "iq");
            }
            
            val_1.Add(item:  "ir");
            if(val_1 != null)
            {
                    val_1.Add(item:  "is");
            }
            else
            {
                    val_1.Add(item:  "is");
            }
            
            val_1.Add(item:  "it");
            if(val_1 != null)
            {
                    val_1.Add(item:  "je");
            }
            else
            {
                    val_1.Add(item:  "je");
            }
            
            val_1.Add(item:  "jm");
            if(val_1 != null)
            {
                    val_1.Add(item:  "jo");
            }
            else
            {
                    val_1.Add(item:  "jo");
            }
            
            val_1.Add(item:  "jp");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ke");
            }
            else
            {
                    val_1.Add(item:  "ke");
            }
            
            val_1.Add(item:  "kg");
            if(val_1 != null)
            {
                    val_1.Add(item:  "kh");
            }
            else
            {
                    val_1.Add(item:  "kh");
            }
            
            val_1.Add(item:  "ki");
            if(val_1 != null)
            {
                    val_1.Add(item:  "km");
            }
            else
            {
                    val_1.Add(item:  "km");
            }
            
            val_1.Add(item:  "kn");
            if(val_1 != null)
            {
                    val_1.Add(item:  "kp");
            }
            else
            {
                    val_1.Add(item:  "kp");
            }
            
            val_1.Add(item:  "kr");
            if(val_1 != null)
            {
                    val_1.Add(item:  "kw");
            }
            else
            {
                    val_1.Add(item:  "kw");
            }
            
            val_1.Add(item:  "ky");
            if(val_1 != null)
            {
                    val_1.Add(item:  "kz");
            }
            else
            {
                    val_1.Add(item:  "kz");
            }
            
            val_1.Add(item:  "la");
            if(val_1 != null)
            {
                    val_1.Add(item:  "lb");
            }
            else
            {
                    val_1.Add(item:  "lb");
            }
            
            val_1.Add(item:  "lc");
            if(val_1 != null)
            {
                    val_1.Add(item:  "li");
            }
            else
            {
                    val_1.Add(item:  "li");
            }
            
            val_1.Add(item:  "lk");
            if(val_1 != null)
            {
                    val_1.Add(item:  "lr");
            }
            else
            {
                    val_1.Add(item:  "lr");
            }
            
            val_1.Add(item:  "ls");
            if(val_1 != null)
            {
                    val_1.Add(item:  "lt");
            }
            else
            {
                    val_1.Add(item:  "lt");
            }
            
            val_1.Add(item:  "lu");
            if(val_1 != null)
            {
                    val_1.Add(item:  "lv");
            }
            else
            {
                    val_1.Add(item:  "lv");
            }
            
            val_1.Add(item:  "ly");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ma");
            }
            else
            {
                    val_1.Add(item:  "ma");
            }
            
            val_1.Add(item:  "mc");
            if(val_1 != null)
            {
                    val_1.Add(item:  "md");
            }
            else
            {
                    val_1.Add(item:  "md");
            }
            
            val_1.Add(item:  "me");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mf");
            }
            else
            {
                    val_1.Add(item:  "mf");
            }
            
            val_1.Add(item:  "mg");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mh");
            }
            else
            {
                    val_1.Add(item:  "mh");
            }
            
            val_1.Add(item:  "mk");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ml");
            }
            else
            {
                    val_1.Add(item:  "ml");
            }
            
            val_1.Add(item:  "mm");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mn");
            }
            else
            {
                    val_1.Add(item:  "mn");
            }
            
            val_1.Add(item:  "mo");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mp");
            }
            else
            {
                    val_1.Add(item:  "mp");
            }
            
            val_1.Add(item:  "mq");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mr");
            }
            else
            {
                    val_1.Add(item:  "mr");
            }
            
            val_1.Add(item:  "ms");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mt");
            }
            else
            {
                    val_1.Add(item:  "mt");
            }
            
            val_1.Add(item:  "mu");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mv");
            }
            else
            {
                    val_1.Add(item:  "mv");
            }
            
            val_1.Add(item:  "mw");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mx");
            }
            else
            {
                    val_1.Add(item:  "mx");
            }
            
            val_1.Add(item:  "my");
            if(val_1 != null)
            {
                    val_1.Add(item:  "mz");
            }
            else
            {
                    val_1.Add(item:  "mz");
            }
            
            val_1.Add(item:  "na");
            if(val_1 != null)
            {
                    val_1.Add(item:  "nc");
            }
            else
            {
                    val_1.Add(item:  "nc");
            }
            
            val_1.Add(item:  "ne");
            if(val_1 != null)
            {
                    val_1.Add(item:  "nf");
            }
            else
            {
                    val_1.Add(item:  "nf");
            }
            
            val_1.Add(item:  "ng");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ni");
            }
            else
            {
                    val_1.Add(item:  "ni");
            }
            
            val_1.Add(item:  "nl");
            if(val_1 != null)
            {
                    val_1.Add(item:  "no");
            }
            else
            {
                    val_1.Add(item:  "no");
            }
            
            val_1.Add(item:  "np");
            if(val_1 != null)
            {
                    val_1.Add(item:  "nr");
            }
            else
            {
                    val_1.Add(item:  "nr");
            }
            
            val_1.Add(item:  "nu");
            if(val_1 != null)
            {
                    val_1.Add(item:  "nz");
            }
            else
            {
                    val_1.Add(item:  "nz");
            }
            
            val_1.Add(item:  "om");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pa");
            }
            else
            {
                    val_1.Add(item:  "pa");
            }
            
            val_1.Add(item:  "pe");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pf");
            }
            else
            {
                    val_1.Add(item:  "pf");
            }
            
            val_1.Add(item:  "pg");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ph");
            }
            else
            {
                    val_1.Add(item:  "ph");
            }
            
            val_1.Add(item:  "pk");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pl");
            }
            else
            {
                    val_1.Add(item:  "pl");
            }
            
            val_1.Add(item:  "pm");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pn");
            }
            else
            {
                    val_1.Add(item:  "pn");
            }
            
            val_1.Add(item:  "pr");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ps");
            }
            else
            {
                    val_1.Add(item:  "ps");
            }
            
            val_1.Add(item:  "pt");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pw");
            }
            else
            {
                    val_1.Add(item:  "pw");
            }
            
            val_1.Add(item:  "py");
            if(val_1 != null)
            {
                    val_1.Add(item:  "qa");
            }
            else
            {
                    val_1.Add(item:  "qa");
            }
            
            val_1.Add(item:  "re");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ro");
            }
            else
            {
                    val_1.Add(item:  "ro");
            }
            
            val_1.Add(item:  "rs");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ru");
            }
            else
            {
                    val_1.Add(item:  "ru");
            }
            
            val_1.Add(item:  "rw");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sa");
            }
            else
            {
                    val_1.Add(item:  "sa");
            }
            
            val_1.Add(item:  "sb");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sc");
            }
            else
            {
                    val_1.Add(item:  "sc");
            }
            
            val_1.Add(item:  "sd");
            if(val_1 != null)
            {
                    val_1.Add(item:  "se");
            }
            else
            {
                    val_1.Add(item:  "se");
            }
            
            val_1.Add(item:  "sg");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sh");
            }
            else
            {
                    val_1.Add(item:  "sh");
            }
            
            val_1.Add(item:  "si");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sj");
            }
            else
            {
                    val_1.Add(item:  "sj");
            }
            
            val_1.Add(item:  "sk");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sl");
            }
            else
            {
                    val_1.Add(item:  "sl");
            }
            
            val_1.Add(item:  "sm");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sn");
            }
            else
            {
                    val_1.Add(item:  "sn");
            }
            
            val_1.Add(item:  "so");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sr");
            }
            else
            {
                    val_1.Add(item:  "sr");
            }
            
            val_1.Add(item:  "ss");
            if(val_1 != null)
            {
                    val_1.Add(item:  "st");
            }
            else
            {
                    val_1.Add(item:  "st");
            }
            
            val_1.Add(item:  "sv");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sx");
            }
            else
            {
                    val_1.Add(item:  "sx");
            }
            
            val_1.Add(item:  "sy");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sz");
            }
            else
            {
                    val_1.Add(item:  "sz");
            }
            
            val_1.Add(item:  "tc");
            if(val_1 != null)
            {
                    val_1.Add(item:  "td");
            }
            else
            {
                    val_1.Add(item:  "td");
            }
            
            val_1.Add(item:  "tf");
            if(val_1 != null)
            {
                    val_1.Add(item:  "tg");
            }
            else
            {
                    val_1.Add(item:  "tg");
            }
            
            val_1.Add(item:  "th");
            if(val_1 != null)
            {
                    val_1.Add(item:  "tj");
            }
            else
            {
                    val_1.Add(item:  "tj");
            }
            
            val_1.Add(item:  "tk");
            if(val_1 != null)
            {
                    val_1.Add(item:  "tl");
            }
            else
            {
                    val_1.Add(item:  "tl");
            }
            
            val_1.Add(item:  "tm");
            if(val_1 != null)
            {
                    val_1.Add(item:  "tn");
            }
            else
            {
                    val_1.Add(item:  "tn");
            }
            
            val_1.Add(item:  "to");
            if(val_1 != null)
            {
                    val_1.Add(item:  "tr");
            }
            else
            {
                    val_1.Add(item:  "tr");
            }
            
            val_1.Add(item:  "tt");
            if(val_1 != null)
            {
                    val_1.Add(item:  "tv");
            }
            else
            {
                    val_1.Add(item:  "tv");
            }
            
            val_1.Add(item:  "tw");
            if(val_1 != null)
            {
                    val_1.Add(item:  "tz");
            }
            else
            {
                    val_1.Add(item:  "tz");
            }
            
            val_1.Add(item:  "ua");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ug");
            }
            else
            {
                    val_1.Add(item:  "ug");
            }
            
            val_1.Add(item:  "um");
            if(val_1 != null)
            {
                    val_1.Add(item:  "us");
            }
            else
            {
                    val_1.Add(item:  "us");
            }
            
            val_1.Add(item:  "uy");
            if(val_1 != null)
            {
                    val_1.Add(item:  "uz");
            }
            else
            {
                    val_1.Add(item:  "uz");
            }
            
            val_1.Add(item:  "va");
            if(val_1 != null)
            {
                    val_1.Add(item:  "vc");
            }
            else
            {
                    val_1.Add(item:  "vc");
            }
            
            val_1.Add(item:  "ve");
            if(val_1 != null)
            {
                    val_1.Add(item:  "vg");
            }
            else
            {
                    val_1.Add(item:  "vg");
            }
            
            val_1.Add(item:  "vi");
            if(val_1 != null)
            {
                    val_1.Add(item:  "vn");
            }
            else
            {
                    val_1.Add(item:  "vn");
            }
            
            val_1.Add(item:  "vu");
            if(val_1 != null)
            {
                    val_1.Add(item:  "wf");
            }
            else
            {
                    val_1.Add(item:  "wf");
            }
            
            val_1.Add(item:  "ws");
            if(val_1 != null)
            {
                    val_1.Add(item:  "ye");
            }
            else
            {
                    val_1.Add(item:  "ye");
            }
            
            val_1.Add(item:  "yt");
            if(val_1 != null)
            {
                    val_1.Add(item:  "za");
            }
            else
            {
                    val_1.Add(item:  "za");
            }
            
            val_1.Add(item:  "zm");
            val_1.Add(item:  "zw");
            Mapbox.Geocoding.ForwardGeocodeResource.CountryCodes = val_1;
        }
    
    }

}
