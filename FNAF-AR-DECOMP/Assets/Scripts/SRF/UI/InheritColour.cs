using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InheritColour : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Graphic _graphic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Graphic From;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Graphic Graphic { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Graphic get_Graphic()
        {
            UnityEngine.UI.Graphic val_3;
            if(this._graphic == 0)
            {
                    this._graphic = this.GetComponent<UnityEngine.UI.Graphic>();
                return val_3;
            }
            
            val_3 = this._graphic;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            if(this.From == 0)
            {
                    return;
            }
            
            UnityEngine.Color val_4 = this.From.canvasRenderer.GetColor();
            if(this.Graphic == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InheritColour()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
