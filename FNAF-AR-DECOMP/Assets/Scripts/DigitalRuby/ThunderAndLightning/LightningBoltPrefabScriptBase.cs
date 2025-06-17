using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class LightningBoltPrefabScriptBase : LightningBoltScript
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltParameters> batchParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Random random;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats IntervalRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfIntegers CountRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CountProbabilityModifier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats DelayRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats DurationRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats TrunkWidthRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LifeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Generations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ChaosFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ChaosFactorForks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Intensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GlowIntensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GlowWidthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadePercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeInMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeFullyLitMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeOutMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GrowthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EndWidthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Forkedness;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ForkLengthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ForkLengthVariance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ForkEndWidthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningLightParameters LightParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaximumLightsPerBatch;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ManualMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float AutomaticModeSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningCustomTransformDelegate CustomTransformHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Random <RandomOverride>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float nextLightningTimestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float lifeTimeRemaining;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Random RandomOverride { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Random get_RandomOverride()
        {
            return (System.Random)this.<RandomOverride>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_RandomOverride(System.Random value)
        {
            this.<RandomOverride>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalculateNextLightningTimestamp(float offset)
        {
            DigitalRuby.ThunderAndLightning.RangeOfFloats val_3 = this.IntervalRange;
            if(val_3 != S2)
            {
                    val_3 = this.IntervalRange.Random() + offset;
            }
            
            this.nextLightningTimestamp = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CustomTransform(DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo state)
        {
            if(this.CustomTransformHandler == null)
            {
                    return;
            }
            
            this.CustomTransformHandler.Invoke(arg0:  state);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallLightning()
        {
            this.CallLightning(start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallLightning(System.Nullable<UnityEngine.Vector3> start, System.Nullable<UnityEngine.Vector3> end)
        {
            System.Random val_3;
            System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> val_4;
            float val_5;
            val_3 = this.<RandomOverride>k__BackingField;
            if(val_3 == null)
            {
                    val_3 = this.random;
            }
            
            if(this.CountRange < 1)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            goto label_18;
            label_14:
            val_4 = 0;
            if(X21 != 0)
            {
                goto label_15;
            }
            
            goto label_5;
            label_18:
            DigitalRuby.ThunderAndLightning.LightningBoltParameters val_1 = this.CreateParameters();
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            val_5 = this.CountProbabilityModifier;
            if(val_5 >= 0.9999f)
            {
                goto label_10;
            }
            
            val_5 = (float)val_5;
            if(this.CountProbabilityModifier >= val_5)
            {
                goto label_10;
            }
            
            DigitalRuby.ThunderAndLightning.LightningBoltParameters.ReturnParametersToCache(p:  val_1);
            goto label_17;
            label_10:
            if(this.CustomTransformHandler == null)
            {
                goto label_14;
            }
            
            System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> val_2 = null;
            val_4 = val_2;
            val_2 = new System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo>(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBoltPrefabScriptBase::CustomTransform(DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo state));
            if(val_1 != null)
            {
                goto label_15;
            }
            
            label_5:
            label_15:
            val_1.CustomTransform = val_4;
            if((174536736 & 1) != 0)
            {
                    val_1.Start = new UnityEngine.Vector3();
                mem2[0] = ???;
                mem2[0] = ???;
            }
            
            if(( & 1) != 0)
            {
                    val_1.End = new UnityEngine.Vector3();
                mem2[0] = ???;
                mem2[0] = ???;
            }
            
            label_17:
            val_3 = val_3 + 1;
            if(this.CountRange != val_3)
            {
                goto label_18;
            }
            
            label_2:
            this.CreateLightningBoltsNow();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void CreateLightningBoltsNow()
        {
            null = null;
            DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightsPerBatch = this.MaximumLightsPerBatch;
            this.CreateLightningBolts(parameters:  this.batchParameters);
            DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightsPerBatch = DigitalRuby.ThunderAndLightning.LightningBolt.MaximumLightsPerBatch;
            this.batchParameters.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void PopulateParameters(DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            System.Random val_1 = this.<RandomOverride>k__BackingField;
            p.randomOverride = val_1;
            if(val_1 == null)
            {
                    val_1 = p.random;
            }
            
            p.currentRandom = val_1;
            p.Generations = this.Generations;
            p.LifeTime = V0.16B;
            p.ChaosFactor = this.ChaosFactor;
            p.TrunkWidth = V0.16B;
            p.ChaosFactorForks = this.ChaosFactorForks;
            p.Intensity = this.Intensity;
            p.GlowIntensity = this.GlowIntensity;
            p.GlowWidthMultiplier = this.GlowWidthMultiplier;
            p.Forkedness = this.Forkedness;
            p.ForkLengthMultiplier = this.ForkLengthMultiplier;
            p.ForkLengthVariance = this.ForkLengthVariance;
            p.FadePercent = this.FadePercent;
            p.FadeInMultiplier = this.FadeInMultiplier;
            p.FadeOutMultiplier = this.FadeOutMultiplier;
            p.FadeFullyLitMultiplier = this.FadeFullyLitMultiplier;
            p.GrowthMultiplier = this.GrowthMultiplier;
            p.EndWidthMultiplier = this.EndWidthMultiplier;
            p.ForkEndWidthMultiplier = this.ForkEndWidthMultiplier;
            p.DelayRange = this.DelayRange;
            mem2[0] = ???;
            p.LightParameters = this.LightParameters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            DigitalRuby.ThunderAndLightning.RangeOfFloats val_3;
            this.Start();
            val_3 = this.IntervalRange;
            if(val_3 != S1)
            {
                    val_3 = this.IntervalRange.Random() + 0f;
            }
            
            this.nextLightningTimestamp = val_3;
            this.lifeTimeRemaining = (this.LifeTime > 0f) ? this.LifeTime : 3.402823E+38f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            float val_9;
            float val_10;
            this.Update();
            val_9 = this.lifeTimeRemaining - DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime;
            this.lifeTimeRemaining = val_9;
            if(val_9 < 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.gameObject);
            }
            
            val_10 = this.nextLightningTimestamp - DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime;
            this.nextLightningTimestamp = val_10;
            if(val_10 <= 0f)
            {
                    val_9 = this.IntervalRange;
                if(val_9 != S1)
            {
                    val_9 = val_10 + this.IntervalRange.Random();
            }
            
                this.nextLightningTimestamp = val_9;
                if(this.ManualMode != true)
            {
                    this.CallLightning(start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false});
            }
            
            }
            
            if(this.AutomaticModeSeconds <= 0f)
            {
                    return;
            }
            
            val_10 = DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime;
            float val_7 = UnityEngine.Mathf.Max(a:  0f, b:  this.AutomaticModeSeconds - val_10);
            this.AutomaticModeSeconds = val_7;
            this.ManualMode = (val_7 == 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            this.batchParameters.Add(item:  p);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trigger()
        {
            this.Trigger(seconds:  -1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trigger(float seconds)
        {
            this.CallLightning(start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false});
            if(seconds < 0f)
            {
                    return;
            }
            
            this.AutomaticModeSeconds = UnityEngine.Mathf.Max(a:  0f, b:  seconds);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trigger(System.Nullable<UnityEngine.Vector3> start, System.Nullable<UnityEngine.Vector3> end)
        {
            this.CallLightning(start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = start.HasValue}, end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = end.HasValue});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected LightningBoltPrefabScriptBase()
        {
            this.batchParameters = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltParameters>();
            this.random = new System.Random();
            this.IntervalRange = new DigitalRuby.ThunderAndLightning.RangeOfFloats();
            this.CountRange = 4294967297;
            mem[1152921526257358448] = 1039516303;
            this.CountProbabilityModifier = ;
            this.DelayRange = new DigitalRuby.ThunderAndLightning.RangeOfFloats();
            mem2[0] = 1036831949;
            this.Generations = 6;
            mem2[0] = 1033476506;
            this.GlowIntensity = ;
            this.GlowWidthMultiplier = ;
            this.FadePercent = 0.15f;
            this.FadeInMultiplier = 1f;
            this.FadeFullyLitMultiplier = 1f;
            this.FadeOutMultiplier = 1f;
            this.Intensity = 1f;
            mem2[0] = ;
            this.ForkEndWidthMultiplier = 1f;
            this.MaximumLightsPerBatch = 8;
        }
    
    }

}
