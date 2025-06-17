using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModEffect
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Magnitude;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModEffect(string type, float magnitude)
        {
            this.Type = type;
            this.Magnitude = magnitude;
        }
    
    }

}
