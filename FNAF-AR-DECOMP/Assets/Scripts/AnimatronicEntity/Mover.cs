using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Mover
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Mover.EntityMovedArgs> OnEntityMovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Domain_SROptions _debugOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.IMoveState[] _states;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEntityMovedEvent(System.Action<AnimatronicEntity.Mover.EntityMovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEntityMovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntityMovedEvent != 1152921524985419200);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEntityMovedEvent(System.Action<AnimatronicEntity.Mover.EntityMovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEntityMovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEntityMovedEvent != 1152921524985555776);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
            AnimatronicEntity.IMoveState[] val_1 = new AnimatronicEntity.IMoveState[15];
            this._states = val_1;
            AnimatronicEntity.FarAwayMover val_2 = new AnimatronicEntity.FarAwayMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.StalkingPlayerMover val_3 = new AnimatronicEntity.StalkingPlayerMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.ApproachingPlayerMover val_4 = new AnimatronicEntity.ApproachingPlayerMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.NearPlayerMover val_5 = new AnimatronicEntity.NearPlayerMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.SameRoomMover val_6 = new AnimatronicEntity.SameRoomMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.OnDeckMover val_7 = new AnimatronicEntity.OnDeckMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.MoveToStalkingRangeMover val_8 = new AnimatronicEntity.MoveToStalkingRangeMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.ScavengingMover val_9 = new AnimatronicEntity.ScavengingMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.RecallMover val_10 = new AnimatronicEntity.RecallMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.SentAwayMover val_11 = new AnimatronicEntity.SentAwayMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.BlinkMover val_12 = new AnimatronicEntity.BlinkMover();
            ._animatronicEntityDomain = animatronicEntityDomain;
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
            AnimatronicEntity.TravelMover val_13 = new AnimatronicEntity.TravelMover(animatronicEntityDomain:  animatronicEntityDomain);
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
        public void UpdateEntities(float deltaTime)
        {
            var val_6 = this;
            List.Enumerator<T> val_2 = this._animatronicEntityDomain.<container>k__BackingField.GetAllEntities().GetEnumerator();
            label_5:
            if(((-1094952952) & 1) == 0)
            {
                goto label_4;
            }
            
            this.UpdateEntity(animatronicEntity:  0.emailUIDataHandler, deltaTime:  deltaTime);
            goto label_5;
            label_4:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524986730504});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float deltaTime)
        {
            float val_19;
            AnimatronicEntity.AnimatronicEntity val_20;
            AnimatronicEntity.StateData val_21;
            float val_23;
            float val_25;
            AnimatronicEntity.IMoveState[] val_26;
            var val_27;
            float val_30;
            val_19 = deltaTime;
            val_20 = animatronicEntity;
            val_21 = animatronicEntity.<stateData>k__BackingField;
            if(val_21.animatronicState == 6)
            {
                    return;
            }
            
            if((animatronicEntity.<updateTimerData>k__BackingField) != null)
            {
                    val_23 = animatronicEntity.<updateTimerData>k__BackingField.accumulatedDeltaTime;
            }
            else
            {
                    float val_3 = 0.accumulatedDeltaTime;
                val_23 = val_3;
            }
            
            val_3 = val_23 + val_19;
            animatronicEntity.<updateTimerData>k__BackingField.accumulatedDeltaTime = val_3;
            if((animatronicEntity.<updateTimerData>k__BackingField) != null)
            {
                    val_25 = animatronicEntity.<updateTimerData>k__BackingField.nextUpdateTimer;
            }
            else
            {
                    float val_5 = 0.nextUpdateTimer;
                val_25 = val_5;
            }
            
            val_5 = val_25 - val_19;
            animatronicEntity.<updateTimerData>k__BackingField.nextUpdateTimer = val_5;
            val_19 = animatronicEntity.<updateTimerData>k__BackingField.accumulatedDeltaTime;
            val_26 = this._states;
            val_21 = animatronicEntity.<stateData>k__BackingField.animatronicState;
            if(val_21 >= this._states.Length)
            {
                    val_27 = 0;
            }
            
            if(val_26[(long)val_21] != null)
            {
                    if((animatronicEntity.<updateTimerData>k__BackingField.nextUpdateTimer) > 0f)
            {
                    return;
            }
            
                this.EnsureRange(entity:  val_20);
                if(val_21 >= this._states.Length)
            {
                    val_27 = 0;
            }
            
                var val_22 = 0;
                val_22 = val_22 + 1;
                val_27 = 0;
            }
            else
            {
                    AnimatronicState val_9 = animatronicEntity.<stateData>k__BackingField.animatronicState;
                long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_9});
                val_20 = "Entity is n null state " + val_9.ToString() + " skipping update";
                UnityEngine.Debug.LogError(message:  val_20);
                return;
            }
            
            val_21 = this._states[(long)val_21].DidMoveEntity(entity:  val_20, delta:  val_19);
            animatronicEntity.<updateTimerData>k__BackingField.accumulatedDeltaTime = 0f;
            bool val_16 = AnimatronicEntity.StateData.IsInState(sourceState:  animatronicEntity.<stateData>k__BackingField.animatronicState, stateToCheck:  2);
            if(this._animatronicEntityDomain._animatronicEntityConfig == null)
            {
                goto label_34;
            }
            
            if(val_16 == false)
            {
                goto label_35;
            }
            
            label_39:
            val_30 = this._animatronicEntityDomain._animatronicEntityConfig.approachUpdateFrequencyMinSeconds;
            if(this._animatronicEntityDomain._animatronicEntityConfig != null)
            {
                goto label_38;
            }
            
            goto label_38;
            label_34:
            if(val_16 == true)
            {
                goto label_39;
            }
            
            label_35:
            val_30 = this._animatronicEntityDomain._animatronicEntityConfig.updateFrequencyMinSeconds;
            label_38:
            val_19 = UnityEngine.Random.Range(min:  val_30, max:  this._animatronicEntityDomain._animatronicEntityConfig.updateFrequencyMaxSeconds);
            animatronicEntity.<updateTimerData>k__BackingField.nextUpdateTimer = val_19;
            val_26 = TheGame.ServerTime.GetCurrentTime();
            animatronicEntity.<updateTimerData>k__BackingField.LastUpdateTimestamp = val_26;
            if(val_21 == false)
            {
                    return;
            }
            
            if(this.OnEntityMovedEvent == null)
            {
                    return;
            }
            
            Mover.EntityMovedArgs val_19 = null;
            val_21 = val_19;
            val_19 = new Mover.EntityMovedArgs();
            .entity = val_20;
            .geoPosition = animatronicEntity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField;
            mem[1152921524987296480] = AnimatronicEntity.StateData.__il2cppRuntimeField_cctor_finished;
            val_20 = animatronicEntity.<distanceFromPlayerData>k__BackingField;
            .distanceFromPlayer = animatronicEntity.<distanceFromPlayerData>k__BackingField._distance;
            this.OnEntityMovedEvent.Invoke(obj:  val_19);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnsureRange(AnimatronicEntity.AnimatronicEntity entity)
        {
            AnimatronicEntity.DistanceFromPlayerData val_2;
            float val_3;
            AnimatronicEntity.AnimatronicEntityDomain val_4;
            val_2 = entity.<distanceFromPlayerData>k__BackingField;
            if((entity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) == false)
            {
                    return;
            }
            
            val_3 = entity.<distanceFromPlayerData>k__BackingField._distance;
            val_2 = this._animatronicEntityDomain._animatronicEntityConfig;
            if(val_3 <= this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceTravelMax)
            {
                    return;
            }
            
            val_2 = entity.<geoPositionData>k__BackingField;
            val_4 = this._animatronicEntityDomain;
            if(this._animatronicEntityDomain != null)
            {
                goto label_7;
            }
            
            val_4 = this._animatronicEntityDomain;
            if(val_4 == null)
            {
                goto label_8;
            }
            
            label_7:
            Mapbox.Utils.Vector2d val_1 = this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.TelportToRadius(entity:  entity, radius:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceTravelMax);
            val_3 = val_1.x;
            entity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_1;
            mem2[0] = val_1.y;
            return;
            label_8:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(float deltaTime)
        {
            this.UpdateEntities(deltaTime:  deltaTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterEntityMoved(System.Action<AnimatronicEntity.Mover.EntityMovedArgs> callback)
        {
            this.OnEntityMovedEvent = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mover()
        {
            AnimatronicEntity.Mover.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
