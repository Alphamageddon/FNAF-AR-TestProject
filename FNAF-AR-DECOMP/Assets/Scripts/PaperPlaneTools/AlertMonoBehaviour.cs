using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertMonoBehaviour : MonoBehaviour
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AlertAndroid_OnButtonClick(string buttonType)
        {
            PaperPlaneTools.AlertManager.Instance.HandleEvent(eventName:  "AlertAndroid_OnButtonClick", value:  buttonType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AlertAndroid_OnCancel(string nothing)
        {
            PaperPlaneTools.AlertManager.Instance.HandleEvent(eventName:  "AlertAndroid_OnCancel", value:  nothing);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AlertAndroid_OnDismiss(string nothing)
        {
            PaperPlaneTools.AlertManager.Instance.HandleEvent(eventName:  "AlertAndroid_OnDismiss", value:  nothing);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AlertIOS_OnButtonClick(string tag)
        {
            PaperPlaneTools.AlertManager.Instance.HandleEvent(eventName:  "AlertIOS_OnButtonClick", value:  tag);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AlertIOS_OnDismiss(string nothing)
        {
            PaperPlaneTools.AlertManager.Instance.HandleEvent(eventName:  "AlertIOS_OnDismiss", value:  nothing);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertMonoBehaviour()
        {
        
        }
    
    }

}
