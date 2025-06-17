using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Movement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Mover
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _cameraStableTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _animatronicPrefabTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _rootBone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _transformBone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Animation.AnimatorDispatcher _animatorDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.Animatronic3d.Model.Movement.LocalSpaceMover _localSpaceMover;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.Animatronic3d.Model.Movement.TransformOverrider _transformOverrider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isWalking;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _workshopRotationSpeed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetRootBonePosition()
        {
            if(this._rootBone != null)
            {
                    return this._rootBone.position;
            }
            
            return this._rootBone.position;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetPosition()
        {
            if(this._animatronicPrefabTransform != null)
            {
                    return this._animatronicPrefabTransform.localPosition;
            }
            
            return this._animatronicPrefabTransform.localPosition;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetForward()
        {
            if(this._animatronicPrefabTransform != null)
            {
                    return this._animatronicPrefabTransform.forward;
            }
            
            return this._animatronicPrefabTransform.forward;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetTransformOverrideMode(Animatronics.Animatronic3d.Model.Movement.TransformOverrider.Mode mode)
        {
            this._transformOverrider._offsetMode = mode;
            this._transformOverrider.UpdateOverrides();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetAbsoluteAngleBetweenPositionAndCamera(UnityEngine.Vector3 position)
        {
            return (float)System.Math.Abs(this.GetSignedAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetAbsoluteAngleFromCamera()
        {
            UnityEngine.Vector3 val_1 = this.GetRootBonePosition();
            return this.GetAbsoluteAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetSignedAngleBetweenPositionAndCamera(UnityEngine.Vector3 position)
        {
            float val_7;
            float val_8;
            UnityEngine.Transform val_9;
            val_7 = position.z;
            val_8 = position.x;
            val_9 = this;
            if(this._cameraStableTransform == 0)
            {
                    return (float)UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = val_7, y = val_4.y, z = val_8}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z, z = val_4.x});
            }
            
            UnityEngine.Vector3 val_2 = this._cameraStableTransform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8, y = position.y, z = val_7}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_9 = this._cameraStableTransform;
            UnityEngine.Vector3 val_4 = val_9.forward;
            val_7 = val_4.x;
            val_8 = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            return (float)UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = val_7, y = val_4.y, z = val_8}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z, z = val_4.x});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetSignedAngleFromCamera()
        {
            UnityEngine.Vector3 val_1 = this.GetRootBonePosition();
            return this.GetSignedAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetDistanceFromCamera()
        {
            if(this._cameraStableTransform == 0)
            {
                    return 0f;
            }
            
            if(this._localSpaceMover != null)
            {
                    return this._localSpaceMover.GetDistanceFromLocalOrigin();
            }
            
            return this._localSpaceMover.GetDistanceFromLocalOrigin();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera)
        {
            float val_16;
            UnityEngine.Transform val_17;
            float val_18;
            float val_19;
            val_16 = distanceFromCamera;
            val_17 = this._cameraStableTransform;
            if(val_17 == 0)
            {
                    ConsoleLogger.LogError(className:  "Animatronic3D", functionName:  "Teleport", logString:  "Camera transform is null. Cannot teleport");
                return;
            }
            
            UnityEngine.Vector3 val_2 = this._cameraStableTransform.forward;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, planeNormal:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.AngleAxis(angle:  angleFromCamera, axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_17 = this._animatronicPrefabTransform;
            UnityEngine.Vector3 val_8 = this._cameraStableTransform.position;
            val_18 = val_8.x;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_16);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_16 = val_10.x;
            val_19 = val_10.z;
            val_17.position = new UnityEngine.Vector3() {x = val_16, y = val_10.y, z = val_19};
            if(faceCamera != false)
            {
                    UnityEngine.Vector3 val_11 = this._cameraStableTransform.position;
                UnityEngine.Vector3 val_12 = this._animatronicPrefabTransform.position;
                val_18 = val_12.y;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_18, z = val_12.z});
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, planeNormal:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                val_16 = val_15.x;
                val_19 = val_15.z;
                this._animatronicPrefabTransform.forward = new UnityEngine.Vector3() {x = val_16, y = val_15.y, z = val_19};
            }
            
            this.VerifyAnimatronicPrefabUpVectorMatchesWorld(callingFunction:  "Teleport");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TeleportToLocalPosition(UnityEngine.Vector3 position, UnityEngine.Vector3 forward)
        {
            this._animatronicPrefabTransform.localPosition = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            this._animatronicPrefabTransform.forward = new UnityEngine.Vector3() {x = forward.x, y = forward.y, z = forward.z};
            this.VerifyAnimatronicPrefabUpVectorMatchesWorld(callingFunction:  "TeleportToLocalPosition");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TeleportInFrontOfCamera(float distanceFromCamera)
        {
            if(this._cameraStableTransform == 0)
            {
                    ConsoleLogger.LogError(className:  "Animatronic3D", functionName:  "Teleport", logString:  "Camera transform is null. Cannot teleport");
                return;
            }
            
            this.Teleport(angleFromCamera:  0f, distanceFromCamera:  distanceFromCamera, faceCamera:  true);
            this.VerifyAnimatronicPrefabUpVectorMatchesWorld(callingFunction:  "TeleportInFrontOfCamera");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TeleportAtCurrentAngle(float distanceFromCamera)
        {
            float val_5 = distanceFromCamera;
            if(this._cameraStableTransform == 0)
            {
                    ConsoleLogger.LogError(className:  "Animatronic3D", functionName:  "Teleport", logString:  "Camera transform is null. Cannot teleport");
                return;
            }
            
            UnityEngine.Vector3 val_2 = this._animatronicPrefabTransform.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_5 = distanceFromCamera);
            this._animatronicPrefabTransform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_5 = val_4.x;
            this._animatronicPrefabTransform.forward = new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_4.z};
            this.VerifyAnimatronicPrefabUpVectorMatchesWorld(callingFunction:  "TeleportAtCurrentAngle");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InvertFacing()
        {
            UnityEngine.Vector3 val_1 = this._animatronicPrefabTransform.forward;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this._animatronicPrefabTransform.forward = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RotateFacingInWorkshop(UnityEngine.Vector3 mPrevPos, UnityEngine.Vector3 mCurrPos)
        {
            this._transformBone.Rotate(xAngle:  0f, yAngle:  -((mCurrPos.x - mPrevPos.x) * this._workshopRotationSpeed), zAngle:  0f, relativeTo:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMoving()
        {
            return (bool)(this._localSpaceMover._movementUnitsPerSecond != 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopMovement()
        {
            this._localSpaceMover.StopMovement();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveInCircleAroundCamera(float degreesPerSecond, bool isWalking, float duration = -1)
        {
            this._isWalking = isWalking;
            this._localSpaceMover._rotateAroundOrigin = true;
            this._localSpaceMover.StartMovement(unitsPerSecond:  degreesPerSecond, duration:  duration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveInLineTowardCamera(float unitsPerSecond, bool isWalking, float duration = -1)
        {
            this._isWalking = isWalking;
            this._localSpaceMover._rotateAroundOrigin = false;
            this._localSpaceMover.StartMovement(unitsPerSecond:  unitsPerSecond, duration:  duration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this._localSpaceMover.Update();
            this.VerifyAnimatronicPrefabUpVectorMatchesWorld(callingFunction:  "Update");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LateUpdate()
        {
            if(this._transformOverrider != null)
            {
                    this._transformOverrider.LateUpdate();
            }
            
            this.VerifyAnimatronicPrefabUpVectorMatchesWorld(callingFunction:  "LateUpdate");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VerifyAnimatronicPrefabUpVectorMatchesWorld(string callingFunction)
        {
            if(this._transformOverrider._shouldFollowCameraRotation == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this._animatronicPrefabTransform.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            float val_3 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_3 = 1f - val_3;
            if(val_3 <= 0.0001f)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this._animatronicPrefabTransform.up;
            ConsoleLogger.LogError(className:  "Mover", functionName:  callingFunction, logString:  System.String.Format(format:  "The animatronic is not upright: {0}", arg0:  val_4));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartedMoving()
        {
            this._animatorDispatcher.SetAnimationBool(animationBool:  3, value:  (this._isWalking == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StoppedMoving()
        {
            this._animatorDispatcher.SetAnimationBool(animationBool:  3, value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mover(UnityEngine.Transform cameraStableTransform, UnityEngine.Transform animatronic3DTransform, Animatronics.Animatronic3d.Model.Animation.AnimatorDispatcher animatorDispatcher, Animatronics.Animatronic3d.Model.AnimatronicModelConfig animatronicModelConfig, Animatronics.Animatronic3d.Model.Effects.CloakController cloakController)
        {
            val_1 = new System.Object();
            this._cameraStableTransform = cameraStableTransform;
            this._animatronicPrefabTransform = animatronicModelConfig.ModelTransforms.PrefabTransform;
            this._rootBone = animatronicModelConfig.ModelTransforms.RootBone;
            this._transformBone = animatronicModelConfig.ModelTransforms.TransformBone;
            this._animatorDispatcher = val_1;
            this._localSpaceMover = new Animatronics.Animatronic3d.Model.Movement.LocalSpaceMover(animatronicPrefabTransform:  this._animatronicPrefabTransform);
            Animatronics.Animatronic3d.Model.Movement.TransformOverrider val_3 = new Animatronics.Animatronic3d.Model.Movement.TransformOverrider();
            ._cameraStableTransform = this._cameraStableTransform;
            ._animatronic3DTransform = animatronic3DTransform;
            ._transforms = animatronicModelConfig.ModelTransforms;
            ._offsets = animatronicModelConfig.AdditionalOffsets;
            ._cloakController = cloakController;
            ._offsetMode = 0;
            val_3.UpdateOverrides();
            this._transformOverrider = val_3;
            float val_7 = (float)UnityEngine.Screen.width;
            val_7 = val_7 * 0.5f;
            val_7 = 180f / val_7;
            this._workshopRotationSpeed = val_7;
            this._localSpaceMover.add_OnStartedMoving(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Movement.Mover::StartedMoving()));
            this._localSpaceMover.add_OnStoppedMoving(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Movement.Mover::StoppedMoving()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._localSpaceMover.remove_OnStoppedMoving(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Movement.Mover::StoppedMoving()));
            this._localSpaceMover.remove_OnStartedMoving(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Movement.Mover::StartedMoving()));
            this._transformOverrider._cloakController = 0;
            this._transformOverrider._cameraStableTransform = 0;
            this._transformOverrider._transforms = 0;
            this._localSpaceMover._animatronicPrefabTransform = 0;
            this._animatorDispatcher = 0;
            this._cameraStableTransform = 0;
            this._rootBone = 0;
        }
    
    }

}
