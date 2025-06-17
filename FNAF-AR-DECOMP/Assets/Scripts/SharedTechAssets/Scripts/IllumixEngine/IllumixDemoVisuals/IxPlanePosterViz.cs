using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxPlanePosterViz : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject tilePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject imageCanvasPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float minLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, bool> _planeHasSpawnedSquare;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float ComputePlaneInfo(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, out UnityEngine.Vector3 center)
        {
            float val_13;
            float val_14;
            var val_15;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            val_13 = 3.402823E+38f;
            val_14 = -3.402823E+38f;
            val_15 = 0;
            val_16 = val_14;
            val_17 = val_13;
            val_18 = val_14;
            val_19 = val_13;
            goto label_1;
            label_5:
            UnityEngine.Vector3 val_1 = X22.Item[0];
            float val_2 = (val_1.x < 0) ? val_1.x : (val_19);
            float val_3 = (val_1.x > val_18) ? val_1.x : (val_18);
            float val_6 = (val_1.z < 0) ? val_1.z : (val_13);
            float val_7 = (val_1.z > val_14) ? val_1.z : (val_14);
            val_15 = 1;
            label_1:
            if(val_15 < X22.Count)
            {
                goto label_5;
            }
            
            val_1.x = val_3 + val_2;
            float val_13 = 0.5f;
            val_1.y = ((val_1.y > val_16) ? val_1.y : (val_16)) + ((val_1.y < 0) ? val_1.y : (val_17));
            val_1.x = val_1.x * val_13;
            val_1.y = val_1.y * val_13;
            val_13 = (val_7 + val_6) * val_13;
            val_3 = val_3 - val_2;
            center.z = 0f;
            center.x = 0f;
            center.y = 0f;
            float val_11 = val_3 * val_3;
            float val_12 = (val_7 - val_6) * (val_7 - val_6);
            val_12 = val_12 + val_11;
            if(val_11 < _TYPE_MAX_)
            {
                    return (float)val_12;
            }
            
            return (float)val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            var val_3;
            var val_4;
            int val_5;
            if((this.ComputePlaneInfo(plane:  plane, center: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) > this.minLength)
            {
                    this.AttachTile(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, normal:  new UnityEngine.Vector3());
                val_3 = 1152921518583513568;
                val_4 = 1;
                val_5 = plane;
            }
            else
            {
                    val_3 = 1152921518583513568;
                val_5 = plane;
                val_4 = 0;
            }
            
            this._planeHasSpawnedSquare.set_Item(key:  val_5, value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttachTile(UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.imageCanvasPrefab);
            UnityEngine.Canvas val_2 = this.imageCanvasPrefab.GetComponent<UnityEngine.Canvas>();
            val_1.transform.position = new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            val_1.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            this.UpdateBoundary(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            bool val_1 = this._planeHasSpawnedSquare.Item[W22];
            if(val_1 == true)
            {
                    return;
            }
            
            if((val_1.ComputePlaneInfo(plane:  plane = plane, center: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) <= this.minLength)
            {
                    return;
            }
            
            this.AttachTile(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, normal:  new UnityEngine.Vector3());
            this._planeHasSpawnedSquare.set_Item(key:  plane, value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._planeHasSpawnedSquare = new System.Collections.Generic.Dictionary<System.Int32, System.Boolean>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneAddedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxPlanePosterViz::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxPlanePosterViz::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxPlanePosterViz::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneAddedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxPlanePosterViz::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxPlanePosterViz::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxPlanePosterViz::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxPlanePosterViz()
        {
            this.minLength = 0.3f;
            this.showPlane = true;
        }
    
    }

}
