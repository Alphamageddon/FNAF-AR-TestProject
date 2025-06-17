using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class AkCallbackManager
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool <IsLoggingEnabled>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkEventCallbackInfo AkEventCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkMarkerCallbackInfo AkMarkerCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkDurationCallbackInfo AkDurationCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkMonitoringCallbackInfo AkMonitoringCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkBankCallbackInfo AkBankCallbackInfo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.Dictionary<int, AkCallbackManager.EventCallbackPackage> m_mapEventCallbacks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.Dictionary<int, AkCallbackManager.BankCallbackPackage> m_mapBankCallbacks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkCallbackManager.EventCallbackPackage m_LastAddedEventPackage;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IntPtr m_pNotifMem;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkCallbackManager.MonitoringCallback m_MonitoringCB;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkCallbackManager.BGMCallbackPackage ms_sourceChangeCallbackPkg;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool IsLoggingEnabled { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool get_IsLoggingEnabled()
    {
        null = null;
        return (bool)AkCallbackManager.<IsLoggingEnabled>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void set_IsLoggingEnabled(bool value)
    {
        null = null;
        AkCallbackManager.<IsLoggingEnabled>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemoveEventCallback(uint in_playingID)
    {
        var val_4;
        var val_5;
        var val_13;
        System.Collections.Generic.Dictionary<System.Int32, EventCallbackPackage> val_14;
        var val_15;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_13 = null;
        val_13 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = AkCallbackManager.m_mapEventCallbacks.GetEnumerator();
        val_14 = 1152921519390649728;
        label_6:
        if((1898926032 & 1) == 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_6 = val_5.trackableId;
        if(val_4 != in_playingID)
        {
            goto label_6;
        }
        
        val_1.Add(item:  val_6.m_SubId1.region);
        label_4:
        long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519390674896});
        int val_10 = val_1.Count;
        if(val_10 >= 1)
        {
                var val_13 = 0;
            do
        {
            val_15 = null;
            val_15 = null;
            val_14 = AkCallbackManager.m_mapEventCallbacks;
            bool val_12 = val_14.Remove(key:  val_1.Item[0]);
            val_13 = val_13 + 1;
        }
        while(val_10 != val_13);
        
        }
        
        AkSoundEnginePINVOKE.CSharp_CancelEventCallback(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemoveEventCallbackCookie(object in_cookie)
    {
        var val_4;
        var val_5;
        var val_14;
        System.Collections.Generic.Dictionary<System.Int32, EventCallbackPackage> val_15;
        System.Collections.Generic.Dictionary<System.Int32, EventCallbackPackage> val_16;
        var val_17;
        var val_18;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_14 = null;
        val_14 = null;
        val_15 = AkCallbackManager.m_mapEventCallbacks;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_15.GetEnumerator();
        val_16 = 1152921519390649728;
        val_17 = 1152921519390650752;
        label_8:
        if((1899066704 & 1) == 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_6 = val_5.trackableId;
        if(val_4 != in_cookie)
        {
            goto label_8;
        }
        
        val_1.Add(item:  val_6.m_SubId1.region);
        goto label_8;
        label_4:
        long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519390815568});
        int val_10 = val_1.Count;
        if(val_10 < 1)
        {
                return;
        }
        
        val_17 = 1152921518615434288;
        do
        {
            int val_11 = val_1.Item[0];
            val_18 = null;
            val_18 = null;
            val_16 = AkCallbackManager.m_mapEventCallbacks;
            bool val_12 = val_16.Remove(key:  val_11);
            AkSoundEnginePINVOKE.CSharp_CancelEventCallbackCookie(jarg1:  System.IntPtr.op_Explicit(value:  val_11));
            val_15 = 0 + 1;
        }
        while(val_10 != val_15);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemoveBankCallback(object in_cookie)
    {
        var val_5;
        var val_14;
        System.Collections.Generic.Dictionary<System.Int32, BankCallbackPackage> val_15;
        System.Collections.Generic.Dictionary<System.Int32, BankCallbackPackage> val_16;
        var val_17;
        var val_18;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_14 = null;
        val_14 = null;
        val_15 = AkCallbackManager.m_mapBankCallbacks;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_15.GetEnumerator();
        val_16 = 1152921519390942336;
        val_17 = 1152921519390943360;
        label_8:
        if((1899218640 & 1) == 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_6 = val_5.trackableId;
        if(val_5 != in_cookie)
        {
            goto label_8;
        }
        
        val_1.Add(item:  val_6.m_SubId1.region);
        goto label_8;
        label_4:
        long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519390967504});
        int val_10 = val_1.Count;
        if(val_10 < 1)
        {
                return;
        }
        
        val_17 = 1152921518615434288;
        do
        {
            int val_11 = val_1.Item[0];
            val_18 = null;
            val_18 = null;
            val_16 = AkCallbackManager.m_mapBankCallbacks;
            bool val_12 = val_16.Remove(key:  val_11);
            AkSoundEnginePINVOKE.CSharp_CancelBankCallbackCookie(jarg1:  System.IntPtr.op_Explicit(value:  val_11));
            val_15 = 0 + 1;
        }
        while(val_10 != val_15);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetLastAddedPlayingID(uint in_playingID)
    {
        var val_1;
        EventCallbackPackage val_2;
        var val_3;
        val_1 = null;
        val_1 = null;
        val_2 = AkCallbackManager.m_LastAddedEventPackage;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AkCallbackManager.m_LastAddedEventPackage;
        if(val_2 != null)
        {
                if(AkCallbackManager.m_LastAddedEventPackage.m_playingID != 0)
        {
                return;
        }
        
            val_3 = null;
            val_3 = null;
            AkCallbackManager.m_LastAddedEventPackage.m_playingID = in_playingID;
            return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT Init(AkCallbackManager.InitializationSettings settings)
    {
        IntPtr val_3;
        var val_4;
        AkCallbackManager.IsLoggingEnabled = (settings.IsLoggingEnabled == true) ? 1 : 0;
        if(settings.BufferSize >= 1)
        {
                val_3 = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  settings.BufferSize);
        }
        else
        {
                val_3 = 0;
        }
        
        val_4 = null;
        val_4 = null;
        AkCallbackManager.m_pNotifMem = val_3;
        return AkCallbackSerializer.Init(in_pMemory:  AkCallbackManager.m_pNotifMem, in_uSize:  settings.BufferSize);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Term()
    {
        IntPtr val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((System.IntPtr.op_Inequality(value1:  AkCallbackManager.m_pNotifMem, value2:  0)) == false)
        {
                return;
        }
        
        AkCallbackSerializer.Term();
        val_4 = null;
        val_4 = null;
        val_2 = AkCallbackManager.m_pNotifMem;
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  val_2);
        AkCallbackManager.m_pNotifMem = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, AkCallbackManager.MonitoringCallback in_CB)
    {
        var val_2;
        AkCallbackSerializer.SetLocalOutput(in_uErrorLevel:  (in_CB == 0) ? 0 : in_Level);
        val_2 = null;
        val_2 = null;
        AkCallbackManager.m_MonitoringCB = in_CB;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetBGMCallback(AkCallbackManager.BGMCallback in_CB, object in_cookie)
    {
        var val_2;
        AkCallbackManager.BGMCallbackPackage val_1 = new AkCallbackManager.BGMCallbackPackage();
        if(val_1 != null)
        {
                .m_Callback = in_CB;
        }
        else
        {
                mem[16] = in_CB;
        }
        
        .m_Cookie = in_cookie;
        val_2 = null;
        val_2 = null;
        AkCallbackManager.ms_sourceChangeCallbackPkg = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int PostCallbacks()
    {
        var val_35;
        IntPtr val_36;
        var val_37;
        IntPtr val_38;
        AkCallbackManager.BGMCallback val_39;
        var val_40;
        BGMCallbackPackage val_41;
        var val_42;
        object val_44;
        var val_45;
        IntPtr val_46;
        var val_47;
        AkCallbackInfo val_48;
        var val_49;
        IntPtr val_50;
        var val_51;
        var val_52;
        uint val_53;
        var val_54;
        var val_56;
        var val_57;
        var val_60;
        var val_61;
        val_35 = null;
        val_35 = null;
        if((System.IntPtr.op_Equality(value1:  AkCallbackManager.m_pNotifMem, value2:  0)) == true)
        {
            goto label_3;
        }
        
        val_36 = AkCallbackSerializer.Lock();
        val_37 = 0;
        goto label_107;
        label_125:
        val_38 = AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_pPackage_get(jarg1:  val_36);
        int val_4 = AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_eType_get(jarg1:  val_36);
        val_39 = AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_GetData(jarg1:  val_36);
        if(val_4 <= 570425344)
        {
            goto label_7;
        }
        
        if(val_4 == 1073741824)
        {
            goto label_8;
        }
        
        if(val_4 != 587202560)
        {
            goto label_9;
        }
        
        val_40 = null;
        val_40 = null;
        val_41 = AkCallbackManager.ms_sourceChangeCallbackPkg;
        if(val_41 == null)
        {
            goto label_93;
        }
        
        val_41 = AkCallbackManager.ms_sourceChangeCallbackPkg;
        if(val_41 == null)
        {
                val_41 = 0;
        }
        
        if(11993091 == 0)
        {
            goto label_93;
        }
        
        val_42 = null;
        val_42 = null;
        val_39 = mem[AkCallbackManager.ms_sourceChangeCallbackPkg + 16];
        val_39 = AkCallbackManager.ms_sourceChangeCallbackPkg.m_Callback;
        val_44 = mem[AkCallbackManager.ms_sourceChangeCallbackPkg + 24];
        val_44 = AkCallbackManager.ms_sourceChangeCallbackPkg.m_Cookie;
        AKRESULT val_8 = Invoke(in_bOtherAudioPlaying:  AkCallbackManager.AkAudioSourceChangeCallbackInfo.bOtherAudioPlaying, in_Cookie:  val_44);
        goto label_93;
        label_7:
        if(val_4 == 536870912)
        {
            goto label_25;
        }
        
        if(val_4 == 570425344)
        {
            goto label_93;
        }
        
        label_9:
        val_45 = null;
        EventCallbackPackage val_10 = 0;
        val_45 = null;
        val_46 = val_38;
        val_44 = System.IntPtr.op_Explicit(value:  val_46);
        if((AkCallbackManager.m_mapEventCallbacks.TryGetValue(key:  val_44, value: out  val_10)) == false)
        {
            goto label_30;
        }
        
        if(val_4 <= 512)
        {
            goto label_31;
        }
        
        if(val_4 <= 4096)
        {
            goto label_32;
        }
        
        if((val_4 == 8192) || (val_4 == 16384))
        {
            goto label_79;
        }
        
        if(val_4 != 65536)
        {
            goto label_108;
        }
        
        val_47 = null;
        val_47 = null;
        val_44 = AkCallbackManager.AkMIDIEventCallbackInfo;
        val_48 = 1152921505083260952;
        goto label_124;
        label_8:
        val_49 = null;
        BankCallbackPackage val_13 = 0;
        val_49 = null;
        val_50 = val_38;
        val_44 = System.IntPtr.op_Explicit(value:  val_50);
        if((AkCallbackManager.m_mapBankCallbacks.TryGetValue(key:  val_44, value: out  val_13)) == false)
        {
            goto label_43;
        }
        
        val_51 = null;
        val_51 = null;
        val_44 = System.IntPtr.op_Explicit(value:  val_38);
        bool val_16 = AkCallbackManager.m_mapBankCallbacks.Remove(key:  val_44);
        if((val_13 == 0) || (11993091 == 0))
        {
            goto label_93;
        }
        
        val_52 = null;
        val_52 = null;
        val_39 = 11993091;
        val_44 = AkCallbackManager.AkBankCallbackInfo.inMemoryBankPtr;
        val_53 = AkCallbackManager.AkBankCallbackInfo.memPoolId;
        val_39.Invoke(in_bankID:  AkCallbackManager.AkBankCallbackInfo.bankID, in_InMemoryBankPtr:  val_44, in_eLoadResult:  AkCallbackManager.AkBankCallbackInfo.loadResult, in_memPoolId:  val_53, in_Cookie:  15026800);
        goto label_93;
        label_25:
        val_54 = null;
        val_54 = null;
        if(AkCallbackManager.m_MonitoringCB == null)
        {
            goto label_93;
        }
        
        val_39 = AkCallbackManager.m_MonitoringCB;
        val_44 = AkCallbackManager.AkMonitoringCallbackInfo.errorLevel;
        val_53 = AkCallbackManager.AkMonitoringCallbackInfo.gameObjID;
        val_39.Invoke(in_errorCode:  AkCallbackManager.AkMonitoringCallbackInfo.errorCode, in_errorLevel:  val_44, in_playingID:  AkCallbackManager.AkMonitoringCallbackInfo.playingID, in_gameObjID:  val_53, in_msg:  AkCallbackManager.AkMonitoringCallbackInfo.message);
        goto label_93;
        label_31:
        if(val_4 <= 64)
        {
            goto label_73;
        }
        
        if(val_4 == 128)
        {
            goto label_74;
        }
        
        if((val_4 == 256) || (val_4 == 512))
        {
            goto label_79;
        }
        
        goto label_108;
        label_32:
        if((val_4 != 1024) && (val_4 != 2048))
        {
                if(val_4 != 4096)
        {
            goto label_108;
        }
        
        }
        
        label_79:
        val_56 = null;
        val_56 = null;
        val_44 = AkCallbackManager.AkMusicSyncCallbackInfo;
        val_48 = 1152921505083260976;
        label_124:
        if(val_48 == null)
        {
            goto label_93;
        }
        
        val_57 = val_10;
        if(val_57 == 0)
        {
            goto label_85;
        }
        
        val_44 = 15026800;
        goto label_99;
        label_73:
        if((val_4 - 1) > 7)
        {
            goto label_87;
        }
        
        var val_35 = 52956544 + ((val_4 - 1)) << 2;
        val_35 = val_35 + 52956544;
        goto (52956544 + ((val_4 - 1)) << 2 + 52956544);
        label_85:
        val_44 = 15026800;
        if(val_10 == 0)
        {
            goto label_98;
        }
        
        val_57 = val_10;
        goto label_99;
        label_74:
        val_60 = null;
        val_60 = null;
        goto label_124;
        label_98:
        val_57 = 0;
        label_99:
        val_44.Invoke(in_cookie:  64, in_type:  val_4, in_info:  val_48);
        label_93:
        val_36 = AkSoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_pNext_get(jarg1:  val_36);
        val_37 = 1;
        goto label_107;
        label_87:
        if(val_4 != 64)
        {
            goto label_108;
        }
        
        val_61 = null;
        val_61 = null;
        if(AkCallbackManager.AkMusicPlaylistCallbackInfo != null)
        {
            goto label_124;
        }
        
        goto label_124;
        label_107:
        if((System.IntPtr.op_Inequality(value1:  val_36, value2:  0)) == true)
        {
            goto label_125;
        }
        
        goto label_132;
        label_108:
        UnityEngine.Debug.LogError(message:  "WwiseUnity: PostCallbacks aborted due to error: Undefined callback type <"("WwiseUnity: PostCallbacks aborted due to error: Undefined callback type <") + val_4 + "> found. Callback object possibly corrupted."("> found. Callback object possibly corrupted."));
        goto label_132;
        label_30:
        UnityEngine.Debug.LogError(message:  "WwiseUnity: EventCallbackPackage not found for <"("WwiseUnity: EventCallbackPackage not found for <") + val_38.ToString() + ">."(">."));
        goto label_132;
        label_43:
        UnityEngine.Debug.LogError(message:  "WwiseUnity: BankCallbackPackage not found for <"("WwiseUnity: BankCallbackPackage not found for <") + val_38.ToString() + ">."(">."));
        label_132:
        AkCallbackSerializer.Unlock();
        return (int)val_37;
        label_3:
        val_37 = 0;
        return (int)val_37;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkCallbackManager()
    {
        AkCallbackManager.AkEventCallbackInfo = new AkEventCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        AkCallbackManager.AkDynamicSequenceItemCallbackInfo = new AkDynamicSequenceItemCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        AkCallbackManager.AkMIDIEventCallbackInfo = new AkMIDIEventCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        AkCallbackManager.AkMarkerCallbackInfo = new AkMarkerCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        AkCallbackManager.AkDurationCallbackInfo = new AkDurationCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        AkCallbackManager.AkMusicSyncCallbackInfo = new AkMusicSyncCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        AkCallbackManager.AkMusicPlaylistCallbackInfo = new AkMusicPlaylistCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        .swigCMemOwn = false;
        .swigCPtr = 0;
        AkCallbackManager.AkAudioSourceChangeCallbackInfo = new AkAudioSourceChangeCallbackInfo();
        AkCallbackManager.AkMonitoringCallbackInfo = new AkMonitoringCallbackInfo(cPtr:  0, cMemoryOwn:  false);
        .swigCMemOwn = false;
        .swigCPtr = 0;
        AkCallbackManager.AkBankCallbackInfo = new AkBankCallbackInfo();
        AkCallbackManager.m_mapEventCallbacks = new System.Collections.Generic.Dictionary<System.Int32, EventCallbackPackage>();
        AkCallbackManager.m_mapBankCallbacks = new System.Collections.Generic.Dictionary<System.Int32, BankCallbackPackage>();
        AkCallbackManager.m_pNotifMem = 0;
    }

}
