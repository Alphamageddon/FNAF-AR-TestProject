using UnityEngine;

namespace Systems.ARObjectDetection.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DetectedObject : IComparable<Systems.ARObjectDetection.Data.DetectedObject>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string objectType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numTimesSeen;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CompareTo(Systems.ARObjectDetection.Data.DetectedObject other)
        {
            var val_2;
            if(this.numTimesSeen <= other.numTimesSeen)
            {
                    return (int)(this.numTimesSeen < other.numTimesSeen) ? 1 : 0;
            }
            
            val_2 = 0;
            return (int)(this.numTimesSeen < other.numTimesSeen) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DetectedObject()
        {
        
        }
    
    }

}
