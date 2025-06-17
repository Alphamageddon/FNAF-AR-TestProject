using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IJsonSerializerStrategy
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool TrySerializeNonPrimitiveObject(object input, out object output); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract object DeserializeObject(object value, System.Type type); // 0
    
    }

}
