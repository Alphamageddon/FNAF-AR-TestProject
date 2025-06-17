using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningGenerator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly DigitalRuby.ThunderAndLightning.LightningGenerator GeneratorInstance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetPerpendicularVector(ref UnityEngine.Vector3 directionNormalized, out UnityEngine.Vector3 side)
        {
            float val_9;
            float val_10;
            float val_11;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_9 = directionNormalized.x;
            val_10 = directionNormalized.y;
            val_11 = directionNormalized.z;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            }
            else
            {
                    float val_8 = System.Math.Abs(directionNormalized.y);
                float val_9 = System.Math.Abs(directionNormalized.z);
                if((System.Math.Abs(directionNormalized.x) >= val_8) && (val_8 >= val_9))
            {
                    val_11 = 1f;
                val_9 = (-(directionNormalized.y + directionNormalized.z)) / directionNormalized.x;
                val_10 = val_11;
            }
            else
            {
                    if(val_8 < val_9)
            {
                    val_10 = 1f;
                val_11 = (-(directionNormalized.x + directionNormalized.y)) / directionNormalized.z;
                val_9 = val_10;
            }
            else
            {
                    val_11 = 1f;
                val_10 = (-(directionNormalized.x + directionNormalized.z)) / directionNormalized.y;
                val_9 = val_11;
            }
            
            }
            
            }
            
            side.x = val_9;
            side.y = val_10;
            side.z = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnGenerateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBolt bolt, UnityEngine.Vector3 start, UnityEngine.Vector3 end, DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            int val_1;
            var val_2;
            if(p != null)
            {
                    val_1 = p.generations;
                val_2 = val_1;
            }
            else
            {
                    val_2 = 62590012;
                val_1 = 62590012;
            }
            
            this.GenerateLightningBoltStandard(bolt:  bolt, start:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, end:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, generation:  62590012, totalGenerations:  62590012, offsetAmount:  0f, p:  p);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldCreateFork(DigitalRuby.ThunderAndLightning.LightningBoltParameters p, int generation, int totalGenerations)
        {
            var val_2;
            if(p.generationWhereForksStop < generation)
            {
                    int val_2 = p.forkednessCalculated;
                val_2 = totalGenerations - val_2;
                if(val_2 <= generation)
            {
                    return (bool)(p.Forkedness > (float)D0) ? 1 : 0;
            }
            
            }
            
            val_2 = 0;
            return (bool)(p.Forkedness > (float)D0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateFork(DigitalRuby.ThunderAndLightning.LightningBolt bolt, DigitalRuby.ThunderAndLightning.LightningBoltParameters p, int generation, int totalGenerations, UnityEngine.Vector3 start, UnityEngine.Vector3 midPoint)
        {
            if((this.ShouldCreateFork(p:  p, generation:  generation, totalGenerations:  totalGenerations)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = midPoint.x, y = midPoint.y, z = midPoint.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  p.ForkMultiplier());
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = midPoint.x, y = midPoint.y, z = midPoint.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.GenerateLightningBoltStandard(bolt:  bolt, start:  new UnityEngine.Vector3() {x = midPoint.x, y = midPoint.y, z = midPoint.z}, end:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, generation:  generation, totalGenerations:  totalGenerations, offsetAmount:  0f, p:  p);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateLightningBoltStandard(DigitalRuby.ThunderAndLightning.LightningBolt bolt, UnityEngine.Vector3 start, UnityEngine.Vector3 end, int generation, int totalGenerations, float offsetAmount, DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            float val_8;
            float val_9;
            float val_10;
            float val_12;
            float val_13;
            float val_14;
            float val_19;
            int val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegment> val_26;
            int val_27;
            int val_28;
            int val_29;
            var val_30;
            val_19 = offsetAmount;
            val_20 = generation;
            val_21 = end.z;
            val_22 = end.y;
            val_23 = end.x;
            if(val_20 < 1)
            {
                    return;
            }
            
            DigitalRuby.ThunderAndLightning.LightningBoltSegmentGroup val_1 = bolt.AddGroup();
            val_1.Segments.Add(item:  new DigitalRuby.ThunderAndLightning.LightningBoltSegment() {Start = new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, End = new UnityEngine.Vector3() {x = val_23, y = val_22, z = val_21}});
            float val_18 = (float)val_20;
            val_18 = val_18 / (float)totalGenerations;
            float val_2 = val_18 * val_18;
            if(p != null)
            {
                    float val_19 = p.TrunkWidth;
                val_1.Generation = val_20;
                val_19 = val_2 * val_19;
                val_1.LineWidth = val_19;
            }
            else
            {
                    float val_20 = 0f;
                val_1.Generation = val_20;
                val_20 = val_2 * val_20;
                val_1.LineWidth = val_20;
            }
            
            float val_21 = 255f;
            val_21 = val_2 * val_21;
            val_1.Color = p.Color;
            mem2[0] = (int)val_21;
            if(p != null)
            {
                    val_24 = p.EndWidthMultiplier;
            }
            else
            {
                    val_24 = 1.105332E-36f;
            }
            
            float val_22 = p.ForkEndWidthMultiplier;
            val_22 = val_24 * val_22;
            val_1.EndWidthMultiplier = val_22;
            if(val_19 <= 0f)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23, y = val_22, z = val_21}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
                val_25 = val_3.x * ((val_20 == totalGenerations) ? p.ChaosFactor : p.ChaosFactorForks);
            }
            
            int val_23 = val_1.StartIndex;
            do
            {
                val_26 = val_1.Segments;
                int val_5 = val_20 - 1;
                val_27 = val_26;
                int val_6 = val_27.Count;
                val_1.StartIndex = val_6;
                if(val_23 < val_6)
            {
                    do
            {
                DigitalRuby.ThunderAndLightning.LightningBoltSegment val_7 = val_1.Segments.Item[val_23];
                val_21 = val_8;
                val_22 = val_10;
                DigitalRuby.ThunderAndLightning.LightningBoltSegment val_11 = val_1.Segments.Item[val_23];
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21, y = val_9, z = val_22}, b:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14});
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  0.5f);
                this.RandomVector(bolt:  bolt, start: ref  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, end: ref  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, offsetAmount:  val_25, random:  p.currentRandom, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_23 = val_17.y;
                val_1.Segments.Add(item:  new DigitalRuby.ThunderAndLightning.LightningBoltSegment() {Start = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, End = new UnityEngine.Vector3() {x = val_17.x, y = val_23, z = val_17.z}});
                val_26 = val_1.Segments;
                val_26.Add(item:  new DigitalRuby.ThunderAndLightning.LightningBoltSegment() {Start = new UnityEngine.Vector3() {x = val_17.x, y = val_23, z = val_17.z}, End = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}});
                this.CreateFork(bolt:  bolt, p:  p, generation:  val_5, totalGenerations:  totalGenerations, start:  new UnityEngine.Vector3() {x = val_21, y = val_9, z = val_22}, midPoint:  new UnityEngine.Vector3() {x = val_17.x, y = val_23, z = val_17.z});
                val_27 = val_1.StartIndex;
                val_23 = val_23 + 1;
            }
            while(val_23 < val_27);
            
                val_28 = val_20;
            }
            
                val_29 = val_5;
                val_30 = val_25 * 0.5f;
            }
            while(val_28 > 1);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RandomDirection3D(System.Random r)
        {
            float val_5;
            float val_5 = (float)D0;
            val_5 = val_5 + val_5;
            float val_1 = val_5 + (-1f);
            UnityEngine.Vector3 val_2 = r.RandomDirection2D(r:  r);
            float val_3 = val_1 * val_1;
            val_3 = 1f - val_3;
            if(S12 >= _TYPE_MAX_)
            {
                    val_5 = val_3;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_5);
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RandomDirection2D(System.Random r)
        {
            float val_2 = (float)D0;
            val_2 = val_2 + val_2;
            float val_1 = val_2 * 3.141593f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 RandomDirection2DXZ(System.Random r)
        {
            float val_2 = (float)D0;
            val_2 = val_2 + val_2;
            float val_1 = val_2 * 3.141593f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RandomVector(DigitalRuby.ThunderAndLightning.LightningBolt bolt, ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, float offsetAmount, System.Random random, out UnityEngine.Vector3 result)
        {
            var val_11;
            var val_12;
            var val_13;
            float val_14;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            val_11 = 1152921528888919504;
            val_12 = bolt;
            if((bolt.<CameraMode>k__BackingField) == 2)
            {
                goto label_2;
            }
            
            if((bolt.<CameraMode>k__BackingField) != 1)
            {
                goto label_3;
            }
            
            val_12 = 1152921504840871936;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, rhs:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            bool val_4 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            if(val_4 == false)
            {
                goto label_6;
            }
            
            val_4.GetPerpendicularVector(directionNormalized: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, side: out  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(random != null)
            {
                goto label_17;
            }
            
            goto label_8;
            label_2:
            end.z = start.z;
            val_14 = start.z;
            val_14 = end.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = val_14}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
            val_18 = (float)-val_5.y;
            val_19 = 0f;
            val_20 = 0f;
            val_21 = 0f;
            goto label_12;
            label_3:
            end.y = start.y;
            val_22 = start.y;
            val_22 = end.y;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = val_22, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
            val_18 = (float)-val_6.z;
            val_19 = 0f;
            val_20 = 0f;
            val_21 = 0f;
            label_12:
            val_18 = val_18 * offsetAmount;
            val_18 = val_18 + val_18;
            val_23 = val_18 - offsetAmount;
            goto label_16;
            label_6:
            val_13 = 0;
            if(random != null)
            {
                goto label_17;
            }
            
            label_8:
            label_17:
            float val_11 = 0.1f;
            val_11 = (float)val_2.x + val_11;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  (float)(double)(float)val_2.x * 3.141593f);
            val_20 = val_8.y;
            val_21 = val_8.z;
            val_23 = val_11 * offsetAmount;
            val_19 = val_8.x;
            UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_19, y = val_20, z = val_21, w = (float)(double)(float)val_2.x * 3.141593f}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            label_16:
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_23);
            result.x = val_10.x;
            result.y = val_10.y;
            result.z = val_10.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBolt bolt, DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            this.GenerateLightningBolt(bolt:  bolt, p:  p, start: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, end: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBolt bolt, DigitalRuby.ThunderAndLightning.LightningBoltParameters p, out UnityEngine.Vector3 start, out UnityEngine.Vector3 end)
        {
            UnityEngine.Vector3 val_3;
            UnityEngine.Vector3 val_6;
            UnityEngine.Vector3 val_9;
            UnityEngine.Vector3 val_12;
            if(p != null)
            {
                    val_3 = p.Start;
                val_6 = p.StartVariance;
            }
            else
            {
                    val_3 = p.Start;
                val_6 = p.StartVariance;
            }
            
            UnityEngine.Vector3 val_1 = p.ApplyVariance(pos:  new UnityEngine.Vector3() {x = val_3, y = V9.16B, z = V10.16B}, variance:  new UnityEngine.Vector3() {x = val_6, y = V12.16B, z = V13.16B});
            start.x = val_1.x;
            start.y = val_1.y;
            start.z = val_1.z;
            if(p != null)
            {
                    val_9 = p.End;
                val_12 = p.EndVariance;
            }
            else
            {
                    val_9 = p.End;
                val_12 = p.EndVariance;
            }
            
            UnityEngine.Vector3 val_2 = p.ApplyVariance(pos:  new UnityEngine.Vector3() {x = val_9, y = V9.16B, z = V10.16B}, variance:  new UnityEngine.Vector3() {x = val_12, y = V12.16B, z = V13.16B});
            end.x = val_2.x;
            end.y = val_2.y;
            end.z = val_2.z;
            goto typeof(DigitalRuby.ThunderAndLightning.LightningGenerator).__il2cppRuntimeField_168;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningGenerator()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LightningGenerator()
        {
            DigitalRuby.ThunderAndLightning.LightningGenerator.GeneratorInstance = new DigitalRuby.ThunderAndLightning.LightningGenerator();
        }
    
    }

}
