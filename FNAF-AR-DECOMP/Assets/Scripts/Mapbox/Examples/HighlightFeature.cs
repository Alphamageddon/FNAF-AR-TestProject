using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HighlightFeature : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Material _highlightMaterial;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Material> _materials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshRenderer _meshRenderer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Material val_8;
            var val_9;
            val_8 = 1152921505121488896;
            if(Mapbox.Examples.HighlightFeature._highlightMaterial == 0)
            {
                    Mapbox.Examples.HighlightFeature._highlightMaterial = UnityEngine.Object.Instantiate<UnityEngine.Material>(original:  this.GetComponent<UnityEngine.MeshRenderer>().material);
                UnityEngine.Color val_5 = UnityEngine.Color.red;
                Mapbox.Examples.HighlightFeature._highlightMaterial.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            }
            
            UnityEngine.MeshRenderer val_6 = this.GetComponent<UnityEngine.MeshRenderer>();
            this._meshRenderer = val_6;
            val_9 = 0;
            goto label_9;
            label_13:
            val_8 = val_6.sharedMaterials[0];
            this._materials.Add(item:  val_8);
            val_9 = 1;
            label_9:
            if(val_9 < val_7.Length)
            {
                goto label_13;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMouseEnter()
        {
            this._meshRenderer.sharedMaterial = Mapbox.Examples.HighlightFeature._highlightMaterial;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMouseExit()
        {
            this._meshRenderer.materials = this._materials.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HighlightFeature()
        {
            this._materials = new System.Collections.Generic.List<UnityEngine.Material>();
        }
    
    }

}
