using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkCallbackManager.BankCallbackPackage
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackManager.BankCallback m_Callback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public object m_Cookie;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackManager.BankCallbackPackage(AkCallbackManager.BankCallback in_cb, object in_cookie)
    {
        var val_3;
        val_1 = new System.Object();
        this.m_Callback = in_cb;
        this.m_Cookie = val_1;
        val_3 = null;
        val_3 = null;
        AkCallbackManager.m_mapBankCallbacks.set_Item(key:  val_1.GetHashCode(), value:  this);
    }

}
