using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResponsiveEnable : ResponsiveBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.ResponsiveEnable.Entry[] Entries;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Refresh()
        {
            var val_12;
            Entry val_13;
            Entry val_14;
            var val_15;
            var val_16;
            UnityEngine.Rect val_2 = this.RectTransform.rect;
            val_12 = 0;
            goto label_2;
            label_32:
            Entry val_14 = this.Entries[0];
            val_13 = this.Entries[0];
            Entry val_16 = this.Entries[0];
            val_14 = this.Entries[0];
            if(val_14 == 1)
            {
                goto label_5;
            }
            
            if(val_14 != 0)
            {
                goto label_6;
            }
            
            if(val_16 <= 0f)
            {
                goto label_7;
            }
            
            var val_3 = (val_2.m_XMin >= val_16) ? 1 : 0;
            goto label_8;
            label_5:
            if(val_16 <= 0f)
            {
                goto label_9;
            }
            
            var val_4 = (val_2.m_XMin <= val_16) ? 1 : 0;
            goto label_10;
            label_7:
            val_15 = 1;
            label_8:
            if(val_14 <= 0f)
            {
                goto label_14;
            }
            
            val_15 = val_15 & ((val_2.m_XMin >= val_14) ? 1 : 0);
            if(val_13 != 0)
            {
                goto label_12;
            }
            
            goto label_16;
            label_9:
            val_16 = 1;
            label_10:
            var val_6 = (val_16 != 0) ? 1 : 0;
            if(val_14 > 0f)
            {
                    bool val_8 = (((val_2.m_XMin <= val_14) ? 1 : 0) != val_16) ? 1 : 0;
            }
            
            label_14:
            if(val_13 == 0)
            {
                goto label_16;
            }
            
            label_12:
            if(this.Entries[0x0][1].ThresholdWidth >= (1.401298E-45f))
            {
                    do
            {
                val_14 = mem[this.Entries[0x0][1].Components + 32];
                if(val_14 != 0)
            {
                    val_14.SetActive(value:  val_8);
            }
            
            }
            while((0 + 1) < this.Entries[0x0][1].ThresholdWidth);
            
            }
            
            label_16:
            if((this.Entries[0] != 0) && (this.Entries[0x0][0].ThresholdWidth >= (1.401298E-45f)))
            {
                    do
            {
                val_13 = 0;
                val_14 = mem[this.Entries[0x0][0].Components + 32];
                if(val_14 != 0)
            {
                    val_14.enabled = val_8;
            }
            
            }
            while((val_13 + 1) < this.Entries[0x0][0].ThresholdWidth);
            
            }
            
            val_12 = 1;
            label_2:
            if(val_12 < this.Entries.Length)
            {
                goto label_32;
            }
            
            return;
            label_6:
            System.IndexOutOfRangeException val_13 = new System.IndexOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResponsiveEnable()
        {
            this.Entries = new Entry[0];
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
