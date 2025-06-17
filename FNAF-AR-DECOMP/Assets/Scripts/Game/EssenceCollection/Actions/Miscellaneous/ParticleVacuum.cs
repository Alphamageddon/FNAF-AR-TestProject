using UnityEngine;

namespace Game.EssenceCollection.Actions.Miscellaneous
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ParticleVacuum
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.AttackSequenceDomain <_attackSequenceDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.CameraEquipment.CameraEquipmentDomain <_cameraEquipmentDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllThreatPills <_allThreatPills>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera <_mainCamera>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.MoteFinder <_moteFinder>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Threat.ThreatPillFinder <_threatPillFinder>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _vacuumIsOn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastDetachmentTimestamp;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool VacuumIsOn { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain _attackSequenceDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.CameraEquipmentDomain _cameraEquipmentDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills _allThreatPills { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _mainCamera { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.MoteFinder _moteFinder { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Threat.ThreatPillFinder _threatPillFinder { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_VacuumIsOn()
        {
            return (bool)this._vacuumIsOn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain get__attackSequenceDomain()
        {
            return (Game.AttackSequence.AttackSequenceDomain)this.<_attackSequenceDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.CameraEquipmentDomain get__cameraEquipmentDomain()
        {
            return (Game.CameraEquipment.CameraEquipmentDomain)this.<_cameraEquipmentDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills get__allThreatPills()
        {
            return (Game.EssenceCollection.Data.Particles.AllThreatPills)this.<_allThreatPills>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera get__mainCamera()
        {
            return (UnityEngine.Camera)this.<_mainCamera>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__mainCamera(UnityEngine.Camera value)
        {
            this.<_mainCamera>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.MoteFinder get__moteFinder()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.MoteFinder)this.<_moteFinder>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Threat.ThreatPillFinder get__threatPillFinder()
        {
            return (Game.EssenceCollection.Actions.Threat.ThreatPillFinder)this.<_threatPillFinder>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParticleVacuum(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.AttackSequence.AttackSequenceDomain attackSequenceDomain, Game.CameraEquipment.CameraEquipmentDomain cameraEquipmentDomain, Game.EssenceCollection.Data.Particles.AllMotes allMotes, Game.EssenceCollection.Data.Particles.AllThreatPills allThreatPills, Master.SceneLookupTableAccess sceneLookupTableAccess)
        {
            val_1 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_attackSequenceDomain>k__BackingField = val_1;
            this.<_cameraEquipmentDomain>k__BackingField = cameraEquipmentDomain;
            this.<_allMotes>k__BackingField = allMotes;
            this.<_allThreatPills>k__BackingField = allThreatPills;
            this.<_moteFinder>k__BackingField = new Game.EssenceCollection.Actions.Miscellaneous.MoteFinder(allMotes:  allMotes, sceneLookupTableAccess:  sceneLookupTableAccess);
            this.<_threatPillFinder>k__BackingField = new Game.EssenceCollection.Actions.Threat.ThreatPillFinder(allThreatPills:  allThreatPills, sceneLookupTableAccess:  sceneLookupTableAccess);
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)
        {
            this.<_mainCamera>k__BackingField = cameraSceneLookupTable.ForegroundCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInitialized()
        {
            return UnityEngine.Object.op_Implicit(exists:  this.<_mainCamera>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetPositionToSuckTo()
        {
            if((this.<_masterDataConnector>k__BackingField) != null)
            {
                goto label_0;
            }
            
            this.<_masterDataConnector>k__BackingField = this.<_masterDataConnector>k__BackingField;
            if((this.<_masterDataConnector>k__BackingField) == null)
            {
                goto label_1;
            }
            
            label_0:
            float val_1 = this.<_mainCamera>k__BackingField.nearClipPlane;
            UnityEngine.Vector3 val_2 = this.<_mainCamera>k__BackingField.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVacuumState()
        {
            bool val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            if((this.<_cameraEquipmentDomain>k__BackingField._flashlight.IsOn) != false)
            {
                    val_4 = (~(this.<_attackSequenceDomain>k__BackingField.IsInEncounter())) & 1;
            }
            else
            {
                    val_4 = false;
            }
            
            this._vacuumIsOn = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RunVacuum()
        {
            if(this._vacuumIsOn == false)
            {
                    return;
            }
            
            this.SuckDetachedParticles();
            if(this.CanDetachParticle() == false)
            {
                    return;
            }
            
            this.DetachNearestParticle();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SuckDetachedParticles()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_mainCamera>k__BackingField)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.GetPositionToSuckTo();
            if((val_3.Length != 0) && (val_3.Length >= 1))
            {
                    do
            {
                this.SuckMoteVelocityTowards(moteSpawnInfo:  this.<_allMotes>k__BackingField.GetDetachedMotes()[0], suckToPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            }
            while((0 + 1) < val_3.Length);
            
            }
            
            if(val_5.Length == 0)
            {
                    return;
            }
            
            if(val_5.Length < 1)
            {
                    return;
            }
            
            do
            {
                this.SuckThreatPillVelocityTowards(threatPillSpawnInfo:  this.<_allThreatPills>k__BackingField.GetDetachedThreatPills()[0], suckToPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            }
            while((0 + 1) < val_5.Length);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SuckMoteVelocityTowards(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo, UnityEngine.Vector3 suckToPosition)
        {
            var val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_31;
            float val_32;
            UnityEngine.Vector3 val_2 = moteSpawnInfo.Mote.transform.position;
            MOTEOVERRIDES val_4 = moteSpawnInfo.EssenceNode.EssenceTypesEntry.MoteOverrides;
            if(val_4 == null)
            {
                goto label_7;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_5 = val_4.DetachedMovementBehavior;
            if(val_5 == null)
            {
                goto label_7;
            }
            
            double val_6 = val_5.DetachedAcceleration;
            goto label_8;
            label_7:
            label_8:
            val_24 = 0;
            if(((-713086976) & 1) != 0)
            {
                    val_24 = 0.South;
            }
            
            UnityEngine.Vector3 val_8 = this.GetAppliedAcceleration(currentPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, suckToPosition:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z}, acceleration:  (float)val_24);
            UnityEngine.Vector3 val_9 = moteSpawnInfo.Mote.currentVelocity;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_25 = val_10.x;
            if(moteSpawnInfo.Mote != null)
            {
                    val_26 = val_25;
                val_27 = val_10.y;
                val_28 = val_10.z;
                moteSpawnInfo.Mote.currentVelocity = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28};
            }
            else
            {
                    val_26 = val_25;
                val_27 = val_10.y;
                val_28 = val_10.z;
                0.currentVelocity = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28};
            }
            
            UnityEngine.Vector3 val_11 = moteSpawnInfo.Mote.currentVelocity;
            val_29 = val_11.x;
            MOTEOVERRIDES val_13 = moteSpawnInfo.EssenceNode.EssenceTypesEntry.MoteOverrides;
            if(val_13 == null)
            {
                goto label_19;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_14 = val_13.DetachedMovementBehavior;
            if(val_14 == null)
            {
                goto label_19;
            }
            
            double val_15 = val_14.MaximumDetachedSpeed;
            goto label_20;
            label_19:
            label_20:
            val_31 = 0f;
            if(((-713086976) & 1) != 0)
            {
                    val_31 = (float)0.South;
            }
            
            if(val_29 <= val_31)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_17 = moteSpawnInfo.Mote.currentVelocity;
            MOTEOVERRIDES val_19 = moteSpawnInfo.EssenceNode.EssenceTypesEntry.MoteOverrides;
            if(val_19 == null)
            {
                goto label_27;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_20 = val_19.DetachedMovementBehavior;
            if(val_20 == null)
            {
                goto label_27;
            }
            
            double val_21 = val_20.MaximumDetachedSpeed;
            goto label_28;
            label_27:
            label_28:
            val_32 = 0f;
            if(((-713086976) & 1) != 0)
            {
                    val_32 = (float)0.South;
            }
            
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  val_32);
            val_29 = val_23.x;
            val_25 = val_23.z;
            moteSpawnInfo.Mote.currentVelocity = new UnityEngine.Vector3() {x = val_29, y = val_23.y, z = val_25};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SuckThreatPillVelocityTowards(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo, UnityEngine.Vector3 suckToPosition)
        {
            var val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_31;
            float val_32;
            UnityEngine.Vector3 val_2 = threatPillSpawnInfo.ThreatPill.transform.position;
            ENTRY val_3 = threatPillSpawnInfo.EssenceNode.EssenceTypesEntry;
            if(val_3 == null)
            {
                goto label_7;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_5 = val_3.ThreatPillOverrides.DetachedMovementBehavior;
            if(val_5 == null)
            {
                goto label_7;
            }
            
            double val_6 = val_5.DetachedAcceleration;
            goto label_8;
            label_7:
            label_8:
            val_24 = 0;
            if(((-712852096) & 1) != 0)
            {
                    val_24 = 0.South;
            }
            
            UnityEngine.Vector3 val_8 = this.GetAppliedAcceleration(currentPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, suckToPosition:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z}, acceleration:  (float)val_24);
            UnityEngine.Vector3 val_9 = threatPillSpawnInfo.ThreatPill.currentVelocity;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_25 = val_10.x;
            if(threatPillSpawnInfo.ThreatPill != null)
            {
                    val_26 = val_25;
                val_27 = val_10.y;
                val_28 = val_10.z;
                threatPillSpawnInfo.ThreatPill.currentVelocity = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28};
            }
            else
            {
                    val_26 = val_25;
                val_27 = val_10.y;
                val_28 = val_10.z;
                0.currentVelocity = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28};
            }
            
            UnityEngine.Vector3 val_11 = threatPillSpawnInfo.ThreatPill.currentVelocity;
            val_29 = val_11.x;
            THREATPILLOVERRIDES val_13 = threatPillSpawnInfo.EssenceNode.EssenceTypesEntry.ThreatPillOverrides;
            if(val_13 == null)
            {
                goto label_19;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_14 = val_13.DetachedMovementBehavior;
            if(val_14 == null)
            {
                goto label_19;
            }
            
            double val_15 = val_14.MaximumDetachedSpeed;
            goto label_20;
            label_19:
            label_20:
            val_31 = 0f;
            if(((-712852096) & 1) != 0)
            {
                    val_31 = (float)0.South;
            }
            
            if(val_29 <= val_31)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_17 = threatPillSpawnInfo.ThreatPill.currentVelocity;
            THREATPILLOVERRIDES val_19 = threatPillSpawnInfo.EssenceNode.EssenceTypesEntry.ThreatPillOverrides;
            if(val_19 == null)
            {
                goto label_27;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_20 = val_19.DetachedMovementBehavior;
            if(val_20 == null)
            {
                goto label_27;
            }
            
            double val_21 = val_20.MaximumDetachedSpeed;
            goto label_28;
            label_27:
            label_28:
            val_32 = 0f;
            if(((-712852096) & 1) != 0)
            {
                    val_32 = (float)0.South;
            }
            
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  val_32);
            val_29 = val_23.x;
            val_25 = val_23.z;
            threatPillSpawnInfo.ThreatPill.currentVelocity = new UnityEngine.Vector3() {x = val_29, y = val_23.y, z = val_25};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GetAppliedAcceleration(UnityEngine.Vector3 currentPosition, UnityEngine.Vector3 suckToPosition, float acceleration)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z}, b:  new UnityEngine.Vector3() {x = currentPosition.x, y = currentPosition.y, z = currentPosition.z});
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = val_2 * acceleration;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  val_2, a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToDetachParticles()
        {
            if(this.CanDetachParticle() == false)
            {
                    return;
            }
            
            this.DetachNearestParticle();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanDetachParticle()
        {
            var val_6;
            MoteSpawnInfo[] val_1 = this.<_allMotes>k__BackingField.GetDetachedMotes();
            ThreatPillSpawnInfo[] val_2 = this.<_allThreatPills>k__BackingField.GetDetachedThreatPills();
            float val_6 = (float)val_1.Length;
            val_6 = val_6 + (float)val_2.Length;
            if(val_6 < (this.<_masterDataConnector>k__BackingField.ParticleVacuum_MaximumDetached))
            {
                    var val_5 = ((this._lastDetachmentTimestamp + (this.<_masterDataConnector>k__BackingField.ParticleVacuum_DetachFrequency)) <= UnityEngine.Time.time) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DetachNearestParticle()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_mainCamera>k__BackingField)) == false)
            {
                    return;
            }
            
            this.<_moteFinder>k__BackingField.FindNearestMote();
            this.<_threatPillFinder>k__BackingField.FindNearestThreatPill();
            if(((this.<_moteFinder>k__BackingField.<LastMoteFound>k__BackingField) == false) || ((this.<_threatPillFinder>k__BackingField.LastThreatPillFound) == false))
            {
                goto label_9;
            }
            
            if((this.<_moteFinder>k__BackingField.<LastClosestMoteDistance>k__BackingField) <= (this.<_threatPillFinder>k__BackingField.LastClosestThreatPillDistance))
            {
                goto label_12;
            }
            
            goto label_13;
            label_9:
            if((this.<_moteFinder>k__BackingField.<LastMoteFound>k__BackingField) == false)
            {
                goto label_15;
            }
            
            label_12:
            this._lastDetachmentTimestamp = UnityEngine.Time.time;
            this.<_allMotes>k__BackingField.DetachMote(moteSpawnInfo:  this.<_moteFinder>k__BackingField.<LastClosestMote>k__BackingField);
            return;
            label_15:
            if((this.<_threatPillFinder>k__BackingField.LastThreatPillFound) == false)
            {
                    return;
            }
            
            label_13:
            this._lastDetachmentTimestamp = UnityEngine.Time.time;
            this.<_allThreatPills>k__BackingField.DetachThreatPill(threatPillSpawnInfo:  this.<_threatPillFinder>k__BackingField.LastClosestThreatPill);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateParticleDeceleration()
        {
            if(this._vacuumIsOn != false)
            {
                    return;
            }
            
            this.ApplyDecelerationToMotes();
            this.ApplyDecelerationToThreatPills();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ApplyDecelerationToMotes()
        {
            var val_2;
            MoteSpawnInfo[] val_1 = this.<_allMotes>k__BackingField.GetDetachedMotes();
            val_2 = 0;
            goto label_1;
            label_4:
            val_1.ApplyDecelerationToMote(moteSpawnInfo:  val_1[0]);
            val_2 = 1;
            label_1:
            if(val_2 < val_1.Length)
            {
                goto label_4;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ApplyDecelerationToMote(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            float val_13;
            UnityEngine.Vector3 val_1 = moteSpawnInfo.Mote.currentVelocity;
            MOTEOVERRIDES val_3 = moteSpawnInfo.EssenceNode.EssenceTypesEntry.MoteOverrides;
            if(val_3 == null)
            {
                goto label_6;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_4 = val_3.DetachedMovementBehavior;
            if(val_4 == null)
            {
                goto label_6;
            }
            
            double val_5 = val_4.DetachedDeceleration;
            goto label_7;
            label_6:
            label_7:
            val_13 = 0f;
            if(((-711588864) & 1) != 0)
            {
                    val_13 = (float)0.South;
            }
            
            val_13 = val_13 * UnityEngine.Time.deltaTime;
            if(val_13 < val_1.x)
            {
                    UnityEngine.Vector3 val_8 = moteSpawnInfo.Mote.currentVelocity;
                UnityEngine.Vector3 val_9 = moteSpawnInfo.Mote.currentVelocity;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_13, a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            }
            else
            {
                    UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            }
            
            moteSpawnInfo.Mote.currentVelocity = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateMotePositions()
        {
            goto label_1;
            label_5:
            MoteSpawnInfo val_2 = this.<_allMotes>k__BackingField.GetDetachedMotes()[0];
            this.UpdateMotePosition(moteVisual:  val_1[0x0][0].Mote);
            0 = 1;
            label_1:
            if(0 < val_1.Length)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateMotePosition(Game.EssenceCollection.Visuals.MoteVisual moteVisual)
        {
            UnityEngine.Transform val_1 = moteVisual.transform;
            UnityEngine.Vector3 val_2 = val_1.position;
            UnityEngine.Vector3 val_4 = moteVisual.currentVelocity;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Time.deltaTime, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_1.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ApplyDecelerationToThreatPills()
        {
            var val_2;
            ThreatPillSpawnInfo[] val_1 = this.<_allThreatPills>k__BackingField.GetDetachedThreatPills();
            val_2 = 0;
            goto label_1;
            label_4:
            val_1.ApplyDecelerationToThreatPill(threatPillSpawnInfo:  val_1[0]);
            val_2 = 1;
            label_1:
            if(val_2 < val_1.Length)
            {
                goto label_4;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ApplyDecelerationToThreatPill(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            float val_13;
            UnityEngine.Vector3 val_1 = threatPillSpawnInfo.ThreatPill.currentVelocity;
            THREATPILLOVERRIDES val_3 = threatPillSpawnInfo.EssenceNode.EssenceTypesEntry.ThreatPillOverrides;
            if(val_3 == null)
            {
                goto label_6;
            }
            
            DETACHEDMOVEMENTBEHAVIOR val_4 = val_3.DetachedMovementBehavior;
            if(val_4 == null)
            {
                goto label_6;
            }
            
            double val_5 = val_4.DetachedDeceleration;
            goto label_7;
            label_6:
            label_7:
            val_13 = 0f;
            if(((-710886912) & 1) != 0)
            {
                    val_13 = (float)0.South;
            }
            
            val_13 = val_13 * UnityEngine.Time.deltaTime;
            if(val_13 < val_1.x)
            {
                    UnityEngine.Vector3 val_8 = threatPillSpawnInfo.ThreatPill.currentVelocity;
                UnityEngine.Vector3 val_9 = threatPillSpawnInfo.ThreatPill.currentVelocity;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_13, a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            }
            else
            {
                    UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            }
            
            threatPillSpawnInfo.ThreatPill.currentVelocity = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateThreatPillPositions()
        {
            goto label_1;
            label_5:
            ThreatPillSpawnInfo val_2 = this.<_allThreatPills>k__BackingField.GetDetachedThreatPills()[0];
            this.UpdateThreatPillPosition(threatPillVisual:  val_1[0x0][0].ThreatPill);
            0 = 1;
            label_1:
            if(0 < val_1.Length)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateThreatPillPosition(Game.EssenceCollection.Visuals.ThreatPillVisual threatPillVisual)
        {
            UnityEngine.Transform val_1 = threatPillVisual.transform;
            UnityEngine.Vector3 val_2 = val_1.position;
            UnityEngine.Vector3 val_4 = threatPillVisual.currentVelocity;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Time.deltaTime, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_1.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateVacuumState();
            this.RunVacuum();
            this.UpdateParticleDeceleration();
            this.UpdateMotePositions();
            this.UpdateThreatPillPositions();
        }
    
    }

}
