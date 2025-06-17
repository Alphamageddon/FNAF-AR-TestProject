using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerFilterCombiner : ILayerFeatureFilterComparer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer> Filters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Filters.LayerFilterCombinerOperationType Type;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Try(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            var val_7;
            LayerFilterCombiner.<>c__DisplayClass2_0 val_1 = new LayerFilterCombiner.<>c__DisplayClass2_0();
            .feature = feature;
            if(this.Type == 2)
            {
                goto label_2;
            }
            
            if(this.Type == 1)
            {
                    return System.Linq.Enumerable.All<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  this.Filters, predicate:  new System.Func<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer, System.Boolean>(object:  val_1, method:  System.Boolean LayerFilterCombiner.<>c__DisplayClass2_0::<Try>b__1(Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer m)));
            }
            
            if(this.Type != 0)
            {
                goto label_4;
            }
            
            return System.Linq.Enumerable.Any<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  this.Filters, predicate:  new System.Func<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer, System.Boolean>(object:  val_1, method:  System.Boolean LayerFilterCombiner.<>c__DisplayClass2_0::<Try>b__0(Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer m)));
            label_2:
            val_7 = (System.Linq.Enumerable.Any<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  this.Filters, predicate:  new System.Func<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer, System.Boolean>(object:  val_1, method:  System.Boolean LayerFilterCombiner.<>c__DisplayClass2_0::<Try>b__2(Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer m)))) ^ 1;
            return (bool)val_7 & 1;
            label_4:
            val_7 = 0;
            return (bool)val_7 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerFilterCombiner()
        {
        
        }
    
    }

}
