using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FilterBase : ILayerFeatureFilterComparer
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string Key { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string get_Key()
        {
            return "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool Try(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FilterBase()
        {
        
        }
    
    }

}
