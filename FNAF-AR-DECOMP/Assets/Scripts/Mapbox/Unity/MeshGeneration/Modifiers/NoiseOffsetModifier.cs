using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NoiseOffsetModifier : GameObjectModifier
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Random.insideUnitSphere;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.01f);
            UnityEngine.Transform val_3 = ve.GameObject.transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NoiseOffsetModifier()
        {
            mem[1152921519694669240] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
