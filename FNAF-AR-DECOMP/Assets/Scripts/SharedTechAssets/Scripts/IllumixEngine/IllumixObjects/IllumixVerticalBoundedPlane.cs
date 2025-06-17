using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixVerticalBoundedPlane : IllumixSurfaceObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int _objectCounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> <Boundary>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 <Normal>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly int <Key>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> Boundary { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Normal { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Key { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> get_Boundary()
        {
            return (System.Collections.Generic.List<UnityEngine.Vector3>)this.<Boundary>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Boundary(System.Collections.Generic.List<UnityEngine.Vector3> value)
        {
            this.<Boundary>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_Normal()
        {
            return new UnityEngine.Vector3() {x = this.<Normal>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Normal(UnityEngine.Vector3 value)
        {
            this.<Normal>k__BackingField = value;
            mem[1152921523142921868] = value.y;
            mem[1152921523142921872] = value.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Key()
        {
            return (int)this.<Key>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixVerticalBoundedPlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 initialCenter, UnityEngine.Vector3 normal, int updateKey)
        {
            null = null;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane._objectCounter = SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane._objectCounter + 1;
            string val_2 = "VBP" + SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane._objectCounter;
            this.<Boundary>k__BackingField = boundary;
            this.<Key>k__BackingField = updateKey;
            this.<Normal>k__BackingField = normal;
            mem[1152921523143158236] = normal.y;
            mem[1152921523143158240] = normal.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdatePlane(System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            this.<Boundary>k__BackingField = boundary;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateNormal(UnityEngine.Vector3 normal)
        {
            this.<Normal>k__BackingField = normal;
            mem[1152921523143402716] = normal.y;
            mem[1152921523143402720] = normal.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IllumixVerticalBoundedPlane()
        {
        
        }
    
    }

}
