using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseGlimpseActivator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly Game.ItemDefinition.Data.DataDefinitions.GlimpseData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly float CloakTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool GlimpseActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseEffect GlimpseEffect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly SimpleTimer Cooldown;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float MaxGlimpseTime { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float get_MaxGlimpseTime()
        {
            float val_1 = this.Config.CloakDelayTime.Max;
            val_1 = this.CloakTime + val_1;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Reset(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            this.GlimpseActive = false;
            0.EndGlimpse(blackboard:  blackboard);
            this.Cooldown.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard, float remainingAvailableTime); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float GetRandomDistance()
        {
            if(this.Config.Distance != null)
            {
                    return UnityEngine.Random.Range(min:  this.Config.Distance.Min, max:  this.Config.Distance.Max);
            }
            
            return UnityEngine.Random.Range(min:  this.Config.Distance.Min, max:  this.Config.Distance.Max);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float GetRandomCloakDelayTime()
        {
            if(this.Config.CloakDelayTime != null)
            {
                    return UnityEngine.Random.Range(min:  this.Config.CloakDelayTime.Min, max:  this.Config.CloakDelayTime.Max);
            }
            
            return UnityEngine.Random.Range(min:  this.Config.CloakDelayTime.Min, max:  this.Config.CloakDelayTime.Max);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float GetRandomExpireTime()
        {
            if(this.Config.ExpireTime != null)
            {
                    return UnityEngine.Random.Range(min:  this.Config.ExpireTime.Min, max:  this.Config.ExpireTime.Max);
            }
            
            return UnityEngine.Random.Range(min:  this.Config.ExpireTime.Min, max:  this.Config.ExpireTime.Max);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void StartCooldown()
        {
            this.Cooldown.StartTimer(time:  UnityEngine.Random.Range(min:  this.Config.Cooldown.Min, max:  this.Config.Cooldown.Max));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void UpdateActiveGlimpseEffect(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            if(this.GlimpseActive == false)
            {
                    return;
            }
            
            if(this.GlimpseEffect._finished != false)
            {
                    this.GlimpseActive = false;
                return;
            }
            
            this.GlimpseEffect.Update(blackboard:  blackboard);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseGlimpseActivator(Game.ItemDefinition.Data.DataDefinitions.GlimpseData config, Animatronics.Animatronic3d.Model.Effects.CloakSettings cloakConfig)
        {
            this.GlimpseEffect = new Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseEffect();
            this.Cooldown = new SimpleTimer();
            val_3 = new System.Object();
            this.Config = config;
            this.CloakTime = cloakConfig.CloakTime;
        }
    
    }

}
