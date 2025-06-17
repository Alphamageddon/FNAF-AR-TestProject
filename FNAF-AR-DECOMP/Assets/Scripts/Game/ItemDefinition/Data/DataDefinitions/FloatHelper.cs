using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class FloatHelper
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float ApplyModifier(float baseValue, string key, System.Collections.Generic.Dictionary<string, float> mods)
        {
            if((mods.ContainsKey(key:  key)) != false)
            {
                    float val_2 = mods.Item[key];
            }
            else
            {
                    float val_3 = 1f;
            }
            
            val_3 = val_3 * baseValue;
            return (float)val_3;
        }
    
    }

}
