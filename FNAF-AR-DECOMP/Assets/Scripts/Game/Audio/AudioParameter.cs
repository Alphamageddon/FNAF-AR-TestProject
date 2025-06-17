using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AudioParameter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Name;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioParameter(string name)
        {
            this.Name = name;
        }
    
    }

}
