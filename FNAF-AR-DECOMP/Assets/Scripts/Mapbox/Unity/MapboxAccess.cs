using UnityEngine;

namespace Mapbox.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapboxAccess : IFileSource
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Telemetry.ITelemetryLibrary _telemetryLibrary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.Cache.CachingWebFileSource _fileSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MapboxAccess.TokenValidationEvent OnTokenValidation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Unity.MapboxAccess _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Configured;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ConfigurationJSON;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MapboxConfiguration _configuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _tokenNotSetErrorMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.Geocoder _geocoder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.Directions _directions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.MapMatching.MapMatcher _mapMatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Tokens.MapboxTokenApi _tokenValidator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.TilesetTileJSON.TileJSON _tileJson;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MapboxAccess Instance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MapboxConfiguration Configuration { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.Geocoder Geocoder { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.Directions Directions { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.MapMatching.MapMatcher MapMatcher { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Tokens.MapboxTokenApi TokenValidator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.TilesetTileJSON.TileJSON TileJSON { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnTokenValidation(Mapbox.Unity.MapboxAccess.TokenValidationEvent value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnTokenValidation, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTokenValidation != 1152921519665346208);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnTokenValidation(Mapbox.Unity.MapboxAccess.TokenValidationEvent value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnTokenValidation, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTokenValidation != 1152921519665482784);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MapboxAccess get_Instance()
        {
            Mapbox.Unity.MapboxAccess val_2;
            Mapbox.Unity.MapboxAccess val_3 = Mapbox.Unity.MapboxAccess._instance;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Mapbox.Unity.MapboxAccess val_1 = null;
            val_2 = val_1;
            val_1 = new Mapbox.Unity.MapboxAccess();
            Mapbox.Unity.MapboxAccess._instance = val_2;
            val_3 = Mapbox.Unity.MapboxAccess._instance;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MapboxConfiguration get_Configuration()
        {
            return (Mapbox.Unity.MapboxConfiguration)this._configuration;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapboxAccess()
        {
            this._tokenNotSetErrorMessage = "No configuration file found! Configure your access token from the Mapbox > Setup menu.";
            this.LoadAccessToken();
            if(this._configuration != null)
            {
                    if((System.String.IsNullOrEmpty(value:  this._configuration.AccessToken)) == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  this._tokenNotSetErrorMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetConfiguration(Mapbox.Unity.MapboxConfiguration configuration, bool throwExecptions = True)
        {
            bool val_7;
            Mapbox.Unity.MapboxConfiguration val_8;
            Mapbox.Unity.MapboxAccess val_9;
            object val_10;
            var val_11;
            Mapbox.Unity.MapboxConfiguration val_12;
            val_7 = throwExecptions;
            val_8 = configuration;
            val_9 = this;
            MapboxAccess.<>c__DisplayClass16_0 val_1 = null;
            val_10 = val_1;
            val_1 = new MapboxAccess.<>c__DisplayClass16_0();
            if(val_10 == null)
            {
                goto label_1;
            }
            
            val_7 = val_10;
            .throwExecptions = val_7;
            val_11 = 1152921519666048008;
            mem[1152921519666048000] = val_9;
            mem[1152921519666048016] = val_8;
            if(val_8 != null)
            {
                goto label_4;
            }
            
            label_5:
            if(.throwExecptions == false)
            {
                goto label_4;
            }
            
            val_9 = this._tokenNotSetErrorMessage;
            MapboxAccess.InvalidTokenException val_3 = null;
            val_10 = val_3;
            val_3 = new MapboxAccess.InvalidTokenException(message:  val_9);
            label_1:
            mem[16] = val_9;
            mem[24] = 0;
            val_11 = 32;
            mem[32] = val_8;
            val_8 = mem[32];
            if(val_8 == 0)
            {
                goto label_5;
            }
            
            label_4:
            if(val_11 == 0)
            {
                goto label_7;
            }
            
            if(val_10 != null)
            {
                goto label_8;
            }
            
            val_12 = mem[32];
            if(val_12 == 0)
            {
                goto label_9;
            }
            
            label_8:
            if((System.String.IsNullOrEmpty(value:  configuration + 16)) == false)
            {
                goto label_10;
            }
            
            label_7:
            UnityEngine.Debug.LogError(message:  val_9);
            return;
            label_10:
            val_9.TokenValidator.Retrieve(accessToken:  configuration + 16, callback:  new System.Action<Mapbox.Tokens.MapboxToken>(object:  val_3, method:  System.Void MapboxAccess.<>c__DisplayClass16_0::<SetConfiguration>b__0(Mapbox.Tokens.MapboxToken response)));
            mem2[0] = mem[32];
            val_9.ConfigureFileSource();
            val_9.ConfigureTelemetry();
            Mapbox.Unity.MapboxAccess.Configured = true;
            return;
            label_9:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearAllCacheFiles()
        {
            var val_6;
            if(this._fileSource != null)
            {
                    this._fileSource.Clear();
            }
            
            string val_2 = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "cache");
            if((System.IO.Directory.Exists(path:  val_2)) == false)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_7;
            label_21:
            System.IO.File.Delete(path:  System.IO.Directory.GetFiles(path:  val_2)[0]);
            val_6 = 1;
            label_7:
            if(val_6 < val_4.Length)
            {
                goto label_21;
            }
            
            if(this._fileSource != null)
            {
                    this._fileSource.ReInit();
            }
            
            UnityEngine.Debug.Log(message:  "done clearing caches");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadAccessToken()
        {
            var val_7;
            var val_8;
            if((System.String.IsNullOrEmpty(value:  Mapbox.Unity.MapboxAccess.ConfigurationJSON)) == false)
            {
                goto label_1;
            }
            
            val_7 = null;
            val_7 = null;
            UnityEngine.TextAsset val_2 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  Constants.Path.MAPBOX_STYLES_PALETTES_FOLDER);
            if(0 == val_2)
            {
                goto label_6;
            }
            
            val_8 = null;
            Mapbox.Unity.MapboxAccess.ConfigurationJSON = val_2.text;
            goto label_8;
            label_1:
            val_8 = null;
            label_8:
            if(Mapbox.Unity.MapboxAccess.ConfigurationJSON == null)
            {
                goto label_9;
            }
            
            if(this != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            this.SetConfiguration(configuration:  UnityEngine.JsonUtility.FromJson<Mapbox.Unity.MapboxConfiguration>(json:  Mapbox.Unity.MapboxAccess.ConfigurationJSON), throwExecptions:  true);
            return;
            label_9:
            if(this != null)
            {
                goto label_11;
            }
            
            goto label_12;
            label_6:
            MapboxAccess.InvalidTokenException val_6 = new MapboxAccess.InvalidTokenException(message:  this._tokenNotSetErrorMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfigureFileSource()
        {
            if(this._configuration != null)
            {
                goto label_1;
            }
            
            this._configuration = this._configuration;
            if(this._configuration == null)
            {
                goto label_2;
            }
            
            label_1:
            this._fileSource = new Mapbox.Platform.Cache.CachingWebFileSource(accessToken:  this._configuration.AccessToken, autoRefreshCache:  this._configuration.AutoRefreshCache).AddCache(cache:  new Mapbox.Platform.Cache.MemoryCache(maxCacheSize:  this._configuration.MemoryCacheSize)).AddCache(cache:  new Mapbox.Platform.Cache.SQLiteCache(maxTileCount:  new System.Nullable<System.UInt32>() {HasValue = false}, dbName:  "cache.db"));
            return;
            label_2:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfigureTelemetry()
        {
            var val_8;
            Mapbox.Unity.Telemetry.ITelemetryLibrary val_1 = Mapbox.Unity.Telemetry.TelemetryFactory.GetTelemetryInstance();
            this._telemetryLibrary = val_1;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_8 = public System.Void Mapbox.Unity.Telemetry.ITelemetryLibrary::Initialize(string accessToken);
            val_1.Initialize(accessToken:  this._configuration.AccessToken);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = 2;
            this._telemetryLibrary.SetLocationCollectionState(enable:  val_1.GetTelemetryCollectionState());
            var val_9 = 0;
            val_9 = val_9 + 1;
            this._telemetryLibrary.SendTurnstile();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLocationCollectionState(bool enable)
        {
            var val_3;
            enable = enable;
            val_3 = 0;
            UnityEngine.PlayerPrefs.SetInt(key:  "MAPBOX_SHOULD_COLLECT_LOCATION", value:  enable);
            UnityEngine.PlayerPrefs.Save();
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 2;
            this._telemetryLibrary.SetLocationCollectionState(enable:  enable);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool GetTelemetryCollectionState()
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  "MAPBOX_SHOULD_COLLECT_LOCATION")) == true)
            {
                    return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "MAPBOX_SHOULD_COLLECT_LOCATION")) != 0) ? 1 : 0;
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  "MAPBOX_SHOULD_COLLECT_LOCATION", value:  0);
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "MAPBOX_SHOULD_COLLECT_LOCATION")) != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Request(string url, System.Action<Mapbox.Platform.Response> callback, int timeout = 10, Mapbox.Map.CanonicalTileId tileId, string mapId)
        {
            tileId.Y = tileId.Y & 4294967295;
            return this._fileSource.Request(uri:  url, callback:  callback, timeout:  this._configuration.DefaultTimeout, tileId:  new Mapbox.Map.CanonicalTileId() {Z = tileId.Z, X = tileId.X, Y = tileId.Y}, mapId:  mapId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.Geocoder get_Geocoder()
        {
            Mapbox.Geocoding.Geocoder val_3 = this._geocoder;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Mapbox.Geocoding.Geocoder val_2 = null;
            val_3 = val_2;
            val_2 = new Mapbox.Geocoding.Geocoder(fileSource:  new Mapbox.Platform.FileSource(acessToken:  this._configuration.AccessToken));
            this._geocoder = val_3;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.Directions get_Directions()
        {
            Mapbox.Directions.Directions val_3 = this._directions;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Mapbox.Directions.Directions val_2 = null;
            val_3 = val_2;
            val_2 = new Mapbox.Directions.Directions(fileSource:  new Mapbox.Platform.FileSource(acessToken:  this._configuration.AccessToken));
            this._directions = val_3;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.MapMatching.MapMatcher get_MapMatcher()
        {
            Mapbox.MapMatching.MapMatcher val_3 = this._mapMatcher;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Mapbox.MapMatching.MapMatcher val_2 = null;
            val_3 = val_2;
            val_2 = new Mapbox.MapMatching.MapMatcher(fileSource:  new Mapbox.Platform.FileSource(acessToken:  this._configuration.AccessToken), timeout:  this._configuration.DefaultTimeout);
            this._mapMatcher = val_3;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Tokens.MapboxTokenApi get_TokenValidator()
        {
            Mapbox.Tokens.MapboxTokenApi val_2 = this._tokenValidator;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            Mapbox.Tokens.MapboxTokenApi val_1 = null;
            val_2 = val_1;
            val_1 = new Mapbox.Tokens.MapboxTokenApi();
            this._tokenValidator = val_2;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.TilesetTileJSON.TileJSON get_TileJSON()
        {
            Mapbox.Platform.TilesetTileJSON.TileJSON val_3 = this._tileJson;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Mapbox.Platform.TilesetTileJSON.TileJSON val_2 = null;
            val_3 = val_2;
            val_2 = new Mapbox.Platform.TilesetTileJSON.TileJSON(fileSource:  new Mapbox.Platform.FileSource(acessToken:  this._configuration.AccessToken), timeout:  this._configuration.DefaultTimeout);
            this._tileJson = val_3;
            return val_3;
        }
    
    }

}
