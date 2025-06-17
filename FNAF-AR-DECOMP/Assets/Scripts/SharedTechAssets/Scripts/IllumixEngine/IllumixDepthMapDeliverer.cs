using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixDepthMapDeliverer : IIllumixDepthMapAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap _depthMap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.Update UpdatedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixDepthMapDeliverer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.UpdatedEvent, b:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.UpdatedEvent, value:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap map)
        {
            this._depthMap = map;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateMap()
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.UpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IllumixDepthMapDeliverer.UpdatedEvent.Invoke(map:  this._depthMap);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap GetMap()
        {
            return (SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixDepthMap)this._depthMap;
        }
    
    }

}
