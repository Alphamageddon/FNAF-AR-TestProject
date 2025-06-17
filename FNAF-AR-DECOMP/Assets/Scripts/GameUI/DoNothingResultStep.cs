using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DoNothingResultStep : BaseResultStep
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DoNothingResultStep(GameUI.ResultStepConfig config)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IsComplete()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void StartStep()
        {
        
        }
    
    }

}
