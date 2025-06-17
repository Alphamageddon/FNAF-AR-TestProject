using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopAnimatronicButton : MonoBehaviour, IWorkshopSlotButton
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI buttonStatusText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle highlightToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI costText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject statusIconObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string availableText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string deliveringText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string returningText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string scavengingText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string attackingText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string brokenText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopSlotData workshopSlotData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _index;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetStatusText(string newText)
        {
            this.buttonStatusText.text = newText;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateWearAndTearText()
        {
            if((this.workshopSlotData.<ServerEntry>k__BackingField) == null)
            {
                goto label_2;
            }
            
            if(this.costText != null)
            {
                goto label_6;
            }
            
            label_7:
            label_6:
            this.costText.text = this.workshopSlotData.<ServerEntry>k__BackingField.health.ToString();
            return;
            label_2:
            if(this.costText != null)
            {
                goto label_6;
            }
            
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAvailableText()
        {
            string val_1;
            string val_2;
            UnityEngine.GameObject val_3;
            var val_4;
            if((this.workshopSlotData.<ServerEntry>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.workshopSlotData.<ServerEntry>k__BackingField) == null)
            {
                goto label_5;
            }
            
            if((this.workshopSlotData.<ServerEntry>k__BackingField.status) == 0)
            {
                goto label_6;
            }
            
            label_9:
            if((this.workshopSlotData.<ServerEntry>k__BackingField.status) != 1)
            {
                goto label_7;
            }
            
            val_1 = this.scavengingText;
            goto label_19;
            label_5:
            if((this.workshopSlotData.<ServerEntry>k__BackingField.status) != 0)
            {
                goto label_9;
            }
            
            label_6:
            if((this.workshopSlotData.<ServerEntry>k__BackingField.health) == 0)
            {
                goto label_10;
            }
            
            val_2 = this.availableText;
            goto label_11;
            label_7:
            if((this.workshopSlotData.<ServerEntry>k__BackingField.status) != 2)
            {
                goto label_14;
            }
            
            val_1 = this.deliveringText;
            goto label_19;
            label_14:
            if((this.workshopSlotData.<ServerEntry>k__BackingField.status) != 3)
            {
                goto label_18;
            }
            
            val_1 = this.returningText;
            goto label_19;
            label_10:
            val_2 = this.brokenText;
            label_11:
            this.SetStatusText(newText:  val_2);
            val_3 = this.statusIconObject;
            val_4 = 1;
            goto label_21;
            label_18:
            if((this.workshopSlotData.<ServerEntry>k__BackingField.status) != 4)
            {
                    return;
            }
            
            val_1 = this.attackingText;
            label_19:
            this.SetStatusText(newText:  val_1);
            val_3 = this.statusIconObject;
            val_4 = 0;
            label_21:
            val_3.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateIcon()
        {
            if(this.image.overrideSprite != 0)
            {
                    if((System.String.op_Inequality(a:  this.image.overrideSprite.name, b:  this.workshopSlotData.Sprite.name)) == false)
            {
                    return;
            }
            
            }
            
            this.image.overrideSprite = this.workshopSlotData.Sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Initialize(GameUI.WorkshopSlotData data, int index)
        {
            this.workshopSlotData = data;
            this._index = index;
            this.image.overrideSprite = data.Sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSelectedUI(bool value)
        {
            value = value;
            this.highlightToggle.SetHighlightAndOtherCellsHighlightState(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.UpdateAvailableText();
            this.UpdateWearAndTearText();
            this.FetchLocalization();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchLocalization()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.WorkshopAnimatronicButton::<FetchLocalization>b__20_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateAvailableText();
            this.UpdateWearAndTearText();
            this.UpdateIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSortWeight()
        {
            return (int)this._index;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Data.StoreDisplayData GetStoreDisplayData()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopSlotData GetWorkshopSlotData()
        {
            return (GameUI.WorkshopSlotData)this.workshopSlotData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopAnimatronicButton()
        {
            this.availableText = "AVAILABLE";
            this.deliveringText = "DELIVERING";
            this.returningText = "RETURNING";
            this.scavengingText = "SALVAGING";
            this.attackingText = "ATTACKING";
            this.brokenText = "BROKEN";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalization>b__20_0(Game.Localization.ILocalization localization)
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_19 = 0;
            val_19 = val_19 + 1;
            this.returningText = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_recalling_text", originalString:  this.returningText);
            Game.Localization.LocalizationDomain val_4 = Game.Localization.LocalizationDomain.Instance;
            var val_20 = 0;
            val_20 = val_20 + 1;
            this.availableText = val_4.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_available_text", originalString:  this.availableText);
            Game.Localization.LocalizationDomain val_7 = Game.Localization.LocalizationDomain.Instance;
            var val_21 = 0;
            val_21 = val_21 + 1;
            this.scavengingText = val_7.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_scavenging_text", originalString:  this.scavengingText);
            Game.Localization.LocalizationDomain val_10 = Game.Localization.LocalizationDomain.Instance;
            var val_22 = 0;
            val_22 = val_22 + 1;
            this.deliveringText = val_10.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_delivering_text", originalString:  this.deliveringText);
            Game.Localization.LocalizationDomain val_13 = Game.Localization.LocalizationDomain.Instance;
            var val_23 = 0;
            val_23 = val_23 + 1;
            this.attackingText = val_13.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_attacking_text", originalString:  this.attackingText);
            Game.Localization.LocalizationDomain val_16 = Game.Localization.LocalizationDomain.Instance;
            var val_24 = 0;
            val_24 = val_24 + 1;
            this.brokenText = val_16.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_broken_text", originalString:  this.brokenText);
        }
    
    }

}
