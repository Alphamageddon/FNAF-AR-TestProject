using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxDirectedPointVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> directPointObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject directedPointPrefab;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddDirectedPoint(IllumixDirectedPoint dp)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.directedPointPrefab);
            val_1.transform.position = new UnityEngine.Vector3() {x = dp.position, y = V9.16B, z = V10.16B};
            val_1.GetComponent<DirectedPoint>().Initialize(point:  new UnityEngine.Vector3() {x = dp.position, y = V12.16B, z = V11.16B}, direction:  new UnityEngine.Vector3() {x = dp.direction, y = V9.16B, z = dp.position});
            this.directPointObjects.set_Item(key:  new UnityEngine.Vector3() {x = dp.position, y = V9.16B, z = dp.direction}, value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateDirectedPoint(IllumixDirectedPoint old_dp, IllumixDirectedPoint new_dp)
        {
            this.directPointObjects.Item[new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}].transform.position = new UnityEngine.Vector3() {x = new_dp.position, y = V9.16B, z = V10.16B};
            this.directPointObjects.Item[new UnityEngine.Vector3() {x = new_dp.position, y = V9.16B, z = V10.16B}].GetComponent<DirectedPoint>().UpdateDirection(direction:  new UnityEngine.Vector3() {x = new_dp.direction, y = V9.16B, z = V10.16B});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveDirectedPoint(IllumixDirectedPoint dp)
        {
            UnityEngine.GameObject val_1 = this.directPointObjects.Item[new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}];
            if(val_1 != null)
            {
                    val_1.SetActive(value:  false);
            }
            else
            {
                    val_1.SetActive(value:  false);
            }
            
            val_1.GetComponent<DirectedPoint>().Clear();
            bool val_3 = this.directPointObjects.Remove(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
            UnityEngine.Object.Destroy(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.directPointObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.add_AddedEvent(value:  new IxDirectedPointDeliverer.DirectedPointAdd(object:  this, method:  public System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxDirectedPointVisualizer::AddDirectedPoint(IllumixDirectedPoint dp)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.remove_AddedEvent(value:  new IxDirectedPointDeliverer.DirectedPointAdd(object:  this, method:  public System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxDirectedPointVisualizer::AddDirectedPoint(IllumixDirectedPoint dp)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxDirectedPointVisualizer()
        {
        
        }
    
    }

}
