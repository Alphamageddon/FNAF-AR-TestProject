using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AnalyticsCalls
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Systems.Analytics.AnalyticsDomain <Domain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, int> _arObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int maxPayloadItems = 10;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Map = "UI_Main_Map";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Store = "UI_Main_Store";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Inbox = "UI_Main_Inbox";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Camera_Remnant = "UI_Main_Remnant";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Camera_Stun = "UI_Main_Stun";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Workshop = "UI_Main_Workshop";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Profile = "UI_Main_Profile";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Settings = "UI_Main_Settings";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Friends = "UI_Profile_Friends";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Leaderboards = "UI_Profile_Leaderboards";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_Devices = "UI_Map_Devices";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_Navigation_DailyChallenges = "UI_Map_DailyChallenges";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_EncounterEnter = "Cam_Shocker_Event";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_EncounterDuration = "Cam_Shocker_Mode";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_EncounterShocksUsed = "Cam_Shocker_Use";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_EncounterFlashlightUsed = "Cam_Shocker_Flashlight";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_EncounterBatteriesUsed = "Cam_Shocker_Batteries";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_EncounterWin = "Cam_Shocker_Win";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_EncounterLose = "Cam_Shocker_Loss";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_RewardMaxStreak = "Streak_New_Max";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_StreakFunnelPrefix = "Streak_Funnel_";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_RewardCPU = "Reward_CPU";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_RewardPlushSuit = "Reward_Plushsuit";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_CollectSequentialReward = "Seasonal_Event";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_PurchaseLure = "Lure_Purchase";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_PurchaseDevice = "Device_Purchase";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_PurchaseMiniPack = "MiniPack_Purchase";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_PurchaseEndoskeleton = "Workshop_Slot_Purchase";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_ActivateLure = "Lure_Deploy";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_ArObjectsDetected = "AR_Objects_Detected";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_GuideNodePrefix = "FTUE_";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_SendFriendInvite = "Invite_Sent";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_OpenFriendCodeUI = "Friend_Code";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_SelectEnterFriendCode = "Enter_Friend_Code";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_SendAnimatronicToFriend = "Animatronic_Sent";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EventKey_SendAnimatronicToSalvage = "Animatronic_Salvage";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_Streak = "Streak";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_Cpu = "Cpu";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_ChargeDirection = "ChargeDirection";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_PlushSuit = "PlushSuit";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_Duration = "Duration";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_Remnant = "TotalRemnant";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_ShocksUsed = "ShocksUsed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_AvailableList = "AvailableList";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_BatteryPer = "BatteryPer";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_ExtraBatteries = "BatteryExtra";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_BatteriesUsed = "BatteriesUsed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_PurchasedItem = "PurchasedItem";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_TotalLures = "TotalLures";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_CurrentNumTokens = "CurrentNumTokens";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_TransactNumTokens = "TransactNumTokens";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_NumTickets = "NumTickets";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_AlertID = "AlertID";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_Read_Emails = "ReadEmails";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_Unread_Emails = "UnreadEmails";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_Unlocked_Slots = "UnlockedAnimatronicSlots";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_LureId = "LureId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_UserId = "UserId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_FriendCount = "FriendCount";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_SequentialRewardIndex = "CollectSequenceIndex";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_SequentialRewardSeason = "CollectSequenceSeason";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CollectionKey_ARPayload = "ARPayload";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Action OnNextNavigationEvent;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Systems.Analytics.AnalyticsDomain Domain { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Systems.Analytics.IAnalyticsProxy Proxy { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Systems.Analytics.AnalyticsDomain get_Domain()
        {
            null = null;
            return (Systems.Analytics.AnalyticsDomain)Systems.Analytics.AnalyticsCalls.CollectionKey_ARPayload;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_Domain(Systems.Analytics.AnalyticsDomain value)
        {
            null = null;
            Systems.Analytics.AnalyticsCalls.CollectionKey_ARPayload = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Systems.Analytics.IAnalyticsProxy get_Proxy()
        {
            if(Systems.Analytics.AnalyticsCalls.Domain != null)
            {
                    return (Systems.Analytics.IAnalyticsProxy)val_1._proxy;
            }
            
            return (Systems.Analytics.IAnalyticsProxy)val_1._proxy;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void EndInProgressTimedNavigationEvents()
        {
            var val_1 = null;
            if(Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent != null)
            {
                    Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent.Invoke();
                val_1 = null;
            }
            
            val_1 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Map()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Main_Map");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__7_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Map>b__7_0());
                AnalyticsCalls.<>c.<>9__7_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Store()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Main_Store");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__8_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Store>b__8_0());
                AnalyticsCalls.<>c.<>9__8_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Inbox(int readEmails, int unreadEmails)
        {
            int val_5;
            AnalyticsCalls.<>c__DisplayClass9_0 val_1 = new AnalyticsCalls.<>c__DisplayClass9_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .readEmails = readEmails;
            }
            else
            {
                    val_5 = 16;
                mem[16] = readEmails;
            }
            
            .unreadEmails = unreadEmails;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_5 = 0;
            val_5 = val_5 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithIntInt(mode:  1, key:  "UI_Main_Inbox", intField1:  "ReadEmails", intValue1:  val_5, intField2:  "UnreadEmails", intValue2:  (AnalyticsCalls.<>c__DisplayClass9_0)[1152921523442590272].unreadEmails);
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = new System.Action(object:  val_1, method:  System.Void AnalyticsCalls.<>c__DisplayClass9_0::<FireEvent_Ui_UserHitNavigationButton_Inbox>b__0());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Camera_Remnant()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Main_Remnant");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__10_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Camera_Remnant>b__10_0());
                AnalyticsCalls.<>c.<>9__10_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Camera_Stun()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Main_Stun");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__11_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Camera_Stun>b__11_0());
                AnalyticsCalls.<>c.<>9__11_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Workshop(int unlockedSlots)
        {
            .unlockedSlots = unlockedSlots;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_5 = 0;
            val_5 = val_5 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithInt(mode:  1, key:  "UI_Main_Workshop", intField:  "UnlockedAnimatronicSlots", intValue:  (AnalyticsCalls.<>c__DisplayClass12_0)[1152921523442987232].unlockedSlots);
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = new System.Action(object:  new AnalyticsCalls.<>c__DisplayClass12_0(), method:  System.Void AnalyticsCalls.<>c__DisplayClass12_0::<FireEvent_Ui_UserHitNavigationButton_Workshop>b__0());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Profile()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Main_Profile");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__13_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Profile>b__13_0());
                AnalyticsCalls.<>c.<>9__13_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Settings()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Main_Settings");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__14_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Settings>b__14_0());
                AnalyticsCalls.<>c.<>9__14_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Devices()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Map_Devices");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__15_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Devices>b__15_0());
                AnalyticsCalls.<>c.<>9__15_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Friends(int friendCount)
        {
            .friendCount = friendCount;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_5 = 0;
            val_5 = val_5 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithInt(mode:  1, key:  "UI_Profile_Friends", intField:  "FriendCount", intValue:  (AnalyticsCalls.<>c__DisplayClass16_0)[1152921523443513712].friendCount);
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = new System.Action(object:  new AnalyticsCalls.<>c__DisplayClass16_0(), method:  System.Void AnalyticsCalls.<>c__DisplayClass16_0::<FireEvent_Ui_UserHitNavigationButton_Friends>b__0());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_Leaderboards()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Profile_Leaderboards");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__17_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_Leaderboards>b__17_0());
                AnalyticsCalls.<>c.<>9__17_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Ui_UserHitNavigationButton_DailyChallenges()
        {
            var val_5;
            System.Action val_7;
            var val_8;
            Systems.Analytics.AnalyticsCalls.EndInProgressTimedNavigationEvents();
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  1, key:  "UI_Map_DailyChallenges");
            val_5 = null;
            val_5 = null;
            val_7 = AnalyticsCalls.<>c.<>9__18_0;
            if(val_7 == null)
            {
                    System.Action val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action(object:  AnalyticsCalls.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AnalyticsCalls.<>c::<FireEvent_Ui_UserHitNavigationButton_DailyChallenges>b__18_0());
                AnalyticsCalls.<>c.<>9__18_0 = val_7;
            }
            
            val_8 = null;
            val_8 = null;
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_AttackSequence_BeginEncounter()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  0, key:  "Cam_Shocker_Event");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_AttackSequence_WinAnimatronic(string cpuId, string plushSuitId, Game.AttackSequence.Encounters.RelativeDirection chargeDirection)
        {
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = chargeDirection});
            var val_5 = 0;
            val_5 = val_5 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStrStr(mode:  0, key:  "Cam_Shocker_Win", strField1:  "Cpu", stringValue1:  cpuId, strField2:  "ChargeDirection", stringValue2:  chargeDirection.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_AttackSequence_LoseAnimatronic(string cpuId, string plushSuitId, Game.AttackSequence.Encounters.RelativeDirection chargeDirection)
        {
            var val_8 = null;
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = chargeDirection});
            var val_8 = 0;
            val_8 = val_8 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStrStrStrInt(mode:  0, key:  "Cam_Shocker_Loss", strField1:  "Cpu", stringValue1:  cpuId, strField2:  "BatteryPer", stringValue2:  Systems.Analytics.AnalyticsCalls.GetBatteryPercentage().ToString(), strField3:  "ChargeDirection", stringValue3:  chargeDirection.ToString(), intField:  "BatteryExtra", intValue:  Systems.Analytics.AnalyticsCalls.GetExtraBatteries());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvents_AttackSequence_EncounterEnded(long encounterStartTime, Game.AttackSequence.Encounters.EncounterAnalyticsCollector encounterAnalyticsCollector)
        {
            long val_13 = encounterStartTime;
            var val_11 = 0;
            val_11 = val_11 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithInt(mode:  0, key:  "Cam_Shocker_Batteries", intField:  "BatteriesUsed", intValue:  Systems.Analytics.AnalyticsCalls.GetBatteriesUsed());
            if(encounterAnalyticsCollector.numFlashlightActivations >= 1)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  0, key:  "Cam_Shocker_Flashlight");
            }
            
            val_13 = TheGame.ServerTime.GetCurrentTime() - val_13;
            var val_14 = 0;
            val_14 = val_14 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithInt(mode:  0, key:  "Cam_Shocker_Mode", intField:  "Duration", intValue:  val_13);
            var val_15 = 0;
            val_15 = val_15 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithInt(mode:  0, key:  "Cam_Shocker_Use", intField:  "ShocksUsed", intValue:  encounterAnalyticsCollector.numShocksFired);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_MaxStreakIncreased(int maxStreak, int totalRemnant)
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithIntInt(mode:  0, key:  "Streak_New_Max", intField1:  "Streak", intValue1:  maxStreak, intField2:  "TotalRemnant", intValue2:  totalRemnant);
            var val_7 = 0;
            val_7 = val_7 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithInt(mode:  0, key:  System.String.Format(format:  "{0}{1}", arg0:  "Streak_Funnel_", arg1:  maxStreak), intField:  "TotalRemnant", intValue:  totalRemnant);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Reward_CPU(string cpuId)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStr(mode:  0, key:  "Reward_CPU", strField:  "Cpu", stringValue:  cpuId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Reward_PlushSuit(string plushSuitId)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStr(mode:  0, key:  "Reward_Plushsuit", strField:  "PlushSuit", stringValue:  plushSuitId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_Collect_SequentialReward(string season, int sequenceIndex)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStrInt(mode:  0, key:  "Seasonal_Event", strField:  "CollectSequenceSeason", stringValue:  season, intField:  "CollectSequenceIndex", intValue:  sequenceIndex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_PlayFabPurchaseSuccessful(PlayFab.ClientModels.ItemInstance item)
        {
            var val_22;
            string val_23;
            string val_25;
            var val_26;
            var val_28;
            string val_29;
            string val_30;
            var val_31;
            var val_33;
            var val_34;
            val_22 = item;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_23 = item.ItemClass;
            if((System.String.op_Equality(a:  val_23, b:  "Lure")) == false)
            {
                goto label_5;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_12;
            label_5:
            if((System.String.op_Equality(a:  val_23, b:  "MiniPack")) == false)
            {
                goto label_13;
            }
            
            val_25 = item.ItemId;
            val_26 = Systems.Analytics.AnalyticsCalls.Proxy;
            val_28 = null;
            val_29 = "MiniPack_Purchase";
            val_30 = "PurchasedItem";
            var val_15 = 0;
            val_31 = 1152921505176477704;
            val_15 = val_15 + 1;
            goto label_28;
            label_13:
            if((System.String.op_Equality(a:  val_23, b:  "Device")) == false)
            {
                goto label_21;
            }
            
            val_25 = item.ItemId;
            val_26 = Systems.Analytics.AnalyticsCalls.Proxy;
            val_28 = null;
            val_29 = "Device_Purchase";
            val_30 = "PurchasedItem";
            var val_16 = 0;
            val_31 = 1152921505176477704;
            val_16 = val_16 + 1;
            goto label_28;
            label_12:
            label_37:
            val_33 = ???;
            val_22 = ???;
            val_23 = ???;
            val_34 = ???;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStrInt(mode:  0, key:  "Lure_Purchase", strField:  "PurchasedItem", stringValue:  item.ItemId, intField:  "TotalLures", intValue:  val_1.devicesDomain.AllPlayerDevices.GetTotalLures());
            return;
            label_21:
            if((System.String.op_Equality(a:  val_23, b:  "EndoskeletonSlot")) == false)
            {
                    return;
            }
            
            Systems.Analytics.IAnalyticsProxy val_11 = Systems.Analytics.AnalyticsCalls.Proxy;
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_37;
            label_28:
            val_33 = ???;
            val_22 = ???;
            val_23 = ???;
            val_34 = ???;
            val_26.FireEventWithStr(mode:  0, key:  val_29, strField:  val_30, stringValue:  val_25);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_ActiveLure(string lureId)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStr(mode:  0, key:  "Lure_Deploy", strField:  "LureId", stringValue:  lureId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_InviteFriend()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  0, key:  "Invite_Sent");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_OpenFriendCodeUI()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  0, key:  "Friend_Code");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_SelectEnterFriendCode()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  0, key:  "Enter_Friend_Code");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_SendAnimatronicToFriend(string cpuId, string plushSuitId, string userId)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStrStrStr(mode:  0, key:  "Animatronic_Sent", strField1:  "Cpu", stringValue1:  cpuId, strField2:  "PlushSuit", stringValue2:  plushSuitId, strField3:  "UserId", stringValue3:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_SendAnimatronicToSalvage(string cpuId, string plushSuitId)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStrStr(mode:  0, key:  "Animatronic_Salvage", strField1:  "Cpu", stringValue1:  cpuId, strField2:  "PlushSuit", stringValue2:  plushSuitId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_GuideNodeActivated(string nodeId)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEvent(mode:  0, key:  "FTUE_" + nodeId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FireEvent_AR_ObjectsDetected(Wintellect.PowerCollections.OrderedSet<Systems.ARObjectDetection.Data.DetectedObject> detectedObjects)
        {
            var val_6;
            var val_8;
            string val_9;
            var val_11;
            System.Collections.Generic.IList<T> val_1 = detectedObjects.AsList();
            val_6 = 0;
            goto label_2;
            label_22:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = null;
            val_8 = null;
            if(val_1.Item[0] != 0)
            {
                    val_9 = mem[val_3 + 16];
                val_9 = val_3 + 16;
            }
            else
            {
                    val_9 = 11993091;
            }
            
            Systems.Analytics.AnalyticsCalls._arObjects.set_Item(key:  val_9, value:  val_3 + 24);
            if(Systems.Analytics.AnalyticsCalls._arObjects.Count >= 10)
            {
                    Systems.Analytics.AnalyticsCalls.FireEvent_AR_ObjectDetectedBatch();
            }
            
            val_6 = 1;
            label_2:
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(val_6 < val_1.Count)
            {
                goto label_22;
            }
            
            val_11 = null;
            val_11 = null;
            if(Systems.Analytics.AnalyticsCalls._arObjects.Count < 1)
            {
                    return;
            }
            
            Systems.Analytics.AnalyticsCalls.FireEvent_AR_ObjectDetectedBatch();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void FireEvent_AR_ObjectDetectedBatch()
        {
            object val_4;
            var val_15;
            string val_16;
            val_15 = null;
            val_16 = "";
            val_15 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = Systems.Analytics.AnalyticsCalls._arObjects.GetEnumerator();
            goto label_4;
            label_6:
            UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_4.trackableId;
            val_4 = val_5.m_SubId1;
            val_16 = val_16 + ","(val_16 + ",") + System.String.Format(format:  "{0}:{1}", arg0:  val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int32>::get_Key()), arg1:  val_4)(System.String.Format(format:  "{0}:{1}", arg0:  val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int32>::get_Key()), arg1:  val_4));
            label_4:
            if((1659553136 & 1) != 0)
            {
                goto label_6;
            }
            
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523446269296});
            var val_15 = 0;
            val_15 = val_15 + 1;
            Systems.Analytics.AnalyticsCalls.Proxy.FireEventWithStr(mode:  0, key:  "AR_Objects_Detected", strField:  "ARPayload", stringValue:  val_16);
            Systems.Analytics.AnalyticsCalls._arObjects.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetBatteryPercentage()
        {
            if(Systems.Analytics.AnalyticsCalls.Domain == null)
            {
                    return -1f;
            }
            
            Systems.Analytics.AnalyticsDomain val_2 = Systems.Analytics.AnalyticsCalls.Domain;
            if(val_2 != null)
            {
                    return val_2.BatteryCharge;
            }
            
            return val_2.BatteryCharge;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetExtraBatteries()
        {
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = Systems.Analytics.AnalyticsCalls.Domain.PurchasedDevices;
            if((val_2.ContainsKey(key:  "ExtraBattery")) == false)
            {
                    return 0;
            }
            
            if(val_2 != null)
            {
                    return val_2.Item["ExtraBattery"];
            }
            
            return val_2.Item["ExtraBattery"];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetBatteriesUsed()
        {
            Systems.Analytics.AnalyticsDomain val_1 = Systems.Analytics.AnalyticsCalls.Domain;
            if(val_1 == null)
            {
                    return (int)val_1;
            }
            
            Systems.Analytics.AnalyticsDomain val_2 = Systems.Analytics.AnalyticsCalls.Domain;
            if(val_2 != null)
            {
                    return val_2.NumExtraBatteriesUsed;
            }
            
            return val_2.NumExtraBatteriesUsed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetCurrentNumTokens()
        {
            if(Systems.Analytics.AnalyticsCalls.Domain == null)
            {
                    return 0;
            }
            
            Systems.Analytics.AnalyticsDomain val_2 = Systems.Analytics.AnalyticsCalls.Domain;
            if(val_2 != null)
            {
                    return val_2.CurrentFazTokens;
            }
            
            return val_2.CurrentFazTokens;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnalyticsCalls()
        {
            Systems.Analytics.AnalyticsCalls._arObjects = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            Systems.Analytics.AnalyticsCalls.OnNextNavigationEvent = 0;
        }
    
    }

}
