using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NumberChangeResultStep : BaseResultStep
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NumberChangeResultStep(GameUI.ResultStepConfig config)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IsComplete()
        {
            var val_3;
            if(this.HasStarted != false)
            {
                    var val_2 = (W8 != 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void StartStep()
        {
            mem2[0] = 1;
            mem2[0] = UnityEngine.Time.time;
        }
    
    }

}
