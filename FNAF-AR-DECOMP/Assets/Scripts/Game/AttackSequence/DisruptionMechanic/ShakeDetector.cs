using UnityEngine;

namespace Game.AttackSequence.DisruptionMechanic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShakeDetector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsShaking>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float AccelerometerUpdateInterval = 0.01666667;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float LowPassKernelWidthInSeconds = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float LowPassFilterFactor = 0.01666667;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float DefaultMagnitude = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float DefaultGraceTime = 0.1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _lowPassValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _magnitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _graceTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _shakeGracePeriod;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsShaking { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsShaking()
        {
            return (bool)this.<IsShaking>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsShaking(bool value)
        {
            this.<IsShaking>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetConfigValues(Game.ItemDefinition.Data.DataDefinitions.DisruptionData settings)
        {
            if(settings != null)
            {
                    this._magnitude = settings.ShakeMagnitude;
            }
            else
            {
                    this._magnitude = 5.142877E-39f;
            }
            
            this._graceTime = settings.ShakeGraceTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearConfigValues()
        {
            this._magnitude = 2f;
            this._graceTime = 7.346868E-41f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            float val_6;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.acceleration;
            val_6 = val_1.x;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this._lowPassValue, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_6, y = val_1.y, z = val_1.z}, t:  0.01666667f);
            this._lowPassValue = val_2;
            mem[1152921525444094824] = val_2.y;
            mem[1152921525444094828] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(val_3.x < this._magnitude)
            {
                    if(this._shakeGracePeriod.Started() == false)
            {
                    return;
            }
            
                if(this._shakeGracePeriod.IsExpired() == false)
            {
                    return;
            }
            
                this.<IsShaking>k__BackingField = false;
                this._shakeGracePeriod.Reset();
                return;
            }
            
            val_6 = this._graceTime;
            this.<IsShaking>k__BackingField = true;
            this._shakeGracePeriod.StartTimer(time:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShakeDetector()
        {
            this._magnitude = 2f;
            this._graceTime = 7.346868E-41f;
            this._shakeGracePeriod = new SimpleTimer();
            UnityEngine.Vector3 val_2 = UnityEngine.Input.acceleration;
            this._lowPassValue = val_2;
            mem[1152921525444227304] = val_2.y;
            mem[1152921525444227308] = val_2.z;
        }
    
    }

}
