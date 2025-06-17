using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EditorLocationProviderLocationLog : AbstractEditorLocationProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.TextAsset _locationLogFile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.LocationLogReader _logReader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.IEnumerator<Mapbox.Unity.Location.Location> _locationEnumerator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._locationEnumerator != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this._locationEnumerator.Dispose();
                this._locationEnumerator = 0;
            }
            
            if(this._logReader == null)
            {
                    return;
            }
            
            this._logReader.Dispose();
            this._logReader = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SetLocation()
        {
            if(this._locationEnumerator == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            bool val_2 = this._locationEnumerator.MoveNext();
            var val_6 = 0;
            val_6 = val_6 + 1;
            T val_4 = this._locationEnumerator.Current;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EditorLocationProviderLocationLog()
        {
        
        }
    
    }

}
