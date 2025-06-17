using UnityEngine;

namespace Master.Restart
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShutdownParameters
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain MasterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Initialization.DomainLifecycle DomainLifecycle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameStartDisplayChooser DisplayChooser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Audio.GameAudioDomain AudioDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShutdownParameters()
        {
        
        }
    
    }

}
