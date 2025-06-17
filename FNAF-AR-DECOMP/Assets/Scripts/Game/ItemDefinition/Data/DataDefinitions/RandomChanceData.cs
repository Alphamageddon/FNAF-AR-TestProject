using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RandomChanceData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Chance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Modifier;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RandomChanceData(ProtoData.ATTACK_DATA.Types.CHANCE rawSettings)
        {
            float val_3;
            if(rawSettings == null)
            {
                goto label_0;
            }
            
            if(this != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            this.Chance = (float)rawSettings.Chance;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            val_3 = (float)rawSettings.Modifier;
            goto label_3;
            label_0:
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_3 = 0f;
            label_3:
            this.Modifier = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RandomChanceData(float chance, float modifier)
        {
            this.Chance = chance;
            this.Modifier = modifier;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RandomChanceData(Game.ItemDefinition.Data.DataDefinitions.RandomChanceData chance, string chanceKey, string modifierKey, System.Collections.Generic.Dictionary<string, float> mods)
        {
            float val_7;
            float val_8;
            val_1 = new System.Object();
            if((mods.ContainsKey(key:  string val_1 = chanceKey)) == false)
            {
                goto label_3;
            }
            
            val_7 = mods.Item[val_1];
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_3:
            val_7 = 1f;
            if(this != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            val_8 = chance.Chance * val_7;
            this.Chance = val_8;
            if((mods.ContainsKey(key:  modifierKey)) != false)
            {
                    float val_5 = mods.Item[modifierKey];
            }
            else
            {
                    val_8 = 1f;
            }
            
            val_8 = chance.Modifier * val_8;
            this.Modifier = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{{\"Chance\":{0},\"Modifier\":{1}}}", arg0:  this.Chance, arg1:  this.Modifier);
        }
    
    }

}
