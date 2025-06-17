using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomPauseData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Seconds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomPauseData(ProtoData.ATTACK_DATA.Types.PHANTOMPAUSE rawSettings)
        {
            PHANTOMPAUSE val_3 = rawSettings;
            if(val_3 != null)
            {
                    val_3 = val_3.Seconds;
            }
            
            this.Seconds = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_3);
        }
    
    }

}
