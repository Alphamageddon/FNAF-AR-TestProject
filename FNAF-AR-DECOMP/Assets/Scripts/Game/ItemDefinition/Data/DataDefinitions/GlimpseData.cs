using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GlimpseData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Cooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Distance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData CloakDelayTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData ExpireTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData HalfAngleDeadZone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData HalfAngleTeleport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData PhaseDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData RepositionDelay;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GlimpseData(ProtoData.ATTACK_DATA.Types.GLIMPSE rawSettings)
        {
            RANGE val_20;
            RANGE val_21;
            RANGE val_22;
            RANGE val_23;
            RANGE val_24;
            val_20 = rawSettings;
            if(val_20 != null)
            {
                    val_21 = val_20.Cooldown;
            }
            else
            {
                    val_21 = 0;
            }
            
            this.Cooldown = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_21);
            if(val_20 != null)
            {
                    this.Distance = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_20.Distance);
                val_22 = val_20.CloakDelayTime;
            }
            else
            {
                    val_22 = 0;
                this.Distance = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  0);
            }
            
            this.CloakDelayTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_22);
            if(val_20 != null)
            {
                    this.ExpireTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_20.ExpireTime);
                val_23 = val_20.HalfAngleDeadZone;
            }
            else
            {
                    val_23 = 0;
                this.ExpireTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  0);
            }
            
            this.HalfAngleDeadZone = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_23);
            if(val_20 != null)
            {
                    this.HalfAngleTeleport = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_20.HalfAngleTeleport);
                val_24 = val_20.PhaseDuration;
            }
            else
            {
                    val_24 = 0;
                this.HalfAngleTeleport = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  0);
            }
            
            this.PhaseDuration = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_24);
            if(val_20 != null)
            {
                    val_20 = val_20.RepositionDelay;
            }
            
            this.RepositionDelay = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_20);
        }
    
    }

}
