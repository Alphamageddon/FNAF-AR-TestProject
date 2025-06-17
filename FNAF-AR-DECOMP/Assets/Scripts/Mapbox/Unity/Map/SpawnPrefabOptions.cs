using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SpawnPrefabOptions : ModifierProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject prefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool scaleDownWithWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> AllPrefabsInstatiated;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type ModifierType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type get_ModifierType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SpawnPrefabOptions()
        {
            var val_2;
            System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> val_4;
            this.scaleDownWithWorld = true;
            val_2 = null;
            val_2 = null;
            val_4 = SpawnPrefabOptions.<>c.<>9__5_0;
            if(val_4 == null)
            {
                    System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> val_1 = null;
                val_4 = val_1;
                val_1 = new System.Action<System.Collections.Generic.List<UnityEngine.GameObject>>(object:  SpawnPrefabOptions.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SpawnPrefabOptions.<>c::<.ctor>b__5_0(System.Collections.Generic.List<UnityEngine.GameObject> <p0>));
                SpawnPrefabOptions.<>c.<>9__5_0 = val_4;
            }
            
            this.AllPrefabsInstatiated = val_4;
        }
    
    }

}
