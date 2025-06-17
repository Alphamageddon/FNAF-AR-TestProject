using UnityEngine;

namespace EZCameraShake
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraShaker : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 testPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform target;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform targetBackground;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShaker Instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, EZCameraShake.CameraShaker> instanceList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 DefaultPosInfluence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 DefaultRotInfluence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RestPositionOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RestRotationOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RawCameraPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Quaternion RawCameraRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RawCameraForward;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 posAddShake;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 rotAddShake;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<EZCameraShake.CameraShakeInstance> cameraShakeInstances;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<EZCameraShake.CameraShakeInstance> ShakeInstances { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            null = null;
            EZCameraShake.CameraShaker.Instance = this;
            EZCameraShake.CameraShaker.instanceList.Add(key:  this.gameObject.name, value:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_22;
            System.Collections.Generic.List<EZCameraShake.CameraShakeInstance> val_23;
            UnityEngine.Transform val_1 = this.targetBackground.parent;
            if(val_1 != null)
            {
                    UnityEngine.Vector3 val_2 = val_1.position;
                this.RawCameraPosition = val_2;
                mem[1152921526251742156] = val_2.y;
                mem[1152921526251742160] = val_2.z;
            }
            else
            {
                    UnityEngine.Vector3 val_3 = 0.position;
                this.RawCameraPosition = val_3;
                mem[1152921526251742156] = val_3.y;
                mem[1152921526251742160] = val_3.z;
            }
            
            UnityEngine.Quaternion val_4 = val_1.rotation;
            this.RawCameraRotation = val_4;
            mem[1152921526251742168] = val_4.y;
            mem[1152921526251742172] = val_4.z;
            mem[1152921526251742176] = val_4.w;
            UnityEngine.Vector3 val_5 = val_1.forward;
            this.RawCameraForward = val_5;
            mem[1152921526251742184] = val_5.y;
            mem[1152921526251742188] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.posAddShake = val_6;
            mem[1152921526251742196] = val_6.y;
            mem[1152921526251742200] = val_6.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.rotAddShake = val_7;
            mem[1152921526251742208] = val_7.y;
            mem[1152921526251742212] = val_7.z;
            val_22 = 0;
            goto label_7;
            label_24:
            val_23 = this.cameraShakeInstances;
            if(val_22 >= val_23.Count)
            {
                goto label_9;
            }
            
            EZCameraShake.CameraShakeInstance val_9 = this.cameraShakeInstances.Item[0];
            if((val_9.CurrentState == 3) && (val_9.DeleteOnInactive != false))
            {
                    this.cameraShakeInstances.RemoveAt(index:  0);
            }
            else
            {
                    if(val_9.CurrentState != 3)
            {
                    UnityEngine.Vector3 val_12 = val_9.UpdateShake();
                float val_19 = val_12.y;
                val_19 = val_19 * val_12.y;
                float val_21 = val_19;
                float val_22 = val_12.z * val_12.z;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.posAddShake, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_12.x * val_9.PositionInfluence, y = val_21, z = val_22});
                this.posAddShake = val_15;
                mem[1152921526251742196] = val_15.y;
                mem[1152921526251742200] = val_15.z;
                UnityEngine.Vector3 val_16 = val_9.UpdateShake();
                UnityEngine.Vector3 val_20 = val_9.RotationInfluence;
                val_20 = val_16.x * val_20;
                val_21 = val_16.y * val_21;
                val_22 = val_16.z * val_22;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.rotAddShake, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22});
                this.rotAddShake = val_17;
                mem[1152921526251742208] = val_17.y;
                mem[1152921526251742212] = val_17.z;
            }
            
            }
            
            val_22 = val_22 + 1;
            label_7:
            val_23 = this.cameraShakeInstances;
            if(val_22 < val_23.Count)
            {
                goto label_24;
            }
            
            label_9:
            this.target.localPosition = new UnityEngine.Vector3() {x = this.posAddShake, y = V9.16B, z = V10.16B};
            this.target.localEulerAngles = new UnityEngine.Vector3() {x = this.rotAddShake, y = V9.16B, z = V10.16B};
            this.targetBackground.localPosition = new UnityEngine.Vector3() {x = this.posAddShake, y = V9.16B, z = V10.16B};
            this.targetBackground.localEulerAngles = new UnityEngine.Vector3() {x = this.rotAddShake, y = V9.16B, z = V10.16B};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static EZCameraShake.CameraShaker GetInstance(string name)
        {
            string val_4;
            var val_5;
            var val_6;
            val_4 = name;
            EZCameraShake.CameraShaker val_1 = 0;
            val_5 = null;
            val_5 = null;
            if((EZCameraShake.CameraShaker.instanceList.TryGetValue(key:  val_4, value: out  val_1)) != false)
            {
                    val_6 = val_1;
                return (EZCameraShake.CameraShaker)val_6;
            }
            
            val_4 = "CameraShake " + val_4 + " not found!"(" not found!");
            UnityEngine.Debug.LogError(message:  val_4);
            val_6 = 0;
            return (EZCameraShake.CameraShaker)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EZCameraShake.CameraShakeInstance Shake(EZCameraShake.CameraShakeInstance shake)
        {
            this.cameraShakeInstances.Add(item:  shake);
            return (EZCameraShake.CameraShakeInstance)shake;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EZCameraShake.CameraShakeInstance ShakeOnce(float magnitude, float roughness, float fadeInTime, float fadeOutTime)
        {
            EZCameraShake.CameraShakeInstance val_1 = new EZCameraShake.CameraShakeInstance(magnitude:  magnitude, roughness:  roughness, fadeInTime:  fadeInTime, fadeOutTime:  fadeOutTime);
            .PositionInfluence = this.DefaultPosInfluence;
            mem[1152921526252206524] = ???;
            mem[1152921526252206528] = ???;
            .RotationInfluence = this.DefaultRotInfluence;
            mem[1152921526252206536] = ???;
            mem[1152921526252206540] = ???;
            this.cameraShakeInstances.Add(item:  val_1);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EZCameraShake.CameraShakeInstance ShakeOnce(float magnitude, float roughness, float fadeInTime, float fadeOutTime, UnityEngine.Vector3 posInfluence, UnityEngine.Vector3 rotInfluence)
        {
            var val_1;
            EZCameraShake.CameraShakeInstance val_2 = new EZCameraShake.CameraShakeInstance(magnitude:  magnitude, roughness:  roughness, fadeInTime:  fadeInTime, fadeOutTime:  fadeOutTime);
            if(val_2 != null)
            {
                    .PositionInfluence = posInfluence;
                mem[1152921526252334908] = posInfluence.y;
                mem[1152921526252334912] = posInfluence.z;
            }
            else
            {
                    mem[24] = posInfluence.x;
                mem[1152921526252334908] = posInfluence.y;
                mem[32] = posInfluence.z;
            }
            
            .RotationInfluence = rotInfluence;
            mem[1152921526252334920] = val_1;
            mem[1152921526252334924] = rotInfluence.y;
            this.cameraShakeInstances.Add(item:  val_2);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EZCameraShake.CameraShakeInstance StartShake(float magnitude, float roughness, float fadeInTime)
        {
            EZCameraShake.CameraShakeInstance val_1 = new EZCameraShake.CameraShakeInstance(magnitude:  magnitude, roughness:  roughness);
            .PositionInfluence = this.DefaultPosInfluence;
            mem[1152921526252463292] = ???;
            mem[1152921526252463296] = ???;
            if(val_1 != null)
            {
                    .RotationInfluence = this.DefaultRotInfluence;
                mem[1152921526252463304] = ???;
                mem[1152921526252463308] = this.DefaultPosInfluence;
            }
            else
            {
                    .RotationInfluence = this.DefaultRotInfluence;
                mem[40] = ???;
                mem[1152921526252463308] = this.DefaultPosInfluence;
            }
            
            if(fadeInTime == 0f)
            {
                    .currentFadeTime = 1f;
            }
            
            .fadeInDuration = fadeInTime;
            .fadeOutDuration = 0f;
            .sustain = true;
            this.cameraShakeInstances.Add(item:  val_1);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EZCameraShake.CameraShakeInstance StartShake(float magnitude, float roughness, float fadeInTime, UnityEngine.Vector3 posInfluence, UnityEngine.Vector3 rotInfluence)
        {
            var val_1;
            EZCameraShake.CameraShakeInstance val_2 = new EZCameraShake.CameraShakeInstance(magnitude:  magnitude, roughness:  roughness);
            if(val_2 != null)
            {
                    .PositionInfluence = posInfluence;
                mem[1152921526252591676] = posInfluence.y;
                mem[1152921526252591680] = posInfluence.z;
            }
            else
            {
                    mem[24] = posInfluence.x;
                mem[1152921526252591676] = posInfluence.y;
                mem[32] = posInfluence.z;
            }
            
            .RotationInfluence = rotInfluence;
            mem[1152921526252591688] = val_1;
            mem[1152921526252591692] = rotInfluence.y;
            if(fadeInTime == 0f)
            {
                    .currentFadeTime = 1f;
            }
            
            .fadeInDuration = fadeInTime;
            .fadeOutDuration = 0f;
            .sustain = true;
            this.cameraShakeInstances.Add(item:  val_2);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<EZCameraShake.CameraShakeInstance> get_ShakeInstances()
        {
            return (System.Collections.Generic.List<EZCameraShake.CameraShakeInstance>)new System.Collections.Generic.List<EZCameraShake.CameraShakeInstance>(collection:  this.cameraShakeInstances);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            null = null;
            bool val_3 = EZCameraShake.CameraShaker.instanceList.Remove(key:  this.gameObject.name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraShaker()
        {
            this.DefaultPosInfluence = 0;
            mem[1152921526252943840] = 0;
            this.DefaultRotInfluence = 0;
            mem[1152921526252943852] = 0;
            this.RestPositionOffset = 0;
            mem[1152921526252943864] = 0;
            this.RestRotationOffset = 0;
            mem[1152921526252943876] = 0;
            this.cameraShakeInstances = new System.Collections.Generic.List<EZCameraShake.CameraShakeInstance>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static CameraShaker()
        {
            EZCameraShake.CameraShaker.instanceList = new System.Collections.Generic.Dictionary<System.String, EZCameraShake.CameraShaker>();
        }
    
    }

}
