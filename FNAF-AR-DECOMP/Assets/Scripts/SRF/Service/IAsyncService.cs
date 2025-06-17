using UnityEngine;

namespace SRF.Service
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAsyncService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsLoaded { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsLoaded(); // 0
    
    }

}
