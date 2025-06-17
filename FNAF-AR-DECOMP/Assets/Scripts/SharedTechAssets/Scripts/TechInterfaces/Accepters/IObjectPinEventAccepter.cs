using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IObjectPinEventAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnBeginEvent(int predId, string label, float confidence); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnEndEvent(); // 0
    
    }

}
