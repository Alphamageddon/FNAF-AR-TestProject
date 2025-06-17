using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CopyPreferredSize : LayoutElement
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform CopySource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingWidth;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float preferredWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float preferredHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int layoutPriority { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_preferredWidth()
        {
            if(this.CopySource == 0)
            {
                    return (float)-1f;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)-1f;
            }
            
            -1f = (UnityEngine.UI.LayoutUtility.GetPreferredWidth(rect:  this.CopySource)) + this.PaddingWidth;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_preferredHeight()
        {
            if(this.CopySource == 0)
            {
                    return (float)-1f;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)-1f;
            }
            
            -1f = (UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  this.CopySource)) + this.PaddingHeight;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int get_layoutPriority()
        {
            return 2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CopyPreferredSize()
        {
        
        }
    
    }

}
