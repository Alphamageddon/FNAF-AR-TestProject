using UnityEngine;

namespace Animatronics.AnimatronicStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Getter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.AnimatronicStatsDomain _animatronicStatsDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Getter(Animatronics.AnimatronicStats.AnimatronicStatsDomain animatronicStatsDomain)
        {
            this._animatronicStatsDomain = animatronicStatsDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNumberOfOrdersForAnimatronic(string animatronicId)
        {
            string val_3;
            int val_4;
            val_3 = animatronicId;
            if((this._animatronicStatsDomain.<container>k__BackingField.DoesDataExistForAnimatronic(animatronicId:  val_3)) != false)
            {
                    val_3 = this._animatronicStatsDomain.<container>k__BackingField.GetDataForAnimatronic(animatronicId:  val_3);
                val_4 = val_2.numberOfOrders;
                return (int)val_4;
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNumberOfOrdersForAllAnimatronics()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            val_4 = 0;
            goto label_2;
            label_5:
            val_4 = (this.GetNumberOfOrdersForAnimatronic(animatronicId:  this._animatronicStatsDomain.<container>k__BackingField.GetAllAnimatronicIds()[0])) + val_4;
            val_3 = 1;
            label_2:
            if(val_3 < val_1.Length)
            {
                goto label_5;
            }
            
            return (int)val_4;
        }
    
    }

}
