using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FeaturePointModifier : IPointAccepter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private PointDispenser dispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FeaturePointViewspaceBoxer boxer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FeaturePointModifier_Config config;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FeaturePointModifier_SROptions debugOptions;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem pointCloudPS;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem.Particle[] particles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int nextParticleIndex;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<UnityEngine.Vector3> realPoints;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<UnityEngine.Vector3> fakePoints;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Setup(PointDispenser dispenser, FeaturePointModifier_Config config, UnityEngine.Camera m_Camera)
    {
        this.dispenser = dispenser;
        this.config = config;
        this.boxer = new FeaturePointViewspaceBoxer(m_Camera:  m_Camera);
        .featurePointModifier = this;
        this.debugOptions = new FeaturePointModifier_SROptions();
        this.InitParticleSystem();
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(val_3 == null)
        {
                return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_3.AddOptionContainer(container:  this.debugOptions);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Teardown()
    {
        this.dispenser = 0;
        this.boxer = 0;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        if(val_1 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.RemoveOptionContainer(container:  this.debugOptions);
        }
        
        this.debugOptions = 0;
        this.DestroyParticleSystem();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnPointUpdatedEvent(UnityEngine.Vector3[] featurePoints)
    {
        this.dispenser.SendPointUpdateEvent(pointData:  this.FilterAndModify(pointCloudData:  featurePoints));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetParticleOff(ref UnityEngine.ParticleSystem.Particle particle)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        UnityEngine.Color32 val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        byte val_4 = val_3.r & 4294967295;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetParticleOn(ref UnityEngine.ParticleSystem.Particle particle, UnityEngine.Vector3 position, UnityEngine.Color color)
    {
        UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
        byte val_2 = val_1.r & 4294967295;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitParticleSystem()
    {
        var val_3;
        this.pointCloudPS = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  this.config.pointCloudParticlePrefab);
        val_3 = 0;
        this.particles = new Particle[0];
        goto label_5;
        label_9:
        Particle val_3 = 0 + 32;
        this.SetParticleOff(particle: ref  new Particle() {m_Position = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_Velocity = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_AnimatedVelocity = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_InitialVelocity = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_AxisOfRotation = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_Rotation = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_AngularVelocity = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_StartSize = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_StartColor = new UnityEngine.Color32() {r = val_3, g = val_3, b = val_3, a = val_3}, m_RandomSeed = val_3, m_Lifetime = val_3, m_StartLifetime = val_3, m_EmitAccumulator0 = val_3, m_EmitAccumulator1 = val_3, m_Flags = val_3});
        val_3 = 1;
        label_5:
        if(val_3 < this.config.maxPointsToShow)
        {
            goto label_9;
        }
        
        this.pointCloudPS.SetParticles(particles:  this.particles, size:  this.config.maxPointsToShow);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DestroyParticleSystem()
    {
        UnityEngine.Object.Destroy(obj:  this.pointCloudPS);
        this.pointCloudPS = 0;
        mem[1152921518937462920] = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RefreshParticles()
    {
        this.pointCloudPS.SetParticles(particles:  this.particles, size:  this.config.maxPointsToShow);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void HideParticles()
    {
        goto label_0;
        label_4:
        Particle val_1 = 0 + 32;
        this.SetParticleOff(particle: ref  new Particle() {m_Position = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_Velocity = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_AnimatedVelocity = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_InitialVelocity = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_AxisOfRotation = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_Rotation = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_AngularVelocity = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_StartSize = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_StartColor = new UnityEngine.Color32() {r = val_1, g = val_1, b = val_1, a = val_1}, m_RandomSeed = val_1, m_Lifetime = val_1, m_StartLifetime = val_1, m_EmitAccumulator0 = val_1, m_EmitAccumulator1 = val_1, m_Flags = val_1});
        0 = 1;
        label_0:
        if(0 < this.config.maxPointsToShow)
        {
            goto label_4;
        }
        
        this.pointCloudPS.SetParticles(particles:  this.particles, size:  this.config.maxPointsToShow);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3[] FilterAndModify(UnityEngine.Vector3[] pointCloudData)
    {
        float val_10;
        float val_11;
        float val_12;
        float val_14;
        FeaturePointModifier_Config val_58;
        int val_59;
        var val_60;
        float val_64;
        float val_65;
        var val_66;
        var val_67;
        float val_68;
        float val_69;
        float val_70;
        float val_71;
        float val_72;
        float val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        int val_83;
        System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>[,] val_1 = 0;
        this.boxer.BoxPoints(sourcePoints:  pointCloudData, boxedPoints: out  val_1);
        val_58 = 1152921518724775088;
        this.realPoints.Clear();
        this.fakePoints.Clear();
        if((this.config.showDebugVisuals != false) && (this.config.maxPointsToShow >= 1))
        {
                System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
        
        if(val_1 != 0)
        {
                val_59 = val_1.GetLength(dimension:  0);
        }
        else
        {
                val_59 = val_1.GetLength(dimension:  0);
        }
        
        int val_5 = val_1.GetLength(dimension:  1);
        if(val_59 < 1)
        {
            goto label_11;
        }
        
        val_60 = 124;
        label_106:
        if(val_5 < 1)
        {
            goto label_12;
        }
        
        label_67:
        var val_57 = 0;
        val_57 = 0 + (mem[4306960403] * val_57);
        var val_6 = val_1 + (((mem[4306960403] * 0) + 0) << 3);
        if((((val_1 + ((mem[4306960403] * 0) + 0) << 3) + 32) == 0) || (((val_1 + ((mem[4306960403] * 0) + 0) << 3) + 32.Count) < 1))
        {
            goto label_17;
        }
        
        var val_65 = 0;
        label_66:
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3> val_9 = (val_1 + ((mem[4306960403] * 0) + 0) << 3) + 32.Item[0];
        System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3> val_13 = (val_1 + ((mem[4306960403] * 0) + 0) << 3) + 32.Item[0];
        val_64 = val_14;
        val_65 = this.config.minDepth;
        if(val_64 < val_65)
        {
            goto label_23;
        }
        
        val_65 = this.config.maxDepth;
        if(val_64 >= 0)
        {
            goto label_23;
        }
        
        int val_15 = UnityEngine.Mathf.Max(a:  -1, b:  0);
        val_66 = 0;
        goto label_26;
        label_58:
        val_67 = UnityEngine.Mathf.Max(a:  -1, b:  0);
        goto label_29;
        label_55:
        var val_58 = (long)val_15;
        val_58 = (long)val_67 + (mem[4306960403] * val_58);
        var val_17 = val_1 + (((mem[4306960403] * (long)(int)(val_15)) + (long)(int)(val_16)) << 3);
        if((((val_1 + ((mem[4306960403] * (long)(int)(val_15)) + (long)(int)(val_16)) << 3) + 32) != 0) && (((val_1 + ((mem[4306960403] * (long)(int)(val_15)) + (long)(int)(val_16)) << 3) + 32.Count) >= 1))
        {
                do
        {
            var val_22 = (val_65 == 0) ? 1 : 0;
            val_22 = (((0 == val_15) ? 1 : 0) & ((0 == val_67) ? 1 : 0)) & val_22;
            if((val_22 & 1) == 0)
        {
                System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3> val_23 = (val_1 + ((mem[4306960403] * (long)(int)(val_15)) + (long)(int)(val_16)) << 3) + 32.Item[0];
            val_69 = val_10;
            val_68 = val_11;
            float val_59 = val_11;
            val_59 = val_59 - val_68;
            val_65 = val_64 * this.config.maxNeighborHeightDelta;
            if(System.Math.Abs(val_59) < 0)
        {
                val_70 = val_12;
            val_71 = val_69;
            float val_24 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_70}, b:  new UnityEngine.Vector3() {x = val_71, y = val_68, z = val_12});
            val_65 = this.config.maxNeighborDistanceDelta;
            val_72 = val_24 / val_64;
            if(val_72 <= val_65)
        {
                val_66 = 1;
            if(val_66 >= this.config.minCloseNeighbors)
        {
                val_72 = val_24 * val_24;
            val_65 = val_72 * this.config.numFakePointsMultiplier;
            int val_63 = (int)val_65;
            if(val_63 >= (1.401298E-45f))
        {
                do
        {
            float val_62 = 1f;
            float val_61 = val_62;
            float val_25 = UnityEngine.Random.Range(min:  0f, max:  val_61);
            val_61 = val_62 - val_25;
            float val_26 = UnityEngine.Random.Range(min:  0f, max:  val_61);
            val_26 = val_25 + val_26;
            val_62 = val_62 - val_26;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12}, d:  val_25);
            val_73 = val_27.y;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_69, y = val_68, z = val_12}, d:  val_26);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_73, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  val_62);
            val_71 = val_30.x;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_71, y = val_30.y, z = val_30.z});
            val_65 = val_31.x;
            val_72 = val_31.y;
            val_70 = val_31.z;
            this.fakePoints.Add(item:  new UnityEngine.Vector3() {x = val_65, y = val_72, z = val_70});
            val_63 = val_63 - 1;
        }
        while(val_63 != 0);
        
            val_64 = val_64;
        }
        
        }
        
        }
        
        }
        
        }
        
            val_74 = 0 + 1;
        }
        while(val_74 < ((val_1 + ((mem[4306960403] * (long)(int)(val_15)) + (long)(int)(val_16)) << 3) + 32.Count));
        
        }
        
        val_67 = val_67 + 1;
        label_29:
        val_75 = null;
        if(val_67 < (UnityEngine.Mathf.Min(a:  1, b:  val_5)))
        {
            goto label_55;
        }
        
        int val_64 = val_15;
        val_59 = val_59;
        val_64 = val_64 + 1;
        label_26:
        if(val_64 < (UnityEngine.Mathf.Min(a:  1, b:  val_59)))
        {
            goto label_58;
        }
        
        goto label_59;
        label_23:
        val_66 = 0;
        label_59:
        if(val_66 >= this.config.minCloseNeighbors)
        {
            goto label_61;
        }
        
        val_76 = (val_1 + ((mem[4306960403] * 0) + 0) << 3) + 32;
        if(0 == 0)
        {
            goto label_62;
        }
        
        val_77 = 0;
        if(val_77 == 0)
        {
                val_77 = 0;
        }
        
        val_78 = public System.Void System.Collections.Generic.List<UnityEngine.Vector3>::Add(UnityEngine.Vector3 item);
        goto label_64;
        label_61:
        val_76 = (val_1 + ((mem[4306960403] * 0) + 0) << 3) + 32;
        val_78 = public System.Void System.Collections.Generic.List<UnityEngine.Vector3>::Add(UnityEngine.Vector3 item);
        label_64:
        val_65 = val_10;
        val_70 = val_12;
        val_72 = val_11;
        this.realPoints.Add(item:  new UnityEngine.Vector3() {x = val_65, y = val_72, z = val_70});
        label_62:
        val_65 = val_65 + 1;
        if(val_65 < val_76.Count)
        {
            goto label_66;
        }
        
        label_17:
        val_60 = 124;
        val_58 = 0 + 1;
        if(val_58 != val_5)
        {
            goto label_67;
        }
        
        label_12:
        if(0 == 0)
        {
            goto label_68;
        }
        
        if(this.config.showCurrentOnly != false)
        {
                this.nextParticleIndex = 0;
        }
        
        val_79 = 0;
        goto label_71;
        label_80:
        this.nextParticleIndex = 0;
        label_78:
        val_79 = 1;
        label_71:
        if(val_79 >= this.realPoints.Count)
        {
            goto label_73;
        }
        
        UnityEngine.Vector3 val_37 = this.realPoints.Item[1];
        val_68 = val_37.x;
        val_64 = val_37.z;
        UnityEngine.Color val_38 = UnityEngine.Color.yellow;
        val_69 = val_38.g;
        val_73 = val_38.a;
        int val_40 = (this.particles + (this.nextParticleIndex * val_60)) + 32;
        val_65 = val_68;
        val_72 = val_37.y;
        val_70 = val_64;
        val_71 = val_38.r;
        this.SetParticleOn(particle: ref  new Particle() {m_Position = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_Velocity = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_AnimatedVelocity = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_InitialVelocity = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_AxisOfRotation = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_Rotation = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_AngularVelocity = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_StartSize = new UnityEngine.Vector3() {x = val_40, y = val_40, z = val_40}, m_StartColor = new UnityEngine.Color32() {r = val_40, g = val_40, b = val_40, a = val_40}, m_RandomSeed = val_40, m_Lifetime = val_40, m_StartLifetime = val_40, m_EmitAccumulator0 = val_40, m_EmitAccumulator1 = val_40, m_Flags = val_40}, position:  new UnityEngine.Vector3() {x = val_65, y = val_72, z = val_70}, color:  new UnityEngine.Color() {r = val_71, g = val_69, b = val_38.b, a = val_73});
        int val_41 = this.nextParticleIndex + 1;
        this.nextParticleIndex = val_41;
        if(val_41 < this.config.maxPointsToShow)
        {
            goto label_78;
        }
        
        if(this.config.showCurrentOnly == false)
        {
            goto label_80;
        }
        
        label_73:
        val_74 = 0;
        goto label_81;
        label_90:
        this.nextParticleIndex = 0;
        label_88:
        val_74 = 1;
        label_81:
        if(val_74 >= this.fakePoints.Count)
        {
            goto label_83;
        }
        
        UnityEngine.Vector3 val_43 = this.fakePoints.Item[1];
        val_68 = val_43.x;
        val_64 = val_43.z;
        UnityEngine.Color val_44 = UnityEngine.Color.green;
        val_69 = val_44.g;
        val_73 = val_44.a;
        int val_46 = (this.particles + (this.nextParticleIndex * val_60)) + 32;
        val_65 = val_68;
        val_72 = val_43.y;
        val_70 = val_64;
        val_71 = val_44.r;
        this.SetParticleOn(particle: ref  new Particle() {m_Position = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_Velocity = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_AnimatedVelocity = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_InitialVelocity = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_AxisOfRotation = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_Rotation = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_AngularVelocity = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_StartSize = new UnityEngine.Vector3() {x = val_46, y = val_46, z = val_46}, m_StartColor = new UnityEngine.Color32() {r = val_46, g = val_46, b = val_46, a = val_46}, m_RandomSeed = val_46, m_Lifetime = val_46, m_StartLifetime = val_46, m_EmitAccumulator0 = val_46, m_EmitAccumulator1 = val_46, m_Flags = val_46}, position:  new UnityEngine.Vector3() {x = val_65, y = val_72, z = val_70}, color:  new UnityEngine.Color() {r = val_71, g = val_69, b = val_44.b, a = val_73});
        int val_47 = this.nextParticleIndex + 1;
        this.nextParticleIndex = val_47;
        if(val_47 < this.config.maxPointsToShow)
        {
            goto label_88;
        }
        
        if(this.config.showCurrentOnly == false)
        {
            goto label_90;
        }
        
        label_83:
        val_80 = 0;
        goto label_91;
        label_100:
        this.nextParticleIndex = 0;
        label_98:
        val_80 = 1;
        label_91:
        val_81 = 0;
        if(val_81 == 0)
        {
                val_81 = 0;
        }
        
        if(val_80 >= val_81.Count)
        {
            goto label_93;
        }
        
        val_82 = 0;
        if(val_82 == 0)
        {
                val_82 = 0;
        }
        
        UnityEngine.Vector3 val_49 = val_82.Item[1];
        val_68 = val_49.x;
        val_64 = val_49.z;
        UnityEngine.Color val_50 = UnityEngine.Color.red;
        val_69 = val_50.g;
        val_73 = val_50.a;
        int val_52 = (this.particles + (this.nextParticleIndex * val_60)) + 32;
        this.SetParticleOn(particle: ref  new Particle() {m_Position = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_Velocity = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_AnimatedVelocity = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_InitialVelocity = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_AxisOfRotation = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_Rotation = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_AngularVelocity = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_StartSize = new UnityEngine.Vector3() {x = val_52, y = val_52, z = val_52}, m_StartColor = new UnityEngine.Color32() {r = val_52, g = val_52, b = val_52, a = val_52}, m_RandomSeed = val_52, m_Lifetime = val_52, m_StartLifetime = val_52, m_EmitAccumulator0 = val_52, m_EmitAccumulator1 = val_52, m_Flags = val_52}, position:  new UnityEngine.Vector3() {x = val_68, y = val_49.y, z = val_64}, color:  new UnityEngine.Color() {r = val_50.r, g = val_69, b = val_50.b, a = val_73});
        int val_53 = this.nextParticleIndex + 1;
        this.nextParticleIndex = val_53;
        if(val_53 < this.config.maxPointsToShow)
        {
            goto label_98;
        }
        
        if(this.config.showCurrentOnly == false)
        {
            goto label_100;
        }
        
        label_93:
        val_83 = this.nextParticleIndex;
        goto label_101;
        label_105:
        Particle val_55 = (this.particles + ((long)val_83 * val_60)) + 32;
        this.SetParticleOff(particle: ref  new Particle() {m_Position = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_Velocity = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_AnimatedVelocity = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_InitialVelocity = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_AxisOfRotation = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_Rotation = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_AngularVelocity = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_StartSize = new UnityEngine.Vector3() {x = val_55, y = val_55, z = val_55}, m_StartColor = new UnityEngine.Color32() {r = val_55, g = val_55, b = val_55, a = val_55}, m_RandomSeed = val_55, m_Lifetime = val_55, m_StartLifetime = val_55, m_EmitAccumulator0 = val_55, m_EmitAccumulator1 = val_55, m_Flags = val_55});
        val_83 = val_83 + 1;
        label_101:
        val_58 = this.config;
        if(val_83 < this.config.maxPointsToShow)
        {
            goto label_105;
        }
        
        this.RefreshParticles();
        label_68:
        var val_66 = 0;
        val_66 = val_66 + 1;
        if(val_66 != val_59)
        {
            goto label_106;
        }
        
        label_11:
        this.realPoints.AddRange(collection:  this.fakePoints);
        return (UnityEngine.Vector3[])this.realPoints.ToArray();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FeaturePointModifier()
    {
        this.realPoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.fakePoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
    }

}
