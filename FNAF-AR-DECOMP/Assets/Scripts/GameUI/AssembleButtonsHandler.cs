using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssembleButtonsHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel _workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _plushSuitButtonImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _cpuButtonImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.UI.Button> _modSelectionButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _modButtonActiveImages;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _modButtonEmptyImages;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.UI.Image> _modButtonImages;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _modSelectionButtonsLockedIcons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<TMPro.TextMeshProUGUI> _modUnlockTexts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.IItemDefinitionDomain _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _essenceSlotTotalDisplayText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MAX_STREAK_KEY = "ui_workshop_modify_mod_button_max_streak_unlock";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string maxStreakUnlockPrefixString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssembleButtonsHandler(Master.MasterDomain masterDomain, GameUI.WorkshopSlotDataModel workshopSlotDataModel, UnityEngine.UI.Image plushSuitButtonImage, UnityEngine.UI.Image cpuButtonImage, System.Collections.Generic.List<UnityEngine.UI.Button> modSelectionButtons, System.Collections.Generic.List<UnityEngine.GameObject> modButtonActiveImages, System.Collections.Generic.List<UnityEngine.UI.Image> modButtonImages, System.Collections.Generic.List<UnityEngine.GameObject> modSelectionButtons_Highlight, TMPro.TextMeshProUGUI essenceSlotTotalDisplayText, System.Collections.Generic.List<TMPro.TextMeshProUGUI> modUnlockTexts, System.Collections.Generic.List<UnityEngine.GameObject> modButtonEmptyImages)
        {
            this.maxStreakUnlockPrefixString = "UNLOCK STREAK: ";
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            this._workshopSlotDataModel = val_1;
            this._plushSuitButtonImage = plushSuitButtonImage;
            this._cpuButtonImage = cpuButtonImage;
            this._modSelectionButtons = modSelectionButtons;
            this._modButtonActiveImages = modButtonActiveImages;
            this._modButtonEmptyImages = modButtonEmptyImages;
            this._essenceSlotTotalDisplayText = essenceSlotTotalDisplayText;
            this._modButtonImages = modButtonImages;
            this._modSelectionButtonsLockedIcons = modSelectionButtons_Highlight;
            this._modUnlockTexts = modUnlockTexts;
            masterDomain.ItemDefinitionDomain.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void GameUI.AssembleButtonsHandler::ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.AssembleButtonsHandler::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            this.SetModUnlockText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            this._itemDefinitionDomain = itemDefinitionDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetModUnlockText()
        {
            AssembleButtonsHandler.<>c__DisplayClass18_0 val_12;
            AssembleButtonsHandler.<>c__DisplayClass18_0 val_1 = null;
            val_12 = val_1;
            val_1 = new AssembleButtonsHandler.<>c__DisplayClass18_0();
            .<>4__this = this;
            .modUnlocks = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetStreaksForMods();
            .index = 0;
            List.Enumerator<T> val_4 = this._modUnlockTexts.GetEnumerator();
            label_10:
            if(((-1266250504) & 1) == 0)
            {
                    return;
            }
            
            new AssembleButtonsHandler.<>c__DisplayClass18_1() = new System.Object();
            .CS$<>8__locals1 = val_12;
            .text = 0.emailUIDataHandler;
            System.Action<Game.Localization.ILocalization> val_9 = new System.Action<Game.Localization.ILocalization>(object:  new AssembleButtonsHandler.<>c__DisplayClass18_1(), method:  System.Void AssembleButtonsHandler.<>c__DisplayClass18_1::<SetModUnlockText>b__0(Game.Localization.ILocalization localization));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  null);
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetModIcons(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton)
        {
            Game.ItemDefinition.Container.ItemDefinitions val_16;
            Game.ItemDefinition.Data.DataDefinitions.ModData val_17;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = this._itemDefinitionDomain.ItemDefinitions;
            GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
            int val_5 = val_16.GetNumModSlotsUnlocked(bestStreak:  val_3.gameUIData.GetServerBestStreak());
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_17 = 0;
            label_26:
            bool val_8 = false;
            if(endoskeleton.mods.Count > val_17)
            {
                    string val_7 = endoskeleton.mods.Item[0];
                val_17 = val_7.GetModData(itemDefinitions:  val_16, modName:  val_7, hasMod: out  val_8);
            }
            else
            {
                    val_17 = 0;
            }
            
            val_16 = val_8;
            this._modButtonActiveImages.Item[0].SetActive(value:  (val_16 != 0) ? 1 : 0);
            this._modButtonEmptyImages.Item[0].SetActive(value:  (val_16 == 0) ? 1 : 0);
            UnityEngine.GameObject val_15 = this._modButtonImages.Item[0].gameObject;
            if(val_15 == null)
            {
                goto label_22;
            }
            
            if(val_16 == 0)
            {
                goto label_23;
            }
            
            label_25:
            val_15.SetActive(value:  true);
            this.SetModButtonIcon(modData:  val_17, index:  0);
            goto label_24;
            label_22:
            if(val_16 != 0)
            {
                goto label_25;
            }
            
            label_23:
            val_15.SetActive(value:  false);
            label_24:
            val_17 = val_17 + 1;
            if(val_5 != val_17)
            {
                goto label_26;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.ModData GetModData(Game.ItemDefinition.Container.ItemDefinitions itemDefinitions, string modName, out bool hasMod)
        {
            var val_4 = 0;
            if((System.String.IsNullOrEmpty(value:  modName)) != true)
            {
                    Game.ItemDefinition.Data.DataDefinitions.ModData val_2 = itemDefinitions.GetModById(id:  modName);
            }
            
            hasMod = (val_2 != 0) ? 1 : 0;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetModButtonIcon(Game.ItemDefinition.Data.DataDefinitions.ModData modData, int index)
        {
            if(this._modButtonImages.Count <= index)
            {
                    return;
            }
            
            this.SetIconForMod(modData:  modData, modImage:  this._modButtonImages.Item[index]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIconForMod(Game.ItemDefinition.Data.DataDefinitions.ModData modData, UnityEngine.UI.Image modImage)
        {
            Game.AssetManagement.Icons.IIconLookup val_9;
            string val_10;
            var val_13;
            val_9 = this;
            if(modData == null)
            {
                goto label_1;
            }
            
            val_10 = modData.ModIconName;
            if(val_10 != null)
            {
                goto label_2;
            }
            
            label_1:
            val_10 = System.String.alignConst;
            label_2:
            if((System.String.IsNullOrWhiteSpace(value:  val_10)) == false)
            {
                goto label_3;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_8;
            label_3:
            if(modImage.overrideSprite != 0)
            {
                    if((System.String.op_Inequality(a:  modImage.overrideSprite.name, b:  val_10)) == false)
            {
                    return;
            }
            
            }
            
            val_9 = this._iconLookup;
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_20;
            label_8:
            val_13 = this._iconLookup;
            UnityEngine.Sprite val_8 = val_13.GetDefaultIcon();
            goto label_21;
            label_20:
            val_13 = val_9;
            label_21:
            modImage.overrideSprite = val_13.GetIcon(group:  1, name:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIconForCpu(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton, UnityEngine.UI.Image cpuImage)
        {
            string val_12;
            var val_15;
            var val_14 = 0;
            val_14 = val_14 + 1;
            if((this._itemDefinitionDomain.ItemDefinitions.GetCPUById(id:  endoskeleton.cpu)) == null)
            {
                goto label_8;
            }
            
            val_12 = val_3.CpuIconNameFlat;
            if(val_12 != null)
            {
                goto label_9;
            }
            
            label_8:
            val_12 = System.String.alignConst;
            label_9:
            if((System.String.IsNullOrWhiteSpace(value:  val_12)) == false)
            {
                goto label_10;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_15;
            label_10:
            if(cpuImage.overrideSprite != 0)
            {
                    if((System.String.op_Inequality(a:  cpuImage.overrideSprite.name, b:  val_12)) == false)
            {
                    return;
            }
            
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            goto label_27;
            label_15:
            val_15 = this._iconLookup;
            UnityEngine.Sprite val_11 = val_15.GetDefaultIcon();
            goto label_28;
            label_27:
            val_15 = this._iconLookup;
            label_28:
            cpuImage.overrideSprite = val_15.GetIcon(group:  0, name:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIconForPlushSuit(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton, UnityEngine.UI.Image plushSuitImage)
        {
            string val_12;
            var val_15;
            var val_14 = 0;
            val_14 = val_14 + 1;
            if((this._itemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  endoskeleton.plushSuit)) == null)
            {
                goto label_8;
            }
            
            val_12 = val_3.PortraitIconFlatName;
            if(val_12 != null)
            {
                goto label_9;
            }
            
            label_8:
            val_12 = System.String.alignConst;
            label_9:
            if((System.String.IsNullOrWhiteSpace(value:  val_12)) == false)
            {
                goto label_10;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_15;
            label_10:
            if(plushSuitImage.overrideSprite != 0)
            {
                    if((System.String.op_Inequality(a:  plushSuitImage.overrideSprite.name, b:  val_12)) == false)
            {
                    return;
            }
            
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            goto label_27;
            label_15:
            val_15 = this._iconLookup;
            UnityEngine.Sprite val_11 = val_15.GetDefaultIcon();
            goto label_28;
            label_27:
            val_15 = this._iconLookup;
            label_28:
            plushSuitImage.overrideSprite = val_15.GetIcon(group:  2, name:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateModSlotButtonsEnabled()
        {
            var val_7 = 0;
            goto label_1;
            label_10:
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            this._modSelectionButtons.Item[0].interactable = true;
            this._modSelectionButtonsLockedIcons.Item[0].SetActive(value:  (val_7 >= val_1.gameUIData.modSlotUnlocks) ? 1 : 0);
            val_7 = 1;
            label_1:
            if(val_7 < this._modSelectionButtons.Count)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAssembleDisplay()
        {
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_2 = this._workshopSlotDataModel.GetSelectedSlotData().DisplayEndoskeleton;
            this.SetIconForPlushSuit(endoskeleton:  val_2, plushSuitImage:  this._plushSuitButtonImage);
            this.SetIconForCpu(endoskeleton:  val_2, cpuImage:  this._cpuButtonImage);
            this.SetModIcons(endoskeleton:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEssenceDisplay()
        {
            int val_4;
            GameUI.WorkshopSlotData val_1 = this._workshopSlotDataModel.GetSelectedSlotData();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_2 = val_1.DisplayEndoskeleton;
            val_4 = val_2.numEssence.ToString(format:  "n0");
            if(val_4 != null)
            {
                goto label_4;
            }
            
            label_2:
            val_4 = System.String.alignConst;
            label_4:
            this._essenceSlotTotalDisplayText.text = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateModSlotButtonsEnabled();
            this.UpdateAssembleDisplay();
            this.UpdateEssenceDisplay();
        }
    
    }

}
