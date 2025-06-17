using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SceneRecognitionDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISceneRecognitionAccepter> sceneRecognitionAccepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.ISceneRecognitionAccepter accepter)
        {
            this.sceneRecognitionAccepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISceneRecognitionAccepter> accepters)
        {
            this.sceneRecognitionAccepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendSceneRecognitionEvent(string[] labels, float[] probs)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.sceneRecognitionAccepters.Item[0].OnUpdateEvent(sceneLabels:  labels, probs:  probs);
            0 = 1;
            label_1:
            if(0 < this.sceneRecognitionAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SceneRecognitionDispenser()
        {
            this.sceneRecognitionAccepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISceneRecognitionAccepter>();
        }
    
    }

}
