using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Scaler : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float maxWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float maxHeight;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Object val_20;
            float val_23;
            float val_24;
            float val_28;
            float val_29;
            UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
            val_20 = 0;
            if(this.transform.parent != 0)
            {
                    val_20 = this.transform.parent.GetComponent<UnityEngine.RectTransform>();
            }
            
            UnityEngine.Rect val_8 = val_1.rect;
            val_23 = 0f;
            if(val_20 != 0)
            {
                    UnityEngine.Rect val_10 = val_20.rect;
                val_23 = val_10.m_XMin;
            }
            
            if(val_8.m_XMin <= 0f)
            {
                goto label_12;
            }
            
            val_10.m_XMin = val_23 * this.maxWidth;
            val_24 = UnityEngine.Mathf.Min(a:  1f, b:  val_10.m_XMin / val_8.m_XMin);
            if(val_1 != null)
            {
                goto label_17;
            }
            
            goto label_16;
            label_12:
            val_24 = 1f;
            if(val_1 != null)
            {
                goto label_17;
            }
            
            label_16:
            label_17:
            UnityEngine.Rect val_13 = val_1.rect;
            val_28 = 0f;
            if(val_20 != 0)
            {
                    UnityEngine.Rect val_15 = val_20.rect;
                val_28 = val_15.m_XMin;
            }
            
            if(val_8.m_XMin > 0f)
            {
                    val_15.m_XMin = val_28 * this.maxHeight;
                val_29 = UnityEngine.Mathf.Min(a:  1f, b:  val_15.m_XMin / val_13.m_XMin);
            }
            else
            {
                    val_29 = 1f;
            }
            
            float val_18 = UnityEngine.Mathf.Min(a:  val_24, b:  val_29);
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Scaler()
        {
            this.maxWidth = 1f;
            this.maxHeight = 1f;
        }
    
    }

}
