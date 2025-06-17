using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectDetectionManager_Config : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool enableObjDetect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int updateFrequency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useCPUOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool shouldDownloadModel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectDetectionManager_Config()
        {
        
        }
    
    }

}
