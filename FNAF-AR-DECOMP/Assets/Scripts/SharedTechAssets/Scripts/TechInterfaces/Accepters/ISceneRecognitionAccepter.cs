using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISceneRecognitionAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnUpdateEvent(string[] sceneLabels, float[] probs); // 0
    
    }

}
