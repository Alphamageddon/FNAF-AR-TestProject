using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameSparksSettings : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string gamesparksSettingsAssetName = "GameSparksSettings";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string gamesparksSettingsPath = "GameSparks/Resources";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string gamesparksSettingsAssetExtension = ".asset";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly string liveServiceUrlBase;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly string previewServiceUrlBase;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static GameSparksSettings instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string sdkVersion;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string apiKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string credential;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string apiSecret;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool previewBuild;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool debugBuild;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static GameSparksSettings Instance { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool PreviewBuild { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string SdkVersion { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string ApiSecret { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string ApiKey { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string Credential { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool DebugBuild { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string ServiceUrl { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetInstance(GameSparksSettings settings)
    {
        null = null;
        GameSparksSettings.instance = settings;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static GameSparksSettings get_Instance()
    {
        GameSparksSettings val_4;
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(GameSparksSettings.instance == null)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load(path:  "GameSparksSettings");
            val_5 = null;
            val_6 = 0;
            GameSparksSettings.instance = ;
            val_5 = null;
            val_4 = UnityEngine.ScriptableObject.CreateInstance<GameSparksSettings>();
            val_5 = null;
            GameSparksSettings.instance = val_4;
        }
        
        val_5 = null;
        return (GameSparksSettings)GameSparksSettings.instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool get_PreviewBuild()
    {
        if(GameSparksSettings.Instance != null)
        {
                return (bool)val_1.previewBuild;
        }
        
        return (bool)val_1.previewBuild;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_PreviewBuild(bool value)
    {
        GameSparksSettings val_1 = GameSparksSettings.Instance;
        val_1.previewBuild = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_SdkVersion()
    {
        if(GameSparksSettings.Instance != null)
        {
                return (string)val_1.sdkVersion;
        }
        
        return (string)val_1.sdkVersion;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_SdkVersion(string value)
    {
        GameSparksSettings val_1 = GameSparksSettings.Instance;
        val_1.sdkVersion = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_ApiSecret()
    {
        if(GameSparksSettings.Instance != null)
        {
                return (string)val_1.apiSecret;
        }
        
        return (string)val_1.apiSecret;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_ApiSecret(string value)
    {
        GameSparksSettings val_1 = GameSparksSettings.Instance;
        val_1.apiSecret = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_ApiKey()
    {
        if(GameSparksSettings.Instance != null)
        {
                return (string)val_1.apiKey;
        }
        
        return (string)val_1.apiKey;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_ApiKey(string value)
    {
        GameSparksSettings val_1 = GameSparksSettings.Instance;
        val_1.apiKey = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_Credential()
    {
        string val_5;
        string val_6;
        val_5 = GameSparksSettings.Instance;
        if(val_1.credential != null)
        {
                GameSparksSettings val_2 = GameSparksSettings.Instance;
            val_5 = val_2.credential;
            if(val_5.Length != 0)
        {
                val_5 = GameSparksSettings.Instance;
            val_6 = val_4.credential;
            return (string)val_6;
        }
        
        }
        
        val_6 = "device";
        return (string)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_Credential(string value)
    {
        GameSparksSettings val_1 = GameSparksSettings.Instance;
        val_1.credential = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool get_DebugBuild()
    {
        if(GameSparksSettings.Instance != null)
        {
                return (bool)val_1.debugBuild;
        }
        
        return (bool)val_1.debugBuild;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_DebugBuild(bool value)
    {
        GameSparksSettings val_1 = GameSparksSettings.Instance;
        val_1.debugBuild = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_ServiceUrl()
    {
        string val_11;
        var val_12;
        var val_13;
        string val_14;
        var val_15;
        GameSparksSettings val_1 = GameSparksSettings.Instance;
        val_11 = val_1.apiKey;
        GameSparksSettings val_2 = GameSparksSettings.Instance;
        if((val_2.apiSecret.Contains(value:  ":")) != false)
        {
                GameSparksSettings val_4 = GameSparksSettings.Instance;
            GameSparksSettings val_5 = GameSparksSettings.Instance;
            val_11 = val_4.apiSecret.Substring(startIndex:  0, length:  val_5.apiSecret.IndexOf(value:  ":"))(val_4.apiSecret.Substring(startIndex:  0, length:  val_5.apiSecret.IndexOf(value:  ":"))) + "/"("/") + val_11;
        }
        
        GameSparksSettings val_9 = GameSparksSettings.Instance;
        val_12 = null;
        if(val_9.previewBuild != false)
        {
                val_13 = null;
            val_14 = GameSparksSettings.previewServiceUrlBase;
        }
        else
        {
                val_15 = null;
            val_14 = GameSparksSettings.liveServiceUrlBase;
        }
        
        if(GameSparksSettings.Instance != null)
        {
                return System.String.Format(format:  val_14, arg0:  val_11, arg1:  val_10.credential);
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparksSettings()
    {
        this.apiSecret = "";
        this.previewBuild = true;
        this.apiKey = "";
        this.credential = "device";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static GameSparksSettings()
    {
        GameSparksSettings.liveServiceUrlBase = "wss://live-{0}.ws.gamesparks.net/ws/{1}/{0}";
        GameSparksSettings.previewServiceUrlBase = "wss://preview-{0}.ws.gamesparks.net/ws/{1}/{0}";
    }

}
