using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AppCenterBehaviorAdvanced : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterSettingsAdvanced SettingsAdvanced;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        if((this.gameObject.GetComponent<AppCenterBehavior>()) != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "App Center Behavior Advanced should have the App Center Behavior instance attached to the same game object.");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterBehaviorAdvanced()
    {
    
    }

}
