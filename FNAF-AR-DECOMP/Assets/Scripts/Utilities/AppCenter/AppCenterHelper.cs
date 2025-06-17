using UnityEngine;

namespace Utilities.AppCenter
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AppCenterHelper : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _reportUnhandledExceptions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ReportUnhandledExceptions { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ReportUnhandledExceptions()
        {
            return (bool)this._reportUnhandledExceptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ReportUnhandledExceptions(bool value)
        {
            bool val_1 = value;
            this._reportUnhandledExceptions = val_1;
            Microsoft.AppCenter.Unity.Crashes.Crashes.ReportUnhandledExceptions(enabled:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            Microsoft.AppCenter.Unity.Crashes.Crashes.ReportUnhandledExceptions(enabled:  (this._reportUnhandledExceptions == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppCenterHelper()
        {
            this._reportUnhandledExceptions = true;
        }
    
    }

}
