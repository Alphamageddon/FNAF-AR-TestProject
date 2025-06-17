using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EmailUIDataHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ALL = "Inbox_00";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string NEW = "Inbox_01";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ServerGameUIDataModel _serverGameUIDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.EmailData> _emailDatas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _emailIdsToBeDeletedOnServer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _emailIdsToBeSetToReadOnServer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerable emailDatas { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerable get_emailDatas()
        {
            return (System.Collections.IEnumerable)this._emailDatas;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_InboxDataReceivedFromServer(System.Collections.Generic.List<GameUI.EmailData> data)
        {
            this._emailDatas = this.UpdateWithLocalData(data:  data);
            this.SortAndBroadcast();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EmailUIDataHandler(Master.MasterDomain masterDomain, GameUI.ServerGameUIDataModel serverGameUIDataModel)
        {
            this._emailDatas = new System.Collections.Generic.List<GameUI.EmailData>();
            this._emailIdsToBeDeletedOnServer = new System.Collections.Generic.List<System.String>();
            this._emailIdsToBeSetToReadOnServer = new System.Collections.Generic.List<System.String>();
            val_4 = new System.Object();
            this._masterDomain = masterDomain;
            this._serverGameUIDataModel = val_4;
            this._itemDefinitions = masterDomain.ItemDefinitionDomain.ItemDefinitions;
            this._masterDomain.eventExposer.add_InboxDataReceivedFromServer(value:  new System.Action<System.Collections.Generic.List<GameUI.EmailData>>(object:  this, method:  System.Void GameUI.EmailUIDataHandler::EventExposer_InboxDataReceivedFromServer(System.Collections.Generic.List<GameUI.EmailData> data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateInboxFromServer(System.Collections.Generic.List<GameUI.EmailData> data)
        {
            this._emailDatas = this.UpdateWithLocalData(data:  data);
            this.SortAndBroadcast();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SortAndBroadcast()
        {
            this._emailDatas.Sort(comparison:  new System.Comparison<GameUI.EmailData>(object:  this, method:  System.Int32 GameUI.EmailUIDataHandler::SortByNewestAndUnread(GameUI.EmailData e1, GameUI.EmailData e2)));
            this.Broadcast();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.EmailData> UpdateWithLocalData(System.Collections.Generic.List<GameUI.EmailData> data)
        {
            var val_3;
            List.Enumerator<T> val_1 = this._emailIdsToBeDeletedOnServer.GetEnumerator();
            label_5:
            if(((-1198227776) & 1) == 0)
            {
                goto label_2;
            }
            
            new EmailUIDataHandler.<>c__DisplayClass14_0() = new System.Object();
            .id = val_3.emailUIDataHandler;
            System.Predicate<GameUI.EmailData> val_6 = new System.Predicate<GameUI.EmailData>(object:  new EmailUIDataHandler.<>c__DisplayClass14_0(), method:  System.Boolean EmailUIDataHandler.<>c__DisplayClass14_0::<UpdateWithLocalData>b__0(GameUI.EmailData email));
            int val_7 = data.RemoveAll(match:  null);
            goto label_5;
            label_2:
            List.Enumerator<T> val_10 = data.GetEnumerator();
            do
            {
                label_21:
                if(((-1198227800) & 1) == 0)
            {
                    return (System.Collections.Generic.List<GameUI.EmailData>)data;
            }
            
                GameUI.EmailUIDataHandler val_11 = 0.emailUIDataHandler;
            }
            while((this._emailIdsToBeSetToReadOnServer.Contains(item:  1152921517654220160)) == false);
            
            mem2[0] = 1;
            bool val_13 = this._emailIdsToBeSetToReadOnServer.Remove(item:  "Inbox_01");
            goto label_21;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int SortByNewestAndUnread(GameUI.EmailData e1, GameUI.EmailData e2)
        {
            var val_11;
            var val_12;
            var val_13;
            val_11 = e2;
            val_12 = e1;
            val_13 = val_12;
            var val_2 = (e2.isRead == true) ? 1 : 0;
            val_2 = ((e1.isRead == true) ? 1 : 0) ^ val_2;
            if((val_2 & 1) != 0)
            {
                    val_12 = ???;
                val_11 = ???;
                var val_3 = (e2.isRead == true) ? 1 : 0;
                val_13 = ???;
            }
            
            var val_4 = val_11 + 56;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Broadcast()
        {
            GameUI.ServerGameUIDataModel val_5;
            this._masterDomain.eventExposer.OnEmailModelUpdated(emailDatas:  this._emailDatas);
            val_5 = this._serverGameUIDataModel;
            if(this._emailIdsToBeSetToReadOnServer.Count < val_5.maxEmailsToDeletePacketSize)
            {
                    val_5 = this._serverGameUIDataModel;
                if(this._emailIdsToBeDeletedOnServer.Count < val_5.maxEmailsSetReadPacketSize)
            {
                    return;
            }
            
            }
            
            this.UpdateServer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEmailReadByID(string id)
        {
            System.Collections.Generic.List<GameUI.EmailData> val_7;
            this._emailIdsToBeSetToReadOnServer.Add(item:  id);
            val_7 = this._emailDatas;
            List.Enumerator<T> val_1 = val_7.GetEnumerator();
            label_5:
            if(((-1197764760) & 1) == 0)
            {
                goto label_3;
            }
            
            val_7 = 0.emailUIDataHandler;
            if((System.String.op_Equality(a:  0, b:  id)) == false)
            {
                goto label_5;
            }
            
            mem2[0] = 1;
            bool val_4 = id.Remove(item:  "Inbox_01");
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524883918696});
            this.SortAndBroadcast();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteEmailByID(string id)
        {
            .id = id;
            int val_3 = this._emailDatas.RemoveAll(match:  new System.Predicate<GameUI.EmailData>(object:  new EmailUIDataHandler.<>c__DisplayClass18_0(), method:  System.Boolean EmailUIDataHandler.<>c__DisplayClass18_0::<DeleteEmailByID>b__0(GameUI.EmailData emailToDelete)));
            this._emailIdsToBeDeletedOnServer.Add(item:  (EmailUIDataHandler.<>c__DisplayClass18_0)[1152921524884124960].id);
            this.SortAndBroadcast();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNumberOfEmails()
        {
            if(this._emailDatas != null)
            {
                    return this._emailDatas.Count;
            }
            
            return this._emailDatas.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.EmailData GetEmailByID(string searchId)
        {
            .searchId = searchId;
            if(this._emailDatas != null)
            {
                    return this._emailDatas.Find(match:  new System.Predicate<GameUI.EmailData>(object:  new EmailUIDataHandler.<>c__DisplayClass20_0(), method:  System.Boolean EmailUIDataHandler.<>c__DisplayClass20_0::<GetEmailByID>b__0(GameUI.EmailData email)));
            }
            
            return this._emailDatas.Find(match:  new System.Predicate<GameUI.EmailData>(object:  new EmailUIDataHandler.<>c__DisplayClass20_0(), method:  System.Boolean EmailUIDataHandler.<>c__DisplayClass20_0::<GetEmailByID>b__0(GameUI.EmailData email)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetNumberReadAndUnread(out int read, out int unread)
        {
            var val_5 = null;
            if((EmailUIDataHandler.<>c.<>9__21_0) == null)
            {
                goto label_3;
            }
            
            label_10:
            read = this._emailDatas.FindAll(match:  EmailUIDataHandler.<>c.<>9__21_0).Count;
            int val_5 = read;
            val_5 = this._emailDatas.Count - val_5;
            unread = val_5;
            return;
            label_3:
            EmailUIDataHandler.<>c.<>9__21_0 = new System.Predicate<GameUI.EmailData>(object:  EmailUIDataHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EmailUIDataHandler.<>c::<GetNumberReadAndUnread>b__21_0(GameUI.EmailData x));
            if(this._emailDatas != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateServer()
        {
            if(this._emailIdsToBeSetToReadOnServer.Count <= 0)
            {
                    if(this._emailIdsToBeDeletedOnServer.Count < 1)
            {
                goto label_4;
            }
            
            }
            
            this._masterDomain.serverDomain.batchInboxRequester.BatchUpdateInbox(readIds:  new System.Collections.Generic.List<System.String>(collection:  this._emailIdsToBeSetToReadOnServer), deleteIds:  new System.Collections.Generic.List<System.String>(collection:  this._emailIdsToBeDeletedOnServer));
            label_4:
            this._emailIdsToBeDeletedOnServer.Clear();
            this._emailIdsToBeSetToReadOnServer.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetNewID()
        {
            return "Inbox_01";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetAllID()
        {
            return "Inbox_00";
        }
    
    }

}
