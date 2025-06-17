using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class GetSocialUiNativeBridgeMock : IGetSocialUiNativeBridge
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Ui.GetSocialUiNativeBridgeMock _instance;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.GetSocialUiNativeBridgeMock Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool OnBackPressed()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Ui.GetSocialUiNativeBridgeMock::OnBackPressed(), values:  System.Array.Empty<System.Object>());
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Ui.GetSocialUiNativeBridgeMock get_Instance()
        {
            GetSocialSdk.Ui.GetSocialUiNativeBridgeMock val_2 = GetSocialSdk.Ui.GetSocialUiNativeBridgeMock._instance;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            GetSocialSdk.Ui.GetSocialUiNativeBridgeMock val_1 = null;
            val_2 = val_1;
            val_1 = new GetSocialSdk.Ui.GetSocialUiNativeBridgeMock();
            GetSocialSdk.Ui.GetSocialUiNativeBridgeMock._instance = val_2;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LoadDefaultConfiguration()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Ui.GetSocialUiNativeBridgeMock::LoadDefaultConfiguration(), values:  System.Array.Empty<System.Object>());
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LoadConfiguration(string filePath)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(filePath != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(filePath == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = filePath;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Ui.GetSocialUiNativeBridgeMock::LoadConfiguration(string filePath), values:  val_1);
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowView<T>(GetSocialSdk.Ui.ViewBuilder<T> viewBuilder)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(viewBuilder != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(viewBuilder == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = viewBuilder;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Ui.GetSocialUiNativeBridgeMock::ShowView<System.Object>(GetSocialSdk.Ui.ViewBuilder<T> viewBuilder), values:  val_1);
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CloseView(bool saveViewState)
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Ui.GetSocialUiNativeBridgeMock::CloseView(bool saveViewState), values:  System.Array.Empty<System.Object>());
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RestoreView()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Ui.GetSocialUiNativeBridgeMock::RestoreView(), values:  System.Array.Empty<System.Object>());
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialUiNativeBridgeMock()
        {
        
        }
    
    }

}
