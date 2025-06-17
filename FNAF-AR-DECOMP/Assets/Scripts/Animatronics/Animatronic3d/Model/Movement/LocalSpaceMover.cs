using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Movement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocalSpaceMover
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnStartedMoving;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnStoppedMoving;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _animatronicPrefabTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _moveDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _movementUnitsPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _rotateAroundOrigin;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMoving { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnStartedMoving(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStartedMoving, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartedMoving != 1152921525078772560);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnStartedMoving(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStartedMoving, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartedMoving != 1152921525078909136);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnStoppedMoving(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStoppedMoving, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStoppedMoving != 1152921525079045720);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnStoppedMoving(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStoppedMoving, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStoppedMoving != 1152921525079182296);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsMoving()
        {
            return (bool)(this._movementUnitsPerSecond != 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetDistanceFromLocalOrigin()
        {
            UnityEngine.Vector3 val_1 = this._animatronicPrefabTransform.localPosition;
            return (float)val_1.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopMovement()
        {
            if((this._movementUnitsPerSecond != 0f) && (this.OnStoppedMoving != null))
            {
                    this.OnStoppedMoving.Invoke();
            }
            
            this._moveDuration.Reset();
            this._movementUnitsPerSecond = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveInCircleAroundOrigin(float degreesPerSecond, float duration)
        {
            this._rotateAroundOrigin = true;
            this.StartMovement(unitsPerSecond:  degreesPerSecond, duration:  duration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveInLineTowardOrigin(float unitsPerSecond, float duration)
        {
            this._rotateAroundOrigin = false;
            this.StartMovement(unitsPerSecond:  unitsPerSecond, duration:  duration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._movementUnitsPerSecond == 0f)
            {
                    return;
            }
            
            if(this._moveDuration.Started() != false)
            {
                    if(this._moveDuration.IsExpired() != false)
            {
                    this.StopMovement();
                return;
            }
            
            }
            
            if(this._rotateAroundOrigin != false)
            {
                    this.RotateAroundOrigin();
                return;
            }
            
            this.MoveTowardOrigin();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartMovement(float unitsPerSecond, float duration)
        {
            this._movementUnitsPerSecond = unitsPerSecond;
            if(duration < 0f)
            {
                    this._moveDuration.Reset();
            }
            else
            {
                    this._moveDuration.StartTimer(time:  duration);
            }
            
            if(this.OnStartedMoving == null)
            {
                    return;
            }
            
            this.OnStartedMoving.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RotateAroundOrigin()
        {
            UnityEngine.Vector3 val_2 = this._animatronicPrefabTransform.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.AngleAxis(angle:  this._movementUnitsPerSecond * UnityEngine.Time.deltaTime, axis:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this._animatronicPrefabTransform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this._animatronicPrefabTransform.forward = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MoveTowardOrigin()
        {
            UnityEngine.Transform val_9;
            float val_10;
            float val_11;
            val_9 = this;
            float val_9 = this._movementUnitsPerSecond;
            val_9 = val_9 * UnityEngine.Time.deltaTime;
            if(val_9 < this.GetDistanceFromLocalOrigin())
            {
                    UnityEngine.Vector3 val_3 = this._animatronicPrefabTransform.localPosition;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_9);
                this._animatronicPrefabTransform.Translate(translation:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, relativeTo:  0);
                val_9 = this._animatronicPrefabTransform;
                UnityEngine.Vector3 val_6 = val_9.localPosition;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_10 = val_7.x;
                val_11 = val_7.z;
                val_9.forward = new UnityEngine.Vector3() {x = val_10, y = val_7.y, z = val_11};
                return;
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_10 = val_8.x;
            val_11 = val_8.z;
            this._animatronicPrefabTransform.localPosition = new UnityEngine.Vector3() {x = val_10, y = val_8.y, z = val_11};
            this.StopMovement();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocalSpaceMover(UnityEngine.Transform animatronicPrefabTransform)
        {
            this._moveDuration = new SimpleTimer();
            this._animatronicPrefabTransform = animatronicPrefabTransform;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._animatronicPrefabTransform = 0;
        }
    
    }

}
