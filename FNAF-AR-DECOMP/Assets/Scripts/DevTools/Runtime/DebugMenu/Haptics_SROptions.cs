using UnityEngine;

namespace DevTools.Runtime.DebugMenu
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Haptics_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string CategoryName = "Haptics";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnityVibrate()
        {
            UnityEngine.Handheld.Vibrate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void NoneHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  7, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FailureHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  3, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SuccessHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  1, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectionHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  0, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WarningHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  2, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LightImpactHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  4, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MediumImpactHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  5, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HeavyImpactHaptic()
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  6, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Haptics_SROptions()
        {
        
        }
    
    }

}
