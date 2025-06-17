using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ChangeShadowDistance : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ShadowDistance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.QualitySettings.shadowDistance = (float)this.ShadowDistance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChangeShadowDistance()
        {
        
        }
    
    }

}
