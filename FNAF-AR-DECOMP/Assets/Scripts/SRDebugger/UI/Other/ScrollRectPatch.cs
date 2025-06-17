using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScrollRectPatch : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform Content;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Mask ReplaceMask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform Viewport;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.RectTransform val_8;
            UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            if(val_1 != null)
            {
                    val_1.content = this.Content;
                val_8 = this.Viewport;
            }
            else
            {
                    val_1.content = this.Content;
                val_8 = this.Viewport;
            }
            
            val_1.viewport = val_8;
            if(this.ReplaceMask == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this.ReplaceMask.gameObject;
            UnityEngine.Object.Destroy(obj:  val_3.GetComponent<UnityEngine.UI.Graphic>());
            if(val_3 != null)
            {
                    UnityEngine.Object.Destroy(obj:  val_3.GetComponent<UnityEngine.CanvasRenderer>());
                UnityEngine.Object.Destroy(obj:  this.ReplaceMask);
            }
            else
            {
                    UnityEngine.Object.Destroy(obj:  0.GetComponent<UnityEngine.CanvasRenderer>());
                UnityEngine.Object.Destroy(obj:  this.ReplaceMask);
            }
            
            UnityEngine.UI.RectMask2D val_7 = val_3.AddComponent<UnityEngine.UI.RectMask2D>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScrollRectPatch()
        {
        
        }
    
    }

}
