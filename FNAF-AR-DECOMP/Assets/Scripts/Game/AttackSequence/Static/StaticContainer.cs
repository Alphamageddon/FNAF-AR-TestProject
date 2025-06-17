using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.Dictionary<string, Game.AttackSequence.Static.StaticSource> StaticSources;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterStaticSource(string entityId)
        {
            if((this.StaticSources.ContainsKey(key:  entityId)) != false)
            {
                    return;
            }
            
            this.StaticSources.Add(key:  entityId, value:  new Game.AttackSequence.Static.StaticSource());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateStaticSourceAngle(string entityId, float angle)
        {
            string val_3 = entityId;
            if((this.StaticSources.ContainsKey(key:  val_3 = entityId)) == false)
            {
                    return;
            }
            
            val_3 = this.StaticSources.Item[val_3];
            val_2.Angle = angle;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdatePhaseStaticSettings(string entityId, Game.AttackSequence.Static.PhaseStaticSettings settings, float shearModifier)
        {
            Game.AttackSequence.Static.StaticEffectSettings val_6;
            Game.AttackSequence.Static.AngleStrength val_7;
            Game.AttackSequence.Static.StaticEffectSettings val_8;
            Game.AttackSequence.Static.StaticEffectSettings val_9;
            val_6 = settings;
            val_7 = this;
            if((this.StaticSources.ContainsKey(key:  entityId)) == false)
            {
                    return;
            }
            
            Game.AttackSequence.Static.StaticSource val_2 = this.StaticSources.Item[entityId];
            Game.AttackSequence.Static.AngleStrength val_3 = new Game.AttackSequence.Static.AngleStrength(angleRange:  settings.BaseAngle);
            if(val_2 != null)
            {
                    val_2.BaseAngleStrength = val_3;
                val_8 = settings.BaseEffects;
            }
            else
            {
                    mem[16] = val_3;
                val_8 = settings.BaseEffects;
            }
            
            val_2.BaseEffects = val_8;
            Game.AttackSequence.Static.AngleStrength val_4 = new Game.AttackSequence.Static.AngleStrength(angleRange:  settings.Angle);
            if(val_2 != null)
            {
                    val_2.AngleStrength = val_4;
                val_9 = settings.Effects;
            }
            else
            {
                    mem[32] = val_4;
                val_9 = settings.Effects;
            }
            
            val_2.Effects = val_9;
            Game.AttackSequence.Static.AngleStrength val_5 = null;
            val_7 = val_5;
            val_5 = new Game.AttackSequence.Static.AngleStrength(angleRange:  settings.FlashlightAngle);
            if(val_2 != null)
            {
                    val_2.FlashlightAngleStrength = val_7;
                val_2.FlashlightEffects = settings.FlashlightEffects;
            }
            else
            {
                    mem[48] = val_7;
                val_6 = settings.FlashlightEffects;
                mem[56] = val_6;
            }
            
            val_2.ShearModifier = shearModifier;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearPhaseStaticSettings(string entityId)
        {
            string val_3 = entityId;
            if((this.StaticSources.ContainsKey(key:  val_3 = entityId)) == false)
            {
                    return;
            }
            
            val_3 = this.StaticSources.Item[val_3];
            val_2.AngleStrength = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeregisterStaticSource(string entityId)
        {
            if((this.StaticSources.ContainsKey(key:  entityId)) == false)
            {
                    return;
            }
            
            bool val_2 = this.StaticSources.Remove(key:  entityId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFootstepAdditive(string entityId, Game.AttackSequence.Static.AdditiveStaticSettings settings)
        {
            var val_6;
            if((this.StaticSources.ContainsKey(key:  entityId)) == false)
            {
                    return;
            }
            
            Game.AttackSequence.Static.AdditiveSource val_2 = new Game.AttackSequence.Static.AdditiveSource();
            .IsPositional = settings.IsPositional;
            Game.AttackSequence.Static.FadeAndDurationStrength val_3 = new Game.AttackSequence.Static.FadeAndDurationStrength(fadeSettings:  settings.FadeSettings, durationRange:  settings.Duration);
            if(val_2 != null)
            {
                    val_6 = val_2;
                .Strength = val_3;
                mem[1152921525437964432] = settings.Effects;
            }
            else
            {
                    val_6 = 24;
                mem[24] = val_3;
                mem[32] = settings.Effects;
            }
            
            float val_4 = UnityEngine.Time.time;
            float val_6 = mem[1152921525437976704];
            float val_7 = mem[1152921525437976708];
            val_6 = val_4 + val_6;
            mem[1152921525437976716] = val_4;
            mem[1152921525437976720] = val_6;
            val_6 = val_6 + val_7;
            val_7 = val_6 + mem[1152921525437976712];
            mem[1152921525437976724] = val_6;
            mem[1152921525437976728] = val_7;
            Game.AttackSequence.Static.StaticSource val_5 = this.StaticSources.Item[entityId];
            val_5.AdditiveSources.Add(item:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticContainer()
        {
            this.StaticSources = new System.Collections.Generic.Dictionary<System.String, Game.AttackSequence.Static.StaticSource>();
        }
    
    }

}
