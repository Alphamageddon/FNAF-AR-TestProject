using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_UiFrameRateCounter : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float UpdateInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float m_LastInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_Frames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions AnchorPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string htmlColorTag;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI m_TextMeshPro;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform m_frameCounter_transform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            UnityEngine.Application.targetFrameRate = 0;
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "Frame Counter");
            UnityEngine.RectTransform val_3 = val_2.AddComponent<UnityEngine.RectTransform>();
            this.m_frameCounter_transform = val_3;
            val_3.SetParent(parent:  this.transform, worldPositionStays:  false);
            TMPro.TextMeshProUGUI val_5 = val_2.AddComponent<TMPro.TextMeshProUGUI>();
            this.m_TextMeshPro = val_5;
            val_5.font = UnityEngine.Resources.Load<TMPro.TMP_FontAsset>(path:  "Fonts & Materials/LiberationSans SDF");
            UnityEngine.Material val_7 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Fonts & Materials/LiberationSans SDF - Overlay");
            this.m_TextMeshPro.enableWordWrapping = false;
            this.m_TextMeshPro.fontSize = 36f;
            this.m_TextMeshPro.isOverlay = true;
            this.Set_FrameCounter_Position(anchor_position:  this.AnchorPosition);
            this.last_AnchorPosition = this.AnchorPosition;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.m_LastInterval = UnityEngine.Time.realtimeSinceStartup;
            this.m_Frames = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            FpsCounterAnchorPositions val_8 = this.AnchorPosition;
            if(val_8 != this.last_AnchorPosition)
            {
                    this.Set_FrameCounter_Position(anchor_position:  val_8 = this.AnchorPosition);
                val_8 = this.AnchorPosition;
            }
            
            int val_8 = this.m_Frames;
            this.last_AnchorPosition = val_8;
            val_8 = val_8 + 1;
            this.m_Frames = val_8;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            float val_9 = this.UpdateInterval;
            float val_10 = this.m_LastInterval;
            val_9 = val_10 + val_9;
            if(val_1 <= val_9)
            {
                    return;
            }
            
            val_10 = val_1 - val_10;
            float val_2 = (float)this.m_Frames / val_10;
            string val_5 = (val_2 < 0) ? "<color=yellow>" : ((val_2 < 0) ? "<color=red>" : "<color=green>");
            this.htmlColorTag = val_5;
            this.m_TextMeshPro.SetText(text:  val_5 + "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS"("{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS"), arg0:  val_2, arg1:  1000f / (UnityEngine.Mathf.Max(a:  val_2, b:  1E-05f)));
            this.m_Frames = 0;
            this.m_LastInterval = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Set_FrameCounter_Position(TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions anchor_position)
        {
            UnityEngine.RectTransform val_14 = this;
            if(anchor_position > 3)
            {
                    return;
            }
            
            var val_14 = 52945872 + (anchor_position) << 2;
            val_14 = val_14 + 52945872;
            goto (52945872 + (anchor_position) << 2 + 52945872);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_UiFrameRateCounter()
        {
            this.UpdateInterval = 5f;
            this.AnchorPosition = 2;
        }
    
    }

}
