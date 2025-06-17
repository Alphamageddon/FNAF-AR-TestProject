using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendCodeModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _myCurrentFriendCode;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MyCurrentFriendCode { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_MyCurrentFriendCode()
        {
            return (string)this._myCurrentFriendCode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendCodeModel(Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
            masterDomain.eventExposer.add_PersonalFriendCodeUpdated(value:  new System.Action<System.String>(object:  this, method:  System.Void GameUI.FriendCodeModel::EventExposer_PersonalFriendCodeUpdated(string friendCode)));
            this._myCurrentFriendCode = "[No Friend Code]";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_PersonalFriendCodeUpdated(string friendCode)
        {
            this._myCurrentFriendCode = friendCode;
        }
    
    }

}
