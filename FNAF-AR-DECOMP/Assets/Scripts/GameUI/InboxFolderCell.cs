using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxFolderCell : MonoBehaviour, ICellInterface<GameUI.InboxFolderCellData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.IllumixButton _selectFolderButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.IllumixButton _deleteFolderButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _folderText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.InboxFolderCellData inboxFolderCellData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetFolderName(string locKey, int number)
        {
            InboxFolderCell.<>c__DisplayClass4_0 val_1 = new InboxFolderCell.<>c__DisplayClass4_0();
            if(val_1 != null)
            {
                    .locKey = locKey;
                .<>4__this = this;
            }
            else
            {
                    mem[16] = locKey;
                mem[24] = this;
            }
            
            .number = number;
            this._folderText.fontStyle = this.inboxFolderCellData.isCurrentFolder;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void InboxFolderCell.<>c__DisplayClass4_0::<SetFolderName>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.InboxFolderCellData data)
        {
            this.inboxFolderCellData = data;
            if(data != null)
            {
                goto label_0;
            }
            
            data = this.inboxFolderCellData;
            if(data == null)
            {
                goto label_1;
            }
            
            label_0:
            this.SetFolderName(locKey:  data.folderLocKey, number:  this.inboxFolderCellData.numEmailsInFolder);
            return;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectFolder()
        {
            if(this.inboxFolderCellData != null)
            {
                goto label_1;
            }
            
            this.inboxFolderCellData = this.inboxFolderCellData;
            if(this.inboxFolderCellData == null)
            {
                goto label_2;
            }
            
            label_1:
            this.inboxFolderCellData.SelectFolderDelegate.Invoke(obj:  this.inboxFolderCellData.folderId);
            return;
            label_2:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteFolder()
        {
            if(this.inboxFolderCellData != null)
            {
                goto label_1;
            }
            
            this.inboxFolderCellData = this.inboxFolderCellData;
            if(this.inboxFolderCellData == null)
            {
                goto label_2;
            }
            
            label_1:
            this.inboxFolderCellData.DeleteFolderDelegate.Invoke(obj:  this.inboxFolderCellData.folderId);
            return;
            label_2:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._selectFolderButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.InboxFolderCell::SelectFolder()));
            this._selectFolderButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.InboxFolderCell::SelectFolder()));
            this._deleteFolderButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.InboxFolderCell::DeleteFolder()));
            this._deleteFolderButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.InboxFolderCell::DeleteFolder()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxFolderCell()
        {
        
        }
    
    }

}
