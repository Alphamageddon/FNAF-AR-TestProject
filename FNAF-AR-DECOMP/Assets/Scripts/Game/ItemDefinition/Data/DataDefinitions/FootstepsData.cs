using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FootstepsData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData Walk;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData Run;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FootstepsData(ProtoData.ATTACK_DATA.Types.FOOTSTEPS rawSettings)
        {
            FOOTSTEPCONFIG val_5;
            FOOTSTEPCONFIG val_6;
            val_5 = rawSettings;
            if(val_5 != null)
            {
                    val_6 = val_5.Walk;
            }
            else
            {
                    val_6 = 0;
            }
            
            this.Walk = new Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData(rawSettings:  val_6);
            if(val_5 != null)
            {
                    val_5 = val_5.Run;
            }
            
            this.Run = new Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData(rawSettings:  val_5);
        }
    
    }

}
