using UnityEngine;

namespace Game.StoreDomain.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreSectionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string DISPLAY_CAROUSEL = "Carousel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string DISPLAY_MAIN = "Main";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string DISPLAY_NONE = "None";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Logical;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.StoreDomain.Data.DataDefinitions.StoreSectionData.DisplayType Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Order;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreSectionData(ProtoData.STORESECTIONS_DATA.Types.ENTRY entry)
        {
            StoreSectionData.<>c__DisplayClass8_0 val_1 = new StoreSectionData.<>c__DisplayClass8_0();
            .entry = entry;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            STORESECTIONS_DATA.Types.ENTRY val_9 = (StoreSectionData.<>c__DisplayClass8_0)[1152921525135350752].entry;
            string val_2 = val_9.Logical;
            val_9 = (val_2 == null) ? "" : (val_2);
            this.Logical = val_9;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void StoreSectionData.<>c__DisplayClass8_0::<.ctor>b__0(Game.Localization.ILocalization localization)));
            string val_6 = (StoreSectionData.<>c__DisplayClass8_0)[1152921525135350752].entry.DisplayType;
            this.Type = val_6.GetDisplayType(raw:  val_6);
            this.Order = (int)(StoreSectionData.<>c__DisplayClass8_0)[1152921525135350752].entry.Order;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.StoreDomain.Data.DataDefinitions.StoreSectionData.DisplayType GetDisplayType(string raw)
        {
            var val_4;
            if((System.String.op_Equality(a:  raw, b:  "Carousel")) == false)
            {
                    return (DisplayType)(((System.String.op_Equality(a:  raw, b:  "Main")) & true) != 0) ? (1 + 1) : 1;
            }
            
            val_4 = 0;
            return (DisplayType)(((System.String.op_Equality(a:  raw, b:  "Main")) & true) != 0) ? (1 + 1) : 1;
        }
    
    }

}
