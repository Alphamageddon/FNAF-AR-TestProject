using UnityEngine;

namespace EZCameraShake
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraShakeInstance
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Magnitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Roughness;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 PositionInfluence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RotationInfluence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DeleteOnInactive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float roughMod;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float magnMod;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float fadeOutDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float fadeInDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool sustain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float currentFadeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float tick;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 amt;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ScaleRoughness { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ScaleMagnitude { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float NormalizedFadeTime { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsShaking { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsFadingOut { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsFadingIn { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EZCameraShake.CameraShakeState CurrentState { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraShakeInstance(float magnitude, float roughness, float fadeInTime, float fadeOutTime)
        {
            this.DeleteOnInactive = true;
            this.roughMod = 1f;
            this.magnMod = 1f;
            this.fadeOutDuration = fadeOutTime;
            this.fadeInDuration = fadeInTime;
            this.Magnitude = magnitude;
            this.Roughness = roughness;
            this.sustain = (fadeInTime > 0f) ? 1 : 0;
            this.currentFadeTime = (fadeInTime > 0f) ? 0f : 1f;
            this.tick = (float)UnityEngine.Random.Range(min:  99, max:  100);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraShakeInstance(float magnitude, float roughness)
        {
            this.DeleteOnInactive = true;
            this.roughMod = 1f;
            this.magnMod = 1f;
            this.Magnitude = magnitude;
            this.Roughness = roughness;
            this.sustain = true;
            this.tick = (float)UnityEngine.Random.Range(min:  99, max:  100);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 UpdateShake()
        {
            float val_9;
            bool val_10;
            float val_11;
            float val_12;
            float val_1 = UnityEngine.Mathf.PerlinNoise(x:  this.tick, y:  0f);
            val_1 = val_1 + (-0.5f);
            this.amt = val_1;
            float val_2 = UnityEngine.Mathf.PerlinNoise(x:  0f, y:  this.tick);
            val_2 = val_2 + (-0.5f);
            mem[1152921526249371060] = val_2;
            val_9 = (UnityEngine.Mathf.PerlinNoise(x:  this.tick, y:  this.tick)) + (-0.5f);
            mem[1152921526249371064] = val_9;
            if(this.fadeInDuration <= 0f)
            {
                goto label_7;
            }
            
            if(this.sustain == false)
            {
                goto label_8;
            }
            
            if(this.currentFadeTime >= 0)
            {
                goto label_5;
            }
            
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_4 / this.fadeInDuration;
            val_9 = this.currentFadeTime + val_4;
            this.currentFadeTime = val_9;
            goto label_7;
            label_5:
            val_9 = this.fadeOutDuration;
            if(val_9 <= 0f)
            {
                goto label_7;
            }
            
            this.sustain = false;
            goto label_8;
            label_7:
            val_10 = this.sustain;
            if(val_10 == true)
            {
                goto label_9;
            }
            
            label_8:
            float val_5 = UnityEngine.Time.deltaTime;
            val_10 = this.sustain;
            val_5 = val_5 / this.fadeOutDuration;
            val_9 = this.currentFadeTime - val_5;
            this.currentFadeTime = val_9;
            label_9:
            float val_6 = UnityEngine.Time.deltaTime;
            val_11 = this.roughMod;
            if(val_10 != false)
            {
                    val_12 = val_6 * this.Roughness;
            }
            else
            {
                    val_6 = val_6 * this.Roughness;
                val_12 = val_6 * val_11;
                val_11 = this.currentFadeTime;
            }
            
            val_12 = val_11 * val_12;
            val_12 = this.tick + val_12;
            this.tick = val_12;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.amt, y = V10.16B, z = this.tick}, d:  this.Magnitude);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.magnMod);
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.currentFadeTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartFadeOut(float fadeOutTime)
        {
            if(fadeOutTime == 0f)
            {
                    this.currentFadeTime = 0f;
            }
            
            this.fadeOutDuration = fadeOutTime;
            this.fadeInDuration = 0f;
            this.sustain = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartFadeIn(float fadeInTime)
        {
            if(fadeInTime == 0f)
            {
                    this.currentFadeTime = 1f;
            }
            
            this.fadeInDuration = fadeInTime;
            this.fadeOutDuration = 0f;
            this.sustain = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ScaleRoughness()
        {
            return (float)this.roughMod;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ScaleRoughness(float value)
        {
            this.roughMod = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ScaleMagnitude()
        {
            return (float)this.magnMod;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ScaleMagnitude(float value)
        {
            this.magnMod = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_NormalizedFadeTime()
        {
            return (float)this.currentFadeTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_IsShaking()
        {
            if(this.currentFadeTime > 0f)
            {
                    return true;
            }
            
            return (bool)(this.sustain == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_IsFadingOut()
        {
            if(this.sustain == false)
            {
                    return (bool)(this.currentFadeTime > 0f) ? 1 : 0;
            }
            
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_IsFadingIn()
        {
            if(this.currentFadeTime >= 0)
            {
                    return false;
            }
            
            if(this.sustain == false)
            {
                    return false;
            }
            
            return (bool)(this.fadeInDuration > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EZCameraShake.CameraShakeState get_CurrentState()
        {
            var val_4;
            if((this.currentFadeTime >= 0) || (this.sustain == false))
            {
                goto label_1;
            }
            
            val_4 = 0;
            if(this.fadeInDuration <= 0f)
            {
                goto label_4;
            }
            
            return 0;
            label_1:
            var val_1 = (this.sustain == false) ? 1 : 0;
            if((this.sustain != true) && (this.currentFadeTime > 0f))
            {
                    return 1;
            }
            
            label_4:
            val_4 = val_4 ^ 1;
            val_4 = ((this.currentFadeTime > 0f) ? 1 : 0) | val_4;
            return (EZCameraShake.CameraShakeState)(val_4 == 0) ? (2 + 1) : 2;
        }
    
    }

}
