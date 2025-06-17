using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AbstractEditorLocationProvider : AbstractLocationProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int _accuracy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _autoFireEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _updateInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _sendEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _wait;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator QueryLocation()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AbstractEditorLocationProvider.<QueryLocation>d__5();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendLocationEvent()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnValidate()
        {
            if(this._sendEvent == false)
            {
                    return;
            }
            
            this._sendEvent = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void SetLocation(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AbstractEditorLocationProvider()
        {
            this._wait = new UnityEngine.WaitForSeconds(seconds:  0f);
        }
    
    }

}
