using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerPropertyInRangeFilterComparer : LayerHasPropertyFilterComparer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Max;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool PropertyComparer(object property)
        {
            var val_3;
            if(property != null)
            {
                    double val_1 = System.Convert.ToDouble(value:  property);
                if(val_1 >= 0)
            {
                    var val_2 = (val_1 < this.Max) ? 1 : 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerPropertyInRangeFilterComparer()
        {
            val_1 = new System.Object();
        }
    
    }

}
