using UnityEngine;

namespace VLB_Samples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeaturesNotSupportedMessage : MonoBehaviour
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            var val_5;
            UnityEngine.UI.Text val_1 = this.GetComponent<UnityEngine.UI.Text>();
            if(VLB.Noise3D.isSupported != false)
            {
                    val_5 = "";
                if(val_1 != null)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
            }
            
            }
            else
            {
                    val_5 = VLB.Noise3D.isNotSupportedString;
                if(val_1 != null)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
            }
            
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeaturesNotSupportedMessage()
        {
        
        }
    
    }

}
