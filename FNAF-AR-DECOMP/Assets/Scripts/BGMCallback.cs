using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AkCallbackManager.BGMCallback : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackManager.BGMCallback(object object, IntPtr method)
    {
        mem[1152921519394424080] = object;
        mem[1152921519394424088] = method;
        mem[1152921519394424064] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AKRESULT Invoke(bool in_bOtherAudioPlaying, object in_Cookie)
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        if((X25 + 24) == 0)
        {
            goto label_10;
        }
        
        val_16 = 0;
        var val_22 = 0;
        goto label_42;
        label_0:
        if((X23 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X23 + 72) == 1)
        {
            goto label_44;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_44;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_44;
        }
        
        if(X22 == 0)
        {
            goto label_9;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
            goto label_10;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X23.serverGameUIDataModel;
        if((X23 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_28 = X22;
        if((X22 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_12 = X22 + 176;
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_15:
        if(((X22 + 176 + 8) + -8) == (X23 + 24))
        {
            goto label_14;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < (X22 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_14 = X22 + 176;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_20:
        if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_19;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (X22 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_35:
        var val_16 = X22;
        val_16 = val_16 + ((X23 + 72) << 4);
        val_20 = mem[(X22 + (X23 + 72) << 4) + 304];
        val_20 = (X22 + (X23 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_17 = X22;
        bool val_3 = in_bOtherAudioPlaying;
        val_21 = X22;
        val_17 = val_17 + (X23 + 72);
        goto label_41;
        label_37:
        var val_18 = val_12;
        val_18 = val_18 + in_Cookie;
        val_17 = val_17 + val_18;
        object val_4 = val_17 + 296;
        label_39:
        label_22:
        bool val_5 = in_bOtherAudioPlaying;
        val_21 = X22;
        goto label_41;
        label_19:
        var val_19 = val_14;
        val_19 = val_19 + (X23 + 72);
        val_19 = X22 + val_19;
        val_19 = val_19 + 296;
        label_21:
        bool val_6 = in_bOtherAudioPlaying;
        val_21 = X22;
        goto label_41;
        label_42:
        var val_7 = X25 + 0;
        val_17 = mem[(X25 + 0) + 32 + 32 + 8];
        val_17 = (X25 + 0) + 32 + 32 + 8;
        if((val_17 & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) == 0)
        {
            goto label_32;
        }
        
        if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_33;
        }
        
        if((val_17 & 1) == 0)
        {
            goto label_34;
        }
        
        if((val_17.serverGameUIDataModel & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X25 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_20 = (X25 + 0) + 32 + 32 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_38:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
        {
            goto label_40;
        }
        
        label_32:
        val_21 = in_bOtherAudioPlaying;
        goto label_41;
        label_40:
        in_bOtherAudioPlaying = in_bOtherAudioPlaying;
        val_21 = (X25 + 0) + 32 + 32;
        label_41:
        val_16 = val_21;
        label_33:
        val_22 = val_22 + 1;
        if(val_22 != (X25 + 24))
        {
            goto label_42;
        }
        
        return (AKRESULT)val_16;
        label_10:
        val_16 = 0;
        return (AKRESULT)val_16;
        label_4:
        if((X23 + 74) != 2)
        {
            goto label_44;
        }
        
        label_9:
        bool val_9 = in_bOtherAudioPlaying;
        label_44:
        in_bOtherAudioPlaying = in_bOtherAudioPlaying;
        label_53:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_45;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_49;
        }
        
        var val_23 = X22 + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_48:
        if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
        {
            goto label_47;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (X22 + 286))
        {
            goto label_48;
        }
        
        goto label_49;
        label_12:
        var val_25 = X22;
        val_25 = val_25 + ((X23 + 72) << 4);
        val_23 = mem[(X22 + (X23 + 72) << 4) + 304];
        val_23 = (X22 + (X23 + 72) << 4) + 304;
        goto label_50;
        label_45:
        var val_26 = X22;
        val_26 = val_26 + (X23 + 72);
        goto label_51;
        label_14:
        var val_27 = val_12;
        val_27 = val_27 + (X23 + 72);
        val_28 = val_28 + val_27;
        val_18 = val_28 + 296;
        label_16:
        val_23 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8];
        val_23 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8;
        label_50:
        bool val_11 = in_bOtherAudioPlaying;
        goto label_53;
        label_47:
        var val_29 = val_23;
        val_29 = val_29 + (X23 + 72);
        val_29 = X22 + val_29;
        val_22 = val_29 + 296;
        label_49:
        label_51:
        in_bOtherAudioPlaying = in_bOtherAudioPlaying;
        goto label_53;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(bool in_bOtherAudioPlaying, object in_Cookie, System.AsyncCallback callback, object object)
    {
        bool val_1 = in_bOtherAudioPlaying;
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AKRESULT EndInvoke(System.IAsyncResult result)
    {
        return (AKRESULT)UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = result});
    }

}
