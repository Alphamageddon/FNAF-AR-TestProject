using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WearAndTearData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int WearAndTear;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int RepairParts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float HaywireCircleChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float HaywireCircleModifier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float HaywirePauseChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float HaywirePauseModifier;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WearAndTearData(ProtoData.WEARANDTEAR_DATA.Types.ENTRY entry)
        {
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            double val_28;
            var val_29;
            float val_30;
            var val_31;
            float val_32;
            float val_33;
            val_24 = this;
            var val_1 = (entry != 0) ? (val_24) : 0;
            if(entry == null)
            {
                goto label_2;
            }
            
            WEARANDTEAR val_2 = entry.WearAndTear;
            if(val_2 == null)
            {
                goto label_2;
            }
            
            double val_3 = val_2.WearAndTear;
            goto label_3;
            label_2:
            label_3:
            val_25 = 0;
            if(((-768346176) & 1) != 0)
            {
                    val_25 = 0.South;
            }
            
            this.WearAndTear = UnityEngine.Mathf.RoundToInt(f:  (float)val_25);
            if(entry != null)
            {
                    val_26 = entry.RepairParts;
            }
            else
            {
                    val_26 = 0;
            }
            
            this.RepairParts = UnityEngine.Mathf.RoundToInt(f:  (float)val_26);
            if(entry == null)
            {
                goto label_15;
            }
            
            PENALTIES val_8 = entry.Penalties;
            if(val_8 == null)
            {
                goto label_15;
            }
            
            HAYWIRECHANCE val_9 = val_8.HaywireCircleChance;
            if(val_9 == null)
            {
                goto label_15;
            }
            
            double val_10 = val_9.Chance;
            val_27 = val_1;
            goto label_16;
            label_15:
            val_27 = val_24;
            label_16:
            if(((-768346176) & 1) == 0)
            {
                goto label_17;
            }
            
            val_28 = 0.South;
            if(this != null)
            {
                goto label_20;
            }
            
            goto label_19;
            label_17:
            val_28 = 1;
            if(this != null)
            {
                goto label_20;
            }
            
            label_19:
            label_20:
            this.HaywireCircleChance = (float)val_28;
            if(entry == null)
            {
                goto label_23;
            }
            
            PENALTIES val_12 = entry.Penalties;
            if(val_12 == null)
            {
                goto label_23;
            }
            
            HAYWIRECHANCE val_13 = val_12.HaywireCircleChance;
            if(val_13 == null)
            {
                goto label_23;
            }
            
            double val_14 = val_13.Modifier;
            val_29 = val_1;
            goto label_24;
            label_23:
            val_29 = val_24;
            label_24:
            if(((-768346176) & 1) == 0)
            {
                goto label_25;
            }
            
            val_30 = (float)0.South;
            if(this != null)
            {
                goto label_28;
            }
            
            goto label_27;
            label_25:
            val_30 = 1f;
            if(this != null)
            {
                goto label_28;
            }
            
            label_27:
            label_28:
            this.HaywireCircleModifier = val_30;
            if(entry == null)
            {
                goto label_31;
            }
            
            PENALTIES val_16 = entry.Penalties;
            if(val_16 == null)
            {
                goto label_31;
            }
            
            HAYWIRECHANCE val_17 = val_16.HaywirePauseChance;
            if(val_17 == null)
            {
                goto label_31;
            }
            
            double val_18 = val_17.Chance;
            val_31 = val_1;
            goto label_32;
            label_31:
            val_31 = val_24;
            label_32:
            if(((-768346176) & 1) == 0)
            {
                goto label_33;
            }
            
            val_32 = (float)0.South;
            if(this != null)
            {
                goto label_36;
            }
            
            goto label_35;
            label_33:
            val_32 = 1f;
            if(this != null)
            {
                goto label_36;
            }
            
            label_35:
            label_36:
            this.HaywirePauseChance = val_32;
            if(entry == null)
            {
                goto label_39;
            }
            
            PENALTIES val_20 = entry.Penalties;
            if(val_20 == null)
            {
                goto label_39;
            }
            
            HAYWIRECHANCE val_21 = val_20.HaywirePauseChance;
            if(val_21 == null)
            {
                goto label_39;
            }
            
            double val_22 = val_21.Modifier;
            val_24 = val_1;
            goto label_40;
            label_39:
            label_40:
            if(((-768346176) & 1) == 0)
            {
                goto label_41;
            }
            
            val_33 = (float)0.South;
            if(this != null)
            {
                goto label_44;
            }
            
            goto label_43;
            label_41:
            val_33 = 1f;
            if(this != null)
            {
                goto label_44;
            }
            
            label_43:
            label_44:
            this.HaywirePauseModifier = val_33;
        }
    
    }

}
