using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CallbackProxy<T> : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<T> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CallbackProxy<T>(System.Action<T> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            mem[1152921526061395616] = onSuccess;
            mem[1152921526061395624] = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onSuccess(UnityEngine.AndroidJavaObject resultAJO)
        {
            var val_2;
            var val_3 = __RuntimeMethodHiddenParam + 24 + 192;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 286) == 0)
            {
                goto label_5;
            }
            
            var val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 176;
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_4:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 16))
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < (__RuntimeMethodHiddenParam + 24 + 192 + 286))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            val_3 = val_3 + (((__RuntimeMethodHiddenParam + 24 + 192 + 176 + 8)) << 4);
            val_2 = val_3 + 296;
            label_5:
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onFailure(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  X19);
        }
    
    }

}
