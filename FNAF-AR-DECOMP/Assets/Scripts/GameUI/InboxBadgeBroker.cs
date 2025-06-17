using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxBadgeBroker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxBadgeBrokerData _inboxBadgeBrokerData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _eventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _currentUnreadMsgCount;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEvents_EmailDataModelUpdated(System.Collections.Generic.List<GameUI.EmailData> data)
        {
            this.UpdateBadge(emails:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RetrieveAndInvokeAudio()
        {
            if(this._audioPlayer != null)
            {
                    this.InvokeMsgReceivedAudio();
                return;
            }
            
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void GameUI.InboxBadgeBroker::<RetrieveAndInvokeAudio>b__5_0(Game.Audio.IAudioPlayer audioPlayer)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InvokeMsgReceivedAudio()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForModeByName(name:  this._eventName, emitter:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBadge(System.Collections.Generic.List<GameUI.EmailData> emails)
        {
            var val_5;
            List.Enumerator<T> val_1 = emails.GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_4:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            label_2:
            if(((-1363952680) & 1) != 0)
            {
                goto label_4;
            }
            
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524717730776});
            this._inboxBadgeBrokerData.inboxBadgeActivator.SetBadgeValue(count:  -1363952679);
            if((-1363952679) > this._currentUnreadMsgCount)
            {
                    this.RetrieveAndInvokeAudio();
            }
            
            this._currentUnreadMsgCount = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxBadgeBroker(GameUI.InboxBadgeBrokerData inboxBadgeBrokerData)
        {
            this._eventName = "UIInboxMsgReceived";
            this._inboxBadgeBrokerData = inboxBadgeBrokerData;
            inboxBadgeBrokerData.masterEvents.add_EmailDataModelUpdated(value:  new System.Action<System.Collections.Generic.List<GameUI.EmailData>>(object:  this, method:  System.Void GameUI.InboxBadgeBroker::MasterEvents_EmailDataModelUpdated(System.Collections.Generic.List<GameUI.EmailData> data)));
            if(GameSparks.Core.GS.Authenticated != false)
            {
                    this._inboxBadgeBrokerData.getInboxMessagesRequster.GetInboxMessages();
            }
            
            this._currentUnreadMsgCount = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._inboxBadgeBrokerData.masterEvents.remove_EmailDataModelUpdated(value:  new System.Action<System.Collections.Generic.List<GameUI.EmailData>>(object:  this, method:  System.Void GameUI.InboxBadgeBroker::MasterEvents_EmailDataModelUpdated(System.Collections.Generic.List<GameUI.EmailData> data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <RetrieveAndInvokeAudio>b__5_0(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
            this.InvokeMsgReceivedAudio();
        }
    
    }

}
