using UnityEngine;

namespace Game.EssenceCollection.Actions.Particles.ThreatPills
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ThreatPillOrbiter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllThreatPills <_allThreatPills>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills _allThreatPills { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills get__allThreatPills()
        {
            return (Game.EssenceCollection.Data.Particles.AllThreatPills)this.<_allThreatPills>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ThreatPillOrbiter(Game.EssenceCollection.Data.Particles.AllThreatPills allThreatPills)
        {
            this.<_allThreatPills>k__BackingField = allThreatPills;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            goto label_2;
            label_15:
            ThreatPillSpawnInfo[] val_2 = this.<_allThreatPills>k__BackingField.GetAllThreatPillsForEssence(essenceNode:  this.<_allThreatPills>k__BackingField.GetAllEssences()[0]);
            if((val_2 != null) && (val_2.Length >= 1))
            {
                    do
            {
                ThreatPillSpawnInfo val_9 = val_2[0];
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
                val_2[0x0][0].ThreatPillParent.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, angle:  val_2[0x0][0].ThreatPillOrbitParams * UnityEngine.Time.deltaTime);
            }
            while((0 + 1) < val_2.Length);
            
            }
            
            0 = 1;
            label_2:
            if(0 < val_1.Length)
            {
                goto label_15;
            }
        
        }
    
    }

}
