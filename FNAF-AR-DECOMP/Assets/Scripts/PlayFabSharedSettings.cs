using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class PlayFabSharedSettings : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string TitleId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal string VerticalName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ProductionEnvironmentUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.WebRequestType RequestType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string AdvertisingIdType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string AdvertisingIdValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool DisableAdvertising;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool DisableDeviceInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool DisableFocusTimeCollection;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int RequestTimeout;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool RequestKeepAlive;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool CompressApiData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFab.PlayFabLogLevel LogLevel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string LoggerHost;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int LoggerPort;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnableRealTimeLogging;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int LogCapLimit;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabSharedSettings()
    {
        this.RequestTimeout = 2000;
        this.RequestKeepAlive = true;
        this.CompressApiData = true;
        this.LogLevel = 12;
        this.ProductionEnvironmentUrl = "";
        this.LoggerHost = "";
        this.LogCapLimit = 30;
    }

}
