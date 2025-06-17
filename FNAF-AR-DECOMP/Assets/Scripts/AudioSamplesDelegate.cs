using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AkAudioInputManager.AudioSamplesDelegate : MulticastDelegate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAudioInputManager.AudioSamplesDelegate(object object, IntPtr method)
    {
        mem[1152921519385131920] = object;
        mem[1152921519385131928] = method;
        mem[1152921519385131904] = method;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool Invoke(uint playingID, uint channelIndex, float[] samples)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if(X26 == 0)
        {
            goto label_0;
        }
        
        if((X26 + 24) == 0)
        {
            goto label_1;
        }
        
        val_11 = 0;
        var val_18 = 0;
        goto label_42;
        label_0:
        if((X24 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 72) == 1)
        {
                return (bool)val_11 & 1;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
                return (bool)val_11 & 1;
        }
        
        }
        
        if((X23 + 265) == 0)
        {
                return (bool)val_11 & 1;
        }
        
        if(X23 == 0)
        {
                return (bool)val_11 & 1;
        }
        
        if(((X23 + 265) & 1) != 0)
        {
                return (bool)val_11 & 1;
        }
        
        GameUI.ServerGameUIDataModel val_1 = X24.serverGameUIDataModel;
        if((X24 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_24 = X23;
        if((X23 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_8 = X23 + 176;
        var val_9 = 0;
        val_8 = val_8 + 8;
        label_15:
        if(((X23 + 176 + 8) + -8) == (X24 + 24))
        {
            goto label_14;
        }
        
        val_9 = val_9 + 1;
        val_8 = val_8 + 16;
        if(val_9 < (X23 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X24 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X23 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_10 = X23 + 176;
        var val_11 = 0;
        val_10 = val_10 + 8;
        label_20:
        if(((X23 + 176 + 8) + -8) == X24.serverGameUIDataModel)
        {
            goto label_19;
        }
        
        val_11 = val_11 + 1;
        val_10 = val_10 + 16;
        if(val_11 < (X23 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_35:
        var val_12 = X23;
        val_12 = val_12 + ((X24 + 72) << 4);
        val_14 = mem[(X23 + (X24 + 72) << 4) + 304];
        val_14 = (X23 + (X24 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_13 = X23;
        val_15 = X23;
        val_13 = val_13 + (X24 + 72);
        goto label_41;
        label_37:
        var val_14 = val_8;
        val_14 = val_14 + channelIndex;
        val_13 = val_13 + val_14;
        uint val_3 = val_13 + 296;
        label_39:
        val_14 = mem[(((X23 + X24 + 72) + (((X23 + 176 + 8) + 16) + channelIndex)) + 296) + 8];
        val_14 = (((X23 + X24 + 72) + (((X23 + 176 + 8) + 16) + channelIndex)) + 296) + 8;
        label_22:
        val_15 = X23;
        goto label_41;
        label_19:
        var val_15 = val_10;
        val_15 = val_15 + (X24 + 72);
        val_15 = X23 + val_15;
        val_13 = val_15 + 296;
        label_21:
        val_15 = X23;
        goto label_41;
        label_42:
        var val_4 = X26 + 0;
        if((((X26 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X26 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X26 + 0) + 32 + 32) != 0)
        {
                if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(mem[1152921519385301256] == 0)
        {
            goto label_40;
        }
        
        if(((X26 + 0) + 32 + 32) == 0)
        {
            goto label_32;
        }
        
        if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_33;
        }
        
        if((((X26 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_34;
        }
        
        if((((X26 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X26 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_16 = (X26 + 0) + 32 + 32 + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_38:
        if((((X26 + 0) + 32 + 32 + 176 + 8) + -8) == ((X26 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < ((X26 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X26 + 0) + 32 + 32 + 8 + 74) != 3)
        {
            goto label_40;
        }
        
        label_32:
        val_15 = playingID;
        goto label_41;
        label_40:
        val_15 = (X26 + 0) + 32 + 32;
        label_41:
        val_11 = val_15 & 1;
        label_33:
        val_18 = val_18 + 1;
        if(val_18 != (X26 + 24))
        {
            goto label_42;
        }
        
        return (bool)val_11 & 1;
        label_1:
        val_11 = 0;
        return (bool)val_11 & 1;
        label_4:
        if((X24 + 74) != 3)
        {
                return (bool)val_11 & 1;
        }
        
        return (bool)val_11 & 1;
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_46;
        }
        
        if((X23 + 286) == 0)
        {
                return (bool)val_11 & 1;
        }
        
        var val_19 = X23 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_49:
        if(((X23 + 176 + 8) + -8) == X24.serverGameUIDataModel)
        {
            goto label_48;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X23 + 286))
        {
            goto label_49;
        }
        
        return (bool)val_11 & 1;
        label_12:
        var val_21 = X23;
        val_21 = val_21 + ((X24 + 72) << 4);
        val_17 = mem[(X23 + (X24 + 72) << 4) + 304];
        val_17 = (X23 + (X24 + 72) << 4) + 304;
        return (bool)val_11 & 1;
        label_46:
        var val_22 = X23;
        val_22 = val_22 + (X24 + 72);
        return (bool)val_11 & 1;
        label_14:
        var val_23 = val_8;
        val_23 = val_23 + (X24 + 72);
        val_24 = val_24 + val_23;
        val_12 = val_24 + 296;
        label_16:
        val_17 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X24 + 24), slot: 0) + 8];
        val_17 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X24 + 24), slot: 0) + 8;
        return (bool)val_11 & 1;
        label_48:
        var val_25 = val_19;
        val_25 = val_25 + (X24 + 72);
        val_25 = X23 + val_25;
        val_16 = val_25 + 296;
        return (bool)val_11 & 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual System.IAsyncResult BeginInvoke(uint playingID, uint channelIndex, float[] samples, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual bool EndInvoke(System.IAsyncResult result)
    {
        return (bool)UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = result});
    }

}
