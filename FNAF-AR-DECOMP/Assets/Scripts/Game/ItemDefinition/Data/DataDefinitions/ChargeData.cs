using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ChargeData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string REMNANT_SHOCK_WINDOW = "RemnantShockWindow";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Seconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float MaxShockWindow;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData ShockWindow;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool UseFeintDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData JumpscareDelayChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData JumpscareDelayTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData SkipDelayedJumpscareChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData CircleChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData JumpscareChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData PauseChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool ForceCircleAfterPause;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChargeData(ProtoData.ATTACK_DATA.Types.CHARGE rawSettings)
        {
            RANGE val_34;
            RANGE val_35;
            float val_36;
            CHANCE val_37;
            CHANCE val_38;
            CHANCE val_39;
            CHANCE val_40;
            var val_41;
            bool val_42;
            var val_1 = (rawSettings != 0) ? (this) : 0;
            if(rawSettings != null)
            {
                    val_34 = rawSettings.Seconds;
            }
            else
            {
                    val_34 = 0;
            }
            
            this.Seconds = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_34);
            if(rawSettings != null)
            {
                    mem2[0] = (float)rawSettings.MaxShockWindow;
                val_35 = rawSettings.ShockWindow;
            }
            else
            {
                    val_35 = 0;
                this.MaxShockWindow = -1.175494E-38f;
            }
            
            if((new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_35)) != null)
            {
                    val_36 = (Game.ItemDefinition.Data.DataDefinitions.RangeData)[1152921525296087088].Min;
            }
            else
            {
                    val_36 = 1.68059E-38f;
            }
            
            this.ShockWindow = Game.ItemDefinition.Data.DataDefinitions.ChargeData.BuildShockWindow(min:  val_36, max:  (Game.ItemDefinition.Data.DataDefinitions.RangeData)[1152921525296087088].Max, maxShockWindow:  this.MaxShockWindow);
            if(rawSettings != null)
            {
                    this.UseFeintDistance = rawSettings.UseFeintDistance;
                val_37 = rawSettings.JumpscareDelayChance;
            }
            else
            {
                    val_37 = 0;
                this.UseFeintDistance = false;
            }
            
            this.JumpscareDelayChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_37);
            if(rawSettings != null)
            {
                    this.JumpscareDelayTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  rawSettings.JumpscareDelayTime);
                val_38 = rawSettings.SkipDelayedJumpscareChance;
            }
            else
            {
                    val_38 = 0;
                this.JumpscareDelayTime = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  0);
            }
            
            this.SkipDelayedJumpscareChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_38);
            if(rawSettings == null)
            {
                goto label_13;
            }
            
            NEXTPHASE val_17 = rawSettings.NextPhase;
            if(val_17 == null)
            {
                goto label_14;
            }
            
            val_39 = val_17.Circle;
            goto label_15;
            label_13:
            val_40 = 0;
            this.CircleChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            goto label_19;
            label_14:
            val_39 = 0;
            label_15:
            this.CircleChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_39);
            if(rawSettings == null)
            {
                goto label_17;
            }
            
            NEXTPHASE val_21 = rawSettings.NextPhase;
            if(val_21 == null)
            {
                goto label_18;
            }
            
            val_40 = val_21.Jumpscare;
            goto label_19;
            label_17:
            val_40 = 0;
            this.JumpscareChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            goto label_23;
            label_18:
            val_40 = 0;
            label_19:
            this.JumpscareChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_40);
            if(rawSettings == null)
            {
                goto label_21;
            }
            
            NEXTPHASE val_25 = rawSettings.NextPhase;
            if(val_25 == null)
            {
                goto label_22;
            }
            
            val_40 = val_25.Pause;
            goto label_23;
            label_21:
            val_41 = 0;
            this.PauseChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            goto label_27;
            label_22:
            val_40 = 0;
            label_23:
            this.PauseChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_40);
            if(rawSettings == null)
            {
                goto label_26;
            }
            
            NEXTPHASE val_29 = rawSettings.NextPhase;
            if(val_29 == null)
            {
                goto label_26;
            }
            
            bool val_31 = val_29.ForceCircleAfterPause;
            val_41 = 0;
            goto label_27;
            label_26:
            val_41 = 0;
            label_27:
            if(((-785656820) & 1) != 0)
            {
                    val_42 = val_41.GetValueOrDefault();
            }
            else
            {
                    val_42 = false;
            }
            
            this.ForceCircleAfterPause = val_42;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChargeData(Game.ItemDefinition.Data.DataDefinitions.ChargeData charge, System.Collections.Generic.Dictionary<string, float> mods)
        {
            float val_4;
            val_1 = new System.Object();
            if(charge != null)
            {
                    this.Seconds = charge.Seconds;
                this.MaxShockWindow = charge.MaxShockWindow;
            }
            else
            {
                    this.Seconds = 11993091;
                this.MaxShockWindow = 2.105703E-38f;
            }
            
            if((new Game.ItemDefinition.Data.DataDefinitions.RangeData(range:  charge.ShockWindow, key:  "RemnantShockWindow", mods:  System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = mods)) != null)
            {
                    val_4 = (Game.ItemDefinition.Data.DataDefinitions.RangeData)[1152921525296354848].Min;
            }
            else
            {
                    val_4 = 1.68059E-38f;
            }
            
            this.ShockWindow = Game.ItemDefinition.Data.DataDefinitions.ChargeData.BuildShockWindow(min:  val_4, max:  (Game.ItemDefinition.Data.DataDefinitions.RangeData)[1152921525296354848].Max, maxShockWindow:  this.MaxShockWindow);
            this.UseFeintDistance = charge.UseFeintDistance;
            this.JumpscareDelayChance = charge.JumpscareDelayChance;
            this.JumpscareDelayTime = charge.JumpscareDelayTime;
            this.SkipDelayedJumpscareChance = charge.SkipDelayedJumpscareChance;
            this.CircleChance = charge.CircleChance;
            this.JumpscareChance = charge.JumpscareChance;
            this.PauseChance = charge.PauseChance;
            this.ForceCircleAfterPause = charge.ForceCircleAfterPause;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChargeData(Game.ItemDefinition.Data.DataDefinitions.RangeData seconds, float maxShockWindow, Game.ItemDefinition.Data.DataDefinitions.RangeData shockWindow, bool useFeintDistance, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData jumpscareDelayChance, Game.ItemDefinition.Data.DataDefinitions.RangeData jumpscareDelayTime, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData skipDelayedJumpscareChance, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData circleChance, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData jumpscareChance, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData pauseChance, bool forceCircleAfterPause)
        {
            float val_5;
            float val_6;
            val_5 = maxShockWindow;
            val_1 = new System.Object();
            this.Seconds = seconds;
            this.MaxShockWindow = val_5;
            if(val_1 != null)
            {
                    val_6 = shockWindow.Min;
            }
            else
            {
                    val_6 = 1.68059E-38f;
                val_5 = this.MaxShockWindow;
            }
            
            this.ShockWindow = Game.ItemDefinition.Data.DataDefinitions.ChargeData.BuildShockWindow(min:  val_6, max:  shockWindow.Max, maxShockWindow:  val_5);
            this.JumpscareDelayChance = jumpscareDelayChance;
            this.JumpscareDelayTime = jumpscareDelayTime;
            this.SkipDelayedJumpscareChance = skipDelayedJumpscareChance;
            this.PauseChance = pauseChance;
            this.UseFeintDistance = useFeintDistance;
            this.CircleChance = circleChance;
            this.JumpscareChance = jumpscareChance;
            this.ForceCircleAfterPause = forceCircleAfterPause;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Game.ItemDefinition.Data.DataDefinitions.RangeData BuildShockWindow(float min, float max, float maxShockWindow)
        {
            .Min = UnityEngine.Mathf.Min(a:  min, b:  maxShockWindow);
            .Max = UnityEngine.Mathf.Min(a:  max, b:  maxShockWindow);
            return (Game.ItemDefinition.Data.DataDefinitions.RangeData)new Game.ItemDefinition.Data.DataDefinitions.RangeData();
        }
    
    }

}
