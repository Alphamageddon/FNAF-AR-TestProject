using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningWhipScript : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AudioClip WhipCrack;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AudioClip WhipCrackThunder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AudioSource audioSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject whipStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject whipEndStrike;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject whipHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject whipSpring;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 prevDrag;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool dragging;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool canWhip;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator WhipForward()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LightningWhipScript.<WhipForward>d__10();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.whipStart = UnityEngine.GameObject.Find(name:  "WhipStart");
            this.whipEndStrike = UnityEngine.GameObject.Find(name:  "WhipEndStrike");
            this.whipHandle = UnityEngine.GameObject.Find(name:  "WhipHandle");
            this.whipSpring = UnityEngine.GameObject.Find(name:  "WhipSpring");
            this.audioSource = this.GetComponent<UnityEngine.AudioSource>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            float val_22;
            float val_23;
            if(this.dragging == false)
            {
                goto label_1;
            }
            
            label_24:
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                goto label_2;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_22 = val_5.x;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = this.prevDrag});
            UnityEngine.Rigidbody2D val_7 = this.whipHandle.GetComponent<UnityEngine.Rigidbody2D>();
            UnityEngine.Vector2 val_8 = val_7.position;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_23 = val_9.x;
            val_7.MovePosition(position:  new UnityEngine.Vector2() {x = val_23, y = val_9.y});
            label_23:
            this.prevDrag = val_5;
            mem[1152921528893660724] = val_5.y;
            goto label_22;
            label_1:
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_12 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_13 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_23 = val_13.z;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_23});
            val_22 = val_14.x;
            UnityEngine.Collider2D val_15 = UnityEngine.Physics2D.OverlapPoint(point:  new UnityEngine.Vector2() {x = val_22, y = val_14.y});
            if((val_15 == 0) || (val_15.gameObject != this.whipHandle))
            {
                goto label_22;
            }
            
            this.dragging = true;
            goto label_23;
            label_10:
            if(this.dragging == true)
            {
                goto label_24;
            }
            
            label_2:
            this.dragging = false;
            label_22:
            if((UnityEngine.Input.GetKeyDown(key:  32)) == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  this.WhipForward());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningWhipScript()
        {
            this.canWhip = true;
        }
    
    }

}
