using UnityEngine;

namespace Animatronics.AnimatronicStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Loader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.AnimatronicStatsDomain _animatronicStatsDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Loader(Animatronics.AnimatronicStats.AnimatronicStatsDomain animatronicStatsDomain)
        {
            this._animatronicStatsDomain = animatronicStatsDomain;
        }
    
    }

}
