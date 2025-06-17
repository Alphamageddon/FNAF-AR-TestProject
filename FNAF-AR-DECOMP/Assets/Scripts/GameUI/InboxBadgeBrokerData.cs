using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxBadgeBrokerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.GetInboxMessagesRequster getInboxMessagesRequster;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.InboxBadgeActivator inboxBadgeActivator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxBadgeBrokerData()
        {
        
        }
    
    }

}
