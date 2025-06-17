using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISerializerPlugin : IPlayFabPlugin
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract T DeserializeObject<T>(string serialized); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract T DeserializeObject<T>(string serialized, object serializerStrategy); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract object DeserializeObject(string serialized); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string SerializeObject(object obj); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string SerializeObject(object obj, object serializerStrategy); // 0
    
    }

}
