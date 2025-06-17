using UnityEngine;

namespace VLB_Samples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CheckIfInsideBeam : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isInsideBeam;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material m_Material;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Collider m_Collider;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.m_Collider = this.GetComponent<UnityEngine.Collider>();
            UnityEngine.MeshRenderer val_2 = this.GetComponent<UnityEngine.MeshRenderer>();
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
            {
                    return;
            }
            
            this.m_Material = val_2.material;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Material)) == false)
            {
                    return;
            }
            
            if(this.isInsideBeam != false)
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.green;
            }
            else
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.red;
            }
            
            this.m_Material.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixedUpdate()
        {
            this.isInsideBeam = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTriggerStay(UnityEngine.Collider trigger)
        {
            VLB.VolumetricLightBeam val_1 = trigger.GetComponent<VLB.VolumetricLightBeam>();
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
            {
                    return;
            }
            
            bool val_4 = ~(val_1.IsColliderHiddenByDynamicOccluder(collider:  this.m_Collider));
            val_4 = val_4 & 1;
            this.isInsideBeam = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CheckIfInsideBeam()
        {
        
        }
    
    }

}
