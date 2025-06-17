using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningGeneratorPath : LightningGenerator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly DigitalRuby.ThunderAndLightning.LightningGeneratorPath PathGeneratorInstance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateLightningBoltPath(DigitalRuby.ThunderAndLightning.LightningBolt bolt, UnityEngine.Vector3 start, UnityEngine.Vector3 end, DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            float val_30;
            float val_31;
            float val_32;
            UnityEngine.Color32 val_33;
            float val_34;
            var val_35;
            var val_36;
            var val_37;
            float val_38;
            float val_45;
            float val_46;
            val_30 = end.z;
            val_31 = end.x;
            val_32 = start.y;
            if((p.<Points>k__BackingField.Count) <= 1)
            {
                goto label_3;
            }
            
            if(bolt.AddGroup() == null)
            {
                goto label_5;
            }
            
            val_2.LineWidth = p.TrunkWidth;
            val_2.Generation = p.generations;
            val_2.EndWidthMultiplier = p.EndWidthMultiplier;
            val_33 = p.Color;
            goto label_6;
            label_3:
            UnityEngine.Debug.LogError(message:  "Lightning path should have at least two points");
            return;
            label_5:
            mem[16] = p.TrunkWidth;
            mem[24] = p.generations;
            mem[44] = p.EndWidthMultiplier;
            val_33 = p.Color;
            label_6:
            val_2.Color = val_33;
            UnityEngine.Vector3 val_3 = p.<Points>k__BackingField.Item[0];
            val_34 = val_3.x;
            int val_4 = p.SmoothingFactor - 1;
            int val_5 = p.generations - 1;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = start.x, y = val_32, z = start.z});
            p.Start = val_6;
            mem2[0] = val_6.y;
            mem2[0] = val_6.z;
            if((p.<Points>k__BackingField) != null)
            {
                    val_35 = 1152921518724785408;
                val_36 = p.<Points>k__BackingField.Count;
            }
            else
            {
                    val_35 = 1152921518724785408;
                val_36 = p.<Points>k__BackingField.Count;
            }
            
            val_30 = val_30;
            UnityEngine.Vector3 val_10 = p.<Points>k__BackingField.Item[val_36 - 1];
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_31, y = end.y, z = val_30});
            p.End = val_11;
            mem2[0] = val_11.y;
            mem2[0] = val_11.z;
            val_37 = 1;
            goto label_15;
            label_36:
            UnityEngine.Vector3 val_12 = p.<Points>k__BackingField.Item[1];
            val_34 = val_12.x;
            val_38 = val_12.y;
            val_32 = val_12.z;
            val_31 = p.Start;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34, y = val_38, z = val_32}, b:  new UnityEngine.Vector3() {x = p.Start, y = val_31, z = ???});
            float val_14 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_13.x);
            if(p.ChaosFactor > 0f)
            {
                    if((bolt.<CameraMode>k__BackingField) == 1)
            {
                    UnityEngine.Vector3 val_15 = this.RandomDirection3D(r:  p.currentRandom);
            }
            else
            {
                    if((bolt.<CameraMode>k__BackingField) == 2)
            {
                    UnityEngine.Vector3 val_16 = 0.RandomDirection2D(r:  p.currentRandom);
            }
            else
            {
                    UnityEngine.Vector3 val_17 = 0.RandomDirection2DXZ(r:  p.currentRandom);
            }
            
            }
            
                val_45 = val_17.x;
                val_46 = val_17.y;
                val_30 = val_17.z;
                val_46 = val_46;
                val_45 = val_45;
                float val_30 = p.ChaosFactor;
                val_30 = val_30 * val_14;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  val_30, a:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_30});
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34, y = val_38, z = val_32}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                val_34 = val_19.x;
                val_38 = val_19.y;
                val_32 = val_19.z;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34, y = val_38, z = val_32}, b:  new UnityEngine.Vector3() {x = p.Start, y = val_31, z = ???});
            }
            
            val_2.Segments.Add(item:  new DigitalRuby.ThunderAndLightning.LightningBoltSegment() {Start = new UnityEngine.Vector3() {x = p.Start, y = val_31, z = ???}, End = new UnityEngine.Vector3() {x = val_34, y = val_38, z = val_32}});
            float val_31 = p.ChaosFactor;
            val_31 = val_31 * val_14;
            val_2.Segments.RandomVector(bolt:  bolt, start: ref  new UnityEngine.Vector3() {x = p.Start, y = p.Start, z = ???}, end: ref  new UnityEngine.Vector3() {x = val_34, y = val_38, z = val_32}, offsetAmount:  val_31, random:  p.currentRandom, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if((val_2.Segments.ShouldCreateFork(p:  p, generation:  val_5, totalGenerations:  p.generations)) != false)
            {
                    val_30 = val_20.x;
                val_32 = val_20.y;
                val_34 = p.ForkMultiplier();
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30, y = val_32, z = val_20.z}, d:  val_34);
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  (float)val_4);
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  0.5f);
                UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34, y = val_38, z = val_32}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.GenerateLightningBoltStandard(bolt:  bolt, start:  new UnityEngine.Vector3() {x = p.Start, y = val_31, z = ???}, end:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, generation:  val_5, totalGenerations:  p.generations, offsetAmount:  0f, p:  p);
            }
            
            val_4 = val_4 - 1;
            if(val_4 == 0)
            {
                    int val_28 = p.SmoothingFactor - 1;
            }
            
            val_37 = 2;
            label_15:
            if(val_37 < (p.<Points>k__BackingField.Count))
            {
                goto label_36;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnGenerateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBolt bolt, UnityEngine.Vector3 start, UnityEngine.Vector3 end, DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            this.GenerateLightningBoltPath(bolt:  bolt, start:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, end:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, p:  p);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningGeneratorPath()
        {
            this = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LightningGeneratorPath()
        {
            DigitalRuby.ThunderAndLightning.LightningGeneratorPath.PathGeneratorInstance = new DigitalRuby.ThunderAndLightning.LightningGeneratorPath();
        }
    
    }

}
