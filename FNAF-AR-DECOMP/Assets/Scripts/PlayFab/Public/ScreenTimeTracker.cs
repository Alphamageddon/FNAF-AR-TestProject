using UnityEngine;

namespace PlayFab.Public
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScreenTimeTracker : IScreenTimeTracker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Guid focusId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Guid gameSessionID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool initialFocus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isSending;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime focusOffDateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime focusOnDateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<PlayFab.EventsModels.EventContents> eventsRequests;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.EventsModels.EntityKey entityKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string eventNamespace = "com.playfab.events.sessions";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int maxBatchSizeInEvents = 10;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClientSessionStart(string entityId, string entityType, string playFabUserId)
        {
            PlayFab.EventsModels.EntityKey val_8;
            System.Guid val_1 = System.Guid.NewGuid();
            this.gameSessionID = val_1;
            mem[1152921525747357960] = val_1._d;
            mem[1152921525747357961] = val_1._e;
            mem[1152921525747357962] = val_1._f;
            mem[1152921525747357963] = val_1._g;
            mem[1152921525747357964] = val_1._h;
            mem[1152921525747357965] = val_1._i;
            mem[1152921525747357966] = val_1._j;
            mem[1152921525747357967] = val_1._k;
            this.entityKey.Id = entityId;
            this.entityKey.Type = entityType;
            PlayFab.EventsModels.EventContents val_2 = new PlayFab.EventsModels.EventContents();
            if(val_2 != null)
            {
                    .Name = "client_session_start";
                .EventNamespace = "com.playfab.events.sessions";
                val_8 = this.entityKey;
            }
            else
            {
                    mem[32] = "client_session_start";
                mem[24] = "com.playfab.events.sessions";
                val_8 = this.entityKey;
            }
            
            .Entity = val_8;
            System.DateTime val_3 = System.DateTime.UtcNow;
            .OriginalTimestamp = 0;
            mem[1152921525747410456] = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_4.Add(key:  "UserID", value:  playFabUserId);
            val_4.Add(key:  "DeviceType", value:  UnityEngine.SystemInfo.deviceType);
            val_4.Add(key:  "DeviceModel", value:  UnityEngine.SystemInfo.deviceModel);
            val_4.Add(key:  "OS", value:  UnityEngine.SystemInfo.operatingSystem);
            val_4.Add(key:  "ClientSessionID", value:  this.gameSessionID);
            .Payload = val_4;
            this.eventsRequests.Enqueue(item:  val_2);
            this.OnApplicationFocus(isFocused:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnApplicationFocus(bool isFocused)
        {
            PlayFab.EventsModels.EntityKey val_11;
            var val_12;
            System.Guid val_13;
            var val_14;
            PlayFab.EventsModels.EventContents val_1 = new PlayFab.EventsModels.EventContents();
            System.DateTime val_2 = System.DateTime.UtcNow;
            if(val_1 != null)
            {
                    .Name = "client_focus_change";
                .EventNamespace = "com.playfab.events.sessions";
                val_11 = this.entityKey;
            }
            else
            {
                    mem[32] = "client_focus_change";
                mem[24] = "com.playfab.events.sessions";
                val_11 = this.entityKey;
            }
            
            .Entity = val_11;
            if(this.initialFocus != false)
            {
                    System.Guid val_3 = System.Guid.NewGuid();
                this.focusId = val_3;
                mem[1152921525747573880] = val_3._d;
                mem[1152921525747573881] = val_3._e;
                mem[1152921525747573882] = val_3._f;
                mem[1152921525747573883] = val_3._g;
                mem[1152921525747573884] = val_3._h;
                mem[1152921525747573885] = val_3._i;
                mem[1152921525747573886] = val_3._j;
                mem[1152921525747573887] = val_3._k;
            }
            
            if(isFocused == false)
            {
                goto label_8;
            }
            
            this.focusOnDateTime = val_2;
            System.Guid val_5 = System.Guid.NewGuid();
            val_12 = this;
            mem[1152921525747573880] = val_5._d;
            mem[1152921525747573881] = val_5._e;
            mem[1152921525747573882] = val_5._f;
            mem[1152921525747573883] = val_5._g;
            mem[1152921525747573884] = val_5._h;
            mem[1152921525747573885] = val_5._i;
            mem[1152921525747573886] = val_5._j;
            mem[1152921525747573887] = val_5._k;
            val_13 = 1152921525747573880;
            mem[1152921525747573872] = val_5._a;
            mem[1152921525747573876] = val_5._b;
            mem[1152921525747573878] = val_5._c;
            val_14 = 0;
            if(this.initialFocus == true)
            {
                goto label_15;
            }
            
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_2.dateData}, d2:  new System.DateTime() {dateData = this.focusOffDateTime});
            double val_7 = val_6._ticks.TotalSeconds;
            if(val_7 < 0)
            {
                goto label_15;
            }
            
            val_14 = val_7;
            goto label_15;
            label_8:
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_2.dateData}, d2:  new System.DateTime() {dateData = this.focusOnDateTime});
            double val_9 = val_8._ticks.TotalSeconds;
            val_13 = this.focusId;
            val_12 = 1152921525747573880;
            this.focusOffDateTime = val_2;
            label_15:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_10 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_10.Add(key:  "FocusID", value:  this.focusId._a);
            val_10.Add(key:  "FocusState", value:  isFocused);
            val_10.Add(key:  "FocusStateDuration", value:  ???);
            val_10.Add(key:  "EventTimestamp", value:  val_2);
            val_10.Add(key:  "ClientSessionID", value:  this.gameSessionID);
            .Payload = val_10;
            .OriginalTimestamp = 0;
            mem[1152921525747605912] = 0;
            this.eventsRequests.Enqueue(item:  val_1);
            this.initialFocus = false;
            if(isFocused == true)
            {
                    return;
            }
            
            this.Send();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Send()
        {
            System.Collections.Generic.List<PlayFab.EventsModels.EventContents> val_10;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() == false)
            {
                    return;
            }
            
            if(this.isSending == true)
            {
                    return;
            }
            
            this.isSending = true;
            .Events = new System.Collections.Generic.List<PlayFab.EventsModels.EventContents>();
            goto label_6;
            label_12:
            if((PlayFab.EventsModels.WriteEventsRequest)[1152921525747808992].Events.Count >= 10)
            {
                goto label_8;
            }
            
            (PlayFab.EventsModels.WriteEventsRequest)[1152921525747808992].Events.Add(item:  this.eventsRequests.Dequeue());
            label_6:
            if(this.eventsRequests.Count >= 1)
            {
                goto label_12;
            }
            
            label_8:
            val_10 = (PlayFab.EventsModels.WriteEventsRequest)[1152921525747808992].Events;
            if(val_10.Count >= 1)
            {
                    System.Action<PlayFab.EventsModels.WriteEventsResponse> val_8 = null;
                val_10 = val_8;
                val_8 = new System.Action<PlayFab.EventsModels.WriteEventsResponse>(object:  this, method:  System.Void PlayFab.Public.ScreenTimeTracker::EventSentSuccessfulCallback(PlayFab.EventsModels.WriteEventsResponse response));
                PlayFab.PlayFabEventsAPI.WriteEvents(request:  new PlayFab.EventsModels.WriteEventsRequest(), resultCallback:  val_8, errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void PlayFab.Public.ScreenTimeTracker::EventSentErrorCallback(PlayFab.PlayFabError response)), customData:  0, extraHeaders:  0);
            }
            
            this.isSending = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventSentSuccessfulCallback(PlayFab.EventsModels.WriteEventsResponse response)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventSentErrorCallback(PlayFab.PlayFabError response)
        {
            UnityEngine.Debug.LogWarning(message:  "Failed to send session data. Error: "("Failed to send session data. Error: ") + response.GenerateErrorReport());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnApplicationQuit()
        {
            this.Send();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScreenTimeTracker()
        {
            this.initialFocus = true;
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.focusOffDateTime = val_1;
            System.DateTime val_2 = System.DateTime.UtcNow;
            this.focusOnDateTime = val_2;
            this.eventsRequests = new System.Collections.Generic.Queue<PlayFab.EventsModels.EventContents>();
            this.entityKey = new PlayFab.EventsModels.EntityKey();
        }
    
    }

}
