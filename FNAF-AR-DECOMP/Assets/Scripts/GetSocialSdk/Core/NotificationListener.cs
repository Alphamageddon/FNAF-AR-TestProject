using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class NotificationListener : MulticastDelegate
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NotificationListener(object object, IntPtr method)
        {
            mem[1152921525989194080] = object;
            mem[1152921525989194088] = method;
            mem[1152921525989194064] = method;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool Invoke(GetSocialSdk.Core.Notification notification, bool wasClicked)
        {
            var val_34;
            var val_35;
            var val_36;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_44;
            var val_45;
            var val_46;
            if(X25 == 0)
            {
                goto label_0;
            }
            
            if((X25 + 24) == 0)
            {
                goto label_1;
            }
            
            val_34 = 0;
            var val_45 = 0;
            goto label_65;
            label_0:
            if((X22 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X22 + 74) != 2)
            {
                goto label_5;
            }
            
            if((X22 + 72) == 65535)
            {
                goto label_9;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                goto label_9;
            }
            
            }
            
            if((X23 + 265) == 0)
            {
                goto label_9;
            }
            
            if(X23 == 0)
            {
                goto label_71;
            }
            
            if(((X23 + 265) & 1) != 0)
            {
                    return (bool)val_34 & 1;
            }
            
            GameUI.ServerGameUIDataModel val_1 = X22.serverGameUIDataModel;
            if((X22 & 1) == 0)
            {
                goto label_12;
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_13;
            }
            
            var val_53 = X23;
            if((X23 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_31 = X23 + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_16:
            if(((X23 + 176 + 8) + -8) == (X22 + 24))
            {
                goto label_15;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (X23 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_59:
            val_36 = mem[X22 + 72];
            val_36 = X22 + 72;
            if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0)) & 1) == 0)
            {
                goto label_18;
            }
            
            GameUI.ServerGameUIDataModel val_2 = X22.serverGameUIDataModel;
            var val_33 = 0;
            val_33 = val_33 + 1;
            goto label_22;
            label_60:
            GetSocialSdk.Core.Notification val_3 = 1152921505326653440 + ((X22 + 72) << 4);
            val_38 = mem[(1152921505326653440 + (X22 + 72) << 4) + 304];
            goto label_23;
            label_18:
            bool val_4 = wasClicked;
            val_39 = notification;
            GetSocialSdk.Core.Notification val_5 = 1152921505326653440 + val_36;
            goto label_52;
            label_45:
            if((val_39 & 1) == 0)
            {
                goto label_25;
            }
            
            if((X22 + 72 + 286) == 0)
            {
                goto label_29;
            }
            
            var val_34 = X22 + 72 + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_28:
            if(((X22 + 72 + 176 + 8) + -8) == X22.serverGameUIDataModel)
            {
                goto label_27;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (X22 + 72 + 286))
            {
                goto label_28;
            }
            
            goto label_29;
            label_46:
            var val_36 = val_36;
            val_36 = val_36 + ((X22 + 72) << 4);
            val_41 = mem[(X22 + 72 + (X22 + 72) << 4) + 304];
            val_41 = (X22 + 72 + (X22 + 72) << 4) + 304;
            goto label_30;
            label_25:
            var val_37 = val_36;
            bool val_7 = wasClicked;
            val_39 = val_36;
            val_37 = val_37 + (X22 + 72);
            goto label_52;
            label_64:
            val_38 = mem[(((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (wasClicked & 1))) + 296) + 8];
            val_38 = (((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (wasClicked & 1))) + 296) + 8;
            label_23:
            bool val_9 = wasClicked;
            val_39 = notification;
            goto label_52;
            label_22:
            var val_40 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(val_2), slot: 0);
            bool val_11 = wasClicked;
            val_39 = notification;
            goto label_52;
            label_48:
            var val_39 = 1179403647;
            val_39 = val_39 + ((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(val_2), slot: 0) + 8);
            val_40 = val_40 + val_39;
            var val_12 = val_40 + 296;
            label_50:
            val_41 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(val_2), slot: 0)  + 8];
            val_41 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(val_2), slot: 0)  + 8;
            label_30:
            bool val_13 = wasClicked;
            val_39 = val_36;
            goto label_52;
            label_27:
            var val_41 = val_34;
            val_41 = val_41 + (X22 + 72);
            val_41 = val_36 + val_41;
            val_40 = val_41 + 296;
            label_29:
            bool val_14 = wasClicked;
            val_39 = val_36;
            goto label_52;
            label_65:
            var val_15 = X25 + 0;
            val_36 = mem[(X25 + 0) + 32 + 32];
            val_36 = (X25 + 0) + 32 + 32;
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_37;
            }
            
            if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
            {
                goto label_38;
            }
            
            if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_42;
            }
            
            if(val_36 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_42;
            }
            
            }
            
            if(((X25 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_42;
            }
            
            if(val_36 == 0)
            {
                goto label_56;
            }
            
            if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_45;
            }
            
            if((((X25 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
            {
                goto label_46;
            }
            
            if(((X25 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_50;
            }
            
            var val_42 = (X25 + 0) + 32 + 32 + 176;
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_49:
            if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_48;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < ((X25 + 0) + 32 + 32 + 286))
            {
                goto label_49;
            }
            
            goto label_50;
            label_37:
            if(((X25 + 0) + 32 + 32 + 8 + 74) == 2)
            {
                goto label_56;
            }
            
            label_42:
            wasClicked = wasClicked;
            val_39 = val_36;
            goto label_52;
            label_38:
            if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_56;
            }
            
            if(val_36 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_56;
            }
            
            }
            
            if(((X25 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_56;
            }
            
            if(val_36 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            }
            
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_59;
            }
            
            if((((X25 + 0) + 32 + 32 + 8.serverGameUIDataModel) & 1) == 0)
            {
                goto label_60;
            }
            
            var val_44 = 0;
            val_44 = val_44 + 1;
            goto label_64;
            label_56:
            bool val_18 = wasClicked;
            val_39 = notification;
            label_52:
            val_34 = val_39 & 1;
            label_58:
            val_45 = val_45 + 1;
            if(val_45 != (X25 + 24))
            {
                goto label_65;
            }
            
            return (bool)val_34 & 1;
            label_1:
            val_34 = 0;
            return (bool)val_34 & 1;
            label_4:
            if((X22 + 74) == 2)
            {
                goto label_71;
            }
            
            label_9:
            wasClicked = wasClicked;
            label_98:
            label_5:
            if((X22 + 72) == 65535)
            {
                goto label_71;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                goto label_71;
            }
            
            }
            
            if((X23 + 265) == 0)
            {
                goto label_71;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                    return (bool)val_34 & 1;
            }
            
            }
            
            GameUI.ServerGameUIDataModel val_20 = X22.serverGameUIDataModel;
            if((X22 & 1) == 0)
            {
                goto label_74;
            }
            
            if((val_20 & 1) == 0)
            {
                goto label_75;
            }
            
            var val_46 = 0;
            val_46 = val_46 + 1;
            goto label_79;
            label_71:
            bool val_21 = wasClicked;
            return (bool)val_34 & 1;
            label_74:
            if((val_20 & 1) == 0)
            {
                goto label_81;
            }
            
            GameUI.ServerGameUIDataModel val_22 = X22.serverGameUIDataModel;
            var val_47 = 0;
            val_47 = val_47 + 1;
            goto label_85;
            label_75:
            GetSocialSdk.Core.Notification val_23 = 1152921505326653440 + ((X22 + 72) << 4);
            val_44 = mem[(1152921505326653440 + (X22 + 72) << 4) + 304];
            goto label_86;
            label_81:
            GetSocialSdk.Core.Notification val_24 = 1152921505326653440 + (X22 + 72);
            goto label_87;
            label_12:
            if((val_1 & 1) == 0)
            {
                goto label_88;
            }
            
            if((X23 + 286) == 0)
            {
                goto label_92;
            }
            
            var val_48 = X23 + 176;
            var val_49 = 0;
            val_48 = val_48 + 8;
            label_91:
            if(((X23 + 176 + 8) + -8) == X22.serverGameUIDataModel)
            {
                goto label_90;
            }
            
            val_49 = val_49 + 1;
            val_48 = val_48 + 16;
            if(val_49 < (X23 + 286))
            {
                goto label_91;
            }
            
            goto label_92;
            label_13:
            var val_50 = X23;
            val_50 = val_50 + ((X22 + 72) << 4);
            val_46 = mem[(X23 + (X22 + 72) << 4) + 304];
            val_46 = (X23 + (X22 + 72) << 4) + 304;
            goto label_93;
            label_88:
            var val_51 = X23;
            val_51 = val_51 + (X22 + 72);
            goto label_94;
            label_79:
            val_44 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(X22 + 24), slot: 0) + 8];
            val_44 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(notification, typeof(X22 + 24), slot: 0) + 8;
            label_86:
            bool val_27 = wasClicked;
            return (bool)val_34 & 1;
            label_85:
            label_87:
            bool val_29 = wasClicked;
            return (bool)val_34 & 1;
            label_15:
            var val_52 = val_31;
            val_52 = val_52 + (X22 + 72);
            val_53 = val_53 + val_52;
            val_35 = val_53 + 296;
            label_17:
            val_46 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8];
            val_46 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8;
            label_93:
            bool val_30 = wasClicked;
            goto label_98;
            label_90:
            var val_54 = val_48;
            val_54 = val_54 + (X22 + 72);
            val_54 = X23 + val_54;
            val_45 = val_54 + 296;
            label_92:
            label_94:
            wasClicked = wasClicked;
            goto label_98;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual System.IAsyncResult BeginInvoke(GetSocialSdk.Core.Notification notification, bool wasClicked, System.AsyncCallback callback, object object)
        {
            bool val_1 = wasClicked;
            return (System.IAsyncResult)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool EndInvoke(System.IAsyncResult result)
        {
            return (bool)UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = result});
        }
    
    }

}
