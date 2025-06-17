using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TelemetryConfigurationButton : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _booleanValue;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Mapbox.Unity.Utilities.TelemetryConfigurationButton::SetPlayerPref()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetPlayerPref()
        {
            Mapbox.Unity.MapboxAccess.Instance.SetLocationCollectionState(enable:  (this._booleanValue == true) ? 1 : 0);
            UnityEngine.PlayerPrefs.Save();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TelemetryConfigurationButton()
        {
        
        }
    
    }

}
