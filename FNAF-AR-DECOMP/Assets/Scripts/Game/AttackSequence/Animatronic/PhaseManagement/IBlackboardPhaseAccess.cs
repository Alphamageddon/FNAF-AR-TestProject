using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IBlackboardPhaseAccess
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int NumShocksRemaining { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string EntityId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Animatronics.Animatronic3d.IAnimatronic3D Model { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems Systems { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsExpressDelivery { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Static.StaticConfig StaticConfig { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.ItemDefinition.Data.DataDefinitions.AttackProfile AttackProfile { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState HaywireState { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsInCameraMode { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float AbsoluteAngleFromCamera { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float DistanceFromCamera { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsAABBOnScreen { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool FreezeStaticAngle { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Vector3 FrozenStaticPosition { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool ShouldCheckForDirectionChange { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool ShockedDuringHaywire { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool ForceCircleAfterPause { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool PhantomOverloadRequested { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool PhantomRepositionRequested { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_NumShocksRemaining(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_EntityId(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Animatronics.Animatronic3d.IAnimatronic3D get_Model(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems get_Systems(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsExpressDelivery(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Static.StaticConfig get_StaticConfig(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.ItemDefinition.Data.DataDefinitions.AttackProfile get_AttackProfile(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState get_HaywireState(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsInCameraMode(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_AbsoluteAngleFromCamera(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_DistanceFromCamera(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsAABBOnScreen(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_FreezeStaticAngle(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_FreezeStaticAngle(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Vector3 get_FrozenStaticPosition(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_FrozenStaticPosition(UnityEngine.Vector3 value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_ShouldCheckForDirectionChange(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_ShouldCheckForDirectionChange(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_ShockedDuringHaywire(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_ShockedDuringHaywire(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_ForceCircleAfterPause(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_ForceCircleAfterPause(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_PhantomOverloadRequested(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_PhantomOverloadRequested(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_PhantomRepositionRequested(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_PhantomRepositionRequested(bool value); // 0
    
    }

}
