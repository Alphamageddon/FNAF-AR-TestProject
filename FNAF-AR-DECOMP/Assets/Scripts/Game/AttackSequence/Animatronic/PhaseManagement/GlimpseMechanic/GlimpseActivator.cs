using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GlimpseActivator : BaseGlimpseActivator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _thisProjectedCameraForward;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _lastProjectedCameraForward;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _signedCameraAngleDelta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _absoluteCameraAngleDelta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldUseDeadZone;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Reset(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            this.Reset(blackboard:  blackboard);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this._thisProjectedCameraForward = val_1;
            mem[1152921525491065924] = val_1.y;
            mem[1152921525491065928] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this._lastProjectedCameraForward = val_2;
            mem[1152921525491065936] = val_2.y;
            mem[1152921525491065940] = val_2.z;
            this._signedCameraAngleDelta = 0f;
            this._absoluteCameraAngleDelta = 0f;
            this.StartCooldown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Update(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard, float remainingAvailableTime)
        {
            float val_24;
            var val_26;
            float val_27;
            val_24 = remainingAvailableTime;
            this._lastProjectedCameraForward = this._thisProjectedCameraForward;
            mem[1152921525491186196] = ???;
            var val_28 = 0;
            val_28 = val_28 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_2 = blackboard.Systems;
            UnityEngine.Vector3 val_3 = val_2.CameraStableTransform.forward;
            val_26 = 1152921504840871936;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, planeNormal:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_27 = val_5.y;
            this._thisProjectedCameraForward = val_5;
            mem[1152921525491186180] = val_27;
            mem[1152921525491186184] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_27, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this._lastProjectedCameraForward, y = val_5.x, z = val_27}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) == true)
            {
                    return;
            }
            
            val_27 = this._lastProjectedCameraForward;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            float val_11 = UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = this._thisProjectedCameraForward, y = V13.16B, z = V12.16B}, to:  new UnityEngine.Vector3() {x = val_27, y = this._lastProjectedCameraForward, z = val_5.x}, axis:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.z, z = val_5.x});
            this._signedCameraAngleDelta = val_11;
            this._absoluteCameraAngleDelta = System.Math.Abs(val_11);
            this.UpdateActiveGlimpseEffect(blackboard:  blackboard);
            this.StartCooldown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GlimpseActivator(Game.ItemDefinition.Data.DataDefinitions.GlimpseData config, Animatronics.Animatronic3d.Model.Effects.CloakSettings cloakConfig, bool shouldUseDeadZone)
        {
            this._shouldUseDeadZone = shouldUseDeadZone;
            this.StartCooldown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCameraMoving()
        {
            return (bool)(this._absoluteCameraAngleDelta > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsTargetInDeadZone(float targetAngle, float signedStaticAngle)
        {
            UnityEngine.Vector3 val_2;
            var val_3;
            float val_2 = signedStaticAngle;
            val_2 = this;
            val_2 = val_2 - targetAngle;
            float val_3 = System.Math.Abs(val_2);
            val_3 = 0;
            return (bool);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetRandomAngle()
        {
            float val_1 = UnityEngine.Random.Range(min:  X20 + 56 + 16, max:  X21 + 56 + 20);
            val_1 = val_1 + this._absoluteCameraAngleDelta;
            val_1 = (this._signedCameraAngleDelta >= 0) ? (-val_1) : (val_1);
            return (float)val_1;
        }
    
    }

}
