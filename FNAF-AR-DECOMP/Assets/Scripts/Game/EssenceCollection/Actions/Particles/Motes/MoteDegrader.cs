using UnityEngine;

namespace Game.EssenceCollection.Actions.Particles.Motes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MoteDegrader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum <_particleVacuum>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner <_moteSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo> _motesToRemove;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum _particleVacuum { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner _moteSpawner { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum get__particleVacuum()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum)this.<_particleVacuum>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner get__moteSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner)this.<_moteSpawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MoteDegrader(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.Particles.AllMotes allMotes, Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum particleVacuum, Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner moteSpawner)
        {
            this._motesToRemove = new System.Collections.Generic.List<MoteSpawnInfo>();
            val_2 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_allMotes>k__BackingField = val_2;
            this.<_particleVacuum>k__BackingField = particleVacuum;
            this.<_moteSpawner>k__BackingField = moteSpawner;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DegradeExistingMotes()
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
            MoteSpawnInfo[] val_3 = this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  this.<_allMotes>k__BackingField.GetAllEssences()[0]);
            val_7 = 0;
            goto label_8;
            label_11:
            val_3.DegradeMote(moteSpawnInfo:  val_3[0]);
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
            this.DegradeMote(suckToPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, moteSpawnInfo:  this.<_allMotes>k__BackingField.GetDetachedMotes()[0]);
            val_8 = 1;
            label_16:
            if(val_8 < val_5.Length)
            {
                goto label_19;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DegradeMote(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            var val_3;
            float val_4;
            float val_5;
            val_3 = moteSpawnInfo;
            if(val_3 != null)
            {
                    val_4 = moteSpawnInfo.DegradeTimeLeft;
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
        private void DegradeMote(UnityEngine.Vector3 suckToPosition, Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            Game.EssenceCollection.Data.MasterDataConnector val_7;
            float val_8;
            UnityEngine.Vector3 val_2 = moteSpawnInfo.Mote.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_7 = this.<_masterDataConnector>k__BackingField;
            if(val_7 == null)
            {
                goto label_6;
            }
            
            val_8 = this.<_masterDataConnector>k__BackingField.Motes_MaxDegradeMultiplier;
            goto label_7;
            label_6:
            val_8 = this.<_masterDataConnector>k__BackingField.Motes_MaxDegradeMultiplier;
            if((this.<_masterDataConnector>k__BackingField) == null)
            {
                goto label_8;
            }
            
            val_7 = this.<_masterDataConnector>k__BackingField;
            label_7:
            label_11:
            label_12:
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = (UnityEngine.Mathf.Lerp(a:  val_8, b:  this.<_masterDataConnector>k__BackingField.Motes_MinDegradeMultiplier, t:  UnityEngine.Mathf.Clamp(value:  val_3.x, min:  this.<_masterDataConnector>k__BackingField.Motes_MinDegradeDistance, max:  this.<_masterDataConnector>k__BackingField.Motes_MaxDegradeDistance))) * val_6;
            val_6 = moteSpawnInfo.DegradeTimeLeft - val_6;
            moteSpawnInfo.DegradeTimeLeft = val_6;
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
        private void CheckForMotesToRemove()
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
            this.CheckForMoteRemove(moteSpawnInfo:  this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  this.<_allMotes>k__BackingField.GetAllEssences()[0])[0]);
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
            this.CheckForMoteRemove(moteSpawnInfo:  this.<_allMotes>k__BackingField.GetDetachedMotes()[0]);
            val_6 = 1;
            label_11:
            if(val_6 < val_3.Length)
            {
                goto label_14;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForMoteRemove(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            if(moteSpawnInfo.DegradeTimeLeft > 0f)
            {
                    return;
            }
            
            this._motesToRemove.Add(item:  moteSpawnInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveOldMotes()
        {
            List.Enumerator<T> val_1 = this._motesToRemove.GetEnumerator();
            label_4:
            if(((-729416088) & 1) == 0)
            {
                goto label_2;
            }
            
            this.<_moteSpawner>k__BackingField.DespawnMote(moteSpawnInfo:  0.emailUIDataHandler);
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525352267368});
            this._motesToRemove.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.DegradeExistingMotes();
            this.CheckForMotesToRemove();
            this.RemoveOldMotes();
        }
    
    }

}
