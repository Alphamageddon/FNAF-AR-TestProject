using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlushSuitData
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
        public readonly bool Enabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string SoundBankName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string AnimatronicAssetBundle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string AnimatronicPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string MapIconPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string PlushSuitIconName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string PortraitIconName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string PortraitIconFlatName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string PlushSuitSilhouetteIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool PlayerAcquirable;
        
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
        public PlushSuitData(ProtoData.PLUSHSUIT_DATA.Types.ENTRY data)
        {
            PLUSHSUIT_DATA.Types.ENTRY val_47;
            string val_48;
            var val_49;
            var val_50;
            var val_51;
            int val_52;
            var val_53;
            int val_54;
            var val_55;
            int val_56;
            var val_57;
            int val_58;
            var val_59;
            int val_60;
            var val_61;
            int val_62;
            var val_63;
            int val_64;
            var val_65;
            int val_66;
            bool val_67;
            PlushSuitData.<>c__DisplayClass17_0 val_1 = new PlushSuitData.<>c__DisplayClass17_0();
            .data = data;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            val_47 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data;
            if(val_47 != null)
            {
                    string val_2 = val_47.Logical;
            }
            
            this.Id = (val_2 == null) ? "" : (val_2);
            GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void PlushSuitData.<>c__DisplayClass17_0::<.ctor>b__0(Game.Localization.ILocalization localization)));
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) != null)
            {
                    ANIMPLAYERFACINGTEXT val_5 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.AnimPlayerFacingText;
                if(val_5 != null)
            {
                    string val_6 = val_5.PlushSuitDescription;
                var val_7 = (val_6 == null) ? "" : (val_6);
                if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) != null)
            {
                    if(this != null)
            {
                goto label_12;
            }
            
            }
            
            }
            
            }
            
            val_48 = "";
            label_12:
            this.Description = val_48;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) != null)
            {
                    double val_8 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.Order;
            }
            
            this.Order = 0;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_16;
            }
            
            STATUS val_9 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.Status;
            if(val_9 == null)
            {
                goto label_16;
            }
            
            LIVESTATE val_10 = val_9.LiveState;
            val_49 = 0;
            goto label_17;
            label_16:
            val_49 = 0;
            label_17:
            if(((-768956600) & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_11 = val_49.region;
            }
            else
            {
                    val_50 = 0;
            }
            
            this.Enabled = (val_50 == 1) ? 1 : 0;
            val_51 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_22;
            }
            
            ARTASSETS val_14 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_51 = this;
            if(val_14 == null)
            {
                goto label_22;
            }
            
            AUDIO val_15 = val_14.Audio;
            val_51 = this;
            if(val_15 == null)
            {
                goto label_22;
            }
            
            val_52 = val_15.SoundBank;
            val_51 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_52 != null)
            {
                goto label_23;
            }
            
            label_22:
            val_52 = System.String.alignConst;
            label_23:
            mem2[0] = val_52;
            val_53 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_27;
            }
            
            ARTASSETS val_18 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_53 = this;
            if(val_18 == null)
            {
                goto label_27;
            }
            
            ANIMATRONIC3D val_19 = val_18.Animatronic3D;
            val_53 = this;
            if(val_19 == null)
            {
                goto label_27;
            }
            
            val_54 = val_19.Bundle;
            val_53 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_54 != null)
            {
                goto label_28;
            }
            
            label_27:
            val_54 = System.String.alignConst;
            label_28:
            mem2[0] = val_54;
            val_55 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_32;
            }
            
            ARTASSETS val_22 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_55 = this;
            if(val_22 == null)
            {
                goto label_32;
            }
            
            ANIMATRONIC3D val_23 = val_22.Animatronic3D;
            val_55 = this;
            if(val_23 == null)
            {
                goto label_32;
            }
            
            val_56 = val_23.Prefab;
            val_55 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_56 != null)
            {
                goto label_33;
            }
            
            label_32:
            val_56 = System.String.alignConst;
            label_33:
            mem2[0] = val_56;
            val_57 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_37;
            }
            
            ARTASSETS val_26 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_57 = this;
            if(val_26 == null)
            {
                goto label_37;
            }
            
            ANIMATRONIC3D val_27 = val_26.Animatronic3D;
            val_57 = this;
            if(val_27 == null)
            {
                goto label_37;
            }
            
            val_58 = val_27.MapIcon;
            val_57 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_58 != null)
            {
                goto label_38;
            }
            
            label_37:
            val_58 = System.String.alignConst;
            label_38:
            mem2[0] = val_58;
            val_59 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_42;
            }
            
            ARTASSETS val_30 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_59 = this;
            if(val_30 == null)
            {
                goto label_42;
            }
            
            UIASSETS val_31 = val_30.UI;
            val_59 = this;
            if(val_31 == null)
            {
                goto label_42;
            }
            
            val_60 = val_31.PlushSuitIcon;
            val_59 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_60 != null)
            {
                goto label_43;
            }
            
            label_42:
            val_60 = System.String.alignConst;
            label_43:
            mem2[0] = val_60;
            val_61 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_47;
            }
            
            ARTASSETS val_34 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_61 = this;
            if(val_34 == null)
            {
                goto label_47;
            }
            
            UIASSETS val_35 = val_34.UI;
            val_61 = this;
            if(val_35 == null)
            {
                goto label_47;
            }
            
            val_62 = val_35.PortraitIcon;
            val_61 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_62 != null)
            {
                goto label_48;
            }
            
            label_47:
            val_62 = System.String.alignConst;
            label_48:
            mem2[0] = val_62;
            val_63 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_52;
            }
            
            ARTASSETS val_38 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_63 = this;
            if(val_38 == null)
            {
                goto label_52;
            }
            
            UIASSETS val_39 = val_38.UI;
            val_63 = this;
            if(val_39 == null)
            {
                goto label_52;
            }
            
            val_64 = val_39.PortraitIconFlat;
            val_63 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_64 != null)
            {
                goto label_53;
            }
            
            label_52:
            val_64 = System.String.alignConst;
            label_53:
            mem2[0] = val_64;
            val_65 = this;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == null)
            {
                goto label_57;
            }
            
            ARTASSETS val_42 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.ArtAssets;
            val_65 = this;
            if(val_42 == null)
            {
                goto label_57;
            }
            
            UIASSETS val_43 = val_42.UI;
            val_65 = this;
            if(val_43 == null)
            {
                goto label_57;
            }
            
            val_66 = val_43.PlushSuitSilhouetteIcon;
            val_65 = (((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) == 0) ? 0 : (this);
            if(val_66 != null)
            {
                goto label_58;
            }
            
            label_57:
            val_66 = System.String.alignConst;
            label_58:
            mem2[0] = val_66;
            if(((PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data) != null)
            {
                    val_67 = (PlushSuitData.<>c__DisplayClass17_0)[1152921525312775008].data.PlayerAcquirable;
            }
            else
            {
                    val_67 = false;
            }
            
            this.PlayerAcquirable = val_67;
        }
    
    }

}
