using UnityEngine;

namespace Mapbox.Examples.Playground
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ReverseGeocoderExample : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.ReverseGeocodeUserInput _searchLocation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _resultsText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._searchLocation.add_OnGeocoderResponse(value:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void Mapbox.Examples.Playground.ReverseGeocoderExample::SearchLocation_OnGeocoderResponse(object sender, System.EventArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._searchLocation == 0)
            {
                    return;
            }
            
            this._searchLocation.remove_OnGeocoderResponse(value:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void Mapbox.Examples.Playground.ReverseGeocoderExample::SearchLocation_OnGeocoderResponse(object sender, System.EventArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SearchLocation_OnGeocoderResponse(object sender, System.EventArgs e)
        {
            string val_2 = Mapbox.Json.JsonConvert.SerializeObject(value:  this._searchLocation.<Response>k__BackingField, formatting:  1, converters:  Mapbox.Utils.JsonConverters.JsonConverters.Converters);
            if(this._resultsText == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReverseGeocoderExample()
        {
        
        }
    
    }

}
