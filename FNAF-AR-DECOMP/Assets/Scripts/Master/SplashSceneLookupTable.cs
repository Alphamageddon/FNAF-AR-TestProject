using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SplashSceneLookupTable : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _displayParent;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject DisplayParent { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject get_DisplayParent()
        {
            return (UnityEngine.GameObject)this._displayParent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SplashSceneLookupTable()
        {
        
        }
    
    }

}
