using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MultiwireData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.IntRangeData Count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData HalfAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData LocateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData HiddenTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MultiwireData(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE rawSettings)
        {
            RANGE val_10;
            RANGE val_11;
            RANGE val_12;
            val_10 = rawSettings;
            if(val_10 != null)
            {
                    val_11 = val_10.Count;
            }
            else
            {
                    val_11 = 0;
            }
            
            this.Count = new Game.ItemDefinition.Data.DataDefinitions.IntRangeData(rawSettings:  val_11);
            if(val_10 != null)
            {
                    this.HalfAngle = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_10.HalfAngle);
                val_12 = val_10.LocateTime;
            }
            else
            {
                    val_12 = 0;
                this.HalfAngle = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  0);
            }
            
            this.LocateTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_12);
            if(val_10 != null)
            {
                    val_10 = val_10.HiddenTime;
            }
            
            this.HiddenTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_10);
        }
    
    }

}
