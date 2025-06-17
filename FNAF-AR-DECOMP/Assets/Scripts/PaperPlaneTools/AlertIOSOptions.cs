using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertIOSOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PaperPlaneTools.AlertIOSButton.Type DefaultPositiveButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PaperPlaneTools.AlertIOSButton.Type DefaultNegativeButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PaperPlaneTools.AlertIOSButton.Type DefaultNeutralButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PaperPlaneTools.Alert.ButtonType DefaultPreferableButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PaperPlaneTools.Alert.ButtonType[] DefaultButtonsAddOrder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertIOSButton.Type <PositiveButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertIOSButton.Type <NegativeButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.AlertIOSButton.Type <NeutralButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert.ButtonType <PreferableButton>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert.ButtonType[] <ButtonsAddOrder>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type PositiveButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type NegativeButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type NeutralButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert.ButtonType PreferableButton { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert.ButtonType[] ButtonsAddOrder { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertIOSOptions()
        {
            null = null;
            this.<PositiveButton>k__BackingField = PaperPlaneTools.AlertIOSOptions.DefaultPositiveButton;
            this.<NegativeButton>k__BackingField = PaperPlaneTools.AlertIOSOptions.DefaultNegativeButton;
            this.<NeutralButton>k__BackingField = PaperPlaneTools.AlertIOSOptions.DefaultNeutralButton;
            this.<PreferableButton>k__BackingField = PaperPlaneTools.AlertIOSOptions.DefaultPreferableButton;
            this.<ButtonsAddOrder>k__BackingField = PaperPlaneTools.AlertIOSOptions.DefaultButtonsAddOrder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type get_PositiveButton()
        {
            return (Type)this.<PositiveButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PositiveButton(PaperPlaneTools.AlertIOSButton.Type value)
        {
            this.<PositiveButton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type get_NegativeButton()
        {
            return (Type)this.<NegativeButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_NegativeButton(PaperPlaneTools.AlertIOSButton.Type value)
        {
            this.<NegativeButton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.AlertIOSButton.Type get_NeutralButton()
        {
            return (Type)this.<NeutralButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_NeutralButton(PaperPlaneTools.AlertIOSButton.Type value)
        {
            this.<NeutralButton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert.ButtonType get_PreferableButton()
        {
            return (ButtonType)this.<PreferableButton>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PreferableButton(PaperPlaneTools.Alert.ButtonType value)
        {
            this.<PreferableButton>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaperPlaneTools.Alert.ButtonType[] get_ButtonsAddOrder()
        {
            return (ButtonType[])this.<ButtonsAddOrder>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ButtonsAddOrder(PaperPlaneTools.Alert.ButtonType[] value)
        {
            this.<ButtonsAddOrder>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AlertIOSOptions()
        {
            int val_2;
            PaperPlaneTools.AlertIOSOptions.DefaultPositiveButton = 0;
            PaperPlaneTools.AlertIOSOptions.DefaultNegativeButton = 0;
            PaperPlaneTools.AlertIOSOptions.DefaultNeutralButton = 0;
            PaperPlaneTools.AlertIOSOptions.DefaultPreferableButton = 0;
            ButtonType[] val_1 = new ButtonType[3];
            val_2 = val_1.Length;
            if(val_2 <= 1)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[0] = 2;
            val_1[1] = 1;
            PaperPlaneTools.AlertIOSOptions.DefaultButtonsAddOrder = val_1;
        }
    
    }

}
