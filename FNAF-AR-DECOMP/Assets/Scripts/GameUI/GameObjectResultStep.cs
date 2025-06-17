using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameObjectResultStep : BaseResultStep
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameObjectResultStep(GameUI.ResultStepConfig config)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IsComplete()
        {
            return this.HasStarted;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void StartStep()
        {
            var val_3;
            if("The key was of an incorrect type for this dictionary." == 0)
            {
                    return;
            }
            
            val_3 = 1;
            this.SetActive(value:  false);
        }
    
    }

}
