using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.RandomChance
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RandomChanceGroup
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ClassName = "RandomChanceGroup";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _debugGroupName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption> _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _setupComplete;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddOption(int id, string debugOptionName, float baseChance, float modifier)
        {
            if(this._setupComplete != false)
            {
                    string[] val_1 = new string[5];
                val_1[0] = "Can\'t add option \'";
                val_1[1] = debugOptionName;
                val_1[2] = "\' to group \'";
                val_1[3] = this._debugGroupName;
                val_1[4] = "\' because setup has already completed";
                ConsoleLogger.LogError(className:  "RandomChanceGroup", functionName:  "AddOption", logString:  +val_1);
                return;
            }
            
            this._options.Add(item:  new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption(id:  id, debugOptionName:  debugOptionName, baseChance:  baseChance, modifier:  modifier));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteSetup()
        {
            this._setupComplete = true;
            this.EnsureChanceRange();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetRandomOption()
        {
            string val_8;
            int val_9;
            int val_10;
            val_8 = this;
            val_9 = 1152921525466205984;
            if(this._options.Count == 0)
            {
                goto label_2;
            }
            
            this.PrintChances(function:  public System.Int32 System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption>::get_Count(), message:  "Before - ");
            System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption> val_8 = this._options;
            val_8 = val_8.Count - 1;
            if(val_8 < 1)
            {
                goto label_9;
            }
            
            val_9 = 0;
            float val_9 = 0f;
            label_8:
            Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption val_4 = this._options.Item[0];
            val_9 = val_9 + val_4.Chance;
            if((UnityEngine.Random.Range(min:  0.0001f, max:  1f)) <= val_9)
            {
                goto label_7;
            }
            
            val_9 = val_9 + 1;
            if(val_9 < val_8)
            {
                goto label_8;
            }
            
            goto label_9;
            label_2:
            val_8 = "No random options added to group \'" + this._debugGroupName + "\'. Can\'t return random option";
            ConsoleLogger.LogError(className:  "RandomChanceGroup", functionName:  "GetRandomOption", logString:  val_8);
            val_10 = 0;
            return val_10;
            label_7:
            if(val_8 != val_9)
            {
                goto label_13;
            }
            
            label_9:
            Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption val_6 = this._options.Item[val_8];
            val_9 = val_8;
            label_13:
            Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption val_7 = this._options.Item[val_9];
            val_10 = val_7.Id;
            this.UpdateChances(selectedId:  val_10);
            this.PrintChances(function:  val_10, message:  "After - ");
            return val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PrintChances(string function, string message)
        {
            GameUI.ServerGameUIDataModel val_6;
            var val_7;
            var val_8;
            List.Enumerator<T> val_1 = this._options.GetEnumerator();
            label_5:
            if(((-615232056) & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.emailUIDataHandler != null)
            {
                    val_6 = val_2._serverGameUIDataModel;
            }
            else
            {
                    val_6 = 15026800;
            }
            
            string val_4 = message + System.String.Format(format:  "{0}: {1} - ", arg0:  val_6, arg1:  val_2._emailDatas)(System.String.Format(format:  "{0}: {1} - ", arg0:  val_6, arg1:  val_2._emailDatas));
            goto label_5;
            label_2:
            val_7 = 0;
            val_8 = 1;
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525466451400});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnsureChanceRange()
        {
            var val_3;
            var val_12;
            float val_14;
            var val_15;
            System.Collections.Generic.List<GameUI.EmailData> val_16;
            val_12 = this;
            List.Enumerator<T> val_1 = this._options.GetEnumerator();
            val_14 = 0f;
            goto label_2;
            label_4:
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            val_14 = val_14 + val_4._emailDatas;
            label_2:
            if(((-615054528) & 1) != 0)
            {
                goto label_4;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525466628928});
            if(val_14 <= 0f)
            {
                    return;
            }
            
            List.Enumerator<T> val_7 = this._options.GetEnumerator();
            val_12 = 32;
            goto label_11;
            label_14:
            if(val_3.emailUIDataHandler != null)
            {
                    val_16 = val_8._emailDatas;
            }
            else
            {
                    val_16 = 8.96831E-44f;
                val_15 = 32;
            }
            
            mem[32] = val_16 / val_14;
            label_11:
            if(((-615054528) & 1) != 0)
            {
                goto label_14;
            }
            
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525466628928});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateChances(int selectedId)
        {
            var val_4;
            var val_5;
            List.Enumerator<T> val_1 = this._options.GetEnumerator();
            label_6:
            if(((-614897448) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2._masterDomain != selectedId)
            {
                goto label_4;
            }
            
            val_2.GiveChance(options:  this._options);
            goto label_6;
            label_4:
            val_2.TakeChance(options:  this._options);
            goto label_6;
            label_2:
            val_4 = 0;
            val_5 = 1;
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525466786008});
            this.EnsureChanceRange();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RandomChanceGroup(string debugGroupName)
        {
            this._options = new System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption>();
            this._debugGroupName = debugGroupName;
        }
    
    }

}
