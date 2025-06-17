using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerPropertyIsLessFilterComparer : LayerHasPropertyFilterComparer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Min;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool PropertyComparer(object property)
        {
            var val_3;
            if(property != null)
            {
                    var val_2 = ((System.Convert.ToDouble(value:  property)) < 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerPropertyIsLessFilterComparer()
        {
        
        }
    
    }

}
