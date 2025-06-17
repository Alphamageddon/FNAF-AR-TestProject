using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerPropertyContainsFilterComparer : LayerHasPropertyFilterComparer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<object> ValueSet;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool PropertyComparer(object property)
        {
            var val_3;
            var val_11;
            var val_12;
            var val_13;
            val_12 = property;
            List.Enumerator<T> val_1 = this.ValueSet.GetEnumerator();
            do
            {
                if(((-2051514064) & 1) == 0)
            {
                goto label_15;
            }
            
                val_11 = val_12.ToLower();
            }
            while((val_11.Contains(value:  val_3.emailUIDataHandler.ToString())) == false);
            
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519735202096});
            val_13 = 1;
            return (bool)val_13;
            label_15:
            val_13 = 0;
            return (bool)val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerPropertyContainsFilterComparer()
        {
            val_1 = new System.Object();
        }
    
    }

}
