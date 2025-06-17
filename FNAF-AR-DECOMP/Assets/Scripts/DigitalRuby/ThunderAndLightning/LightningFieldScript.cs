using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningFieldScript : LightningBoltPrefabScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MinimumLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float minimumLengthSquared;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Bounds FieldBounds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Light Light;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 RandomPointInBounds()
        {
            float val_1 = UnityEngine.Random.Range(min:  V0.16B, max:  V0.16B);
            float val_2 = UnityEngine.Random.Range(min:  V0.16B, max:  V0.16B);
            float val_3 = UnityEngine.Random.Range(min:  V2.16B, max:  V2.16B);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            if(this.Light == 0)
            {
                    return;
            }
            
            this.Light.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if(this.Light == 0)
            {
                    return;
            }
            
            this.Light.transform.position = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
            this.Light.intensity = UnityEngine.Random.Range(min:  2.8f, max:  3.2f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            UnityEngine.Vector3 val_5;
            float val_6;
            float val_7;
            UnityEngine.Light val_8;
            float val_5 = this.MinimumLength;
            var val_6 = 0;
            val_5 = val_5 * val_5;
            this.minimumLengthSquared = val_5;
            label_7:
            UnityEngine.Vector3 val_1 = this.RandomPointInBounds();
            parameters.Start = val_1;
            mem2[0] = val_1.y;
            mem2[0] = val_1.z;
            UnityEngine.Vector3 val_2 = this.RandomPointInBounds();
            val_5 = val_2.x;
            val_6 = val_2.y;
            val_7 = val_2.z;
            if(parameters != null)
            {
                    parameters.End = val_2;
                mem2[0] = val_6;
                mem2[0] = val_7;
            }
            else
            {
                    parameters.End = val_2;
                mem2[0] = val_6;
                mem2[0] = val_7;
                val_5 = parameters.End;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7}, b:  new UnityEngine.Vector3() {x = parameters.Start, y = V11.16B, z = V12.16B});
            if(val_3.x >= this.minimumLengthSquared)
            {
                goto label_6;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < 15)
            {
                goto label_7;
            }
            
            label_6:
            val_8 = this.Light;
            if(val_8 != 0)
            {
                    val_8 = this.Light;
                val_8.enabled = true;
            }
            
            this.CreateLightningBolt(p:  parameters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningFieldScript()
        {
            this.MinimumLength = 0.01f;
        }
    
    }

}
