using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class UniAndroidPermission : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string PackageName = "net.sanukin.PermissionManager";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Action onAllowCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Action onDenyCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Action onDenyAndNeverAskAgainCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsPermitted(AndroidPermission permission)
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "net.sanukin.PermissionManager");
        object[] val_2 = new object[1];
        val_2[0] = UniAndroidPermission.GetPermittionStr(permittion:  permission);
        if(val_1 == null)
        {
                return (bool)val_1.CallStatic<System.Boolean>(methodName:  "hasPermission", args:  val_2);
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_1.Dispose();
        return (bool)val_1.CallStatic<System.Boolean>(methodName:  "hasPermission", args:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RequestPermission(AndroidPermission permission, System.Action onAllow, System.Action onDeny, System.Action onDenyAndNeverAskAgain)
    {
        System.Action val_13;
        var val_14;
        var val_15;
        val_13 = onDeny;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_14 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "net.sanukin.PermissionManager");
        object[] val_2 = new object[1];
        val_2[0] = UniAndroidPermission.GetPermittionStr(permittion:  permission);
        val_1.CallStatic(methodName:  "requestPermission", args:  val_2);
        val_15 = 0;
        UniAndroidPermission.onAllowCallback = onAllow;
        UniAndroidPermission.onDenyCallback = val_13;
        UniAndroidPermission.onDenyAndNeverAskAgainCallback = onDenyAndNeverAskAgain;
        if(val_14 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_1.Dispose();
        }
        
        if(67 == 67)
        {
                return;
        }
        
        if(val_15 == 0)
        {
                return;
        }
        
        val_14 = ???;
        val_13 = ???;
        val_15 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static string GetPermittionStr(AndroidPermission permittion)
    {
        long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = permittion});
        return (string)"android.permission." + permittion.ToString();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnAllow()
    {
        if(UniAndroidPermission.onAllowCallback != null)
        {
                UniAndroidPermission.onAllowCallback.Invoke();
        }
        
        UniAndroidPermission.onAllowCallback.ResetAllCallBacks();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDeny()
    {
        if(UniAndroidPermission.onDenyCallback != null)
        {
                UniAndroidPermission.onDenyCallback.Invoke();
        }
        
        UniAndroidPermission.onDenyCallback.ResetAllCallBacks();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDenyAndNeverAskAgain()
    {
        if(UniAndroidPermission.onDenyAndNeverAskAgainCallback != null)
        {
                UniAndroidPermission.onDenyAndNeverAskAgainCallback.Invoke();
        }
        
        UniAndroidPermission.onDenyAndNeverAskAgainCallback.ResetAllCallBacks();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ResetAllCallBacks()
    {
        UniAndroidPermission.onAllowCallback = 0;
        UniAndroidPermission.onDenyCallback = 0;
        UniAndroidPermission.onDenyAndNeverAskAgainCallback = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UniAndroidPermission()
    {
    
    }

}
