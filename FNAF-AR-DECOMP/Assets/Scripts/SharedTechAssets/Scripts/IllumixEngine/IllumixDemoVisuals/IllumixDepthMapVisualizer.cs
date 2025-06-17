using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixDepthMapVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int downsampleRate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int width;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int height;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _texture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.RawImage rawImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixDepthMapVisualizer_SROptions _srOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color[] colorArray;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatedDepthMap(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap map)
        {
            var val_53;
            var val_54;
            int val_55;
            UnityEngine.UI.RawImage val_56;
            UnityEngine.UI.RawImage val_57;
            val_53 = map;
            if(this.width == map.Width)
            {
                    val_54 = 0;
            }
            else
            {
                    this.width = map.Width;
                val_54 = 1;
            }
            
            val_55 = map.Height;
            if(this.height != val_55)
            {
                goto label_4;
            }
            
            if((val_54 & 1) != 0)
            {
                goto label_5;
            }
            
            val_56 = this.rawImage;
            goto label_6;
            label_4:
            this.height = val_55;
            label_5:
            UnityEngine.UI.RawImage val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.RawImage>();
            val_56 = this;
            this.rawImage = val_1;
            if(val_1 == 0)
            {
                    val_55 = "UpdatedDepthMap";
                ConsoleLogger.LogError(className:  "IllumixDepthMapVisualizer", functionName:  "UpdatedDepthMap", logString:  "RawImage on canvas required!");
            }
            
            int val_53 = this.width;
            val_53 = val_53 / this.downsampleRate;
            val_53 = val_53 * this.height;
            int val_3 = val_53 / this.downsampleRate;
            this.colorArray = new UnityEngine.Color[0];
            this._texture = new UnityEngine.Texture2D(width:  this.width / this.downsampleRate, height:  this.height / this.downsampleRate);
            if(UnityEngine.Input.deviceOrientation != 3)
            {
                    if(UnityEngine.Input.deviceOrientation != 4)
            {
                    if(UnityEngine.Screen.width <= UnityEngine.Screen.height)
            {
                goto label_14;
            }
            
            }
            
            }
            
            label_40:
            UnityEngine.Transform val_14 = this.rawImage.gameObject.transform;
            UnityEngine.Vector3 val_15 = val_14.localScale;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  (float)UnityEngine.Screen.height / 28f);
            val_14.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            label_6:
            val_57 = this.rawImage.gameObject;
            if(val_57.activeSelf == false)
            {
                    return;
            }
            
            this.fillColorMapFromDepth(values:  map.DepthMap);
            this._texture.SetPixels(colors:  this.colorArray);
            this._texture.Apply();
            val_57 = this.rawImage;
            val_57.texture = this._texture;
            int val_54 = map.Position;
            val_54 = val_54 - 1;
            if(val_54 > 3)
            {
                goto label_27;
            }
            
            var val_55 = 52947652 + ((map.Position - 1)) << 2;
            val_55 = val_55 + 52947652;
            goto (52947652 + ((map.Position - 1)) << 2 + 52947652);
            label_27:
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.zero;
            this.rawImage.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
            return;
            label_14:
            int val_52 = UnityEngine.Screen.width;
            goto label_40;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void fillColorMapFromDepth(double[] values)
        {
            var val_7;
            int val_8;
            int val_9;
            val_8 = this.height;
            if(val_8 < 1)
            {
                    return;
            }
            
            do
            {
                if(this.width >= 1)
            {
                    var val_8 = 0;
                do
            {
                float val_2 = System.Math.Min(val1:  (float)values[(long)val_8 + (val_8 * 0)], val2:  3f);
                val_2 = val_2 / 3f;
                int val_3 = this.height / this.downsampleRate;
                int val_4 = 0 / this.downsampleRate;
                val_4 = (val_3 - 1) - val_4;
                val_3 = (val_8 / this.downsampleRate) + (val_4 * val_3);
                this.colorArray[(long)val_3] = 0;
                this.colorArray[(long)val_3] = 0;
                this.colorArray[(long)val_3] = 0;
                this.colorArray[(long)val_3] = 0;
                val_9 = this.downsampleRate;
                val_8 = this.height;
                val_8 = val_9 + val_8;
            }
            while(val_8 < this.width);
            
            }
            else
            {
                    val_9 = this.downsampleRate;
            }
            
                val_7 = val_9 + 0;
            }
            while(val_7 < val_8);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleImageVisibility()
        {
            this.rawImage.gameObject.SetActive(value:  (~this.rawImage.gameObject.activeSelf) & 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            ._viz = this;
            this._srOptions = new SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixDepthMapVisualizer_SROptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            IntPtr val_4;
            IllumixDepthMapDeliverer.Update val_1 = null;
            val_4 = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixDepthMapVisualizer::UpdatedDepthMap(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap map);
            val_1 = new IllumixDepthMapDeliverer.Update(object:  this, method:  val_4);
            SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.add_UpdatedEvent(value:  val_1);
            SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
            if(val_2 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 12;
            val_2.AddOptionContainer(container:  this._srOptions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            IntPtr val_4;
            IllumixDepthMapDeliverer.Update val_1 = null;
            val_4 = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixDepthMapVisualizer::UpdatedDepthMap(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap map);
            val_1 = new IllumixDepthMapDeliverer.Update(object:  this, method:  val_4);
            SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.remove_UpdatedEvent(value:  val_1);
            SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
            if(val_2 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 13;
            val_2.RemoveOptionContainer(container:  this._srOptions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixDepthMapVisualizer()
        {
            this.downsampleRate = 1;
        }
    
    }

}
