using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextMeshOutline : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float pixelSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color outlineColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool resolutionDependant;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int doubleResolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.TextMesh textMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshRenderer meshRenderer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            var val_14;
            this.textMesh = this.GetComponent<UnityEngine.TextMesh>();
            this.meshRenderer = this.GetComponent<UnityEngine.MeshRenderer>();
            var val_14 = 8;
            label_21:
            System.Type[] val_3 = new System.Type[1];
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_3 == null)
            {
                goto label_3;
            }
            
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_3[0] = val_4;
            UnityEngine.GameObject val_5 = new UnityEngine.GameObject(name:  "outline", components:  val_3);
            val_5.transform.parent = this.transform;
            val_5.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.MeshRenderer val_9 = val_5.GetComponent<UnityEngine.MeshRenderer>();
            UnityEngine.Material val_11 = new UnityEngine.Material(source:  this.meshRenderer.material);
            if(val_9 != null)
            {
                    val_9.material = val_11;
                val_9.shadowCastingMode = 0;
                val_14 = val_9;
            }
            else
            {
                    0.material = val_11;
                0.shadowCastingMode = 0;
                val_14 = 0;
            }
            
            val_14.receiveShadows = false;
            val_14.sortingLayerID = this.meshRenderer.sortingLayerID;
            val_14.sortingLayerName = this.meshRenderer.sortingLayerName;
            val_14 = val_14 - 1;
            if(val_14 != 0)
            {
                goto label_21;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            var val_41;
            var val_42;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Color val_5 = this.textMesh.color;
            UnityEngine.Color val_6 = this.textMesh.color;
            mem[1152921519840807464] = val_5.a * val_6.a;
            val_41 = 0;
            goto label_5;
            label_47:
            UnityEngine.TextMesh val_10 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.TextMesh>();
            val_10.color = new UnityEngine.Color() {r = this.outlineColor, g = V12.16B, b = V13.16B, a = V14.16B};
            val_10.text = this.textMesh.text;
            val_10.alignment = this.textMesh.alignment;
            val_10.anchor = this.textMesh.anchor;
            val_10.characterSize = this.textMesh.characterSize;
            val_10.font = this.textMesh.font;
            val_10.fontSize = this.textMesh.fontSize;
            val_10.fontStyle = this.textMesh.fontStyle;
            val_10.richText = this.textMesh.richText;
            val_10.tabSize = this.textMesh.tabSize;
            val_10.lineSpacing = this.textMesh.lineSpacing;
            val_10.offsetZ = this.textMesh.offsetZ;
            if(this.resolutionDependant == false)
            {
                goto label_31;
            }
            
            if(UnityEngine.Screen.width <= this.doubleResolution)
            {
                goto label_32;
            }
            
            val_42 = 1;
            goto label_34;
            label_31:
            val_42 = 0;
            goto label_34;
            label_32:
            int val_24 = UnityEngine.Screen.height;
            label_34:
            UnityEngine.Vector3 val_26 = val_24.GetOffset(i:  0);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  (((val_24 > this.doubleResolution) ? 1 : 0) == 0) ? this.pixelSize : (this.pixelSize + this.pixelSize));
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            UnityEngine.Vector3 val_32 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            val_10.transform.position = new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z};
            UnityEngine.MeshRenderer val_36 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.MeshRenderer>();
            val_36.sortingLayerID = this.meshRenderer.sortingLayerID;
            val_36.sortingLayerName = this.meshRenderer.sortingLayerName;
            val_41 = 1;
            label_5:
            if(val_41 < this.transform.childCount)
            {
                goto label_47;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GetOffset(int i)
        {
            var val_2 = (i < 0) ? (i + 7) : i;
            val_2 = val_2 & 4294967288;
            val_2 = i - val_2;
            if(val_2 <= 7)
            {
                    var val_4 = 52950760 + ((i - (i < 0 ? (i + 7) : i & 4294967288))) << 2;
                val_4 = val_4 + 52950760;
            }
            else
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextMeshOutline()
        {
            this.pixelSize = 1f;
            UnityEngine.Color val_1 = UnityEngine.Color.black;
            this.outlineColor = val_1;
            mem[1152921519841162528] = val_1.g;
            mem[1152921519841162532] = val_1.b;
            mem[1152921519841162536] = val_1.a;
            this.doubleResolution = 1024;
        }
    
    }

}
