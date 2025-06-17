using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MapUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string NormalizeStaticStyleURL(string url)
        {
            int val_6;
            if((url.StartsWith(value:  "mapbox://", comparisonType:  4)) == false)
            {
                    return (string)url;
            }
            
            char[] val_2 = new char[1];
            val_2[0] = '/';
            System.String[] val_3 = url.Split(separator:  val_2);
            val_6 = val_3.Length;
            if(val_6 <= 3)
            {
                    val_6 = val_3.Length;
            }
            
            if(val_6 <= 4)
            {
                    val_6 = val_3.Length;
            }
            
            string[] val_5 = new string[6];
            val_5[0] = "https://api.mapbox.com/styles/v1/";
            val_5[1] = val_3[3];
            val_5[2] = "/";
            val_5[3] = val_3[4];
            val_5[4] = (val_6 < 6) ? System.String.__il2cppRuntimeField_static_fields : "/draft";
            val_5[5] = "/tiles";
            return +val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string MapIdToUrl(string id)
        {
            return "https://api.mapbox.com/v4/"("https://api.mapbox.com/v4/") + id;
        }
    
    }

}
