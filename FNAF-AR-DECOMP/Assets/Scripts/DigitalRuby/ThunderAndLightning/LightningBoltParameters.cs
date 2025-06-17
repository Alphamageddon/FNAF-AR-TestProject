using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public sealed class LightningBoltParameters
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int randomSeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltParameters> cache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int generationWhereForksStop;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int forkednessCalculated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal DigitalRuby.ThunderAndLightning.LightningBoltQualitySetting quality;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal float delaySeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int maxLights;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float Scale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<int, DigitalRuby.ThunderAndLightning.LightningQualityMaximum> QualityMaximums;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningGenerator Generator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 End;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 StartVariance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EndVariance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> CustomTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int generations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LifeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Delay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats DelayRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ChaosFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ChaosFactorForks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TrunkWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EndWidthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Intensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GlowIntensity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GlowWidthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Forkedness;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerationWhereForksStopSubtractor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color32 Color;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Random random;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Random currentRandom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Random randomOverride;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadePercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeInMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeFullyLitMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FadeOutMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float growthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ForkLengthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ForkLengthVariance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ForkEndWidthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningLightParameters LightParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> <Points>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SmoothingFactor;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Generations { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Random Random { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Random RandomOverride { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GrowthMultiplier { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> Points { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LightningBoltParameters()
        {
            var val_12;
            System.Collections.Generic.Dictionary<TKey, TValue> val_13;
            DigitalRuby.ThunderAndLightning.LightningQualityMaximum val_14;
            var val_15;
            var val_16;
            DigitalRuby.ThunderAndLightning.LightningBoltParameters.randomSeed = System.Environment.TickCount;
            DigitalRuby.ThunderAndLightning.LightningBoltParameters.cache = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltParameters>();
            DigitalRuby.ThunderAndLightning.LightningBoltParameters.Scale = 1f;
            System.Collections.Generic.Dictionary<System.Int32, DigitalRuby.ThunderAndLightning.LightningQualityMaximum> val_3 = new System.Collections.Generic.Dictionary<System.Int32, DigitalRuby.ThunderAndLightning.LightningQualityMaximum>();
            DigitalRuby.ThunderAndLightning.LightningBoltParameters.QualityMaximums = val_3;
            System.String[] val_4 = UnityEngine.QualitySettings.names;
            val_12 = 0;
            goto label_1;
            label_31:
            if(val_12 > 5)
            {
                goto label_2;
            }
            
            val_13 = DigitalRuby.ThunderAndLightning.LightningBoltParameters.QualityMaximums;
            DigitalRuby.ThunderAndLightning.LightningQualityMaximum val_5 = null;
            val_14 = val_5;
            val_5 = new DigitalRuby.ThunderAndLightning.LightningQualityMaximum();
            if(val_14 == null)
            {
                goto label_3;
            }
            
            val_5.MaximumGenerations = 3;
            val_5.MaximumLightPercent = 0f;
            goto label_4;
            label_2:
            val_13 = DigitalRuby.ThunderAndLightning.LightningBoltParameters.QualityMaximums;
            DigitalRuby.ThunderAndLightning.LightningQualityMaximum val_6 = null;
            val_14 = val_6;
            val_6 = new DigitalRuby.ThunderAndLightning.LightningQualityMaximum();
            if(val_14 == null)
            {
                goto label_5;
            }
            
            val_6.MaximumGenerations = 8;
            val_6.MaximumLightPercent = 0.025f;
            goto label_6;
            label_3:
            val_5.MaximumGenerations = 3;
            val_5.MaximumLightPercent = 0f;
            label_4:
            val_5.MaximumShadowPercent = 0f;
            val_15 = public System.Void System.Collections.Generic.Dictionary<System.Int32, DigitalRuby.ThunderAndLightning.LightningQualityMaximum>::set_Item(System.Int32 key, DigitalRuby.ThunderAndLightning.LightningQualityMaximum value);
            val_16 = 0;
            goto label_20;
            label_5:
            val_6.MaximumGenerations = 8;
            val_6.MaximumLightPercent = 0.025f;
            label_6:
            val_6.MaximumShadowPercent = 0.05f;
            val_15 = public System.Void System.Collections.Generic.Dictionary<System.Int32, DigitalRuby.ThunderAndLightning.LightningQualityMaximum>::set_Item(System.Int32 key, DigitalRuby.ThunderAndLightning.LightningQualityMaximum value);
            val_16 = val_12;
            label_20:
            val_3.set_Item(key:  5, value:  null);
            val_12 = 1;
            label_1:
            if(val_12 < val_4.Length)
            {
                goto label_31;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltParameters()
        {
            var val_4;
            this.ChaosFactorForks = -1f;
            this.EndWidthMultiplier = 0.5f;
            this.Intensity = 1f;
            this.GenerationWhereForksStopSubtractor = 5;
            this.ForkLengthMultiplier = 0.6f;
            this.ForkLengthVariance = 7.346868E-41f;
            this.Color = 0;
            this.FadePercent = ;
            this.FadeInMultiplier = ;
            this.FadeFullyLitMultiplier = 1f;
            this.FadeOutMultiplier = 1f;
            this.ForkEndWidthMultiplier = 1f;
            val_4 = null;
            val_4 = null;
            DigitalRuby.ThunderAndLightning.LightningBoltParameters.randomSeed = DigitalRuby.ThunderAndLightning.LightningBoltParameters.randomSeed + 1;
            System.Random val_2 = new System.Random(Seed:  DigitalRuby.ThunderAndLightning.LightningBoltParameters.randomSeed);
            this.random = val_2;
            this.currentRandom = val_2;
            this.<Points>k__BackingField = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Generations()
        {
            return (int)this.generations;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Generations(int value)
        {
            int val_9;
            object val_10;
            var val_11;
            val_10 = this;
            int val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  1, max:  8);
            if(this.quality == 0)
            {
                goto label_3;
            }
            
            val_9 = UnityEngine.QualitySettings.GetQualityLevel();
            val_11 = null;
            val_11 = null;
            if((DigitalRuby.ThunderAndLightning.LightningBoltParameters.QualityMaximums.TryGetValue(key:  val_9, value: out  0)) == false)
            {
                goto label_7;
            }
            
            val_9 = val_3.MaximumGenerations;
            this.generations = UnityEngine.Mathf.Min(a:  val_9, b:  val_1);
            return;
            label_3:
            this.generations = val_1;
            return;
            label_7:
            this.generations = val_1;
            val_10 = "Unable to read lightning quality settings from level " + val_9.ToString();
            UnityEngine.Debug.LogError(message:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Random get_Random()
        {
            return (System.Random)this.currentRandom;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Random(System.Random value)
        {
            System.Random val_3;
            var val_4;
            val_3 = value;
            if(val_3 == null)
            {
                goto label_0;
            }
            
            if(this == null)
            {
                goto label_1;
            }
            
            val_4 = 0;
            goto label_3;
            label_0:
            val_3 = this.random;
            var val_1 = (this == 0) ? 1 : 0;
            goto label_3;
            label_1:
            val_4 = 1;
            label_3:
            this.random = val_3;
            this.currentRandom = (this.randomOverride == 0) ? (val_3) : this.randomOverride;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Random get_RandomOverride()
        {
            return (System.Random)this.randomOverride;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_RandomOverride(System.Random value)
        {
            this.randomOverride = value;
            this.currentRandom = this.random;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_GrowthMultiplier()
        {
            return (float)this.growthMultiplier;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_GrowthMultiplier(float value)
        {
            this.growthMultiplier = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  0.999f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> get_Points()
        {
            return (System.Collections.Generic.List<UnityEngine.Vector3>)this.<Points>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Points(System.Collections.Generic.List<UnityEngine.Vector3> value)
        {
            this.<Points>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ForkMultiplier()
        {
            float val_1 = (float)D0;
            val_1 = this.ForkLengthVariance * val_1;
            val_1 = val_1 + this.ForkLengthMultiplier;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 ApplyVariance(UnityEngine.Vector3 pos, UnityEngine.Vector3 variance)
        {
            float val_5 = (float)pos.x;
            float val_6 = (float)pos.x;
            float val_7 = (float)pos.x;
            float val_8 = -1f;
            val_5 = val_5 + val_5;
            val_6 = val_6 + val_6;
            val_7 = val_7 + val_7;
            val_5 = val_5 + val_8;
            val_6 = val_6 + val_8;
            val_7 = val_7 + val_8;
            val_5 = variance.x * val_5;
            val_8 = variance.y * val_6;
            float val_2 = pos.x + val_5;
            float val_3 = pos.y + val_8;
            float val_4 = pos.z + (variance.z * val_7);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            mem[1152921526260937704] = val_1.z;
            this.End = val_1;
            mem[1152921526260937712] = val_1.y;
            mem[1152921526260937716] = val_1.z;
            this.Start = val_1;
            mem[1152921526260937700] = val_1.y;
            this.Generator = 0;
            this.SmoothingFactor = 0;
            this.currentRandom = this.random;
            this.randomOverride = 0;
            this.CustomTransform = 0;
            if((this.<Points>k__BackingField) == null)
            {
                    return;
            }
            
            this.<Points>k__BackingField.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static DigitalRuby.ThunderAndLightning.LightningBoltParameters GetOrCreateParameters()
        {
            var val_5;
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltParameters> val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = DigitalRuby.ThunderAndLightning.LightningBoltParameters.cache;
            val_7 = null;
            if(val_6.Count != 0)
            {
                    val_7 = null;
                val_6 = DigitalRuby.ThunderAndLightning.LightningBoltParameters.cache.Count - 1;
                val_8 = DigitalRuby.ThunderAndLightning.LightningBoltParameters.cache.Item[val_6];
                DigitalRuby.ThunderAndLightning.LightningBoltParameters.cache.RemoveAt(index:  val_6);
                return (DigitalRuby.ThunderAndLightning.LightningBoltParameters)val_8;
            }
            
            DigitalRuby.ThunderAndLightning.LightningBoltParameters val_4 = null;
            val_8 = val_4;
            val_4 = new DigitalRuby.ThunderAndLightning.LightningBoltParameters();
            return (DigitalRuby.ThunderAndLightning.LightningBoltParameters)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReturnParametersToCache(DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((DigitalRuby.ThunderAndLightning.LightningBoltParameters.cache.Contains(item:  p)) != false)
            {
                    return;
            }
            
            p.Reset();
            val_3 = null;
            val_3 = null;
            DigitalRuby.ThunderAndLightning.LightningBoltParameters.cache.Add(item:  p);
        }
    
    }

}
