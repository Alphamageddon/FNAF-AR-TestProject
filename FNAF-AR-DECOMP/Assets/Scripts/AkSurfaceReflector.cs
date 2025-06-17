using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSurfaceReflector : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.AcousticTexture AcousticTexture;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnableDiffraction;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnableDiffractionOnBoundaryEdges;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoom AssociatedRoom;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MeshFilter MeshFilter;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ulong GetAkGeometrySetID(UnityEngine.MeshFilter meshFilter)
    {
        return (ulong)(long)meshFilter.GetInstanceID();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AddGeometrySet(AK.Wwise.AcousticTexture acousticTexture, UnityEngine.MeshFilter meshFilter, ulong roomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges)
    {
        ulong val_46;
        bool val_47;
        UnityEngine.Object val_48;
        AK.Wwise.AcousticTexture val_49;
        var val_50;
        float val_51;
        float val_52;
        float val_53;
        float val_54;
        AkVertexArray val_55;
        var val_56;
        var val_57;
        var val_58;
        int val_59;
        val_47 = enableDiffraction;
        val_48 = meshFilter;
        val_49 = acousticTexture;
        if(AkSoundEngine.IsInitialized() == false)
        {
                return;
        }
        
        if(val_48 == 0)
        {
                UnityEngine.Debug.Log(message:  "AddGeometrySet(): No mesh found!");
            return;
        }
        
        UnityEngine.Mesh val_3 = val_48.sharedMesh;
        if(val_3 != null)
        {
                val_50 = val_3.vertices;
        }
        else
        {
                val_50 = 0.vertices;
        }
        
        System.Int32[] val_6 = val_3.triangles;
        int[] val_7 = new int[0];
        System.Collections.Generic.List<UnityEngine.Vector3> val_8 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Int32> val_9 = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Int32>();
        if(val_5.Length >= 1)
        {
                do
        {
            var val_10 = val_50 + (0 * 12);
            val_51 = mem[(0 * 12) + val_5 + 32];
            val_51 = (0 * 12) + val_5 + 32;
            val_52 = val_51;
            val_53 = (0 * 12) + val_5 + 32 + 4;
            val_54 = (0 * 12) + val_5 + 32 + 8;
            if((val_9.TryGetValue(key:  new UnityEngine.Vector3() {x = val_52, y = val_53, z = val_54}, value: out  0)) != true)
        {
                int val_13 = val_8.Count;
            val_8.Add(item:  new UnityEngine.Vector3() {x = (0 * 12) + val_5 + 32, y = (0 * 12) + val_5 + 32 + 4, z = (0 * 12) + val_5 + 32 + 8});
            val_51 = mem[(0 * 12) + val_5 + 32];
            val_51 = (0 * 12) + val_5 + 32;
            val_52 = val_51;
            val_53 = (0 * 12) + val_5 + 32 + 4;
            val_54 = (0 * 12) + val_5 + 32 + 8;
            val_9.Add(key:  new UnityEngine.Vector3() {x = val_52, y = val_53, z = val_54}, value:  val_13);
        }
        
            val_7[0] = val_13;
        }
        while((0 + 1) < val_5.Length);
        
        }
        
        int val_15 = val_8.Count;
        AkAcousticSurfaceArray val_16 = null;
        val_49 = val_16;
        val_16 = new AkAcousticSurfaceArray(count:  1);
        AkAcousticSurface val_17 = val_16.Item[0];
        val_17.textureID = val_49.Id;
        val_17.reflectorChannelMask = 0;
        val_17.strName = val_48.gameObject.name;
        val_55 = new AkVertexArray();
        val_55 = new AkVertexArray(count:  val_15);
        if(val_15 < 1)
        {
            goto label_34;
        }
        
        var val_57 = 0;
        val_56 = 0;
        val_57 = 0;
        goto label_130;
        label_34:
        val_58 = 0;
        System.Int32[] val_22 = val_3.triangles;
        int val_23 = val_22.Length * 1431655766;
        val_23 = val_23 >> 32;
        int val_25 = val_23 + (val_23 >> 63);
        val_59 = val_25;
        new AkTriangleArray() = new AkTriangleArray(count:  val_59);
        if(val_22.Length >= 3)
        {
                var val_54 = 0;
            do
        {
            AkTriangle val_27 = new AkTriangleArray().Item[0];
            var val_28 = val_54 + 0;
            System.Int32[] val_29 = val_6 + (((long)(int)((0 + 0))) << 2);
            val_27.point0 = val_7[((val_6 + ((long)(int)((0 + 0))) << 2) + 32) << 2];
            var val_30 = val_28 + 1;
            System.Int32[] val_31 = val_6 + (((long)(int)(((0 + 0) + 1))) << 2);
            val_27.point1 = val_7[((val_6 + ((long)(int)(((0 + 0) + 1))) << 2) + 32) << 2];
            var val_32 = val_28 + 2;
            val_55 = val_55;
            System.Int32[] val_33 = val_6 + (((long)(int)(((0 + 0) + 2))) << 2);
            val_27.point2 = val_7[((val_6 + ((long)(int)(((0 + 0) + 2))) << 2) + 32) << 2];
            val_59 = 0;
            val_27.surface = 0;
            if(val_27 != null)
        {
                var val_53 = 0;
            val_53 = val_53 + 1;
            val_59 = public System.Void System.IDisposable::Dispose();
            val_27.Dispose();
        }
        
            if(((445 == 0) ? 445 : 445) == 445)
        {
            
        }
        else
        {
                if(val_58 != 0)
        {
                val_59 = 0;
            val_58 = 0;
        }
        
        }
        
            val_54 = val_54 + 1;
        }
        while(val_54 < (long)val_25);
        
        }
        
        val_46 = AkSurfaceReflector.GetAkGeometrySetID(meshFilter:  val_48);
        val_47 = val_55;
        AKRESULT val_39 = AkSoundEngine.SetGeometry(in_GeomSetID:  val_46, Triangles:  new AkTriangleArray(), NumTriangles:  1973160512, Vertices:  new AkVertexArray(), NumVertices:  1973119552, Surfaces:  val_16, NumSurfaces:  1973103168, RoomID:  roomID, EnableDiffraction:  val_47, EnableDiffractionOnBoundaryEdges:  enableDiffractionOnBoundaryEdges);
        var val_55 = 0;
        val_55 = val_55 + 1;
        new AkTriangleArray().Dispose();
        var val_41 = (538 == 0) ? 538 : 538;
        if((val_58 == 0) || (val_41 == 538))
        {
            goto label_89;
        }
        
        val_58 = 0;
        if(val_55 != 0)
        {
            goto label_90;
        }
        
        goto label_145;
        label_89:
        if(val_55 == 0)
        {
            goto label_145;
        }
        
        label_90:
        AkVertexArray val_59 = new AkVertexArray();
        var val_58 = 0;
        val_58 = val_58 + 1;
        new AkVertexArray().Dispose();
        label_145:
        var val_48 = (val_41 == 0) ? 538 : (val_41);
        if(( != 0) && (val_48 != 538))
        {
                val_58 = 0;
        }
        
        if(val_49 != null)
        {
            goto label_152;
        }
        
        if(val_58 == 0)
        {
                return;
        }
        
        label_165:
        if(val_48 == 0)
        {
                return;
        }
        
        if(val_48 == 538)
        {
                return;
        }
        
        return;
        label_152:
        var val_60 = 0;
        val_60 = val_60 + 1;
        val_16.Dispose();
        if( != 0)
        {
            goto label_165;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemoveGeometrySet(UnityEngine.MeshFilter meshFilter)
    {
        if(meshFilter == 0)
        {
                return;
        }
        
        AKRESULT val_3 = AkSoundEngine.RemoveGeometry(in_SetID:  AkSurfaceReflector.GetAkGeometrySetID(meshFilter:  meshFilter));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        this.MeshFilter = this.GetComponent<UnityEngine.MeshFilter>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        var val_3;
        ulong val_4;
        val_3 = null;
        val_3 = null;
        val_4 = AkRoom.INVALID_ROOM_ID;
        if(this.AssociatedRoom != 0)
        {
                val_4 = this.AssociatedRoom.GetID();
        }
        
        AkSurfaceReflector.AddGeometrySet(acousticTexture:  this.AcousticTexture, meshFilter:  this.MeshFilter, roomID:  val_4, enableDiffraction:  this.EnableDiffraction, enableDiffractionOnBoundaryEdges:  this.EnableDiffractionOnBoundaryEdges);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        AkSurfaceReflector.RemoveGeometrySet(meshFilter:  this.MeshFilter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSurfaceReflector()
    {
        this.AcousticTexture = new AK.Wwise.AcousticTexture();
    }

}
