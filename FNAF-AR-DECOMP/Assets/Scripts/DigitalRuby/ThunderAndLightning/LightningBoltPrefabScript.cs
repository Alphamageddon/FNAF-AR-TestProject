using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltPrefabScript : LightningBoltPrefabScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Source;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Destination;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 StartVariance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 EndVariance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            UnityEngine.Vector3 val_8;
            float val_9;
            float val_10;
            var val_11;
            UnityEngine.Vector3 val_12;
            float val_13;
            float val_14;
            if(this.Source == 0)
            {
                    val_8 = parameters.Start;
                var val_2 = (parameters == 0) ? 1 : 0;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = this.Source.transform.position;
                val_8 = val_4.x;
                val_9 = val_4.y;
                val_10 = val_4.z;
                if(parameters != null)
            {
                    val_11 = 0;
            }
            else
            {
                    val_11 = 1;
            }
            
            }
            
            parameters.Start = val_4;
            mem2[0] = val_9;
            mem2[0] = val_10;
            if(this.Destination != 0)
            {
                goto label_12;
            }
            
            val_12 = parameters.End;
            if(val_11 != 0)
            {
                goto label_14;
            }
            
            goto label_18;
            label_12:
            UnityEngine.Vector3 val_7 = this.Destination.transform.position;
            val_12 = val_7.x;
            val_13 = val_7.y;
            val_14 = val_7.z;
            if(val_11 == 0)
            {
                goto label_18;
            }
            
            label_14:
            label_18:
            parameters.End = val_7;
            mem2[0] = val_13;
            mem2[0] = val_14;
            parameters.StartVariance = this.StartVariance;
            mem2[0] = 1152921504851574784;
            mem2[0] = ???;
            parameters.EndVariance = this.EndVariance;
            mem2[0] = 1152921504851574784;
            mem2[0] = ???;
            this.CreateLightningBolt(p:  parameters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltPrefabScript()
        {
        
        }
    
    }

}
