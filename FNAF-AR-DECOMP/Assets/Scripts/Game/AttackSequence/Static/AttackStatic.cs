using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackStatic
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Static.StaticConfigs <Configs>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Static.StaticContainer <Container>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ModifiedGlitchShader _glitchShader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isFlashlightOn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _angleStrength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _shear;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _audio;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticConfigs Configs { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticContainer Container { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticConfigs get_Configs()
        {
            return (Game.AttackSequence.Static.StaticConfigs)this.<Configs>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Configs(Game.AttackSequence.Static.StaticConfigs value)
        {
            this.<Configs>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticContainer get_Container()
        {
            return (Game.AttackSequence.Static.StaticContainer)this.<Container>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Container(Game.AttackSequence.Static.StaticContainer value)
        {
            this.<Container>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
        {
            this._isFlashlightOn = isFlashlightOn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetUpdateValues()
        {
            this._angleStrength = -1f;
            this._shear = 0f;
            this._audio = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalculateUpdateValues()
        {
            var val_5;
            var val_6;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.<Container>k__BackingField.StaticSources.Values.GetEnumerator();
            label_7:
            if(((-648178584) & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            if(val_3._emailDatas == null)
            {
                goto label_7;
            }
            
            this.CalculateAngleStrength(staticSource:  val_3);
            this.AddAdditiveStrengths(staticSource:  val_3);
            goto label_7;
            label_4:
            val_5 = 0;
            val_6 = 1;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525433504872});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalculateAngleStrength(Game.AttackSequence.Static.StaticSource staticSource)
        {
            Game.AttackSequence.Static.AngleStrength val_10;
            if(staticSource != null)
            {
                    val_10 = staticSource.BaseAngleStrength;
            }
            else
            {
                    val_10 = 11993091;
            }
            
            float val_2 = UnityEngine.Mathf.Max(a:  Game.AttackSequence.Static.AngleStrength.CalculateStrength(min:  mem[4306960403], max:  mem[4306960407], actual:  staticSource.Angle), b:  0f);
            float val_10 = staticSource.BaseEffects.Shear;
            val_10 = staticSource.ShearModifier * val_10;
            val_10 = val_2 * val_10;
            this._shear = val_10;
            float val_11 = staticSource.BaseEffects.Audio;
            val_11 = staticSource.ShearModifier * val_11;
            val_11 = val_2 * val_11;
            this._audio = val_11;
            if(this._isFlashlightOn == false)
            {
                goto label_8;
            }
            
            float val_13 = 0f;
            float val_4 = UnityEngine.Mathf.Max(a:  Game.AttackSequence.Static.AngleStrength.CalculateStrength(min:  staticSource.FlashlightAngleStrength._angleMin, max:  staticSource.FlashlightAngleStrength._angleMax, actual:  staticSource.Angle), b:  val_13);
            this._angleStrength = val_4;
            float val_12 = staticSource.FlashlightEffects.Shear;
            val_12 = staticSource.ShearModifier * val_12;
            val_13 = val_4 * val_12;
            this._shear = UnityEngine.Mathf.Max(a:  this._shear, b:  val_13);
            if(staticSource.FlashlightEffects == null)
            {
                goto label_13;
            }
            
            label_18:
            float val_14 = staticSource.ShearModifier;
            val_14 = val_14 * staticSource.FlashlightEffects.Audio;
            val_14 = this._angleStrength * val_14;
            this._audio = UnityEngine.Mathf.Max(a:  this._audio, b:  val_14);
            return;
            label_8:
            float val_16 = 0f;
            float val_8 = UnityEngine.Mathf.Max(a:  Game.AttackSequence.Static.AngleStrength.CalculateStrength(min:  staticSource.AngleStrength._angleMin, max:  staticSource.AngleStrength._angleMax, actual:  staticSource.Angle), b:  val_16);
            this._angleStrength = val_8;
            float val_15 = staticSource.Effects.Shear;
            val_15 = staticSource.ShearModifier * val_15;
            val_16 = val_8 * val_15;
            this._shear = UnityEngine.Mathf.Max(a:  this._shear, b:  val_16);
            if(staticSource.Effects != null)
            {
                goto label_18;
            }
            
            label_13:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddAdditiveStrengths(Game.AttackSequence.Static.StaticSource staticSource)
        {
            int val_5;
            Game.AttackSequence.Static.FadeAndDurationStrength val_6;
            float val_7;
            float val_1 = UnityEngine.Time.time;
            val_5 = staticSource.AdditiveSources.Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                Game.AttackSequence.Static.AdditiveSource val_3 = staticSource.AdditiveSources.Item[val_5];
                val_6 = val_3.Strength;
                if((val_3.Strength._start >= 0) && (val_3.Strength._fadeOutEnd > val_1))
            {
                    val_7 = 1f;
                if(val_3.IsPositional != false)
            {
                    val_7 = this._angleStrength;
            }
            
                val_6 = val_3.EffectSettings;
                float val_5 = val_3.Strength.GetStrength(time:  val_1);
                float val_6 = val_3.EffectSettings.Shear;
                val_5 = val_7 * val_5;
                val_6 = staticSource.ShearModifier * val_6;
                val_6 = val_5 * val_6;
                val_6 = this._shear + val_6;
                this._shear = val_6;
                float val_7 = val_3.EffectSettings.Audio;
                val_7 = staticSource.ShearModifier * val_7;
                val_7 = val_5 * val_7;
                val_7 = this._audio + val_7;
                this._audio = val_7;
            }
            else
            {
                    staticSource.AdditiveSources.RemoveAt(index:  val_5);
            }
            
                val_5 = val_5 - 1;
            }
            while((val_5 & 2147483648) == 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ApplyUpdateValues()
        {
            if(this._glitchShader == 0)
            {
                    return;
            }
            
            this._glitchShader.ShearStrength = this._shear;
            .StaticAudioStrength = UnityEngine.Mathf.Clamp(value:  this._audio, min:  0f, max:  1f);
            this._masterEventExposer.OnStaticSettingsUpdated(staticSettings:  new Game.AttackSequence.Static.StaticSettings());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackStatic(Master.EventExposer masterEventExposer, Game.MasterData.MasterDataDomain masterDataDomain)
        {
            val_1 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this.<Configs>k__BackingField = new Game.AttackSequence.Static.StaticConfigs(masterDataDomain:  Game.MasterData.MasterDataDomain val_1 = masterDataDomain);
            this.<Container>k__BackingField = new Game.AttackSequence.Static.StaticContainer();
            this._masterEventExposer.add_FlashlightStateChanged(value:  new FlashlightState.StateChanged(object:  this, method:  System.Void Game.AttackSequence.Static.AttackStatic::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(ModifiedGlitchShader glitchShader)
        {
            this._glitchShader = glitchShader;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_FlashlightStateChanged(value:  new FlashlightState.StateChanged(object:  this, method:  System.Void Game.AttackSequence.Static.AttackStatic::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)));
            this.<Configs>k__BackingField = 0;
            this._masterEventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this._angleStrength = -1f;
            this._shear = 0f;
            this._audio = 0f;
            this.CalculateUpdateValues();
            this.ApplyUpdateValues();
        }
    
    }

}
