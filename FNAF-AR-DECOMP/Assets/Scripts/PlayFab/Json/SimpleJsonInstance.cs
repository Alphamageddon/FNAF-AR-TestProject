using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SimpleJsonInstance : ISerializerPlugin, IPlayFabPlugin
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.SimpleJsonInstance.PlayFabSimpleJsonCuztomization ApiSerializerStrategy;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T DeserializeObject<T>(string json)
        {
            null = null;
            goto __RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T DeserializeObject<T>(string json, object jsonSerializerStrategy)
        {
            if(jsonSerializerStrategy == null)
            {
                    return (object)json;
            }
            
            if(jsonSerializerStrategy != null)
            {
                    return (object)json;
            }
            
            return (object)json;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object DeserializeObject(string json)
        {
            var val_2 = null;
            return PlayFab.Json.PlayFabSimpleJson.DeserializeObject(json:  json, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), jsonSerializerStrategy:  PlayFab.Json.SimpleJsonInstance.ApiSerializerStrategy);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SerializeObject(object json)
        {
            null = null;
            return PlayFab.Json.PlayFabSimpleJson.SerializeObject(json:  json, jsonSerializerStrategy:  PlayFab.Json.SimpleJsonInstance.ApiSerializerStrategy);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SerializeObject(object json, object jsonSerializerStrategy)
        {
            PlayFab.Json.IJsonSerializerStrategy val_3;
            if(jsonSerializerStrategy != null)
            {
                    val_3 = jsonSerializerStrategy;
                if(val_3 != null)
            {
                    return (string)PlayFab.Json.PlayFabSimpleJson.SerializeObject(json:  json, jsonSerializerStrategy:  val_3 = 0);
            }
            
            }
            
            return (string)PlayFab.Json.PlayFabSimpleJson.SerializeObject(json:  json, jsonSerializerStrategy:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SimpleJsonInstance()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SimpleJsonInstance()
        {
            PlayFab.Json.SimpleJsonInstance.ApiSerializerStrategy = new SimpleJsonInstance.PlayFabSimpleJsonCuztomization();
        }
    
    }

}
