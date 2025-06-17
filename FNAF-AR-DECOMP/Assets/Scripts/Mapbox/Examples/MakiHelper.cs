using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MakiHelper : MonoBehaviour, IFeaturePropertySettable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.RectTransform Parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.GameObject UiPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _uiObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Set(System.Collections.Generic.Dictionary<string, object> props)
        {
            var val_30;
            var val_31;
            UnityEngine.RectTransform val_32;
            var val_33;
            val_30 = props;
            val_31 = 1152921504851574784;
            val_32 = Mapbox.Examples.MakiHelper.Parent;
            if(val_32 == 0)
            {
                    UnityEngine.GameObject val_3 = null;
                val_32 = val_3;
                val_3 = new UnityEngine.GameObject(name:  "PoiContainer");
                val_3.transform.SetParent(p:  UnityEngine.GameObject.Find(name:  "PoiCanvas").transform);
                Mapbox.Examples.MakiHelper.Parent = val_3.AddComponent<UnityEngine.RectTransform>();
                Mapbox.Examples.MakiHelper.UiPrefab = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MakiUiPrefab");
            }
            
            val_33 = 1152921515845838592;
            if((val_30.ContainsKey(key:  "maki")) == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  Mapbox.Examples.MakiHelper.UiPrefab);
            this._uiObject = val_9;
            val_9.transform.SetParent(p:  Mapbox.Examples.MakiHelper.Parent);
            this._uiObject.transform.Find(n:  "Image").GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "maki/"("maki/") + val_30.Item["maki"] + "-15"("-15"));
            val_32 = "name";
            if((val_30.ContainsKey(key:  "name")) == false)
            {
                    return;
            }
            
            UnityEngine.UI.Text val_18 = this._uiObject.GetComponentInChildren<UnityEngine.UI.Text>();
            object val_19 = val_30.Item["name"];
            val_30 = ???;
            val_32 = ???;
            val_33 = ???;
            val_31 = ???;
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LateUpdate()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._uiObject)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.transform.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this._uiObject.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MakiHelper()
        {
        
        }
    
    }

}
