using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TriggerZone : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool setIsTrigger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float rangeMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int kMeshColliderNumSides = 8;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh m_Mesh;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_11;
            float val_12;
            var val_13;
            float val_14;
            float val_15;
            VLB.VolumetricLightBeam val_1 = this.GetComponent<VLB.VolumetricLightBeam>();
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
            {
                    return;
            }
            
            UnityEngine.MeshCollider val_4 = VLB.Utils.GetOrAddComponent<UnityEngine.MeshCollider>(self:  this.gameObject);
            if(val_1 != null)
            {
                    val_11 = val_1;
                val_12 = val_1.coneRadiusStart;
                val_13 = this;
                val_14 = mem[val_1 + 80 + 32];
                val_14 = val_1 + 80 + 32;
                val_15 = val_14 * this.rangeMultiplier;
            }
            else
            {
                    val_13 = this;
                val_14 = 9.18355E-41f;
                val_15 = val_14 * this.rangeMultiplier;
                val_11 = 80;
                val_12 = 0f;
            }
            
            UnityEngine.Mesh val_7 = VLB.MeshGenerator.GenerateConeZ_Radius(lengthZ:  val_15, radiusStart:  0f, radiusEnd:  UnityEngine.Mathf.LerpUnclamped(a:  val_12, b:  val_1.coneRadiusEnd, t:  this.rangeMultiplier), numSides:  8, numSegments:  0, cap:  false, doubleSided:  false);
            this.m_Mesh = val_7;
            val_7.hideFlags = VLB.Consts.ProceduralObjectsHideFlags;
            val_4.sharedMesh = this.m_Mesh;
            if(this.setIsTrigger != false)
            {
                    if(val_4 != null)
            {
                    val_4.convex = true;
            }
            else
            {
                    val_4.convex = true;
            }
            
                val_4.isTrigger = true;
            }
            
            UnityEngine.Object.Destroy(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TriggerZone()
        {
            this.setIsTrigger = true;
            this.rangeMultiplier = 1f;
        }
    
    }

}
