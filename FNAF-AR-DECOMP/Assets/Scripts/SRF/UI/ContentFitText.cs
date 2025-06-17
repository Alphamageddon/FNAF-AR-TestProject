using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ContentFitText : UIBehaviour, ILayoutElement
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRText CopySource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 Padding;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float preferredWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float flexibleWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float preferredHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float flexibleHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int layoutPriority { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_minWidth()
        {
            if(this.CopySource == 0)
            {
                    return (float)val_3;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  this.CopySource.rectTransform);
            val_3 = val_3 + this.Padding;
            return (float)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_preferredWidth()
        {
            if(this.CopySource == 0)
            {
                    return (float)val_3;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredWidth(rect:  this.CopySource.rectTransform);
            val_3 = val_3 + this.Padding;
            return (float)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_flexibleWidth()
        {
            if(this.CopySource != 0)
            {
                    return UnityEngine.UI.LayoutUtility.GetFlexibleWidth(rect:  this.CopySource.rectTransform);
            }
            
            return -1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_minHeight()
        {
            if(this.CopySource == 0)
            {
                    return (float)val_3;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetFlexibleHeight(rect:  this.CopySource.rectTransform);
            val_3 = val_3 + S1;
            return (float)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_preferredHeight()
        {
            if(this.CopySource == 0)
            {
                    return (float)val_3;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  this.CopySource.rectTransform);
            val_3 = val_3 + S1;
            return (float)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_flexibleHeight()
        {
            if(this.CopySource != 0)
            {
                    return UnityEngine.UI.LayoutUtility.GetFlexibleHeight(rect:  this.CopySource.rectTransform);
            }
            
            return -1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_layoutPriority()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CalculateLayoutInputHorizontal()
        {
            this.CopySource.CalculateLayoutInputHorizontal();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CalculateLayoutInputVertical()
        {
            this.CopySource.CalculateLayoutInputVertical();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.SetDirty();
            this.CopySource.add_LayoutDirty(value:  new System.Action<SRF.UI.SRText>(object:  this, method:  System.Void SRF.UI.ContentFitText::CopySourceOnLayoutDirty(SRF.UI.SRText srText)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CopySourceOnLayoutDirty(SRF.UI.SRText srText)
        {
            this.SetDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnTransformParentChanged()
        {
            this.SetDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDisable()
        {
            this.CopySource.remove_LayoutDirty(value:  new System.Action<SRF.UI.SRText>(object:  this, method:  System.Void SRF.UI.ContentFitText::CopySourceOnLayoutDirty(SRF.UI.SRText srText)));
            this.SetDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDidApplyAnimationProperties()
        {
            this.SetDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnBeforeTransformParentChanged()
        {
            this.SetDirty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetDirty()
        {
            UnityEngine.RectTransform val_3;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.transform;
            if(val_2 != null)
            {
                    val_2 = (null == null) ? (val_2) : 0;
            }
            else
            {
                    val_3 = 0;
            }
            
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ContentFitText()
        {
        
        }
    
    }

}
