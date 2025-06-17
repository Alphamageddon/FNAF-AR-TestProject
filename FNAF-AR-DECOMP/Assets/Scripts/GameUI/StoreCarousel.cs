using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreCarousel : ScrollRect
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float CLOSE_ENOUGH;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI StatusText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LERPSpeedPixelsPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button LeftButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button RightButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.ScrollRect ParentScrollRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Viewport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.StoreCell> _children;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform _contentRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _prevTimestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _rerouteToParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCell _currentBanner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lerpTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isLERPing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _initialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _bannerWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _lastDragPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDragging;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCarousel.CarouselAutoScroll _carouselAutoScroll;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendEventToParentScrollRect<T>(System.Action<T> action)
        {
            if(action == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateLERP(float delta)
        {
            var val_6;
            float val_1 = this.GetCurrentScrollPosition();
            val_1 = val_1 - this._lerpTarget;
            val_6 = null;
            val_6 = null;
            if(System.Math.Abs(val_1) > GameUI.StoreCarousel.CLOSE_ENOUGH)
            {
                    float val_4 = UnityEngine.Mathf.Min(a:  this.LERPSpeedPixelsPerSecond * delta, b:  System.Math.Abs(this._lerpTarget - val_1));
                val_4 = val_4 * ((val_1 > this._lerpTarget) ? -1f : 1f);
                this.OffsetScrollPosition(newX:  val_4);
                return;
            }
            
            this.SetScrollPosition(x:  this._lerpTarget);
            this._isLERPing = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetCurrentScrollPosition()
        {
            if(this._contentRect != null)
            {
                    return this._contentRect.anchoredPosition;
            }
            
            return this._contentRect.anchoredPosition;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OffsetScrollPosition(float newX)
        {
            UnityEngine.Vector2 val_1 = this._contentRect.anchoredPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            val_2.x = val_2.x + newX;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this._contentRect.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetScrollPosition(float x)
        {
            UnityEngine.Vector2 val_1 = this._contentRect.anchoredPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = x, y = val_2.y, z = val_2.z});
            this._contentRect.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalculateTargetPosition()
        {
            float val_10;
            var val_11;
            this._lerpTarget = 0f;
            val_10 = 3.402823E+38f;
            val_11 = 0;
            goto label_1;
            label_11:
            UnityEngine.Vector2 val_5 = this._children.Item[0].gameObject.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
            float val_10 = this._bannerWidth;
            val_10 = val_10 * (-0.5f);
            float val_6 = val_5.x + val_10;
            float val_7 = this.GetCurrentScrollPosition() + val_6;
            float val_12 = System.Math.Abs(val_10);
            if(System.Math.Abs(val_7) < 0)
            {
                    this._lerpTarget = -val_6;
                this._isLERPing = true;
                this._currentBanner = this._children.Item[0];
                this.UpdateText();
                val_10 = val_7;
            }
            
            val_11 = 1;
            label_1:
            if(val_11 < this._children.Count)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCurrentBanner(GameUI.StoreCell banner)
        {
            this._currentBanner = banner;
            this.UpdateText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize()
        {
            if(this._initialized == true)
            {
                    return;
            }
            
            this._prevTimestamp = UnityEngine.Time.time;
            this._isLERPing = false;
            this._contentRect = this.content.GetComponent<UnityEngine.RectTransform>();
            this.LeftButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.StoreCarousel::MoveLeft()));
            this.RightButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.StoreCarousel::MoveRight()));
            UnityEngine.Vector2 val_9 = this.Viewport.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            this._bannerWidth = val_9.x;
            this._initialized = true;
            this._carouselAutoScroll = new StoreCarousel.CarouselAutoScroll(ScrollDelegate:  new System.Action(object:  this, method:  public System.Void GameUI.StoreCarousel::MoveRight()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            float val_1 = UnityEngine.Time.time;
            this._prevTimestamp = val_1;
            if(this._isLERPing != false)
            {
                    val_1 = val_1 - this._prevTimestamp;
                this.UpdateLERP(delta:  val_1);
            }
            
            if(this._isDragging == false)
            {
                goto label_1;
            }
            
            if(this._carouselAutoScroll != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            this._carouselAutoScroll.Update(isDragging:  (1 != 0) ? 1 : 0);
            return;
            label_1:
            if(this._carouselAutoScroll != null)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetCarousel()
        {
            goto label_1;
            label_8:
            UnityEngine.Object.Destroy(obj:  this._children.Item[0].gameObject);
            this._children.set_Item(index:  0, value:  0);
            0 = 1;
            label_1:
            if(0 < this._children.Count)
            {
                goto label_8;
            }
            
            this._currentBanner = 0;
            this._children.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDestroy()
        {
            this._children.Clear();
            this.OnDestroy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetMaxScrollPos()
        {
            float val_2 = this._bannerWidth;
            val_2 = val_2 * (float)this._children.Count;
            val_2 = this._bannerWidth - val_2;
            return (float)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForDragExtension(float direction)
        {
            float val_1 = this.GetCurrentScrollPosition();
            if(direction < 0)
            {
                    float val_3 = this.GetMaxScrollPos();
                if(this.GetCurrentScrollPosition() < 0)
            {
                    this.ExpandRight();
                return;
            }
            
            }
            
            if(direction <= 0f)
            {
                    return;
            }
            
            if(this.GetCurrentScrollPosition() <= 0f)
            {
                    return;
            }
            
            this.ExpandLeft();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExpandRight()
        {
            this._contentRect.GetChild(index:  0).SetAsLastSibling();
            this.OffsetScrollPosition(newX:  this._bannerWidth);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExpandLeft()
        {
            var val_5;
            if(this._contentRect != null)
            {
                    val_5 = this._contentRect.childCount;
            }
            else
            {
                    val_5 = 0.childCount;
            }
            
            this._contentRect.GetChild(index:  val_5 - 1).SetAsFirstSibling();
            this.OffsetScrollPosition(newX:  -this._bannerWidth);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            .eventData = eventData;
            this.SendEventToParentScrollRect<UnityEngine.EventSystems.IInitializePotentialDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IInitializePotentialDragHandler>(object:  new StoreCarousel.<>c__DisplayClass35_0(), method:  System.Void StoreCarousel.<>c__DisplayClass35_0::<OnInitializePotentialDrag>b__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent)));
            this.OnInitializePotentialDrag(eventData:  (StoreCarousel.<>c__DisplayClass35_0)[1152921524746083120].eventData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            StoreCarousel.<>c__DisplayClass36_0 val_1 = new StoreCarousel.<>c__DisplayClass36_0();
            .eventData = eventData;
            this.SendEventToParentScrollRect<UnityEngine.EventSystems.IBeginDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IBeginDragHandler>(object:  val_1, method:  System.Void StoreCarousel.<>c__DisplayClass36_0::<OnBeginDrag>b__0(UnityEngine.EventSystems.IBeginDragHandler parent)));
            if(val_1 != null)
            {
                    this.OnBeginDrag(eventData:  (StoreCarousel.<>c__DisplayClass36_0)[1152921524746239152].eventData);
            }
            else
            {
                    this.OnBeginDrag(eventData:  (StoreCarousel.<>c__DisplayClass36_0)[1152921524746239152].eventData);
            }
            
            UnityEngine.Vector2 val_3 = (StoreCarousel.<>c__DisplayClass36_0)[1152921524746239152].eventData.position;
            this._lastDragPosition = val_3;
            mem[1152921524746203448] = val_3.y;
            this._isLERPing = false;
            this._isDragging = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            .eventData = eventData;
            this.SendEventToParentScrollRect<UnityEngine.EventSystems.IDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IDragHandler>(object:  new StoreCarousel.<>c__DisplayClass37_0(), method:  System.Void StoreCarousel.<>c__DisplayClass37_0::<OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent)));
            if(this._children.Count < 2)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_4 = (StoreCarousel.<>c__DisplayClass37_0)[1152921524746399280].eventData.position;
            float val_5 = val_4.x - this._lastDragPosition;
            this.OffsetScrollPosition(newX:  val_5);
            this._lastDragPosition = val_4;
            mem[1152921524746363576] = val_4.y;
            this.CheckForDragExtension(direction:  val_5);
            this._isDragging = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            .eventData = eventData;
            this.SendEventToParentScrollRect<UnityEngine.EventSystems.IEndDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IEndDragHandler>(object:  new StoreCarousel.<>c__DisplayClass38_0(), method:  System.Void StoreCarousel.<>c__DisplayClass38_0::<OnEndDrag>b__0(UnityEngine.EventSystems.IEndDragHandler parent)));
            this.OnEndDrag(eventData:  (StoreCarousel.<>c__DisplayClass38_0)[1152921524746551216].eventData);
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.velocity = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.CalculateTargetPosition();
            this._isDragging = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveLeft()
        {
            this._isLERPing = true;
            this.MoveToPreviousCell();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveRight()
        {
            this._isLERPing = true;
            this.MoveToNextCell();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MoveToPreviousCell()
        {
            float val_9;
            var val_10;
            val_9 = this.GetCurrentScrollPosition();
            val_10 = null;
            val_10 = null;
            if(System.Math.Abs(val_9) < 0)
            {
                    this.ExpandLeft();
                val_9 = this.GetCurrentScrollPosition();
            }
            
            float val_10 = this._bannerWidth;
            val_10 = val_9 + val_10;
            this._lerpTarget = val_10;
            int val_11 = this.CurrentIndex();
            int val_5 = this._children.Count;
            int val_6 = val_11 + this._children.Count;
            val_6 = val_6 - 1;
            val_11 = val_6 - ((val_6 / val_5) * val_5);
            this._currentBanner = this._children.Item[val_11];
            this.UpdateText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MoveToNextCell()
        {
            float val_9;
            var val_10;
            val_9 = this.GetCurrentScrollPosition();
            float val_2 = this.GetMaxScrollPos();
            val_2 = val_9 - val_2;
            val_10 = null;
            val_10 = null;
            if(System.Math.Abs(val_2) < 0)
            {
                    this.ExpandRight();
                val_9 = this.GetCurrentScrollPosition();
            }
            
            float val_10 = this._bannerWidth;
            val_10 = val_9 - val_10;
            this._lerpTarget = val_10;
            int val_11 = this.CurrentIndex();
            int val_5 = this._children.Count;
            int val_6 = val_11 + 1;
            val_11 = val_6 - ((val_6 / val_5) * val_5);
            this._currentBanner = this._children.Item[val_11];
            this.UpdateText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int CurrentIndex()
        {
            if(this._currentBanner == 0)
            {
                    return 0;
            }
            
            if(this._children != null)
            {
                    return this._children.IndexOf(item:  this._currentBanner);
            }
            
            return this._children.IndexOf(item:  this._currentBanner);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateText()
        {
            this.StatusText.text = this.CurrentIndex() + 1(this.CurrentIndex() + 1) + " / "(" / ") + this._children.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddItem(GameUI.StoreCell newItem)
        {
            System.Delegate val_13 = System.Delegate.Combine(a:  newItem.CellDisabled, b:  new System.Action<GameUI.StoreCell>(object:  this, method:  public System.Void GameUI.StoreCarousel::OnCellDisabled(GameUI.StoreCell cell)));
            if(newItem == null)
            {
                goto label_2;
            }
            
            if(val_13 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_13 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_13 = 0;
            }
            
            label_6:
            newItem.CellDisabled = val_13;
            newItem.transform.SetParent(parent:  this.content.transform, worldPositionStays:  false);
            this._children.Add(item:  newItem);
            this.LeftButton.gameObject.SetActive(value:  (this._children.Count > 1) ? 1 : 0);
            this.RightButton.gameObject.SetActive(value:  (this._children.Count > 1) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCellDisabled(GameUI.StoreCell cell)
        {
            bool val_1 = this._children.Remove(item:  cell);
            UnityEngine.Object.Destroy(obj:  cell.gameObject);
            this.CalculateTargetPosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreCarousel()
        {
            this._children = new System.Collections.Generic.List<GameUI.StoreCell>();
            this._bannerWidth = 600f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static StoreCarousel()
        {
            GameUI.StoreCarousel.CLOSE_ENOUGH = 0.5f;
        }
    
    }

}
