using UnityEngine;

namespace Game.AttackSequence
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackSequenceDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess _sceneLookupTableAccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Animatronic3DDomain _animatronic3DDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.CameraEquipmentDomain _cameraEquipmentDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.ItemDefinitionDomain _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.PlayerStats.PlayerStatsDomain _playerStatsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Initialization.CameraFx _cameraFx;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackSpawner _animatronicSpawner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackDestroyer _animatronicDestroyer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Encounters.Encounter _encounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Static.AttackStatic _attackStatic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.DisruptionMechanic.ShakeDetector _shakeDetector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.DisruptionMechanic.AttackDisruption _attackDisruption;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.SurgeMechanic.AttackSurge _attackSurge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.RewardDispatcher _rewardDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems _systems;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInEncounter()
        {
            if(this._encounter == null)
            {
                    return false;
            }
            
            if(this._encounter._animatronic == null)
            {
                    return (bool)(this._encounter._isInRewardsSequence == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEncounterPlayingOutro()
        {
            if(this._encounter == null)
            {
                    return false;
            }
            
            return (bool)(this._encounter._awaitingUiTrigger == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInShockableEncounter()
        {
            Game.AttackSequence.Animatronic.AttackAnimatronic val_3;
            if(this._encounter == null)
            {
                    return false;
            }
            
            val_3 = this._encounter._animatronic;
            if(val_3 == null)
            {
                    return (bool)(val_3.EncounterType != 3) ? 1 : 0;
            }
            
            return (bool)(val_3.EncounterType != 3) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsDisruptionFullyActive()
        {
            if(this._encounter == null)
            {
                    return false;
            }
            
            if(this._encounter._animatronic == null)
            {
                    if(this._encounter._isInRewardsSequence == false)
            {
                    return false;
            }
            
            }
            
            if(this._attackDisruption == null)
            {
                    return false;
            }
            
            if(this._attackDisruption._isActive == false)
            {
                    return false;
            }
            
            return (bool)(this._attackDisruption._hasReachedMaxStrength == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShockerActivated()
        {
            var val_2;
            if(this._encounter == null)
            {
                goto label_0;
            }
            
            if(this._encounter._animatronic == null)
            {
                    if(this._encounter._isInRewardsSequence == false)
            {
                goto label_4;
            }
            
            }
            
            if((this._attackDisruption == null) || (this._attackDisruption._isActive == false))
            {
                goto label_4;
            }
            
            var val_1 = (this._attackDisruption._hasReachedMaxStrength == true) ? 1 : 0;
            goto label_5;
            label_0:
            label_4:
            val_2 = 0;
            label_5:
            this._encounter.ShockerActivated(isDisruptionFullyActive:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackSequenceDomain(Master.SceneLookupTableAccess sceneLookupTableAccess, Master.EventExposer masterEventExposer, AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain, Animatronics.Animatronic3d.Animatronic3DDomain animatronic3DDomain, Game.CameraEquipment.CameraEquipmentDomain cameraEquipmentDomain, Game.ItemDefinition.ItemDefinitionDomain itemDefinitionDomain, Game.MasterData.MasterDataDomain masterDataDomain, Game.Server.ServerDomain serverDomain, Initialization.CameraFx cameraFx, Game.PlayerStats.PlayerStatsDomain playerStatsDomain)
        {
            val_1 = new System.Object();
            this._sceneLookupTableAccess = sceneLookupTableAccess;
            this._masterEventExposer = val_1;
            this._animatronicEntityDomain = animatronicEntityDomain;
            this._animatronic3DDomain = animatronic3DDomain;
            this._cameraEquipmentDomain = cameraEquipmentDomain;
            this._itemDefinitionDomain = itemDefinitionDomain;
            this._playerStatsDomain = playerStatsDomain;
            this._cameraFx = cameraFx;
            this._masterDataDomain = masterDataDomain;
            this._serverDomain = serverDomain;
            this.Setup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            this._animatronicDestroyer = new Game.AttackSequence.Animatronic.AttackDestroyer();
            this._animatronicSpawner = new Game.AttackSequence.Animatronic.AttackSpawner(masterEventExposer:  this._masterEventExposer, animatronicEntityDomain:  this._animatronicEntityDomain, animatronic3DDomain:  this._animatronic3DDomain, itemDefinitionDomain:  this._itemDefinitionDomain, playerStatsDomain:  this._playerStatsDomain);
            this._encounter = new Game.AttackSequence.Encounters.Encounter(masterEventExposer:  this._masterEventExposer);
            this._attackStatic = new Game.AttackSequence.Static.AttackStatic(masterEventExposer:  this._masterEventExposer, masterDataDomain:  this._masterDataDomain);
            Game.AttackSequence.DisruptionMechanic.ShakeDetector val_5 = new Game.AttackSequence.DisruptionMechanic.ShakeDetector();
            this._shakeDetector = val_5;
            this._attackDisruption = new Game.AttackSequence.DisruptionMechanic.AttackDisruption(masterEventExposer:  this._masterEventExposer, shakeDetector:  val_5);
            this._attackSurge = new Game.AttackSequence.SurgeMechanic.AttackSurge(masterEventExposer:  this._masterEventExposer);
            this._rewardDispatcher = new Game.AttackSequence.RewardDispatcher(masterEventExposer:  this._masterEventExposer, serverDomain:  this._serverDomain);
            this._sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.AttackSequence.AttackSequenceDomain::CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)
        {
            .Camera = cameraSceneLookupTable.ForegroundCamera;
            .CameraStableTransform = cameraSceneLookupTable.StableCameraTransform;
            .Encounter = this._encounter;
            .AttackStatic = this._attackStatic;
            .AttackDisruption = this._attackDisruption;
            .AttackSurge = this._attackSurge;
            if(cameraSceneLookupTable != null)
            {
                    .HaywireFxController = cameraSceneLookupTable.HaywireFxController;
            }
            else
            {
                    .HaywireFxController = 0.HaywireFxController;
            }
            
            .ThreatLevelFxController = cameraSceneLookupTable.ThreatLevelFxController;
            .Battery = this._cameraEquipmentDomain.Battery;
            .Flashlight = this._cameraEquipmentDomain.Flashlight;
            .Mask = this._cameraEquipmentDomain.Mask;
            .Shocker = this._cameraEquipmentDomain.Shocker;
            this._systems = new Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems();
            this._attackStatic._glitchShader = cameraSceneLookupTable.ModifiedGlitchShader;
            this._attackDisruption._fxController = this._cameraFx.disruptionFxController;
            this._attackDisruption._systems = this._systems;
            this._attackSurge._systems = this._systems;
            this._animatronicSpawner.Setup(systems:  this._systems);
            this._animatronicDestroyer.Setup(spawner:  this._animatronicSpawner);
            this._encounter.Setup(spawner:  this._animatronicSpawner, destroyer:  this._animatronicDestroyer, rewardDispatcher:  this._rewardDispatcher, shocker:  this._cameraEquipmentDomain.Shocker);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._systems = 0;
            if(this._rewardDispatcher != null)
            {
                    this._rewardDispatcher.Teardown();
            }
            
            this._rewardDispatcher = 0;
            if(this._attackDisruption != null)
            {
                    this._attackDisruption.Teardown();
            }
            
            this._attackDisruption = 0;
            if(this._attackSurge != null)
            {
                    this._attackSurge.Teardown();
            }
            
            this._attackSurge = 0;
            if(this._encounter != null)
            {
                    this._encounter.Teardown();
            }
            
            this._encounter = 0;
            this._animatronicSpawner.Teardown();
            this._animatronicSpawner = 0;
            this._shakeDetector = 0;
            if(this._attackStatic != null)
            {
                    this._attackStatic.Teardown();
            }
            
            this._attackStatic = 0;
            this._animatronicDestroyer.Teardown();
            this._animatronicDestroyer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._attackStatic != null)
            {
                    this._attackStatic._angleStrength = -1f;
                this._attackStatic._shear = 0f;
                this._attackStatic._audio = 0f;
                this._attackStatic.CalculateUpdateValues();
                this._attackStatic.ApplyUpdateValues();
            }
            
            if(this._shakeDetector != null)
            {
                    this._shakeDetector.Update();
            }
            
            if(this._attackDisruption != null)
            {
                    this._attackDisruption.Update();
            }
            
            if(this._attackSurge == null)
            {
                    return;
            }
            
            this._attackSurge.Update();
        }
    
    }

}
