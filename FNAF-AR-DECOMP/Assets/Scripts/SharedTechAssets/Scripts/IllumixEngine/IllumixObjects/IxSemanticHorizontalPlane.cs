using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticHorizontalPlane : IllumixHorizontalSupportedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticInfo> tileToPrediction;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticHorizontalPlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 initialCenter, UnityEngine.Vector2 discretizedCenter, int updateKey, float tileLength)
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
