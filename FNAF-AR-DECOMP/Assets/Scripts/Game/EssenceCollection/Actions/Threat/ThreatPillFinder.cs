using UnityEngine;

namespace Game.EssenceCollection.Actions.Threat
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ThreatPillFinder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <LastThreatPillFound>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <LastClosestThreatPillDistance>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo <LastClosestThreatPill>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllThreatPills <_allThreatPills>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera <_mainCamera>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LastThreatPillFound { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LastClosestThreatPillDistance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo LastClosestThreatPill { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills _allThreatPills { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _mainCamera { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_LastThreatPillFound()
        {
            return (bool)this.<LastThreatPillFound>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastThreatPillFound(bool value)
        {
            this.<LastThreatPillFound>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_LastClosestThreatPillDistance()
        {
            return (float)this.<LastClosestThreatPillDistance>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastClosestThreatPillDistance(float value)
        {
            this.<LastClosestThreatPillDistance>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo get_LastClosestThreatPill()
        {
            return (ThreatPillSpawnInfo)this.<LastClosestThreatPill>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastClosestThreatPill(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo value)
        {
            this.<LastClosestThreatPill>k__BackingField = value;
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
        public ThreatPillFinder(Game.EssenceCollection.Data.Particles.AllThreatPills allThreatPills, Master.SceneLookupTableAccess sceneLookupTableAccess)
        {
            this.<_allThreatPills>k__BackingField = allThreatPills;
            this.Reset();
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.Threat.ThreatPillFinder::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable camerascenelookuptable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable camerascenelookuptable)
        {
            this.<_mainCamera>k__BackingField = camerascenelookuptable.ForegroundCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            this.<LastThreatPillFound>k__BackingField = false;
            this.<LastClosestThreatPillDistance>k__BackingField = -1.175494E-38f;
            this.<LastClosestThreatPill>k__BackingField = new AllThreatPills.ThreatPillSpawnInfo();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FindNearestThreatPill()
        {
            var val_6;
            var val_7;
            this.Reset();
            if((UnityEngine.Object.op_Implicit(exists:  this.<_mainCamera>k__BackingField)) == false)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_5;
            label_15:
            val_7 = 0;
            goto label_8;
            label_13:
            ThreatPillSpawnInfo val_7 = this.<_allThreatPills>k__BackingField.GetAllThreatPillsForEssence(essenceNode:  this.<_allThreatPills>k__BackingField.GetAllEssences()[0])[0];
            if((this.ThreatPillIsVisible(threatPillSpawnInfo:  val_7)) != false)
            {
                    float val_5 = this.ThreatPillDistanceFromPlayer(threatPillSpawnInfo:  val_7);
                if(val_5 < 0)
            {
                    this.<LastThreatPillFound>k__BackingField = true;
                this.<LastClosestThreatPillDistance>k__BackingField = val_5;
                this.<LastClosestThreatPill>k__BackingField = val_7;
            }
            
            }
            
            val_7 = 1;
            label_8:
            if(val_7 < val_3.Length)
            {
                goto label_13;
            }
            
            val_6 = 1;
            label_5:
            if(val_6 < val_2.Length)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ThreatPillIsVisible(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            UnityEngine.Camera val_6;
            var val_7;
            val_6 = this;
            UnityEngine.Vector3 val_2 = threatPillSpawnInfo.ThreatPill.transform.position;
            UnityEngine.Vector3 val_3 = this.<_mainCamera>k__BackingField.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_7 = 0;
            if(val_3.y > 1f)
            {
                    return (bool)(val_3.z >= val_6.nearClipPlane) ? 1 : 0;
            }
            
            if(val_3.y < 0f)
            {
                    return (bool)(val_3.z >= val_6.nearClipPlane) ? 1 : 0;
            }
            
            if(val_3.x < 0f)
            {
                    return (bool)(val_3.z >= val_6.nearClipPlane) ? 1 : 0;
            }
            
            if(val_3.x > 1f)
            {
                    return (bool)(val_3.z >= val_6.nearClipPlane) ? 1 : 0;
            }
            
            val_6 = this.<_mainCamera>k__BackingField;
            return (bool)(val_3.z >= val_6.nearClipPlane) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float ThreatPillDistanceFromPlayer(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            UnityEngine.Vector3 val_2 = this.<_mainCamera>k__BackingField.transform.position;
            UnityEngine.Vector3 val_4 = threatPillSpawnInfo.ThreatPill.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return (float)val_5.x;
        }
    
    }

}
