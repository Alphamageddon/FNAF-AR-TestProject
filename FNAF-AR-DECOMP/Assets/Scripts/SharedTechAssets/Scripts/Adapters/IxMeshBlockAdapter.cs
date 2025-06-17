using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxMeshBlockAdapter : IMeshBlockAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxMeshBlockAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxMeshBlockAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMeshBlockUpdatedEvent(UnityEngine.Vector3 key, UnityEngine.Vector3[] vertices, int[] triangles)
        {
            System.Int32[] val_3;
            IllumixMeshBlock val_1 = null;
            val_3 = triangles;
            val_1 = new IllumixMeshBlock(key:  new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}, vertices:  vertices, triangles:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._accepter.OnMeshBlockAddedEvent(meshBlock:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxMeshBlockAdapter()
        {
        
        }
    
    }

}
