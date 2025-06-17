using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardV3Translator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions itemDefinitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.PlayerInventory playerInventory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.CPUInventory cpuInventory;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardV3Translator(Master.MasterDomain masterDomain)
        {
            masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.RewardV3Translator::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            this.itemDefinitions = masterDomain.ItemDefinitionDomain.ItemDefinitions;
            TheGame.Domain val_4 = masterDomain.theGameDomain;
            this.playerInventory = val_4.playerInventory;
            this.cpuInventory = masterDomain.WorkshopDomain.Inventory.CpuInventory;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetEssenceOnLossCellDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            UnityEngine.Sprite val_11;
            string val_13;
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            if(rewardDataV3.essenceOnLoss == 0)
            {
                    return val_1;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_11 = this._iconLookup.GetDefaultIcon();
            if((this.itemDefinitions.GetRewardsDataByCategory(rewardCategory:  0)) != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_11 = this._iconLookup.GetIcon(group:  4, name:  val_5.rewardIconName);
            }
            
            .localizedString = "REMNANT";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  new RewardV3Translator.<>c__DisplayClass6_0(), method:  System.Void RewardV3Translator.<>c__DisplayClass6_0::<GetEssenceOnLossCellDescriptions>b__0(Game.Localization.ILocalization localization)));
            GameUI.ItemUIDescription val_11 = new GameUI.ItemUIDescription();
            if(val_11 != null)
            {
                    .rewardCategory = 0;
                .sprite = val_11;
                .displayName = (RewardV3Translator.<>c__DisplayClass6_0)[1152921524709039184].localizedString;
                val_13 = (RewardV3Translator.<>c__DisplayClass6_0)[1152921524709039184].localizedString;
            }
            else
            {
                    mem[16] = 0;
                mem[24] = val_11;
                val_11 = (RewardV3Translator.<>c__DisplayClass6_0)[1152921524709039184].localizedString;
                mem[40] = val_11;
                val_13 = (RewardV3Translator.<>c__DisplayClass6_0)[1152921524709039184].localizedString;
            }
            
            .typeName = val_13;
            .number = -rewardDataV3.essenceOnLoss;
            val_1.Add(item:  val_11);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetEssenceOnWinDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            var val_4;
            System.Action<T> val_16;
            var val_17;
            object val_18;
            var val_19;
            UnityEngine.Sprite val_21;
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            List.Enumerator<T> val_2 = rewardDataV3.currencyRewardList.GetEnumerator();
            val_16 = 1152921524709175088;
            val_17 = 0;
            goto label_5;
            label_6:
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            bool val_6 = System.String.op_Equality(a:  val_5._masterDomain, b:  "ESSENCE");
            label_5:
            if(((-1372423744) & 1) != 0)
            {
                goto label_6;
            }
            
            val_18 = 0;
            val_19 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524709259712});
            if(null == null)
            {
                    return val_1;
            }
            
            RewardV3Translator.<>c__DisplayClass7_0 val_8 = null;
            val_18 = val_8;
            val_8 = new RewardV3Translator.<>c__DisplayClass7_0();
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_21 = this._iconLookup.GetDefaultIcon();
            if((this.itemDefinitions.GetRewardsDataByCategory(rewardCategory:  0)) != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_21 = this._iconLookup.GetIcon(group:  4, name:  val_11.rewardIconName);
            }
            
            .localizedString = "ESSENCE";
            System.Action<Game.Localization.ILocalization> val_16 = null;
            val_16 = val_16;
            val_16 = new System.Action<Game.Localization.ILocalization>(object:  val_8, method:  System.Void RewardV3Translator.<>c__DisplayClass7_0::<GetEssenceOnWinDescriptions>b__0(Game.Localization.ILocalization localization));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  val_16);
            GameUI.ItemUIDescription val_17 = new GameUI.ItemUIDescription();
            if(val_17 != null)
            {
                    .rewardCategory = 0;
                .sprite = val_21;
                .displayName = (RewardV3Translator.<>c__DisplayClass7_0)[1152921524709328400].localizedString;
                .typeName = (RewardV3Translator.<>c__DisplayClass7_0)[1152921524709328400].localizedString;
            }
            else
            {
                    mem[16] = 0;
                mem[24] = val_21;
                mem[40] = (RewardV3Translator.<>c__DisplayClass7_0)[1152921524709328400].localizedString;
                val_18 = (RewardV3Translator.<>c__DisplayClass7_0)[1152921524709328400].localizedString;
                mem[32] = val_18;
            }
            
            .number = null;
            val_1.Add(item:  val_17);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetPartsCellDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            var val_4;
            System.Action<T> val_16;
            var val_17;
            object val_18;
            var val_19;
            UnityEngine.Sprite val_21;
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            List.Enumerator<T> val_2 = rewardDataV3.currencyRewardList.GetEnumerator();
            val_16 = 1152921524709175088;
            val_17 = 0;
            goto label_5;
            label_6:
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            bool val_6 = System.String.op_Equality(a:  val_5._masterDomain, b:  "PARTS");
            label_5:
            if(((-1372138624) & 1) != 0)
            {
                goto label_6;
            }
            
            val_18 = 0;
            val_19 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524709544832});
            if(null == null)
            {
                    return val_1;
            }
            
            RewardV3Translator.<>c__DisplayClass8_0 val_8 = null;
            val_18 = val_8;
            val_8 = new RewardV3Translator.<>c__DisplayClass8_0();
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_21 = this._iconLookup.GetDefaultIcon();
            if((this.itemDefinitions.GetRewardsDataByCategory(rewardCategory:  1)) != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_21 = this._iconLookup.GetIcon(group:  4, name:  val_11.rewardIconName);
            }
            
            .localizedString = "PARTS";
            System.Action<Game.Localization.ILocalization> val_16 = null;
            val_16 = val_16;
            val_16 = new System.Action<Game.Localization.ILocalization>(object:  val_8, method:  System.Void RewardV3Translator.<>c__DisplayClass8_0::<GetPartsCellDescriptions>b__0(Game.Localization.ILocalization localization));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  val_16);
            GameUI.ItemUIDescription val_17 = new GameUI.ItemUIDescription();
            if(val_17 != null)
            {
                    .rewardCategory = 1;
                .sprite = val_21;
                .displayName = (RewardV3Translator.<>c__DisplayClass8_0)[1152921524709613520].localizedString;
                .typeName = (RewardV3Translator.<>c__DisplayClass8_0)[1152921524709613520].localizedString;
            }
            else
            {
                    mem[16] = 1;
                mem[24] = val_21;
                mem[40] = (RewardV3Translator.<>c__DisplayClass8_0)[1152921524709613520].localizedString;
                val_18 = (RewardV3Translator.<>c__DisplayClass8_0)[1152921524709613520].localizedString;
                mem[32] = val_18;
            }
            
            .number = null;
            val_1.Add(item:  val_17);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetPlushSuitCellDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            var val_6;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            ulong val_31;
            var val_32;
            var val_33;
            GameUI.ItemUIDescription val_34;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_35;
            RewardV3Translator.<>c__DisplayClass9_0 val_36;
            var val_37;
            var val_40;
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            if(rewardDataV3.animatronicRewardTable == null)
            {
                    return val_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = rewardDataV3.animatronicRewardTable.GetEnumerator();
            val_27 = 0;
            val_28 = 0;
            label_57:
            if(((-1371863680) & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_7 = val_6.trackableId;
            if((this.playerInventory.GetPlushSuits().Contains(item:  val_7.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>>::get_Key()))) == true)
            {
                goto label_57;
            }
            
            List.Enumerator<T> val_10 = val_7.m_SubId1.GetEnumerator();
            label_32:
            if(((-1371863728) & 1) == 0)
            {
                goto label_8;
            }
            
            if((System.String.op_Equality(a:  val_11._masterDomain, b:  "PlushSuit")) == false)
            {
                goto label_32;
            }
            
            RewardV3Translator.<>c__DisplayClass9_0 val_13 = new RewardV3Translator.<>c__DisplayClass9_0();
            mem[1152921524709892608] = "PLUSH SUIT";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_13, method:  System.Void RewardV3Translator.<>c__DisplayClass9_0::<GetPlushSuitCellDescriptions>b__0(Game.Localization.ILocalization localization)));
            val_29 = mem[1152921524709831936];
            if(val_29 == 0)
            {
                    val_29 = val_29;
            }
            
            var val_28 = val_29;
            if((mem[1152921524709831936] + 286) == 0)
            {
                goto label_15;
            }
            
            var val_26 = mem[1152921524709831936] + 176;
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_17:
            if(((mem[1152921524709831936] + 176 + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < (mem[1152921524709831936] + 286))
            {
                goto label_17;
            }
            
            label_15:
            val_29 = val_29;
            goto label_18;
            label_16:
            val_28 = val_28 + (((mem[1152921524709831936] + 176 + 8)) << 4);
            val_30 = val_28 + 296;
            label_18:
            UnityEngine.Sprite val_17 = val_29.GetDefaultIcon();
            val_31 = val_7.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>>::get_Key());
            if(mem[1152921524709831944] == 0)
            {
                    val_31 = val_31;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_19 = mem[1152921524709831944].GetPlushSuitById(id:  val_31);
            if(val_19 == null)
            {
                goto label_20;
            }
            
            val_32 = mem[1152921524709831936];
            if(val_32 == 0)
            {
                    val_32 = val_32;
            }
            
            var val_32 = val_32;
            if((mem[1152921524709831936] + 286) == 0)
            {
                goto label_22;
            }
            
            var val_29 = mem[1152921524709831936] + 176;
            var val_30 = 0;
            val_29 = val_29 + 8;
            label_24:
            if(((mem[1152921524709831936] + 176 + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_30 = val_30 + 1;
            val_29 = val_29 + 16;
            if(val_30 < (mem[1152921524709831936] + 286))
            {
                goto label_24;
            }
            
            label_22:
            val_32 = val_32;
            goto label_25;
            label_23:
            var val_31 = val_29;
            val_31 = val_31 + 1;
            val_32 = val_32 + val_31;
            val_33 = val_32 + 296;
            label_25:
            label_20:
            GameUI.ItemUIDescription val_21 = new GameUI.ItemUIDescription();
            val_34 = val_21;
            if(val_34 != 0)
            {
                    mem[1152921524709925408] = 2;
            }
            else
            {
                    mem[16] = 2;
                val_34 = val_21;
            }
            
            mem[1152921524709925416] = val_32.GetIcon(group:  2, name:  val_19.PlushSuitIconName);
            val_35 = val_19;
            if(val_35 != 0)
            {
                    val_34 = val_21;
            }
            
            mem[1152921524709925432] = val_35.AnimatronicName;
            val_36 = val_13;
            if(val_36 == 0)
            {
                    val_34 = val_21;
                val_36 = val_13;
            }
            
            mem[1152921524709925424] = mem[1152921524709892608];
            if(val_6.emailUIDataHandler == null)
            {
                    val_34 = val_21;
            }
            
            mem[1152921524709925440] = val_11._serverGameUIDataModel;
            if(val_1 == null)
            {
                    val_34 = val_21;
            }
            
            val_1.Add(item:  val_21);
            goto label_32;
            label_8:
            val_37 = val_28;
            long val_23 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524709819728});
            if((((327 == 0) ? 327 : 327) == 327) || ( == 0))
            {
                goto label_57;
            }
            
            goto label_57;
            label_4:
            val_40 = 355;
            long val_25 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524709819776});
            if( == 0)
            {
                    return val_1;
            }
            
            if( == 0)
            {
                    return val_1;
            }
            
            if( == 355)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetCPUCellDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            var val_4;
            string val_21;
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            List.Enumerator<T> val_2 = rewardDataV3.cpuRewardList.GetEnumerator();
            do
            {
                label_31:
                if(((-1371586656) & 1) == 0)
            {
                    return val_1;
            }
            
                GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
                new RewardV3Translator.<>c__DisplayClass10_0() = new System.Object();
            }
            while((this.cpuInventory.entries.ContainsKey(key:  val_5._masterDomain)) == true);
            
            .localizedTypeString = "CPU";
            System.Action<Game.Localization.ILocalization> val_11 = new System.Action<Game.Localization.ILocalization>(object:  new RewardV3Translator.<>c__DisplayClass10_0(), method:  System.Void RewardV3Translator.<>c__DisplayClass10_0::<GetCPUCellDescriptions>b__0(Game.Localization.ILocalization localization));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  null);
            var val_21 = 0;
            val_21 = val_21 + 1;
            UnityEngine.Sprite val_13 = this._iconLookup.GetDefaultIcon();
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_14 = this.itemDefinitions.GetCPUById(id:  val_5._masterDomain);
            if(val_14 != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
            }
            
            new GameUI.ItemUIDescription() = new GameUI.ItemUIDescription();
            if(new GameUI.ItemUIDescription() != null)
            {
                    .rewardCategory = 3;
            }
            else
            {
                    mem[16] = 3;
            }
            
            .sprite = this._iconLookup.GetIcon(group:  0, name:  val_14.CpuIconName);
            if(val_14 != null)
            {
                    string val_18 = val_14.AnimatronicName;
            }
            else
            {
                    val_21 = 0;
            }
            
            .displayName = val_21;
            .typeName = (RewardV3Translator.<>c__DisplayClass10_0)[1152921524710157312].localizedTypeString;
            .number = val_5._serverGameUIDataModel;
            val_1.Add(item:  new GameUI.ItemUIDescription());
            goto label_31;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetModCellDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            var val_4;
            System.Collections.Generic.List<T> val_16;
            var val_17;
            UnityEngine.Sprite val_18;
            var val_19;
            string val_20;
            int val_21;
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = null;
            val_16 = val_1;
            val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            List.Enumerator<T> val_2 = rewardDataV3.modRewardList.GetEnumerator();
            label_29:
            if(((-1371301456) & 1) == 0)
            {
                    return (System.Collections.Generic.List<GameUI.ItemUIDescription>)val_16;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            new RewardV3Translator.<>c__DisplayClass11_0() = new System.Object();
            .localizedString = "MOD";
            System.Action<Game.Localization.ILocalization> val_9 = new System.Action<Game.Localization.ILocalization>(object:  new RewardV3Translator.<>c__DisplayClass11_0(), method:  System.Void RewardV3Translator.<>c__DisplayClass11_0::<GetModCellDescriptions>b__0(Game.Localization.ILocalization localization));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  null);
            var val_18 = mem[1152921524710394144];
            if((mem[1152921524710394144] + 286) == 0)
            {
                goto label_11;
            }
            
            var val_16 = mem[1152921524710394144] + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_10:
            if(((mem[1152921524710394144] + 176 + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (mem[1152921524710394144] + 286))
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            val_18 = val_18 + (((mem[1152921524710394144] + 176 + 8)) << 4);
            val_17 = val_18 + 296;
            label_11:
            val_18 = mem[1152921524710394144].GetDefaultIcon();
            Game.ItemDefinition.Data.DataDefinitions.ModData val_11 = mem[1152921524710394152].GetModById(id:  val_5._masterDomain);
            if(val_11 == null)
            {
                goto label_14;
            }
            
            var val_22 = mem[1152921524710394144];
            if((mem[1152921524710394144] + 286) == 0)
            {
                goto label_19;
            }
            
            var val_19 = mem[1152921524710394144] + 176;
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_18:
            if(((mem[1152921524710394144] + 176 + 8) + -8) == null)
            {
                goto label_17;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < (mem[1152921524710394144] + 286))
            {
                goto label_18;
            }
            
            goto label_19;
            label_17:
            var val_21 = val_19;
            val_21 = val_21 + 1;
            val_22 = val_22 + val_21;
            val_19 = val_22 + 296;
            label_19:
            val_18 = mem[1152921524710394144].GetIcon(group:  1, name:  val_11.ModIconRewardName);
            label_14:
            new GameUI.ItemUIDescription() = new GameUI.ItemUIDescription();
            if(new GameUI.ItemUIDescription() != null)
            {
                    .rewardCategory = 4;
            }
            else
            {
                    mem[16] = 4;
            }
            
            .sprite = val_18;
            .typeName = (RewardV3Translator.<>c__DisplayClass11_0)[1152921524710442512].localizedString;
            if(val_11 != null)
            {
                    val_20 = val_11.Name;
            }
            else
            {
                    val_20 = 0;
            }
            
            .displayName = val_20;
            .number = val_5._serverGameUIDataModel;
            if(val_11 != null)
            {
                    .description = val_11.Description;
                .categoryName = val_11.CategoryStringLocalized;
                val_21 = val_11.Stars;
            }
            else
            {
                    val_21 = 0;
                .description = 0;
                .categoryName = 0;
            }
            
            .magnitude = val_21;
            val_1.Add(item:  new GameUI.ItemUIDescription());
            goto label_29;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetCoinDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            var val_4;
            System.Action<T> val_16;
            var val_17;
            object val_18;
            var val_19;
            UnityEngine.Sprite val_21;
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            List.Enumerator<T> val_2 = rewardDataV3.currencyRewardList.GetEnumerator();
            val_16 = 1152921524709175088;
            val_17 = 0;
            goto label_5;
            label_6:
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            bool val_6 = System.String.op_Equality(a:  val_5._masterDomain, b:  "FAZ_TOKENS");
            label_5:
            if(((-1371024512) & 1) != 0)
            {
                goto label_6;
            }
            
            val_18 = 0;
            val_19 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524710658944});
            if(null == null)
            {
                    return val_1;
            }
            
            RewardV3Translator.<>c__DisplayClass12_0 val_8 = null;
            val_18 = val_8;
            val_8 = new RewardV3Translator.<>c__DisplayClass12_0();
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_21 = this._iconLookup.GetDefaultIcon();
            if((this.itemDefinitions.GetRewardsDataByCategory(rewardCategory:  5)) != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_21 = this._iconLookup.GetIcon(group:  4, name:  val_11.rewardIconName);
            }
            
            .localizedString = "PARTS";
            System.Action<Game.Localization.ILocalization> val_16 = null;
            val_16 = val_16;
            val_16 = new System.Action<Game.Localization.ILocalization>(object:  val_8, method:  System.Void RewardV3Translator.<>c__DisplayClass12_0::<GetCoinDescriptions>b__0(Game.Localization.ILocalization localization));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  val_16);
            GameUI.ItemUIDescription val_17 = new GameUI.ItemUIDescription();
            if(val_17 != null)
            {
                    .rewardCategory = 1;
                .sprite = val_21;
                .displayName = (RewardV3Translator.<>c__DisplayClass12_0)[1152921524710727632].localizedString;
                .typeName = (RewardV3Translator.<>c__DisplayClass12_0)[1152921524710727632].localizedString;
            }
            else
            {
                    mem[16] = 1;
                mem[24] = val_21;
                mem[40] = (RewardV3Translator.<>c__DisplayClass12_0)[1152921524710727632].localizedString;
                val_18 = (RewardV3Translator.<>c__DisplayClass12_0)[1152921524710727632].localizedString;
                mem[32] = val_18;
            }
            
            .number = null;
            val_1.Add(item:  val_17);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ItemUIDescription GetEndoskeletonSlotRewardDescription()
        {
            string val_7;
            UnityEngine.Sprite val_2 = this.GetSpriteForRewardCategory(category:  6);
            .localizedString = "NEW ENDOSKELETON";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  new RewardV3Translator.<>c__DisplayClass13_0(), method:  System.Void RewardV3Translator.<>c__DisplayClass13_0::<GetEndoskeletonSlotRewardDescription>b__0(Game.Localization.ILocalization localization)));
            GameUI.ItemUIDescription val_6 = new GameUI.ItemUIDescription();
            if(val_6 != null)
            {
                    .rewardCategory = 6;
                .sprite = val_2;
                val_7 = (RewardV3Translator.<>c__DisplayClass13_0)[1152921524710939104].localizedString;
            }
            else
            {
                    mem[16] = 6;
                mem[24] = val_2;
                val_7 = (RewardV3Translator.<>c__DisplayClass13_0)[1152921524710939104].localizedString;
            }
            
            .typeName = val_7;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ItemUIDescription GetModSlotRewardDescription()
        {
            string val_7;
            UnityEngine.Sprite val_2 = this.GetSpriteForRewardCategory(category:  7);
            .localizedString = "MOD SLOT";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  new RewardV3Translator.<>c__DisplayClass14_0(), method:  System.Void RewardV3Translator.<>c__DisplayClass14_0::<GetModSlotRewardDescription>b__0(Game.Localization.ILocalization localization)));
            GameUI.ItemUIDescription val_6 = new GameUI.ItemUIDescription();
            if(val_6 != null)
            {
                    .rewardCategory = 6;
                .sprite = val_2;
                val_7 = (RewardV3Translator.<>c__DisplayClass14_0)[1152921524711117760].localizedString;
            }
            else
            {
                    mem[16] = 6;
                mem[24] = val_2;
                val_7 = (RewardV3Translator.<>c__DisplayClass14_0)[1152921524711117760].localizedString;
            }
            
            .typeName = val_7;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ItemUIDescription GetPartsRewardDescription(int numParts)
        {
            UnityEngine.Sprite val_7 = this.GetSpriteForRewardCategory(category:  1);
            .localizedString = "PARTS";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  new RewardV3Translator.<>c__DisplayClass15_0(), method:  System.Void RewardV3Translator.<>c__DisplayClass15_0::<GetPartsRewardDescription>b__0(Game.Localization.ILocalization localization)));
            GameUI.ItemUIDescription val_6 = new GameUI.ItemUIDescription();
            if(val_6 != null)
            {
                    .rewardCategory = 1;
                .sprite = val_7;
                .displayName = (RewardV3Translator.<>c__DisplayClass15_0)[1152921524711304512].localizedString;
                .typeName = (RewardV3Translator.<>c__DisplayClass15_0)[1152921524711304512].localizedString;
            }
            else
            {
                    mem[16] = 1;
                mem[24] = val_7;
                val_7 = (RewardV3Translator.<>c__DisplayClass15_0)[1152921524711304512].localizedString;
                mem[40] = val_7;
                mem[32] = (RewardV3Translator.<>c__DisplayClass15_0)[1152921524711304512].localizedString;
            }
            
            .number = numParts;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ItemUIDescription> GetAllWinRewardDescriptions(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            System.Collections.Generic.List<GameUI.ItemUIDescription> val_1 = new System.Collections.Generic.List<GameUI.ItemUIDescription>();
            val_1.AddRange(collection:  this.GetPartsCellDescriptions(rewardDataV3:  rewardDataV3));
            val_1.AddRange(collection:  this.GetEssenceOnWinDescriptions(rewardDataV3:  rewardDataV3));
            val_1.AddRange(collection:  this.GetCPUCellDescriptions(rewardDataV3:  rewardDataV3));
            val_1.AddRange(collection:  this.GetModCellDescriptions(rewardDataV3:  rewardDataV3));
            val_1.AddRange(collection:  this.GetPlushSuitCellDescriptions(rewardDataV3:  rewardDataV3));
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Sprite GetSpriteForRewardCategory(Game.ItemDefinition.Container.RewardCategory category)
        {
            Game.AssetManagement.Icons.IIconLookup val_9;
            var val_11;
            Game.AssetManagement.Icons.IconGroup val_13;
            val_9 = this._iconLookup;
            if((this.itemDefinitions.GetRewardsDataByCategory(rewardCategory:  category)) != null)
            {
                    var val_3 = 0;
                val_11 = 1152921505280790536;
                val_3 = val_3 + 1;
                val_11 = 1152921505280790552;
            }
            else
            {
                    val_13 = null;
                var val_4 = 0;
                val_11 = 1152921505280790536;
                val_4 = val_4 + 1;
                return val_9.GetDefaultIcon();
            }
            
            val_9 = ???;
            val_13 = 4;
            return val_9.GetIcon(group:  val_13, name:  val_1.rewardIconName);
        }
    
    }

}
