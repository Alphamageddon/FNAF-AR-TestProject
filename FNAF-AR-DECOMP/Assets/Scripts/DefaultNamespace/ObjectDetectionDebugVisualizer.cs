using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectDetectionDebugVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Canvas canvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject[] imageBoxes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject[] textBoxes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text[] texts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform[] textRects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform[] imgRects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material[] images;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int MAX_BOXES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool canUpdate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void IxObjectDetectionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections, int[] isFiltered)
        {
            var val_18;
            var val_19;
            int val_20;
            UnityEngine.Material val_21;
            float val_26;
            var val_27;
            val_18 = detections;
            val_19 = 0;
            goto label_1;
            label_28:
            if(val_19 >= true)
            {
                goto label_2;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_18 = val_18[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_19 = val_18[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_20 = val_18[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_21 = val_18[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_22 = val_18[0];
            if(val_18 != 0)
            {
                    UnityEngine.UI.Text val_24 = this.texts[0];
                string val_1 = val_18 + " " + val_18[0];
            }
            
            val_20 = isFiltered[0];
            if(val_20 == 1)
            {
                    val_21 = this.images[0];
                UnityEngine.Color val_2 = UnityEngine.Color.red;
            }
            else
            {
                    if(val_19 >= isFiltered.Length)
            {
                    val_20 = mem[isFiltered[0x0] + 32];
                val_20 = isFiltered[0x0] + 32;
            }
            
                val_21 = this.images[0];
                if(val_20 != 0)
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.yellow;
            }
            else
            {
                    UnityEngine.Color val_4 = UnityEngine.Color.cyan;
            }
            
            }
            
            val_21.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            float val_6 = val_19 + val_21;
            val_6 = val_6 * 0.5f;
            double val_26 = (double)val_6;
            double val_27 = (double)UnityEngine.Screen.width;
            val_26 = val_26 + (-0.5);
            val_27 = val_26 * val_27;
            val_26 = (float)val_27;
            float val_8 = val_20 + val_22;
            val_8 = val_8 * 0.5f;
            double val_28 = (double)val_8;
            double val_29 = (double)UnityEngine.Screen.height;
            val_28 = val_28 + (-0.5);
            val_29 = val_28 * val_29;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_26, y:  (float)val_29);
            this.textRects[0].anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            UnityEngine.RectTransform val_30 = this.imgRects[0];
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_26, y:  (float)val_29);
            val_30.anchoredPosition = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
            val_27 = UnityEngine.Screen.width;
            float val_31 = (float)val_27;
            val_31 = (val_21 - val_19) * val_31;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_31, y:  (val_22 - val_20) * (float)UnityEngine.Screen.height);
            val_30.sizeDelta = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
            val_19 = 1;
            label_1:
            int val_34 = detections.Length;
            if(val_19 < val_34)
            {
                goto label_28;
            }
            
            label_2:
            if(this.MAX_BOXES <= val_34)
            {
                    return;
            }
            
            val_18 = "";
            val_27 = 1152921504853065728;
            do
            {
                UnityEngine.UI.Text val_32 = this.texts[(long)val_34];
                UnityEngine.Vector2 val_17 = UnityEngine.Vector2.zero;
                val_26 = val_17.x;
                this.imgRects[(long)val_34].sizeDelta = new UnityEngine.Vector2() {x = val_26, y = val_17.y};
                val_34 = val_34 + 1;
            }
            while(val_34 < this.MAX_BOXES);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GrabGOs()
        {
            this.imageBoxes = new UnityEngine.GameObject[0];
            this.textBoxes = new UnityEngine.GameObject[0];
            this.texts = new UnityEngine.UI.Text[0];
            this.textRects = new UnityEngine.RectTransform[0];
            this.imgRects = new UnityEngine.RectTransform[0];
            this.images = new UnityEngine.Material[0];
            if(this.MAX_BOXES < 1)
            {
                    return;
            }
            
            object val_22 = 0;
            label_52:
            val_22 = val_22 + 1;
            UnityEngine.Transform val_9 = this.canvas.transform.Find(n:  "Text" + val_22);
            UnityEngine.UI.Text val_10 = val_9.GetComponent<UnityEngine.UI.Text>();
            if(this.texts == null)
            {
                goto label_5;
            }
            
            if(val_10 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_10 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            this.texts[0] = val_10;
            this.texts[0].fontSize = 20;
            UnityEngine.UI.Text val_24 = this.texts[0];
            UnityEngine.RectTransform val_11 = val_9.GetComponent<UnityEngine.RectTransform>();
            if(this.textRects == null)
            {
                goto label_18;
            }
            
            if(val_11 != null)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_11 == null)
            {
                goto label_22;
            }
            
            label_19:
            label_22:
            this.textRects[0] = val_11;
            UnityEngine.RectTransform val_15 = this.canvas.transform.Find(n:  "Image" + val_22).GetComponent<UnityEngine.RectTransform>();
            if(this.imgRects == null)
            {
                goto label_27;
            }
            
            if(val_15 != null)
            {
                goto label_28;
            }
            
            goto label_31;
            label_27:
            if(val_15 == null)
            {
                goto label_31;
            }
            
            label_28:
            label_31:
            this.imgRects[0] = val_15;
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.zero;
            this.imgRects[0].sizeDelta = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
            UnityEngine.UI.Image val_20 = this.canvas.transform.Find(n:  "Image" + val_22).GetComponent<UnityEngine.UI.Image>();
            if(this.images == null)
            {
                goto label_42;
            }
            
            if(val_20 != null)
            {
                goto label_43;
            }
            
            goto label_46;
            label_42:
            if(val_20 == null)
            {
                goto label_46;
            }
            
            label_43:
            label_46:
            this.images[0] = val_20;
            bool val_21 = UnityEngine.Object.op_Equality(x:  this.images[0], y:  0);
            if(val_22 < this.MAX_BOXES)
            {
                goto label_52;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.canUpdate == false)
            {
                    return;
            }
            
            this.canUpdate = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.GrabGOs();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectDetectionDebugVisualizer()
        {
            this.MAX_BOXES = 10;
        }
    
    }

}
