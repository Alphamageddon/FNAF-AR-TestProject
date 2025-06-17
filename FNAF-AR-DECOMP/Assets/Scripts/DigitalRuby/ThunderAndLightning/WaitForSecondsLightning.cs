using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WaitForSecondsLightning : CustomYieldInstruction
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float remaining;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool keepWaiting { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WaitForSecondsLightning(float time)
        {
            this.remaining = time;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_keepWaiting()
        {
            var val_2;
            if(this.remaining > 0f)
            {
                    float val_1 = DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime;
                val_1 = this.remaining - val_1;
                val_2 = 1;
                this.remaining = val_1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
    
    }

}
