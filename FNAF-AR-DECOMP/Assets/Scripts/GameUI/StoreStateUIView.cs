using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreStateUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreStateUIActions storeStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCell storeCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreSection storeSectionPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCell CarouselBannerPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform StoreSectionParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCarousel Carousel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect StoreScrollRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SCROLL_TARGET_DEFAULT = "None";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SCROLL_TARGET_DEVICE = "Device";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SCROLL_TARGET_FAZCOINS = "FazCoins";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SCROLL_TARGET_LURE = "Lure";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SCROLL_TARGET_MINIPACK = "MiniPack";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SCROLL_TARGET_PACK = "Pack";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, GameUI.StoreSection> _storeSectionsByType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.Store.Data.StoreDisplayData>> _sortedDisplayItems;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateStoreSections()
        {
            var val_9 = this;
            this._storeSectionsByType = new System.Collections.Generic.Dictionary<System.String, GameUI.StoreSection>();
            List.Enumerator<T> val_4 = this._masterDomain.StoreDomain.StoreContainer.SectionData.GetEnumerator();
            do
            {
                label_9:
                if(((-1133944104) & 1) == 0)
            {
                    return;
            }
            
            }
            while(val_5._emailDatas != 1);
            
            this._storeSectionsByType.set_Item(key:  val_5._masterDomain, value:  this.CreateSection(data:  0.emailUIDataHandler));
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreSection CreateSection(Game.StoreDomain.Data.DataDefinitions.StoreSectionData data)
        {
            GameUI.StoreSection val_1 = UnityEngine.Object.Instantiate<GameUI.StoreSection>(original:  this.storeSectionPrefab, parent:  this.StoreSectionParent);
            if(this._masterDomain == null)
            {
                goto label_3;
            }
            
            label_6:
            val_1.SetData(data:  data, storeDomain:  public static GameUI.StoreSection UnityEngine.Object::Instantiate<GameUI.StoreSection>(GameUI.StoreSection original, UnityEngine.Transform parent));
            return val_1;
            label_3:
            if(val_1 != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetSections()
        {
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._storeSectionsByType.Values.GetEnumerator();
            label_5:
            if(((-1133611528) & 1) == 0)
            {
                goto label_3;
            }
            
            0.emailUIDataHandler.Reset();
            goto label_5;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524948071928});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void IconsLoaded()
        {
            this.PopulateStore();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulateStore()
        {
            if(this._masterDomain.StoreDomain.IconsReady() == false)
            {
                    return;
            }
            
            this.PopulateStoreItems();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateStoreItems()
        {
            var val_5;
            var val_12;
            var val_13;
            System.Comparison<Game.Store.Data.StoreDisplayData> val_15;
            val_12 = this;
            this.SortDisplayItems();
            this.ResetSections();
            this.Carousel.ResetCarousel();
            List.Enumerator<T> val_3 = this._masterDomain.StoreDomain.StoreContainer.SectionData.GetEnumerator();
            do
            {
                label_22:
                if(((-1133176256) & 1) == 0)
            {
                    return;
            }
            
                GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            }
            while((this._sortedDisplayItems.ContainsKey(key:  val_6._masterDomain)) == false);
            
            System.Collections.Generic.List<Game.Store.Data.StoreDisplayData> val_8 = this._sortedDisplayItems.Item[val_6._masterDomain];
            val_13 = null;
            val_13 = null;
            val_15 = StoreStateUIView.<>c.<>9__21_0;
            if(val_15 == null)
            {
                goto label_13;
            }
            
            if(val_8 != null)
            {
                goto label_18;
            }
            
            goto label_15;
            label_13:
            val_15 = null;
            val_15 = new System.Comparison<Game.Store.Data.StoreDisplayData>(object:  StoreStateUIView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 StoreStateUIView.<>c::<PopulateStoreItems>b__21_0(Game.Store.Data.StoreDisplayData a, Game.Store.Data.StoreDisplayData b));
            StoreStateUIView.<>c.<>9__21_0 = val_15;
            if(val_8 != null)
            {
                goto label_18;
            }
            
            label_15:
            label_18:
            val_8.Sort(comparison:  null);
            if(val_6._emailDatas == null)
            {
                goto label_19;
            }
            
            if(val_6._emailDatas != 1)
            {
                goto label_22;
            }
            
            this.PopulateMainSection(key:  val_6._masterDomain, items:  val_8);
            goto label_22;
            label_19:
            this.PopulateCarouselSection(items:  val_8);
            goto label_22;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateMainSection(string key, System.Collections.Generic.List<Game.Store.Data.StoreDisplayData> items)
        {
            if((this._storeSectionsByType.ContainsKey(key:  key)) == false)
            {
                    return;
            }
            
            GameUI.StoreSection val_2 = this._storeSectionsByType.Item[key];
            val_2.Reset();
            if((this._sortedDisplayItems.ContainsKey(key:  key)) == false)
            {
                    return;
            }
            
            this.AddItemsToStoreSection(section:  val_2, displayData:  items);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateCarouselSection(System.Collections.Generic.List<Game.Store.Data.StoreDisplayData> items)
        {
            goto label_1;
            label_15:
            GameUI.StoreCell val_1 = UnityEngine.Object.Instantiate<GameUI.StoreCell>(original:  this.CarouselBannerPrefab);
            Game.Store.Data.StoreDisplayData val_2 = items.Item[0];
            GameUI.StoreCellData val_4 = new GameUI.StoreCellData();
            .OnClickedDelegate = new System.Action<GameUI.StoreCell>(object:  this, method:  public System.Void GameUI.StoreStateUIView::OnStoreButtonClicked(GameUI.StoreCell cell));
            .displayData = items.Item[0];
            if(val_1 != null)
            {
                    val_1._storeCellData = val_4;
                val_1.UpdateDisplay();
            }
            else
            {
                    mem[112] = val_4;
                val_1.UpdateDisplay();
            }
            
            val_1.SetSprite(sprite:  this._masterDomain.StoreDomain.GetStoreIcon(iconName:  val_2.storeData.ArtRef));
            this.Carousel.AddItem(newItem:  val_1);
            0 = 1;
            label_1:
            if(0 < items.Count)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SortDisplayItems()
        {
            var val_6;
            var val_13 = this;
            this._sortedDisplayItems.Clear();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = this._masterDomain.StoreDomain.StoreContainer.DisplayItems.Values.GetEnumerator();
            label_15:
            if(((-1132546368) & 1) == 0)
            {
                    return;
            }
            
            if((this._sortedDisplayItems.ContainsKey(key:  val_7._serverGameUIDataModel.<currentStreakLeaderboard>k__BackingField)) != true)
            {
                    System.Collections.Generic.List<Game.Store.Data.StoreDisplayData> val_9 = new System.Collections.Generic.List<Game.Store.Data.StoreDisplayData>();
                this._sortedDisplayItems.set_Item(key:  val_7._serverGameUIDataModel.<currentStreakLeaderboard>k__BackingField, value:  null);
            }
            
            this._sortedDisplayItems.Item[val_7._serverGameUIDataModel.<currentStreakLeaderboard>k__BackingField].Add(item:  val_6.emailUIDataHandler);
            goto label_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddItemsToStoreSection(GameUI.StoreSection section, System.Collections.Generic.List<Game.Store.Data.StoreDisplayData> displayData)
        {
            var val_3;
            section.Reset();
            List.Enumerator<T> val_1 = displayData.GetEnumerator();
            label_11:
            if(((-1132323776) & 1) == 0)
            {
                    return;
            }
            
            GameUI.StoreCell val_5 = this.CreateNewCell(section:  section = section);
            new GameUI.StoreCellData() = new System.Object();
            System.Action<GameUI.StoreCell> val_8 = new System.Action<GameUI.StoreCell>(object:  this, method:  public System.Void GameUI.StoreStateUIView::OnStoreButtonClicked(GameUI.StoreCell cell));
            if(new GameUI.StoreCellData() != null)
            {
                    .OnClickedDelegate = null;
            }
            else
            {
                    mem[16] = null;
            }
            
            .displayData = val_3.emailUIDataHandler;
            val_5._storeCellData = new GameUI.StoreCellData();
            val_5.UpdateDisplay();
            val_5.SetSprite(sprite:  this._masterDomain.StoreDomain.GetStoreIcon(iconName:  val_4._serverGameUIDataModel.<maxEmailsSetReadPacketSize>k__BackingField));
            goto label_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCell CreateNewCell(GameUI.StoreSection section)
        {
            GameUI.StoreCell val_1 = UnityEngine.Object.Instantiate<GameUI.StoreCell>(original:  this.storeCellPrefab);
            section.AddItem(transform:  val_1.transform);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStoreButtonClicked(GameUI.StoreCell cell)
        {
            this.storeStateUIActions.ShowPurchaseDialog(cell:  cell);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStoreDataUpdated()
        {
            this.PopulateStore();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseError(string error)
        {
            this.PopulateStore();
            this.storeStateUIActions.OnPurchaseError(error:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator DelayByFrames(int frames, System.Action action)
        {
            StoreStateUIView.<DelayByFrames>d__30 val_1 = new StoreStateUIView.<DelayByFrames>d__30();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .frames = frames;
            }
            else
            {
                    mem[32] = frames;
            }
            
            .action = action;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleScrollToSection()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            GameUI.IllumixButtonBlackBoard val_2 = val_1.gameUIData.illumixButtonBlackBoard;
            GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
            val_3.gameUIData.illumixButtonBlackBoard = "None";
            if((System.String.op_Inequality(a:  val_2, b:  "None")) == false)
            {
                    return;
            }
            
            this.ScrollToSection(sectionType:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ScrollToSection(string sectionType)
        {
            System.Collections.Generic.Dictionary<System.String, GameUI.StoreSection> val_7;
            string val_8;
            val_7 = this._storeSectionsByType;
            if((val_7.ContainsKey(key:  sectionType)) == false)
            {
                goto label_2;
            }
            
            val_7 = this._storeSectionsByType.Item[sectionType];
            if((UnityEngine.Object.op_Implicit(exists:  val_7)) == false)
            {
                goto label_6;
            }
            
            val_7 = val_7.GetComponent<UnityEngine.RectTransform>();
            if((UnityEngine.Object.op_Implicit(exists:  val_7)) == false)
            {
                goto label_10;
            }
            
            GameUI.StoreStateUIView.ScrollToRectTransform(scrollRect:  this.StoreScrollRect, rectTransform:  val_7);
            return;
            label_2:
            val_8 = "Can\'t find section type - ";
            goto label_12;
            label_6:
            val_8 = "Can\'t find section - ";
            goto label_12;
            label_10:
            val_8 = "Can\'t find section\'s rect transform - ";
            label_12:
            ConsoleLogger.LogError(className:  "StoreStateUIView", functionName:  "ScrollToSection", logString:  val_8 + sectionType + "!"("!"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ScrollToRectTransform(UnityEngine.UI.ScrollRect scrollRect, UnityEngine.RectTransform rectTransform)
        {
            UnityEngine.Vector3 val_2 = scrollRect.content.localPosition;
            UnityEngine.Vector2 val_3 = GameUI.StoreStateUIView.GetSnapToPositionToBringChildIntoView(scrollRect:  scrollRect, rectTransform:  rectTransform);
            scrollRect.content.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_3.y, z = val_2.z};
            UnityEngine.Canvas.ForceUpdateCanvases();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Vector2 GetSnapToPositionToBringChildIntoView(UnityEngine.UI.ScrollRect scrollRect, UnityEngine.RectTransform rectTransform)
        {
            UnityEngine.Canvas.ForceUpdateCanvases();
            UnityEngine.Vector3 val_2 = scrollRect.viewport.localPosition;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = rectTransform.localPosition;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_5.x = val_3.x + val_5.x;
            val_5.y = val_3.y + val_5.y;
            val_5.x = 0f - val_5.x;
            val_5.y = 0f - val_5.y;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
            return new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            System.Action val_11;
            System.Action val_12;
            System.Action<System.String> val_13;
            this._masterDomain = Master.MasterDomain.GetDomain();
            this._sortedDisplayItems = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.Store.Data.StoreDisplayData>>();
            this.Carousel.Initialize();
            this.CreateStoreSections();
            this.PopulateStore();
            this._masterDomain.eventExposer.OnStoreOpened();
            val_11 = System.Delegate.Combine(a:  val_3.AppStoreProductsIntegrated, b:  new System.Action(object:  this, method:  public System.Void GameUI.StoreStateUIView::OnStoreDataUpdated()));
            if(this._masterDomain.StoreDomain.StoreContainer == null)
            {
                goto label_7;
            }
            
            if(val_11 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_11 == null)
            {
                goto label_11;
            }
            
            label_8:
            if(null != null)
            {
                    val_11 = 0;
            }
            
            label_11:
            val_3.AppStoreProductsIntegrated = val_11;
            val_12 = System.Delegate.Combine(a:  this._masterDomain.StoreDomain.IconsLoaded, b:  new System.Action(object:  this, method:  public System.Void GameUI.StoreStateUIView::IconsLoaded()));
            if(this._masterDomain.StoreDomain == null)
            {
                goto label_14;
            }
            
            if(val_12 != null)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if(val_12 == null)
            {
                goto label_18;
            }
            
            label_15:
            if(null != null)
            {
                    val_12 = 0;
            }
            
            label_18:
            this._masterDomain.StoreDomain.IconsLoaded = val_12;
            val_13 = System.Delegate.Combine(a:  this._masterDomain.StoreDomain.PurchaseErrorCallback, b:  new System.Action<System.String>(object:  this, method:  public System.Void GameUI.StoreStateUIView::OnPurchaseError(string error)));
            if(this._masterDomain.StoreDomain == null)
            {
                goto label_21;
            }
            
            if(val_13 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_13 == null)
            {
                goto label_25;
            }
            
            label_22:
            if(null != null)
            {
                    val_13 = 0;
            }
            
            label_25:
            this._masterDomain.StoreDomain.PurchaseErrorCallback = val_13;
            this._masterDomain.serverDomain.virtualGoodsListRequester.RequestVirtualGoods();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            System.Action val_1 = new System.Action(object:  this, method:  System.Void GameUI.StoreStateUIView::HandleScrollToSection());
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.DelayByFrames(frames:  1, action:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            object val_9;
            System.Action val_10;
            System.Action val_11;
            System.Action<System.String> val_12;
            val_9 = this;
            val_10 = System.Delegate.Remove(source:  val_1.AppStoreProductsIntegrated, value:  new System.Action(object:  this, method:  public System.Void GameUI.StoreStateUIView::OnStoreDataUpdated()));
            if(this._masterDomain.StoreDomain.StoreContainer == null)
            {
                goto label_4;
            }
            
            if(val_10 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_10 == null)
            {
                goto label_8;
            }
            
            label_5:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_8:
            val_1.AppStoreProductsIntegrated = val_10;
            val_11 = System.Delegate.Remove(source:  this._masterDomain.StoreDomain.IconsLoaded, value:  new System.Action(object:  this, method:  public System.Void GameUI.StoreStateUIView::IconsLoaded()));
            if(this._masterDomain.StoreDomain == null)
            {
                goto label_11;
            }
            
            if(val_11 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_11 == null)
            {
                goto label_15;
            }
            
            label_12:
            if(null != null)
            {
                    val_11 = 0;
            }
            
            label_15:
            this._masterDomain.StoreDomain.IconsLoaded = val_11;
            val_12 = System.Delegate.Remove(source:  this._masterDomain.StoreDomain.PurchaseErrorCallback, value:  new System.Action<System.String>(object:  this, method:  public System.Void GameUI.StoreStateUIView::OnPurchaseError(string error)));
            if(this._masterDomain.StoreDomain == null)
            {
                goto label_18;
            }
            
            if(val_12 != null)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_12 == null)
            {
                goto label_22;
            }
            
            label_19:
            if(null != null)
            {
                    val_12 = 0;
            }
            
            label_22:
            this._masterDomain.StoreDomain.PurchaseErrorCallback = val_12;
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            val_9 = this._masterDomain.eventExposer;
            val_9.OnStoreClosed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreStateUIView()
        {
        
        }
    
    }

}
