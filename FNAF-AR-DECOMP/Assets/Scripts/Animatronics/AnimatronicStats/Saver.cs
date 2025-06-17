using UnityEngine;

namespace Animatronics.AnimatronicStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Saver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.AnimatronicStatsDomain _animatronicStatsDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Saver(Animatronics.AnimatronicStats.AnimatronicStatsDomain animatronicStatsDomain)
        {
            this._animatronicStatsDomain = animatronicStatsDomain;
        }
    
    }

}
