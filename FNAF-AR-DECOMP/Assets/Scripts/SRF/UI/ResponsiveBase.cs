using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class ResponsiveBase : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _queueRefresh;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.RectTransform RectTransform { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.RectTransform get_RectTransform()
        {
            var val_3;
            if(this.CachedTransform == null)
            {
                    return (UnityEngine.RectTransform)val_3;
            }
            
            if(null == null)
            {
                    return (UnityEngine.RectTransform)val_3;
            }
            
            val_3 = 0;
            return (UnityEngine.RectTransform)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnEnable()
        {
            this._queueRefresh = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnRectTransformDimensionsChange()
        {
            this._queueRefresh = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Update()
        {
            if(this._queueRefresh == false)
            {
                    return;
            }
            
            this._queueRefresh = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void Refresh(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DoRefresh()
        {
            goto typeof(SRF.UI.ResponsiveBase).__il2cppRuntimeField_168;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ResponsiveBase()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
