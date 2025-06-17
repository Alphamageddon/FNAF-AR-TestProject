using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxStateUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Inbox dialogHandler_Inbox;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxStateUIView inboxStateUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject emailButtonParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Inbox gameProject_Alpine_CanvasController_Inbox;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteEmail()
        {
            this.inboxStateUIView.DeleteShownEmail();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CloseEmail()
        {
            this.inboxStateUIView.CloseEmail();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowFolderSelection()
        {
            this.inboxStateUIView.ShowFolderSelect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxStateUIActions()
        {
        
        }
    
    }

}
