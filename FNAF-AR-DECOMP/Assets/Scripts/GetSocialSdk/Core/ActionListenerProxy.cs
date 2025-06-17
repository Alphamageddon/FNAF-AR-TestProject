using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ActionListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GetSocialSdk.Core.ActionListener _actionListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActionListenerProxy(GetSocialSdk.Core.ActionListener actionListener)
        {
            this._actionListener = actionListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool handleAction(UnityEngine.AndroidJavaObject ajo)
        {
            if(this._actionListener == null)
            {
                    return false;
            }
            
            GetSocialSdk.Core.GetSocialAction val_1 = new GetSocialSdk.Core.GetSocialAction();
            GetSocialSdk.Core.GetSocialAction val_2 = val_1.ParseFromAJO(ajo:  ajo);
            return this._actionListener.Invoke(action:  val_1);
        }
    
    }

}
