using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Benchmark04 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SpawnType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MinPointSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxPointSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Steps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform m_Transform;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            int val_20;
            int val_21;
            string val_22;
            this.m_Transform = this.transform;
            int val_3 = UnityEngine.Screen.height;
            var val_4 = (val_3 < 0) ? (val_3 + 1) : (val_3);
            val_4 = val_4 >> 1;
            float val_21 = (float)val_4;
            UnityEngine.Camera.main.orthographicSize = val_21;
            val_21 = this.MinPointSize;
            val_20 = this.MaxPointSize;
            if(val_21 > val_20)
            {
                    return;
            }
            
            float val_20 = (float)UnityEngine.Screen.width;
            val_20 = val_20 / (float)UnityEngine.Screen.height;
            val_20 = val_20 * val_21;
            float val_8 = val_20 * (-0.975f);
            float val_22 = 0f;
            val_21 = val_21 * 0.975f;
            do
            {
                if(this.SpawnType == 0)
            {
                    val_22 = "Text - "("Text - ") + val_21 + " Pts";
                UnityEngine.GameObject val_10 = new UnityEngine.GameObject(name:  val_22);
                if(val_22 > (val_21 + val_21))
            {
                    return;
            }
            
                UnityEngine.Vector3 val_12 = this.m_Transform.position;
                float val_13 = val_21 - val_22;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_10.transform.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                TMPro.TextMeshPro val_15 = val_10.AddComponent<TMPro.TextMeshPro>();
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  0.5f);
                val_15.rectTransform.pivot = new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
                if(val_15 != null)
            {
                    val_15.enableWordWrapping = false;
                val_15.extraPadding = true;
                val_15.isOrthographic = true;
            }
            else
            {
                    val_15.enableWordWrapping = false;
                val_15.extraPadding = true;
                val_15.isOrthographic = true;
            }
            
                val_15.fontSize = (float)val_21;
                val_22 = val_21 + " pts - Lorem ipsum dolor sit..."(" pts - Lorem ipsum dolor sit...");
                val_15.text = val_22;
                UnityEngine.Color val_19 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                val_20 = this.MaxPointSize;
                val_22 = val_22 + (float)val_21;
            }
            
                val_21 = this.Steps + val_21;
            }
            while(val_21 <= val_20);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Benchmark04()
        {
            this.MinPointSize = 76;
            this.MaxPointSize = 64;
            this.Steps = 4;
        }
    
    }

}
