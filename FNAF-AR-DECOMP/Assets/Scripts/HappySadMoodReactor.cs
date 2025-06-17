using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class HappySadMoodReactor : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Master.MasterDomain _masterDomain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _scaryMoodLastFrame;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        Master.MasterDomain val_8;
        if(this._masterDomain != 0)
        {
            goto label_3;
        }
        
        val_8 = Master.MasterDomain.GetDomain();
        this._masterDomain = val_8;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_8 = this._masterDomain;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        GameUI.Domain val_3 = val_8.gameUIDomain;
        bool val_8 = val_3.gameUIData.serverGameUIDataModel;
        Systems.Guide.FeatureFlags.FeatureFlagMap val_5 = val_8.featureFlagMap;
        if(val_5 == null)
        {
                return;
        }
        
        bool val_6 = val_5.IsScaryMoodAllowed();
        var val_7 = (this._scaryMoodLastFrame == true) ? 1 : 0;
        val_7 = val_6 ^ val_7;
        if(val_7 == false)
        {
                return;
        }
        
        val_8 = val_6;
        val_6.OnMoodChange(scaryMoodAllowed:  val_8);
        this._scaryMoodLastFrame = val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnMoodChange(bool scaryMoodAllowed)
    {
        UnityEngine.Debug.Log(message:  "Scary mood is currently " + (scaryMoodAllowed != true) ? "On" : "Off"((scaryMoodAllowed != true) ? "On" : "Off"));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HappySadMoodReactor()
    {
    
    }

}
