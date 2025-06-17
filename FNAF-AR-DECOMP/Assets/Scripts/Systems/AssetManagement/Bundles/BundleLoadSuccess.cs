using UnityEngine;

namespace Systems.AssetManagement.Bundles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class BundleLoadSuccess : MulticastDelegate
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleLoadSuccess(object object, IntPtr method)
        {
            mem[1152921523417309424] = object;
            mem[1152921523417309432] = method;
            mem[1152921523417309408] = method;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Invoke(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle)
        {
            uint val_3;
            string val_4;
            var val_13;
            var val_14;
            uint val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            uint val_20;
            if(X25 == 0)
            {
                goto label_0;
            }
            
            if((X25 + 24) == 0)
            {
                    return;
            }
            
            var val_17 = 0;
            goto label_30;
            label_21:
            if((1630725744 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X22 + 286) == 0)
            {
                goto label_28;
            }
            
            var val_9 = X22 + 176;
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_7:
            if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
            {
                goto label_6;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (X22 + 286))
            {
                goto label_7;
            }
            
            goto label_28;
            label_22:
            var val_11 = X22;
            val_11 = val_11 + ((X23 + 72) << 4);
            val_14 = mem[(X22 + (X23 + 72) << 4) + 304];
            val_14 = (X22 + (X23 + 72) << 4) + 304;
            val_15 = info.m_Hash.m_u32_2;
            goto label_28;
            label_4:
            var val_12 = X22;
            val_12 = val_12 + (X23 + 72);
            goto label_28;
            label_24:
            var val_13 = X11;
            val_13 = val_13 + bundle;
            val_12 = val_12 + val_13;
            UnityEngine.AssetBundle val_2 = val_12 + 296;
            label_26:
            val_15 = val_3;
            goto label_28;
            label_6:
            var val_14 = val_9;
            val_14 = val_14 + (X23 + 72);
            val_14 = X22 + val_14;
            val_13 = val_14 + 296;
            goto label_28;
            label_30:
            var val_5 = X25 + 0;
            val_16 = mem[(X25 + 0) + 32 + 32 + 8];
            val_16 = (X25 + 0) + 32 + 32 + 8;
            if((val_16 & 1) == 0)
            {
                goto label_14;
            }
            
            if(((X25 + 0) + 32 + 32 + 8 + 72) == 1)
            {
                goto label_29;
            }
            
            if(((X25 + 0) + 32 + 32) != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_29;
            }
            
            }
            
            if(((X25 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_29;
            }
            
            if((((X25 + 0) + 32 + 32) == 0) || ((((X25 + 0) + 32 + 32 + 265) & 1) != 0))
            {
                goto label_28;
            }
            
            if((val_16 & 1) == 0)
            {
                goto label_21;
            }
            
            if((val_16.serverGameUIDataModel & 1) == 0)
            {
                goto label_22;
            }
            
            val_3 = info.m_Hash.m_u32_2;
            val_4 = info.m_Name;
            if(((X25 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_26;
            }
            
            var val_15 = (X25 + 0) + 32 + 32 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_25:
            if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_24;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < ((X25 + 0) + 32 + 32 + 286))
            {
                goto label_25;
            }
            
            goto label_26;
            label_14:
            if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
            {
                goto label_27;
            }
            
            goto label_28;
            label_27:
            label_29:
            label_28:
            val_17 = val_17 + 1;
            if(val_17 != (X25 + 24))
            {
                goto label_30;
            }
            
            return;
            label_0:
            if((X23 & 1) == 0)
            {
                goto label_33;
            }
            
            if((X23 + 72) == 1)
            {
                goto label_37;
            }
            
            if(X22 != 0)
            {
                    if(((X22 + 265) & 1) != 0)
            {
                goto label_37;
            }
            
            }
            
            if((X22 + 265) == 0)
            {
                goto label_37;
            }
            
            if(X22 == 0)
            {
                    return;
            }
            
            if(((X22 + 265) & 1) != 0)
            {
                    return;
            }
            
            GameUI.ServerGameUIDataModel val_7 = X23.serverGameUIDataModel;
            if((X23 & 1) == 0)
            {
                goto label_40;
            }
            
            if((val_7 & 1) == 0)
            {
                goto label_41;
            }
            
            var val_25 = X22;
            if((X22 + 286) == 0)
            {
                goto label_45;
            }
            
            var val_18 = X22 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_44:
            if(((X22 + 176 + 8) + -8) == (X23 + 24))
            {
                goto label_43;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X22 + 286))
            {
                goto label_44;
            }
            
            goto label_45;
            label_33:
            if((X23 + 74) != 2)
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
            
            if((X22 + 286) == 0)
            {
                    return;
            }
            
            var val_20 = X22 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_53:
            if(((X22 + 176 + 8) + -8) == X23.serverGameUIDataModel)
            {
                goto label_52;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (X22 + 286))
            {
                goto label_53;
            }
            
            return;
            label_41:
            var val_22 = X22;
            val_22 = val_22 + ((X23 + 72) << 4);
            val_19 = mem[(X22 + (X23 + 72) << 4) + 304];
            val_19 = (X22 + (X23 + 72) << 4) + 304;
            val_20 = info.m_Hash.m_u32_2;
            return;
            label_50:
            var val_23 = X22;
            val_23 = val_23 + (X23 + 72);
            return;
            label_43:
            var val_24 = val_18;
            val_24 = val_24 + (X23 + 72);
            val_25 = val_25 + val_24;
            val_17 = val_25 + 296;
            label_45:
            val_19 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8];
            val_19 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8;
            val_20 = info.m_Hash.m_u32_2;
            return;
            label_52:
            var val_26 = val_20;
            val_26 = val_26 + (X23 + 72);
            val_26 = X22 + val_26;
            val_18 = val_26 + 296;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
