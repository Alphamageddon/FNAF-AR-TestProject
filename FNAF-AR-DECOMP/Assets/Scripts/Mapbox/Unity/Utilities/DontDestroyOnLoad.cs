using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DontDestroyOnLoad : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Unity.Utilities.DontDestroyOnLoad _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useSingleInstance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            if((Mapbox.Unity.Utilities.DontDestroyOnLoad._instance != 0) && (this._useSingleInstance != false))
            {
                    UnityEngine.Object.Destroy(obj:  this.gameObject);
                return;
            }
            
            Mapbox.Unity.Utilities.DontDestroyOnLoad._instance = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DontDestroyOnLoad()
        {
        
        }
    
    }

}
