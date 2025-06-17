using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResponsiveResize : ResponsiveBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.ResponsiveResize.Element[] Elements;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Refresh()
        {
            var val_10;
            var val_11;
            var val_12;
            UnityEngine.Rect val_2 = this.RectTransform.rect;
            val_10 = 0;
            goto label_2;
            label_20:
            Element val_10 = this.Elements[0];
            Element val_11 = this.Elements[0];
            if(val_11 == 0)
            {
                goto label_17;
            }
            
            val_11 = 0;
            val_12 = -1f;
            goto label_8;
            label_11:
            var val_4 = ((mem[this.Elements[0x0][0].SizeDefinitions + 32 + 4]) <= val_2.m_XMin) ? 1 : 0;
            var val_5 = ((mem[this.Elements[0x0][0].SizeDefinitions + 32 + 4]) > (-3.402823E+38f)) ? 1 : 0;
            float val_6 = (val_5 != val_4) ? (mem[this.Elements[0x0][0].SizeDefinitions + 32]) : (val_12);
            var val_7 = (val_5 != val_4) ? (mem[this.Elements[0x0][0].SizeDefinitions + 32 + 4]) : -3.402823E+38f;
            val_11 = 1;
            label_8:
            if(val_11 < (mem[this.Elements[0x0][0] + 24]))
            {
                goto label_11;
            }
            
            if(val_6 > 0f)
            {
                    if(val_11 != 0)
            {
                    val_11.SetSizeWithCurrentAnchors(axis:  0, size:  val_6);
            }
            else
            {
                    0.SetSizeWithCurrentAnchors(axis:  0, size:  val_6);
            }
            
                bool val_9 = UnityEngine.Object.op_Inequality(x:  val_11.GetComponent<UnityEngine.UI.LayoutElement>(), y:  0);
            }
            
            label_17:
            val_10 = 1;
            label_2:
            if(val_10 < this.Elements.Length)
            {
                goto label_20;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResponsiveResize()
        {
            this.Elements = new Element[0];
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
