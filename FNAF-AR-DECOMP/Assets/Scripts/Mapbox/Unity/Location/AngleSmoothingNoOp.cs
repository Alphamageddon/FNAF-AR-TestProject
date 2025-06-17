using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AngleSmoothingNoOp : AngleSmoothingAbstractBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override double Calculate()
        {
            if(this != null)
            {
                    return this.Item[0];
            }
            
            return this.Item[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AngleSmoothingNoOp()
        {
        
        }
    
    }

}
