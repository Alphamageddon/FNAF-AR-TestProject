using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Container
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> OnEntityAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> OnEntityRemovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Container.EntitiesClearedArgs> OnEntitiesClearedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> _animatronicEntities;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> _fakeAnimatronicEntities;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<AnimatronicEntity.AnimatronicEntity> AnimatronicEntities { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<AnimatronicEntity.AnimatronicEntity> FakeAnimatronicEntities { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEntityAddedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEntityAddedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntityAddedEvent != 1152921525002702720);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEntityAddedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEntityAddedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntityAddedEvent != 1152921525002839296);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEntityRemovedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEntityRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntityRemovedEvent != 1152921525002975880);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEntityRemovedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEntityRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntityRemovedEvent != 1152921525003112456);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEntitiesClearedEvent(System.Action<AnimatronicEntity.Container.EntitiesClearedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEntitiesClearedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntitiesClearedEvent != 1152921525003249040);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEntitiesClearedEvent(System.Action<AnimatronicEntity.Container.EntitiesClearedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEntitiesClearedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntitiesClearedEvent != 1152921525003385616);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<AnimatronicEntity.AnimatronicEntity> get_AnimatronicEntities()
        {
            return (System.Collections.Generic.IEnumerable<AnimatronicEntity.AnimatronicEntity>)this._animatronicEntities;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<AnimatronicEntity.AnimatronicEntity> get_FakeAnimatronicEntities()
        {
            return (System.Collections.Generic.IEnumerable<AnimatronicEntity.AnimatronicEntity>)this._fakeAnimatronicEntities;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntity GetFirstAnimatronic()
        {
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_3;
            var val_4;
            val_3 = this;
            if(this._animatronicEntities.Count >= 1)
            {
                    val_3 = this._animatronicEntities;
                AnimatronicEntity.AnimatronicEntity val_2 = val_3.Item[0];
                return (AnimatronicEntity.AnimatronicEntity)val_4;
            }
            
            val_4 = 0;
            return (AnimatronicEntity.AnimatronicEntity)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntity GetAnimatronicClosestToAttackPhase(AnimatronicEntity.AnimatronicEntity animatronicEntity, int highestPhase)
        {
            var val_5;
            var val_6;
            val_5 = animatronicEntity;
            val_6 = 1;
            goto label_1;
            label_4:
            AnimatronicEntity.AnimatronicEntity val_1 = this._animatronicEntities.Item[1];
            val_6 = 2;
            label_1:
            if(val_6 < this._animatronicEntities.Count)
            {
                goto label_4;
            }
            
            return (AnimatronicEntity.AnimatronicEntity)((val_1.IsCloserPhase(entity:  val_1, highestPhase:  highestPhase)) != true) ? (val_1) : (val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCloserPhase(AnimatronicEntity.AnimatronicEntity entity, int highestPhase)
        {
            var val_3;
            if(highestPhase != 6)
            {
                    return (bool)((entity.<stateData>k__BackingField.animatronicState) > highestPhase) ? 1 : 0;
            }
            
            val_3 = 1;
            return (bool)((entity.<stateData>k__BackingField.animatronicState) > highestPhase) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> GetAllEntities()
        {
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_1 = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            val_1.AddRange(collection:  this._animatronicEntities);
            val_1.AddRange(collection:  this._fakeAnimatronicEntities);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity GetAnimatronicClosestToPlayer()
        {
            AnimatronicEntity.AnimatronicEntity val_1 = this.GetFirstAnimatronic();
            if(val_1 == null)
            {
                    return val_1;
            }
            
            return this.GetAnimatronicClosestToAttackPhase(animatronicEntity:  val_1, highestPhase:  val_1.<stateData>k__BackingField.animatronicState);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetFakeID(string id)
        {
            object[] val_1 = new object[4];
            val_1[0] = "fake_";
            val_1[1] = id;
            val_1[2] = "_";
            val_1[3] = this._fakeAnimatronicEntities.Count;
            return (string)+val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEmpty()
        {
            return (bool)(this._animatronicEntities.Count == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumEntities()
        {
            if(this._animatronicEntities != null)
            {
                    return this._animatronicEntities.Count;
            }
            
            return this._animatronicEntities.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsEntity(string entityId)
        {
            string val_8;
            var val_9;
            val_8 = entityId;
            List.Enumerator<T> val_2 = this.GetAllEntities().GetEnumerator();
            label_4:
            if(((-1076839208) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            if((System.String.op_Equality(a:  val_3._emailIdsToBeDeletedOnServer, b:  val_8)) == false)
            {
                goto label_4;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525004844248});
            val_9 = 1;
            return (bool)val_9;
            label_2:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525004844248});
            val_9 = 0;
            return (bool)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity GetEntity(string entityId)
        {
            string val_8;
            var val_9;
            val_8 = entityId;
            List.Enumerator<T> val_2 = this.GetAllEntities().GetEnumerator();
            label_4:
            if(((-1076686248) & 1) == 0)
            {
                goto label_2;
            }
            
            val_9 = 0.emailUIDataHandler;
            if((System.String.op_Equality(a:  val_3._emailIdsToBeDeletedOnServer, b:  val_8)) == false)
            {
                goto label_4;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525004997208});
            return (AnimatronicEntity.AnimatronicEntity)val_9;
            label_2:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525004997208});
            val_9 = 0;
            return (AnimatronicEntity.AnimatronicEntity)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity GetScavengingEntity()
        {
            var val_8;
            List.Enumerator<T> val_2 = this.GetAllEntities().GetEnumerator();
            label_5:
            if(((-1076533288) & 1) == 0)
            {
                goto label_2;
            }
            
            val_8 = 0.emailUIDataHandler;
            if(val_3._emailIdsToBeSetToReadOnServer.animatronicState != 10)
            {
                goto label_5;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525005150168});
            return (AnimatronicEntity.AnimatronicEntity)val_8;
            label_2:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525005150168});
            val_8 = 0;
            return (AnimatronicEntity.AnimatronicEntity)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddEntity(AnimatronicEntity.AnimatronicEntity entity)
        {
            this._animatronicEntities.Add(item:  entity);
            if(this.OnEntityAddedEvent == null)
            {
                    return;
            }
            
            .entity = entity;
            this.OnEntityAddedEvent.Invoke(obj:  new Container.EntityAddedRemovedArgs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFakeEntity(AnimatronicEntity.AnimatronicEntity entity)
        {
            this._fakeAnimatronicEntities.Add(item:  entity);
            if(this.OnEntityAddedEvent == null)
            {
                    return;
            }
            
            .entity = entity;
            this.OnEntityAddedEvent.Invoke(obj:  new Container.EntityAddedRemovedArgs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveEntity(AnimatronicEntity.AnimatronicEntity entity)
        {
            if((this._animatronicEntities.Contains(item:  entity)) != false)
            {
                    bool val_2 = this._animatronicEntities.Remove(item:  entity);
                if(this.OnEntityRemovedEvent != null)
            {
                    .entity = entity;
                this.OnEntityRemovedEvent.Invoke(obj:  new Container.EntityAddedRemovedArgs());
            }
            
            }
            
            if((this._fakeAnimatronicEntities.Contains(item:  entity)) == false)
            {
                    return;
            }
            
            bool val_5 = this._fakeAnimatronicEntities.Remove(item:  entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            this._animatronicEntities.Clear();
            this._fakeAnimatronicEntities.Clear();
            if(this.OnEntitiesClearedEvent == null)
            {
                    return;
            }
            
            this.OnEntitiesClearedEvent.Invoke(obj:  new Container.EntitiesClearedArgs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterEntityAdded(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> callback)
        {
            this.OnEntityAddedEvent = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterEntityRemoved(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> callback)
        {
            this.OnEntityRemovedEvent = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterEntitiesCleared(System.Action<AnimatronicEntity.Container.EntitiesClearedArgs> callback)
        {
            this.OnEntitiesClearedEvent = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Container()
        {
            this._animatronicEntities = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            this._fakeAnimatronicEntities = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
        }
    
    }

}
