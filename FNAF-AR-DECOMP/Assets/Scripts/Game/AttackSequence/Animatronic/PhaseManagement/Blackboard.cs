using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Blackboard : IBlackboardPhaseAccess
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <NumShocksRemaining>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <InShockableWindow>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <EntityId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.IAnimatronic3D <Model>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems <Systems>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsExpressDelivery>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Static.StaticConfig <StaticConfig>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.AttackProfile <AttackProfile>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState <HaywireState>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsInCameraMode>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <AbsoluteAngleFromCamera>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <DistanceFromCamera>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsAABBOnScreen>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsOnScreen>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <FreezeStaticAngle>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 <FrozenStaticPosition>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <ShouldCheckForDirectionChange>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <ShockedDuringHaywire>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <ForceCircleAfterPause>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <PhantomOverloadRequested>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <PhantomRepositionRequested>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumShocksRemaining { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool InShockableWindow { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.IAnimatronic3D Model { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems Systems { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsExpressDelivery { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticConfig StaticConfig { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.AttackProfile AttackProfile { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState HaywireState { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInCameraMode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float AbsoluteAngleFromCamera { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistanceFromCamera { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAABBOnScreen { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsOnScreen { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool FreezeStaticAngle { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 FrozenStaticPosition { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldCheckForDirectionChange { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShockedDuringHaywire { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ForceCircleAfterPause { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool PhantomOverloadRequested { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool PhantomRepositionRequested { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumShocksRemaining()
        {
            return (int)this.<NumShocksRemaining>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_NumShocksRemaining(int value)
        {
            this.<NumShocksRemaining>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_InShockableWindow()
        {
            return (bool)this.<InShockableWindow>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_InShockableWindow(bool value)
        {
            this.<InShockableWindow>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_EntityId()
        {
            return (string)this.<EntityId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EntityId(string value)
        {
            this.<EntityId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.IAnimatronic3D get_Model()
        {
            return (Animatronics.Animatronic3d.IAnimatronic3D)this.<Model>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Model(Animatronics.Animatronic3d.IAnimatronic3D value)
        {
            this.<Model>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems get_Systems()
        {
            return (Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems)this.<Systems>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Systems(Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems value)
        {
            this.<Systems>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsExpressDelivery()
        {
            return (bool)this.<IsExpressDelivery>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsExpressDelivery(bool value)
        {
            this.<IsExpressDelivery>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticConfig get_StaticConfig()
        {
            return (Game.AttackSequence.Static.StaticConfig)this.<StaticConfig>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StaticConfig(Game.AttackSequence.Static.StaticConfig value)
        {
            this.<StaticConfig>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.AttackProfile get_AttackProfile()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.AttackProfile)this.<AttackProfile>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AttackProfile(Game.ItemDefinition.Data.DataDefinitions.AttackProfile value)
        {
            this.<AttackProfile>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState get_HaywireState()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState)this.<HaywireState>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_HaywireState(Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState value)
        {
            this.<HaywireState>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsInCameraMode()
        {
            return (bool)this.<IsInCameraMode>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsInCameraMode(bool value)
        {
            this.<IsInCameraMode>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_AbsoluteAngleFromCamera()
        {
            return (float)this.<AbsoluteAngleFromCamera>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AbsoluteAngleFromCamera(float value)
        {
            this.<AbsoluteAngleFromCamera>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DistanceFromCamera()
        {
            return (float)this.<DistanceFromCamera>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DistanceFromCamera(float value)
        {
            this.<DistanceFromCamera>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsAABBOnScreen()
        {
            return (bool)this.<IsAABBOnScreen>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsAABBOnScreen(bool value)
        {
            this.<IsAABBOnScreen>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsOnScreen()
        {
            return (bool)this.<IsOnScreen>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsOnScreen(bool value)
        {
            this.<IsOnScreen>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_FreezeStaticAngle()
        {
            return (bool)this.<FreezeStaticAngle>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_FreezeStaticAngle(bool value)
        {
            this.<FreezeStaticAngle>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_FrozenStaticPosition()
        {
            return new UnityEngine.Vector3() {x = this.<FrozenStaticPosition>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_FrozenStaticPosition(UnityEngine.Vector3 value)
        {
            this.<FrozenStaticPosition>k__BackingField = value;
            mem[1152921525460627380] = value.y;
            mem[1152921525460627384] = value.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShouldCheckForDirectionChange()
        {
            return (bool)this.<ShouldCheckForDirectionChange>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShouldCheckForDirectionChange(bool value)
        {
            this.<ShouldCheckForDirectionChange>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShockedDuringHaywire()
        {
            return (bool)this.<ShockedDuringHaywire>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShockedDuringHaywire(bool value)
        {
            this.<ShockedDuringHaywire>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ForceCircleAfterPause()
        {
            return (bool)this.<ForceCircleAfterPause>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ForceCircleAfterPause(bool value)
        {
            this.<ForceCircleAfterPause>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_PhantomOverloadRequested()
        {
            return (bool)this.<PhantomOverloadRequested>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PhantomOverloadRequested(bool value)
        {
            this.<PhantomOverloadRequested>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_PhantomRepositionRequested()
        {
            return (bool)this.<PhantomRepositionRequested>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PhantomRepositionRequested(bool value)
        {
            this.<PhantomRepositionRequested>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.<Model>k__BackingField = 0;
            this.<Systems>k__BackingField = 0;
            this.<AttackProfile>k__BackingField = 0;
            this.<HaywireState>k__BackingField = 0;
            this.<StaticConfig>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Blackboard()
        {
        
        }
    
    }

}
