using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomWalkData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData EncounterBurnTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData PhaseBurnTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomWalkData(ProtoData.ATTACK_DATA.Types.PHANTOMWALK rawSettings)
        {
            RANGE val_5;
            RANGE val_6;
            val_5 = rawSettings;
            if(val_5 != null)
            {
                    val_6 = val_5.EncounterBurnTime;
            }
            else
            {
                    val_6 = 0;
            }
            
            this.EncounterBurnTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_6);
            if(val_5 != null)
            {
                    val_5 = val_5.PhaseBurnTime;
            }
            
            this.PhaseBurnTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_5);
        }
    
    }

}
