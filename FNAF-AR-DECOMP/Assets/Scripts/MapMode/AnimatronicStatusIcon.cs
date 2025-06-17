using UnityEngine;

namespace MapMode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicStatusIcon : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.IconType Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.CameraBillboard Billboard;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float BlinkRate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float BlinkTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshRenderer _blinkRenderer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCamera(UnityEngine.Camera billboardCamera)
        {
            this.Billboard._camera = billboardCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Show()
        {
            this.gameObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if((this.transform.GetComponent<UnityEngine.MeshRenderer>()) == 0)
            {
                    return;
            }
            
            this.BlinkTimer = this.BlinkRate;
            UnityEngine.MeshRenderer val_5 = this.transform.GetComponent<UnityEngine.MeshRenderer>();
            this._blinkRenderer = val_5;
            val_5.enabled = true;
            this.isVisible = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            float val_3;
            if(this._blinkRenderer == 0)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.BlinkTimer - val_2;
            this.BlinkTimer = val_2;
            if(val_2 > 0f)
            {
                    return;
            }
            
            if(this._blinkRenderer == null)
            {
                goto label_5;
            }
            
            if(this.isVisible == false)
            {
                goto label_6;
            }
            
            label_8:
            this._blinkRenderer.enabled = false;
            val_3 = this.BlinkRate;
            this.isVisible = false;
            goto label_7;
            label_5:
            if(this.isVisible == true)
            {
                goto label_8;
            }
            
            label_6:
            this._blinkRenderer.enabled = true;
            val_3 = this.BlinkRate;
            this.isVisible = true;
            label_7:
            this.BlinkTimer = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicStatusIcon()
        {
            this.BlinkRate = 0.65f;
            this.isVisible = true;
        }
    
    }

}
