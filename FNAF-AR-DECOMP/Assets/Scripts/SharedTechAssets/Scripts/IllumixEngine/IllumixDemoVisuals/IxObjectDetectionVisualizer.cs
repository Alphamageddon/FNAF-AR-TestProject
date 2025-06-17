using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxObjectDetectionVisualizer : MonoBehaviour
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
        private int MAX_BOXES;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] _detections;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool canUpdate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxObjectDetectionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections)
        {
            this.canUpdate = true;
            this._detections = detections;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GrabGOs()
        {
            this.imageBoxes = new UnityEngine.GameObject[0];
            this.textBoxes = new UnityEngine.GameObject[0];
            this.texts = new UnityEngine.UI.Text[0];
            this.textRects = new UnityEngine.RectTransform[0];
            this.imgRects = new UnityEngine.RectTransform[0];
            if(this.MAX_BOXES < 1)
            {
                    return;
            }
            
            label_38:
            object val_7 = 0 + 1;
            UnityEngine.Transform val_9 = this.canvas.transform.Find(n:  "Text" + val_7);
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
            UnityEngine.UI.Text val_18 = this.texts[0];
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
            UnityEngine.RectTransform val_15 = this.canvas.transform.Find(n:  "Image" + val_7).GetComponent<UnityEngine.RectTransform>();
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
            if(val_7 < this.MAX_BOXES)
            {
                goto label_38;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_15;
            var val_16;
            float val_17;
            int val_18;
            if(this.canUpdate == false)
            {
                    return;
            }
            
            this.canUpdate = false;
            val_15 = 1152921504623194112;
            val_16 = 0;
            goto label_2;
            label_18:
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_15 = this._detections[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_16 = this._detections[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_17 = this._detections[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_18 = this._detections[0];
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_19 = this._detections[0];
            if(val_15 != 0)
            {
                    UnityEngine.UI.Text val_21 = this.texts[0];
                string val_1 = val_15 + " " + this._detections[0];
            }
            
            float val_3 = val_16 + val_18;
            val_3 = val_3 * 0.5f;
            double val_23 = (double)val_3;
            double val_24 = (double)UnityEngine.Screen.width;
            val_23 = val_23 + (-0.5);
            val_24 = val_23 * val_24;
            val_17 = (float)val_24;
            float val_5 = val_17 + val_19;
            val_5 = val_5 * 0.5f;
            double val_25 = (double)val_5;
            double val_26 = (double)UnityEngine.Screen.height;
            val_25 = val_25 + (-0.5);
            val_26 = val_25 * val_26;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_17, y:  (float)val_26);
            this.textRects[0].anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.RectTransform val_27 = this.imgRects[0];
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_17, y:  (float)val_26);
            val_27.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            float val_28 = (float)UnityEngine.Screen.width;
            val_28 = (val_18 - val_16) * val_28;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_28, y:  (val_19 - val_17) * (float)UnityEngine.Screen.height);
            val_27.sizeDelta = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
            val_16 = 1;
            label_2:
            if(val_16 < this._detections.Length)
            {
                    if(val_16 < this.MAX_BOXES)
            {
                goto label_18;
            }
            
            }
            
            val_18 = this._detections.Length;
            if(this.MAX_BOXES <= val_18)
            {
                    return;
            }
            
            val_15 = 1152921504853065728;
            do
            {
                UnityEngine.UI.Text val_29 = this.texts[(long)val_18];
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
                val_17 = val_14.x;
                this.imgRects[(long)val_18].sizeDelta = new UnityEngine.Vector2() {x = val_17, y = val_14.y};
                val_18 = val_18 + 1;
            }
            while(val_18 < this.MAX_BOXES);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.GrabGOs();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.add_UpdatedEvent(value:  new IxObjectDetectionDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxObjectDetectionVisualizer::IxObjectDetectionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections)));
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.add_BeginEvent(value:  new IxObjectDetectionDeliverer.Begin(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxObjectDetectionVisualizer::IxObjectDetectionDelivererOnBeginDetectEvent()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxObjectDetectionDelivererOnBeginDetectEvent()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.remove_UpdatedEvent(value:  new IxObjectDetectionDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxObjectDetectionVisualizer::IxObjectDetectionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections)));
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.remove_BeginEvent(value:  new IxObjectDetectionDeliverer.Begin(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxObjectDetectionVisualizer::IxObjectDetectionDelivererOnBeginDetectEvent()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxObjectDetectionVisualizer()
        {
            this.MAX_BOXES = 10;
        }
    
    }

}
