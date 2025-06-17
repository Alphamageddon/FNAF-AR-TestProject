using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PoiLabelTextSetter : MonoBehaviour, IFeaturePropertySettable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _background;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Set(System.Collections.Generic.Dictionary<string, object> props)
        {
            string val_5;
            UnityEngine.UI.Text val_6;
            val_5 = "name";
            val_6 = 1152921515845838592;
            if((props.ContainsKey(key:  "name")) == true)
            {
                goto label_5;
            }
            
            val_5 = "house_num";
            if((props.ContainsKey(key:  "house_num")) == true)
            {
                goto label_5;
            }
            
            val_5 = "type";
            if((props.ContainsKey(key:  "type")) == false)
            {
                goto label_7;
            }
            
            label_5:
            val_6 = this._text;
            object val_4 = props.Item[val_5];
            label_7:
            this.RefreshBackground();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshBackground()
        {
            UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  this._background.GetComponent<UnityEngine.RectTransform>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PoiLabelTextSetter()
        {
        
        }
    
    }

}
