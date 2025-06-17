using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CharacterMovement : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material[] Materials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Target;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Animator CharacterAnimator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.AstronautMouseController _controller;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._controller = this.GetComponent<Mapbox.Examples.AstronautMouseController>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_14;
            UnityEngine.Transform val_15;
            float val_16;
            float val_17;
            UnityEngine.Animator val_18;
            string val_19;
            var val_20;
            if(this._controller.enabled != false)
            {
                    return;
            }
            
            val_14 = 0;
            goto label_3;
            label_10:
            val_15 = this.transform;
            UnityEngine.Vector3 val_3 = val_15.position;
            UnityEngine.Vector4 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.Materials[0].SetVector(name:  "_CharacterPosition", value:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            val_14 = 1;
            label_3:
            if(val_14 < this.Materials.Length)
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_6 = this.transform.position;
            val_16 = val_6.x;
            val_17 = val_6.z;
            UnityEngine.Vector3 val_7 = this.Target.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_16, y = val_6.y, z = val_17}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) > 0.1f)
            {
                    val_15 = this.Target;
                UnityEngine.Vector3 val_10 = val_15.position;
                this.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  this.Speed);
                val_16 = val_13.x;
                val_17 = val_13.z;
                this.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_16, y = val_13.y, z = val_17});
                val_18 = this.CharacterAnimator;
                val_19 = "IsWalking";
                val_20 = 1;
            }
            else
            {
                    val_18 = this.CharacterAnimator;
                val_19 = "IsWalking";
                val_20 = 0;
            }
            
            val_18.SetBool(name:  val_19, value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CharacterMovement()
        {
        
        }
    
    }

}
