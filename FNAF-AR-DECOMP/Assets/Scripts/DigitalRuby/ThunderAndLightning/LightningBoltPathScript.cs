using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltPathScript : LightningBoltPathScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats SpeedIntervalRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Repeat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float nextInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int nextIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<UnityEngine.Vector3> lastPoint;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            var val_21;
            int val_22;
            UnityEngine.Object val_23;
            val_21 = this.GetCurrentPathObjects();
            if(val_21.Count < 2)
            {
                    return;
            }
            
            val_22 = this.nextIndex;
            if(val_22 >= val_21.Count)
            {
                    if(this.Repeat == false)
            {
                    return;
            }
            
                if(val_21 != null)
            {
                    val_23 = val_21.Item[val_21.Count - 1];
            }
            else
            {
                    val_23 = val_21.Item[val_21.Count - 1];
            }
            
                if(val_23 == val_21.Item[0])
            {
                    mem2[0] = 1;
            }
            else
            {
                    mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = 0;
            }
            
            }
            
            if((this.lastPoint & 1) == 0)
            {
                    mem2[0] = this.nextIndex + 1;
                UnityEngine.Vector3 val_15 = val_21.Item[this.nextIndex].transform.position;
                this.lastPoint = 0;
                mem[1152921528876138656] = 0;
            }
            
            val_22 = mem[this.nextIndex];
            val_22 = this.nextIndex;
            val_21 = val_21.Item[val_22].transform;
            UnityEngine.Vector3 val_18 = val_21.position;
            if((this.lastPoint & 1) == 0)
            {
                    return;
            }
            
            if(((-1500524752) & 1) == 0)
            {
                    return;
            }
            
            val_21 = 1152921517415529968;
            parameters.Start = 0;
            mem2[0] = val_18.y;
            mem2[0] = val_18.z;
            parameters.End = 0;
            mem2[0] = val_18.y;
            mem2[0] = val_18.z;
            this.CreateLightningBolt(p:  parameters);
            float val_20 = this.nextInterval;
            val_20 = val_20 - this.Speed;
            this.nextInterval = val_20;
            if(val_20 > 0f)
            {
                    return;
            }
            
            float val_19 = UnityEngine.Random.Range(min:  this.SpeedIntervalRange, max:  this.Speed);
            int val_21 = this.nextIndex;
            val_19 = val_19 + this.nextInterval;
            this.nextInterval = val_19;
            val_21 = val_21 + 1;
            this.nextIndex = val_21;
            this.lastPoint = 0;
            mem[1152921528876138656] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            mem[1152921528876287524] = 0;
            mem2[0] = 0;
            this.nextInterval = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltPathScript()
        {
            this.Speed = 1f;
            this.SpeedIntervalRange = new DigitalRuby.ThunderAndLightning.RangeOfFloats();
            mem[1152921528876399496] = 1f;
            this.Repeat = true;
            this.nextInterval = 1f;
        }
    
    }

}
