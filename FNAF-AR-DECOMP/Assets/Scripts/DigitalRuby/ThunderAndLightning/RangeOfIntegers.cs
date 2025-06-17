using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public struct RangeOfIntegers
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Minimum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Maximum;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Random()
        {
            return UnityEngine.Random.Range(min:  -1490904080, max:  W8 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Random(System.Random r)
        {
            System.Random val_1 = r & 1;
            var val_2 = W2 & 1;
            goto X8;
        }
    
    }

}
