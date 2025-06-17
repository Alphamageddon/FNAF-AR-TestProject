using UnityEngine;

namespace SharedTechAssets.Scripts.SceneRecognition
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SceneRecognition_Config : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool enableSceneRecognition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int updateFrequency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useCPUOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minProbThreshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool shouldDownloadModel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SceneRecognition_Config()
        {
        
        }
    
    }

}
