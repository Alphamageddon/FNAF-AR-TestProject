using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAlertPlatformAdapter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetOnDismiss(System.Action action); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Show(PaperPlaneTools.Alert alert); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Dismiss(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void HandleEvent(string name, string value); // 0
    
    }

}
