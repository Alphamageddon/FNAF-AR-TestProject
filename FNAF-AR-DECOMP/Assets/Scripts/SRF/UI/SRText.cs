using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRText : Text
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<SRF.UI.SRText> LayoutDirty;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LayoutDirty(System.Action<SRF.UI.SRText> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LayoutDirty, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LayoutDirty != 1152921520768064352);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LayoutDirty(System.Action<SRF.UI.SRText> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LayoutDirty, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LayoutDirty != 1152921520768200928);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLayoutDirty()
        {
            this.SetLayoutDirty();
            if(this.LayoutDirty == null)
            {
                    return;
            }
            
            this.LayoutDirty.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRText()
        {
        
        }
    
    }

}
