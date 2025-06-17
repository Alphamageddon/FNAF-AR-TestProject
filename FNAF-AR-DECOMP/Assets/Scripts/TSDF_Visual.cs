using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TSDF_Visual
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.TSDF.TSDF_Manager domain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TSDF_Config config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, UnityEngine.GameObject> blockKeyToMesh;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Visual(com.illumix.TSDF.TSDF_Manager tsdfDomain)
    {
        this.domain = tsdfDomain;
        this.config = tsdfDomain.config;
        this.blockKeyToMesh = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, UnityEngine.GameObject>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool GetInHalfSpace(UnityEngine.Vector3 cameraPosition, UnityEngine.Quaternion cameraRotation, UnityEngine.Vector3 blockCoord)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = cameraRotation.x, y = cameraRotation.y, z = cameraRotation.z, w = cameraRotation.w}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = blockCoord.x, y = val_1, z = blockCoord.y}, b:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z});
        return (bool)((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) >= 0f) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void GeneratePS()
    {
        var val_5;
        TSDF_Data val_19;
        TSDF_Config val_20;
        TSDF_Properties val_21;
        float val_22;
        float val_23;
        TSDF_Config val_24;
        System.Collections.Generic.List<Particle> val_1 = new System.Collections.Generic.List<Particle>();
        val_19 = this.domain.data;
        val_20 = this.config;
        if(this.config == null)
        {
                val_20 = this.config;
            if(val_20 == null)
        {
            goto label_39;
        }
        
        }
        
        val_21 = this.config.props;
        val_22 = this.config.weightThreshold;
        val_23 = 0.25f;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = val_19.Keys.GetEnumerator();
        goto label_9;
        label_21:
        GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
        val_24 = val_19.Item[val_6];
        if(val_7.weight >= 0)
        {
                com.illumix.TSDF.Voxel val_8 = val_19.Item[val_6];
            val_23 = mem[System.Math.Abs(val_8.sdf) > S9 ? 1152921518994464800 : 1152921518994464816 + 8 + 4];
            val_23 = System.Math.Abs(val_8.sdf) > S9 ? 1152921518994464800 : 1152921518994464816 + 8 + 4;
            UnityEngine.Vector3 val_10 = this.domain.IntVectorToVertexPosition(intVertex:  val_6, resolution:  val_21);
            val_24 = this.config;
            com.illumix.TSDF.Voxel val_11 = val_19.Item[val_6];
            float val_19 = System.Math.Abs(val_11.sdf);
            val_19 = val_19 / (???);
            val_19 = 1f - val_19;
            float val_12 = System.Math.Max(val1:  val_19, val2:  0f);
            val_12 = this.config.particleSize * val_12;
            UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = (System.Math.Abs(val_8.sdf) > S9) ? 1502715936 : 1502715952, g = System.Math.Abs(val_8.sdf) > S9 ? 1152921518994464800 : 1152921518994464816 + 4, b = System.Math.Abs(val_8.sdf) > S9 ? 1152921518994464800 : 1152921518994464816 + 8, a = val_23});
            byte val_14 = val_13.r & 4294967295;
            val_1.Add(item:  new Particle() {m_Position = new UnityEngine.Vector3(), m_Velocity = new UnityEngine.Vector3(), m_AnimatedVelocity = new UnityEngine.Vector3(), m_InitialVelocity = new UnityEngine.Vector3(), m_AxisOfRotation = new UnityEngine.Vector3(), m_Rotation = new UnityEngine.Vector3(), m_AngularVelocity = new UnityEngine.Vector3(), m_StartSize = new UnityEngine.Vector3(), m_StartColor = new UnityEngine.Color32()});
            val_21 = val_21;
            val_22 = val_22;
        }
        
        label_9:
        if((1502715904 & 1) != 0)
        {
            goto label_21;
        }
        
        long val_15 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518994464768});
        if(val_1 != null)
        {
            goto label_42;
        }
        
        goto label_23;
        label_39:
        if((public System.Void System.Collections.Generic.List<Particle>::.ctor()) != 1)
        {
            goto label_40;
        }
        
        val_19 = 1179403647;
        long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518994464768});
        if(val_1 != null)
        {
            goto label_42;
        }
        
        label_23:
        label_42:
        T[] val_17 = val_1.ToArray();
        if(val_17 == null)
        {
            goto label_44;
        }
        
        label_47:
        this.domain.ps.SetParticles(particles:  val_17, size:  val_17.Length);
        return;
        label_44:
        if(this.domain.ps != null)
        {
            goto label_47;
        }
        
        goto label_47;
        label_40:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClearMeshes()
    {
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.blockKeyToMesh.Keys.GetEnumerator();
        label_5:
        if((1502954120 & 1) == 0)
        {
            goto label_3;
        }
        
        UnityEngine.GameObject val_4 = this.blockKeyToMesh.Item[0.emailUIDataHandler];
        val_4.ClearMesh(go:  val_4);
        goto label_5;
        label_3:
        long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518994702984});
        this.blockKeyToMesh.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClearMesh(UnityEngine.GameObject go)
    {
        go.GetComponent<SimpleMesh>().ClearMesh();
        go.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  go);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateMeshes()
    {
        var val_3;
        com.illumix.TSDF.TSDF_Manager val_18;
        UnityEngine.Vector3[] val_6 = 0;
        System.Int32[] val_7 = 0;
        val_18 = this.domain;
        if(this.domain == null)
        {
                val_18 = this.domain;
            if(val_18 == null)
        {
            goto label_40;
        }
        
        }
        
        HashSet.Enumerator<T> val_1 = this.domain.blocksUpdated.GetEnumerator();
        label_24:
        if((1503305056 & 1) == 0)
        {
            goto label_4;
        }
        
        GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
        this.domain.GetMeshInfoFromBlock(block:  this.domain.Item[val_4], coordsArr: out  val_6, trianglesArr: out  val_7);
        if(15026800 == 0)
        {
            goto label_8;
        }
        
        if((this.blockKeyToMesh.ContainsKey(key:  val_4)) != true)
        {
                UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.config.meshPrefab);
            val_9.SetActive(value:  true);
            this.blockKeyToMesh.set_Item(key:  val_4, value:  val_9);
        }
        
        this.blockKeyToMesh.Item[val_4].GetComponent<SimpleMesh>().InitializeMesh(vertices:  val_6, triangles:  val_7);
        goto label_24;
        label_8:
        if((this.blockKeyToMesh.ContainsKey(key:  val_4)) == false)
        {
            goto label_24;
        }
        
        UnityEngine.GameObject val_13 = this.blockKeyToMesh.Item[val_4];
        val_13.ClearMesh(go:  val_13);
        bool val_14 = this.blockKeyToMesh.Remove(key:  val_4);
        goto label_24;
        label_4:
        long val_15 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518995053920});
        goto label_42;
        label_40:
        if(W1 != 1)
        {
            goto label_41;
        }
        
        long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518995053920});
        label_42:
        this.domain.blocksUpdated.Clear();
        return;
        label_41:
    }

}
