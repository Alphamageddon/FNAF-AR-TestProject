using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IConvertableFromNative<T>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract T ParseFromAJO(UnityEngine.AndroidJavaObject ajo); // 0
    
    }

}
