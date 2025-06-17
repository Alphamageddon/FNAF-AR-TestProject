using UnityEngine;

namespace Game.StoreDomain.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ACTIVE = "State_Active";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string YES = "Yes";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NameRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DescriptionRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StoreSection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Order;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ArtRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DialogArtRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BadgeArtRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BadgeLocRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Live;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Repeatable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Subscription;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreItem> Items;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<TheGame.Currency.CurrencyType> ValidCurrencies;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreData(ProtoData.STORE_DATA.Types.ENTRY entry)
        {
            int val_26;
            int val_27;
            StoreData.<>c__DisplayClass18_0 val_1 = new StoreData.<>c__DisplayClass18_0();
            .entry = entry;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            this.Id = (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.PurchasableLogical;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void StoreData.<>c__DisplayClass18_0::<.ctor>b__0(Game.Localization.ILocalization localization)));
            string val_6 = (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.Description;
            this.Description = (val_6 == null) ? "Description Missing" : (val_6);
            this.StoreSection = (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.StoreSection;
            this.Order = (int)(StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.Order;
            this.ArtRef = (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.ArtRef;
            this.DialogArtRef = (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.DialogArtRef;
            if(((StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry) != null)
            {
                    BADGE val_12 = (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.Badge;
                if(val_12 != null)
            {
                    if(val_12.BadgeArtRef != null)
            {
                goto label_14;
            }
            
            }
            
            }
            
            val_26 = System.String.alignConst;
            label_14:
            this.BadgeArtRef = val_26;
            if(((StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry) != null)
            {
                    BADGE val_14 = (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.Badge;
                if(val_14 != null)
            {
                    if(val_14.BadgeLocRef != null)
            {
                goto label_17;
            }
            
            }
            
            }
            
            val_27 = System.String.alignConst;
            label_17:
            this.BadgeLocRef = val_27;
            this.Live = System.String.op_Equality(a:  (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.LiveState, b:  "State_Active");
            this.Repeatable = System.String.op_Equality(a:  (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.Repeatable, b:  "Yes");
            this.Subscription = System.String.op_Equality(a:  (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.Subscription, b:  "Yes");
            this.GetItemsFromContents(contents:  (StoreData.<>c__DisplayClass18_0)[1152921525134093920].entry.Contents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetItemsFromContents(ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS contents)
        {
            this.Items = new System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreItem>();
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item1);
            }
            else
            {
                    this.AddNewItem(item:  0.Item1);
            }
            
            this.AddNewItem(item:  contents.Item2);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item3);
            }
            else
            {
                    this.AddNewItem(item:  0.Item3);
            }
            
            this.AddNewItem(item:  contents.Item4);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item5);
            }
            else
            {
                    this.AddNewItem(item:  0.Item5);
            }
            
            this.AddNewItem(item:  contents.Item6);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item7);
            }
            else
            {
                    this.AddNewItem(item:  0.Item7);
            }
            
            this.AddNewItem(item:  contents.Item8);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item9);
            }
            else
            {
                    this.AddNewItem(item:  0.Item9);
            }
            
            this.AddNewItem(item:  contents.Item10);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item11);
            }
            else
            {
                    this.AddNewItem(item:  0.Item11);
            }
            
            this.AddNewItem(item:  contents.Item12);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item13);
            }
            else
            {
                    this.AddNewItem(item:  0.Item13);
            }
            
            this.AddNewItem(item:  contents.Item14);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item15);
            }
            else
            {
                    this.AddNewItem(item:  0.Item15);
            }
            
            this.AddNewItem(item:  contents.Item16);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item17);
            }
            else
            {
                    this.AddNewItem(item:  0.Item17);
            }
            
            this.AddNewItem(item:  contents.Item18);
            if(contents != null)
            {
                    this.AddNewItem(item:  contents.Item19);
            }
            else
            {
                    this.AddNewItem(item:  0.Item19);
            }
            
            this.AddNewItem(item:  contents.Item20);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddNewItem(ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM item)
        {
            if(item == null)
            {
                    return;
            }
            
            .Id = item.Logical;
            .Type = item.Type;
            .Quantity = (int)item.Qty;
            this.Items.Add(item:  new Game.StoreDomain.Data.DataDefinitions.StoreItem());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GenerateDescription()
        {
            object val_5;
            var val_6;
            val_5 = "";
            val_6 = 0;
            goto label_1;
            label_23:
            Game.StoreDomain.Data.DataDefinitions.StoreItem val_1 = this.Items.Item[0];
            object[] val_2 = new object[5];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if("" != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            label_4:
            label_7:
            val_2[0] = val_5;
            val_2[1] = val_1.Id;
            val_2[2] = " x";
            val_2[3] = val_1.Quantity;
            val_2[4] = "\n";
            val_5 = +val_2;
            val_6 = 1;
            label_1:
            if(val_6 < this.Items.Count)
            {
                goto label_23;
            }
            
            return (string)val_5;
        }
    
    }

}
