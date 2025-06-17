using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameUIMasterDataConnector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModCategory, int> <ModCategorySortWeights>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.MasterData.MasterDataDomain <_masterDataDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.MODCATEGORIES_DATA MODCATEGORIES_MASTER_DATA;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModCategory, int> ModCategorySortWeights { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModCategory, int> get_ModCategorySortWeights()
        {
            return (System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModCategory, System.Int32>)this.<ModCategorySortWeights>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ModCategorySortWeights(System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModCategory, int> value)
        {
            this.<ModCategorySortWeights>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain get__masterDataDomain()
        {
            return (Game.MasterData.MasterDataDomain)this.<_masterDataDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUIMasterDataConnector(Game.MasterData.MasterDataDomain masterDataDomain)
        {
            this.<ModCategorySortWeights>k__BackingField = new System.Collections.Generic.Dictionary<Game.ItemDefinition.Data.DataDefinitions.ModCategory, System.Int32>();
            this.<_masterDataDomain>k__BackingField = masterDataDomain;
            masterDataDomain.GetAccessToData.GetModCategoryDataAsync(returnModCategoriesDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.MODCATEGORIES_DATA>(object:  this, method:  System.Void GameUI.GameUIMasterDataConnector::ReceivedMasterData(ProtoData.MODCATEGORIES_DATA alertData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReceivedMasterData(ProtoData.MODCATEGORIES_DATA alertData)
        {
            this.MODCATEGORIES_MASTER_DATA = alertData;
            this.FixupModCetgorySortOrder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupFromMasterData()
        {
            this.FixupModCetgorySortOrder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupModCetgorySortOrder()
        {
            var val_13;
            var val_14;
            Game.ItemDefinition.Data.DataDefinitions.ModCategory val_8 = 0;
            System.Collections.Generic.IEnumerator<T> val_2 = this.MODCATEGORIES_MASTER_DATA.Entries.GetEnumerator();
            label_21:
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            T val_6 = val_2.Current;
            bool val_9 = System.Enum.TryParse<Game.ItemDefinition.Data.DataDefinitions.ModCategory>(value:  val_6.ModCatLogical, result: out  val_8);
            this.<ModCategorySortWeights>k__BackingField.Add(key:  val_8, value:  UnityEngine.Mathf.RoundToInt(f:  (float)(int)val_6.Order));
            goto label_21;
            label_8:
            val_13 = 0;
            val_14 = 85;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_2.Dispose();
            }
            
            if( == 85)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
    
    }

}
