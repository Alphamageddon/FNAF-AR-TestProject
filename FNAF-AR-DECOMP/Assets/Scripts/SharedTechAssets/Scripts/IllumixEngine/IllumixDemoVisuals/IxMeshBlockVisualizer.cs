using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxMeshBlockVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject meshPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> meshObjects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddMeshBlock(IllumixMeshBlock meshBlock)
        {
            if((this.meshObjects.ContainsKey(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B})) == false)
            {
                goto label_3;
            }
            
            UnityEngine.GameObject val_2 = this.meshObjects.Item[new UnityEngine.Vector3() {x = V10.16B, y = V9.16B, z = V8.16B}];
            SimpleMesh val_3 = val_2.GetComponent<SimpleMesh>();
            if(meshBlock.triangles.Length == 0)
            {
                goto label_7;
            }
            
            val_3.UpdateMesh(vertices:  meshBlock.vertices, triangles:  meshBlock.triangles);
            return;
            label_3:
            this.meshObjects.set_Item(key:  new UnityEngine.Vector3() {x = V10.16B, y = V9.16B, z = V8.16B}, value:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.meshPrefab));
            this.meshObjects.Item[new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}].GetComponent<SimpleMesh>().InitializeMesh(vertices:  meshBlock.vertices, triangles:  meshBlock.triangles);
            return;
            label_7:
            val_3.ClearMesh();
            bool val_7 = this.meshObjects.Remove(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
            UnityEngine.Object.Destroy(obj:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.meshObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.add_SurfaceMeshBlockUpdatedEvent(value:  new IxMeshBlockDeliverer.SurfaceMeshBlockUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxMeshBlockVisualizer::AddMeshBlock(IllumixMeshBlock meshBlock)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.remove_SurfaceMeshBlockUpdatedEvent(value:  new IxMeshBlockDeliverer.SurfaceMeshBlockUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxMeshBlockVisualizer::AddMeshBlock(IllumixMeshBlock meshBlock)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxMeshBlockVisualizer()
        {
        
        }
    
    }

}
