using UnityEngine;

namespace Game.AttackSequence.Animatronic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackAnimatronic
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic> OnReadyForCleanup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _currentMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems _systems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntity _entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.IAnimatronic3D _model;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.AttackProfile _attackProfile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Blackboard _blackboard;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.PhaseChooser _phaseChooser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _readyForCleanup;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CpuAudioId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CpuId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlushSuitId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EncounterType EncounterType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long EncounterStartTime { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 RewardData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnReadyForCleanup(System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnReadyForCleanup, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReadyForCleanup != 1152921525448169648);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnReadyForCleanup(System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnReadyForCleanup, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReadyForCleanup != 1152921525448306224);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_EntityId()
        {
            if(this._entity != null)
            {
                    return this._entity.entityId;
            }
            
            return this._entity.entityId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_CpuAudioId()
        {
            if(this._entity.animatronicConfigData.CpuData != null)
            {
                    return (string)val_2.SoundBankName;
            }
            
            return (string)val_2.SoundBankName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_CpuId()
        {
            if(this._entity.animatronicConfigData.CpuData != null)
            {
                    return (string)val_2.Id;
            }
            
            return (string)val_2.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_PlushSuitId()
        {
            if(this._entity.animatronicConfigData.PlushSuitData != null)
            {
                    return (string)val_2.Id;
            }
            
            return (string)val_2.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EncounterType get_EncounterType()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.Blackboard val_2;
            var val_3;
            val_2 = this._blackboard;
            if(val_2 != null)
            {
                    val_2 = this._blackboard.<AttackProfile>k__BackingField;
                if(val_2 != null)
            {
                    val_2 = 0;
            }
            
            }
            
            if(((-632691048) & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_1 = val_2.region;
                return (Game.ItemDefinition.Data.DataDefinitions.EncounterType)val_3;
            }
            
            val_3 = 0;
            return (Game.ItemDefinition.Data.DataDefinitions.EncounterType)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_EncounterStartTime()
        {
            AnimatronicEntity.AttackSequenceData val_1 = this._entity.AttackSequenceData;
            if(val_1 != null)
            {
                    return val_1.encounterStartTime;
            }
            
            return val_1.encounterStartTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 get_RewardData()
        {
            if(this._entity != null)
            {
                    return this._entity.rewardDataV3;
            }
            
            return this._entity.rewardDataV3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HitByShocker()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.PhaseChooser val_3;
            Game.AttackSequence.Animatronic.PhaseManagement.Phase val_4;
            val_3 = this;
            if(this.IsShockable() != false)
            {
                    val_4 = 1;
                return (bool)val_4;
            }
            
            if((this._blackboard.<IsOnScreen>k__BackingField) != false)
            {
                    val_3 = this._phaseChooser;
                val_4 = this._phaseChooser._currentPhase;
                if(val_4 == null)
            {
                    return (bool)val_4;
            }
            
                var val_2 = (val_4 == 8) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EncounterEnded()
        {
            this._phaseChooser.SetPhase(newPhase:  11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            this._currentMode = args.currentDisplay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsShockable()
        {
            if(this._blackboard != null)
            {
                    return (bool)(((this._blackboard.<InShockableWindow>k__BackingField) == true) ? 1 : 0) & (((this._blackboard.<IsOnScreen>k__BackingField) == true) ? 1 : 0);
            }
            
            this._blackboard = this._blackboard;
            if(this._blackboard != null)
            {
                    return (bool)(((this._blackboard.<InShockableWindow>k__BackingField) == true) ? 1 : 0) & (((this._blackboard.<IsOnScreen>k__BackingField) == true) ? 1 : 0);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShockerActivated(Game.CameraEquipment.Shocker.ShockerActivation shockerActivation)
        {
            if(shockerActivation.OnCooldown == true)
            {
                    return;
            }
            
            if(shockerActivation.NoBattery != false)
            {
                    return;
            }
            
            if(shockerActivation.DidHit == false)
            {
                    return;
            }
            
            if((this._phaseChooser._currentPhase != null) && (this._phaseChooser._currentPhase == 8))
            {
                    this._blackboard.<ShockedDuringHaywire>k__BackingField = true;
                return;
            }
            
            this.Shock();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimationGameEventReceived(UnityEngine.AnimationEvent animationEvent)
        {
            if((animationEvent.intParameter - 2000) > 3)
            {
                    return;
            }
            
            var val_4 = 52950240 + ((val_1 - 2000)) << 2;
            val_4 = val_4 + 52950240;
            goto (52950240 + ((val_1 - 2000)) << 2 + 52950240);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FootstepEffectTriggered(bool isWalking)
        {
            this._systems.AttackStatic.<Container>k__BackingField.AddFootstepAdditive(entityId:  this.EntityId, settings:  (isWalking != true) ? this._blackboard.<StaticConfig>k__BackingField.WalkFootsteps : this._blackboard.<StaticConfig>k__BackingField.RunFootsteps);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Shock()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.Blackboard val_1;
            int val_2;
            val_1 = this._blackboard;
            if(val_1 != null)
            {
                    val_2 = this._blackboard.<NumShocksRemaining>k__BackingField;
            }
            else
            {
                    val_1 = 16;
                val_2 = 11993091;
            }
            
            mem[16] = 11993090;
            this._masterEventExposer.OnAnimatronicShocked();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBlackboard()
        {
            var val_8;
            var val_12;
            this._blackboard.<IsInCameraMode>k__BackingField = (this._currentMode == 1) ? 1 : 0;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_8 = 37;
            this._blackboard.<AbsoluteAngleFromCamera>k__BackingField = this._model.GetAbsoluteAngleFromCamera();
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_8 = 38;
            this._blackboard.<DistanceFromCamera>k__BackingField = this._model.GetDistanceFromCamera();
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_8 = 51;
            val_12 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAABBInCameraFrustum(UnityEngine.Camera cameraToTest);
            this._blackboard.<IsAABBOnScreen>k__BackingField = this._model.IsAABBInCameraFrustum(cameraToTest:  this._systems.Camera);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_12 = 52;
            this._blackboard.<IsOnScreen>k__BackingField = this._model.IsOnScreen(cameraToTest:  this._systems.Camera, xBorderMin:  0.1f, xBorderMax:  -0.1f, yBorderMin:  -0.5f, yBorderMax:  0.5f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackAnimatronic(Master.EventExposer masterEventExposer, TheGame.GameDisplayData.DisplayType currentMode, Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems systems, AnimatronicEntity.AnimatronicEntity entity, Animatronics.Animatronic3d.IAnimatronic3D model, Game.ItemDefinition.Data.DataDefinitions.AttackProfile attackProfile)
        {
            IntPtr val_22;
            IntPtr val_24;
            IntPtr val_26;
            var val_28;
            val_1 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this._currentMode = currentMode;
            this._systems = val_1;
            this._entity = entity;
            this._model = model;
            this._attackProfile = attackProfile;
            var val_20 = 0;
            val_20 = val_20 + 1;
            model.Setup(cpuData:  entity.animatronicConfigData.CpuData, plushSuitData:  this._entity.animatronicConfigData.PlushSuitData, attackProfile:  this._attackProfile, audioMode:  2, masterEventExposer:  masterEventExposer, displayMode:  currentMode, cameraStableTransform:  this._systems.CameraStableTransform);
            System.Action<UnityEngine.AnimationEvent> val_7 = null;
            val_22 = System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::AnimationGameEventReceived(UnityEngine.AnimationEvent animationEvent);
            val_7 = new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  val_22);
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = 55;
            this._model.RegisterForAnimationGameEvents(eventReceived:  val_7);
            System.Action val_9 = null;
            val_24 = System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::Update();
            val_9 = new System.Action(object:  this, method:  val_24);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_24 = 57;
            this._model.RegisterUpdateCallback(update:  val_9);
            Footsteps.FootstepEffectTriggered val_11 = null;
            val_26 = System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::FootstepEffectTriggered(bool isWalking);
            val_11 = new Footsteps.FootstepEffectTriggered(object:  this, method:  val_26);
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_26 = 50;
            val_28 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetFootstepEffectCallback(Animatronics.Animatronic3d.Model.Movement.Footsteps.FootstepEffectTriggered callback);
            this._model.SetFootstepEffectCallback(callback:  val_11);
            int val_24 = this._entity.wearAndTear;
            val_24 = 100 - val_24;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_28 = 28;
            this._model.SetWearAndTear(value:  val_24);
            this.InitializeBlackboard();
            Game.AttackSequence.Animatronic.PhaseManagement.PhaseChooser val_16 = new Game.AttackSequence.Animatronic.PhaseManagement.PhaseChooser();
            ._masterEventExposer = this._masterEventExposer;
            ._readyForCleanupCallback = new System.Action(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::ReadyForCleanup());
            this._phaseChooser = val_16;
            val_16.Setup(blackboard:  this._blackboard);
            this._systems.AttackStatic.<Container>k__BackingField.RegisterStaticSource(entityId:  this.EntityId);
            this._masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._masterEventExposer.add_ShockerActivated(value:  new System.Action<Game.CameraEquipment.Shocker.ShockerActivation>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::ShockerActivated(Game.CameraEquipment.Shocker.ShockerActivation shockerActivation)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeBlackboard()
        {
            var val_9;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_10;
            Game.AttackSequence.Animatronic.PhaseManagement.Blackboard val_1 = new Game.AttackSequence.Animatronic.PhaseManagement.Blackboard();
            if(val_1 != null)
            {
                    .<NumShocksRemaining>k__BackingField = this._attackProfile.NumShocksToDefeat;
                .<EntityId>k__BackingField = this.EntityId;
                val_9 = this;
                .<Model>k__BackingField = this._model;
                val_10 = this._systems;
            }
            else
            {
                    mem[16] = this._attackProfile.NumShocksToDefeat;
                mem[24] = this.EntityId;
                mem[32] = this._model;
                val_9 = this;
                val_10 = this._systems;
            }
            
            .<Systems>k__BackingField = val_10;
            .<IsExpressDelivery>k__BackingField = this._entity.stateData.expressDelivery;
            .<StaticConfig>k__BackingField = this._systems.AttackStatic.<Configs>k__BackingField.GetStaticConfig(profileId:  this._attackProfile.StaticProfile);
            .<AttackProfile>k__BackingField = this._attackProfile;
            .<HaywireState>k__BackingField = new Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState(config:  this._attackProfile.Haywire);
            this._blackboard = val_1;
            this.UpdateBlackboard();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestDestruction()
        {
            this._phaseChooser.SetPhase(newPhase:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            IntPtr val_9;
            IntPtr val_11;
            this._masterEventExposer.remove_ShockerActivated(value:  new System.Action<Game.CameraEquipment.Shocker.ShockerActivation>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::ShockerActivated(Game.CameraEquipment.Shocker.ShockerActivation shockerActivation)));
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._systems.AttackStatic.<Container>k__BackingField.DeregisterStaticSource(entityId:  this.EntityId);
            this._phaseChooser.Teardown();
            this._phaseChooser = 0;
            this._blackboard.<Model>k__BackingField = 0;
            this._blackboard.<Systems>k__BackingField = 0;
            this._blackboard.<AttackProfile>k__BackingField = 0;
            this._blackboard.<HaywireState>k__BackingField = 0;
            this._blackboard.<StaticConfig>k__BackingField = 0;
            this._attackProfile = 0;
            this._blackboard = 0;
            System.Action val_4 = null;
            val_9 = System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::Update();
            val_4 = new System.Action(object:  this, method:  val_9);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = 58;
            this._model.UnregisterUpdateCallback(update:  val_4);
            System.Action<UnityEngine.AnimationEvent> val_6 = null;
            val_11 = System.Void Game.AttackSequence.Animatronic.AttackAnimatronic::AnimationGameEventReceived(UnityEngine.AnimationEvent animationEvent);
            val_6 = new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  val_11);
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = 56;
            this._model.UnregisterFromAnimationGameEvents(eventReceived:  val_6);
            var val_11 = 0;
            val_11 = val_11 + 1;
            this._model.Teardown();
            this._masterEventExposer = 0;
            mem[1152921525451571616] = 0;
            this._model = 0;
            this._systems = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateBlackboard();
            this._phaseChooser.Update();
            if((this._blackboard.<FreezeStaticAngle>k__BackingField) == false)
            {
                goto label_5;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_11;
            label_5:
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_16;
            label_11:
            float val_3 = this._model.GetAbsoluteAngleBetweenPositionAndCamera(position:  new UnityEngine.Vector3() {x = this._blackboard.<FrozenStaticPosition>k__BackingField, y = V9.16B, z = V10.16B});
            goto label_17;
            label_16:
            label_17:
            this._systems.AttackStatic.<Container>k__BackingField.UpdateStaticSourceAngle(entityId:  this.EntityId, angle:  this._model.GetAbsoluteAngleFromCamera());
            if(this._readyForCleanup == false)
            {
                    return;
            }
            
            this.PerformCleanup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReadyForCleanup()
        {
            this._readyForCleanup = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PerformCleanup()
        {
            this._entity.AttackSequenceData.attackSequenceComplete = true;
            if(this.OnReadyForCleanup == null)
            {
                    return;
            }
            
            this.OnReadyForCleanup.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AttackAnimatronic()
        {
            Game.AttackSequence.Animatronic.AttackAnimatronic.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
