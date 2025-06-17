using UnityEngine;

namespace Systems.Audio.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SoundBankRequest
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SoundBankName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string> Success;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string> Failure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SoundBankRequest()
        {
        
        }
    
    }

}
