using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ListCallbackProxy<T> : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<System.Collections.Generic.List<T>> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListCallbackProxy<T>(System.Action<System.Collections.Generic.List<T>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            mem[1152921526066806784] = onSuccess;
            mem[1152921526066806792] = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onSuccess(UnityEngine.AndroidJavaObject resultAJO)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_2 = __RuntimeMethodHiddenParam;
            val_3 = GetSocialSdk.Core.JniUtils.FromJavaList(javaList:  resultAJO);
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_4 & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8) == 0)
            {
                goto label_6;
            }
            
            label_18:
            val_2 = ???;
            val_3 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 48;
            label_6:
            val_5 = mem[val_2 + 24 + 192 + 294];
            val_5 = val_2 + 24 + 192 + 294;
            if((val_5 & 1) == 0)
            {
                    val_5 = mem[val_2 + 24 + 192 + 294];
                val_5 = val_2 + 24 + 192 + 294;
            }
            
            val_6 = mem[val_2 + 24 + 192];
            val_6 = val_2 + 24 + 192;
            if(((val_2 + 24 + 192 + 294) & 1) == 0)
            {
                    val_6 = mem[val_2 + 24 + 192];
                val_6 = val_2 + 24 + 192;
            }
            
            mem2[0] = val_2 + 24 + 192 + 16;
            if(val_3 != 0)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onFailure(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  X19);
        }
    
    }

}
