using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StyleComponent : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.Style _activeStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.StyleRoot _cachedRoot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Graphic _graphic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasStarted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Selectable _selectable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _styleKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IgnoreImage;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StyleKey { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_StyleKey()
        {
            return (string)this._styleKey;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StyleKey(string value)
        {
            this._styleKey = value;
            this.Refresh(invalidateCache:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.Refresh(invalidateCache:  true);
            this._hasStarted = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            if(this._hasStarted == false)
            {
                    return;
            }
            
            this.Refresh(invalidateCache:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Refresh(bool invalidateCache)
        {
            SRF.UI.StyleRoot val_8;
            SRF.UI.StyleRoot val_9;
            object val_10;
            if((System.String.IsNullOrEmpty(value:  this._styleKey)) != true)
            {
                    val_8 = this._cachedRoot;
                if((val_8 != 0) && (invalidateCache != true))
            {
                    val_9 = this._cachedRoot;
            }
            else
            {
                    val_9 = this.GetStyleRoot();
                this._cachedRoot = val_9;
            }
            
                if(val_9 == 0)
            {
                    val_10 = "[StyleComponent] No active StyleRoot object found in parents.";
            }
            else
            {
                    SRF.UI.Style val_5 = this._cachedRoot.GetStyle(key:  this._styleKey);
                if(val_5 != null)
            {
                    this._activeStyle = val_5;
                this.ApplyStyle();
                return;
            }
            
                object[] val_6 = new object[1];
                val_8 = this._styleKey;
                val_6[0] = val_8;
                val_10 = System.String.Format(format:  "[StyleComponent] Style not found ({0})", args:  val_6);
            }
            
                UnityEngine.Debug.LogWarning(message:  val_10, context:  this);
            }
            
            this._activeStyle = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.StyleRoot GetStyleRoot()
        {
            UnityEngine.Object val_9 = this.CachedTransform;
            var val_9 = 0;
            label_15:
            SRF.UI.StyleRoot val_2 = val_9.GetComponentInParent<SRF.UI.StyleRoot>();
            if(val_2 != 0)
            {
                    val_9 = val_2.CachedTransform.parent;
            }
            
            val_9 = val_9 + 1;
            if(val_9 >= 101)
            {
                goto label_7;
            }
            
            if(val_2 == 0)
            {
                    return val_2;
            }
            
            if(val_2.enabled == true)
            {
                    return val_2;
            }
            
            if(val_9 != 0)
            {
                goto label_15;
            }
            
            return val_2;
            label_7:
            UnityEngine.Debug.LogWarning(message:  "Breaking Loop");
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ApplyStyle()
        {
            UnityEngine.UI.Graphic val_14;
            UnityEngine.Color val_15;
            var val_16;
            var val_17;
            var val_18;
            val_14 = this;
            if(this._activeStyle == null)
            {
                    return;
            }
            
            if(this._graphic == 0)
            {
                    this._graphic = this.GetComponent<UnityEngine.UI.Graphic>();
            }
            
            if(this._selectable == 0)
            {
                    this._selectable = this.GetComponent<UnityEngine.UI.Selectable>();
            }
            
            if(this._image == 0)
            {
                    this._image = this.GetComponent<UnityEngine.UI.Image>();
            }
            
            if(this.IgnoreImage != true)
            {
                    if(this._image != 0)
            {
                    this._image.sprite = this._activeStyle.Image;
            }
            
            }
            
            if(this._selectable != 0)
            {
                    UnityEngine.UI.ColorBlock val_9 = this._selectable.colors;
                TMPro.Mesh_Extents val_10 = new TMPro.Mesh_Extents(min:  new UnityEngine.Vector2() {x = this._activeStyle.HoverColor}, max:  new UnityEngine.Vector2());
                val_10.min.x.highlightedColor = new UnityEngine.Color() {r = this._activeStyle.ActiveColor};
                val_10.min.x.pressedColor = new UnityEngine.Color() {r = this._activeStyle.DisabledColor};
                this._selectable.colors = new UnityEngine.UI.ColorBlock() {m_NormalColor = new UnityEngine.Color(), m_HighlightedColor = new UnityEngine.Color(), m_PressedColor = new UnityEngine.Color(), m_DisabledColor = new UnityEngine.Color()};
                if(this._graphic == 0)
            {
                    return;
            }
            
                val_14 = this._graphic;
                UnityEngine.Color val_12 = UnityEngine.Color.white;
                val_15 = val_12.r;
                val_16 = val_12.g;
                val_17 = val_12.b;
                val_18 = val_12.a;
                if(val_14 != null)
            {
                    return;
            }
            
                return;
            }
            
            if(this._graphic == 0)
            {
                    return;
            }
            
            val_14 = this._graphic;
            val_15 = this._activeStyle.NormalColor;
            if(val_14 != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SRStyleDirty()
        {
            if(this.CachedGameObject.activeInHierarchy != false)
            {
                    this.Refresh(invalidateCache:  true);
                return;
            }
            
            this._cachedRoot = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StyleComponent()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
