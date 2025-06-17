using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltShapeConeScript : LightningBoltPrefabScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float InnerRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float OuterRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Length;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Random.insideUnitCircle;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  this.InnerRadius);
            UnityEngine.Quaternion val_4 = this.transform.rotation;
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector2 val_6 = UnityEngine.Random.insideUnitCircle;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  this.OuterRadius);
            UnityEngine.Quaternion val_9 = this.transform.rotation;
            UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_12 = this.transform.forward;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  this.Length);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            if(parameters != null)
            {
                    parameters.Start = val_5;
                mem2[0] = val_5.y;
                mem2[0] = val_5.z;
            }
            else
            {
                    mem[48] = val_5.x;
                mem[52] = val_5.y;
                mem[56] = val_5.z;
            }
            
            parameters.End = val_14;
            mem2[0] = val_14.y;
            mem2[0] = val_14.z;
            this.CreateLightningBolt(p:  parameters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltShapeConeScript()
        {
            this.InnerRadius = 0.1f;
            this.OuterRadius = 4f;
            this.Length = 4f;
        }
    
    }

}
