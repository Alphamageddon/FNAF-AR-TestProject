using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoadingPanelController : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _content;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AnimationCurve _curve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            Mapbox.Unity.Map.AbstractMap val_1 = UnityEngine.Object.FindObjectOfType<Mapbox.Unity.Map.AbstractMap>();
            this._map = val_1;
            val_1.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Examples.LoadingPanelController::_map_OnInitialized()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _map_OnInitialized()
        {
            this._map.MapVisualizer.add_OnMapVisualizerStateChanged(value:  new System.Action<Mapbox.Unity.Map.ModuleState>(object:  this, method:  System.Void Mapbox.Examples.LoadingPanelController::<_map_OnInitialized>b__5_0(Mapbox.Unity.Map.ModuleState s)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Color val_3 = UnityEngine.Color.clear;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            UnityEngine.Color val_5 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, b:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, t:  this._curve.Evaluate(time:  UnityEngine.Time.time));
            this._text.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoadingPanelController()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <_map_OnInitialized>b__5_0(Mapbox.Unity.Map.ModuleState s)
        {
            if(s != 2)
            {
                    return;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            this._content.SetActive(value:  false);
        }
    
    }

}
