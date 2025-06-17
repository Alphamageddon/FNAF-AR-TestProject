using UnityEngine;

namespace DevTools.Runtime.DebugMenu
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntroSequence_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string CategoryName = "Intro Sequence";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetAdditionalResourcesWarning()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "AdditionalResourcesWarningAccepted", value:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetPPandTOSAccept()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "PrivacyPolicyTermsOfServiceAcceptedKey", value:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntroSequence_SROptions()
        {
        
        }
    
    }

}
