using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxDirectedPointDeliverer : IIxDirectedPointAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.DirectedPointAdd AddedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_AddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.DirectedPointAdd value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.AddedEvent, b:  value);
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
        public static void remove_AddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.DirectedPointAdd value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.AddedEvent, value:  value);
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
        public void OnDirectedPointUpdate(IllumixDirectedPoint[] points)
        {
            goto label_1;
            label_6:
            if(SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.AddedEvent != null)
            {
                    (SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.AddedEvent == 0) ? 0 : SharedTechAssets.Scripts.IllumixEngine.IxDirectedPointDeliverer.AddedEvent.Invoke(idp:  points[0]);
            }
            
            0 = 1;
            label_1:
            if(0 < points.Length)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxDirectedPointDeliverer()
        {
        
        }
    
    }

}
