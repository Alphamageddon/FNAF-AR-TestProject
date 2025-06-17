using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LabelTextSetter : MonoBehaviour, IFeaturePropertySettable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.TextMesh _textMesh;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Set(System.Collections.Generic.Dictionary<string, object> props)
        {
            string val_5;
            this._textMesh.text = "";
            val_5 = "name";
            if((props.ContainsKey(key:  "name")) != true)
            {
                    val_5 = "house_num";
                if((props.ContainsKey(key:  "house_num")) != true)
            {
                    val_5 = "type";
                if((props.ContainsKey(key:  "type")) == false)
            {
                    return;
            }
            
            }
            
            }
            
            this._textMesh.text = props.Item[val_5];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LabelTextSetter()
        {
        
        }
    
    }

}
