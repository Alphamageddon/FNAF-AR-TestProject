using UnityEngine;

namespace Animatronics.AnimatronicStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Setter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.AnimatronicStatsDomain _animatronicStatsDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Setter(Animatronics.AnimatronicStats.AnimatronicStatsDomain animatronicStatsDomain)
        {
            this._animatronicStatsDomain = animatronicStatsDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerAnimatronicOrder(string animatronicId)
        {
            Animatronics.AnimatronicStats.StatsData val_4;
            var val_5;
            int val_6;
            if((this._animatronicStatsDomain.<container>k__BackingField.DoesDataExistForAnimatronic(animatronicId:  animatronicId)) == false)
            {
                goto label_3;
            }
            
            val_4 = this._animatronicStatsDomain.<container>k__BackingField.GetDataForAnimatronic(animatronicId:  animatronicId);
            if(val_4 == null)
            {
                goto label_6;
            }
            
            label_8:
            val_5 = val_4;
            val_6 = val_2.numberOfOrders;
            goto label_7;
            label_3:
            Animatronics.AnimatronicStats.StatsData val_3 = null;
            val_4 = val_3;
            val_3 = new Animatronics.AnimatronicStats.StatsData();
            .version = 1;
            if(val_4 != null)
            {
                goto label_8;
            }
            
            label_6:
            val_5 = 20;
            val_6 = 1;
            label_7:
            mem[20] = 2;
            this._animatronicStatsDomain.<container>k__BackingField.SetDataForAnimatronic(statsData:  val_3, animatronicId:  animatronicId);
        }
    
    }

}
