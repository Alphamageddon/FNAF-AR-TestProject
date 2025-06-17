using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Style
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color ActiveColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color DisabledColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color HoverColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite Image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color NormalColor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.Style Copy()
        {
            SRF.UI.Style val_1 = new SRF.UI.Style();
            val_1.CopyFrom(style:  this);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyFrom(SRF.UI.Style style)
        {
            if(style != null)
            {
                    this.Image = style.Image;
            }
            else
            {
                    this.Image = 1;
            }
            
            this.NormalColor = style.NormalColor;
            mem[1152921520770874764] = ???;
            mem[1152921520770874772] = ???;
            this.HoverColor = style.HoverColor;
            mem[1152921520770874740] = ???;
            mem[1152921520770874748] = ???;
            this.ActiveColor = style.ActiveColor;
            mem[1152921520770874708] = ???;
            mem[1152921520770874716] = ???;
            this.DisabledColor = style.DisabledColor;
            mem[1152921520770874724] = ???;
            mem[1152921520770874732] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Style()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.ActiveColor = val_1;
            mem[1152921520770994900] = val_1.g;
            mem[1152921520770994904] = val_1.b;
            mem[1152921520770994908] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.DisabledColor = val_2;
            mem[1152921520770994916] = val_2.g;
            mem[1152921520770994920] = val_2.b;
            mem[1152921520770994924] = val_2.a;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            this.HoverColor = val_3;
            mem[1152921520770994932] = val_3.g;
            mem[1152921520770994936] = val_3.b;
            mem[1152921520770994940] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            this.NormalColor = val_4;
            mem[1152921520770994956] = val_4.g;
            mem[1152921520770994960] = val_4.b;
            mem[1152921520770994964] = val_4.a;
        }
    
    }

}
