using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GenericDialogData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string positiveButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action positiveButtonAction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string neutralButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action neutralButtonAction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string negativeButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action negativeButtonAction;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GenericDialogData()
        {
        
        }
    
    }

}
