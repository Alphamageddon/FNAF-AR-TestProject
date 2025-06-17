using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StateTracker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<AnimatronicEntity.StateData.AnimatronicState, System.Collections.Generic.HashSet<AnimatronicEntity.AnimatronicEntity>> animatronicStateToAnimatronicEntityIds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private StateTracker()
        {
            this.animatronicStateToAnimatronicEntityIds = new System.Collections.Generic.Dictionary<AnimatronicState, System.Collections.Generic.HashSet<AnimatronicEntity.AnimatronicEntity>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StateTracker(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this.animatronicStateToAnimatronicEntityIds = new System.Collections.Generic.Dictionary<AnimatronicState, System.Collections.Generic.HashSet<AnimatronicEntity.AnimatronicEntity>>();
            this._animatronicEntityDomain = animatronicEntityDomain;
            this.SubscribeToEvents();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SubscribeToEvents()
        {
            this._animatronicEntityDomain.eventExposer.add_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void AnimatronicEntity.StateTracker::EventExposer_OnOnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._animatronicEntityDomain.eventExposer.add_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void AnimatronicEntity.StateTracker::EventExposer_OnOnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)));
            this._animatronicEntityDomain.eventExposer.add_EntityRemovedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void AnimatronicEntity.StateTracker::EventExposer_OnOnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._animatronicEntityDomain.eventExposer.remove_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void AnimatronicEntity.StateTracker::EventExposer_OnOnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._animatronicEntityDomain.eventExposer.remove_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void AnimatronicEntity.StateTracker::EventExposer_OnOnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)));
            this._animatronicEntityDomain.eventExposer.remove_EntityRemovedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void AnimatronicEntity.StateTracker::EventExposer_OnOnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this.animatronicStateToAnimatronicEntityIds.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity[] GetAnimatronicEntitiesForState(AnimatronicEntity.StateData.AnimatronicState animatronicState)
        {
            this.EnsureStateList(animatronicState:  animatronicState);
            return System.Linq.Enumerable.ToArray<AnimatronicEntity.AnimatronicEntity>(source:  this.animatronicStateToAnimatronicEntityIds.Item[animatronicState]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnOnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)
        {
            if(e == null)
            {
                goto label_0;
            }
            
            if(e.entity != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            AnimatronicEntity.StateData val_1 = e.entity.stateData;
            this.RemoveEntityFromState(animatronicEntity:  e.entity, animatronicState:  val_1.<animatronicState>k__BackingField);
            return;
            label_0:
            if(11993091 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnOnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)
        {
            AnimatronicEntity.AnimatronicEntity val_1;
            if(e != null)
            {
                    val_1 = e.entity;
            }
            else
            {
                    val_1 = 11993091;
            }
            
            this.ChangeEntityToNewState(animatronicEntity:  val_1, newAnimatronicState:  e.animatronicState);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnOnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)
        {
            if(e == null)
            {
                goto label_0;
            }
            
            if(e.entity != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            AnimatronicEntity.StateData val_1 = e.entity.stateData;
            this.AddEntityToState(animatronicEntity:  e.entity, animatronicState:  val_1.<animatronicState>k__BackingField);
            return;
            label_0:
            if(11993091 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddEntityToState(AnimatronicEntity.AnimatronicEntity animatronicEntity, AnimatronicEntity.StateData.AnimatronicState animatronicState)
        {
            this.EnsureStateList(animatronicState:  animatronicState);
            bool val_2 = this.animatronicStateToAnimatronicEntityIds.Item[animatronicState].Add(item:  animatronicEntity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnsureStateList(AnimatronicEntity.StateData.AnimatronicState animatronicState)
        {
            if((this.animatronicStateToAnimatronicEntityIds.ContainsKey(key:  animatronicState)) != false)
            {
                    return;
            }
            
            this.animatronicStateToAnimatronicEntityIds.Add(key:  animatronicState, value:  new System.Collections.Generic.HashSet<AnimatronicEntity.AnimatronicEntity>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveEntityFromState(AnimatronicEntity.AnimatronicEntity animatronicEntity, AnimatronicEntity.StateData.AnimatronicState animatronicState)
        {
            bool val_2 = this.animatronicStateToAnimatronicEntityIds.Item[animatronicState].Remove(item:  animatronicEntity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StateData.AnimatronicState FindEntityState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.animatronicStateToAnimatronicEntityIds.Keys.GetEnumerator();
            label_6:
            if(((-1072327416) & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_3 = 0.region;
            if((this.animatronicStateToAnimatronicEntityIds.Item[val_3].Contains(item:  animatronicEntity)) == false)
            {
                goto label_6;
            }
            
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525009356040});
            return (AnimatronicState)val_3;
            label_3:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525009356040});
            System.Exception val_11 = new System.Exception(message:  "Didn\'t find entity in StateTracker - entityId:"("Didn\'t find entity in StateTracker - entityId:") + animatronicEntity.entityId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ChangeEntityToNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity, AnimatronicEntity.StateData.AnimatronicState newAnimatronicState)
        {
            this.RemoveEntityFromState(animatronicEntity:  animatronicEntity, animatronicState:  this.FindEntityState(animatronicEntity:  animatronicEntity));
            this.AddEntityToState(animatronicEntity:  animatronicEntity, animatronicState:  newAnimatronicState);
        }
    
    }

}
