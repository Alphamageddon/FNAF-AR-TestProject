using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVerticalPlane : IllumixVerticalSupportedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticInfo> tileToPrediction;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVerticalPlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 initialCenter, UnityEngine.Vector3 normal, int updateKey)
        {
            this.tileToPrediction = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticInfo>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LabelTile(UnityEngine.Vector2 tileKey, string label, int labelId, float confidence)
        {
            this.tileToPrediction.set_Item(key:  new UnityEngine.Vector2() {x = tileKey.x, y = tileKey.y}, value:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticInfo() {Label = label, Confidence = confidence});
        }
    
    }

}
