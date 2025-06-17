using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSceneRecognitionAdapter : ISceneRecognitionAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSceneRecognitionAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSceneRecognitionAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUpdateEvent(string[] sceneLabels, float[] probs)
        {
            InternalClipper.IntPoint val_1 = new InternalClipper.IntPoint(X:  sceneLabels, Y:  probs);
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._accepter.OnSceneRecognitionUpdate(recognition:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition() {SceneLabels = val_1.X, SceneProbs = val_1.Y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSceneRecognitionAdapter()
        {
        
        }
    
    }

}
