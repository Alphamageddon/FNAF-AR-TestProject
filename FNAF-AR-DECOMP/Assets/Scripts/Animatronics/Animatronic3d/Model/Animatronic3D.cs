using UnityEngine;

namespace Animatronics.Animatronic3d.Model
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Animatronic3D : MonoBehaviour, IAnimatronic3D
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _cpuId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _plushSuitId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _cameraStableTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.AnimatronicModelConfig _modelConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Animation.AnimationEventDispatcher _animationEventDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Animation.AnimatorDispatcher _animatorDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Effects.EffectsDispatcher _effectsDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Audio.AudioDispatcher _audioDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Effects.CloakController _cloakController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Movement.Footsteps _footsteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Movement.Mover _mover;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.AnimationEvent> OnAnimationGameEventReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnUpdate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnAnimationGameEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAnimationGameEventReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimationGameEventReceived != 1152921525066716792);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnAnimationGameEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAnimationGameEventReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimationGameEventReceived != 1152921525066853368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnUpdate(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdate, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdate != 1152921525066989952);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnUpdate(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdate, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdate != 1152921525067126528);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationMode(Animatronics.Animatronic3d.Model.Animation.AnimationMode animationMode)
        {
            this._animatorDispatcher.SetAnimationInt(animationInt:  1, value:  animationMode);
            this._animatorDispatcher.SetAnimationTrigger(animationTrigger:  10, shouldSet:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag)
        {
            if(this._animatorDispatcher != null)
            {
                    return this._animatorDispatcher.IsAnimationTagActive(animationTag:  animationTag);
            }
            
            return this._animatorDispatcher.IsAnimationTagActive(animationTag:  animationTag);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationBool(Animatronics.Animatronic3d.Model.Animation.AnimationBool animationBool, bool value)
        {
            value = value;
            this._animatorDispatcher.SetAnimationBool(animationBool:  animationBool, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationInt(Animatronics.Animatronic3d.Model.Animation.AnimationInt animationInt, int value)
        {
            this._animatorDispatcher.SetAnimationInt(animationInt:  animationInt, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationFloat(Animatronics.Animatronic3d.Model.Animation.AnimationFloat animationFloat, float value)
        {
            this._animatorDispatcher.SetAnimationFloat(animationFloat:  animationFloat, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationTrigger(Animatronics.Animatronic3d.Model.Animation.AnimationTrigger animationTrigger, bool shouldSet)
        {
            shouldSet = shouldSet;
            this._animatorDispatcher.SetAnimationTrigger(animationTrigger:  animationTrigger, shouldSet:  shouldSet);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseAudioEventCamera(Game.Audio.AudioEventName eventName, bool useCpu)
        {
            useCpu = useCpu;
            this._audioDispatcher.RaiseGameEventCamera(eventName:  eventName, useCpu:  useCpu);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseAudioEventGlobal(Game.Audio.AudioEventName eventName, bool useCpu)
        {
            useCpu = useCpu;
            this._audioDispatcher.RaiseGameEventGlobal(eventName:  eventName, useCpu:  useCpu);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName)
        {
            this._audioDispatcher.RaiseEventFromCpu(eventName:  eventName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseAudioEventFromPlushSuit(Game.Audio.AudioEventName eventName)
        {
            this._audioDispatcher.RaiseEventFromPlushSuit(eventName:  eventName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAudioParameter(Game.Audio.AudioParameterName parameterName, float value)
        {
            this._audioDispatcher.SetParameter(parameterName:  parameterName, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAudioMute(bool shouldMute)
        {
            shouldMute = shouldMute;
            this._audioDispatcher.SetMute(shouldMute:  shouldMute);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.Effects.CloakSettings GetCloakSettings()
        {
            if(this._modelConfig != null)
            {
                    return (Animatronics.Animatronic3d.Model.Effects.CloakSettings)this._modelConfig.CloakSettings;
            }
            
            return (Animatronics.Animatronic3d.Model.Effects.CloakSettings)this._modelConfig.CloakSettings;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode)
        {
            this._effectsDispatcher.SetEyeColorMode(mode:  mode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEyeGlow(bool eyeGlowEnabled)
        {
            eyeGlowEnabled = eyeGlowEnabled;
            this._effectsDispatcher.SetEyeGlow(eyeGlowEnabled:  eyeGlowEnabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCloakState(bool cloakEnabled)
        {
            cloakEnabled = cloakEnabled;
            this._cloakController.SetCloakState(cloakEnabled:  cloakEnabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginCloak()
        {
            this._cloakController.BeginCloak();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginDecloak()
        {
            this._cloakController.BeginDecloak();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEyeCloakState(bool eyeCloakEnabled)
        {
            eyeCloakEnabled = eyeCloakEnabled;
            this._cloakController.SetEyeCloakState(eyeCloakEnabled:  eyeCloakEnabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginEyeCloak()
        {
            this._cloakController.BeginEyeCloak();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginEyeDecloak()
        {
            this._cloakController.BeginEyeDecloak();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CloseShockWindow()
        {
            this.ShockWindowClosed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterForPhantomManifestComplete(System.Action callback)
        {
            if(this._modelConfig.PhantomFxController == 0)
            {
                    return;
            }
            
            this._modelConfig.PhantomFxController.RegisterForMeshToggle(callback:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnregisterForPhantomManifestComplete(System.Action callback)
        {
            if(this._modelConfig.PhantomFxController == 0)
            {
                    return;
            }
            
            this._modelConfig.PhantomFxController.UnregisterForMeshToggle(callback:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetPhantomAnimationSpeedModifier()
        {
            if(this._modelConfig.PhantomFxController == 0)
            {
                    return 1f;
            }
            
            if(this._modelConfig.PhantomFxController != null)
            {
                    return this._modelConfig.PhantomFxController.GetAnimationSpeedModifier();
            }
            
            return this._modelConfig.PhantomFxController.GetAnimationSpeedModifier();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetPhantomRepositionEffectTime()
        {
            if(this._modelConfig.PhantomFxController == 0)
            {
                    return 0f;
            }
            
            if(this._modelConfig.PhantomFxController.repositionVfxDuration != null)
            {
                    return this._modelConfig.PhantomFxController.repositionVfxDuration.GetDuration();
            }
            
            return this._modelConfig.PhantomFxController.repositionVfxDuration.GetDuration();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetPhantomShutdownEffectTime()
        {
            if(this._modelConfig.PhantomFxController == 0)
            {
                    return 0f;
            }
            
            if(this._modelConfig.PhantomFxController.shutdownVfxDuration != null)
            {
                    return this._modelConfig.PhantomFxController.shutdownVfxDuration.GetDuration();
            }
            
            return this._modelConfig.PhantomFxController.shutdownVfxDuration.GetDuration();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPhantomEffectAndAnimationState(PhantomFxController.States state)
        {
            if(this._modelConfig.PhantomFxController == 0)
            {
                    return;
            }
            
            this._modelConfig.PhantomFxController.SetState(newState:  state);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetWearAndTear(int value)
        {
            this._effectsDispatcher.SetWearAndTear(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerRepairInterpolation()
        {
            this._effectsDispatcher._materialController._shouldPerformRepairInterpolation = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetRootBonePosition()
        {
            if(this._mover != null)
            {
                    return this._mover.GetRootBonePosition();
            }
            
            return this._mover.GetRootBonePosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetPosition()
        {
            if(this._mover != null)
            {
                    return this._mover.GetPosition();
            }
            
            return this._mover.GetPosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetForward()
        {
            if(this._mover != null)
            {
                    return this._mover.GetForward();
            }
            
            return this._mover.GetForward();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.MovementSettings GetMovementSettings()
        {
            if(this._modelConfig != null)
            {
                    return (Animatronics.Animatronic3d.Model.MovementSettings)this._modelConfig.MovementSettings;
            }
            
            return (Animatronics.Animatronic3d.Model.MovementSettings)this._modelConfig.MovementSettings;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetTransformOverrideMode(Animatronics.Animatronic3d.Model.Movement.TransformOverrider.Mode mode)
        {
            this._mover.SetTransformOverrideMode(mode:  mode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetAbsoluteAngleBetweenPositionAndCamera(UnityEngine.Vector3 position)
        {
            if(this._mover != null)
            {
                    return this._mover.GetAbsoluteAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            }
            
            return this._mover.GetAbsoluteAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetSignedAngleBetweenPositionAndCamera(UnityEngine.Vector3 position)
        {
            if(this._mover != null)
            {
                    return this._mover.GetSignedAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            }
            
            return this._mover.GetSignedAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetAbsoluteAngleFromCamera()
        {
            if(this._mover != null)
            {
                    return this._mover.GetAbsoluteAngleFromCamera();
            }
            
            return this._mover.GetAbsoluteAngleFromCamera();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetDistanceFromCamera()
        {
            if(this._mover != null)
            {
                    return this._mover.GetDistanceFromCamera();
            }
            
            return this._mover.GetDistanceFromCamera();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera)
        {
            faceCamera = faceCamera;
            this._mover.Teleport(angleFromCamera:  angleFromCamera, distanceFromCamera:  distanceFromCamera, faceCamera:  faceCamera);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TeleportToLocalPosition(UnityEngine.Vector3 position, UnityEngine.Vector3 forward)
        {
            this._mover.TeleportToLocalPosition(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, forward:  new UnityEngine.Vector3() {x = forward.x, y = forward.y, z = forward.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TeleportInFrontOfCamera(float distanceFromCamera)
        {
            this._mover.TeleportInFrontOfCamera(distanceFromCamera:  distanceFromCamera);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TeleportAtCurrentAngle(float distanceFromCamera)
        {
            this._mover.TeleportAtCurrentAngle(distanceFromCamera:  distanceFromCamera);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InvertFacing()
        {
            this._mover.InvertFacing();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RotateFacingInWorkshop(UnityEngine.Vector3 mPrevPos, UnityEngine.Vector3 mCurrPos)
        {
            this._mover.RotateFacingInWorkshop(mPrevPos:  new UnityEngine.Vector3() {x = mPrevPos.x, y = mPrevPos.y, z = mPrevPos.z}, mCurrPos:  new UnityEngine.Vector3() {x = mCurrPos.x, y = mCurrPos.y, z = mCurrPos.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMoving()
        {
            return (bool)(this._mover._localSpaceMover._movementUnitsPerSecond != 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopMoving()
        {
            this._mover.StopMovement();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveInCircleAroundCamera(float degreesPerSecond, bool isWalking, float duration = -1)
        {
            bool val_1 = isWalking;
            this._mover.MoveInCircleAroundCamera(degreesPerSecond:  degreesPerSecond, isWalking:  val_1, duration:  duration);
            this._footsteps._isWalking = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveInLineTowardCamera(float unitsPerSecond, bool isWalking, float duration = -1)
        {
            bool val_1 = isWalking;
            this._mover.MoveInLineTowardCamera(unitsPerSecond:  unitsPerSecond, isWalking:  val_1, duration:  duration);
            this._footsteps._isWalking = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFootstepConfig(Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData walkConfigData, Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData runConfigData)
        {
            this._footsteps._walkConfigData = walkConfigData;
            this._footsteps._runConfigData = runConfigData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFootstepEffectCallback(Animatronics.Animatronic3d.Model.Movement.Footsteps.FootstepEffectTriggered callback)
        {
            this._footsteps.add_OnFootstepEffectTriggered(value:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAABBInCameraFrustum(UnityEngine.Camera cameraToTest)
        {
            float val_5;
            float val_6;
            UnityEngine.Object val_10;
            UnityEngine.Plane[] val_11;
            val_10 = cameraToTest;
            if(val_10 != 0)
            {
                    if(this._modelConfig.AABBCollider != 0)
            {
                goto label_7;
            }
            
            }
            
            val_11 = 0;
            return (bool)UnityEngine.GeometryUtility.TestPlanesAABB(planes:  val_11 = val_10, bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Extents = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}});
            label_7:
            val_10 = UnityEngine.GeometryUtility.CalculateFrustumPlanes(camera:  val_10);
            UnityEngine.Bounds val_4 = this._modelConfig.AABBCollider.bounds;
            return (bool)UnityEngine.GeometryUtility.TestPlanesAABB(planes:  val_11, bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Extents = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsOnScreen(UnityEngine.Camera cameraToTest, float xBorderMin, float xBorderMax, float yBorderMin, float yBorderMax)
        {
            var val_13;
            if(cameraToTest != 0)
            {
                    if(cameraToTest.isActiveAndEnabled != false)
            {
                    UnityEngine.Vector3 val_3 = this._modelConfig.ModelTransforms.RootBone.position;
                UnityEngine.Vector3 val_4 = cameraToTest.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                float val_13 = 0f;
                float val_12 = 1f;
                float val_5 = xBorderMin + val_13;
                val_12 = yBorderMax + val_12;
                var val_7 = (val_4.x >= 0) ? 1 : 0;
                val_13 = yBorderMin + val_13;
                val_7 = val_7 & ((val_4.x <= (xBorderMax + val_12)) ? 1 : 0);
                val_7 = ((val_4.y <= val_12) ? 1 : 0) & val_7;
                val_7 = ((val_4.y >= 0) ? 1 : 0) & val_7;
                val_13 = ((val_4.z > 0f) ? 1 : 0) & val_7;
                return (bool)val_13;
            }
            
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterForAnimationGameEvents(System.Action<UnityEngine.AnimationEvent> eventReceived)
        {
            this.add_OnAnimationGameEventReceived(value:  eventReceived);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnregisterFromAnimationGameEvents(System.Action<UnityEngine.AnimationEvent> eventReceived)
        {
            this.remove_OnAnimationGameEventReceived(value:  eventReceived);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterUpdateCallback(System.Action update)
        {
            this.add_OnUpdate(value:  update);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnregisterUpdateCallback(System.Action update)
        {
            this.remove_OnUpdate(value:  update);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimationGameEventReceived(UnityEngine.AnimationEvent animationEvent)
        {
            if(this.OnAnimationGameEventReceived == null)
            {
                    return;
            }
            
            this.OnAnimationGameEventReceived.Invoke(obj:  animationEvent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShockWindowOpened()
        {
            UnityEngine.AnimationEvent val_1 = new UnityEngine.AnimationEvent();
            val_1.intParameter = 208;
            this._animationEventDispatcher.AnimationEventReceived(animationEvent:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShockWindowClosed()
        {
            UnityEngine.AnimationEvent val_1 = new UnityEngine.AnimationEvent();
            val_1.intParameter = 209;
            this._animationEventDispatcher.AnimationEventReceived(animationEvent:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAudioPlayer(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetModelConfig(Animatronics.Animatronic3d.Model.AnimatronicModelConfig prefab)
        {
            this._modelConfig = UnityEngine.Object.Instantiate<Animatronics.Animatronic3d.Model.AnimatronicModelConfig>(original:  prefab, parent:  this.transform);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.ItemDefinition.Data.DataDefinitions.CPUData cpuData, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData plushSuitData, Game.ItemDefinition.Data.DataDefinitions.AttackProfile attackProfile, Game.Audio.AudioMode audioMode, Master.EventExposer masterEventExposer, TheGame.GameDisplayData.DisplayType displayMode, UnityEngine.Transform cameraStableTransform)
        {
            var val_14;
            string val_15;
            string val_16;
            string val_17;
            string val_18;
            val_14 = plushSuitData;
            if(cpuData == null)
            {
                goto label_1;
            }
            
            if(this != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this._cpuId = cpuData.Id;
            if(val_14 == null)
            {
                goto label_3;
            }
            
            val_15 = plushSuitData.Id;
            goto label_4;
            label_1:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_15 = 0;
            label_4:
            this._plushSuitId = val_15;
            this._cameraStableTransform = cameraStableTransform;
            Animatronics.Animatronic3d.Model.Animation.AnimationEventDispatcher val_1 = new Animatronics.Animatronic3d.Model.Animation.AnimationEventDispatcher();
            this._animationEventDispatcher = val_1;
            val_1.Setup(animationEventListener:  this._modelConfig.AnimationEventListener);
            this._animatorDispatcher = new Animatronics.Animatronic3d.Model.Animation.AnimatorDispatcher();
            ._animator = this._modelConfig.Animator;
            if(val_14 != null)
            {
                    val_16 = plushSuitData.SoundBankName;
            }
            
            if(attackProfile != null)
            {
                    var val_3 = (attackProfile.EncounterType != 1) ? (val_16) : 0;
                if((attackProfile.EncounterType == 1) && (cpuData != null))
            {
                    val_17 = cpuData.SoundBankName;
            }
            
            }
            
            Animatronics.Animatronic3d.Model.Audio.AudioDispatcher val_4 = new Animatronics.Animatronic3d.Model.Audio.AudioDispatcher();
            this._audioDispatcher = val_4;
            if(cpuData != null)
            {
                    val_18 = cpuData.SoundBankName;
            }
            else
            {
                    val_18 = 0;
            }
            
            val_4.Setup(cpuSoundBankName:  val_18, plushSuitSoundBankName:  val_17, audioPlayer:  this._audioPlayer, akAudioEmitter:  this._modelConfig.AkAudioEmitter, audioMode:  audioMode);
            this._footsteps = new Animatronics.Animatronic3d.Model.Movement.Footsteps(masterEventExposer:  masterEventExposer, audioDispatcher:  this._audioDispatcher, mode:  displayMode);
            Animatronics.Animatronic3d.Model.Effects.EffectsDispatcher val_6 = new Animatronics.Animatronic3d.Model.Effects.EffectsDispatcher();
            this._effectsDispatcher = val_6;
            val_6.Setup(modelConfig:  this._modelConfig, footsteps:  this._footsteps, cpuData:  cpuData);
            this._cloakController = new Animatronics.Animatronic3d.Model.Effects.CloakController(settings:  this._modelConfig.CloakSettings);
            this._mover = new Animatronics.Animatronic3d.Model.Movement.Mover(cameraStableTransform:  this._cameraStableTransform, animatronic3DTransform:  cameraStableTransform.transform, animatorDispatcher:  this._animatorDispatcher, animatronicModelConfig:  this._modelConfig, cloakController:  this._cloakController);
            this._cloakController.add_OnShockWindowOpened(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Animatronic3D::ShockWindowOpened()));
            this._animationEventDispatcher.add_OnEffectEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this._effectsDispatcher, method:  public System.Void Animatronics.Animatronic3d.Model.Effects.EffectsDispatcher::EffectEventReceived(UnityEngine.AnimationEvent animationEvent)));
            this._animationEventDispatcher.add_OnGameEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Animatronic3D::AnimationGameEventReceived(UnityEngine.AnimationEvent animationEvent)));
            this._animationEventDispatcher.add_OnSoundEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this._audioDispatcher, method:  public System.Void Animatronics.Animatronic3d.Model.Audio.AudioDispatcher::SoundEventReceived(UnityEngine.AnimationEvent animationEvent)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._animationEventDispatcher.remove_OnSoundEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this._audioDispatcher, method:  public System.Void Animatronics.Animatronic3d.Model.Audio.AudioDispatcher::SoundEventReceived(UnityEngine.AnimationEvent animationEvent)));
            this._animationEventDispatcher.remove_OnGameEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Animatronic3D::AnimationGameEventReceived(UnityEngine.AnimationEvent animationEvent)));
            this._animationEventDispatcher.remove_OnEffectEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this._effectsDispatcher, method:  public System.Void Animatronics.Animatronic3d.Model.Effects.EffectsDispatcher::EffectEventReceived(UnityEngine.AnimationEvent animationEvent)));
            this._cloakController.remove_OnShockWindowOpened(value:  new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Animatronic3D::ShockWindowOpened()));
            this._mover.Teardown();
            this._mover = 0;
            this._cloakController = 0;
            this._audioDispatcher.Teardown();
            this._audioDispatcher = 0;
            this._effectsDispatcher._footsteps = 0;
            this._effectsDispatcher._lightningEffect = 0;
            this._effectsDispatcher._materialController = 0;
            this._effectsDispatcher = 0;
            this._animatorDispatcher._animator = 0;
            this._animatorDispatcher = 0;
            this._footsteps.Teardown();
            this._footsteps = 0;
            this._animationEventDispatcher._animationEventListener = 0;
            this._animationEventDispatcher = 0;
            UnityEngine.Object.Destroy(obj:  this._modelConfig);
            this._audioPlayer = 0;
            this._modelConfig = 0;
            this._cameraStableTransform = 0;
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.OnUpdate != null)
            {
                    this.OnUpdate.Invoke();
            }
            
            if(this._mover == null)
            {
                    return;
            }
            
            this._mover.Update();
            this._footsteps._distanceFromCamera = this._mover.GetDistanceFromCamera();
            this._footsteps.UpdateFootstepEffects();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            if(this._mover == null)
            {
                    return;
            }
            
            this._mover.LateUpdate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronic3D()
        {
        
        }
    
    }

}
