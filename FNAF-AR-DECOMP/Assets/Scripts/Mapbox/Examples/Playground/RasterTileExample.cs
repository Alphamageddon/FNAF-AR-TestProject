using UnityEngine;

namespace Mapbox.Examples.Playground
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RasterTileExample : MonoBehaviour, IObserver<Mapbox.Map.RasterTile>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.ForwardGeocodeUserInput _searchLocation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Slider _zoomSlider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Dropdown _stylesDropdown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.RawImage _imageContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.Map<Mapbox.Map.RasterTile> _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _latLon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _mapboxStyles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _startLoc;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _mapstyle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._searchLocation.add_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.RasterTileExample::SearchLocation_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
            this._stylesDropdown.ClearOptions();
            this._stylesDropdown.AddOptions(options:  System.Linq.Enumerable.ToList<System.String>(source:  this._mapboxStyles));
            this._stylesDropdown.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void Mapbox.Examples.Playground.RasterTileExample::ToggleDropdownStyles(int target)));
            this._zoomSlider.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void Mapbox.Examples.Playground.RasterTileExample::AdjustZoom(float value)));
            char[] val_7 = new char[1];
            val_7[0] = ',';
            System.String[] val_8 = this._latLon.Split(separator:  val_7);
            this._startLoc = System.Double.Parse(s:  val_8[0]);
            mem[1152921519874882344] = System.Double.Parse(s:  val_8[1]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._searchLocation == 0)
            {
                    return;
            }
            
            this._searchLocation.remove_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.RasterTileExample::SearchLocation_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Mapbox.Map.Map<Mapbox.Map.RasterTile> val_2 = new Mapbox.Map.Map<Mapbox.Map.RasterTile>(fs:  Mapbox.Unity.MapboxAccess.Instance);
            this._map = val_2;
            val_2.MapId = this._mapboxStyles[this._mapstyle];
            this._map.Center = new Mapbox.Utils.Vector2d() {x = this._startLoc, y = V9.16B};
            this._map.Zoom = (int)this._startLoc;
            this._map.Subscribe(observer:  this);
            this._map.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SearchLocation_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)
        {
            this._map.Center = new Mapbox.Utils.Vector2d() {x = this._searchLocation._coordinate, y = V9.16B};
            this._map.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AdjustZoom(float value)
        {
            this._map.Zoom = (int)value;
            this._map.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ToggleDropdownStyles(int target)
        {
            this._mapstyle = target;
            this._map.MapId = this._mapboxStyles[(long)target];
            this._map.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNext(Mapbox.Map.RasterTile tile)
        {
            if(tile.HasError == true)
            {
                    return;
            }
            
            if(true != 4)
            {
                    if(true != 2)
            {
                    return;
            }
            
            }
            
            UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  256, height:  256);
            bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  tile.data);
            this._imageContainer.texture = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RasterTileExample()
        {
            string[] val_1 = new string[4];
            val_1[0] = "mapbox://styles/mapbox/satellite-v9";
            val_1[1] = "mapbox://styles/mapbox/streets-v9";
            val_1[2] = "mapbox://styles/mapbox/dark-v9";
            val_1[3] = "mapbox://styles/mapbox/light-v9";
            this._mapboxStyles = val_1;
        }
    
    }

}
