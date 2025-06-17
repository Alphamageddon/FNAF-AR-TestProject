using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AlertDemoScript : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject alertNativeWindow;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnButtonShowNativeWindow()
    {
        var val_4;
        PaperPlaneTools.Alert val_1 = new PaperPlaneTools.Alert(title:  "Hello", message:  "Hello, world");
        val_4 = null;
        val_4 = null;
        if((AlertDemoScript.<>c.<>9__1_0) == null)
        {
            goto label_3;
        }
        
        label_9:
        val_1.SetPositiveButton(title:  "OK", handler:  AlertDemoScript.<>c.<>9__1_0).Show();
        return;
        label_3:
        AlertDemoScript.<>c.<>9__1_0 = new System.Action(object:  AlertDemoScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AlertDemoScript.<>c::<OnButtonShowNativeWindow>b__1_0());
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnButtonShowUIWindow()
    {
        if(this.alertNativeWindow == 0)
        {
                UnityEngine.Debug.Log(message:  "Alert Native Window property is the inspector");
            return;
        }
        
        new PaperPlaneTools.Alert(title:  "Hello", message:  "Hello, world").SetPositiveButton(title:  "OK", handler:  0).SetNeutralButton(title:  "Cancel", handler:  0).SetAdapter(adaper:  this.alertNativeWindow.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>()).Show();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnButtonQueueTest()
    {
        new PaperPlaneTools.Alert(title:  "Hello", message:  "#1 in queue").SetPositiveButton(title:  "OK", handler:  0).Show();
        new PaperPlaneTools.Alert(title:  "Hello", message:  "#2 in queue").SetPositiveButton(title:  "OK", handler:  0).Show();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AlertDemoScript()
    {
    
    }

}
