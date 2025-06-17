using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GlobalMesh
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Mesh ms_Mesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool ms_DoubleSided;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Mesh Get()
        {
            var val_11;
            UnityEngine.Mesh val_12;
            var val_13;
            VLB.Config val_1 = VLB.Config.Instance;
            val_11 = null;
            val_11 = null;
            val_12 = VLB.GlobalMesh.ms_Mesh;
            val_13 = null;
            if(val_12 == 0)
            {
                goto label_8;
            }
            
            val_13 = null;
            if(((val_1.renderingMode != 0) ? 1 : 0) == ((VLB.GlobalMesh.ms_DoubleSided == true) ? 1 : 0))
            {
                goto label_11;
            }
            
            label_8:
            VLB.GlobalMesh.Destroy();
            VLB.Config val_5 = VLB.Config.Instance;
            VLB.Config val_6 = VLB.Config.Instance;
            VLB.GlobalMesh.ms_Mesh = VLB.MeshGenerator.GenerateConeZ_Radius(lengthZ:  1f, radiusStart:  1f, radiusEnd:  1f, numSides:  val_5.sharedMeshSides, numSegments:  val_6.sharedMeshSegments, cap:  true, doubleSided:  (val_1.renderingMode != 0) ? 1 : 0);
            val_12 = VLB.GlobalMesh.ms_Mesh;
            val_12.hideFlags = VLB.Consts.ProceduralObjectsHideFlags;
            val_13 = null;
            VLB.GlobalMesh.ms_DoubleSided = (val_1.renderingMode != 0) ? 1 : 0;
            label_11:
            val_13 = null;
            return (UnityEngine.Mesh)VLB.GlobalMesh.ms_Mesh;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Destroy()
        {
            var val_2;
            UnityEngine.Mesh val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = VLB.GlobalMesh.ms_Mesh;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = VLB.GlobalMesh.ms_Mesh;
            UnityEngine.Object.DestroyImmediate(obj:  val_3);
            VLB.GlobalMesh.ms_Mesh = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GlobalMesh()
        {
        
        }
    
    }

}
