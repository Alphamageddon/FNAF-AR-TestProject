using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class DictionaryCallbackProxy<TValue> : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<System.Collections.Generic.Dictionary<string, TValue>> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DictionaryCallbackProxy<TValue>(System.Action<System.Collections.Generic.Dictionary<string, TValue>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            mem[1152921526062141488] = onSuccess;
            mem[1152921526062141496] = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onSuccess(UnityEngine.AndroidJavaObject resultAJO)
        {
            var val_13;
            System.Object[] val_14;
            var val_15;
            if((resultAJO == null) || ((GetSocialSdk.Core.JniUtils.IsJavaNull(ajo:  resultAJO)) == true))
            {
                goto label_3;
            }
            
            UnityEngine.AndroidJavaObject val_5 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  resultAJO, methodName:  "keySet", args:  System.Array.Empty<System.Object>()), methodName:  "iterator", args:  System.Array.Empty<System.Object>());
            val_13 = public static T[] System.Array::Empty<System.Object>();
            goto label_4;
            label_18:
            string val_7 = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  val_5, methodName:  "next", args:  System.Array.Empty<System.Object>());
            object[] val_8 = new object[1];
            if(val_8 == null)
            {
                goto label_5;
            }
            
            if(val_7 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_7 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_8[0] = val_7;
            val_14 = val_8;
            UnityEngine.AndroidJavaObject val_9 = resultAJO.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_8);
            var val_14 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 16 + 286) == 0)
            {
                goto label_13;
            }
            
            var val_12 = __RuntimeMethodHiddenParam + 24 + 192 + 16 + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_15:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 16 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 32))
            {
                goto label_14;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (__RuntimeMethodHiddenParam + 24 + 192 + 16 + 286))
            {
                goto label_15;
            }
            
            label_13:
            val_14 = 0;
            goto label_16;
            label_14:
            val_14 = val_14 + (((__RuntimeMethodHiddenParam + 24 + 192 + 16 + 176 + 8)) << 4);
            val_15 = val_14 + 296;
            label_16:
            val_13 = public static T[] System.Array::Empty<System.Object>();
            label_4:
            if((GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  val_5, methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) == true)
            {
                goto label_18;
            }
            
            label_3:
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
