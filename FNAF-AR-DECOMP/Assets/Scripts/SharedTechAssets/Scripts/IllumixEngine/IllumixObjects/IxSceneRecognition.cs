using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct IxSceneRecognition
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] SceneLabels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float[] SceneProbs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSceneRecognition(string[] sceneLabels, float[] sceneProbs)
        {
            mem[1152921523144558768] = sceneLabels;
            mem[1152921523144558776] = sceneProbs;
        }
    
    }

}
