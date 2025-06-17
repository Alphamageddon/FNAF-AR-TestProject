using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltShapeSphereScript : LightningBoltPrefabScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float InnerRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Radius;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Random.insideUnitSphere;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.InnerRadius);
            UnityEngine.Vector3 val_3 = UnityEngine.Random.onUnitSphere;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.Radius);
            if(parameters != null)
            {
                    parameters.Start = val_2;
                mem2[0] = val_2.y;
                mem2[0] = val_2.z;
            }
            else
            {
                    mem[48] = val_2.x;
                mem[52] = val_2.y;
                mem[56] = val_2.z;
            }
            
            parameters.End = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
            this.CreateLightningBolt(p:  parameters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltShapeSphereScript()
        {
            this.InnerRadius = 0.1f;
            this.Radius = 4f;
        }
    
    }

}
