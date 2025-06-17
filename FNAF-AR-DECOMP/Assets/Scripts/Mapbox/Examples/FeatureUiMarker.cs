using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeatureUiMarker : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _wrapperMarker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _infoPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _info;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] _targetVerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.VectorEntity _selectedFeature;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.Snap();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Clear()
        {
            this.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Show(Mapbox.Unity.MeshGeneration.Data.VectorEntity selectedFeature)
        {
            if(selectedFeature != null)
            {
                    this._selectedFeature = selectedFeature;
                this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                if(selectedFeature.MeshFilter != 0)
            {
                    this._targetVerts = selectedFeature.MeshFilter.mesh.vertices;
                this.Snap();
            }
            
                this.gameObject.SetActive(value:  true);
                return;
            }
            
            this.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Snap()
        {
            UnityEngine.UI.Text val_21;
            var val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_29;
            val_21 = this;
            if(this._targetVerts == null)
            {
                    return;
            }
            
            if(this._selectedFeature == null)
            {
                    return;
            }
            
            if(this._targetVerts.Length >= 1)
            {
                    val_22 = 12;
                do
            {
                var val_1 = this._targetVerts + (0 * val_22);
                UnityEngine.Vector3 val_3 = this._selectedFeature.Transform.position;
                UnityEngine.Vector3 val_4 = this._selectedFeature.Transform.lossyScale;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  val_4.x, a:  new UnityEngine.Vector3() {x = (0 * val_22) + this._targetVerts + 32, y = (0 * val_22) + this._targetVerts + 32 + 4, z = (0 * val_22) + this._targetVerts + 40});
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                val_23 = val_6.z;
                UnityEngine.Vector3 val_7 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_23});
                val_24 = -3.402823E+38f;
                val_25 = 3.402823E+38f;
                if(val_7.x < 0)
            {
                    val_25 = val_7.x;
            }
            else
            {
                    val_23 = -3.402823E+38f;
            }
            
                val_26 = 3.402823E+38f;
                if(val_7.y > val_24)
            {
                    val_24 = val_7.y;
            }
            else
            {
                    if(val_7.y < 0)
            {
                    val_26 = val_7.y;
            }
            
            }
            
            }
            while((0 + 1) < this._targetVerts.Length);
            
            }
            else
            {
                    val_24 = -3.402823E+38f;
                val_26 = 3.402823E+38f;
                val_25 = val_26;
            }
            
            float val_23 = -10f;
            float val_9 = val_24 + 10f;
            val_23 = val_25 + val_23;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_23, y:  val_9);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            this._wrapperMarker.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            float val_13 = val_24 - val_25;
            float val_24 = 20f;
            val_13 = val_13 + val_24;
            val_24 = (val_24 - val_26) + val_24;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_13, y:  val_24);
            if(this._wrapperMarker != null)
            {
                    var val_15 = (null == null) ? this._wrapperMarker : 0;
            }
            
            0.sizeDelta = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_24 + 10f, y:  val_9);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            this._infoPanel.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            val_21 = this._info;
            val_27 = null;
            val_27 = null;
            val_29 = FeatureUiMarker.<>c.<>9__8_0;
            if(val_29 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_19 = null;
                val_29 = val_19;
                val_19 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  FeatureUiMarker.<>c.__il2cppRuntimeField_static_fields, method:  System.String FeatureUiMarker.<>c::<Snap>b__8_0(System.Collections.Generic.KeyValuePair<string, object> x));
                FeatureUiMarker.<>c.<>9__8_0 = val_29;
            }
            
            string val_22 = System.String.Join(separator:  " \r\n ", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(source:  this._selectedFeature.Feature.Properties, selector:  val_19)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureUiMarker()
        {
        
        }
    
    }

}
