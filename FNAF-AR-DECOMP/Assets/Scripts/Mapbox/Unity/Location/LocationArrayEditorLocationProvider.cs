using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationArrayEditorLocationProvider : AbstractEditorLocationProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _latitudeLongitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _heading;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int idx;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d LatitudeLongitude { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d get_LatitudeLongitude()
        {
            return Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  this._latitudeLongitude[0]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SetLocation()
        {
            mem[1152921519786550248] = this._heading;
            Mapbox.Utils.Vector2d val_1 = this.LatitudeLongitude;
            mem[1152921519786550232] = val_1.x;
            mem[1152921519786550240] = val_1.y;
            mem[1152921519786550272] = (float)S2;
            System.DateTime val_2 = System.DateTime.UtcNow;
            mem[1152921519786550256] = Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime() {dateData = val_2.dateData});
            mem[1152921519786550278] = 1;
            mem[1152921519786550328] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationArrayEditorLocationProvider()
        {
            this.idx = 0;
        }
    
    }

}
