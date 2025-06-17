using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AstronautMouseController : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject character;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float characterSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Animator characterAnimator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.AstronautDirections directions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform startPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform endPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject rayPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _movementEndPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LayerMask layerMask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Ray ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RaycastHit hit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LayerMask raycastPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float clicktime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool moving;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool characterDisabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> futurePositions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool interruption;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 nextPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 prevPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera cam;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 previousPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 deltaPos;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.characterAnimator = this.GetComponentInChildren<UnityEngine.Animator>();
            if(UnityEngine.Application.isEditor != false)
            {
                    return;
            }
            
            this.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            float val_7;
            UnityEngine.Ray val_8;
            object val_15;
            float val_16;
            val_15 = this;
            if(this.characterDisabled == true)
            {
                    return;
            }
            
            this.CamControl();
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
            {
                    this.clicktime = UnityEngine.Time.time;
            }
            
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
            {
                    return;
            }
            
            float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - this.clicktime;
            if(val_4 >= 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            val_16 = val_5.x;
            UnityEngine.Ray val_6 = this.cam.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_16, y = val_5.y, z = val_5.z});
            mem[1152921519842110068] = val_7;
            this.ray = val_8;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, m_Direction = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.hit, y = this.hit, z = this.hit}, m_Normal = new UnityEngine.Vector3() {x = this.hit, y = this.hit, z = this.hit}, m_FaceID = this.hit, m_Distance = this.hit, m_UV = new UnityEngine.Vector2() {x = this.hit, y = this.hit}, m_Collider = this.hit}, maxDistance:  Infinityf, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.layerMask}))) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_12 = this.transform.localPosition;
            this.startPoint.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_16 = val_12.x;
            this.endPoint.position = new UnityEngine.Vector3() {x = val_16, y = val_12.y, z = val_12.z};
            this.MovementEndpointControl(pos:  new UnityEngine.Vector3() {x = val_16, y = val_12.y, z = val_12.z}, active:  true);
            val_15 = this.map;
            this.directions.Query(vecs:  new System.Action<System.Collections.Generic.List<UnityEngine.Vector3>>(object:  this, method:  System.Void Mapbox.Examples.AstronautMouseController::GetPositions(System.Collections.Generic.List<UnityEngine.Vector3> vecs)), start:  this.startPoint, end:  this.endPoint, map:  val_15);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetPositions(System.Collections.Generic.List<UnityEngine.Vector3> vecs)
        {
            this.futurePositions = vecs;
            if(vecs == null)
            {
                goto label_0;
            }
            
            if(this.moving == false)
            {
                goto label_2;
            }
            
            this.interruption = true;
            return;
            label_0:
            if(this.moving != false)
            {
                    return;
            }
            
            label_2:
            this.interruption = false;
            this.MoveToNextPlace();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MoveToNextPlace()
        {
            if(this.futurePositions.Count >= 1)
            {
                    UnityEngine.Vector3 val_2 = this.futurePositions.Item[0];
                this.nextPos = val_2;
                mem[1152921519842413064] = val_2.y;
                mem[1152921519842413068] = val_2.z;
                bool val_3 = this.futurePositions.Remove(item:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this.moving = true;
                this.characterAnimator.SetBool(name:  "IsWalking", value:  true);
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.MoveTo());
                return;
            }
            
            if(this.futurePositions.Count > 0)
            {
                    return;
            }
            
            this.moving = false;
            this.characterAnimator.SetBool(name:  "IsWalking", value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator MoveTo()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AstronautMouseController.<MoveTo>d__24();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float CalculateTime()
        {
            float val_1 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.prevPos, y = V12.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.nextPos, y = V9.16B, z = V8.16B});
            val_1 = val_1 / this.characterSpeed;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator LookAtNextPos()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AstronautMouseController.<LookAtNextPos>d__26();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CamControl()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.previousPos, y = V11.16B, z = V10.16B});
            this.deltaPos = val_3;
            mem[1152921519842938940] = val_3.z;
            mem[1152921519842938936] = 0;
            UnityEngine.Vector3 val_6 = this.cam.transform.position;
            UnityEngine.Vector3 val_8 = this.cam.transform.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.deltaPos, y = V11.16B, z = V10.16B});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, t:  UnityEngine.Time.time);
            this.cam.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Vector3 val_13 = this.transform.position;
            this.previousPos = val_13;
            mem[1152921519842938924] = val_13.y;
            mem[1152921519842938928] = val_13.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DisableCharacter()
        {
            this.moving = true;
            this.characterDisabled = true;
            this.StopAllCoroutines();
            this.character.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EnableCharacter()
        {
            this.characterDisabled = false;
            this.character.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LayerChangeOn()
        {
            UnityEngine.Debug.Log(message:  "OPEN");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LayerChangeOff()
        {
            UnityEngine.Debug.Log(message:  "CLOSE");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MovementEndpointControl(UnityEngine.Vector3 pos, bool active)
        {
            this._movementEndPoint.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._movementEndPoint.gameObject.SetActive(value:  active);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AstronautMouseController()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.previousPos = val_1;
            mem[1152921519843684812] = val_1.y;
            mem[1152921519843684816] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.deltaPos = val_2;
            mem[1152921519843684824] = val_2.y;
            mem[1152921519843684828] = val_2.z;
        }
    
    }

}
