using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public struct RangeOfFloats
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Minimum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Maximum;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Random()
        {
            return UnityEngine.Random.Range(min:  null, max:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Random(System.Random r)
        {
        
        }
    
    }

}
