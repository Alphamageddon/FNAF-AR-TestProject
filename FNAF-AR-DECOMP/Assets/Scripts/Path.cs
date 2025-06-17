using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class Constants.Path
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string CONFIG_FILE = "MapboxConfiguration.txt";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string SCENELIST = "Assets/Mapbox/Resources/Mapbox/ScenesList.asset";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string SHOULD_COLLECT_LOCATION_KEY = "MAPBOX_SHOULD_COLLECT_LOCATION";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string TELEMETRY_TURNSTILE_LAST_TICKS_EDITOR_KEY = "MAPBOX_TELEMETRY_TURNSTILE_LAST_TICKS_EDITOR";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string TELEMETRY_TURNSTILE_LAST_TICKS_FALLBACK_KEY = "MAPBOX_TELEMETRY_TURNSTILE_LAST_TICKS_FALLBACK";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string DID_PROMPT_CONFIGURATION = "MAPBOX_DID_PROMPT_CONFIGURATION";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string MAPBOX_RESOURCES_RELATIVE;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string MAPBOX_RESOURCES_ABSOLUTE;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string MAPBOX_USER;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string MAPBOX_USER_MODIFIERS;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string MAP_FEATURE_STYLES_DEFAULT_STYLE_ASSETS;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string MAP_FEATURE_STYLES_SAMPLES;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string MAPBOX_STYLES_ASSETS_FOLDER = "Assets";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string MAPBOX_STYLES_ATLAS_FOLDER = "Atlas";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string MAPBOX_STYLES_MATERIAL_FOLDER = "Materials";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string MAPBOX_STYLES_PALETTES_FOLDER = "Palettes";
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static Constants.Path()
    {
        Constants.Path.MAPBOX_STYLES_PALETTES_FOLDER = System.IO.Path.Combine(path1:  "Mapbox", path2:  "MapboxConfiguration");
        Constants.Path.MAPBOX_RESOURCES_ABSOLUTE = System.IO.Path.Combine(path1:  System.IO.Path.Combine(path1:  UnityEngine.Application.dataPath, path2:  "Resources"), path2:  "Mapbox");
        Constants.Path.MAPBOX_USER = System.IO.Path.Combine(path1:  "Assets", path2:  System.IO.Path.Combine(path1:  "Mapbox", path2:  "User"));
        Constants.Path.MAPBOX_USER_MODIFIERS = System.IO.Path.Combine(path1:  Constants.Path.MAPBOX_USER, path2:  "Modifiers");
        Constants.Path.MAP_FEATURE_STYLES_DEFAULT_STYLE_ASSETS = System.IO.Path.Combine(path1:  "MapboxStyles", path2:  "DefaultStyleAssets");
        Constants.Path.MAP_FEATURE_STYLES_SAMPLES = System.IO.Path.Combine(path1:  System.IO.Path.Combine(path1:  "MapboxStyles", path2:  "Styles"), path2:  "MapboxSampleStyles");
    }

}
