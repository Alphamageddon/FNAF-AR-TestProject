using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIllumixDepthMapAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Add(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap map); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UpdateMap(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap GetMap(); // 0
    
    }

}
