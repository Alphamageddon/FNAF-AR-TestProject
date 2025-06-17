using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerPropertyIsEqualFilterComparer : LayerHasPropertyFilterComparer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Min;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool PropertyComparer(object property)
        {
            var val_4;
            if(property != null)
            {
                    var val_3 = ((System.Math.Abs((System.Convert.ToDouble(value:  property)) - this.Min)) < 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerPropertyIsEqualFilterComparer()
        {
        
        }
    
    }

}
