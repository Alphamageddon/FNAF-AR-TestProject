using UnityEngine;

namespace Systems.AssetManagement.Bundles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class BundleLoadFailure : MulticastDelegate
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleLoadFailure(object object, IntPtr method)
        {
            mem[1152921523417880208] = object;
            mem[1152921523417880216] = method;
            mem[1152921523417880192] = method;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Invoke(UnityEngine.CachedAssetBundle info)
        {
            uint val_3;
            string val_4;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            uint val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            uint val_22;
            val_13 = 1152921523418052800;
            if(X24 == 0)
            {
                goto label_0;
            }
            
            if((X24 + 24) == 0)
            {
                    return;
            }
            
            var val_17 = 0;
            goto label_30;
            label_21:
            val_14 = mem[X22 + 72];
            val_14 = X22 + 72;
            if((1631292416 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X21 + 286) == 0)
            {
                goto label_28;
            }
            
            var val_9 = X21 + 176;
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_7:
            if(((X21 + 176 + 8) + -8) == X22.serverGameUIDataModel)
            {
                goto label_6;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (X21 + 286))
            {
                goto label_7;
            }
            
            goto label_28;
            label_22:
            var val_11 = X21;
            val_11 = val_11 + ((X22 + 72) << 4);
            val_16 = mem[(X21 + (X22 + 72) << 4) + 304];
            val_16 = (X21 + (X22 + 72) << 4) + 304;
            val_17 = info.m_Hash.m_u32_2;
            goto label_28;
            label_4:
            var val_12 = X21;
            val_12 = val_12 + val_14;
            goto label_28;
            label_24:
            var val_13 = X11;
            val_13 = val_13 + ((X21 + X22 + 72) + 304);
            val_12 = val_12 + val_13;
            var val_2 = val_12 + 296;
            label_26:
            val_16 = mem[(((X21 + X22 + 72) + (X11 + (X21 + X22 + 72) + 304)) + 296) + 8];
            val_16 = (((X21 + X22 + 72) + (X11 + (X21 + X22 + 72) + 304)) + 296) + 8;
            val_17 = val_3;
            goto label_28;
            label_6:
            var val_14 = val_9;
            val_14 = val_14 + val_14;
            val_14 = X21 + val_14;
            val_15 = val_14 + 296;
            goto label_28;
            label_30:
            var val_5 = X24 + 0;
            val_18 = mem[(X24 + 0) + 32 + 32];
            val_18 = (X24 + 0) + 32 + 32;
            val_14 = mem[(X24 + 0) + 32 + 16];
            val_14 = (X24 + 0) + 32 + 16;
            if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_14;
            }
            
            if(((X24 + 0) + 32 + 32 + 8 + 72) == 1)
            {
                goto label_29;
            }
            
            if(val_18 != 0)
            {
                    if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_29;
            }
            
            }
            
            if(((X24 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_29;
            }
            
            if((val_18 == 0) || ((((X24 + 0) + 32 + 32 + 265) & 1) != 0))
            {
                goto label_28;
            }
            
            if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_21;
            }
            
            if((((X24 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
            {
                goto label_22;
            }
            
            val_3 = info.m_Hash.m_u32_2;
            val_4 = info.m_Name;
            if(((X24 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_26;
            }
            
            var val_15 = (X24 + 0) + 32 + 32 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_25:
            if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_24;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < ((X24 + 0) + 32 + 32 + 286))
            {
                goto label_25;
            }
            
            goto label_26;
            label_14:
            if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
            {
                goto label_27;
            }
            
            goto label_28;
            label_27:
            label_29:
            label_28:
            val_17 = val_17 + 1;
            if(val_17 != (X24 + 24))
            {
                goto label_30;
            }
            
            return;
            label_0:
            if((X22 & 1) == 0)
            {
                goto label_33;
            }
            
            if((X22 + 72) == 1)
            {
                goto label_37;
            }
            
            if(X21 != 0)
            {
                    if(((X21 + 265) & 1) != 0)
            {
                goto label_37;
            }
            
            }
            
            if((X21 + 265) == 0)
            {
                goto label_37;
            }
            
            if(X21 == 0)
            {
                    return;
            }
            
            if(((X21 + 265) & 1) != 0)
            {
                    return;
            }
            
            GameUI.ServerGameUIDataModel val_7 = X22.serverGameUIDataModel;
            if((X22 & 1) == 0)
            {
                goto label_40;
            }
            
            if((val_7 & 1) == 0)
            {
                goto label_41;
            }
            
            var val_25 = X21;
            if((X21 + 286) == 0)
            {
                goto label_45;
            }
            
            var val_18 = X21 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_44:
            if(((X21 + 176 + 8) + -8) == (X22 + 24))
            {
                goto label_43;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X21 + 286))
            {
                goto label_44;
            }
            
            goto label_45;
            label_33:
            if((X22 + 74) != 1)
            {
                    return;
            }
            
            return;
            label_37:
            return;
            label_40:
            if((val_7 & 1) == 0)
            {
                goto label_50;
            }
            
            if((X21 + 286) == 0)
            {
                    return;
            }
            
            var val_20 = X21 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_53:
            if(((X21 + 176 + 8) + -8) == X22.serverGameUIDataModel)
            {
                goto label_52;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (X21 + 286))
            {
                goto label_53;
            }
            
            return;
            label_41:
            var val_22 = X21;
            val_22 = val_22 + ((X22 + 72) << 4);
            val_21 = mem[(X21 + (X22 + 72) << 4) + 304];
            val_21 = (X21 + (X22 + 72) << 4) + 304;
            val_22 = info.m_Hash.m_u32_2;
            return;
            label_50:
            var val_23 = X21;
            val_23 = val_23 + (X22 + 72);
            return;
            label_43:
            var val_24 = val_18;
            val_24 = val_24 + (X22 + 72);
            val_25 = val_25 + val_24;
            val_19 = val_25 + 296;
            label_45:
            val_21 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0) + 8];
            val_21 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0) + 8;
            val_22 = info.m_Hash.m_u32_2;
            return;
            label_52:
            var val_26 = val_20;
            val_26 = val_26 + (X22 + 72);
            val_26 = X21 + val_26;
            val_20 = val_26 + 296;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.CachedAssetBundle info, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
