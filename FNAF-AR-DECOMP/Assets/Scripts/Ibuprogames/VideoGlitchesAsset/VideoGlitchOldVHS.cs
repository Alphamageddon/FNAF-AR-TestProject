using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchOldVHS : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float waving;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float noise;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float stripeCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float stripeVelocity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float stripeStrength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float stripeNoise;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float switchingNoise;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float acBeatWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float acBeatVelocity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float bloomPasses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableWaving = "_Waving";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableNoise = "_Noise";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableStripeCount = "_StripeCount";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableStripeVelocity = "_StripeVelocity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableStripeStrength = "_StripeStrength";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableStripeNoise = "_StripeNoise";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSwitchingNoise = "_SwitchingNoise";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableACBeatWidth = "_ACBeatWidth";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableACBeatVelocity = "_ACBeatVelocity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableBloomPasses = "_BloomPasses";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Waving { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Noise { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StripeCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StripeVelocity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StripeStrength { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StripeNoise { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SwitchingNoise { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ACBeatWidth { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ACBeatVelocity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BloomPasses { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Waving()
        {
            return (float)this.waving;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Waving(float value)
        {
            this.waving = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Noise()
        {
            return (float)this.noise;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Noise(float value)
        {
            this.noise = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_StripeCount()
        {
            return (float)this.stripeCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StripeCount(float value)
        {
            this.stripeCount = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_StripeVelocity()
        {
            return (float)this.stripeVelocity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StripeVelocity(float value)
        {
            this.stripeVelocity = UnityEngine.Mathf.Clamp(value:  value, min:  -10f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_StripeStrength()
        {
            return (float)this.stripeStrength;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StripeStrength(float value)
        {
            this.stripeStrength = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_StripeNoise()
        {
            return (float)this.stripeNoise;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StripeNoise(float value)
        {
            this.stripeNoise = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_SwitchingNoise()
        {
            return (float)this.switchingNoise;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SwitchingNoise(float value)
        {
            this.switchingNoise = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ACBeatWidth()
        {
            return (float)this.acBeatWidth;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ACBeatWidth(float value)
        {
            this.acBeatWidth = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ACBeatVelocity()
        {
            return (float)this.acBeatVelocity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ACBeatVelocity(float value)
        {
            this.acBeatVelocity = UnityEngine.Mathf.Clamp(value:  value, min:  -10f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_BloomPasses()
        {
            return (float)this.bloomPasses;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BloomPasses(float value)
        {
            this.bloomPasses = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Old broken VHS recorder.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.waving = ;
            this.noise = ;
            this.stripeCount = 2f;
            this.stripeVelocity = 1.2f;
            this.acBeatVelocity = 0.2f;
            this.bloomPasses = 5f;
            this.stripeStrength = ;
            this.stripeNoise = ;
            this.switchingNoise = 0.5f;
            this.acBeatWidth = 0.6f;
            mem[1152921520046116480] = 998445679;
            mem[1152921520046116424] = 1065353216;
            mem[1152921520046116452] = 1065353216;
            mem[1152921520046116484] = 1;
            mem[1152921520046116436] = ;
            mem[1152921520046116488] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Waving", value:  this.waving);
            SetFloat(name:  "_Noise", value:  this.noise);
            float val_1 = 6f;
            val_1 = this.stripeCount * val_1;
            SetFloat(name:  "_StripeCount", value:  val_1);
            SetFloat(name:  "_StripeVelocity", value:  this.stripeVelocity);
            float val_2 = 10f;
            val_2 = this.stripeStrength * val_2;
            SetFloat(name:  "_StripeStrength", value:  val_2);
            float val_3 = 500f;
            val_3 = this.stripeNoise * val_3;
            SetFloat(name:  "_StripeNoise", value:  val_3);
            SetFloat(name:  "_SwitchingNoise", value:  this.switchingNoise);
            SetFloat(name:  "_ACBeatWidth", value:  this.acBeatWidth);
            SetFloat(name:  "_ACBeatVelocity", value:  this.acBeatVelocity);
            SetFloat(name:  "_BloomPasses", value:  this.bloomPasses);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchOldVHS()
        {
            this.waving = ;
            this.noise = ;
            this.stripeCount = 8f;
            this.stripeVelocity = 1.2f;
            this.stripeStrength = ;
            this.stripeNoise = ;
            this.switchingNoise = 0.5f;
            this.acBeatWidth = 0.6f;
            this.acBeatVelocity = 0.2f;
            this.bloomPasses = 5f;
        }
    
    }

}
