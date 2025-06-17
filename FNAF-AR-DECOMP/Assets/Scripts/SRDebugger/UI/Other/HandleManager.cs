using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HandleManager : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject BottomHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject BottomLeftHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject BottomRightHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment DefaultAlignment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject LeftHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject RightHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject TopHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject TopLeftHandle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject TopRightHandle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if(this._hasSet != false)
            {
                    return;
            }
            
            this.SetAlignment(alignment:  this.DefaultAlignment);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAlignment(SRDebugger.PinAlignment alignment)
        {
            UnityEngine.GameObject val_7;
            this._hasSet = true;
            if(alignment < 2)
            {
                goto label_0;
            }
            
            if((alignment & 4294967294) != 2)
            {
                goto label_1;
            }
            
            this.SetActive(obj:  this.BottomHandle, active:  false);
            this.SetActive(obj:  this.TopHandle, active:  true);
            this.SetActive(obj:  this.BottomLeftHandle, active:  false);
            val_7 = this.BottomRightHandle;
            goto label_2;
            label_0:
            this.SetActive(obj:  this.BottomHandle, active:  true);
            this.SetActive(obj:  this.TopHandle, active:  false);
            this.SetActive(obj:  this.TopLeftHandle, active:  false);
            val_7 = this.TopRightHandle;
            label_2:
            this.SetActive(obj:  val_7, active:  false);
            label_1:
            if(alignment > 3)
            {
                    return;
            }
            
            var val_7 = 52951432;
            val_7 = (52951432 + (alignment) << 2) + val_7;
            goto (52951432 + (alignment) << 2 + 52951432);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetActive(UnityEngine.GameObject obj, bool active)
        {
            if(obj == 0)
            {
                    return;
            }
            
            obj.SetActive(value:  active);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HandleManager()
        {
        
        }
    
    }

}
