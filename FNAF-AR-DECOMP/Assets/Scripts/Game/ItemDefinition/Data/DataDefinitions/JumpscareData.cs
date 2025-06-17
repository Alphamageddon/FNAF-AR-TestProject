using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JumpscareData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly MoreMountains.NiceVibrations.HapticTypes VibrationType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JumpscareData(ProtoData.ATTACK_DATA.Types.JUMPSCARE rawSettings)
        {
            var val_5;
            MoreMountains.NiceVibrations.HapticTypes val_3 = 0;
            this.VibrationType = 7;
            if(rawSettings != null)
            {
                    string val_1 = rawSettings.VibrationType;
            }
            else
            {
                    val_5 = 0;
            }
            
            if((System.Enum.TryParse<MoreMountains.NiceVibrations.HapticTypes>(value:  (val_5 == 0) ? "" : (val_5), ignoreCase:  true, result: out  val_3)) == false)
            {
                    return;
            }
            
            this.VibrationType = val_3;
        }
    
    }

}
