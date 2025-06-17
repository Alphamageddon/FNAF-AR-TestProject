using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CopySizeIntoLayoutElement : LayoutElement
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform CopySource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetPreferredSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetMinimumSize;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float preferredWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float preferredHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float minWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float minHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int layoutPriority { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_preferredWidth()
        {
            if(this.SetPreferredSize == false)
            {
                    return (float)-1f;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)-1f;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)-1f;
            }
            
            UnityEngine.Rect val_3 = this.CopySource.rect;
            -1f = val_3.m_XMin + this.PaddingWidth;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_preferredHeight()
        {
            if(this.SetPreferredSize == false)
            {
                    return (float)-1f;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)-1f;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)-1f;
            }
            
            UnityEngine.Rect val_3 = this.CopySource.rect;
            -1f = val_3.m_XMin + this.PaddingHeight;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_minWidth()
        {
            if(this.SetMinimumSize == false)
            {
                    return (float)-1f;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)-1f;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)-1f;
            }
            
            UnityEngine.Rect val_3 = this.CopySource.rect;
            -1f = val_3.m_XMin + this.PaddingWidth;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_minHeight()
        {
            if(this.SetMinimumSize == false)
            {
                    return (float)-1f;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)-1f;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)-1f;
            }
            
            UnityEngine.Rect val_3 = this.CopySource.rect;
            -1f = val_3.m_XMin + this.PaddingHeight;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int get_layoutPriority()
        {
            return 2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CopySizeIntoLayoutElement()
        {
        
        }
    
    }

}
