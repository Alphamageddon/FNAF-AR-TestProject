using UnityEngine;

namespace Game.EssenceCollection.Actions.Particles.ThreatPills
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ThreatPillDegrader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllThreatPills <_allThreatPills>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum <_particleVacuum>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner <_threatPillSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo> _threatPillsToRemove;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills _allThreatPills { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum _particleVacuum { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner _threatPillSpawner { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills get__allThreatPills()
        {
            return (Game.EssenceCollection.Data.Particles.AllThreatPills)this.<_allThreatPills>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum get__particleVacuum()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum)this.<_particleVacuum>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner get__threatPillSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner)this.<_threatPillSpawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ThreatPillDegrader(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.Particles.AllThreatPills allThreatPills, Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum particleVacuum, Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner threatPillSpawner)
        {
            this._threatPillsToRemove = new System.Collections.Generic.List<ThreatPillSpawnInfo>();
            val_2 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_allThreatPills>k__BackingField = val_2;
            this.<_particleVacuum>k__BackingField = particleVacuum;
            this.<_threatPillSpawner>k__BackingField = threatPillSpawner;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DegradeExistingThreatPills()
        {
            var val_6;
            var val_7;
            var val_8;
            if((this.<_particleVacuum>k__BackingField.IsInitialized()) == false)
            {
                    return;
            }
            
            bool val_6 = this.<_particleVacuum>k__BackingField._vacuumIsOn;
            val_6 = val_6 + 3;
            var val_7 = ~val_6;
            val_7 = val_7 & 3;
            if(val_7 != 0)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_5;
            label_13:
            ThreatPillSpawnInfo[] val_3 = this.<_allThreatPills>k__BackingField.GetAllThreatPillsForEssence(essenceNode:  this.<_allThreatPills>k__BackingField.GetAllEssences()[0]);
            val_7 = 0;
            goto label_8;
            label_11:
            val_3.DegradeThreatPill(threatPillSpawnInfo:  val_3[0]);
            val_7 = 1;
            label_8:
            if(val_7 < val_3.Length)
            {
                goto label_11;
            }
            
            val_6 = 1;
            label_5:
            if(val_6 < val_2.Length)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_4 = this.<_particleVacuum>k__BackingField.GetPositionToSuckTo();
            val_8 = 0;
            goto label_16;
            label_19:
            this.DegradeThreatPill(suckToPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, threatPillSpawnInfo:  this.<_allThreatPills>k__BackingField.GetDetachedThreatPills()[0]);
            val_8 = 1;
            label_16:
            if(val_8 < val_5.Length)
            {
                goto label_19;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DegradeThreatPill(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            var val_3;
            float val_4;
            float val_5;
            val_3 = threatPillSpawnInfo;
            if(val_3 != null)
            {
                    val_4 = threatPillSpawnInfo.DegradeTimeLeft;
                val_5 = UnityEngine.Time.deltaTime;
            }
            else
            {
                    val_3 = 40;
                val_4 = 1.85775E-36f;
                float val_2 = UnityEngine.Time.deltaTime;
                val_5 = val_2;
            }
            
            val_2 = val_4 - val_5;
            mem[40] = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DegradeThreatPill(UnityEngine.Vector3 suckToPosition, Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            Game.EssenceCollection.Data.MasterDataConnector val_7;
            float val_8;
            UnityEngine.Vector3 val_2 = threatPillSpawnInfo.ThreatPill.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_7 = this.<_masterDataConnector>k__BackingField;
            if(val_7 == null)
            {
                goto label_6;
            }
            
            val_8 = this.<_masterDataConnector>k__BackingField.ThreatPills_MaxDegradeMultiplier;
            goto label_7;
            label_6:
            val_8 = this.<_masterDataConnector>k__BackingField.ThreatPills_MaxDegradeMultiplier;
            if((this.<_masterDataConnector>k__BackingField) == null)
            {
                goto label_8;
            }
            
            val_7 = this.<_masterDataConnector>k__BackingField;
            label_7:
            label_11:
            label_12:
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = (UnityEngine.Mathf.Lerp(a:  val_8, b:  this.<_masterDataConnector>k__BackingField.ThreatPills_MinDegradeMultiplier, t:  UnityEngine.Mathf.Clamp(value:  val_3.x, min:  this.<_masterDataConnector>k__BackingField.ThreatPills_MinDegradeDistance, max:  this.<_masterDataConnector>k__BackingField.ThreatPills_MaxDegradeDistance))) * val_6;
            val_6 = threatPillSpawnInfo.DegradeTimeLeft - val_6;
            threatPillSpawnInfo.DegradeTimeLeft = val_6;
            return;
            label_8:
            if((this.<_masterDataConnector>k__BackingField) != null)
            {
                goto label_11;
            }
            
            if((this.<_masterDataConnector>k__BackingField) != null)
            {
                goto label_12;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForThreatPillsToRemove()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_9:
            val_5 = 0;
            goto label_4;
            label_7:
            this.CheckForThreatPillRemove(threatPillSpawnInfo:  this.<_allThreatPills>k__BackingField.GetAllThreatPillsForEssence(essenceNode:  this.<_allThreatPills>k__BackingField.GetAllEssences()[0])[0]);
            val_5 = 1;
            label_4:
            if(val_5 < val_2.Length)
            {
                goto label_7;
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < val_1.Length)
            {
                goto label_9;
            }
            
            val_6 = 0;
            goto label_11;
            label_14:
            this.CheckForThreatPillRemove(threatPillSpawnInfo:  this.<_allThreatPills>k__BackingField.GetDetachedThreatPills()[0]);
            val_6 = 1;
            label_11:
            if(val_6 < val_3.Length)
            {
                goto label_14;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForThreatPillRemove(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            if(threatPillSpawnInfo.DegradeTimeLeft > 0f)
            {
                    return;
            }
            
            this._threatPillsToRemove.Add(item:  threatPillSpawnInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveOldThreatPills()
        {
            List.Enumerator<T> val_1 = this._threatPillsToRemove.GetEnumerator();
            label_4:
            if(((-735362584) & 1) == 0)
            {
                goto label_2;
            }
            
            this.<_threatPillSpawner>k__BackingField.DespawnThreatPill(threatPillSpawnInfo:  0.emailUIDataHandler);
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525346320872});
            this._threatPillsToRemove.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.DegradeExistingThreatPills();
            this.CheckForThreatPillsToRemove();
            this.RemoveOldThreatPills();
        }
    
    }

}
