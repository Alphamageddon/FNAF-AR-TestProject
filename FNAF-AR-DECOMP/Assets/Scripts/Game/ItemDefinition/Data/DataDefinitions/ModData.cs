using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CAPITAL_LETTERS_AFTER_FIRST = "(?<!^)[A-Z]";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SPACE_PLUS_LETTER = " $0";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.ModType Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.ModCategory Category;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CategoryString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CategoryStringLocalized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.ModEffect> Effects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double BreakageChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double DropWeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double PartsBuyback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ModIconName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ModIconRenderedName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ModIconRewardName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Stars;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModData(string id)
        {
            this.Id = id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModData(ProtoData.MODS_DATA.Types.ENTRY entry)
        {
            int val_40;
            int val_41;
            int val_42;
            ModData.<>c__DisplayClass18_0 val_1 = new ModData.<>c__DisplayClass18_0();
            .entry = entry;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            this.Id = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.ModLogical;
            GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void ModData.<>c__DisplayClass18_0::<.ctor>b__0(Game.Localization.ILocalization localization)));
            string val_4 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.ModType;
            this.Type = val_4.GetTypeForString(type:  val_4);
            string val_7 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects.EffectCategory;
            this.CategoryString = val_7;
            Game.ItemDefinition.Data.DataDefinitions.ModCategory val_8 = val_7.GetCategoryForString(category:  val_7);
            this.Category = val_8;
            this.GetModNameLocalized(category:  val_8);
            this.Effects = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.ModEffect>();
            EFFECTS val_12 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects;
            Game.ItemDefinition.Data.DataDefinitions.ModEffect val_14 = val_12.CreateModEffect(type:  (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects.EffectType1, magnitude:  val_12.EffectMag1);
            if(val_14 != null)
            {
                    this.Effects.Add(item:  val_14);
            }
            
            EFFECTS val_17 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects;
            Game.ItemDefinition.Data.DataDefinitions.ModEffect val_19 = val_17.CreateModEffect(type:  (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects.EffectType2, magnitude:  val_17.EffectMag2);
            if(val_19 != null)
            {
                    this.Effects.Add(item:  val_19);
            }
            
            EFFECTS val_22 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects;
            Game.ItemDefinition.Data.DataDefinitions.ModEffect val_24 = val_22.CreateModEffect(type:  (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects.EffectType3, magnitude:  val_22.EffectMag3);
            if(val_24 != null)
            {
                    this.Effects.Add(item:  val_24);
            }
            
            EFFECTS val_27 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects;
            Game.ItemDefinition.Data.DataDefinitions.ModEffect val_29 = val_27.CreateModEffect(type:  (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Effects.EffectType4, magnitude:  val_27.EffectMag4);
            if(val_29 != null)
            {
                    this.Effects.Add(item:  val_29);
            }
            
            this.BreakageChance = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.BreakageChance;
            this.DropWeight = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.DropWeight;
            this.PartsBuyback = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.PartsBuyback;
            ARTASSETS val_33 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.ArtAssets;
            if(val_33 != null)
            {
                    if(val_33.ModIcon != null)
            {
                goto label_40;
            }
            
            }
            
            val_40 = System.String.alignConst;
            label_40:
            this.ModIconName = val_40;
            ARTASSETS val_35 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.ArtAssets;
            if(val_35 != null)
            {
                    if(val_35.ModIconRendered != null)
            {
                goto label_43;
            }
            
            }
            
            val_41 = System.String.alignConst;
            label_43:
            this.ModIconRenderedName = val_41;
            ARTASSETS val_37 = (ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.ArtAssets;
            if(val_37 != null)
            {
                    if(val_37.ModIconReward != null)
            {
                goto label_46;
            }
            
            }
            
            val_42 = System.String.alignConst;
            label_46:
            this.ModIconRewardName = val_42;
            this.Stars = (int)(ModData.<>c__DisplayClass18_0)[1152921525310738688].entry.Stars;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Copy(Game.ItemDefinition.Data.DataDefinitions.ModData copy)
        {
            var val_4;
            if(copy != null)
            {
                    this.Name = copy.Name;
                this.Description = copy.Description;
                this.Type = copy.Type;
            }
            else
            {
                    this.Name = 15026800;
                this.Description = 64;
                this.Type = 69077560;
            }
            
            this.Category = copy.Category;
            this.Effects = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.ModEffect>();
            val_4 = 0;
            goto label_3;
            label_7:
            this.Effects.Add(item:  copy.Effects.Item[0]);
            val_4 = 1;
            label_3:
            if(val_4 < copy.Effects.Count)
            {
                goto label_7;
            }
            
            this.BreakageChance = copy.BreakageChance;
            this.DropWeight = copy.DropWeight;
            this.PartsBuyback = copy.PartsBuyback;
            this.Stars = copy.Stars;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetModNameLocalized(Game.ItemDefinition.Data.DataDefinitions.ModCategory category)
        {
            ModData.<>c__DisplayClass20_0 val_1 = new ModData.<>c__DisplayClass20_0();
            if(val_1 != null)
            {
                    .category = category;
            }
            else
            {
                    mem[16] = category;
            }
            
            .<>4__this = this;
            GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void ModData.<>c__DisplayClass20_0::<GetModNameLocalized>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.ModEffect CreateModEffect(string type, double magnitude)
        {
            if((System.String.IsNullOrEmpty(value:  type)) == true)
            {
                    return (Game.ItemDefinition.Data.DataDefinitions.ModEffect)0;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.ModEffect val_2 = null;
            0 = val_2;
            val_2 = new Game.ItemDefinition.Data.DataDefinitions.ModEffect();
            .Type = type;
            .Magnitude = (float)magnitude;
            return (Game.ItemDefinition.Data.DataDefinitions.ModEffect)0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.ModType GetTypeForString(string type)
        {
            Game.ItemDefinition.Data.DataDefinitions.ModType val_1 = 0;
            bool val_2 = System.Enum.TryParse<Game.ItemDefinition.Data.DataDefinitions.ModType>(value:  type, result: out  val_1);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.ModCategory GetCategoryForString(string category)
        {
            Game.ItemDefinition.Data.DataDefinitions.ModCategory val_1 = 0;
            bool val_2 = System.Enum.TryParse<Game.ItemDefinition.Data.DataDefinitions.ModCategory>(value:  category, result: out  val_1);
            return val_1;
        }
    
    }

}
