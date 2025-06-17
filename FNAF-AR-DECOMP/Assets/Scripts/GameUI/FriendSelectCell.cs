using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendSelectCell : MonoBehaviour, ICellInterface<GameUI.FriendsListCellData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button selectButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button sendButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI playerName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image avatar;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle highlightToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject sentPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendsListCellData _data;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateText()
        {
            if(this.playerName == 0)
            {
                    return;
            }
            
            if(this._data == null)
            {
                    return;
            }
            
            if(this._data.playerFriendsEntry == null)
            {
                    return;
            }
            
            if(this._data.playerFriendsEntry.displayName == null)
            {
                    return;
            }
            
            this.playerName.text = this._data.playerFriendsEntry.displayName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.FriendsListCellData data)
        {
            this._data = data;
            this.UpdateText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this.avatar.overrideSprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendToFriend()
        {
            string val_2;
            if(this._data == null)
            {
                    return;
            }
            
            if(this.sentPanel.activeSelf == true)
            {
                    return;
            }
            
            this.sentPanel.SetActive(value:  true);
            this.highlightToggle.SetHighlight(value:  false);
            if(this._data.callback == null)
            {
                    return;
            }
            
            if((this._data == null) || (this._data.playerFriendsEntry == null))
            {
                goto label_9;
            }
            
            val_2 = this._data.playerFriendsEntry.userId;
            if(this._data != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_9:
            val_2 = 0;
            label_11:
            this._data.callback.Invoke(obj:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._data == null)
            {
                    return;
            }
            
            this.selectButton.interactable = this._data.getSendingEnabled.Invoke();
            this.sendButton.interactable = this._data.getSendingEnabled.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this.highlightToggle.SetHighlight(value:  false);
            this.sentPanel.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendSelectCell()
        {
        
        }
    
    }

}
