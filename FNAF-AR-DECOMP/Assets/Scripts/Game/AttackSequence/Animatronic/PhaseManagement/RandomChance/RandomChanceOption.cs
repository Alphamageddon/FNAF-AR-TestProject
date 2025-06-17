using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.RandomChance
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RandomChanceOption : IComparable<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string DebugOptionName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Chance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float _modifier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption> _sortedOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CompareTo(Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption other)
        {
            if(other == null)
            {
                    return 1;
            }
            
            return 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GiveChance(System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption> options)
        {
            var val_9;
            var val_10;
            var val_11;
            if(this._modifier >= 0f)
            {
                    return;
            }
            
            if(this.Chance <= 0f)
            {
                    return;
            }
            
            if(options.Count < 2)
            {
                    return;
            }
            
            val_9 = 1152921504840978432;
            float val_10 = UnityEngine.Mathf.Min(a:  System.Math.Abs(this._modifier), b:  this.Chance);
            val_10 = val_10 / ((float)options.Count - 1);
            List.Enumerator<T> val_5 = options.GetEnumerator();
            goto label_11;
            label_12:
            GameUI.EmailUIDataHandler val_6 = 0.emailUIDataHandler;
            if(val_6._masterDomain != this.Id)
            {
                    System.Collections.Generic.List<GameUI.EmailData> val_11 = val_6._emailDatas;
                val_11 = val_10 + val_11;
                val_6._emailDatas = val_11;
            }
            
            label_11:
            if(((-614503096) & 1) != 0)
            {
                goto label_12;
            }
            
            val_10 = 0;
            val_11 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525467180360});
            float val_12 = System.Math.Abs(this._modifier);
            val_12 = this.Chance - val_12;
            this.Chance = UnityEngine.Mathf.Max(a:  val_12, b:  0f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TakeChance(System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption> options)
        {
            var val_4;
            System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption> val_21;
            var val_22;
            if(this._modifier <= 0f)
            {
                    return;
            }
            
            if(this.Chance >= 1f)
            {
                    return;
            }
            
            if(options.Count < 2)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = options.GetEnumerator();
            label_11:
            if(((-614311264) & 1) == 0)
            {
                goto label_6;
            }
            
            if((val_5._masterDomain == this.Id) || (val_5._emailDatas <= 0f))
            {
                goto label_11;
            }
            
            this._sortedOptions.Add(item:  val_4.emailUIDataHandler);
            goto label_11;
            label_6:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525467372192});
            val_22 = 0;
            if(this._sortedOptions.Count == 0)
            {
                    return;
            }
            
            this._sortedOptions.Sort();
            float val_20 = UnityEngine.Mathf.Min(a:  this._modifier, b:  1f - this.Chance);
            val_20 = val_20 / (float)this._sortedOptions.Count;
            List.Enumerator<T> val_12 = this._sortedOptions.GetEnumerator();
            var val_23 = 0;
            goto label_27;
            label_30:
            GameUI.EmailUIDataHandler val_13 = val_4.emailUIDataHandler;
            System.Collections.Generic.List<GameUI.EmailData> val_21 = val_13._emailDatas;
            if(val_21 >= 0)
            {
                    val_21 = val_21 - val_20;
                val_13._emailDatas = val_21;
            }
            else
            {
                    val_21 = this._sortedOptions;
                int val_15 = val_21.Count - val_23;
                if(val_15 >= 1)
            {
                    System.Collections.Generic.List<GameUI.EmailData> val_22 = val_13._emailDatas;
                val_22 = val_20 - val_22;
                val_22 = val_22 / (float)val_15;
                val_20 = val_20 + val_22;
            }
            
                val_13._emailDatas = 0;
            }
            
            label_27:
            val_23 = val_23 + 1;
            if(((-614311264) & 1) != 0)
            {
                goto label_30;
            }
            
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525467372192});
            this.Chance = UnityEngine.Mathf.Min(a:  this.Chance + this._modifier, b:  1f);
            this._sortedOptions.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RandomChanceOption(int id, string debugOptionName, float baseChance, float modifier)
        {
            this._sortedOptions = new System.Collections.Generic.List<Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceOption>();
            val_2 = new System.Object();
            this.Id = id;
            this.DebugOptionName = val_2;
            this.Chance = UnityEngine.Mathf.Max(a:  baseChance, b:  0f);
            this._modifier = modifier;
        }
    
    }

}
