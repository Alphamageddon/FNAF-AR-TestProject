using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ArObjectEvaluator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.Cooldowns <_cooldowns>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns _cooldowns { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns get__cooldowns()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.Cooldowns)this.<_cooldowns>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ArObjectEvaluator(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.EssenceNodes.Cooldowns cooldowns)
        {
            val_1 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_cooldowns>k__BackingField = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanSelectObject(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection detectedObject)
        {
            Game.EssenceCollection.Data.EssenceNodes.Cooldowns val_5 = this.<_cooldowns>k__BackingField;
            if(val_5.IsGlobalCooledDown() == false)
            {
                    return false;
            }
            
            val_5 = this.<_cooldowns>k__BackingField;
            if((val_5.IsCategoryCooledDown(category:  detectedObject.objectType)) == false)
            {
                    return false;
            }
            
            val_5 = this.<_masterDataConnector>k__BackingField;
            if(detectedObject.conf < 0)
            {
                    return false;
            }
            
            var val_4 = ((UnityEngine.Random.Range(min:  0f, max:  1f)) <= (this.<_masterDataConnector>k__BackingField.Detect_BaseDisplayChance)) ? 1 : 0;
            return false;
        }
    
    }

}
