using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TeleportRepositionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData AngleFromCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData DistanceFromCamera;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TeleportRepositionData(ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION rawSettings)
        {
            RANGE val_5;
            RANGE val_6;
            val_5 = rawSettings;
            if(val_5 != null)
            {
                    val_6 = val_5.AngleFromCamera;
            }
            else
            {
                    val_6 = 0;
            }
            
            this.AngleFromCamera = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_6);
            if(val_5 != null)
            {
                    val_5 = val_5.DistanceFromCamera;
            }
            
            this.DistanceFromCamera = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TeleportRepositionData(Game.ItemDefinition.Data.DataDefinitions.RangeData angleFromCamera, Game.ItemDefinition.Data.DataDefinitions.RangeData distanceFromCamera)
        {
            val_1 = new System.Object();
            this.AngleFromCamera = angleFromCamera;
            this.DistanceFromCamera = val_1;
        }
    
    }

}
