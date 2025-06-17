using UnityEngine;

namespace SRDebugger.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MobileMenuController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _closeButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _maxMenuWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _peekAmount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _targetXPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform Content;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform Menu;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button OpenButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.SRTabController TabController;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PeekAmount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxMenuWidth { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_PeekAmount()
        {
            return (float)this._peekAmount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MaxMenuWidth()
        {
            return (float)this._maxMenuWidth;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            var val_13;
            this.OnEnable();
            UnityEngine.RectTransform val_13 = this.Menu;
            UnityEngine.Transform val_1 = val_13.parent;
            if(val_1 != null)
            {
                    val_13 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            UnityEngine.UI.LayoutElement val_2 = this.Menu.GetComponent<UnityEngine.UI.LayoutElement>();
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  1f, y:  1f);
            this.Menu.pivot = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  1f, y:  0f);
            this.Menu.offsetMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  1f, y:  1f);
            this.Menu.offsetMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Rect val_6 = val_13.rect;
            val_6.m_XMin = val_6.m_XMin - this._peekAmount;
            this.Menu.SetSizeWithCurrentAnchors(axis:  0, size:  UnityEngine.Mathf.Clamp(value:  val_6.m_XMin, min:  0f, max:  this._maxMenuWidth));
            UnityEngine.Rect val_8 = val_13.rect;
            this.Menu.SetSizeWithCurrentAnchors(axis:  1, size:  val_8.m_XMin);
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this.Menu.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            if(this._closeButton == 0)
            {
                    this.CreateCloseButton();
            }
            
            this.OpenButton.gameObject.SetActive(value:  true);
            this.TabController.add_ActiveTabChanged(value:  new System.Action<Systems.AssetManagement.Files.FileLoadSettings, UnityEngine.Networking.DownloadHandler>(object:  this, method:  System.Void SRDebugger.UI.MobileMenuController::TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDisable()
        {
            this.OnDisable();
            UnityEngine.UI.LayoutElement val_1 = this.Menu.GetComponent<UnityEngine.UI.LayoutElement>();
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this.Content.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            this._closeButton.gameObject.SetActive(value:  false);
            this.OpenButton.gameObject.SetActive(value:  false);
            this.TabController.remove_ActiveTabChanged(value:  new System.Action<SRDebugger.UI.Other.SRTabController, SRDebugger.UI.Other.SRTab>(object:  this, method:  System.Void SRDebugger.UI.MobileMenuController::TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateCloseButton()
        {
            var val_21;
            System.Type[] val_1 = new System.Type[1];
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = val_2;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "SR_CloseButtonCanvas", components:  val_1);
            val_3.transform.SetParent(parent:  this.Content, worldPositionStays:  false);
            if(val_3 != null)
            {
                    val_21 = val_3.AddComponent<UnityEngine.Canvas>();
            }
            else
            {
                    val_21 = val_3.AddComponent<UnityEngine.Canvas>();
            }
            
            UnityEngine.UI.GraphicRaycaster val_7 = val_3.AddComponent<UnityEngine.UI.GraphicRaycaster>();
            UnityEngine.RectTransform val_8 = SRF.SRFGameObjectExtensions.GetComponentOrAdd<UnityEngine.RectTransform>(obj:  val_3);
            if(val_21 != null)
            {
                    val_21.overrideSorting = true;
            }
            else
            {
                    val_21.overrideSorting = true;
            }
            
            val_21.sortingOrder = 122;
            UnityEngine.UI.LayoutElement val_9 = val_3.AddComponent<UnityEngine.UI.LayoutElement>();
            this.SetRectSize(rect:  val_8);
            System.Type[] val_10 = new System.Type[1];
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_10 == null)
            {
                goto label_17;
            }
            
            if(val_11 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_11 == null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_10[0] = val_11;
            UnityEngine.GameObject val_12 = new UnityEngine.GameObject(name:  "SR_CloseButton", components:  val_10);
            val_12.transform.SetParent(parent:  val_8, worldPositionStays:  false);
            if(val_12 != null)
            {
                    this.SetRectSize(rect:  val_12.GetComponent<UnityEngine.RectTransform>());
            }
            else
            {
                    this.SetRectSize(rect:  val_12.GetComponent<UnityEngine.RectTransform>());
            }
            
            val_12.AddComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.UI.Button val_17 = val_12.AddComponent<UnityEngine.UI.Button>();
            this._closeButton = val_17;
            val_17.transition = 0;
            this._closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SRDebugger.UI.MobileMenuController::CloseButtonClicked()));
            this._closeButton.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetRectSize(UnityEngine.RectTransform rect)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  0f);
            rect.anchorMin = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1f, y:  1f);
            rect.anchorMax = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Rect val_3 = this.Content.rect;
            rect.SetSizeWithCurrentAnchors(axis:  0, size:  val_3.m_XMin);
            UnityEngine.Rect val_4 = this.Content.rect;
            rect.SetSizeWithCurrentAnchors(axis:  1, size:  val_4.m_XMin);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CloseButtonClicked()
        {
            this.Close();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            float val_6;
            float val_7;
            this.Update();
            UnityEngine.Vector2 val_1 = this.Content.anchoredPosition;
            val_6 = this._targetXPosition;
            val_6 = this._targetXPosition;
            val_6 = this._targetXPosition;
            val_1.x = this._targetXPosition - val_1.x;
            val_7 = 2.5f;
            if(System.Math.Abs(val_1.x) < 0)
            {
                    if(this.Content != null)
            {
                goto label_6;
            }
            
            }
            else
            {
                    val_7 = val_6;
                val_6 = SRMath.SpringLerp(from:  val_1.x, to:  val_7, strength:  15f, deltaTime:  UnityEngine.Time.unscaledDeltaTime);
            }
            
            label_6:
            UnityEngine.Vector2 val_4 = this.Content.anchoredPosition;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_6, y:  val_4.y);
            this.Content.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab)
        {
            this.Close();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Open()
        {
            UnityEngine.Rect val_1 = this.Menu.rect;
            this._targetXPosition = val_1.m_XMin;
            this._closeButton.gameObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Close()
        {
            this._targetXPosition = 0f;
            this._closeButton.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MobileMenuController()
        {
            this._maxMenuWidth = 185f;
            this._peekAmount = 45f;
        }
    
    }

}
