using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FastForwarder : IFastForwarder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasCompleted>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const long TIME_INTERVAL = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int MAX_LOOPS = 360;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _loopCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _frameStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _frameEnd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _end;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _deltaTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> _entities;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _timeInCombat;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasCompleted { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long FrameStartTime { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long FrameEndTime { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasCompleted()
        {
            return (bool)this.<HasCompleted>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasCompleted(bool value)
        {
            this.<HasCompleted>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_FrameStartTime()
        {
            return (long)this._frameStart;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_FrameEndTime()
        {
            return (long)this._frameEnd;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FastForwarder(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._animatronicEntityDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Run()
        {
            if(TheGame.ServerTime.IsInitialized() == false)
            {
                    return;
            }
            
            this.Prepare();
            this.Execute();
            this.Complete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddTimeInCombat(float timeToAdd)
        {
            timeToAdd = this._timeInCombat + timeToAdd;
            this._timeInCombat = timeToAdd;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Prepare()
        {
            this._loopCount = 0;
            this._frameStart = ;
            this._frameEnd = 0;
            this._end = TheGame.ServerTime.GetCurrentTime();
            this._deltaTime = 0;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_2 = this._animatronicEntityDomain.<container>k__BackingField.GetAllEntities();
            this._entities = val_2;
            List.Enumerator<T> val_3 = val_2.GetEnumerator();
            goto label_4;
            label_7:
            long val_5 = 0.emailUIDataHandler.LastUpdateTimestamp;
            this._frameStart = (val_5 < this._frameStart) ? (val_5) : this._frameStart;
            label_4:
            if(((-1096991992) & 1) != 0)
            {
                goto label_7;
            }
            
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524984691464});
            this._timeInCombat = 0f;
            this._frameEnd = this._frameStart;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Execute()
        {
            var val_4;
            var val_11;
            var val_12;
            var val_13;
            long val_10 = this._end;
            if(val_10 <= this._frameEnd)
            {
                    return;
            }
            
            val_11 = 0;
            label_11:
            int val_11 = this._loopCount;
            val_10 = val_10 - this._frameEnd;
            long val_1 = (val_10 > 5) ? (val_10) : 5;
            val_11 = val_11 + 1;
            this._deltaTime = val_1;
            val_1 = val_1 + this._frameEnd;
            this._loopCount = val_11;
            this._frameStart = this._frameEnd;
            this._frameEnd = val_1;
            List.Enumerator<T> val_2 = this._entities.GetEnumerator();
            val_12 = 0;
            goto label_3;
            label_4:
            val_12 = val_12 | (this.UpdateEntity(entity:  val_4.emailUIDataHandler));
            label_3:
            if(((-1096851376) & 1) != 0)
            {
                goto label_4;
            }
            
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524984832080});
            if(((70 == 0) ? 70 : 70) == 70)
            {
                    val_13 = 0;
            }
            
            var val_9 = (this._end > this._frameEnd) ? 1 : 0;
            val_9 = val_12 & val_9;
            if(val_9 == true)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateTimes()
        {
            long val_4 = this._frameEnd;
            long val_2 = this._end;
            int val_3 = this._loopCount;
            val_2 = val_2 - val_4;
            long val_1 = (val_2 > 5) ? (val_2) : 5;
            this._frameStart = val_4;
            val_3 = val_3 + 1;
            val_4 = val_4 + val_1;
            this._loopCount = val_3;
            this._deltaTime = val_1;
            this._frameEnd = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool UpdateEntity(AnimatronicEntity.AnimatronicEntity entity)
        {
            long val_6;
            AnimatronicEntity.StateData val_7;
            var val_8;
            val_6 = this;
            val_7 = entity.<stateData>k__BackingField;
            if(val_7.animatronicState == 6)
            {
                    val_8 = 0;
                return (bool)val_8;
            }
            
            val_7 = entity.<updateTimerData>k__BackingField;
            if(this._frameEnd > val_7.LastUpdateTimestamp)
            {
                    long val_6 = this._frameEnd;
                val_6 = val_6 - (entity.<updateTimerData>k__BackingField.LastUpdateTimestamp);
                bool val_4 = this._animatronicEntityDomain.<stateChooser>k__BackingField.UpdateEntityState(entity:  entity);
                val_7 = this._animatronicEntityDomain.<mover>k__BackingField;
                val_7.UpdateEntity(animatronicEntity:  entity, deltaTime:  (float)(val_6 < this._deltaTime) ? (val_6) : this._deltaTime);
                val_6 = this._frameEnd;
                entity.<updateTimerData>k__BackingField.LastUpdateTimestamp = val_6;
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Complete()
        {
            this.<HasCompleted>k__BackingField = true;
            .TimeSpentInCombat = this._timeInCombat;
            this._animatronicEntityDomain._eventExposer.OnEntityFastForwardComplete(args:  new AnimatronicEntity.FastForwardCompleteArgs());
        }
    
    }

}
