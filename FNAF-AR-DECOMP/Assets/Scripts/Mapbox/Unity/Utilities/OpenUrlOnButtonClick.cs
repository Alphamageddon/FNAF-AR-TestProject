using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class OpenUrlOnButtonClick : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _url;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Mapbox.Unity.Utilities.OpenUrlOnButtonClick::VisitUrl()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VisitUrl()
        {
            UnityEngine.Application.OpenURL(url:  this._url);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OpenUrlOnButtonClick()
        {
        
        }
    
    }

}
