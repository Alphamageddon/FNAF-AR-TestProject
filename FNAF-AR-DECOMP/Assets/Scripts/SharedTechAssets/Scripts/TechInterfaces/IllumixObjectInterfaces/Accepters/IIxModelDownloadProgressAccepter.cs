using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxModelDownloadProgressAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnUpdateEvent(string label, int bytesWritten, int totalBytesToWrite); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnCompleteEvent(string label, bool didFail); // 0
    
    }

}
