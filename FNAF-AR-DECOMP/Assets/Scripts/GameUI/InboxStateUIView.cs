using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxStateUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Inbox dialogHandler_Inbox;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxCell inboxCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform inboxCellParentTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI readText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI totalText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI emptyInboxText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailDialogDisplay emailDialogDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxFolderCell inboxFolderCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform inboxFolderParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject inboxFolderBackground;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI folderNameDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI folderNumEmailsDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform folderArrow;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailUIDataHandler _emailUIDataHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailSelectionHandler _emailSelectionHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateTotalInboxMessagesDisplay()
        {
            int val_5 = 0;
            this.emptyInboxText.gameObject.SetActive(value:  (this._emailUIDataHandler.GetNumberOfEmails() < 1) ? 1 : 0);
            this._emailUIDataHandler.GetNumberReadAndUnread(read: out  0, unread: out  val_5);
            this.readText.text = val_5.ToString();
            this.totalText.text = 0.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetCurrentShowID()
        {
            if(this._emailSelectionHandler != null)
            {
                    return (string)this._emailSelectionHandler._currentShowId;
            }
            
            return (string)this._emailSelectionHandler._currentShowId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CloseEmail()
        {
            this._emailSelectionHandler.CloseEmail();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteShownEmail()
        {
            this._emailSelectionHandler.DeleteEmailById(id:  this._emailSelectionHandler._currentShowId);
            this._emailSelectionHandler.CloseEmail();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowFolderSelect()
        {
            this._emailSelectionHandler.ShowFolderSelect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            var val_5;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            if(val_1 != null)
            {
                    val_5 = this;
                this._eventExposer = val_1.eventExposer;
            }
            else
            {
                    val_5 = this;
                this._eventExposer = 456;
            }
            
            GameUI.Domain val_2 = val_1.gameUIDomain;
            this._emailUIDataHandler = val_2.gameUIData;
            this._emailSelectionHandler = new GameUI.EmailSelectionHandler(data:  new EmailSelectionHandlerData() {masterDomain = val_1, eventExposer = this._eventExposer, emailUIDataHandler = val_2.gameUIData, emailDialogDisplay = this.emailDialogDisplay, inboxCellPrefab = this.inboxCellPrefab, inboxCellParentTransform = this.inboxCellParentTransform, itemDefinitions = val_1.ItemDefinitionDomain.ItemDefinitions, inboxFolderCellPrefab = this.inboxFolderCellPrefab, inboxFolderParent = this.inboxFolderCellPrefab, inboxFolderBackground = this.inboxFolderBackground, folderDisplayName = this.inboxFolderBackground, folderArrow = this.folderArrow, folderNumEmailsDisplay = this.folderNumEmailsDisplay});
            this._eventExposer.OnInboxOpened();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this._emailSelectionHandler.OnDisable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateTotalInboxMessagesDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this._eventExposer.OnInboxClosed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxStateUIView()
        {
        
        }
    
    }

}
