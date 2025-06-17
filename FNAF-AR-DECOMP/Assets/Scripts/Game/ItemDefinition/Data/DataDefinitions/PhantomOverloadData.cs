using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomOverloadData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData ReactionTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData FlashlightDisableTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomOverloadData(ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD rawSettings)
        {
            RANGE val_5;
            RANGE val_6;
            val_5 = rawSettings;
            if(val_5 != null)
            {
                    val_6 = val_5.ReactionTime;
            }
            else
            {
                    val_6 = 0;
            }
            
            this.ReactionTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_6);
            if(val_5 != null)
            {
                    val_5 = val_5.FlashlightDisableTime;
            }
            
            this.FlashlightDisableTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_5);
        }
    
    }

}
