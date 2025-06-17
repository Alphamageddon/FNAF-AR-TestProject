using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameDisplayChanger
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType currentDisplay;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_UICanvasReady(TheGame.GameDisplayData.DisplayType displayType)
        {
            if(displayType == 5)
            {
                    return;
            }
            
            this.SwapDisplay(displayType:  displayType);
            this.SendDisplayChangeEvent(previousDisplay:  this.currentDisplay, newDisplay:  displayType);
            this.currentDisplay = displayType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TrySwapGameScenesAndTriggerEvent(TheGame.GameDisplayData.DisplayType displayType)
        {
            this.SwapDisplay(displayType:  displayType);
            this.SendDisplayChangeEvent(previousDisplay:  this.currentDisplay, newDisplay:  displayType);
            this.currentDisplay = displayType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SwapDisplay(TheGame.GameDisplayData.DisplayType displayType)
        {
            var val_4;
            List.Enumerator<T> val_2 = this.domain.displayKeyValuePairs.GetEnumerator();
            do
            {
                if((1695338816 & 1) == 0)
            {
                    return;
            }
            
                GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            }
            while(val_5._serverGameUIDataModel == 0);
            
            var val_8 = (val_5._masterDomain == displayType) ? 1 : 0;
            val_8 = val_8 ^ val_5._serverGameUIDataModel.activeSelf;
            if(val_8 != false)
            {
                    this.UpdateSkybox(state:  displayType = displayType);
                val_5._serverGameUIDataModel.SetActive(value:  (val_5._masterDomain == displayType) ? 1 : 0);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendDisplayChangeEvent(TheGame.GameDisplayData.DisplayType previousDisplay, TheGame.GameDisplayData.DisplayType newDisplay)
        {
            TheGame.GameDisplayData val_1 = new TheGame.GameDisplayData();
            if(val_1 != null)
            {
                    .<previousDisplay>k__BackingField = previousDisplay;
            }
            else
            {
                    .<previousDisplay>k__BackingField = previousDisplay;
            }
            
            .<currentDisplay>k__BackingField = newDisplay;
            this.domain.masterDomain.eventExposer.OnGameDisplayChange(e:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSkybox(int state)
        {
            UnityEngine.Material[] val_5;
            Initialization.SkyboxSceneConfig val_1 = this.domain.masterDomain.SkyboxConfigs;
            val_5 = val_1.SceneMaterial;
            if(val_1.SceneMaterial.Length <= state)
            {
                    return;
            }
            
            Initialization.SkyboxSceneConfig val_2 = this.domain.masterDomain.SkyboxConfigs;
            val_5 = val_2.SceneMaterial[(long)state];
            if(val_5 == 0)
            {
                    return;
            }
            
            UnityEngine.RenderSettings.skybox = val_5;
            Initialization.SkyboxSceneConfig val_4 = this.domain.masterDomain.SkyboxConfigs;
            UnityEngine.RenderSettings.ambientIntensity = val_4.SceneIntensityMult[(long)state];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddAndroidBackButtonForMapAction()
        {
            int val_2 = Systems.Android.AndroidBackButtonHandler.PushBackButtonAction(backButtonAction:  new System.Action(object:  this, method:  System.Void TheGame.GameDisplayChanger::DoAndroidBackButtonActionForMap()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessAndroidBackButtonForDisplayChange(TheGame.GameDisplayData.DisplayType displayType)
        {
            if((displayType - 1) < 4)
            {
                    int val_3 = Systems.Android.AndroidBackButtonHandler.PushBackButtonAction(backButtonAction:  new System.Action(object:  this, method:  System.Void TheGame.GameDisplayChanger::<ProcessAndroidBackButtonForDisplayChange>b__9_0()));
                return;
            }
            
            if(displayType != 0)
            {
                    return;
            }
            
            Systems.Android.AndroidBackButtonHandler.ClearAllBackButtonActions();
            Systems.Android.AndroidBackButtonHandler.ClearAllPause();
            this.AddAndroidBackButtonForMapAction();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DoAndroidBackButtonActionForMap()
        {
            string val_14;
            var val_17;
            System.Action val_19;
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_16 = 0;
            val_16 = val_16 + 1;
            string val_3 = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_androidbackbutton_title", originalString:  "Quit");
            Game.Localization.LocalizationDomain val_4 = Game.Localization.LocalizationDomain.Instance;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_14 = val_4.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_androidbackbutton_body", originalString:  "Are you sure?");
            Game.Localization.LocalizationDomain val_7 = Game.Localization.LocalizationDomain.Instance;
            var val_18 = 0;
            val_18 = val_18 + 1;
            Game.Localization.LocalizationDomain val_10 = Game.Localization.LocalizationDomain.Instance;
            var val_19 = 0;
            val_19 = val_19 + 1;
            GameUI.GenericDialogData val_13 = new GameUI.GenericDialogData();
            if(val_13 != null)
            {
                    .title = val_3;
                .message = val_14;
            }
            else
            {
                    mem[16] = val_3;
                mem[24] = val_14;
            }
            
            .positiveButtonText = val_7.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_androidbackbutton_positivebutton", originalString:  "Yes");
            val_17 = null;
            val_17 = null;
            val_19 = GameDisplayChanger.<>c.<>9__10_0;
            if(val_19 == null)
            {
                    System.Action val_14 = null;
                val_19 = val_14;
                val_14 = new System.Action(object:  GameDisplayChanger.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameDisplayChanger.<>c::<DoAndroidBackButtonActionForMap>b__10_0());
                GameDisplayChanger.<>c.<>9__10_0 = val_19;
            }
            
            .positiveButtonAction = val_19;
            .negativeButtonText = val_10.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_androidbackbutton_negativebutton", originalString:  "No");
            .negativeButtonAction = new System.Action(object:  this, method:  System.Void TheGame.GameDisplayChanger::AddAndroidBackButtonForMapAction());
            this.domain.masterDomain.eventExposer.GenericDialogRequest(genericDialogData:  val_13);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameDisplayChanger(TheGame.Domain domain)
        {
            this.domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            this.domain.masterDomain.eventExposer.add_UICanvasDidAppear(value:  new System.Action<DisplayType>(object:  this, method:  System.Void TheGame.GameDisplayChanger::EventExposer_UICanvasReady(TheGame.GameDisplayData.DisplayType displayType)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestDisplayChange(TheGame.GameDisplayData.DisplayType displayType)
        {
            GameUI.Domain val_1 = this.domain.masterDomain.gameUIDomain;
            if(val_1.gameUIData.buttonConfigs.IsLocked != false)
            {
                    return;
            }
            
            GameUI.Domain val_4 = this.domain.masterDomain.gameUIDomain;
            val_4.gameUIData.buttonConfigs.LockDisplayChange(displayType:  displayType);
            GameUI.Domain val_6 = this.domain.masterDomain.gameUIDomain;
            Systems.Guide.FeatureFlags.FeatureFlagMap val_8 = val_6.gameUIData.serverGameUIDataModel.featureFlagMap;
            if(val_8 != null)
            {
                    if(val_8.IsResultsReturnToCameraAllowed() != false)
            {
                    this.ProcessAndroidBackButtonForDisplayChange(displayType:  displayType);
            }
            
            }
            
            this.domain.masterDomain.eventExposer.OnUIChangeRequest(obj:  displayType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayData.DisplayType GetDisplayType()
        {
            return (DisplayType)this.currentDisplay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsDisplayType(TheGame.GameDisplayData.DisplayType displayType)
        {
            return (bool)(this.currentDisplay == displayType) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ProcessAndroidBackButtonForDisplayChange>b__9_0()
        {
            this.RequestDisplayChange(displayType:  0);
        }
    
    }

}
