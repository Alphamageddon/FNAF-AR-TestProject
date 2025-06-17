using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct IxSemanticInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Label;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Confidence;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticInfo(string label, float confidence)
        {
            mem[1152921523145007408] = label;
            mem[1152921523145007416] = confidence;
        }
    
    }

}
