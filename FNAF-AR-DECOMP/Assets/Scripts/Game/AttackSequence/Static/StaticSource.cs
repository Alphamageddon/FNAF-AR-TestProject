using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticSource
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.AngleStrength BaseAngleStrength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticEffectSettings BaseEffects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.AngleStrength AngleStrength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticEffectSettings Effects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.AngleStrength FlashlightAngleStrength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticEffectSettings FlashlightEffects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.List<Game.AttackSequence.Static.AdditiveSource> AdditiveSources;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ShearModifier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Angle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticSource()
        {
            this.AdditiveSources = new System.Collections.Generic.List<Game.AttackSequence.Static.AdditiveSource>();
        }
    
    }

}
