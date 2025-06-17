using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVoxelSubvisualizer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> LabelObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> _cubeObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject cubePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<string>> LabelsForObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<string>> TextForObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel voxel)
        {
            if((this.LabelObjects.ContainsKey(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B})) != false)
            {
                    this.UpdateLabel(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, label:  voxel.Prediction);
                return;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.cubePrefab);
            val_2.transform.position = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
            val_2.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.LabelObjects.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  this.LabelPoint(worldPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, label:  voxel.Prediction));
            this._cubeObjects.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  val_2);
            System.Collections.Generic.List<System.String> val_6 = new System.Collections.Generic.List<System.String>();
            val_6.Add(item:  voxel.Prediction);
            this.LabelsForObject.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  val_6);
            System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
            val_7.Add(item:  voxel.Prediction);
            this.TextForObject.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRemovedEvent(UnityEngine.Vector3 center)
        {
            UnityEngine.Object.Destroy(obj:  this._cubeObjects.Item[new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}]);
            UnityEngine.Object.Destroy(obj:  this.LabelObjects.Item[new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}]);
            bool val_3 = this._cubeObjects.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            bool val_4 = this.LabelObjects.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            bool val_5 = this.LabelsForObject.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            bool val_6 = this.TextForObject.Remove(key:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateLabel(UnityEngine.Vector3 key, string label)
        {
            if((this.LabelsForObject.Item[new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}].Contains(item:  label)) != false)
            {
                    return;
            }
            
            UnityEngine.TextMesh val_4 = this.LabelObjects.Item[new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}].GetComponent<UnityEngine.TextMesh>();
            val_4.text = val_4.text + " " + label;
            this.LabelsForObject.Item[new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}].Add(item:  label);
            this.TextForObject.Item[new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}].Add(item:  label);
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
            val_2.richText = true;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateTextMesh(UnityEngine.Vector3 worldCoord, string label, UnityEngine.Color color)
        {
            var val_16;
            var val_17;
            string val_18;
            var val_19;
            System.Collections.Generic.List<System.String> val_3 = this.TextForObject.Item[new UnityEngine.Vector3() {x = worldCoord.x, y = worldCoord.y, z = worldCoord.z}];
            System.Collections.Generic.List<System.String> val_4 = this.LabelsForObject.Item[new UnityEngine.Vector3() {x = worldCoord.x, y = worldCoord.y, z = worldCoord.z}];
            val_16 = 1152921517172219232;
            val_17 = "</color>";
            val_18 = 0;
            goto label_5;
            label_26:
            if((System.String.op_Equality(a:  label, b:  val_4.Item[0])) != false)
            {
                    string[] val_8 = new string[5];
                val_8[0] = "<color=#";
                val_8[1] = UnityEngine.ColorUtility.ToHtmlStringRGBA(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
                val_17 = val_17;
                val_8[2] = ">";
                val_8[3] = label;
                val_8[4] = "</color>";
                val_3.set_Item(index:  0, value:  +val_8);
                val_16 = 1152921517172219232;
            }
            
            val_18 = 1;
            label_5:
            if(val_18 < val_4.Count)
            {
                goto label_26;
            }
            
            System.Text.StringBuilder val_11 = new System.Text.StringBuilder();
            val_19 = 0;
            goto label_27;
            label_33:
            val_18 = val_3.Item[0];
            System.Text.StringBuilder val_13 = val_11.Append(value:  val_18);
            if(val_19 != 0)
            {
                    System.Text.StringBuilder val_14 = val_11.Append(value:  " ");
            }
            
            val_19 = 1;
            label_27:
            if(val_19 < val_3.Count)
            {
                goto label_33;
            }
            
            this.LabelObjects.Item[new UnityEngine.Vector3() {x = worldCoord.x, y = worldCoord.y, z = worldCoord.z}].GetComponent<UnityEngine.TextMesh>().text = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVoxelSubvisualizer(UnityEngine.Camera camera, UnityEngine.GameObject cubePrefab)
        {
            val_1 = new System.Object();
            this._camera = camera;
            this.cubePrefab = val_1;
            this.LabelObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
            this._cubeObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
            this.LabelsForObject = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<System.String>>();
            this.TextForObject = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<System.String>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.add_VoxelLabeledEvent(value:  new IxSemanticVoxelDeliverer.LabelVoxel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVoxelSubvisualizer::OnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel voxel)));
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.add_RemovedEvent(value:  new IxSemanticVoxelDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVoxelSubvisualizer::OnRemovedEvent(UnityEngine.Vector3 center)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
            IxSemanticVoxelDeliverer.LabelVoxel val_1 = new IxSemanticVoxelDeliverer.LabelVoxel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVoxelSubvisualizer::OnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel voxel));
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.remove_VoxelLabeledEvent(value:  val_1);
            val_1 = new IxSemanticVoxelDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVoxelSubvisualizer::OnRemovedEvent(UnityEngine.Vector3 center));
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.remove_RemovedEvent(value:  val_1);
        }
    
    }

}
