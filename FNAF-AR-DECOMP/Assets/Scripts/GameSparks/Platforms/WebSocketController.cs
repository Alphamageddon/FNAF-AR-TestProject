using UnityEngine;

namespace GameSparks.Platforms
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WebSocketController : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <GSName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameSparks.Platforms.IControlledWebSocket> webSockets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool websocketCollectionModified;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GSName { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_GSName()
        {
            return (string)this.<GSName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_GSName(string value)
        {
            this.<GSName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.<GSName>k__BackingField = this.name;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddWebSocket(GameSparks.Platforms.IControlledWebSocket socket)
        {
            this.webSockets.Add(item:  socket);
            this.websocketCollectionModified = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveWebSocket(GameSparks.Platforms.IControlledWebSocket socket)
        {
            bool val_1 = this.webSockets.Remove(item:  socket);
            this.websocketCollectionModified = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Platforms.IControlledWebSocket GetSocket(int socketId)
        {
            var val_7;
            var val_8;
            val_7 = socketId;
            List.Enumerator<T> val_1 = this.webSockets.GetEnumerator();
            label_8:
            if(((-1700665144) & 1) == 0)
            {
                goto label_2;
            }
            
            val_8 = 0.emailUIDataHandler;
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(val_8.SocketId != val_7)
            {
                goto label_8;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520086051016});
            return (GameSparks.Platforms.IControlledWebSocket)val_8;
            label_2:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520086051016});
            val_8 = 0;
            return (GameSparks.Platforms.IControlledWebSocket)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GSSocketOnOpen(string data)
        {
            var val_11;
            var val_12;
            var val_14;
            var val_15;
            var val_17;
            val_11 = GameSparks.Core.GSJson.From(json:  data);
            if(val_11 == null)
            {
                goto label_1;
            }
            
            val_12 = null;
            if(val_11 == null)
            {
                goto label_2;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_14 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            bool val_3 = val_11.ContainsKey(key:  ???);
            var val_4 = (val_3 != true) ? (val_11) : 0;
            if(val_3 == false)
            {
                goto label_7;
            }
            
            var val_15 = val_4;
            if((val_3 != true ? val_1 : 0 + 286) == 0)
            {
                goto label_9;
            }
            
            var val_13 = val_3 != true ? val_1 : 0 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_11:
            if(((val_3 != true ? val_1 : 0 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (val_3 != true ? val_1 : 0 + 286))
            {
                goto label_11;
            }
            
            label_9:
            val_14 = 0;
            goto label_12;
            label_10:
            val_15 = val_15 + (((val_3 != true ? val_1 : 0 + 176 + 8)) << 4);
            val_15 = val_15 + 296;
            label_12:
            GameSparks.Platforms.IControlledWebSocket val_7 = this.GetSocket(socketId:  System.Convert.ToInt32(value:  val_4.Item[???]));
            if(val_7 == null)
            {
                    return;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_12 = ???;
            val_11 = ???;
            val_7.TriggerOnOpen();
            return;
            label_2:
            label_1:
            System.FormatException val_10 = null;
            val_17 = val_10;
            val_10 = new System.FormatException(message:  "parsed json was null. ");
            goto label_21;
            label_7:
            System.FormatException val_11 = null;
            val_17 = val_11;
            val_11 = new System.FormatException();
            label_21:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GSSocketOnClose(string data)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            object val_1 = GameSparks.Core.GSJson.From(json:  data);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                    val_7 = 0;
            }
            
            val_8 = null;
            val_9 = val_1;
            if(val_9 != null)
            {
                goto label_3;
            }
            
            val_7 = 0;
            goto label_4;
            label_1:
            val_8 = null;
            label_4:
            val_9 = 0;
            label_3:
            if(mem[282584257676957] == 0)
            {
                goto label_5;
            }
            
            var val_7 = mem[282584257676847];
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_7:
            if(((mem[282584257676847] + 8) + -8) == val_8)
            {
                goto label_6;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < mem[282584257676957])
            {
                goto label_7;
            }
            
            label_5:
            val_7 = 0;
            goto label_8;
            label_6:
            val_9 = val_9 + (((mem[282584257676847] + 8)) << 4);
            val_10 = val_9 + 296;
            label_8:
            GameSparks.Platforms.IControlledWebSocket val_5 = this.GetSocket(socketId:  System.Convert.ToInt32(value:  val_9.Item[null]));
            if(val_5 == null)
            {
                    return;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_5.TriggerOnClose();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GSSocketOnMessage(string data)
        {
            var val_8;
            var val_9;
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            object val_1 = GameSparks.Core.GSJson.From(json:  data);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_8 = val_1;
            if(val_8 == null)
            {
                goto label_2;
            }
            
            val_9 = 0;
            val_10 = val_8;
            goto label_3;
            label_2:
            val_11 = 0;
            label_1:
            val_8 = 0;
            val_10 = 0;
            val_9 = 1;
            label_3:
            if(mem[282584257676957] == 0)
            {
                goto label_4;
            }
            
            var val_8 = mem[282584257676847];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < mem[282584257676957])
            {
                goto label_6;
            }
            
            label_4:
            val_11 = 0;
            goto label_7;
            label_5:
            val_10 = val_10 + (((mem[282584257676847] + 8)) << 4);
            val_12 = val_10 + 296;
            label_7:
            val_13 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            GameSparks.Platforms.IControlledWebSocket val_5 = this.GetSocket(socketId:  System.Convert.ToInt32(value:  val_8.Item[null]));
            if(val_5 == null)
            {
                    return;
            }
            
            var val_12 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_12;
            }
            
            var val_10 = mem[282584257676847];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_14:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < mem[282584257676957])
            {
                goto label_14;
            }
            
            label_12:
            val_13 = 0;
            goto label_15;
            label_13:
            val_12 = val_12 + (((mem[282584257676847] + 8)) << 4);
            val_14 = val_12 + 296;
            label_15:
            val_15 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            val_10 = val_8.Item[null];
            if((val_10 != 0) && (val_10 != null))
            {
                    val_15 = 0;
                val_10 = 0;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = 3;
            val_5.TriggerOnMessage(message:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GSSocketOnError(string data)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            string val_16;
            object val_1 = GameSparks.Core.GSJson.From(json:  data);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_8 = val_1;
            if(val_8 == null)
            {
                goto label_2;
            }
            
            val_9 = 0;
            val_10 = val_8;
            goto label_3;
            label_2:
            val_11 = 0;
            label_1:
            val_8 = 0;
            val_10 = 0;
            val_9 = 1;
            label_3:
            if(mem[282584257676957] == 0)
            {
                goto label_4;
            }
            
            var val_8 = mem[282584257676847];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < mem[282584257676957])
            {
                goto label_6;
            }
            
            label_4:
            val_11 = 0;
            goto label_7;
            label_5:
            val_10 = val_10 + (((mem[282584257676847] + 8)) << 4);
            val_12 = val_10 + 296;
            label_7:
            val_13 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            var val_12 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_11;
            }
            
            var val_10 = mem[282584257676847];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_13:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < mem[282584257676957])
            {
                goto label_13;
            }
            
            label_11:
            val_13 = 0;
            goto label_14;
            label_12:
            val_12 = val_12 + (((mem[282584257676847] + 8)) << 4);
            val_14 = val_12 + 296;
            label_14:
            val_15 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            val_16 = val_8.Item[null];
            if((val_16 != 0) && (val_16 != null))
            {
                    val_15 = 0;
                val_16 = 0;
            }
            
            GameSparks.Platforms.IControlledWebSocket val_6 = this.GetSocket(socketId:  System.Convert.ToInt32(value:  val_8.Item[null]));
            if(val_6 == null)
            {
                    return;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = 2;
            val_6.TriggerOnError(message:  val_16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ServerToClient(string jsonData)
        {
            var val_15;
            var val_17;
            string val_18;
            var val_19;
            var val_21;
            string val_22;
            var val_23;
            var val_25;
            string val_28;
            var val_29;
            var val_30;
            var val_31;
            string val_32;
            var val_33;
            var val_37;
            object val_1 = GameSparks.Core.GSJson.From(json:  jsonData);
            var val_16 = 0;
            val_15 = 1152921504627703816;
            val_16 = val_16 + 1;
            val_15 = 1152921504627703832;
            val_17 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            val_18 = val_1.Item[???];
            val_19 = this.GetSocket(socketId:  System.Int32.Parse(s:  val_18));
            if(val_19 == null)
            {
                    return;
            }
            
            var val_17 = 0;
            val_15 = 1152921504627703816;
            val_17 = val_17 + 1;
            val_15 = 1152921504627703832;
            val_17 = 0;
            TValue val_7 = val_1.Item[???];
            val_21 = 0;
            val_22 = val_7;
            if((System.String.op_Equality(a:  val_7, b:  "onError")) == false)
            {
                goto label_14;
            }
            
            val_23 = "data";
            var val_18 = 0;
            val_15 = 1152921504627703816;
            val_18 = val_18 + 1;
            val_15 = 1152921504627703832;
            val_21 = 0;
            goto label_19;
            label_14:
            val_25 = 0;
            if((System.String.op_Equality(a:  val_22, b:  "onMessage")) == false)
            {
                goto label_20;
            }
            
            val_23 = "data";
            var val_19 = 0;
            val_15 = 1152921504627703816;
            val_19 = val_19 + 1;
            val_15 = 1152921504627703832;
            val_25 = 0;
            goto label_25;
            label_20:
            if((System.String.op_Equality(a:  val_22, b:  "onOpen")) == false)
            {
                goto label_26;
            }
            
            val_28 = null;
            var val_20 = 0;
            val_15 = 1152921505134784520;
            val_20 = val_20 + 1;
            val_29 = 1;
            val_30 = val_19;
            goto label_41;
            label_19:
            val_31 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            val_32 = val_1.Item[???];
            val_33 = null;
            var val_21 = 0;
            val_15 = 1152921505134784520;
            val_21 = val_21 + 1;
            val_15 = 1152921505134784536;
            val_31 = 2;
            goto label_46;
            label_26:
            if((System.String.op_Equality(a:  val_22, b:  "onClose")) == false)
            {
                    return;
            }
            
            val_28 = null;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_30 = val_19;
            val_29 = 0;
            goto label_41;
            label_25:
            val_31 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
            val_32 = val_1.Item[???];
            val_33 = null;
            var val_23 = 0;
            val_15 = 1152921505134784520;
            val_23 = val_23 + 1;
            val_15 = 1152921505134784536;
            val_31 = 3;
            label_46:
            val_28 = val_32;
            val_19 = ???;
            val_37 = ???;
            val_19.TriggerOnMessage(message:  val_28);
            return;
            label_41:
            val_19.TriggerOnClose();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_6 = this;
            this.websocketCollectionModified = false;
            List.Enumerator<T> val_1 = this.webSockets.GetEnumerator();
            label_8:
            if(((-1699827032) & 1) == 0)
            {
                goto label_2;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            bool val_4 = 0.emailUIDataHandler.Update();
            if(this.websocketCollectionModified == false)
            {
                goto label_8;
            }
            
            label_2:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520086889128});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WebSocketController()
        {
            this.webSockets = new System.Collections.Generic.List<GameSparks.Platforms.IControlledWebSocket>();
        }
    
    }

}
