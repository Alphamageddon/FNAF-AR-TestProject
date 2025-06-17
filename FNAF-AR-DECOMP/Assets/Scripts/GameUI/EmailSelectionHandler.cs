using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EmailSelectionHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailSelectionHandler.EmailSelectionHandlerData _hookups;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.InboxCell> _inboxCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.InboxFolderCell> _inboxFolderCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _currentShowId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _currentSelectedFolderId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_EmailDataModelUpdated(System.Collections.Generic.List<GameUI.EmailData> obj)
        {
            this.RefreshInbox();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EmailSelectionHandler(GameUI.EmailSelectionHandler.EmailSelectionHandlerData data)
        {
            this._inboxCells = new System.Collections.Generic.List<GameUI.InboxCell>();
            this._inboxFolderCells = new System.Collections.Generic.List<GameUI.InboxFolderCell>();
            this._currentShowId = System.String.alignConst;
            data.masterDomain.add_EmailDataModelUpdated(value:  new System.Action<System.Collections.Generic.List<GameUI.EmailData>>(object:  this, method:  System.Void GameUI.EmailSelectionHandler::EventExposer_EmailDataModelUpdated(System.Collections.Generic.List<GameUI.EmailData> obj)));
            this.Initialize();
            this.RefreshInbox();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Initialize()
        {
            string val_2;
            int val_1 = 0;
            X20.GetNumberReadAndUnread(read: out  val_1, unread: out  val_1);
            if(0 > 0)
            {
                    val_2 = "Inbox_01";
            }
            else
            {
                    val_2 = "Inbox_00";
            }
            
            this._currentSelectedFolderId = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DeleteInboxCellById(string id)
        {
            .id = id;
            GameUI.InboxCell val_3 = this._inboxCells.Find(match:  new System.Predicate<GameUI.InboxCell>(object:  new EmailSelectionHandler.<>c__DisplayClass9_0(), method:  System.Boolean EmailSelectionHandler.<>c__DisplayClass9_0::<DeleteInboxCellById>b__0(GameUI.InboxCell cell)));
            if(val_3 == 0)
            {
                    return;
            }
            
            bool val_5 = this._inboxCells.Remove(item:  val_3);
            UnityEngine.Object.Destroy(obj:  val_3.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DeleteEmailById(string id)
        {
            X21.DeleteEmailByID(id:  id);
            this.DeleteInboxCellById(id:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowCellByID(string id)
        {
            GameUI.EmailData val_1 = X21.GetEmailByID(searchId:  id);
            if(val_1 == null)
            {
                    return;
            }
            
            this._currentShowId = val_1.id;
            if(val_1.isRead != true)
            {
                    X22.SetEmailReadByID(id:  id);
                this.SetInboxCellReadById(id:  id);
            }
            
            this.ShowEmail(emailData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetInboxCellReadById(string id)
        {
            .id = id;
            GameUI.InboxCell val_3 = this._inboxCells.Find(match:  new System.Predicate<GameUI.InboxCell>(object:  new EmailSelectionHandler.<>c__DisplayClass12_0(), method:  System.Boolean EmailSelectionHandler.<>c__DisplayClass12_0::<SetInboxCellReadById>b__0(GameUI.InboxCell cell)));
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.SetIsRead();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowEmail(GameUI.EmailData emailData)
        {
            mem2[0] = this._hookups;
            mem2[0] = emailData;
            X20.RefreshDisplay();
            this.gameObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshInboxCellCount()
        {
            int val_4 = GetNumberOfEmails();
            val_4 = val_4 - this._inboxCells.Count;
            if(val_4 >= 1)
            {
                    this.AddInboxCells(numCellsToAdd:  val_4);
                return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
            
            this.RemoveInboxCells(numCellsToDelete:  UnityEngine.Mathf.Abs(value:  val_4));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddInboxCells(int numCellsToAdd)
        {
            GameUI.InboxCell val_4;
            int val_5 = numCellsToAdd;
            if(val_5 < 1)
            {
                    return;
            }
            
            do
            {
                val_4 = UnityEngine.Object.Instantiate<GameUI.InboxCell>(original:  X22, parent:  69730304);
                val_1.deleteEmailByIdDelegate = new System.Action<System.String>(object:  this, method:  System.Void GameUI.EmailSelectionHandler::DeleteEmailById(string id));
                val_1.showCellByIdDelegate = new System.Action<System.String>(object:  this, method:  System.Void GameUI.EmailSelectionHandler::ShowCellByID(string id));
                this._inboxCells.Add(item:  val_4);
                val_5 = val_5 - 1;
            }
            while(val_5 != 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveInboxCells(int numCellsToDelete)
        {
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            var val_12;
            val_10 = numCellsToDelete;
            if(val_10 < 1)
            {
                    return;
            }
            
            do
            {
                if(this._inboxCells != null)
            {
                    val_11 = this._inboxCells.Count;
            }
            else
            {
                    val_11 = 0.Count;
            }
            
                if(this._inboxCells != null)
            {
                    val_12 = this._inboxCells.Count;
            }
            else
            {
                    val_12 = 0.Count;
            }
            
                this._inboxCells.RemoveAt(index:  val_12 - 1);
                val_9 = this._inboxCells.Item[val_11 - 1].gameObject;
                UnityEngine.Object.Destroy(obj:  val_9);
                val_10 = val_10 - 1;
            }
            while(val_10 != 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshInboxCellContent()
        {
            var val_9;
            GameUI.EmailData val_11;
            var val_13;
            var val_14;
            string val_12 = "TKey is a reference type and item.Key is null.";
            if(X9 == 0)
            {
                goto label_6;
            }
            
            var val_11 = 0;
            var val_1 = X11 + 8;
            label_5:
            if(((X11 + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_11 = val_11 + 1;
            val_1 = val_1 + 16;
            if(val_11 < X9)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            val_12 = val_12 + (((X11 + 8)) << 4);
            val_9 = val_12 + 296;
            label_6:
            System.Collections.IEnumerator val_2 = GetEnumerator();
            goto label_7;
            label_24:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_11 = val_2.Current;
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            if(val_11 != (val_7.<emailData>k__BackingField))
            {
                    val_7.<emailData>k__BackingField = val_11;
                this._inboxCells.Item[0].UpdateCellDisplay();
            }
            
            label_7:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_2.MoveNext() == true)
            {
                goto label_24;
            }
            
            val_13 = 0;
            val_14 = 101;
            if(val_2 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_2.Dispose();
            }
            
            if( == 101)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshInbox()
        {
            this.RefreshInboxCellCount();
            this.RefreshInboxCellContent();
            this.ShowByFolder();
            this.UpdateFolderDisplayName();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowByFolder()
        {
            var val_7 = this;
            List.Enumerator<T> val_1 = this._inboxCells.GetEnumerator();
            label_8:
            if(((-1250740136) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            string val_7 = this._currentSelectedFolderId;
            val_7 = val_2.Contains(item:  val_7);
            val_2.gameObject.SetActive(value:  val_7);
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateFolderCells()
        {
            var val_7 = this;
            List.Enumerator<T> val_2 = GetInboxFolderIds().GetEnumerator();
            label_4:
            if(((-1250591240) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            this.SetInboxFolderCellData(inboxFolderCell:  this.GetFolderCell(folderId:  val_3), logical:  val_3);
            goto label_4;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524831092216});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetInboxFolderCellData(GameUI.InboxFolderCell inboxFolderCell, string logical)
        {
            int val_9;
            GameUI.InboxFolderCellData val_1 = new GameUI.InboxFolderCellData();
            if(val_1 != null)
            {
                    .folderId = logical;
                val_9 = this.GetNumEmails(logical:  logical);
            }
            else
            {
                    mem[16] = logical;
                val_9 = this.GetNumEmails(logical:  logical);
            }
            
            .numEmailsInFolder = val_9;
            Game.ItemDefinition.Data.DataDefinitions.InboxData val_4 = val_9.GetInboxData(logical:  logical);
            .folderLocKey = val_4.folderNameLocKey;
            .DeleteFolderDelegate = new System.Action<System.String>(object:  this, method:  System.Void GameUI.EmailSelectionHandler::DeleteFolder(string id));
            .SelectFolderDelegate = new System.Action<System.String>(object:  this, method:  public System.Void GameUI.EmailSelectionHandler::SetFolderId(string id));
            .isCurrentFolder = System.String.op_Equality(a:  logical, b:  this._currentSelectedFolderId);
            inboxFolderCell.SetData(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetNumEmails(string logical)
        {
            .logical = logical;
            System.Collections.Generic.List<T> val_3 = this._inboxCells.FindAll(match:  new System.Predicate<GameUI.InboxCell>(object:  new EmailSelectionHandler.<>c__DisplayClass22_0(), method:  System.Boolean EmailSelectionHandler.<>c__DisplayClass22_0::<GetNumEmails>b__0(GameUI.InboxCell x)));
            if(val_3 != null)
            {
                    return val_3.Count;
            }
            
            return val_3.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxFolderCell GetFolderCell(string folderId)
        {
            System.Collections.Generic.List<GameUI.InboxFolderCell> val_6;
            GameUI.InboxFolderCell val_7;
            UnityEngine.Object val_8;
            val_6 = this;
            .folderId = folderId;
            val_7 = 1152921504851574784;
            val_8 = this._inboxFolderCells.Find(match:  new System.Predicate<GameUI.InboxFolderCell>(object:  new EmailSelectionHandler.<>c__DisplayClass23_0(), method:  System.Boolean EmailSelectionHandler.<>c__DisplayClass23_0::<GetFolderCell>b__0(GameUI.InboxFolderCell x)));
            if(val_8 != 0)
            {
                    return val_8;
            }
            
            val_6 = this._inboxFolderCells;
            val_8 = UnityEngine.Object.Instantiate<GameUI.InboxFolderCell>(original:  val_7, parent:  val_8);
            val_6.Add(item:  val_8);
            return val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DeleteFolder(string id)
        {
            var val_8 = this;
            .id = id;
            List.Enumerator<T> val_4 = this._inboxCells.FindAll(match:  new System.Predicate<GameUI.InboxCell>(object:  new EmailSelectionHandler.<>c__DisplayClass24_0(), method:  System.Boolean EmailSelectionHandler.<>c__DisplayClass24_0::<DeleteFolder>b__0(GameUI.InboxCell x))).GetEnumerator();
            label_7:
            if(((-1249924104) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_5 = 0.emailUIDataHandler;
            this.DeleteEmailById(id:  public GameUI.InboxCell List.Enumerator<GameUI.InboxCell>::get_Current());
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowFolderParent(bool value)
        {
            if(X21.activeSelf ^ value == false)
            {
                    return;
            }
            
            X21.SetActive(value:  value);
            this.Rotate(xAngle:  0f, yAngle:  0f, zAngle:  (value != true) ? 90f : -90f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFolderDisplayName()
        {
            Utilities.AsyncInterfaceAccess<Game.Localization.ILocalization> val_2 = Game.Localization.LocalizationDomain.Instance.Localization;
            val_2.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.EmailSelectionHandler::<UpdateFolderDisplayName>b__26_0(Game.Localization.ILocalization localization)));
            val_2.text = this.GetNumEmails(logical:  this._currentSelectedFolderId).ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFolderId(string id)
        {
            this._currentSelectedFolderId = id;
            this.RefreshInbox();
            this.ShowFolderParent(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowFolderSelect()
        {
            var val_2;
            if(X20.activeSelf != false)
            {
                    val_2 = 0;
            }
            else
            {
                    this.GenerateFolderCells();
                val_2 = 1;
            }
            
            this.ShowFolderParent(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteShownEmail()
        {
            this.DeleteEmailById(id:  this._currentShowId);
            this.CloseEmail();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetCurrentShowID()
        {
            return (string)this._currentShowId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CloseEmail()
        {
            X19.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
            UpdateServer();
            remove_EmailDataModelUpdated(value:  new System.Action<System.Collections.Generic.List<GameUI.EmailData>>(object:  this, method:  System.Void GameUI.EmailSelectionHandler::EventExposer_EmailDataModelUpdated(System.Collections.Generic.List<GameUI.EmailData> obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <UpdateFolderDisplayName>b__26_0(Game.Localization.ILocalization localization)
        {
            Game.ItemDefinition.Data.DataDefinitions.InboxData val_1 = GetInboxData(logical:  this._currentSelectedFolderId);
            var val_4 = 0;
            val_4 = val_4 + 1;
            localization.text = localization.GetLocalizedString(localizedStringId:  val_1.folderNameLocKey, originalString:  val_1.folderNameLocKey);
        }
    
    }

}
