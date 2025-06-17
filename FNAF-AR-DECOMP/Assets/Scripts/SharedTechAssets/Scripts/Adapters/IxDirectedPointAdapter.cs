using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxDirectedPointAdapter : IProcessedDirectedPointsAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxDirectedPointAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxDirectedPointAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDirectedPointsUpdateEvent(UnityEngine.Vector3[] keys, DirectedPointsManager.DirectedPointData[] data, UnityEngine.Vector3 cameraPos)
        {
            var val_4;
            int val_5;
            var val_6;
            IllumixDirectedPoint[] val_1 = new IllumixDirectedPoint[0];
            if(data.Length < 1)
            {
                goto label_2;
            }
            
            var val_6 = 0;
            label_13:
            if(val_6 >= keys.Length)
            {
                    val_4 = 0;
            }
            
            var val_2 = keys + (0 * 12);
            val_5 = data.Length;
            if(val_6 >= val_5)
            {
                    val_4 = 0;
                val_5 = data.Length;
            }
            
            var val_3 = data + (0 * 28);
            if(val_6 >= val_5)
            {
                    val_4 = 0;
            }
            
            var val_4 = data + (0 * 28);
            IllumixDirectedPoint val_5 = new IllumixDirectedPoint(key:  new UnityEngine.Vector3() {x = (0 * 12) + keys + 32, y = (0 * 12) + keys + 32 + 4, z = (0 * 12) + keys + 40}, position:  new UnityEngine.Vector3() {x = (0 * 28) + data + 32, y = (0 * 28) + data + 32 + 4, z = (0 * 28) + data + 40}, direction:  new UnityEngine.Vector3() {x = (0 * 28) + data + 44, y = (0 * 28) + data + 52, z = cameraPos.x}, cameraPos:  new UnityEngine.Vector3() {x = cameraPos.z, y = 6.788408E+11f, z = cameraPos.y});
            if(val_1 == null)
            {
                goto label_7;
            }
            
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_5 == null)
            {
                goto label_11;
            }
            
            label_8:
            if(val_5 == null)
            {
                    val_4 = 0;
            }
            
            label_11:
            if(val_6 >= val_1.Length)
            {
                    val_4 = 0;
            }
            
            val_1[0] = val_5;
            val_6 = val_6 + 1;
            if(val_6 < data.Length)
            {
                goto label_13;
            }
            
            label_2:
            var val_9 = mem[1152921523181194784];
            if((mem[1152921523181194784] + 286) == 0)
            {
                goto label_15;
            }
            
            var val_7 = mem[1152921523181194784] + 176;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_17:
            if(((mem[1152921523181194784] + 176 + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (mem[1152921523181194784] + 286))
            {
                goto label_17;
            }
            
            label_15:
            val_4 = 0;
            goto label_18;
            label_16:
            val_9 = val_9 + (((mem[1152921523181194784] + 176 + 8)) << 4);
            val_6 = val_9 + 296;
            label_18:
            mem[1152921523181194784].OnDirectedPointUpdate(points:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxDirectedPointAdapter()
        {
        
        }
    
    }

}
