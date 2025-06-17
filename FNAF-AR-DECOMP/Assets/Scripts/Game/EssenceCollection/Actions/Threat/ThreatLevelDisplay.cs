using UnityEngine;

namespace Game.EssenceCollection.Actions.Threat
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ThreatLevelDisplay
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.AttackSequenceDomain <_attackSequenceDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Collected.CollectedThreat <_collectedThreat>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ThreatLevelFxController <_threatLevelFxController>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain _attackSequenceDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat _collectedThreat { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ThreatLevelFxController _threatLevelFxController { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain get__attackSequenceDomain()
        {
            return (Game.AttackSequence.AttackSequenceDomain)this.<_attackSequenceDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat get__collectedThreat()
        {
            return (Game.EssenceCollection.Data.Collected.CollectedThreat)this.<_collectedThreat>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ThreatLevelFxController get__threatLevelFxController()
        {
            return (ThreatLevelFxController)this.<_threatLevelFxController>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__threatLevelFxController(ThreatLevelFxController value)
        {
            this.<_threatLevelFxController>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ThreatLevelDisplay(Game.EssenceCollection.Data.Collected.CollectedThreat collectedThreat, Master.SceneLookupTableAccess sceneLookupTableAccess, Game.AttackSequence.AttackSequenceDomain attackSequenceDomain)
        {
            val_1 = new System.Object();
            this.<_attackSequenceDomain>k__BackingField = val_1;
            this.<_collectedThreat>k__BackingField = collectedThreat;
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.Threat.ThreatLevelDisplay::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable camerascenelookuptable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable camerascenelookuptable)
        {
            this.<_threatLevelFxController>k__BackingField = camerascenelookuptable.ThreatLevelFxController;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_threatLevelFxController>k__BackingField)) == false)
            {
                    return;
            }
            
            if((this.<_attackSequenceDomain>k__BackingField.IsInEncounter()) != false)
            {
                    return;
            }
            
            this.<_threatLevelFxController>k__BackingField.SetStrength(strength:  this.<_collectedThreat>k__BackingField._percent);
        }
    
    }

}
