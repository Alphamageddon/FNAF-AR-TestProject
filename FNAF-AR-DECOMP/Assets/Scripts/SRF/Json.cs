using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Json
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object Deserialize(string json)
        {
            if(json == null)
            {
                    return (object)json;
            }
            
            return Json.Parser.Parse(jsonString:  json);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Serialize(object obj)
        {
            return Json.Serializer.Serialize(obj:  obj);
        }
    
    }

}
