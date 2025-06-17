using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal interface IGetSocialUiNativeBridge
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool LoadDefaultConfiguration(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool LoadConfiguration(string filePath); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool ShowView<T>(GetSocialSdk.Ui.ViewBuilder<T> viewBuilder); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool CloseView(bool saveViewState); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool RestoreView(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool OnBackPressed(); // 0
    
    }

}
