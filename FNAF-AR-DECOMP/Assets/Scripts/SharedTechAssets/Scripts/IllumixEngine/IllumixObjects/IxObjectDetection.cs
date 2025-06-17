using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct IxObjectDetection
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string objectType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float maxX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float maxY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float conf;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxObjectDetection(string objectType, float minX, float minY, float maxX, float maxY, float conf)
        {
            this.maxX = objectType;
            this.conf = minX;
            mem[1152921523144368956] = minY;
            mem[1152921523144368960] = maxX;
            mem[1152921523144368964] = maxY;
            mem[1152921523144368968] = conf;
        }
    
    }

}
