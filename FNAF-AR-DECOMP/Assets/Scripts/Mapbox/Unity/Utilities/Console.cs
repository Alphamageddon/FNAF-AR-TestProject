using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Console : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _toggleButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _menu;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _logText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect _logScroll;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Unity.Utilities.Console _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _log;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Utilities.Console Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Utilities.Console get_Instance()
        {
            return (Mapbox.Unity.Utilities.Console)Mapbox.Unity.Utilities.Console._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            if(Mapbox.Unity.Utilities.Console._instance != 0)
            {
                    UnityEngine.Debug.LogError(message:  "Duplicate singleton!", context:  this.gameObject);
            }
            
            Mapbox.Unity.Utilities.Console._instance = this;
            this.ClearLog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearLog()
        {
            this._log = "";
            this._logScroll.verticalNormalizedPosition = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Log(string log, string color)
        {
            if((System.String.IsNullOrEmpty(value:  this._log)) != true)
            {
                    if(this._log.Length >= 15001)
            {
                    this._log = "";
            }
            
            }
            
            this._log = this._log + System.String.Format(format:  "<color={0}>{1}</color>\n", arg0:  color, arg1:  log)(System.String.Format(format:  "<color={0}>{1}</color>\n", arg0:  color, arg1:  log));
            this._logScroll.verticalNormalizedPosition = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleMenu()
        {
            var val_4;
            if(this._menu != null)
            {
                    val_4 = this._menu.activeSelf;
            }
            else
            {
                    val_4 = 0.activeSelf;
            }
            
            this._menu.SetActive(value:  (~val_4) & 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Console()
        {
        
        }
    
    }

}
