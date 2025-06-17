using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EditorLocationProviderDebugLog : EditorLocationProviderLocationLog
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _offset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateLocation(Mapbox.Utils.Vector2d newOffset)
        {
            this._offset = newOffset;
            mem[1152921519785427616] = newOffset.y;
            this._offset = (double)UnityEngine.Mathf.Clamp(value:  (float)newOffset.x, min:  -90f, max:  90f);
            mem[1152921519785427616] = (double)UnityEngine.Mathf.Clamp(value:  (float)-90f, min:  -180f, max:  180f);
            goto typeof(Mapbox.Unity.Location.EditorLocationProviderDebugLog).__il2cppRuntimeField_1B8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SetLocation()
        {
            this.SetLocation();
            if(this._offset < (-90))
            {
                    return;
            }
            
            if(this._offset > 90)
            {
                    return;
            }
            
            if(90 < (-180))
            {
                    return;
            }
            
            if(90 > 180)
            {
                    return;
            }
            
            mem[1152921519785539448] = this._offset;
            mem[1152921519785539456] = 90;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidLatLon()
        {
            if(this._offset < (-90))
            {
                    return false;
            }
            
            if(this._offset > 90)
            {
                    return false;
            }
            
            return (bool)((this._offset >= (-180)) ? 1 : 0) & ((this._offset <= 180) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EditorLocationProviderDebugLog()
        {
            Mapbox.Utils.Vector2d val_1 = new Mapbox.Utils.Vector2d(x:  200, y:  200);
            this._offset = val_1.x;
            mem[1152921519785763616] = val_1.y;
            this = new Mapbox.Unity.Location.AbstractEditorLocationProvider();
        }
    
    }

}
