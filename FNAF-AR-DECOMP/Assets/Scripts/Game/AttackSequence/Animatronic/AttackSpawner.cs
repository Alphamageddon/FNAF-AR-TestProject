using UnityEngine;

namespace Game.AttackSequence.Animatronic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackSpawner
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic> OnAnimatronicSpawned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.IAnimatronic3DDomain _animatronic3DDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.PlayerStats.PlayerStatsContainer _playerStatsData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _currentMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems _systems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Queue<AnimatronicEntity.AnimatronicEntity> _waitingSpawns;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntity _spawningEntity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _gameReadyForAnimatronics;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAnimatronicSpawned(System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAnimatronicSpawned, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicSpawned != 1152921525453343088);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAnimatronicSpawned(System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAnimatronicSpawned, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicSpawned != 1152921525453479664);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackAnimatronicContainerEmpty()
        {
            this.TryToSpawn();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameReadyForAnimatronics()
        {
            this._gameReadyForAnimatronics = true;
            this.TryToSpawn();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            this._currentMode = args.currentDisplay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs args)
        {
            var val_16;
            var val_17;
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_4 = this._animatronicEntityDomain.container.AnimatronicEntities.GetEnumerator();
            label_19:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            this.SpawnIfClose(entity:  val_4.Current);
            goto label_19;
            label_13:
            val_16 = 0;
            val_17 = 58;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_4.Dispose();
            }
            
            if( == 58)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_16 = ???;
            val_17 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs args)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(this._animatronicEntityDomain.animatronicEntityUpdater.FastForwarder.HasCompleted == false)
            {
                    return;
            }
            
            this.SpawnIfClose(entity:  args.entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs args)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(this._animatronicEntityDomain.animatronicEntityUpdater.FastForwarder.HasCompleted == false)
            {
                    return;
            }
            
            this.SpawnIfClose(entity:  args.entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool EntityIdIsDuplicate(AnimatronicEntity.AnimatronicEntity entity)
        {
            if((System.String.op_Equality(a:  this._systems.Encounter.EntityInEncounter, b:  entity.entityId)) == true)
            {
                    return true;
            }
            
            if(this._spawningEntity == entity)
            {
                    return true;
            }
            
            if(this._waitingSpawns != null)
            {
                    return this._waitingSpawns.Contains(item:  entity);
            }
            
            return this._waitingSpawns.Contains(item:  entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnIfClose(AnimatronicEntity.AnimatronicEntity entity)
        {
            if((this.EntityIdIsDuplicate(entity:  entity)) == true)
            {
                    return;
            }
            
            if(entity.stateData.animatronicState != 3)
            {
                    return;
            }
            
            this._waitingSpawns.Enqueue(item:  entity);
            this.TryToSpawn();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToSpawn()
        {
            var val_6;
            if(this._gameReadyForAnimatronics == false)
            {
                    return;
            }
            
            if(this._systems.Encounter._animatronic != null)
            {
                    return;
            }
            
            if(this._systems.Encounter._isInRewardsSequence == true)
            {
                    return;
            }
            
            if(this._spawningEntity != null)
            {
                    return;
            }
            
            if(this._waitingSpawns.Count == 0)
            {
                    return;
            }
            
            AnimatronicEntity.AnimatronicEntity val_2 = this._waitingSpawns.Dequeue();
            this._spawningEntity = val_2;
            Animatronics.Animatronic3d.CreationRequest val_3 = new Animatronics.Animatronic3d.CreationRequest(entity:  val_2, parent:  0);
            val_6 = 0;
            val_3.add_OnRequestComplete(value:  new System.Action<Animatronics.Animatronic3d.CreationRequest>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::LoadComplete(Animatronics.Animatronic3d.CreationRequest result)));
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 0;
            this._animatronic3DDomain.CreateAnimatronic3D(request:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadComplete(Animatronics.Animatronic3d.CreationRequest result)
        {
            var val_30;
            AnimatronicEntity.AnimatronicEntity val_31;
            var val_32;
            if(result.Animatronic3D == null)
            {
                goto label_2;
            }
            
            if(result.Entity != this._spawningEntity)
            {
                    val_30 = null;
                val_30 = null;
                ConsoleLogger.LogError(className:  Game.AttackSequence.Animatronic.AttackSpawner.ClassName, functionName:  "LoadComplete", logString:  "Animatronic3D for " + result.Entity.entityId + " loaded, but does not match " + this._spawningEntity.entityId);
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Single> val_11 = this._itemDefinitions.GetModifiersForAttackProfile(endoskeleton:  result.Entity.endoskeletonData, wearAndTear:  result.Entity.wearAndTear);
            this.AddRemnantShockWindowModifier(mods:  val_11);
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_13 = result.ConfigData.CpuData;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_14 = this._itemDefinitions.GetAttackProfile(profileId:  val_13.AttackProfile);
            if(result == null)
            {
                goto label_21;
            }
            
            val_31 = result.Entity;
            goto label_22;
            label_2:
            val_32 = null;
            val_32 = null;
            ConsoleLogger.LogError(className:  Game.AttackSequence.Animatronic.AttackSpawner.ClassName, functionName:  "LoadComplete", logString:  "Animatronic3D failed to load for " + result.Entity.entityId + ". Cannot spawn AttackAnimatronic");
            return;
            label_21:
            val_31 = 0.Entity;
            label_22:
            if(result.Entity.AttackSequenceData.encounterStartTime == 0)
            {
                    result.Entity.AttackSequenceData.encounterStartTime = TheGame.ServerTime.GetCurrentTime();
                this._animatronicEntityDomain.animatronicEntityUpdater.SaveOnDemand();
            }
            
            this._spawningEntity = 0;
            if(this.OnAnimatronicSpawned == null)
            {
                    return;
            }
            
            this.OnAnimatronicSpawned.Invoke(obj:  new Game.AttackSequence.Animatronic.AttackAnimatronic(masterEventExposer:  this._masterEventExposer, currentMode:  this._currentMode, systems:  this._systems, entity:  val_31, model:  result.Animatronic3D, attackProfile:  val_14.ApplyModsToAttackProfile(attackProfile:  val_14, modEffects:  val_11)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddRemnantShockWindowModifier(System.Collections.Generic.Dictionary<string, float> mods)
        {
            Game.ItemDefinition.Container.RemnantDebuffEntry val_2 = this._itemDefinitions.GetEntryForRemnant(remnant:  this._playerStatsData.GetTotalRemnant());
            if((mods.ContainsKey(key:  "RemnantShockWindow")) != true)
            {
                    mods.Add(key:  "RemnantShockWindow", value:  0f);
            }
            
            mods.set_Item(key:  "RemnantShockWindow", value:  val_2.ShockWindowIncrease);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.AttackProfile ApplyModsToAttackProfile(Game.ItemDefinition.Data.DataDefinitions.AttackProfile attackProfile, System.Collections.Generic.Dictionary<string, float> modEffects)
        {
            return (Game.ItemDefinition.Data.DataDefinitions.AttackProfile)new Game.ItemDefinition.Data.DataDefinitions.AttackProfile(profile:  attackProfile, mods:  modEffects);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackSpawner(Master.EventExposer masterEventExposer, AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain, Utilities.AsyncInterfaceAccess<Animatronics.Animatronic3d.IAnimatronic3DDomain> animatronic3DDomain, Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> itemDefinitionDomain, Utilities.AsyncInterfaceAccess<Game.PlayerStats.IPlayerStatsDomain> playerStatsDomain)
        {
            this._waitingSpawns = new System.Collections.Generic.Queue<AnimatronicEntity.AnimatronicEntity>();
            val_2 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this._animatronicEntityDomain = val_2;
            this._currentMode = 6;
            animatronic3DDomain.GetInterfaceAsync(callback:  new System.Action<Animatronics.Animatronic3d.IAnimatronic3DDomain>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::Animatronic3DDomainReady(Animatronics.Animatronic3d.IAnimatronic3DDomain animatronic3DDomain)));
            itemDefinitionDomain.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::ItemDefinitionDomainReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
            playerStatsDomain.GetInterfaceAsync(callback:  new System.Action<Game.PlayerStats.IPlayerStatsDomain>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::PlayerStatsReady(Game.PlayerStats.IPlayerStatsDomain playerStatsDomain)));
            this._masterEventExposer.add_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::AttackAnimatronicContainerEmpty()));
            this._masterEventExposer.add_GameReadyForAnimatronicsEvent(value:  new System.Action(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::GameReadyForAnimatronics()));
            this._masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::GameDisplayChanged(TheGame.GameDisplayData args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Animatronic3DDomainReady(Animatronics.Animatronic3d.IAnimatronic3DDomain animatronic3DDomain)
        {
            this._animatronic3DDomain = animatronic3DDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ItemDefinitionDomainReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._itemDefinitions = itemDefinitionDomain.ItemDefinitions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayerStatsReady(Game.PlayerStats.IPlayerStatsDomain playerStatsDomain)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._playerStatsData = playerStatsDomain.PlayerStats;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems systems)
        {
            this._systems = systems;
            this._masterEventExposer.add_EntityFastForwardComplete(value:  new System.Action<AnimatronicEntity.FastForwardCompleteArgs>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs args)));
            this._masterEventExposer.add_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::EntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs args)));
            this._masterEventExposer.add_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::EntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::EntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs args)));
            this._masterEventExposer.remove_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::EntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs args)));
            this._masterEventExposer.remove_EntityFastForwardComplete(value:  new System.Action<AnimatronicEntity.FastForwardCompleteArgs>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs args)));
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._masterEventExposer.remove_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackSpawner::AttackAnimatronicContainerEmpty()));
            this._systems = 0;
            this._spawningEntity = 0;
            this._waitingSpawns.Clear();
            mem[1152921525456457104] = 0;
            mem[1152921525456457112] = 0;
            this._masterEventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AttackSpawner()
        {
            Game.AttackSequence.Animatronic.AttackSpawner.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
