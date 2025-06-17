using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxCell : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI toText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI nameText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI subjectText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI dateTimeText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle highlightToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailData <emailData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> deleteEmailByIdDelegate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> showCellByIdDelegate;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.EmailData emailData { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_emailData(GameUI.EmailData value)
        {
            this.<emailData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.EmailData get_emailData()
        {
            return (GameUI.EmailData)this.<emailData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCellDisplay()
        {
            GameUI.EmailData val_7;
            string val_8;
            GameUI.EmailData val_9;
            GameUI.EmailData val_11;
            string val_12;
            GameUI.EmailData val_13;
            GameUI.EmailData val_15;
            string val_16;
            GameUI.EmailData val_17;
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            this.highlightToggle.SetHighlight(value:  ((this.<emailData>k__BackingField.isRead) == true) ? 1 : 0);
            val_7 = this.<emailData>k__BackingField;
            if(val_7 == null)
            {
                goto label_4;
            }
            
            val_8 = this.<emailData>k__BackingField.recipientString;
            val_9 = val_7;
            goto label_7;
            label_4:
            val_9 = this.<emailData>k__BackingField;
            val_8 = this.<emailData>k__BackingField.recipientString;
            if(val_9 == null)
            {
                goto label_6;
            }
            
            val_7 = val_9;
            goto label_7;
            label_6:
            val_7 = this.<emailData>k__BackingField;
            if(val_7 == null)
            {
                goto label_30;
            }
            
            label_7:
            var val_10 = 0;
            val_10 = val_10 + 1;
            this.toText.text = val_1.ILocalization.GetLocalizedString(localizedStringId:  val_8, originalString:  this.<emailData>k__BackingField.recipientString, replacementTokens:  this.<emailData>k__BackingField.tokens);
            val_11 = this.<emailData>k__BackingField;
            if(val_11 == null)
            {
                goto label_15;
            }
            
            val_12 = this.<emailData>k__BackingField.fromString;
            val_13 = val_11;
            goto label_18;
            label_15:
            val_13 = this.<emailData>k__BackingField;
            val_12 = this.<emailData>k__BackingField.fromString;
            if(val_13 == null)
            {
                goto label_17;
            }
            
            val_11 = val_13;
            goto label_18;
            label_17:
            val_11 = this.<emailData>k__BackingField;
            if(val_11 == null)
            {
                goto label_30;
            }
            
            label_18:
            var val_11 = 0;
            val_11 = val_11 + 1;
            this.nameText.text = val_1.ILocalization.GetLocalizedString(localizedStringId:  val_12, originalString:  this.<emailData>k__BackingField.fromString, replacementTokens:  this.<emailData>k__BackingField.tokens);
            val_15 = this.<emailData>k__BackingField;
            if(val_15 == null)
            {
                goto label_26;
            }
            
            val_16 = this.<emailData>k__BackingField.subjectString;
            val_17 = val_15;
            goto label_29;
            label_26:
            val_17 = this.<emailData>k__BackingField;
            val_16 = this.<emailData>k__BackingField.subjectString;
            if(val_17 == null)
            {
                goto label_28;
            }
            
            val_15 = val_17;
            goto label_29;
            label_28:
            val_15 = this.<emailData>k__BackingField;
            if(val_15 == null)
            {
                goto label_30;
            }
            
            label_29:
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.subjectText.text = val_1.ILocalization.GetLocalizedString(localizedStringId:  val_16, originalString:  this.<emailData>k__BackingField.subjectString, replacementTokens:  this.<emailData>k__BackingField.tokens);
            this.dateTimeText.text = this.<emailData>k__BackingField.GetTimeStamp();
            return;
            label_30:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEmailData(GameUI.EmailData email)
        {
            this.<emailData>k__BackingField = email;
            this.UpdateCellDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TrashButtonSelect()
        {
            if(this.deleteEmailByIdDelegate == null)
            {
                    return;
            }
            
            this.deleteEmailByIdDelegate.Invoke(obj:  this.<emailData>k__BackingField.id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowThisCellsEmail()
        {
            if(this.showCellByIdDelegate == null)
            {
                    return;
            }
            
            this.showCellByIdDelegate.Invoke(obj:  this.<emailData>k__BackingField.id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddDelegates(System.Action<string> deleteEmailByID, System.Action<string> showCellByID)
        {
            this.deleteEmailByIdDelegate = deleteEmailByID;
            this.showCellByIdDelegate = showCellByID;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetIsRead()
        {
            this.<emailData>k__BackingField.isRead = true;
            this.highlightToggle.SetHighlight(value:  ((this.<emailData>k__BackingField.isRead) == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxCell()
        {
        
        }
    
    }

}
