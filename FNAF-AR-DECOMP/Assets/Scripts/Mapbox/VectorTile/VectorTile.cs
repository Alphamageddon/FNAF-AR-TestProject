using UnityEngine;

namespace Mapbox.VectorTile
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorTile
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.VectorTile.VectorTileReader _VTR;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTile(byte[] data, bool validate = True)
        {
            Mapbox.VectorTile.VectorTileReader val_1 = null;
            validate = validate;
            val_1 = new Mapbox.VectorTile.VectorTileReader(data:  data, validate:  validate);
            this._VTR = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<string> LayerNames()
        {
            if(this._VTR != null)
            {
                    return this._VTR.LayerNames();
            }
            
            return this._VTR.LayerNames();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileLayer GetLayer(string layerName)
        {
            if(this._VTR != null)
            {
                    return this._VTR.GetLayer(name:  layerName);
            }
            
            return this._VTR.GetLayer(name:  layerName);
        }
    
    }

}
