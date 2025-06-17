using UnityEngine;

namespace SharedTechAssets.Scripts.TechBootstrapComponents
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RawDepthMap
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter Setup()
        {
            SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter val_1 = new SharedTechAssets.Scripts.Adapters.IllumixDepthMapAdapter();
            val_1.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer());
            return (SharedTechAssets.Scripts.TechInterfaces.Accepters.IRawDepthMapAccepter)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RawDepthMap()
        {
        
        }
    
    }

}
