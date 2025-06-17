using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVoxelVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> _labelObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> _cubeObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject cubePrefab;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel voxel)
        {
            if((this._labelObjects.ContainsKey(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B})) != false)
            {
                    this.UpdateLabel(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, label:  voxel.Prediction);
                return;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.cubePrefab);
            val_2.transform.position = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
            val_2.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._labelObjects.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  this.LabelPoint(worldPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, label:  voxel.Prediction));
            this._cubeObjects.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRemovedEvent(UnityEngine.Vector3 center)
        {
            UnityEngine.Object.Destroy(obj:  this._cubeObjects.Item[new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}]);
            UnityEngine.Object.Destroy(obj:  this._labelObjects.Item[new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}]);
            bool val_3 = this._cubeObjects.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            bool val_4 = this._labelObjects.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateLabel(UnityEngine.Vector3 key, string label)
        {
            this._labelObjects.Item[new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}].GetComponent<UnityEngine.TextMesh>().text = label;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject LabelPoint(UnityEngine.Vector3 worldPoint, string label)
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            UnityEngine.TextMesh val_2 = val_1.AddComponent<UnityEngine.TextMesh>();
            if(val_2 != null)
            {
                    val_2.text = label;
                val_2.fontSize = 15;
            }
            else
            {
                    val_2.text = label;
                val_2.fontSize = 15;
            }
            
            val_2.characterSize = 0.01f;
            val_1.transform.position = new UnityEngine.Vector3() {x = worldPoint.x, y = worldPoint.y, z = worldPoint.z};
            val_1.transform.LookAt(target:  this._camera.transform);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_1.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._camera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
            this._labelObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
            this._cubeObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.add_VoxelLabeledEvent(value:  new IxSemanticVoxelDeliverer.LabelVoxel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVoxelVisualizer::OnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel voxel)));
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.add_RemovedEvent(value:  new IxSemanticVoxelDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVoxelVisualizer::OnRemovedEvent(UnityEngine.Vector3 center)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.remove_VoxelLabeledEvent(value:  new IxSemanticVoxelDeliverer.LabelVoxel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVoxelVisualizer::OnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel voxel)));
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.remove_RemovedEvent(value:  new IxSemanticVoxelDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVoxelVisualizer::OnRemovedEvent(UnityEngine.Vector3 center)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVoxelVisualizer()
        {
        
        }
    
    }

}
