using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltDependencies
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material LightningMaterialMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material LightningMaterialMeshNoGlow;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem OriginParticleSystem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem DestParticleSystem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 CameraPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CameraIsOrthographic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.CameraMode CameraMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseWorldSpace;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LevelOfDetailDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SortLayerName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SortOrderInLayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.ICollection<DigitalRuby.ThunderAndLightning.LightningBoltParameters> Parameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningThreadState ThreadState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Func<System.Collections.IEnumerator, UnityEngine.Coroutine> StartCoroutine;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<UnityEngine.Light> LightAdded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<UnityEngine.Light> LightRemoved;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBolt> AddActiveBolt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBoltDependencies> ReturnToCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> LightningBoltStarted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> LightningBoltEnded;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltDependencies()
        {
        
        }
    
    }

}
