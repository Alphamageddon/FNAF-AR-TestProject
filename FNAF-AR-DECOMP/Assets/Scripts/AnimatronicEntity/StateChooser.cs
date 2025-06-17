using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StateChooser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.StateChooser.EntityStateChangedArgs> EntityStateChangedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.IChooseState[] _states;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntityStateChangedEvent(System.Action<AnimatronicEntity.StateChooser.EntityStateChangedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntityStateChangedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityStateChangedEvent != 1152921524993265744);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntityStateChangedEvent(System.Action<AnimatronicEntity.StateChooser.EntityStateChangedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntityStateChangedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityStateChangedEvent != 1152921524993402320);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Broker_EntityMovedEvent(AnimatronicEntity.Mover.EntityMovedArgs e)
        {
            bool val_1 = this.UpdateEntityState(entity:  e.entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StateChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
            AnimatronicEntity.IChooseState[] val_1 = new AnimatronicEntity.IChooseState[15];
            this._states = val_1;
            AnimatronicEntity.FarAwayChooser val_2 = new AnimatronicEntity.FarAwayChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            AnimatronicEntity.StalkingChooser val_3 = new AnimatronicEntity.StalkingChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_7;
            }
            
            if(val_3 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_3 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            this._states[1] = val_3;
            AnimatronicEntity.ApproachingChooser val_4 = new AnimatronicEntity.ApproachingChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_13;
            }
            
            if(val_4 != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(val_4 == null)
            {
                goto label_17;
            }
            
            label_14:
            label_17:
            this._states[2] = val_4;
            AnimatronicEntity.NearPlayerChooser val_5 = new AnimatronicEntity.NearPlayerChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_19;
            }
            
            if(val_5 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(val_5 == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            this._states[3] = val_5;
            AnimatronicEntity.SameRoomChooser val_6 = new AnimatronicEntity.SameRoomChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_25;
            }
            
            if(val_6 != null)
            {
                goto label_26;
            }
            
            goto label_29;
            label_25:
            if(val_6 == null)
            {
                goto label_29;
            }
            
            label_26:
            label_29:
            this._states[4] = val_6;
            AnimatronicEntity.OnDeckChooser val_7 = new AnimatronicEntity.OnDeckChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_31;
            }
            
            if(val_7 != null)
            {
                goto label_32;
            }
            
            goto label_35;
            label_31:
            if(val_7 == null)
            {
                goto label_35;
            }
            
            label_32:
            label_35:
            this._states[7] = val_7;
            AnimatronicEntity.MoveToStalkingRangeChooser val_8 = new AnimatronicEntity.MoveToStalkingRangeChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_37;
            }
            
            if(val_8 != null)
            {
                goto label_38;
            }
            
            goto label_41;
            label_37:
            if(val_8 == null)
            {
                goto label_41;
            }
            
            label_38:
            label_41:
            this._states[9] = val_8;
            AnimatronicEntity.ScavengingChooser val_9 = new AnimatronicEntity.ScavengingChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_43;
            }
            
            if(val_9 != null)
            {
                goto label_44;
            }
            
            goto label_47;
            label_43:
            if(val_9 == null)
            {
                goto label_47;
            }
            
            label_44:
            label_47:
            this._states[10] = val_9;
            AnimatronicEntity.RecallChooser val_10 = new AnimatronicEntity.RecallChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_49;
            }
            
            if(val_10 != null)
            {
                goto label_50;
            }
            
            goto label_53;
            label_49:
            if(val_10 == null)
            {
                goto label_53;
            }
            
            label_50:
            label_53:
            this._states[11] = val_10;
            AnimatronicEntity.SentAwayChooser val_11 = new AnimatronicEntity.SentAwayChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_55;
            }
            
            if(val_11 != null)
            {
                goto label_56;
            }
            
            goto label_59;
            label_55:
            if(val_11 == null)
            {
                goto label_59;
            }
            
            label_56:
            label_59:
            this._states[12] = val_11;
            AnimatronicEntity.BlinkChooser val_12 = new AnimatronicEntity.BlinkChooser(animatronicEntityDomain:  animatronicEntityDomain);
            if(this._states == null)
            {
                goto label_61;
            }
            
            if(val_12 != null)
            {
                goto label_62;
            }
            
            goto label_65;
            label_61:
            if(val_12 == null)
            {
                goto label_65;
            }
            
            label_62:
            label_65:
            this._states[13] = val_12;
            AnimatronicEntity.TravelChooser val_13 = new AnimatronicEntity.TravelChooser();
            ._animatronicEntityDomain = animatronicEntityDomain;
            if(this._states == null)
            {
                goto label_67;
            }
            
            if(val_13 != null)
            {
                goto label_68;
            }
            
            goto label_71;
            label_67:
            if(val_13 == null)
            {
                goto label_71;
            }
            
            label_68:
            label_71:
            this._states[14] = val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEntityStates()
        {
            var val_8 = this;
            List.Enumerator<T> val_3 = this._animatronicEntityDomain.container.GetAllEntities().GetEnumerator();
            label_5:
            if(((-1086978024) & 1) == 0)
            {
                goto label_4;
            }
            
            bool val_5 = this.UpdateEntityState(entity:  0.emailUIDataHandler);
            goto label_5;
            label_4:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524994705432});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UpdateEntityState(AnimatronicEntity.AnimatronicEntity entity)
        {
            AnimatronicEntity.AnimatronicEntity val_8;
            System.Action<EntityStateChangedArgs> val_9;
            var val_10;
            val_8 = entity;
            val_9 = val_8.stateData;
            if((val_1.<animatronicState>k__BackingField) != 6)
            {
                    bool val_2 = val_8.LocationInitialized;
                if(val_2 != true)
            {
                    val_2.InitDataForState(entity:  val_8);
                val_9 = this._animatronicEntityDomain.animatronicEntityUpdater;
                val_9.SaveRequest();
            }
            
                if((this.ChooseCorrectStateForEntity(entity:  val_8)) != false)
            {
                    val_9 = this.EntityStateChangedEvent;
                var val_5 = (val_9 != 0) ? 1 : 0;
                if(val_9 == null)
            {
                    return (bool)val_10;
            }
            
                .entity = val_8;
                val_8 = val_8.stateData;
                .animatronicState = val_7.<animatronicState>k__BackingField;
                val_9.Invoke(obj:  new StateChooser.EntityStateChangedArgs());
                return (bool)val_10;
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanupDestroyed()
        {
            var val_6;
            var val_16;
            var val_17;
            val_16 = this;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_1 = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            val_17 = this._animatronicEntityDomain.container.GetAllEntities();
            List.Enumerator<T> val_4 = val_17.GetEnumerator();
            label_9:
            if(((-1086614800) & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_7 = val_6.emailUIDataHandler;
            AnimatronicEntity.StateData val_8 = val_7.stateData;
            if((val_8.<animatronicState>k__BackingField) != 6)
            {
                goto label_9;
            }
            
            val_1.Add(item:  val_7);
            goto label_9;
            label_4:
            List.Enumerator<T> val_11 = val_1.GetEnumerator();
            label_21:
            if(((-1086614800) & 1) == 0)
            {
                goto label_18;
            }
            
            this._animatronicEntityDomain.container.RemoveEntity(entity:  val_6.emailUIDataHandler);
            goto label_21;
            label_18:
            long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524995068656});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ChooseCorrectStateForEntity(AnimatronicEntity.AnimatronicEntity entity)
        {
            var val_4;
            AnimatronicState val_5;
            var val_6;
            var val_8;
            val_4 = this;
            AnimatronicEntity.StateData val_1 = entity.stateData;
            val_5 = val_1.<animatronicState>k__BackingField;
            if(val_5 >= this._states.Length)
            {
                    val_6 = 0;
            }
            
            if(this._states[val_5] != null)
            {
                    if(val_5 >= this._states.Length)
            {
                    val_6 = 0;
            }
            
                val_5 = this._states[val_5];
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = 0;
                if((val_5.DidChooseNewState(entity:  entity)) != false)
            {
                    if(entity.StateChanged != null)
            {
                    entity.StateChanged.Invoke();
            }
            
                val_4 = this._animatronicEntityDomain.animatronicEntityUpdater;
                val_4.SaveRequest();
                val_8 = 1;
                return (bool)val_8;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Init()
        {
            this._animatronicEntityDomain.eventExposer.add_EntityMovedEvent(value:  new System.Action<EntityMovedArgs>(object:  this, method:  System.Void AnimatronicEntity.StateChooser::Broker_EntityMovedEvent(AnimatronicEntity.Mover.EntityMovedArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataForState(AnimatronicEntity.AnimatronicEntity entity)
        {
            AnimatronicEntity.StateData val_1 = entity.stateData;
            if((val_1.<animatronicState>k__BackingField) <= 3)
            {
                goto label_2;
            }
            
            if((val_1.<animatronicState>k__BackingField) == 12)
            {
                goto label_3;
            }
            
            if((val_1.<animatronicState>k__BackingField) != 10)
            {
                goto label_7;
            }
            
            entity.InitDataForScavengeState();
            return;
            label_2:
            if((val_1.<animatronicState>k__BackingField) == 0)
            {
                goto label_6;
            }
            
            if((val_1.<animatronicState>k__BackingField) == 3)
            {
                    entity.InitDataForNearPlayerState();
                return;
            }
            
            label_7:
            entity.InitDataGeneric();
            return;
            label_3:
            entity.InitDataForSentAwayState();
            return;
            label_6:
            entity.InitDataForFarAwayState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateEntityStates();
            this.CleanupDestroyed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterStateChangedEvent(System.Action<AnimatronicEntity.StateChooser.EntityStateChangedArgs> callback)
        {
            this.EntityStateChangedEvent = callback;
        }
    
    }

}
