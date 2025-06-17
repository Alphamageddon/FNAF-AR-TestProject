using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IReplaceable
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria> Criteria { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria> get_Criteria(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_Criteria(System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria> value); // 0
    
    }

}
