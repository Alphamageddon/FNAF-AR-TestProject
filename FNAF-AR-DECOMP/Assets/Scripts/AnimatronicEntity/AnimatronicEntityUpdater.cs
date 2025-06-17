using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntityUpdater
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float MinSaveDelayForPeriodicSaves = 600;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float MinSaveDelayForOnDemandSaves = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <CanAttack>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.FastForwarder _fastForwarder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldSave;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastSave;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> _scavengers;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.IFastForwarder FastForwarder { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanAttack { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.IFastForwarder get_FastForwarder()
        {
            return (AnimatronicEntity.IFastForwarder)this._fastForwarder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_CanAttack()
        {
            return (bool)this.<CanAttack>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CanAttack(bool value)
        {
            this.<CanAttack>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntityUpdater(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this.<CanAttack>k__BackingField = true;
            this._scavengers = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            this._animatronicEntityDomain = animatronicEntityDomain;
            ._animatronicEntityDomain = animatronicEntityDomain;
            this._fastForwarder = new AnimatronicEntity.FastForwarder();
            animatronicEntityDomain._eventExposer.add_EntityFastForwardComplete(value:  new System.Action<AnimatronicEntity.FastForwardCompleteArgs>(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityUpdater::EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs obj)));
            animatronicEntityDomain._eventExposer.add_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityUpdater::AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType obj)));
            animatronicEntityDomain._eventExposer.add_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityUpdater::AttackEncounterEnded()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs obj)
        {
            this.ResetStalkingTimers();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType obj)
        {
            this.<CanAttack>k__BackingField = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterEnded()
        {
            this.ResetStalkingTimers();
            this.<CanAttack>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetStalkingTimers()
        {
            List.Enumerator<T> val_2 = this._animatronicEntityDomain.<container>k__BackingField.GetAllEntities().GetEnumerator();
            do
            {
                label_9:
                if(((-1105389240) & 1) == 0)
            {
                    return;
            }
            
            }
            while(val_3._emailIdsToBeSetToReadOnServer.animatronicState != 1);
            
            0.emailUIDataHandler.timeRemainingInitialized = false;
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleApplicationPause(bool paused)
        {
            if(paused == false)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            if(this._fastForwarder.HasCompleted == false)
            {
                    return;
            }
            
            this.SaveOnDemand();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleApplicationFocus(bool hasFocus)
        {
            if(hasFocus == true)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            if(this._fastForwarder.HasCompleted == false)
            {
                    return;
            }
            
            this.SaveOnDemand();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleApplicationQuit()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            if(this._fastForwarder.HasCompleted == false)
            {
                    return;
            }
            
            this.SaveOnDemand();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateEntities(float deltaTime)
        {
            this.ResetCounters();
            if(this._animatronicEntityDomain._movementNodeDomain.FinishedLoading() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                if(this._fastForwarder.HasCompleted != false)
            {
                    this._animatronicEntityDomain.<stateChooser>k__BackingField.Update();
                this._animatronicEntityDomain.<mover>k__BackingField.UpdateEntities(deltaTime:  deltaTime);
            }
            else
            {
                    this._fastForwarder.Run();
            }
            
            }
            
            this.HandleServerCalls();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetCounters()
        {
            this._scavengers.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleServerCalls()
        {
            var val_4;
            if(this._shouldSave != false)
            {
                    float val_4 = this._lastSave;
                val_4 = val_4 + 600f;
                if(UnityEngine.Time.time > val_4)
            {
                    this.SaveEntities(serverDomain:  this._animatronicEntityDomain._serverDomain);
            }
            
            }
            
            val_4 = 0;
            goto label_4;
            label_9:
            this._animatronicEntityDomain._serverDomain.scavengeRequester.Scavenge(entity:  this._scavengers.Item[0]);
            val_4 = 1;
            label_4:
            if(val_4 < this._scavengers.Count)
            {
                goto label_9;
            }
            
            this.ResetCounters();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanSave(float cooldown)
        {
            float val_3 = this._lastSave;
            val_3 = val_3 + cooldown;
            return (bool)(UnityEngine.Time.time > val_3) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SaveEntities(Game.Server.ServerDomain serverDomain)
        {
            serverDomain.animatronicEntitySaveRequester.Save();
            this._shouldSave = false;
            this._lastSave = UnityEngine.Time.time;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._scavengers.Clear();
            this._fastForwarder._animatronicEntityDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SaveRequest()
        {
            this._shouldSave = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SaveOnDemand()
        {
            float val_2 = this._lastSave;
            val_2 = val_2 + 5f;
            if(UnityEngine.Time.time <= val_2)
            {
                    return;
            }
            
            this.SaveEntities(serverDomain:  this._animatronicEntityDomain._serverDomain);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestScavenge(AnimatronicEntity.AnimatronicEntity entity)
        {
            this._scavengers.Add(item:  entity);
        }
    
    }

}
