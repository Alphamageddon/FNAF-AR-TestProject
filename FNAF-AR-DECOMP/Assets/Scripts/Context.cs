using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class ConfigProcessor.Context
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int masterDataVersion;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int assetBundleVersion;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string masterDataBaseUri;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string versionUri;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string bundleUri;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string cvDataUri;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int expectedResponses;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int successfulResponsesReceived;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool inFlight;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ConfigProcessor.Context()
    {
        this.inFlight = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Build(Systems.Server.ServerData data, int expectedResponses_)
    {
        this.inFlight = true;
        Server.LoginDomain val_3 = Master.MasterDomain.GetDomain().theGameDomain.loginDomain;
        var val_13 = 0;
        val_13 = val_13 + 1;
        this.masterDataVersion = val_3.LoginController.serverSpecifiedMasterDataVersion;
        if(data != null)
        {
                System.Nullable<System.Int32> val_6 = data.GetInt(key:  "AssetDataVersion");
            this.assetBundleVersion = val_6.HasValue;
        }
        else
        {
                System.Nullable<System.Int32> val_7 = 0.GetInt(key:  "AssetDataVersion");
            this.assetBundleVersion = val_7.HasValue;
        }
        
        this.masterDataBaseUri = data.GetString(key:  "MasterDataBaseURI");
        if(data != null)
        {
                this.versionUri = data.GetString(key:  "VersionURI");
        }
        else
        {
                this.versionUri = 0.GetString(key:  "VersionURI");
        }
        
        this.bundleUri = data.GetString(key:  "BundleURI");
        this.cvDataUri = data.GetString(key:  "CvDataUri");
        this.expectedResponses = expectedResponses_;
        this.successfulResponsesReceived = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Close()
    {
        this.inFlight = false;
    }

}
