using UnityEngine;

namespace Animatronics.Animatronic3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAnimatronic3D
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAnimationMode(Animatronics.Animatronic3d.Model.Animation.AnimationMode animationMode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAnimationBool(Animatronics.Animatronic3d.Model.Animation.AnimationBool animationBool, bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAnimationInt(Animatronics.Animatronic3d.Model.Animation.AnimationInt animationInt, int value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAnimationFloat(Animatronics.Animatronic3d.Model.Animation.AnimationFloat animationFloat, float value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAnimationTrigger(Animatronics.Animatronic3d.Model.Animation.AnimationTrigger animationTrigger, bool shouldSet); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseAudioEventCamera(Game.Audio.AudioEventName eventName, bool useCpu); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseAudioEventGlobal(Game.Audio.AudioEventName eventName, bool useCpu); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseAudioEventFromPlushSuit(Game.Audio.AudioEventName eventName); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAudioParameter(Game.Audio.AudioParameterName parameterName, float value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAudioMute(bool shouldMute); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Animatronics.Animatronic3d.Model.Effects.CloakSettings GetCloakSettings(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetEyeGlow(bool eyeGlowEnabled); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetCloakState(bool cloakEnabled); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void BeginCloak(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void BeginDecloak(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetEyeCloakState(bool eyeCloakEnabled); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void BeginEyeCloak(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void BeginEyeDecloak(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void CloseShockWindow(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RegisterForPhantomManifestComplete(System.Action callback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UnregisterForPhantomManifestComplete(System.Action callback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetPhantomAnimationSpeedModifier(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetPhantomRepositionEffectTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetPhantomShutdownEffectTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetPhantomEffectAndAnimationState(PhantomFxController.States state); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetWearAndTear(int value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TriggerRepairInterpolation(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Vector3 GetRootBonePosition(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Vector3 GetPosition(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Vector3 GetForward(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Animatronics.Animatronic3d.Model.MovementSettings GetMovementSettings(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetTransformOverrideMode(Animatronics.Animatronic3d.Model.Movement.TransformOverrider.Mode mode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetAbsoluteAngleBetweenPositionAndCamera(UnityEngine.Vector3 position); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetSignedAngleBetweenPositionAndCamera(UnityEngine.Vector3 position); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetAbsoluteAngleFromCamera(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float GetDistanceFromCamera(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera = False); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TeleportToLocalPosition(UnityEngine.Vector3 position, UnityEngine.Vector3 forward); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TeleportInFrontOfCamera(float distanceFromCamera); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TeleportAtCurrentAngle(float distanceFromCamera); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void InvertFacing(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RotateFacingInWorkshop(UnityEngine.Vector3 mPrevPos, UnityEngine.Vector3 mCurrPos); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsMoving(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void StopMoving(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void MoveInCircleAroundCamera(float degreesPerSecond, bool isWalking, float duration = -1); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void MoveInLineTowardCamera(float unitsPerSecond, bool isWalking, float duration = -1); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetFootstepConfig(Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData walkConfigData, Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData runConfigData); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetFootstepEffectCallback(Animatronics.Animatronic3d.Model.Movement.Footsteps.FootstepEffectTriggered callback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsAABBInCameraFrustum(UnityEngine.Camera cameraToTest); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsOnScreen(UnityEngine.Camera cameraToTest, float xBorderMin, float xBorderMax, float yBorderMin, float yBorderMax); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Setup(Game.ItemDefinition.Data.DataDefinitions.CPUData cpuData, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData plushSuitData, Game.ItemDefinition.Data.DataDefinitions.AttackProfile attackProfile, Game.Audio.AudioMode audioMode, Master.EventExposer masterEventExposer, TheGame.GameDisplayData.DisplayType displayMode = 6, UnityEngine.Transform cameraStableTransform); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Teardown(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RegisterForAnimationGameEvents(System.Action<UnityEngine.AnimationEvent> eventReceived); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UnregisterFromAnimationGameEvents(System.Action<UnityEngine.AnimationEvent> eventReceived); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RegisterUpdateCallback(System.Action update); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UnregisterUpdateCallback(System.Action update); // 0
    
    }

}
