using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideNodeDriver _driver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideInitializer _initializer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideEventsSharedContext _guideEventsSharedContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideConditionSharedContext _conditionSharedContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideActionSharedContext _actionSharedContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GameplayAdapter _adapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.SimulatedGuideEventAdapter _simulatedAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideVisualizerPresenter _visualizerPresenter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideSrOptions _guideSrOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.MasterDomain masterDomain)
        {
            Systems.Guide.GuideEventsSharedContext val_1 = new Systems.Guide.GuideEventsSharedContext();
            this._guideEventsSharedContext = val_1;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            label_13:
            ._masterEvents = masterDomain.eventExposer;
            Systems.Guide.GuideActionSharedContext val_2 = new Systems.Guide.GuideActionSharedContext();
            this._actionSharedContext = val_2;
            val_2.Setup(masterDomain:  masterDomain);
            Systems.Guide.GuideConditionSharedContext val_3 = new Systems.Guide.GuideConditionSharedContext();
            this._conditionSharedContext = val_3;
            val_3.Setup(exposer:  masterDomain.eventExposer, storeDomain:  masterDomain.StoreDomain);
            masterDomain.SceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void Systems.Guide.GuideDomain::GetMapTableAsync(MapSceneLookupTable mapSceneLookupTable)));
            Systems.Guide.GuideNodeDriver val_6 = new Systems.Guide.GuideNodeDriver();
            this._driver = val_6;
            val_6.Setup(actionSharedContext:  this._actionSharedContext, conditionSharedContext:  this._conditionSharedContext);
            Systems.Guide.GuideInitializer val_7 = new Systems.Guide.GuideInitializer();
            this._initializer = val_7;
            val_7.Setup(masterEvents:  masterDomain.eventExposer, driver:  this._driver, masterData:  masterDomain.MasterDataDomain);
            Systems.Guide.GameplayAdapter val_8 = new Systems.Guide.GameplayAdapter();
            this._adapter = val_8;
            val_8.Setup(guideEventsSharedContext:  this._guideEventsSharedContext, nodeDriver:  this._driver);
            Systems.Guide.GuideVisualizerPresenter val_9 = new Systems.Guide.GuideVisualizerPresenter();
            this._visualizerPresenter = val_9;
            val_9.Setup(driver:  this._driver);
            Systems.Guide.GuideSrOptions val_10 = new Systems.Guide.GuideSrOptions(serverDomain:  masterDomain.serverDomain, nodeDriver:  this._driver);
            this._guideSrOptions = val_10;
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "Tutorial", sectionMenuObject:  val_10, defaultToOn:  false);
            return;
            label_1:
            if(masterDomain != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetMapTableAsync(MapSceneLookupTable mapSceneLookupTable)
        {
            this._conditionSharedContext._mapSceneLookup = mapSceneLookupTable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._actionSharedContext != null)
            {
                    this._actionSharedContext._audioPlayer = 0;
                this._actionSharedContext._pushNotificationsInitializer = 0;
                this._actionSharedContext._gameUIDomain = 0;
            }
            
            this._actionSharedContext = 0;
            if(this._conditionSharedContext != null)
            {
                    this._conditionSharedContext.Teardown();
            }
            
            this._conditionSharedContext = 0;
            if(this._guideEventsSharedContext != null)
            {
                    this._guideEventsSharedContext._masterEvents = 0;
            }
            
            this._guideEventsSharedContext = 0;
            if(this._simulatedAdapter != null)
            {
                    this._simulatedAdapter._nodeDriver = 0;
            }
            
            this._simulatedAdapter = 0;
            if(this._adapter != null)
            {
                    this._adapter.Teardown();
            }
            
            this._adapter = 0;
            if(this._initializer != null)
            {
                    this._initializer.Teardown();
            }
            
            this._initializer = 0;
            if(this._driver != null)
            {
                    this._driver.Teardown();
            }
            
            this._driver = 0;
            if(this._visualizerPresenter != null)
            {
                    this._visualizerPresenter.Teardown();
            }
            
            this._visualizerPresenter = 0;
            mem[1152921523375245168] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._driver != null)
            {
                    this._driver.Update();
            }
            
            if(this._adapter == null)
            {
                    return;
            }
            
            this._adapter.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideDomain()
        {
        
        }
    
    }

}
