using UnityEngine;

namespace Game.EssenceCollection.Actions.Particles.Motes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MoteOrbiter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MoteOrbiter(Game.EssenceCollection.Data.Particles.AllMotes allMotes)
        {
            this.<_allMotes>k__BackingField = allMotes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            var val_7;
            var val_8;
            val_7 = 0;
            goto label_2;
            label_15:
            val_8 = 0;
            goto label_5;
            label_13:
            MoteSpawnInfo val_8 = this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  this.<_allMotes>k__BackingField.GetAllEssences()[0])[0];
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            val_2[0x0][0].MoteParent.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, angle:  val_2[0x0][0].MoteOrbitParams * UnityEngine.Time.deltaTime);
            val_8 = 1;
            label_5:
            if(val_8 < val_2.Length)
            {
                goto label_13;
            }
            
            val_7 = 1;
            label_2:
            if(val_7 < val_1.Length)
            {
                goto label_15;
            }
        
        }
    
    }

}
