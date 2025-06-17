using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationLogReader : LocationLogAbstractBase, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.IO.TextReader _textReader;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationLogReader(byte[] contents)
        {
            this._textReader = new System.IO.StreamReader(stream:  new System.IO.MemoryStream(buffer:  contents));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Finalize()
        {
            this.Finalize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            System.GC.SuppressFinalize(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Dispose(bool disposeManagedResources)
        {
            if(this._disposed == true)
            {
                    return;
            }
            
            if((disposeManagedResources != false) && (this._textReader != null))
            {
                    this._textReader.Dispose();
                this._textReader = 0;
            }
            
            this._disposed = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<Mapbox.Unity.Location.Location> GetLocations()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerator<Mapbox.Unity.Location.Location>)new LocationLogReader.<GetLocations>d__6();
        }
    
    }

}
