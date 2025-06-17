using UnityEngine;

namespace Game.EssenceCollection.Actions.Miscellaneous
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MoteFinder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <LastMoteFound>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <LastClosestMoteDistance>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo <LastClosestMote>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera <_mainCamera>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LastMoteFound { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LastClosestMoteDistance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo LastClosestMote { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _mainCamera { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_LastMoteFound()
        {
            return (bool)this.<LastMoteFound>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastMoteFound(bool value)
        {
            this.<LastMoteFound>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_LastClosestMoteDistance()
        {
            return (float)this.<LastClosestMoteDistance>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastClosestMoteDistance(float value)
        {
            this.<LastClosestMoteDistance>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo get_LastClosestMote()
        {
            return (MoteSpawnInfo)this.<LastClosestMote>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastClosestMote(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo value)
        {
            this.<LastClosestMote>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
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
        public MoteFinder(Game.EssenceCollection.Data.Particles.AllMotes allMotes, Master.SceneLookupTableAccess sceneLookupTableAccess)
        {
            this.<_allMotes>k__BackingField = allMotes;
            this.Reset();
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.Miscellaneous.MoteFinder::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable camerascenelookuptable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable camerascenelookuptable)
        {
            this.<_mainCamera>k__BackingField = camerascenelookuptable.ForegroundCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            this.<LastMoteFound>k__BackingField = false;
            this.<LastClosestMoteDistance>k__BackingField = -1.175494E-38f;
            this.<LastClosestMote>k__BackingField = new AllMotes.MoteSpawnInfo();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FindNearestMote()
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
            MoteSpawnInfo val_7 = this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  this.<_allMotes>k__BackingField.GetAllEssences()[0])[0];
            if((this.MoteIsVisible(moteSpawnInfo:  val_7)) != false)
            {
                    float val_5 = this.MoteDistanceFromPlayer(moteSpawnInfo:  val_7);
                if(val_5 < 0)
            {
                    this.<LastMoteFound>k__BackingField = true;
                this.<LastClosestMoteDistance>k__BackingField = val_5;
                this.<LastClosestMote>k__BackingField = val_7;
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
        private bool MoteIsVisible(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            UnityEngine.Camera val_6;
            var val_7;
            val_6 = this;
            UnityEngine.Vector3 val_2 = moteSpawnInfo.Mote.transform.position;
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
        private float MoteDistanceFromPlayer(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            UnityEngine.Vector3 val_2 = this.<_mainCamera>k__BackingField.transform.position;
            UnityEngine.Vector3 val_4 = moteSpawnInfo.Mote.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return (float)val_5.x;
        }
    
    }

}
