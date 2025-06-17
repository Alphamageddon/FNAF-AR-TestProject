using UnityEngine;

namespace Game.AssetManagement.Icons
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SpriteLinker : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string assetRef;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.UI.Image val_2 = this.gameObject.GetComponent<UnityEngine.UI.Image>();
            Master.MasterDomain val_3 = Master.MasterDomain.GetDomain();
            if(val_3.StoreDomain == null)
            {
                    return;
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2.sprite = val_3.StoreDomain.GetShopUIIcon(iconName:  this.assetRef);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SpriteLinker()
        {
        
        }
    
    }

}
