using UnityEngine;

namespace Game.Store.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreSectionMapper
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string STORE_SECTION_NONE = "None";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string STORE_SECTION_PACK = "Pack";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string STORE_SECTION_FAZCOINS = "FazCoins";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string STORE_SECTION_DEVICE = "Device";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string STORE_SECTION_ENDOSKELETON = "EndoskeletonSlot";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string STORE_SECTION_MINIPACK = "MiniPack";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string STORE_SECTION_LURE = "Lure";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetStringForType(Game.Store.Data.StoreSectionMapper.StoreSectionType type)
        {
            var val_2;
            if((type - 1) <= 5)
            {
                    val_2 = mem[66464912 + ((type - 1)) << 3];
                val_2 = 66464912 + ((type - 1)) << 3;
                return (string)val_2;
            }
            
            val_2 = "None";
            return (string)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.Store.Data.StoreSectionMapper.StoreSectionType GetTypeForString(string typeString)
        {
            var val_8;
            if((System.String.op_Equality(a:  typeString, b:  "Pack")) != false)
            {
                    val_8 = 1;
                return (StoreSectionType)((System.String.op_Equality(a:  typeString, b:  "Lure")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  typeString, b:  "FazCoins")) != false)
            {
                    val_8 = 2;
                return (StoreSectionType)((System.String.op_Equality(a:  typeString, b:  "Lure")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  typeString, b:  "Device")) != false)
            {
                    val_8 = 3;
                return (StoreSectionType)((System.String.op_Equality(a:  typeString, b:  "Lure")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  typeString, b:  "EndoskeletonSlot")) != false)
            {
                    val_8 = 4;
                return (StoreSectionType)((System.String.op_Equality(a:  typeString, b:  "Lure")) != true) ? 6 : 0;
            }
            
            if((System.String.op_Equality(a:  typeString, b:  "MiniPack")) == false)
            {
                    return (StoreSectionType)((System.String.op_Equality(a:  typeString, b:  "Lure")) != true) ? 6 : 0;
            }
            
            val_8 = 5;
            return (StoreSectionType)((System.String.op_Equality(a:  typeString, b:  "Lure")) != true) ? 6 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreSectionMapper()
        {
        
        }
    
    }

}
