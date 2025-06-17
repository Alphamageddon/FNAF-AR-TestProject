using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ConsoleBlobInfo = "Console_Info_Blob";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ConsoleBlobWarning = "Console_Warning_Blob";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ConsoleBlobError = "Console_Error_Blob";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Services.ConsoleEntry _prevData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform _rectTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.CanvasGroup CountContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.StyleComponent ImageStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text StackTrace;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDataContext(object data)
        {
            UnityEngine.CanvasGroup val_10;
            SRF.UI.StyleComponent val_11;
            float val_12;
            val_11 = this;
            if(data == null)
            {
                goto label_3;
            }
            
            if(12089 >= 2)
            {
                goto label_4;
            }
            
            if(this._hasCount == false)
            {
                goto label_10;
            }
            
            val_10 = this.CountContainer;
            val_12 = 0f;
            val_10.alpha = val_12;
            this._hasCount = false;
            goto label_10;
            label_4:
            if(this._hasCount != true)
            {
                    val_10 = this.CountContainer;
                val_12 = 1f;
                val_10.alpha = val_12;
                this._hasCount = true;
            }
            
            if(val_10 != this._count)
            {
                    val_10 = this.Count;
                string val_1 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  val_10, max:  231, exceedsMaxString:  "999+");
                this._count = null;
            }
            
            label_10:
            if(this._prevData == data)
            {
                    return;
            }
            
            this._prevData = data;
            string val_2 = data.MessagePreview;
            string val_3 = data.StackTracePreview;
            bool val_4 = System.String.IsNullOrEmpty(value:  this.StackTrace);
            val_10 = this.Message.rectTransform;
            UnityEngine.Rect val_6 = this._rectTransform.rect;
            if(val_10 == null)
            {
                goto label_18;
            }
            
            if(val_4 == false)
            {
                goto label_19;
            }
            
            label_21:
            float val_7 = val_6.m_XMin + (-4f);
            goto label_20;
            label_18:
            if(val_4 == true)
            {
                goto label_21;
            }
            
            label_19:
            label_20:
            val_10.SetInsetAndSizeFromParentEdge(edge:  3, inset:  12f, size:  val_6.m_XMin + (-14f));
            if(null > 4)
            {
                    return;
            }
            
            var val_10 = mem[4611686019912284664];
            val_10 = val_10 + 52951544;
            goto (mem[4611686019912284664] + 52951544);
            label_3:
            System.Exception val_9 = new System.Exception(message:  "Data should be a ConsoleEntry");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            UnityEngine.RectTransform val_5;
            this.Awake();
            UnityEngine.Transform val_1 = this.CachedTransform;
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            this._rectTransform = val_5;
            this.CountContainer.alpha = 0f;
            SRDebugger.Settings val_3 = SRDebugger.Settings.Instance;
            this.Message.supportRichText = (val_3._richTextInConsole == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsoleEntryView()
        {
        
        }
    
    }

}
