using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JsonArray : List<object>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonArray()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonArray(int capacity)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            int val_2;
            if((PlayFab.Json.PlayFabSimpleJson.SerializeObject(json:  this, jsonSerializerStrategy:  0)) != null)
            {
                    return (string)val_2;
            }
            
            val_2 = System.String.alignConst;
            return (string)val_2;
        }
    
    }

}
