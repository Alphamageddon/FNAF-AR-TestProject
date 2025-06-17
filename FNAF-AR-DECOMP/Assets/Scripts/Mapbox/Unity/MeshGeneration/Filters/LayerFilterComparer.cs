using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LayerFilterComparer : ILayerFeatureFilterComparer
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool Try(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer AnyOf(Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer[] filters)
        {
            .Type = 0;
            .Filters = System.Linq.Enumerable.ToList<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  filters);
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)new Mapbox.Unity.MeshGeneration.Filters.LayerFilterCombiner();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer AllOf(Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer[] filters)
        {
            .Type = 1;
            .Filters = System.Linq.Enumerable.ToList<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  filters);
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)new Mapbox.Unity.MeshGeneration.Filters.LayerFilterCombiner();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer NoneOf(Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer[] filters)
        {
            .Type = 2;
            .Filters = System.Linq.Enumerable.ToList<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  filters);
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)new Mapbox.Unity.MeshGeneration.Filters.LayerFilterCombiner();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer HasProperty(string property)
        {
            .Key = property;
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)new Mapbox.Unity.MeshGeneration.Filters.LayerHasPropertyFilterComparer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer HasPropertyInRange(string property, double min, double max)
        {
            Mapbox.Unity.MeshGeneration.Filters.LayerPropertyInRangeFilterComparer val_1 = new Mapbox.Unity.MeshGeneration.Filters.LayerPropertyInRangeFilterComparer();
            if(val_1 != null)
            {
                    mem[1152921519733099520] = property;
                .Min = min;
            }
            else
            {
                    mem[16] = property;
                mem[24] = min;
            }
            
            .Max = max;
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer HasPropertyGreaterThan(string property, double min)
        {
            Mapbox.Unity.MeshGeneration.Filters.LayerPropertyIsGreaterFilterComparer val_1 = new Mapbox.Unity.MeshGeneration.Filters.LayerPropertyIsGreaterFilterComparer();
            if(val_1 != null)
            {
                    mem[1152921519733227904] = property;
            }
            else
            {
                    mem[16] = property;
            }
            
            .Min = min;
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer HasPropertyLessThan(string property, double min)
        {
            Mapbox.Unity.MeshGeneration.Filters.LayerPropertyIsLessFilterComparer val_1 = new Mapbox.Unity.MeshGeneration.Filters.LayerPropertyIsLessFilterComparer();
            if(val_1 != null)
            {
                    mem[1152921519733356288] = property;
            }
            else
            {
                    mem[16] = property;
            }
            
            .Min = min;
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer HasPropertyIsEqual(string property, double min)
        {
            Mapbox.Unity.MeshGeneration.Filters.LayerPropertyIsEqualFilterComparer val_1 = new Mapbox.Unity.MeshGeneration.Filters.LayerPropertyIsEqualFilterComparer();
            if(val_1 != null)
            {
                    mem[1152921519733484672] = property;
            }
            else
            {
                    mem[16] = property;
            }
            
            .Min = min;
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer PropertyContainsValue(string property, object[] values)
        {
            mem[1152921519733691904] = property;
            .ValueSet = System.Linq.Enumerable.ToList<System.Object>(source:  values);
            return (Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer)new Mapbox.Unity.MeshGeneration.Filters.LayerPropertyContainsFilterComparer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerFilterComparer()
        {
        
        }
    
    }

}
