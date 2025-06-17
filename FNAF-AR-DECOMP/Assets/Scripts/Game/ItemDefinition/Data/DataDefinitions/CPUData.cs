using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CPUData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <AnimatronicName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Order;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string PlushSuitRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Condition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.EyeColorData AttackEyes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.EyeColorData LookAtEyes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.EyeColorData LookAwayEyes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool Enabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Rank;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int EffectivePower;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Phantasm;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool PlayerAcquirable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float ChanceToMalfunction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int SpeedMPH;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int TravelSpeedMPH;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int SalvagerSpeedMPH;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float NodeTravelTimeMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float NodeTravelTimeMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int NodeVisitMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int NodeVisitMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float StalkingTimerMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float StalkingTimerMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string AttackProfile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RewardDropData WanderingAnimatronicRewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RewardDropData PVPTargetRewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RewardDropData RampageRewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop PVPAggressorRewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string SoundBankName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string CpuIconName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string CpuIconNameFlat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string CpuSilhouetteIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string LossTextKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool AlwaysShowIcon;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AnimatronicName { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_AnimatronicName()
        {
            return (string)this.<AnimatronicName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AnimatronicName(string value)
        {
            this.<AnimatronicName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CPUData(ProtoData.CPU_DATA.Types.ENTRY data)
        {
            Game.ItemDefinition.Data.DataDefinitions.EssenceOnLoss val_327;
            var val_328;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_329;
            var val_330;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_331;
            var val_332;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_333;
            var val_334;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_335;
            var val_336;
            Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop val_337;
            var val_338;
            Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop val_339;
            var val_340;
            Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop val_341;
            var val_342;
            Game.ItemDefinition.Data.DataDefinitions.EssenceOnLoss val_343;
            var val_344;
            Game.ItemDefinition.Data.DataDefinitions.EssenceOnLoss val_345;
            var val_346;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_347;
            var val_348;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_349;
            var val_350;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_351;
            var val_352;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_353;
            var val_354;
            Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop val_355;
            var val_356;
            Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop val_357;
            var val_358;
            Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop val_359;
            var val_360;
            Game.ItemDefinition.Data.DataDefinitions.EssenceOnLoss val_361;
            var val_362;
            Game.ItemDefinition.Data.DataDefinitions.EssenceOnLoss val_363;
            var val_364;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_365;
            var val_366;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_367;
            int val_368;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_369;
            int val_370;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_371;
            int val_372;
            int val_373;
            CPUData.<>c__DisplayClass38_0 val_1 = new CPUData.<>c__DisplayClass38_0();
            .data = data;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    string val_2 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.AlwaysShowIcon;
            }
            
            this.AlwaysShowIcon = (val_2 == null) ? "No" : (val_2).Equals(value:  "Yes");
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    string val_6 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Logical;
            }
            
            this.Id = (val_6 == null) ? "" : (val_6);
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void CPUData.<>c__DisplayClass38_0::<.ctor>b__0(Game.Localization.ILocalization localization)));
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    ANIMPLAYERFACINGTEXT val_11 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.AnimPlayerFacingText;
                if(val_11 != null)
            {
                    string val_12 = val_11.CPUDescription;
                var val_13 = (val_12 == null) ? "" : (val_12);
                if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    if(this != null)
            {
                goto label_12;
            }
            
            }
            
            }
            
            }
            
            label_12:
            this.Description = "";
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    double val_14 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Order;
            }
            
            this.Order = 0;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.PlushSuitRef) != null)
            {
                goto label_16;
            }
            
            }
            
            label_16:
            this.PlushSuitRef = System.String.alignConst;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_18;
            }
            
            VISUALSETTINGS val_16 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.VisualSettings;
            if(val_16 == null)
            {
                goto label_18;
            }
            
            double val_17 = val_16.Condition;
            goto label_19;
            label_18:
            label_19:
            if(((-776842128) & 1) != 0)
            {
                    double val_18 = 0.South;
            }
            
            this.Condition = UnityEngine.Mathf.RoundToInt(f:  (float)100);
            this.AttackEyes = new Game.ItemDefinition.Data.DataDefinitions.EyeColorData();
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    VISUALSETTINGS val_21 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.VisualSettings;
                if(val_21 != null)
            {
                    EYECOLOR val_22 = val_21.AttackEyes;
                if(val_22 != null)
            {
                    if(val_22.HexColor != null)
            {
                goto label_27;
            }
            
            }
            
            }
            
            }
            
            label_27:
            this.AttackEyes.HasOverride = UnityEngine.ColorUtility.TryParseHtmlString(htmlString:  "#" + System.String.alignConst, color: out  new UnityEngine.Color() {r = this.AttackEyes.Color, g = this.AttackEyes.Color, b = this.AttackEyes.Color, a = this.AttackEyes.Color});
            var val_27 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.AttackEyes;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_32;
            }
            
            VISUALSETTINGS val_28 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.VisualSettings;
            if(val_28 == null)
            {
                goto label_32;
            }
            
            EYECOLOR val_29 = val_28.AttackEyes;
            if(val_29 == null)
            {
                goto label_32;
            }
            
            double val_30 = val_29.Intensity;
            goto label_33;
            label_32:
            label_33:
            if(((-776842128) & 1) == 0)
            {
                goto label_34;
            }
            
            double val_31 = 0.South;
            if(this.AttackEyes != null)
            {
                goto label_37;
            }
            
            goto label_36;
            label_34:
            if(this.AttackEyes != null)
            {
                goto label_37;
            }
            
            label_36:
            label_37:
            this.AttackEyes.Intensity = (float)-1;
            this.LookAtEyes = new Game.ItemDefinition.Data.DataDefinitions.EyeColorData();
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    VISUALSETTINGS val_33 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.VisualSettings;
                if(val_33 != null)
            {
                    EYECOLOR val_34 = val_33.LookAtEyes;
                if(val_34 != null)
            {
                    if(val_34.HexColor != null)
            {
                goto label_41;
            }
            
            }
            
            }
            
            }
            
            label_41:
            this.LookAtEyes.HasOverride = UnityEngine.ColorUtility.TryParseHtmlString(htmlString:  "#" + System.String.alignConst, color: out  new UnityEngine.Color() {r = this.LookAtEyes.Color, g = this.LookAtEyes.Color, b = this.LookAtEyes.Color, a = this.LookAtEyes.Color});
            var val_39 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.LookAtEyes;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_46;
            }
            
            VISUALSETTINGS val_40 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.VisualSettings;
            if(val_40 == null)
            {
                goto label_46;
            }
            
            EYECOLOR val_41 = val_40.LookAtEyes;
            if(val_41 == null)
            {
                goto label_46;
            }
            
            double val_42 = val_41.Intensity;
            goto label_47;
            label_46:
            label_47:
            if(((-776842128) & 1) == 0)
            {
                goto label_48;
            }
            
            double val_43 = 0.South;
            if(this.LookAtEyes != null)
            {
                goto label_51;
            }
            
            goto label_50;
            label_48:
            if(this.LookAtEyes != null)
            {
                goto label_51;
            }
            
            label_50:
            label_51:
            this.LookAtEyes.Intensity = (float)-1;
            this.LookAwayEyes = new Game.ItemDefinition.Data.DataDefinitions.EyeColorData();
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    VISUALSETTINGS val_45 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.VisualSettings;
                if(val_45 != null)
            {
                    EYECOLOR val_46 = val_45.LookAwayEyes;
                if(val_46 != null)
            {
                    if(val_46.HexColor != null)
            {
                goto label_55;
            }
            
            }
            
            }
            
            }
            
            label_55:
            this.LookAwayEyes.HasOverride = UnityEngine.ColorUtility.TryParseHtmlString(htmlString:  "#" + System.String.alignConst, color: out  new UnityEngine.Color() {r = this.LookAwayEyes.Color, g = this.LookAwayEyes.Color, b = this.LookAwayEyes.Color, a = this.LookAwayEyes.Color});
            var val_51 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.LookAwayEyes;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_60;
            }
            
            VISUALSETTINGS val_52 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.VisualSettings;
            if(val_52 == null)
            {
                goto label_60;
            }
            
            EYECOLOR val_53 = val_52.LookAwayEyes;
            if(val_53 == null)
            {
                goto label_60;
            }
            
            double val_54 = val_53.Intensity;
            goto label_61;
            label_60:
            label_61:
            if(((-776842128) & 1) == 0)
            {
                goto label_62;
            }
            
            double val_55 = 0.South;
            if(this.LookAwayEyes != null)
            {
                goto label_65;
            }
            
            goto label_64;
            label_62:
            if(this.LookAwayEyes != null)
            {
                goto label_65;
            }
            
            label_64:
            label_65:
            this.LookAwayEyes.Intensity = (float)-1;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_67;
            }
            
            STATUS val_56 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Status;
            if(val_56 == null)
            {
                goto label_67;
            }
            
            LIVESTATE val_57 = val_56.LiveState;
            goto label_68;
            label_67:
            label_68:
            if(((-776842136) & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_58 = 0.region;
            }
            
            this.Enabled = (0 == 1) ? 1 : 0;
            this.Rank = (int)(CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rank;
            this.EffectivePower = (int)(CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.EffectivePower;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    double val_62 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Phantasm;
            }
            
            this.Phantasm = 0;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    bool val_64 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.PlayerAcquirable;
            }
            
            this.PlayerAcquirable = false;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    double val_65 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.ChanceToMalfunction;
            }
            
            this.ChanceToMalfunction = (float)0;
            var val_66 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_81;
            }
            
            SPEEDMPH val_67 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.SpeedMPH;
            if(val_67 == null)
            {
                goto label_81;
            }
            
            MAPSPEEDMPH val_68 = val_67.MapSpeedMPH;
            if(val_68 == null)
            {
                goto label_81;
            }
            
            double val_69 = val_68.NotUpgraded;
            goto label_82;
            label_81:
            label_82:
            this.SpeedMPH = (int)0.South;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_86;
            }
            
            SPEEDMPH val_71 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.SpeedMPH;
            if(val_71 == null)
            {
                goto label_86;
            }
            
            double val_72 = val_71.TravelSpeedMPH;
            goto label_87;
            label_86:
            label_87:
            this.TravelSpeedMPH = (int)0.South;
            this.SalvagerSpeedMPH = (int)(CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.SalvagerSpeedMPH;
            var val_75 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_92;
            }
            
            MAPNODES val_76 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.MapNodes;
            if(val_76 == null)
            {
                goto label_92;
            }
            
            NODETRAVELTIME val_77 = val_76.NodeTravelTime;
            if(val_77 == null)
            {
                goto label_92;
            }
            
            double val_78 = val_77.Min;
            goto label_93;
            label_92:
            label_93:
            this.NodeTravelTimeMin = (float)0.South;
            var val_80 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_98;
            }
            
            MAPNODES val_81 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.MapNodes;
            if(val_81 == null)
            {
                goto label_98;
            }
            
            NODETRAVELTIME val_82 = val_81.NodeTravelTime;
            if(val_82 == null)
            {
                goto label_98;
            }
            
            double val_83 = val_82.Max;
            goto label_99;
            label_98:
            label_99:
            this.NodeTravelTimeMax = (float)0.South;
            var val_85 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_104;
            }
            
            MAPNODES val_86 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.MapNodes;
            if(val_86 == null)
            {
                goto label_104;
            }
            
            NODEPATHMIN val_87 = val_86.NodePathMin;
            if(val_87 == null)
            {
                goto label_104;
            }
            
            double val_88 = val_87.Min;
            goto label_105;
            label_104:
            label_105:
            this.NodeVisitMin = (int)0.South;
            var val_90 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_110;
            }
            
            MAPNODES val_91 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.MapNodes;
            if(val_91 == null)
            {
                goto label_110;
            }
            
            NODEPATHMIN val_92 = val_91.NodePathMin;
            if(val_92 == null)
            {
                goto label_110;
            }
            
            double val_93 = val_92.Max;
            goto label_111;
            label_110:
            label_111:
            this.NodeVisitMax = (int)0.South;
            var val_95 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_116;
            }
            
            STALKINGTIMERS val_96 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.StalkingTimers;
            if(val_96 == null)
            {
                goto label_116;
            }
            
            FUNCTIONING val_97 = val_96.Functioning;
            if(val_97 == null)
            {
                goto label_116;
            }
            
            double val_98 = val_97.Min;
            goto label_117;
            label_116:
            label_117:
            this.StalkingTimerMin = (float)0.South;
            var val_100 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_122;
            }
            
            STALKINGTIMERS val_101 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.StalkingTimers;
            if(val_101 == null)
            {
                goto label_122;
            }
            
            FUNCTIONING val_102 = val_101.Functioning;
            if(val_102 == null)
            {
                goto label_122;
            }
            
            double val_103 = val_102.Max;
            goto label_123;
            label_122:
            label_123:
            this.StalkingTimerMax = (float)0.South;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.AttackProfile) != null)
            {
                goto label_127;
            }
            
            }
            
            label_127:
            this.AttackProfile = System.String.alignConst;
            var val_106 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    ARTASSETS val_107 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.ArtAssets;
                if(val_107 != null)
            {
                    AUDIO val_108 = val_107.Audio;
                if(val_108 != null)
            {
                    if(val_108.SoundBank != null)
            {
                goto label_131;
            }
            
            }
            
            }
            
            }
            
            label_131:
            mem2[0] = System.String.alignConst;
            var val_110 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    ARTASSETS val_111 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.ArtAssets;
                if(val_111 != null)
            {
                    UIASSETS val_112 = val_111.UI;
                if(val_112 != null)
            {
                    if(val_112.CpuIcon != null)
            {
                goto label_136;
            }
            
            }
            
            }
            
            }
            
            label_136:
            mem2[0] = System.String.alignConst;
            var val_114 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    ARTASSETS val_115 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.ArtAssets;
                if(val_115 != null)
            {
                    UIASSETS val_116 = val_115.UI;
                if(val_116 != null)
            {
                    if(val_116.CpuIconFlat != null)
            {
                goto label_141;
            }
            
            }
            
            }
            
            }
            
            label_141:
            mem2[0] = System.String.alignConst;
            var val_118 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (this);
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    ARTASSETS val_119 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.ArtAssets;
                if(val_119 != null)
            {
                    UIASSETS val_120 = val_119.UI;
                if(val_120 != null)
            {
                    if(val_120.CpuSilhouetteIcon != null)
            {
                goto label_146;
            }
            
            }
            
            }
            
            }
            
            label_146:
            mem2[0] = System.String.alignConst;
            this.WanderingAnimatronicRewards = new Game.ItemDefinition.Data.DataDefinitions.RewardDropData();
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_151;
            }
            
            REWARDS val_124 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            var val_125 = (val_124 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (Game.ItemDefinition.Data.DataDefinitions.RewardDropData)[1152921525305311424].Currency);
            if(val_124 == null)
            {
                goto label_151;
            }
            
            WANDERINGANIMATRONICS val_126 = val_124.WanderingAnimatronics;
            if(val_126 == null)
            {
                goto label_151;
            }
            
            PARTS val_127 = val_126.Parts;
            if(val_127 == null)
            {
                goto label_392;
            }
            
            double val_128 = val_127.Min;
            goto label_392;
            label_151:
            label_392:
            (Game.ItemDefinition.Data.DataDefinitions.RewardDropData)[1152921525305311424].Currency.PartsMin = (int)0.South;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_159;
            }
            
            REWARDS val_131 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            var val_132 = (val_131 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.WanderingAnimatronicRewards.Currency);
            if(val_131 == null)
            {
                goto label_159;
            }
            
            WANDERINGANIMATRONICS val_133 = val_131.WanderingAnimatronics;
            if(val_133 == null)
            {
                goto label_159;
            }
            
            PARTS val_134 = val_133.Parts;
            if(val_134 == null)
            {
                goto label_393;
            }
            
            double val_135 = val_134.Max;
            goto label_393;
            label_159:
            label_393:
            this.WanderingAnimatronicRewards.Currency.PartsMax = (int)0.South;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_167;
            }
            
            REWARDS val_138 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            var val_139 = (val_138 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.WanderingAnimatronicRewards.Currency);
            if(val_138 == null)
            {
                goto label_167;
            }
            
            WANDERINGANIMATRONICS val_140 = val_138.WanderingAnimatronics;
            if(val_140 == null)
            {
                goto label_167;
            }
            
            ESSENCE val_141 = val_140.Essence;
            if(val_141 == null)
            {
                goto label_394;
            }
            
            double val_142 = val_141.Min;
            goto label_394;
            label_167:
            label_394:
            this.WanderingAnimatronicRewards.Currency.EssenceMin = (int)0.South;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_175;
            }
            
            REWARDS val_145 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            var val_146 = (val_145 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.WanderingAnimatronicRewards.Currency);
            if(val_145 == null)
            {
                goto label_175;
            }
            
            WANDERINGANIMATRONICS val_147 = val_145.WanderingAnimatronics;
            if(val_147 == null)
            {
                goto label_175;
            }
            
            ESSENCE val_148 = val_147.Essence;
            if(val_148 == null)
            {
                goto label_395;
            }
            
            double val_149 = val_148.Max;
            goto label_395;
            label_175:
            label_395:
            this.WanderingAnimatronicRewards.Currency.EssenceMax = (int)0.South;
            var val_151 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.WanderingAnimatronicRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_183;
            }
            
            REWARDS val_152 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_152 == null)
            {
                goto label_183;
            }
            
            WANDERINGANIMATRONICS val_153 = val_152.WanderingAnimatronics;
            if(val_153 == null)
            {
                goto label_183;
            }
            
            double val_154 = val_153.PlushSuitDropChance;
            goto label_184;
            label_183:
            label_184:
            this.WanderingAnimatronicRewards.Items.PlushSuitDropChance = (float)0.South;
            var val_156 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.WanderingAnimatronicRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_190;
            }
            
            REWARDS val_157 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_157 == null)
            {
                goto label_190;
            }
            
            WANDERINGANIMATRONICS val_158 = val_157.WanderingAnimatronics;
            if(val_158 == null)
            {
                goto label_190;
            }
            
            double val_159 = val_158.CPUDropChance;
            goto label_191;
            label_190:
            label_191:
            this.WanderingAnimatronicRewards.Items.CPUDropChance = (float)0.South;
            var val_161 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.WanderingAnimatronicRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_197;
            }
            
            REWARDS val_162 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_162 == null)
            {
                goto label_197;
            }
            
            WANDERINGANIMATRONICS val_163 = val_162.WanderingAnimatronics;
            if(val_163 == null)
            {
                goto label_197;
            }
            
            double val_164 = val_163.ModDropChance;
            goto label_198;
            label_197:
            label_198:
            this.WanderingAnimatronicRewards.Items.ModDropChance = (float)0.South;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_204;
            }
            
            REWARDS val_167 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            var val_168 = (val_167 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : this.WanderingAnimatronicRewards.Penalty);
            if(val_167 == null)
            {
                goto label_204;
            }
            
            WANDERINGANIMATRONICS val_169 = val_167.WanderingAnimatronics;
            if(val_169 == null)
            {
                goto label_204;
            }
            
            ESSENCEONLOSE val_170 = val_169.EssenceOnLose;
            if(val_170 == null)
            {
                goto label_396;
            }
            
            double val_171 = val_170.Min;
            goto label_396;
            label_204:
            label_396:
            this.WanderingAnimatronicRewards.Penalty.EssenceMin = (int)0.South;
            val_327 = this.WanderingAnimatronicRewards.Penalty;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_212;
            }
            
            REWARDS val_174 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_174 == null)
            {
                goto label_212;
            }
            
            WANDERINGANIMATRONICS val_176 = val_174.WanderingAnimatronics;
            if(val_176 == null)
            {
                goto label_212;
            }
            
            ESSENCEONLOSE val_177 = val_176.EssenceOnLose;
            if(val_177 == null)
            {
                goto label_397;
            }
            
            double val_178 = val_177.Max;
            val_327 = (val_174 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_327));
            goto label_397;
            label_212:
            label_397:
            val_328 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_328 = 0.South;
            }
            
            this.WanderingAnimatronicRewards.Penalty.EssenceMax = (int)val_328;
            this.PVPTargetRewards = new Game.ItemDefinition.Data.DataDefinitions.RewardDropData();
            val_329 = (Game.ItemDefinition.Data.DataDefinitions.RewardDropData)[1152921525305520320].Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_220;
            }
            
            REWARDS val_182 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_182 == null)
            {
                goto label_220;
            }
            
            PVPANIMATRONICSVICTIM val_184 = val_182.PvPAnimatronicsVictim;
            if(val_184 == null)
            {
                goto label_220;
            }
            
            PARTS val_185 = val_184.Parts;
            if(val_185 == null)
            {
                goto label_398;
            }
            
            double val_186 = val_185.Min;
            val_329 = (val_182 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_329));
            goto label_398;
            label_220:
            label_398:
            val_330 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_330 = 0.South;
            }
            
            (Game.ItemDefinition.Data.DataDefinitions.RewardDropData)[1152921525305520320].Currency.PartsMin = (int)val_330;
            val_331 = this.PVPTargetRewards.Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_228;
            }
            
            REWARDS val_189 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_189 == null)
            {
                goto label_228;
            }
            
            PVPANIMATRONICSVICTIM val_191 = val_189.PvPAnimatronicsVictim;
            if(val_191 == null)
            {
                goto label_228;
            }
            
            PARTS val_192 = val_191.Parts;
            if(val_192 == null)
            {
                goto label_399;
            }
            
            double val_193 = val_192.Max;
            val_331 = (val_189 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_331));
            goto label_399;
            label_228:
            label_399:
            val_332 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_332 = 0.South;
            }
            
            this.PVPTargetRewards.Currency.PartsMax = (int)val_332;
            val_333 = this.PVPTargetRewards.Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_236;
            }
            
            REWARDS val_196 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_196 == null)
            {
                goto label_236;
            }
            
            PVPANIMATRONICSVICTIM val_198 = val_196.PvPAnimatronicsVictim;
            if(val_198 == null)
            {
                goto label_236;
            }
            
            ESSENCE val_199 = val_198.Essence;
            if(val_199 == null)
            {
                goto label_400;
            }
            
            double val_200 = val_199.Min;
            val_333 = (val_196 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_333));
            goto label_400;
            label_236:
            label_400:
            val_334 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_334 = 0.South;
            }
            
            this.PVPTargetRewards.Currency.EssenceMin = (int)val_334;
            val_335 = this.PVPTargetRewards.Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_244;
            }
            
            REWARDS val_203 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_203 == null)
            {
                goto label_244;
            }
            
            PVPANIMATRONICSVICTIM val_205 = val_203.PvPAnimatronicsVictim;
            if(val_205 == null)
            {
                goto label_244;
            }
            
            ESSENCE val_206 = val_205.Essence;
            if(val_206 == null)
            {
                goto label_401;
            }
            
            double val_207 = val_206.Max;
            val_335 = (val_203 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_335));
            goto label_401;
            label_244:
            label_401:
            val_336 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_336 = 0.South;
            }
            
            this.PVPTargetRewards.Currency.EssenceMax = (int)val_336;
            val_337 = this.PVPTargetRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_252;
            }
            
            REWARDS val_210 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_210 == null)
            {
                goto label_252;
            }
            
            PVPANIMATRONICSVICTIM val_211 = val_210.PvPAnimatronicsVictim;
            if(val_211 == null)
            {
                goto label_252;
            }
            
            double val_212 = val_211.PlushSuitDropChance;
            val_337 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_337);
            goto label_253;
            label_252:
            label_253:
            val_338 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_338 = 0.South;
            }
            
            this.PVPTargetRewards.Items.PlushSuitDropChance = (float)val_338;
            val_339 = this.PVPTargetRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_259;
            }
            
            REWARDS val_215 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_215 == null)
            {
                goto label_259;
            }
            
            PVPANIMATRONICSVICTIM val_216 = val_215.PvPAnimatronicsVictim;
            if(val_216 == null)
            {
                goto label_259;
            }
            
            double val_217 = val_216.CPUDropChance;
            val_339 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_339);
            goto label_260;
            label_259:
            label_260:
            val_340 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_340 = 0.South;
            }
            
            this.PVPTargetRewards.Items.CPUDropChance = (float)val_340;
            val_341 = this.PVPTargetRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_266;
            }
            
            REWARDS val_220 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_220 == null)
            {
                goto label_266;
            }
            
            PVPANIMATRONICSVICTIM val_221 = val_220.PvPAnimatronicsVictim;
            if(val_221 == null)
            {
                goto label_266;
            }
            
            double val_222 = val_221.ModDropChance;
            val_341 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_341);
            goto label_267;
            label_266:
            label_267:
            val_342 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_342 = 0.South;
            }
            
            this.PVPTargetRewards.Items.ModDropChance = (float)val_342;
            val_343 = this.PVPTargetRewards.Penalty;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_273;
            }
            
            REWARDS val_225 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_225 == null)
            {
                goto label_273;
            }
            
            PVPANIMATRONICSVICTIM val_227 = val_225.PvPAnimatronicsVictim;
            if(val_227 == null)
            {
                goto label_273;
            }
            
            ESSENCEONLOSE val_228 = val_227.EssenceOnLose;
            if(val_228 == null)
            {
                goto label_402;
            }
            
            double val_229 = val_228.Min;
            val_343 = (val_225 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_343));
            goto label_402;
            label_273:
            label_402:
            val_344 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_344 = 0.South;
            }
            
            this.PVPTargetRewards.Penalty.EssenceMin = (int)val_344;
            val_345 = this.PVPTargetRewards.Penalty;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_281;
            }
            
            REWARDS val_232 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_232 == null)
            {
                goto label_281;
            }
            
            PVPANIMATRONICSVICTIM val_234 = val_232.PvPAnimatronicsVictim;
            if(val_234 == null)
            {
                goto label_281;
            }
            
            ESSENCEONLOSE val_235 = val_234.EssenceOnLose;
            if(val_235 == null)
            {
                goto label_403;
            }
            
            double val_236 = val_235.Max;
            val_345 = (val_232 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_345));
            goto label_403;
            label_281:
            label_403:
            val_346 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_346 = 0.South;
            }
            
            this.PVPTargetRewards.Penalty.EssenceMax = (int)val_346;
            this.RampageRewards = new Game.ItemDefinition.Data.DataDefinitions.RewardDropData();
            val_347 = (Game.ItemDefinition.Data.DataDefinitions.RewardDropData)[1152921525305729216].Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_289;
            }
            
            REWARDS val_240 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_240 == null)
            {
                goto label_289;
            }
            
            RAMPAGINGANIMATRONICS val_242 = val_240.RampagingAnimatronics;
            if(val_242 == null)
            {
                goto label_289;
            }
            
            PARTS val_243 = val_242.Parts;
            if(val_243 == null)
            {
                goto label_404;
            }
            
            double val_244 = val_243.Min;
            val_347 = (val_240 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_347));
            goto label_404;
            label_289:
            label_404:
            val_348 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_348 = 0.South;
            }
            
            (Game.ItemDefinition.Data.DataDefinitions.RewardDropData)[1152921525305729216].Currency.PartsMin = (int)val_348;
            val_349 = this.RampageRewards.Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_297;
            }
            
            REWARDS val_247 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_247 == null)
            {
                goto label_297;
            }
            
            RAMPAGINGANIMATRONICS val_249 = val_247.RampagingAnimatronics;
            if(val_249 == null)
            {
                goto label_297;
            }
            
            PARTS val_250 = val_249.Parts;
            if(val_250 == null)
            {
                goto label_405;
            }
            
            double val_251 = val_250.Max;
            val_349 = (val_247 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_349));
            goto label_405;
            label_297:
            label_405:
            val_350 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_350 = 0.South;
            }
            
            this.RampageRewards.Currency.PartsMax = (int)val_350;
            val_351 = this.RampageRewards.Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_305;
            }
            
            REWARDS val_254 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_254 == null)
            {
                goto label_305;
            }
            
            RAMPAGINGANIMATRONICS val_256 = val_254.RampagingAnimatronics;
            if(val_256 == null)
            {
                goto label_305;
            }
            
            ESSENCE val_257 = val_256.Essence;
            if(val_257 == null)
            {
                goto label_406;
            }
            
            double val_258 = val_257.Min;
            val_351 = (val_254 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_351));
            goto label_406;
            label_305:
            label_406:
            val_352 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_352 = 0.South;
            }
            
            this.RampageRewards.Currency.EssenceMin = (int)val_352;
            val_353 = this.RampageRewards.Currency;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_313;
            }
            
            REWARDS val_261 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_261 == null)
            {
                goto label_313;
            }
            
            RAMPAGINGANIMATRONICS val_263 = val_261.RampagingAnimatronics;
            if(val_263 == null)
            {
                goto label_313;
            }
            
            ESSENCE val_264 = val_263.Essence;
            if(val_264 == null)
            {
                goto label_407;
            }
            
            double val_265 = val_264.Max;
            val_353 = (val_261 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_353));
            goto label_407;
            label_313:
            label_407:
            val_354 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_354 = 0.South;
            }
            
            this.RampageRewards.Currency.EssenceMax = (int)val_354;
            val_355 = this.RampageRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_321;
            }
            
            REWARDS val_268 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_268 == null)
            {
                goto label_321;
            }
            
            RAMPAGINGANIMATRONICS val_269 = val_268.RampagingAnimatronics;
            if(val_269 == null)
            {
                goto label_321;
            }
            
            double val_270 = val_269.PlushSuitDropChance;
            val_355 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_355);
            goto label_322;
            label_321:
            label_322:
            val_356 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_356 = 0.South;
            }
            
            this.RampageRewards.Items.PlushSuitDropChance = (float)val_356;
            val_357 = this.RampageRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_328;
            }
            
            REWARDS val_273 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_273 == null)
            {
                goto label_328;
            }
            
            RAMPAGINGANIMATRONICS val_274 = val_273.RampagingAnimatronics;
            if(val_274 == null)
            {
                goto label_328;
            }
            
            double val_275 = val_274.CPUDropChance;
            val_357 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_357);
            goto label_329;
            label_328:
            label_329:
            val_358 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_358 = 0.South;
            }
            
            this.RampageRewards.Items.CPUDropChance = (float)val_358;
            val_359 = this.RampageRewards.Items;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_335;
            }
            
            REWARDS val_278 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_278 == null)
            {
                goto label_335;
            }
            
            RAMPAGINGANIMATRONICS val_279 = val_278.RampagingAnimatronics;
            if(val_279 == null)
            {
                goto label_335;
            }
            
            double val_280 = val_279.ModDropChance;
            val_359 = (((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_359);
            goto label_336;
            label_335:
            label_336:
            val_360 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_360 = 0.South;
            }
            
            this.RampageRewards.Items.ModDropChance = (float)val_360;
            val_361 = this.RampageRewards.Penalty;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_342;
            }
            
            REWARDS val_283 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_283 == null)
            {
                goto label_342;
            }
            
            RAMPAGINGANIMATRONICS val_285 = val_283.RampagingAnimatronics;
            if(val_285 == null)
            {
                goto label_342;
            }
            
            ESSENCEONLOSE val_286 = val_285.EssenceOnLose;
            if(val_286 == null)
            {
                goto label_408;
            }
            
            double val_287 = val_286.Min;
            val_361 = (val_283 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_361));
            goto label_408;
            label_342:
            label_408:
            val_362 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_362 = 0.South;
            }
            
            this.RampageRewards.Penalty.EssenceMin = (int)val_362;
            val_363 = this.RampageRewards.Penalty;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_350;
            }
            
            REWARDS val_290 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_290 == null)
            {
                goto label_350;
            }
            
            RAMPAGINGANIMATRONICS val_292 = val_290.RampagingAnimatronics;
            if(val_292 == null)
            {
                goto label_350;
            }
            
            ESSENCEONLOSE val_293 = val_292.EssenceOnLose;
            if(val_293 == null)
            {
                goto label_409;
            }
            
            double val_294 = val_293.Max;
            val_363 = (val_290 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_363));
            goto label_409;
            label_350:
            label_409:
            val_364 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_364 = 0.South;
            }
            
            this.RampageRewards.Penalty.EssenceMax = (int)val_364;
            Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop val_296 = null;
            val_365 = val_296;
            val_296 = new Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop();
            this.PVPAggressorRewards = val_365;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_357;
            }
            
            REWARDS val_298 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_298 == null)
            {
                goto label_357;
            }
            
            PVPANIMATRONICSAGGRESSOR val_300 = val_298.PvPAnimatronicsAggressor;
            if(val_300 == null)
            {
                goto label_357;
            }
            
            PARTS val_301 = val_300.Parts;
            if(val_301 == null)
            {
                goto label_410;
            }
            
            double val_302 = val_301.Min;
            val_365 = (val_298 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_365));
            goto label_410;
            label_357:
            label_410:
            val_366 = 0;
            if(((-776842128) & 1) != 0)
            {
                    val_366 = 0.South;
            }
            
            .PartsMin = (int)val_366;
            val_367 = this.PVPAggressorRewards;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_364;
            }
            
            REWARDS val_305 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_305 == null)
            {
                goto label_364;
            }
            
            PVPANIMATRONICSAGGRESSOR val_307 = val_305.PvPAnimatronicsAggressor;
            if(val_307 == null)
            {
                goto label_364;
            }
            
            PARTS val_308 = val_307.Parts;
            if(val_308 == null)
            {
                goto label_411;
            }
            
            double val_309 = val_308.Max;
            val_367 = (val_305 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_367));
            goto label_411;
            label_364:
            label_411:
            if(((-776842128) & 1) == 0)
            {
                goto label_367;
            }
            
            val_368 = (int)0.South;
            if(val_367 != null)
            {
                goto label_370;
            }
            
            goto label_369;
            label_367:
            val_368 = 0;
            if(val_367 != null)
            {
                goto label_370;
            }
            
            label_369:
            label_370:
            this.PVPAggressorRewards.PartsMax = val_368;
            val_369 = this.PVPAggressorRewards;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_373;
            }
            
            REWARDS val_312 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_312 == null)
            {
                goto label_373;
            }
            
            PVPANIMATRONICSAGGRESSOR val_314 = val_312.PvPAnimatronicsAggressor;
            if(val_314 == null)
            {
                goto label_373;
            }
            
            ESSENCE val_315 = val_314.Essence;
            if(val_315 == null)
            {
                goto label_412;
            }
            
            double val_316 = val_315.Min;
            val_369 = (val_312 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_369));
            goto label_412;
            label_373:
            label_412:
            if(((-776842128) & 1) == 0)
            {
                goto label_376;
            }
            
            val_370 = (int)0.South;
            if(val_369 != null)
            {
                goto label_379;
            }
            
            goto label_378;
            label_376:
            val_370 = 0;
            if(val_369 != null)
            {
                goto label_379;
            }
            
            label_378:
            label_379:
            this.PVPAggressorRewards.EssenceMin = val_370;
            val_371 = this.PVPAggressorRewards;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == null)
            {
                goto label_382;
            }
            
            REWARDS val_319 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.Rewards;
            if(val_319 == null)
            {
                goto label_382;
            }
            
            PVPANIMATRONICSAGGRESSOR val_321 = val_319.PvPAnimatronicsAggressor;
            if(val_321 == null)
            {
                goto label_382;
            }
            
            ESSENCE val_322 = val_321.Essence;
            if(val_322 == null)
            {
                goto label_413;
            }
            
            double val_323 = val_322.Max;
            val_371 = (val_319 == 0) ? 0 : ((((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) == 0) ? 0 : (val_371));
            goto label_413;
            label_382:
            label_413:
            if(((-776842128) & 1) == 0)
            {
                goto label_385;
            }
            
            val_372 = (int)0.South;
            if(val_371 != null)
            {
                goto label_388;
            }
            
            goto label_387;
            label_385:
            val_372 = 0;
            if(val_371 != null)
            {
                goto label_388;
            }
            
            label_387:
            label_388:
            this.PVPAggressorRewards.EssenceMax = val_372;
            if(((CPUData.<>c__DisplayClass38_0)[1152921525304889536].data) != null)
            {
                    ATTACKLOCALIZATION val_325 = (CPUData.<>c__DisplayClass38_0)[1152921525304889536].data.AttackLocalization;
                if(val_325 != null)
            {
                    if(val_325.LossText != null)
            {
                goto label_391;
            }
            
            }
            
            }
            
            val_373 = System.String.alignConst;
            label_391:
            this.LossTextKey = val_373;
        }
    
    }

}
