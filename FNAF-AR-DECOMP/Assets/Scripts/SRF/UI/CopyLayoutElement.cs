using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CopyLayoutElement : UIBehaviour, ILayoutElement
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CopyMinHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CopyMinWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CopyPreferredHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CopyPreferredWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform CopySource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingMinHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingMinWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingPreferredHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PaddingPreferredWidth;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float preferredWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float preferredHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int layoutPriority { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float flexibleHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float flexibleWidth { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_preferredWidth()
        {
            if(this.CopyPreferredWidth == false)
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
            
            -1f = (UnityEngine.UI.LayoutUtility.GetPreferredWidth(rect:  this.CopySource)) + this.PaddingPreferredWidth;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_preferredHeight()
        {
            if(this.CopyPreferredHeight == false)
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
            
            -1f = (UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  this.CopySource)) + this.PaddingPreferredHeight;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_minWidth()
        {
            if(this.CopyMinWidth == false)
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
            
            -1f = (UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  this.CopySource)) + this.PaddingMinWidth;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_minHeight()
        {
            if(this.CopyMinHeight == false)
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
            
            -1f = (UnityEngine.UI.LayoutUtility.GetMinHeight(rect:  this.CopySource)) + this.PaddingMinHeight;
            return (float)-1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_layoutPriority()
        {
            return 2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_flexibleHeight()
        {
            return -1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_flexibleWidth()
        {
            return -1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CalculateLayoutInputHorizontal()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CalculateLayoutInputVertical()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CopyLayoutElement()
        {
        
        }
    
    }

}
