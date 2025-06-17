using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GuideFactory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, Systems.Guide.GuideNode> _nodes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string[] _emptyKeys;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string[] GetNodeKeys()
        {
            var val_9;
            System.Collections.Generic.Dictionary<System.String, Systems.Guide.GuideNode> val_12;
            System.String[] val_13;
            var val_14;
            val_9 = null;
            val_9 = null;
            val_12 = Systems.Guide.GuideFactory._nodes;
            if(val_12 == null)
            {
                goto label_3;
            }
            
            val_12 = Systems.Guide.GuideFactory._nodes;
            if(val_12 == null)
            {
                    val_12 = 0;
            }
            
            int val_2 = val_12.Keys.Count;
            val_13 = new string[0];
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = Systems.Guide.GuideFactory._nodes.Keys.GetEnumerator();
            val_14 = 0;
            goto label_10;
            label_15:
            val_14 = 1;
            val_13[0] = 0.emailUIDataHandler;
            label_10:
            if((1588928616 & 1) != 0)
            {
                goto label_15;
            }
            
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523375644776});
            return val_13;
            label_3:
            val_13 = Systems.Guide.GuideFactory._emptyKeys;
            return val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Systems.Guide.GuideNode GenerateNode(string uid)
        {
            var val_9;
            Systems.Guide.GuideNode val_10;
            Systems.Guide.GuideNode val_1 = 0;
            val_9 = null;
            val_9 = null;
            if((Systems.Guide.GuideFactory._nodes.TryGetValue(key:  uid, value: out  val_1)) != false)
            {
                    val_10 = val_1;
                return val_10;
            }
            
            ConsoleLogger.LogError(className:  "GuideFactory", functionName:  "GenerateNode", logString:  "Cannot find node with uid " + uid);
            Systems.Guide.GuideNode val_4 = null;
            val_10 = val_4;
            val_4 = new Systems.Guide.GuideNode();
            .Uid = "DegenerateNode";
            .Events = new Systems.Guide.GuideEvent[1];
            .EventArgs = new string[0];
            .Conditions = new Systems.Guide.GuideCondition[0];
            string[] val_8 = new string[0];
            if(val_10 != null)
            {
                    .ConditionArgs = val_8;
                .Action = 0;
                .ActionArgs = "5.0";
            }
            else
            {
                    mem[56] = val_8;
                mem[64] = 0;
                mem[72] = "5.0";
            }
            
            .Resolution = 0;
            return val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void LoadTutorialDataFromLocalCSV()
        {
            var val_28;
            string val_29;
            var val_30;
            var val_31;
            int val_32;
            int val_33;
            var val_34;
            var val_35;
            Systems.Guide.GuideAction val_26 = 0;
            System.Collections.Generic.Dictionary<System.String, Systems.Guide.GuideNode> val_1 = new System.Collections.Generic.Dictionary<System.String, Systems.Guide.GuideNode>();
            val_28 = null;
            val_28 = null;
            Systems.Guide.GuideFactory._nodes = val_1;
            UnityEngine.TextAsset val_2 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "Tutorial/ftue");
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_2);
            string val_4 = val_2.text.Trim();
            System.IO.StringReader val_5 = null;
            val_29 = val_4;
            val_5 = new System.IO.StringReader(s:  val_29);
            val_30 = ",";
            val_31 = 1152921505354798016;
            goto label_7;
            label_58:
            val_29 = ",";
            if((val_4.StartsWith(value:  val_29)) != true)
            {
                    val_29 = 0;
                if(val_4.Length != 0)
            {
                    char[] val_8 = new char[1];
                val_8[0] = ',';
                System.String[] val_9 = val_4.Split(separator:  val_8);
                val_32 = val_9.Length;
                if(val_32 == 0)
            {
                    val_32 = val_9.Length;
            }
            
                string val_30 = val_9[0];
                char[] val_10 = new char[1];
                val_10[0] = 32;
                Systems.Guide.GuideEvent[] val_12 = new Systems.Guide.GuideEvent[0];
                if(val_11.Length >= 1)
            {
                    do
            {
                bool val_14 = System.Enum.TryParse<Systems.Guide.GuideEvent>(value:  val_9[1].Split(separator:  val_10)[0], result: out  val_12[0][32]);
            }
            while((0 + 1) < val_11.Length);
            
            }
            
                char[] val_16 = new char[1];
                val_16[0] = 32;
                System.String[] val_17 = val_9[2].Split(separator:  val_16);
                char[] val_18 = new char[1];
                val_18[0] = 32;
                Systems.Guide.GuideCondition[] val_20 = new Systems.Guide.GuideCondition[0];
                if(val_19.Length >= 1)
            {
                    do
            {
                bool val_22 = System.Enum.TryParse<Systems.Guide.GuideCondition>(value:  val_9[3].Split(separator:  val_18)[0], result: out  val_20[0][32]);
            }
            while((0 + 1) < val_19.Length);
            
            }
            
                char[] val_24 = new char[1];
                val_24[0] = 32;
                System.String[] val_25 = val_9[4].Split(separator:  val_24);
                bool val_27 = System.Enum.TryParse<Systems.Guide.GuideAction>(value:  val_9[5], result: out  val_26);
                val_33 = val_9.Length;
                if(val_33 <= 6)
            {
                    val_33 = val_9.Length;
            }
            
                string val_38 = val_9[6];
                bool val_28 = System.Enum.TryParse<Systems.Guide.GuideResolution>(value:  val_9[7], result: out  val_26);
                Systems.Guide.GuideNode val_29 = new Systems.Guide.GuideNode();
                if(val_29 != null)
            {
                    .EventArgs = val_17;
                .Conditions = val_20;
                .ConditionArgs = val_25;
                .Uid = val_30;
                .Events = val_12;
                .ActionArgs = val_38;
                .Action = 0;
                .Resolution = 0;
            }
            else
            {
                    mem[16] = val_30;
                mem[24] = val_12;
                mem[32] = val_17;
                mem[48] = val_20;
                mem[56] = val_25;
                mem[64] = 0;
                mem[72] = val_38;
                mem[88] = 0;
            }
            
                val_30 = ",";
                val_31 = 1152921505354798016;
                .ResolutionArgs = val_9[8];
                val_34 = null;
                val_34 = null;
                val_29 = val_30;
                val_1.Add(key:  val_29, value:  val_29);
            }
            
            }
            
            label_7:
            if(val_5 != null)
            {
                goto label_58;
            }
            
            val_35 = null;
            val_35 = null;
            Systems.Guide.GuideFactory.Validate(nodes:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoadTutorialDataFromProtobuf(ProtoData.TUTORIAL_DATA data)
        {
            var val_46;
            var val_47;
            var val_50;
            System.String[] val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_57;
            Systems.Guide.GuideAction val_39 = 0;
            System.Collections.Generic.Dictionary<System.String, Systems.Guide.GuideNode> val_1 = new System.Collections.Generic.Dictionary<System.String, Systems.Guide.GuideNode>();
            val_46 = 1152921505168719872;
            val_47 = null;
            val_47 = null;
            Systems.Guide.GuideFactory._nodes = val_1;
            System.Collections.Generic.IEnumerator<T> val_3 = data.Entries.GetEnumerator();
            label_72:
            var val_50 = 0;
            val_50 = val_50 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_10;
            }
            
            var val_51 = 0;
            val_51 = val_51 + 1;
            T val_7 = val_3.Current;
            string val_8 = val_7.Logical;
            char[] val_11 = new char[1];
            val_11[0] = 32;
            Systems.Guide.GuideEvent[] val_13 = new Systems.Guide.GuideEvent[0];
            if(val_12.Length >= 1)
            {
                    do
            {
                bool val_15 = System.Enum.TryParse<Systems.Guide.GuideEvent>(value:  val_7.EventInfo.GuideEvents.Split(separator:  val_11)[0], result: out  val_13[0][32]);
            }
            while((0 + 1) < val_12.Length);
            
            }
            
            char[] val_19 = new char[1];
            val_19[0] = 32;
            System.String[] val_20 = val_7.EventInfo.EventArgs.Split(separator:  val_19);
            string val_22 = val_7.ConditionInfo.GuideConditions;
            if(val_22 == null)
            {
                goto label_37;
            }
            
            char[] val_24 = new char[1];
            val_24[0] = 32;
            val_50 = (val_22 == null) ? 0 : (val_22).Split(separator:  val_24);
            if(val_50 != null)
            {
                goto label_42;
            }
            
            label_37:
            val_50 = new string[0];
            label_42:
            Systems.Guide.GuideCondition[] val_27 = new Systems.Guide.GuideCondition[0];
            if(val_26.Length >= 1)
            {
                    do
            {
                bool val_29 = System.Enum.TryParse<Systems.Guide.GuideCondition>(value:  val_50[0], result: out  val_27[0][32]);
            }
            while((0 + 1) < val_26.Length);
            
            }
            
            string val_32 = val_7.ConditionInfo.ConditionArgs;
            if(val_32 == null)
            {
                goto label_52;
            }
            
            char[] val_34 = new char[1];
            val_34[0] = 32;
            val_51 = (val_32 == null) ? 0 : (val_32).Split(separator:  val_34);
            if(val_51 != null)
            {
                goto label_56;
            }
            
            label_52:
            val_51 = new string[0];
            label_56:
            bool val_40 = System.Enum.TryParse<Systems.Guide.GuideAction>(value:  val_7.ActionInfo.GuideAction, result: out  val_39);
            string val_42 = val_7.ActionInfo.ActionArgs;
            bool val_45 = System.Enum.TryParse<Systems.Guide.GuideResolution>(value:  val_7.ResolutionInfo.GuideResolution, result: out  val_39);
            new Systems.Guide.GuideNode() = new Systems.Guide.GuideNode();
            if(new Systems.Guide.GuideNode() != null)
            {
                    .Uid = val_8;
                .Events = val_13;
                .Conditions = val_27;
                .ConditionArgs = val_51;
                .EventArgs = val_20;
                .ActionArgs = val_42;
                .Action = 0;
                .Resolution = 0;
                val_52 = 1152921505168719872;
            }
            else
            {
                    mem[16] = val_8;
                mem[24] = val_13;
                mem[32] = val_20;
                mem[48] = val_27;
                mem[56] = val_51;
                mem[64] = 0;
                val_52 = 1152921505168719872;
                mem[72] = val_42;
                mem[88] = 0;
            }
            
            .ResolutionArgs = val_7.ResolutionInfo.ResolutionArgs;
            val_53 = null;
            val_1.Add(key:  val_8, value:  new Systems.Guide.GuideNode());
            goto label_72;
            label_10:
            val_54 = 0;
            val_55 = 467;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_54 = 0;
                val_54 = val_54 + 1;
                val_3.Dispose();
            }
            
            val_57 = null;
            Systems.Guide.GuideFactory.Validate(nodes:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void Validate(System.Collections.Generic.Dictionary<string, Systems.Guide.GuideNode> nodes)
        {
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = nodes.Values.GetEnumerator();
            label_9:
            if((1590620232 & 1) == 0)
            {
                goto label_3;
            }
            
            if((1590620232 != 3) || (1590620234 == 31))
            {
                goto label_9;
            }
            
            Systems.Guide.GuideFactory.LogValidationError(node:  0.emailUIDataHandler, title:  "SWITCH Resolution Error", message:  "SWITCH Resolution requires a valid action type. Either an invalid action type is being used, or it has not been correctly setup with validation.");
            goto label_9;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523377336392});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void LogValidationError(Systems.Guide.GuideNode node, string title, string message)
        {
            string[] val_1 = new string[7];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(title != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(title == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = title;
            val_1[1] = ": Guide Node ";
            val_1[2] = node.Uid;
            val_1[3] = " (A:";
            mem2[0] = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = node.Action});
            val_1[4] = node.Action.ToString();
            val_1[5] = ",\r\n ";
            val_1[6] = message;
            ConsoleLogger.LogError(className:  "GuideFactory", functionName:  "Validate", logString:  +val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GuideFactory()
        {
            Systems.Guide.GuideFactory._emptyKeys = new string[0];
        }
    
    }

}
