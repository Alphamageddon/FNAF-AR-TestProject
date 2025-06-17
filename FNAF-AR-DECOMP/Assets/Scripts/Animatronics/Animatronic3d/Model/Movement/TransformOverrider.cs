using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Movement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TransformOverrider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _cameraStableTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _animatronic3DTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.ModelTransforms _transforms;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.AdditionalOffsets _offsets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Effects.CloakController _cloakController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldFollowCameraPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldFollowCameraRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _additionalOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _additionalRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldOverrideAnimatedTransformBone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldOverrideAnimatedRootBone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldOverrideAnimatedCloakPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldOverrideAnimatedEyeCloakPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Movement.TransformOverrider.Mode _offsetMode;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsFollowingCameraPosition()
        {
            return (bool)this._shouldFollowCameraPosition;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsFollowingCameraRotation()
        {
            return (bool)this._shouldFollowCameraRotation;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetOverrideMode(Animatronics.Animatronic3d.Model.Movement.TransformOverrider.Mode mode)
        {
            this._offsetMode = mode;
            this.UpdateOverrides();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LateUpdate()
        {
            if(this._offsets.ShouldUpdateEveryFrame != false)
            {
                    this.UpdateOverrides();
            }
            
            this.UpdateAnimatronic3DPosition();
            this.UpdateAnimatronic3DRotation();
            this.SetAdditionalOffset();
            this.OverrideAnimatedTransformBone();
            this.OverrideAnimatedRootBone();
            this.OverrideAnimatedCloakPlane();
            this.OverrideAnimatedEyeCloakPlane();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateOverrides()
        {
            if(this._offsetMode > 3)
            {
                    return;
            }
            
            var val_3 = 52949004 + (this._offsetMode) << 2;
            val_3 = val_3 + 52949004;
            goto (52949004 + (this._offsetMode) << 2 + 52949004);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAnimatronic3DPosition()
        {
            if(this._shouldFollowCameraPosition == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this._cameraStableTransform.position;
            this._animatronic3DTransform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAnimatronic3DRotation()
        {
            UnityEngine.Transform val_3;
            var val_4;
            val_3 = this._animatronic3DTransform;
            if(this._shouldFollowCameraRotation != false)
            {
                    UnityEngine.Vector3 val_1 = this._cameraStableTransform.forward;
                val_3.forward = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
                val_4 = 1152921504840871936;
                val_3 = this._transforms.PrefabTransform;
            }
            else
            {
                    val_4 = 1152921504840871936;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_3.localEulerAngles = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetAdditionalOffset()
        {
            this._transforms.ModelRoot.localPosition = new UnityEngine.Vector3() {x = this._additionalOffset, y = V9.16B, z = V10.16B};
            this._transforms.ModelRoot.localEulerAngles = new UnityEngine.Vector3() {x = this._additionalRotation, y = V9.16B, z = V10.16B};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OverrideAnimatedTransformBone()
        {
            if(this._shouldOverrideAnimatedTransformBone == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            float val_2 = val_1.y;
            val_2 = val_2 + (-0.5f);
            this._transforms.TransformBone.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_2, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OverrideAnimatedRootBone()
        {
            if(this._shouldOverrideAnimatedRootBone == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this._transforms.RootBone.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OverrideAnimatedCloakPlane()
        {
            if(this._shouldOverrideAnimatedCloakPlane == false)
            {
                    return;
            }
            
            this._cloakController.UpdateCloakPercent();
            UnityEngine.Vector3 val_1 = this._cloakController.CalculateCloakPlanePosition();
            this._transforms.CloakPlaneBone.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OverrideAnimatedEyeCloakPlane()
        {
            if(this._shouldOverrideAnimatedEyeCloakPlane != false)
            {
                    UnityEngine.Vector3 val_1 = this._cloakController.CalculateEyeCloakPlanePosition();
            }
            else
            {
                    UnityEngine.Vector3 val_2 = this._transforms.CloakPlaneBone.localPosition;
            }
            
            this._transforms.EyeCloakPlane.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TransformOverrider(UnityEngine.Transform cameraStableTransform, UnityEngine.Transform animatronic3DTransform, Animatronics.Animatronic3d.Model.ModelTransforms modelTransforms, Animatronics.Animatronic3d.Model.AdditionalOffsets additionalOffsets, Animatronics.Animatronic3d.Model.Effects.CloakController cloakController)
        {
            val_1 = new System.Object();
            this._cameraStableTransform = cameraStableTransform;
            this._animatronic3DTransform = animatronic3DTransform;
            this._transforms = val_1;
            this._offsets = additionalOffsets;
            this._cloakController = cloakController;
            this._offsetMode = 0;
            this.UpdateOverrides();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._cloakController = 0;
            this._cameraStableTransform = 0;
            this._transforms = 0;
        }
    
    }

}
