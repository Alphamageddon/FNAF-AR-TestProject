using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackProfile
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SHEAR_MOD = "Shear";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.EncounterType EncounterType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float WaitForCameraTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float OfflineExpireTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool IsMaskAvailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.TeleportRepositionData TeleportReposition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.InitialPauseData InitialPause;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.CircleData Circle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PauseData Pause;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.ChargeData Charge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.JumpscareData Jumpscare;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywireData Haywire;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.DisruptionData Disruption;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.SurgeData Surge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.BatteryData Battery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string StaticProfile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int NumShocksToDefeat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PhantomWalkData PhantomWalk;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PhantomOverloadData PhantomOverload;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PhantomPauseData PhantomPause;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.FootstepsData Footsteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.GlimpseData Glimpse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float ShearModifier;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackProfile(ProtoData.ATTACK_DATA.Types.ENTRY rawSettings)
        {
            GLIMPSE val_49;
            string val_50;
            TELEPORTREPOSITION val_51;
            CIRCLE val_52;
            CHARGE val_53;
            HAYWIRE val_54;
            SURGE val_55;
            PHANTOMWALK val_56;
            PHANTOMPAUSE val_57;
            val_49 = rawSettings;
            Game.ItemDefinition.Data.DataDefinitions.EncounterType val_2 = 0;
            if(val_49 != null)
            {
                    val_50 = val_49.EncounterType;
            }
            else
            {
                    val_50 = 0;
            }
            
            this.EncounterType = ((System.Enum.TryParse<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(value:  val_50, ignoreCase:  true, result: out  val_2)) != true) ? (val_2) : 0;
            if(val_49 != null)
            {
                    this.WaitForCameraTime = (float)val_49.WaitForCameraTime;
                this.OfflineExpireTime = (float)val_49.OfflineExpireTime;
                this.IsMaskAvailable = val_49.IsMaskAvailable;
                val_51 = val_49.TeleportReposition;
            }
            else
            {
                    val_51 = 0;
                this.WaitForCameraTime = 0f;
                this.OfflineExpireTime = 0f;
                this.IsMaskAvailable = false;
            }
            
            this.TeleportReposition = new Game.ItemDefinition.Data.DataDefinitions.TeleportRepositionData(rawSettings:  val_51);
            if(val_49 != null)
            {
                    this.InitialPause = new Game.ItemDefinition.Data.DataDefinitions.InitialPauseData(rawSettings:  val_49.InitialPause);
                val_52 = val_49.Circle;
            }
            else
            {
                    val_52 = 0;
                this.InitialPause = new Game.ItemDefinition.Data.DataDefinitions.InitialPauseData(rawSettings:  0);
            }
            
            this.Circle = new Game.ItemDefinition.Data.DataDefinitions.CircleData(rawSettings:  val_52);
            if(val_49 != null)
            {
                    this.Pause = new Game.ItemDefinition.Data.DataDefinitions.PauseData(rawSettings:  val_49.Pause);
                val_53 = val_49.Charge;
            }
            else
            {
                    val_53 = 0;
                this.Pause = new Game.ItemDefinition.Data.DataDefinitions.PauseData(rawSettings:  0);
            }
            
            this.Charge = new Game.ItemDefinition.Data.DataDefinitions.ChargeData(rawSettings:  val_53);
            if(val_49 != null)
            {
                    this.Jumpscare = new Game.ItemDefinition.Data.DataDefinitions.JumpscareData(rawSettings:  val_49.Jumpscare);
                val_54 = val_49.Haywire;
            }
            else
            {
                    val_54 = 0;
                this.Jumpscare = new Game.ItemDefinition.Data.DataDefinitions.JumpscareData(rawSettings:  0);
            }
            
            this.Haywire = new Game.ItemDefinition.Data.DataDefinitions.HaywireData(rawSettings:  val_54);
            if(val_49 != null)
            {
                    this.Disruption = new Game.ItemDefinition.Data.DataDefinitions.DisruptionData(rawSettings:  val_49.Disruption);
                val_55 = val_49.Surge;
            }
            else
            {
                    val_55 = 0;
                this.Disruption = new Game.ItemDefinition.Data.DataDefinitions.DisruptionData(rawSettings:  0);
            }
            
            this.Surge = new Game.ItemDefinition.Data.DataDefinitions.SurgeData(rawSettings:  val_55);
            if(val_49 != null)
            {
                    this.Battery = new Game.ItemDefinition.Data.DataDefinitions.BatteryData(rawSettings:  val_49.Battery);
                string val_33 = val_49.StaticProfile;
                this.StaticProfile = (val_33 == null) ? "" : (val_33);
                this.NumShocksToDefeat = (int)val_49.NumShocksToDefeat;
                val_56 = val_49.PhantomWalk;
            }
            else
            {
                    this.Battery = new Game.ItemDefinition.Data.DataDefinitions.BatteryData(rawSettings:  0);
                val_56 = 0;
                this.NumShocksToDefeat = 1;
                this.StaticProfile = "";
            }
            
            this.PhantomWalk = new Game.ItemDefinition.Data.DataDefinitions.PhantomWalkData(rawSettings:  val_56);
            if(val_49 != null)
            {
                    this.PhantomOverload = new Game.ItemDefinition.Data.DataDefinitions.PhantomOverloadData(rawSettings:  val_49.PhantomOverload);
                val_57 = val_49.PhantomPause;
            }
            else
            {
                    val_57 = 0;
                this.PhantomOverload = new Game.ItemDefinition.Data.DataDefinitions.PhantomOverloadData(rawSettings:  0);
            }
            
            this.PhantomPause = new Game.ItemDefinition.Data.DataDefinitions.PhantomPauseData(rawSettings:  val_57);
            if(val_49 != null)
            {
                    this.Footsteps = new Game.ItemDefinition.Data.DataDefinitions.FootstepsData(rawSettings:  val_49.Footsteps);
                val_49 = val_49.Glimpse;
            }
            else
            {
                    this.Footsteps = new Game.ItemDefinition.Data.DataDefinitions.FootstepsData(rawSettings:  0);
            }
            
            this.Glimpse = new Game.ItemDefinition.Data.DataDefinitions.GlimpseData(rawSettings:  val_49);
            this.ShearModifier = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackProfile(Game.ItemDefinition.Data.DataDefinitions.EncounterType encounterType, float waitForCameraTime, float offlineExpireTime, bool isMaskAvailable, Game.ItemDefinition.Data.DataDefinitions.TeleportRepositionData teleportReposition, Game.ItemDefinition.Data.DataDefinitions.InitialPauseData initialPause, Game.ItemDefinition.Data.DataDefinitions.CircleData circle, Game.ItemDefinition.Data.DataDefinitions.PauseData pause, Game.ItemDefinition.Data.DataDefinitions.ChargeData charge, Game.ItemDefinition.Data.DataDefinitions.JumpscareData jumpscare, Game.ItemDefinition.Data.DataDefinitions.HaywireData haywire, Game.ItemDefinition.Data.DataDefinitions.DisruptionData disruption, Game.ItemDefinition.Data.DataDefinitions.SurgeData surge, Game.ItemDefinition.Data.DataDefinitions.BatteryData battery, string staticProfile, int numShocksToDefeat, Game.ItemDefinition.Data.DataDefinitions.PhantomWalkData phantomWalk, Game.ItemDefinition.Data.DataDefinitions.PhantomOverloadData phantomOverload, Game.ItemDefinition.Data.DataDefinitions.PhantomPauseData phantomPause, Game.ItemDefinition.Data.DataDefinitions.FootstepsData footsteps, Game.ItemDefinition.Data.DataDefinitions.GlimpseData glimpse)
        {
            Game.ItemDefinition.Data.DataDefinitions.PhantomWalkData val_1 = phantomWalk;
            val_1 = new System.Object();
            this.EncounterType = encounterType;
            this.WaitForCameraTime = waitForCameraTime;
            this.OfflineExpireTime = offlineExpireTime;
            this.TeleportReposition = teleportReposition;
            this.InitialPause = initialPause;
            this.Circle = circle;
            this.Pause = pause;
            this.Haywire = haywire;
            this.Disruption = disruption;
            this.Surge = surge;
            this.Battery = battery;
            this.StaticProfile = staticProfile;
            this.Charge = charge;
            this.Jumpscare = jumpscare;
            this.NumShocksToDefeat = numShocksToDefeat;
            this.PhantomWalk = val_1;
            this.PhantomOverload = phantomOverload;
            this.PhantomPause = phantomPause;
            this.Footsteps = footsteps;
            this.Glimpse = glimpse;
            this.ShearModifier = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackProfile(Game.ItemDefinition.Data.DataDefinitions.AttackProfile profile, System.Collections.Generic.Dictionary<string, float> mods)
        {
            val_1 = new System.Object();
            if(profile != null)
            {
                    this.EncounterType = profile.EncounterType;
                this.WaitForCameraTime = profile.WaitForCameraTime;
                this.OfflineExpireTime = profile.OfflineExpireTime;
                this.IsMaskAvailable = profile.IsMaskAvailable;
                this.TeleportReposition = profile.TeleportReposition;
                this.InitialPause = profile.InitialPause;
            }
            else
            {
                    this.EncounterType = 11993091;
                this.WaitForCameraTime = 1.401298E-45f;
                this.OfflineExpireTime = 2.105703E-38f;
                this.IsMaskAvailable = false;
                this.TeleportReposition = 64;
                this.InitialPause = 69077560;
            }
            
            this.Circle = new Game.ItemDefinition.Data.DataDefinitions.CircleData(circle:  profile.Circle, mods:  System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = mods);
            if(profile != null)
            {
                    this.Pause = profile.Pause;
            }
            else
            {
                    this.Pause = 4194311;
            }
            
            this.Charge = new Game.ItemDefinition.Data.DataDefinitions.ChargeData(charge:  profile.Charge, mods:  val_1);
            if(profile != null)
            {
                    this.Jumpscare = profile.Jumpscare;
            }
            else
            {
                    this.Jumpscare = 0;
            }
            
            this.Haywire = new Game.ItemDefinition.Data.DataDefinitions.HaywireData(haywire:  profile.Haywire, mods:  val_1);
            if(profile != null)
            {
                    this.Disruption = new Game.ItemDefinition.Data.DataDefinitions.DisruptionData(disruption:  profile.Disruption, mods:  val_1);
            }
            else
            {
                    this.Disruption = new Game.ItemDefinition.Data.DataDefinitions.DisruptionData(disruption:  0, mods:  val_1);
            }
            
            this.Surge = new Game.ItemDefinition.Data.DataDefinitions.SurgeData(surge:  profile.Surge, mods:  val_1);
            if(profile != null)
            {
                    this.Battery = new Game.ItemDefinition.Data.DataDefinitions.BatteryData(batteryData:  profile.Battery, mods:  val_1);
                this.StaticProfile = profile.StaticProfile;
                this.NumShocksToDefeat = profile.NumShocksToDefeat;
                this.PhantomWalk = profile.PhantomWalk;
                this.PhantomOverload = profile.PhantomOverload;
                this.PhantomPause = profile.PhantomPause;
                this.Footsteps = profile.Footsteps;
            }
            else
            {
                    this.Battery = new Game.ItemDefinition.Data.DataDefinitions.BatteryData(batteryData:  62590012, mods:  val_1);
                this.StaticProfile = 65536;
                this.NumShocksToDefeat = 1;
                this.PhantomWalk = 62590976;
                this.PhantomOverload = 62656512;
                this.PhantomPause = 62656512;
                this.Footsteps = 6486152;
            }
            
            this.Glimpse = profile.Glimpse;
            this.ShearModifier = Game.ItemDefinition.Data.DataDefinitions.FloatHelper.ApplyModifier(baseValue:  1f, key:  "Shear", mods:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.Circle != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.Circle == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.Circle;
            val_1[1] = this.Haywire;
            val_1[2] = this.Disruption;
            val_1[3] = this.Battery;
            val_1[4] = this.ShearModifier;
            return (string)System.String.Format(format:  "{{\"Circle\":{0},\"Haywire\":{1},\"Disruption\":{2},\"Battery\":{3},\"ShearModifier\":{4}}}", args:  val_1);
        }
    
    }

}
