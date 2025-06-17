using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendRemoveCell : MonoBehaviour, ICellInterface<GameUI.FriendsRemoveCellData>
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
        private GameUI.FriendsRemoveCellData _data;
        
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
        public void RemoveFriend()
        {
            string val_1;
            if(this._data.callback == null)
            {
                    return;
            }
            
            if((this._data == null) || (this._data.playerFriendsEntry == null))
            {
                goto label_4;
            }
            
            val_1 = this._data.playerFriendsEntry.userId;
            if(this._data != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            val_1 = 0;
            label_6:
            this._data.callback.Invoke(arg1:  val_1, arg2:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.FriendsRemoveCellData data)
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
        private void OnDisable()
        {
            this.highlightToggle.SetHighlight(value:  false);
            this.sentPanel.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendRemoveCell()
        {
        
        }
    
    }

}
