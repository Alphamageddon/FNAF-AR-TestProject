using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningLightsabreScript : LightningBoltPrefabScript
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BladeHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ActivationTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AudioSource StartSound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AudioSource StopSound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AudioSource ConstantSound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 bladeStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 bladeDir;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float bladeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float bladeIntensity;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            int val_10 = this.state;
            val_10 = val_10 & 4294967294;
            if(val_10 == 2)
            {
                    float val_11 = this.bladeTime;
                val_11 = val_11 + DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime;
                this.bladeTime = val_11;
                float val_3 = UnityEngine.Mathf.Lerp(a:  0.01f, b:  1f, t:  val_11 / this.ActivationTime);
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.bladeDir, y = V13.16B, z = V14.16B}, d:  val_3);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.BladeHeight);
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.bladeStart, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                float val_12 = this.bladeIntensity;
                val_12 = val_12 * ((this.state == 3) ? (val_3) : (1f - val_3));
                mem[1152921528890333088] = val_12;
                if(this.bladeTime >= this.ActivationTime)
            {
                    this.bladeTime = 0f;
                mem[1152921528890333088] = this.bladeIntensity;
                if(this.state == 2)
            {
                    mem[1152921528890333148] = 1;
                this.state = 0;
            }
            else
            {
                    this.state = 1;
            }
            
            }
            
            }
            
            this.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TurnOn(bool value)
        {
            var val_13;
            UnityEngine.AudioSource val_14;
            var val_15;
            val_14 = this;
            int val_13 = this.state;
            if((val_13 & 4294967294) == 2)
            {
                goto label_2;
            }
            
            val_13 = ((val_13 == 1) ? 1 : 0) & value;
            var val_3 = (val_13 != 0) ? 1 : 0;
            val_3 = val_3 | value;
            val_13 = val_13 ^ val_3;
            if(val_13 == false)
            {
                goto label_2;
            }
            
            UnityEngine.Transform val_4 = transform;
            UnityEngine.Vector3 val_5 = val_4.position;
            this.bladeStart = val_5;
            mem[1152921528890482128] = val_5.y;
            mem[1152921528890482132] = val_5.z;
            mem[1152921528890482012] = 0;
            this.bladeIntensity = val_13;
            bool val_6 = val_4.orthographic;
            val_13 = this.transform;
            if(val_13 == null)
            {
                goto label_6;
            }
            
            if(value == false)
            {
                goto label_7;
            }
            
            label_11:
            if(val_6 == false)
            {
                goto label_8;
            }
            
            UnityEngine.Vector3 val_8 = val_13.up;
            goto label_9;
            label_2:
            val_15 = 0;
            return (bool)val_15;
            label_6:
            if(value == true)
            {
                goto label_11;
            }
            
            label_7:
            if(val_6 == false)
            {
                goto label_12;
            }
            
            UnityEngine.Vector3 val_9 = val_13.up;
            goto label_13;
            label_8:
            UnityEngine.Vector3 val_10 = val_13.forward;
            label_9:
            this.bladeDir = val_10;
            mem[1152921528890482140] = val_10.y;
            mem[1152921528890482144] = val_10.z;
            this.state = 3;
            this.StartSound.Play();
            this.StopSound.Stop();
            val_14 = this.ConstantSound;
            val_14.Play();
            goto label_17;
            label_12:
            UnityEngine.Vector3 val_11 = val_13.forward;
            label_13:
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.bladeDir = val_12;
            mem[1152921528890482140] = val_12.y;
            mem[1152921528890482144] = val_12.z;
            this.state = 2;
            this.StartSound.Stop();
            this.StopSound.Play();
            val_14 = this.ConstantSound;
            val_14.Stop();
            label_17:
            val_15 = 1;
            return (bool)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TurnOnGUI(bool value)
        {
            bool val_2 = this.TurnOn(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningLightsabreScript()
        {
            this.BladeHeight = 0f;
            this.ActivationTime = 0.5f;
            val_1 = new DigitalRuby.ThunderAndLightning.LightningBoltPrefabScriptBase();
        }
    
    }

}
