using UnityEngine;

namespace GameAnalyticsSDK.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GA_MiniJSON
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object Deserialize(string json)
        {
            if(json == null)
            {
                    return (object)json;
            }
            
            return GA_MiniJSON.Parser.Parse(jsonString:  json);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Serialize(object obj)
        {
            return GA_MiniJSON.Serializer.Serialize(obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GA_MiniJSON()
        {
        
        }
    
    }

}
