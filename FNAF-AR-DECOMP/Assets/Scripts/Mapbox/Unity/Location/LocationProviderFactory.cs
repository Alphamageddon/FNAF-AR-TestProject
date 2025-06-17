using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationProviderFactory : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap mapManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.AbstractLocationProvider _deviceLocationProviderUnity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.DeviceLocationProviderAndroidNative _deviceLocationProviderAndroid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.AbstractLocationProvider _editorLocationProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.AbstractLocationProvider _transformLocationProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _dontDestroyOnLoad;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Unity.Location.LocationProviderFactory _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<Mapbox.Unity.Location.ILocationProvider> OnLocationProviderSelected;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider _defaultLocationProvider;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Location.LocationProviderFactory Instance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider DefaultLocationProvider { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider TransformLocationProvider { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider EditorLocationProvider { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider DeviceLocationProvider { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Location.LocationProviderFactory get_Instance()
        {
            return (Mapbox.Unity.Location.LocationProviderFactory)Mapbox.Unity.Location.LocationProviderFactory._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void set_Instance(Mapbox.Unity.Location.LocationProviderFactory value)
        {
            Mapbox.Unity.Location.LocationProviderFactory._instance = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider get_DefaultLocationProvider()
        {
            return (Mapbox.Unity.Location.ILocationProvider)this._defaultLocationProvider;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DefaultLocationProvider(Mapbox.Unity.Location.ILocationProvider value)
        {
            this._defaultLocationProvider = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider get_TransformLocationProvider()
        {
            return (Mapbox.Unity.Location.ILocationProvider)this._transformLocationProvider;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider get_EditorLocationProvider()
        {
            return (Mapbox.Unity.Location.ILocationProvider)this._editorLocationProvider;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider get_DeviceLocationProvider()
        {
            return (Mapbox.Unity.Location.ILocationProvider)this._deviceLocationProviderUnity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            if(Mapbox.Unity.Location.LocationProviderFactory._instance != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.gameObject);
                return;
            }
            
            Mapbox.Unity.Location.LocationProviderFactory._instance = this;
            if(this._dontDestroyOnLoad != false)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            }
            
            this.InjectDeviceLocationProvider();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InjectEditorLocationProvider()
        {
            object[] val_1 = new object[1];
            System.Type val_2 = this._editorLocationProvider.GetType();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            UnityEngine.Debug.LogFormat(format:  "LocationProviderFactory: Injected EDITOR Location Provider - {0}", args:  val_1);
            this._defaultLocationProvider = this._editorLocationProvider;
            if(this.OnLocationProviderSelected == null)
            {
                    return;
            }
            
            this.OnLocationProviderSelected.Invoke(obj:  this._editorLocationProvider);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InjectDeviceLocationProvider()
        {
            object val_19;
            int val_7 = 0;
            System.Text.RegularExpressions.Match val_3 = new System.Text.RegularExpressions.Regex(pattern:  "(?<=API-)-?\\d+").Match(input:  UnityEngine.SystemInfo.operatingSystem);
            if(val_3.Success != false)
            {
                    bool val_8 = System.Int32.TryParse(s:  val_3.Item[0].Value, result: out  val_7);
            }
            
            object[] val_9 = new object[2];
            val_9[0] = UnityEngine.SystemInfo.operatingSystem;
            val_19 = 0;
            val_9[1] = val_19;
            UnityEngine.Debug.LogFormat(format:  "{0} => API version: {1}", args:  val_9);
            if(((UnityEngine.Application.platform == 11) && (0 != this._deviceLocationProviderAndroid)) && (this._deviceLocationProviderAndroid.enabled != false))
            {
                    if(val_7 >= 24)
            {
                    if(this._deviceLocationProviderAndroid.transform.gameObject.activeInHierarchy == true)
            {
                goto label_26;
            }
            
            }
            
            }
            
            object[] val_17 = new object[1];
            val_19 = this._deviceLocationProviderUnity.GetType();
            val_17[0] = val_19;
            UnityEngine.Debug.LogFormat(format:  "LocationProviderFactory: Injected DEVICE Location Provider - {0}", args:  val_17);
            label_26:
            this._defaultLocationProvider = this._deviceLocationProviderUnity;
            if(this.OnLocationProviderSelected == null)
            {
                    return;
            }
            
            this.OnLocationProviderSelected.Invoke(obj:  this._deviceLocationProviderUnity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationProviderFactory()
        {
        
        }
    
    }

}
